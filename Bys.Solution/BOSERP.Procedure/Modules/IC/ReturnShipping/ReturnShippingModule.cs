using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ReturnShipping
{
    public class ReturnShippingModule : GLReceiptModule
    {
        #region Constants

        public const string ReceiptItemsGridControlName = "fld_dgcReceiptItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "ReturnShipping";

        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntry";
        #endregion

        #region Public properties

        public ReceiptItemsGridControl ReceiptItemsGridControl;

        #endregion

        private bool IsEditAfterCompleting = false;
        #region Public properties

        #endregion
        public ReturnShippingModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new ReturnShippingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ReceiptItemsGridControl = (ReceiptItemsGridControl)Controls[ReceiptItemsGridControlName];

            StartGettingInventoryThread();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptsInfo searchObject = (ICReceiptsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;

            ds = objReceiptsController.GetReturnShippingListByBranchID(
                                                                searchObject.ICReceiptNo,
                                                                searchObject.ICReceiptName,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.ReceiptDateFrom,
                                                                searchObject.ReceiptDateTo,
                                                                searchObject.FK_BRBranchID);

            return ds;
        }

        public override void InvalidateToolbar()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            if (objReceiptsInfo.ICReceiptID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objReceiptsInfo.ICReceiptStatus == ReceiptStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void ActionNew()
        {
            base.ActionNew();

            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemController.GetAllShipmentItemsByICShipmentCompletedAndNotExitsInvoiceItemsByIsDelivery();

            guiFind<ICShipmentItemsInfo> guiShipmentItems = new guiFind<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName,
                                                                shipmentItems, this, true, true, new string[] { "ICShipmentNo" });
            if (guiShipmentItems.ShowDialog() != DialogResult.OK)
                return;

            List<ICShipmentItemsInfo> results = (List<ICShipmentItemsInfo>)guiShipmentItems.SelectedObjects;
            List<int> shipmentID = results.Select(o => o.FK_ICShipmentID).Distinct().ToList();
            if (shipmentID.Count > 1)
            {
                MessageBox.Show(ReturnShippingLocalizedResources.ChooseMultiShipmentMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (results.Count == 0) return;

            //Generate entities from Shipment

            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)objShipmentsController.GetObjectByID(shipmentID[0]);
            if (objShipmentsInfo != null)
            {
                objReceiptsInfo.FK_ACObjectID = objShipmentsInfo.FK_ACObjectID;
                objReceiptsInfo.ICObjectType = objShipmentsInfo.ICObjectType;
                objReceiptsInfo.ACObjectAccessKey = string.Join(";", new string[] { objReceiptsInfo.FK_ACObjectID.ToString(), objReceiptsInfo.ICObjectType });
                objReceiptsInfo.FK_GECurrencyID = objShipmentsInfo.FK_GECurrencyID;
                objReceiptsInfo.ICReceiptExchangeRate = objShipmentsInfo.ICShipmentExchangeRate;
                objReceiptsInfo.FK_ARSaleContractID = objShipmentsInfo.FK_ARSaleContractID;
                objReceiptsInfo.FK_ACCostCenterID = objShipmentsInfo.FK_ACCostCenterID;
                objReceiptsInfo.FK_PMProjectID = objShipmentsInfo.FK_PMProjectID;
                objReceiptsInfo.ICShipmentNo = objShipmentsInfo.ICShipmentNo;
                objReceiptsInfo.ICReceiptProject = objShipmentsInfo.ICShipmentProject;
                objReceiptsInfo.ICReceiptSaleContract = objShipmentsInfo.ICShipmentSaleContract;
            }

            ICShipmentItemsInfo objShipmentItemsInfo = results.FirstOrDefault();
            if (objShipmentItemsInfo != null)
            {
                objReceiptsInfo.FK_ARSaleOrderID = objShipmentItemsInfo.FK_ARSaleOrderID;
            }
            entity.GenerateEntitiesFromShipment(results);
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public override int ActionSave()
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;

            List<string> productErrNames = entity.ReceiptItemsList.Where(p => string.IsNullOrWhiteSpace(p.ICReceiptItemReturnShippingType))?.Select(p => p.ICReceiptItemProductDesc)?.ToList();
            if (productErrNames != null && productErrNames.Count > 0)
            {
                MessageBox.Show(string.Format("Các sản phẩm sau chưa chọn Loại nhập đổi trả:" + Environment.NewLine + "{0}", string.Join(Environment.NewLine, productErrNames.ToArray())),
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return 0;
            }
            ICReceiptsController objSaleReturnsController = new ICReceiptsController();
            ICReceiptsInfo refSaleReturnsInfo = (ICReceiptsInfo)objSaleReturnsController.GetObjectByID(objReceiptsInfo.ICReceiptID);
            if (refSaleReturnsInfo != null && refSaleReturnsInfo.ICReceiptStatus != ReceiptStatus.New.ToString())
            {
                MessageBox.Show("Đơn này đã hoàn tất. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            entity.ReceiptItemsList.EndCurrentEdit();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            foreach (ICReceiptItemsInfo objReceiptItemsInfo in entity.ReceiptItemsList)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemController.GetObjectByID(objReceiptItemsInfo.FK_ICShipmentItemID);
                decimal availableReturnQty = objShipmentItemsInfo == null ? 0 : objShipmentItemsInfo.ICShipmentItemProductQty;
                if (objShipmentItemsInfo != null && objReceiptItemsInfo.ICReceiptItemProductQty > availableReturnQty)
                {
                    MessageBox.Show(string.Format(ReturnShippingLocalizedResources.ReturnQtyLargerRemainQtyMessage, objReceiptItemsInfo.ICReceiptItemProductDesc),
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    if (objReceiptItemsInfo.ICReceiptItemReturnShippingType == ReturnShippingType.ReplaceDifferenceProduct.ToString()
                        && objReceiptItemsInfo.FK_ICReplaceProductID == 0)
                    {
                        MessageBox.Show(ReturnShippingLocalizedResources.PleaseChooseReplaceProduct,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        return 0;
                    }
                }
            }

            return base.ActionSave();
        }
        public override bool ActionComplete()
        {
            //Check the serie no is mandatory
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsController objSaleReturnsController = new ICReceiptsController();
            ICReceiptsInfo refSaleReturnsInfo = (ICReceiptsInfo)objSaleReturnsController.GetObjectByID(objReceiptsInfo.ICReceiptID);
            if (refSaleReturnsInfo != null && refSaleReturnsInfo.ICReceiptStatus != ReceiptStatus.New.ToString())
            {
                MessageBox.Show("Đơn này đã hoàn tất. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (ICReceiptItemsInfo objReceiptItemsInfo in entity.ReceiptItemsList)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemController.GetObjectByID(objReceiptItemsInfo.FK_ICShipmentItemID);
                decimal availableReturnQty = objShipmentItemsInfo.ICShipmentItemProductQty;
                if (objShipmentItemsInfo != null && objReceiptItemsInfo.ICReceiptItemProductQty > availableReturnQty)
                {
                    MessageBox.Show(string.Format(ReturnShippingLocalizedResources.ReturnQtyLargerRemainQtyMessage, objReceiptItemsInfo.ICReceiptItemProductDesc),
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (ICReceiptItemsInfo objReceiptItemsInfo in entity.ComponentReceiptItemsList)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (string.IsNullOrEmpty(objReceiptItemsInfo.ICReceiptItemProductSerialNo)
                        && objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString()
                        && !objReceiptItemsInfo.ICReceiptItemIsAverageCalculation)
                    {
                        MessageBox.Show(string.Format(ReturnShippingLocalizedResources.SerieNoIsRequiredMessage, objReceiptItemsInfo.ICReceiptItemProductDesc),
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return base.ActionComplete();
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPReturnShipping report = new RPReturnShipping();
                //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
                InitReceiptReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        private void InitReceiptReport(RPReturnShipping report, int receiptID)
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = new BRBranchsInfo();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(receiptID);
            List<ICReceiptItemsInfo> listReceiptItems = objReceiptItemsController.GetItemsByReceiptID(receiptID);
            ACAccountsController objAccountsController = new ACAccountsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            report.GECurrencyName = objReceiptsInfo.FK_GECurrencyID == GECurrencyID.VND ? "VND" : "USD";
            if (objReceiptsInfo != null)
            {
                objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(objReceiptsInfo.FK_BRBranchID);
                objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objReceiptsInfo.FK_ACObjectID, objReceiptsInfo.ICObjectType);
            }
            //decimal ReceiptTotalCost = listReceiptItems.Sum(p => p.ICReceiptItemTotalCost);
            //objReceiptsInfo.ICReceiptDiscountFix = ReceiptTotalCost * objReceiptsInfo.ICReceiptDiscountPerCent;
            //objReceiptsInfo.ICReceiptTaxAmount = (ReceiptTotalCost - objReceiptsInfo.ICReceiptDiscountFix) * objReceiptsInfo.ICReceiptTaxPercent;
            //objReceiptsInfo.ICReceiptTotalCost = ReceiptTotalCost - objReceiptsInfo.ICReceiptDiscountFix + objReceiptsInfo.ICReceiptTaxAmount;
            //objReceiptsInfo.TotalAmountWord = ConvertAmountToWord.ReadAmount(objReceiptsInfo.ICReceiptTotalCost.ToString(), objReceiptsInfo.FK_GECurrencyID);
            decimal ReceiptTotalAmount = listReceiptItems.Sum(p => p.ICReceiptItemTotalAmount);
            objReceiptsInfo.ICReceiptDiscountFix = ReceiptTotalAmount * objReceiptsInfo.ICReceiptDiscountPerCent;
            objReceiptsInfo.ICReceiptTaxAmount = (ReceiptTotalAmount - objReceiptsInfo.ICReceiptDiscountFix) * objReceiptsInfo.ICReceiptTaxPercent;
            objReceiptsInfo.ICReceiptTotalCost = ReceiptTotalAmount - objReceiptsInfo.ICReceiptDiscountFix + objReceiptsInfo.ICReceiptTaxAmount;
            objReceiptsInfo.TotalAmountWord = ConvertAmountToWord.ReadAmount(objReceiptsInfo.ICReceiptTotalCost.ToString(), objReceiptsInfo.FK_GECurrencyID);
            int shipmentID = listReceiptItems.Where(p => p.FK_ICShipmentID != 0).Select(p => p.FK_ICShipmentID).FirstOrDefault();
            if (shipmentID > 0)
            {
                objShipmentsInfo = (ICShipmentsInfo)objShipmentsController.GetObjectByID(shipmentID);
                objReceiptsInfo.ICShipmentDate = objShipmentsInfo.ICShipmentDate;
                objReceiptsInfo.ICShipmentNo = objShipmentsInfo.ICShipmentNo;
            }
            foreach (ACDocumentEntrysInfo documentEntry in entity.DocumentEntryList)
                if (documentEntry.ACDocumentEntryAmount != 0)
                {
                    XRLabel label1 = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xrLbNo"];
                    objReceiptsInfo.DebitAccountNo += objAccountsController.GetObjectNoByID(documentEntry.FK_ACDebitAccountID) + " ";
                    objReceiptsInfo.CreditAccountNo += objAccountsController.GetObjectNoByID(documentEntry.FK_ACCreditAccountID) + " ";
                }
            foreach (ICReceiptItemsInfo receiptItem in listReceiptItems)
            {
                receiptItem.ICReceiptItemComment = String.Empty;
                receiptItem.ICReceiptItemComment += receiptItem.ICReceiptItemProductDiscount > 0 ?
                        string.Format(" {0}: {1}%;", SaleReturnLocalizedResources.Discount, BOSUtil.GetNumberDisplayFormat(receiptItem.ICReceiptItemProductDiscount, FormatGroupAttribute.cstFormatGroupPercent))
                        : String.Empty;
                receiptItem.ICReceiptItemComment += receiptItem.ICReceiptItemProductTaxPercent > 0 ?
                        string.Format(" {0}: {1}%;", SaleReturnLocalizedResources.VAT, BOSUtil.GetNumberDisplayFormat(receiptItem.ICReceiptItemProductTaxPercent, FormatGroupAttribute.cstFormatGroupPercent))
                        : String.Empty;
                receiptItem.ICReceiptItemProductDesc += string.Format(" {0} / {1}", receiptItem.ICReceiptItemProductSerialNo, receiptItem.ICReceiptItemProductSupplierNo);
            }
            report.bsReceiptsInfo.DataSource = objReceiptsInfo;
            report.bsReceiptItemsInfo.DataSource = listReceiptItems;
            report.bsBranchsInfo.DataSource = objBranchsInfo;
            report.bsObjectsInfo.DataSource = objObjectsInfo;
            report.bsEmployeesInfo.DataSource = objEmployeesInfo;
        }

        public void DeleteItemFromReturnShippingItemsList()
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            entity.ReceiptItemsList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void CheckReturnShippingItemProductQtyReturn(ICReceiptItemsInfo objReceiptItemsInfo)
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            if (objReceiptItemsInfo.ICReceiptItemProductQty > objReceiptItemsInfo.ICReceiptItemProductQtyOld)
            {
                MessageBox.Show(string.Format(ReturnShippingLocalizedResources.ReturnQtyLargerRemainQtyMessage, objReceiptItemsInfo.ICReceiptItemProductDesc),
                    CommonLocalizedResources.MessageBoxDefaultCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemProductQtyOld;
            }
            entity.SetProductPriceByProductUnitPrice(objReceiptItemsInfo);
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        protected override void UpdateDocumentEntries()
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string accDocumentType = AccDocumentType.NhapDoiTra.ToString();

            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        accDocumentType,
                                                                        AccEntryType.NhapDoiTra.ToString());

            //get stock list
            ICStocksController stockController = new ICStocksController();
            List<ICStocksInfo> stocks = null;
            if (BOSApp.LookupTables.ContainsKey(TableName.ICStocksTableName))
            {
                DataSet ds = BOSApp.LookupTables[TableName.ICStocksTableName] as DataSet;
                stocks = stockController.GetListFromDataSet(ds) as List<ICStocksInfo>;
            }
            if (stocks == null || stocks.Count == 0)
            {
                DataSet ds = stockController.GetAllObjects();
                stocks = stockController.GetListFromDataSet(ds) as List<ICStocksInfo>;
            }

            if (entity.ReceiptItemsList != null)
            {
                foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                {
                    SetitemAccountID(item, defaultEntry, stocks);
                }
            }
        }

        private void SetitemAccountID(ICReceiptItemsInfo returnShippingItem, ACDocTypeEntrysInfo defaultEntry, List<ICStocksInfo> stocks)
        {
            if (returnShippingItem == null)
                return;

            ICStocksInfo stock = null;
            ICProductsForViewInfo product = null;

            if (stocks != null)
                stock = stocks.FirstOrDefault(item => item.ICStockID == returnShippingItem.FK_ICStockID);

            if (BOSApp.CurrentProductList != null)
                product = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == returnShippingItem.FK_ICProductID);

            if (stock != null && stock.FK_ACAccountID != 0)
                returnShippingItem.FK_ACAccountID = stock.FK_ACAccountID;
            else if (product != null && product.FK_ACAccountID != 0)
                returnShippingItem.FK_ACAccountID = product.FK_ACAccountID;
            else if (defaultEntry != null)
                returnShippingItem.FK_ACAccountID = defaultEntry.ACDocTypeEntryAccountDefaultDebit;
            else
                returnShippingItem.FK_ACAccountID = 0;
        }

        public void ChangeProductSerialNo(ICReceiptItemsInfo objReceiptItemsInfo)
        {
            ReturnShippingEntities entity = (ReturnShippingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            objReceiptItemsInfo.ICReceiptItemProductUnitCost = AccountHelper.GetProductUnitCost(objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo.ICReceiptItemProductSerialNo, objReceiptsInfo.ICReceiptDate) * objReceiptItemsInfo.ICReceiptItemProductFactor;
            entity.SetProductPriceByProductUnitPrice(objReceiptItemsInfo);
            BOSApp.RoundByCurrency(objReceiptItemsInfo, objReceiptsInfo.FK_GECurrencyID);
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
        }

        public override void ModuleAfterCompleted()
        {
            base.ModuleAfterCompleted();
            ICReceiptsInfo mainObject = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            objReceiptsController.UpdateReferenceDocumentByReturnShippingID(mainObject.ICReceiptID);
        }
    }
}
