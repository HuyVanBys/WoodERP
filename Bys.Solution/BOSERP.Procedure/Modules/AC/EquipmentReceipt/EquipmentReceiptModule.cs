using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
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

namespace BOSERP.Modules.EquipmentReceipt
{
    public class EquipmentReceiptModule : GLReceiptModule
    {
        #region Constants
        public const string ReceiptItemGridControlName = "fld_dgcReceiptItems";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string CCDCLookupEditControlName = "fld_lkeFK_ICProductID";

        #endregion
        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit CCDCLookupEditControl;
        public List<ICProductsInfo> CCDCList;

        #endregion
        public EquipmentReceiptModule()
        {
            Name = ModuleName.EquipmentReceipt;
            CurrentModuleEntity = new EquipmentReceiptEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[EquipmentReceiptModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    query += string.Format(" and ICReceiptTypeCombo = '{0}'", ReceiptType.EquipmentReceipt.ToString());
        //    return query;
        //}
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptsInfo searchObject = (ICReceiptsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objReceiptsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objReceiptsController.GetEquipmentReceiptListByListOfBranchID(searchObject.ICReceiptNo,
                                                            searchObject.ICReceiptInvoiceInNo,
                                                            searchObject.FK_APSupplierID,
                                                            searchObject.FK_HREmployeeID,
                                                            ReceiptType.EquipmentReceipt.ToString(),
                                                            searchObject.ReceiptDateFrom,
                                                            searchObject.ReceiptDateTo,
                                                            BranchList);
                }
            }
            else
            {
                ds = objReceiptsController.GetEquipmentReceiptList(searchObject.ICReceiptNo,
                                                            searchObject.ICReceiptInvoiceInNo,
                                                            searchObject.FK_APSupplierID,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.FK_HREmployeeID,
                                                            ReceiptType.EquipmentReceipt.ToString(),
                                                            searchObject.ReceiptDateFrom,
                                                            searchObject.ReceiptDateTo);
            }

            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public void GetCCDCList()
        {
            ICProductsController objProductController = new ICProductsController();
            CCDCList = (List<ICProductsInfo>)objProductController.GetListFromDataSet(objProductController.GetProductListByDepreciationMonthAndIdentifiedEquipments(null, null, null));
        }
        #region Local
        public void AddItemToReceiptItemList()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ModuleObjects[TableName.ICReceiptItemsTableName];
            if (objReceiptItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(objReceiptItemsInfo.FK_ICProductID);
                entity.ReceiptItemsList.AddObjectToList();
                UpdateTotalCost();
            }
        }

        public void ChangeItemFromReceiptItemList()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ModuleObjects[TableName.ICReceiptItemsTableName];
            entity.SetProductCostByProductUnitCost();
            entity.ReceiptItemsList.ChangeObjectFromList();
            UpdateTotalCost();
        }
        public void ChangeItemFromReceiptItemListCost()
        {
            UpdateDocumentEntries();
        }

        public void DeleteItemFromReceiptItemList()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            entity.ReceiptItemsList.RemoveSelectedRowObjectFromList();
            UpdateTotalCost();
        }

        public void ChangeDiscountPercent()
        {
            UpdateTotalCost();
        }

        public void ChangeDiscountAmount()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (objReceiptsInfo.ICReceiptSubTotalCost > 0)
                objReceiptsInfo.ICReceiptDiscountPerCent = objReceiptsInfo.ICReceiptDiscountFix / objReceiptsInfo.ICReceiptSubTotalCost * 100;
            UpdateTotalCost();
        }

        public void ChangeTaxPercent()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            UpdateTotalCost();
        }

        public void ChangeTaxAmount()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            decimal subTotalCost = objReceiptsInfo.ICReceiptSubTotalCost -
                                    objReceiptsInfo.ICReceiptDiscountFix +
                                    objReceiptsInfo.ICReceiptShippingFees +
                                    objReceiptsInfo.ICReceiptShippingExtraFees;
            if (subTotalCost > 0)
                objReceiptsInfo.ICReceiptTaxPercent = objReceiptsInfo.ICReceiptTaxAmount / subTotalCost * 100;
            UpdateTotalCost();
        }

        public void ChangeFee()
        {
            UpdateTotalCost();
        }

        /// <summary>
        /// Update total costs of the purchase receipt
        /// </summary>
        public void UpdateTotalCost()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                objReceiptsInfo.ICReceiptSubTotalCost = 0;
                foreach (ICReceiptItemsInfo entItem in entity.ReceiptItemsList)
                {
                    BOSApp.RoundByCurrency(entItem, objReceiptsInfo.FK_GECurrencyID);
                    objReceiptsInfo.ICReceiptSubTotalCost += entItem.ICReceiptItemTotalCost;
                }
                objReceiptsInfo.ICReceiptDiscountFix = objReceiptsInfo.ICReceiptSubTotalCost * objReceiptsInfo.ICReceiptDiscountPerCent / 100;
                objReceiptsInfo.ICReceiptTaxAmount = (objReceiptsInfo.ICReceiptSubTotalCost -
                                                     objReceiptsInfo.ICReceiptDiscountFix +
                                                     objReceiptsInfo.ICReceiptShippingFees +
                                                     objReceiptsInfo.ICReceiptShippingExtraFees) * objReceiptsInfo.ICReceiptTaxPercent / 100;
                objReceiptsInfo.ICReceiptTotalCost = objReceiptsInfo.ICReceiptSubTotalCost +
                                                     objReceiptsInfo.ICReceiptTaxAmount +
                                                     objReceiptsInfo.ICReceiptShippingFees +
                                                     objReceiptsInfo.ICReceiptShippingExtraFees -
                                                     objReceiptsInfo.ICReceiptDiscountFix;

                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptSubTotalCost", objReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptDiscountFix", objReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptTaxAmount", objReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptTotalCost", objReceiptsInfo.FK_GECurrencyID);

                entity.ReceiptItemsList.GridControl.RefreshDataSource();

                entity.UpdateMainObjectBindingSource();
                UpdateInventoryCost();
                UpdateDocumentEntries();
            }
        }


        /// <summary>
        /// Update the inventory cost of all items
        /// </summary>
        private void UpdateInventoryCost()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            decimal extCost = entity.ReceiptItemsList.Sum(i => i.ICReceiptItemExtCost);
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
            {
                decimal inventoryCost = item.ICReceiptItemExtCost - item.ICReceiptItemDiscountAmount;
                if (extCost > 0)
                {
                    decimal factor = item.ICReceiptItemExtCost / extCost;
                    inventoryCost -= factor * objReceiptsInfo.ICReceiptDiscountFix;
                    inventoryCost += factor * objReceiptsInfo.ICReceiptShippingFees;
                    inventoryCost += factor * objReceiptsInfo.ICReceiptShippingExtraFees;
                }
                if (item.ICReceiptItemProductQty > 0)
                {
                    inventoryCost = inventoryCost / item.ICReceiptItemProductQty;
                }
                item.ICReceiptItemInventoryCost = inventoryCost;
            }
        }

        /// <summary>
        /// Called when the user changes the supplier
        /// </summary>
        /// <param name="supplierID">Target supplier id</param>
        public void ChangeSupplier(int supplierID)
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.FK_APSupplierID = supplierID;
            if (supplierID > 0)
            {
                APSuppliersController objSuppliersController = new APSuppliersController();
                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierID);
                if (objSuppliersInfo != null)
                {
                    objReceiptsInfo.ICReceiptSupplerTaxNumber = objSuppliersInfo.APSupplierTaxNumber;
                    objReceiptsInfo.ICReceiptSupplierAddress = objSuppliersInfo.APSupplierContactAddressLine1;
                }
            }
            if (!Toolbar.IsNullOrNoneAction())
            {
                SetDefaultValuesFromSupplier();
            }
            entity.UpdateMainObjectBindingSource();
        }
        #endregion

        public override int ActionSave()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            //foreach (ICReceiptItemsInfo item in entity.ReceiptItemList)
            //{
            //    if (string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
            //    {
            //        MessageBox.Show(string.Format(EquipmentReceiptLocalizedResources.SerieNoIsRequiredMessage, item.ICReceiptItemProductName),
            //                        CommonLocalizedResources.MessageBoxDefaultCaption,
            //                        MessageBoxButtons.OK,
            //                        MessageBoxIcon.Error);
            //        return 0;
            //    }
            //}
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (objReceiptsInfo.FK_APSupplierID == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng nhà cung cấp.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            entity.ReceiptItemsList.EndCurrentEdit();
            UpdateTotalCost();
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
            {
                if (item.ICReceiptItemProductSerialNo.Equals(string.Empty))
                    GeneralSeriesForIngredientPackaging(item);
                if (!item.ICReceiptItemIsAverageCalculation)
                {
                    if (item.FK_ICStockID == 0)
                    {
                        MessageBox.Show("Chọn kho cho từng dòng dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return 0;
                    }
                }
            }
            int receiptID = 0;
            //if (!entity.ReceiptItemList.IsInvalidInventory(TransactionUtil.cstInventoryReceipt))
            //{
            receiptID = base.ActionSave();
            //}
            return receiptID;
        }
        public override void ActionNew()
        {

            base.ActionNew();
            GetCCDCList();
            CCDCLookupEditControl = (BOSLookupEdit)Controls[EquipmentReceiptModule.CCDCLookupEditControlName];
            CCDCLookupEditControl.Properties.DataSource = CCDCList;
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.ICReceiptPackNo = entity.GetProductLotNo();
        }
        public override void ActionEdit()
        {
            base.ActionEdit();
            GetCCDCList();
            CCDCLookupEditControl = (BOSLookupEdit)Controls[EquipmentReceiptModule.CCDCLookupEditControlName];
            CCDCLookupEditControl.Properties.DataSource = CCDCList;
        }

        /// <summary>
        /// Init receipt report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        private void InitReceiptReport(XtraReport report)
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ADReportsController objReportsController = new ADReportsController();
            report.DataSource = objReportsController.GetReceiptItemByReceiptID(objReceiptsInfo.ICReceiptID);
            report.DataMember = BOSCommon.Constants.Report.DevReceiptItemReportName;
        }

        /// <summary>
        /// Print receipt report
        /// </summary>
        public void PrintReceiptReport()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RPReceipt report = new RPReceipt();
                    //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
                    InitReceiptReport(report);
                    XtraReportHelper.PrintToPrinter(report, printDialog.PrinterSettings.PrinterName);
                }
            }
        }

        /// <summary>
        /// Preview receipt report before print
        /// </summary>
        public void PreviewReceiptReport()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                RPReceipt report = new RPReceipt();
                //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
                InitReceiptReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevReceiptItemReportPath, false);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Called when user wants to change stock
        /// </summary>
        /// <param name="stockID">Selected stock id</param>
        public void ChangeStock(int stockID)
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ReceiptItemsList.Count > 0)
                {
                    if (MessageBox.Show(EquipmentReceiptLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                        {
                            item.FK_ICStockID = stockID;
                        }
                        entity.ReceiptItemsList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NhapCCDC.ToString(),
                                                                        AccEntryType.NhapCCDC.ToString());

            Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>>();
            List<int> productAccountID = new List<int>();

            if (entity.ReceiptItemsList != null)
            {
                foreach (ICReceiptItemsInfo receiptItem in entity.ReceiptItemsList)
                {
                    ICProductsInfo product = productController.GetObjectByID(receiptItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.NhapCCDC.ToString()
                                                                        && e.FK_ACDebitAccountID == product.FK_ACAccountID);
                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                        entry.FK_ACDebitAccountID = product.FK_ACAccountID;
                    }
                    if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                    {
                        documentEntryAccounts.Add(entry, new List<ICReceiptItemsInfo>());
                        productAccountID.Add(entry.FK_ACDebitAccountID);
                    }
                    documentEntryAccounts[entry].Add(receiptItem);
                }
            }

            //update document entry amount
            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICReceiptItemInventoryCost * i.ICReceiptItemProductQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objReceiptsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);

                    item = entry;
                }


                ACDocumentsInfo objDocumentsInfo = entity.DocumentList.FirstOrDefault(d => d.ACDocumentTypeName == AccDocumentType.NhapCCDC.ToString());
                if (objDocumentsInfo == null)
                {
                    objDocumentsInfo = new ACDocumentsInfo();
                    objDocumentsInfo.FK_ACDocumentTypeID = item.FK_ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = item.ACDocumentTypeName;
                    entity.DocumentList.Add(objDocumentsInfo);
                }
            }

            //remove the redundance document entries 
            List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.NhapCCDC.ToString()
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACDebitAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }


            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.NhapCCDC.ToString())
                {
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objectsInfo = objObjectsController.GetObjectByIDAndType(objReceiptsInfo.FK_ACObjectID, objReceiptsInfo.ICObjectType);
                    if (objectsInfo != null && objectsInfo.FK_ACAccountPurchaseID > 0)
                        entry.FK_ACCreditAccountID = objectsInfo.FK_ACAccountPurchaseID;
                }
                else if (entry.ACEntryTypeName == AccEntryType.ThueGTGTDuocKhauTru.ToString())
                {
                    entry.ACDocumentEntryAmount = entity.ReceiptItemsList.Sum(i => i.ICReceiptItemTaxAmount) + objReceiptsInfo.ICReceiptTaxAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
                }
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ResetModelDetail(ICReceiptItemsInfo item)
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList.Count > 0)
            {
                item.FK_ICModelDetailID = ModelDetailsList.FirstOrDefault().ICModelDetailID;
            }
            else
            {
                item.FK_ICModelDetailID = 0;
            }
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
        }
        public void ApproveEquipmentReceipt()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
                foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                {
                    if (string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
                    {
                        MessageBox.Show(string.Format(EquipmentReceiptLocalizedResources.SerieNoIsRequiredMessage, item.ICReceiptItemProductName),
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }

                entity.ReceiptItemsList.EndCurrentEdit();
                UpdateTotalCost();
                ActionComplete();
                APPOPaymentTimeInvoiceInDetailsController detailController = new APPOPaymentTimeInvoiceInDetailsController();
                detailController.InsertDetailByEquimentReceiptNo(objReceiptsInfo.ICReceiptNo, ModuleName.EquipmentReceipt);
            }
        }
        public void ClearSerialNo(ICReceiptItemsInfo item)
        {
            item.ICReceiptItemProductSerialNo = string.Empty;
            GeneralSeriesForIngredientPackaging(item);
        }
        public string GetdumpSeriesNoInListCurrentForEquipment(int productId, int Model, int ModelDetail, ICReceiptItemsInfo item)
        {
            string packno = String.Empty;
            string Key = Model + "-" + ModelDetail;
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            ICReceiptItemsInfo itemdump = entity.ReceiptItemsList.Where(x => x.FK_ICProductID == productId && (x.FK_ICModelID + "-" + x.FK_ICModelDetailID).Equals(Key)).First();
            if (itemdump != null && itemdump != item)
                packno = itemdump.ICReceiptItemProductSerialNo;
            return packno;
        }
        public int GetSTTInListCurrent(List<ICReceiptItemsInfo> ListItem, int productID, string desc)
        {

            int max = 0;
            int temp = 0;
            List<ICReceiptItemsInfo> List = ListItem.Where(x => x.FK_ICProductID == productID).ToList();
            foreach (ICReceiptItemsInfo item in List)
            {
                string[] line = item.ICReceiptItemProductSerialNo.Split('.');
                if (line.Length > 1)
                    temp = Int32.Parse(line[1]);
                else
                    temp = 0;
                if (temp > max)
                    max = temp;
            }
            return max;
        }
        public void GeneralSeriesForIngredientPackaging(ICReceiptItemsInfo item)
        {
            int STT = 0;
            string PackNo = string.Empty;
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);

            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.Equipment.ToString())
            {
                PackNo = GetdumpSeriesNoInListCurrentForEquipment(item.FK_ICProductID, item.FK_ICModelID, item.FK_ICModelDetailID, item);
                if (PackNo.Equals(String.Empty))
                {
                    //item.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo + "." + STT;
                    if (GetSTTInListCurrent(entity.ReceiptItemsList, item.FK_ICProductID, item.ICReceiptItemProductDesc) == 0)
                    {
                        STT++;
                    }
                    else
                    {
                        STT = GetSTTInListCurrent(entity.ReceiptItemsList, item.FK_ICProductID, item.ICReceiptItemProductDesc) + 1;
                    }
                    item.ICReceiptItemProductSerialNo = objReceiptsInfo.ICReceiptPackNo + "." + STT;
                }
                else
                {
                    item.ICReceiptItemProductSerialNo = PackNo;
                }
            }
            else
            {
                item.ICReceiptItemProductSerialNo = objReceiptsInfo.ICReceiptPackNo;
            }


            entity.ReceiptItemsList.GridControl.RefreshDataSource();


        }
        public override void InvalidateToolbar()
        {

            base.InvalidateToolbar();
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            if (objReceiptsInfo.ICReceiptID > 0)
            {
                if (objReceiptsInfo.ICReceiptStatus == ReceiptStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                }
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            objReceiptsInfo.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objReceiptsInfo.FK_GECurrencyID, objReceiptsInfo.ICReceiptDate);
            objReceiptsInfo.ICReceiptExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            UpdateTotalCost();
        }
        public void ChangeACEInvoiceTypeNo(int invoiceID)
        {
            EquipmentReceiptEntities entity = (EquipmentReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(invoiceID);
            if (objEInvoiceTypesInfo != null)
            {
                objReceiptsInfo.ICReceiptVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objReceiptsInfo.ICReceiptSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            entity.UpdateMainObjectBindingSource();
        }
    }
}
