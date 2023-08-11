using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
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

namespace BOSERP.Modules.AssetIncreasing
{
    public class AssetIncreasingModule : BaseTransactionModule
    {
        #region Constants
        public const string ReceiptItemGridControlName = "fld_dgcReceiptItems";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string ProductControlName = "fld_lkeFK_ICProductID";
        #endregion
        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit ProductLookUpEdit;
        public BOSGridControl ReceiptItemGridControl;
        #endregion
        public AssetIncreasingModule()
        {
            Name = ModuleName.AssetIncreasing;
            CurrentModuleEntity = new AssetIncreasingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[AssetIncreasingModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            ProductLookUpEdit = (BOSLookupEdit)Controls[ProductControlName];
            ProductLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductLookUpEdit_QueryPopUp);

            ReceiptItemGridControl = (BOSGridControl)Controls[ReceiptItemGridControlName];

        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    query += string.Format(" and ICReceiptTypeCombo = '{0}'", ReceiptType.EquipmentReceipt.ToString());
        //    return query;
        //}

        void ProductLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetProductForAssetIncreasing();
            ProductLookUpEdit.Properties.DataSource = productList;
        }

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
                                                            ReceiptType.AssetIncreasing.ToString(),
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
                                                            ReceiptType.AssetIncreasing.ToString(),
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
        #region Local
        public void AddItemToReceiptItemList()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ModuleObjects[TableName.ICReceiptItemsTableName];
            if (objReceiptItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(objReceiptItemsInfo.FK_ICProductID);
                entity.ReceiptItemList.AddObjectToList();
                UpdateTotalCost();
            }
        }
        public void ChangeItemFromReceiptItemList()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ModuleObjects[TableName.ICReceiptItemsTableName];
            entity.SetProductCostByProductUnitCost();
            entity.ReceiptItemList.ChangeObjectFromList();
            UpdateTotalCost();
        }

        public void DeleteItemFromReceiptItemList()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            entity.ReceiptItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalCost();
        }

        public void ChangeDiscountPercent()
        {
            UpdateTotalCost();
        }

        public void ChangeDiscountAmount()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (objReceiptsInfo.ICReceiptSubTotalCost > 0)
                objReceiptsInfo.ICReceiptDiscountPerCent = objReceiptsInfo.ICReceiptDiscountFix / objReceiptsInfo.ICReceiptSubTotalCost * 100;
            UpdateTotalCost();
        }

        public void ChangeTaxPercent()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            UpdateTotalCost();
        }

        public void ChangeTaxAmount()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
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
                AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                objReceiptsInfo.ICReceiptSubTotalCost = 0;
                foreach (ICReceiptItemsInfo entItem in entity.ReceiptItemList)
                {
                    //TNDLoc [ADD][27/09/2016][Round by currency],START
                    BOSApp.RoundByCurrency(entItem, objReceiptsInfo.FK_GECurrencyID);
                    //TNDLoc [ADD][27/09/2016][Round by currency],END
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
                //TNDLoc [ADD][27/09/2016][Round by currency],START
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptSubTotalCost", objReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptDiscountFix", objReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptTotalCost", objReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptTaxAmount", objReceiptsInfo.FK_GECurrencyID);
                //TNDLoc [ADD][27/09/2016][Round by currency],END
                entity.ReceiptItemList.GridControl.RefreshDataSource();
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
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            decimal extCost = entity.ReceiptItemList.Sum(i => i.ICReceiptItemExtCost);
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemList)
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
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.FK_APSupplierID = supplierID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                SetDefaultValuesFromSupplier();
            }
        }
        #endregion

        public override int ActionSave()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
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

            entity.ReceiptItemList.EndCurrentEdit();
            UpdateTotalCost();
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemList)
            {
                if (item.ICReceiptItemProductSerialNo.Equals(string.Empty))
                    GeneralSeriesForIngredientPackaging(item);
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
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.ICReceiptPackNo = entity.GetProductLotNo();
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
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ReceiptItemList.Count > 0)
                {
                    if (MessageBox.Show(AssetIncreasingLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICReceiptItemsInfo item in entity.ReceiptItemList)
                        {
                            item.FK_ICStockID = stockID;
                        }
                        entity.ReceiptItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NhapKhoTaiSan.ToString(),
                                                                        AccEntryType.NhapKhoTaiSan.ToString());

            Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>>();
            List<int> productAccountID = new List<int>();

            if (entity.ReceiptItemList != null)
            {
                foreach (ICReceiptItemsInfo receiptItem in entity.ReceiptItemList)
                {
                    ICProductsInfo product = productController.GetObjectByID(receiptItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.NhapKhoTaiSan.ToString()
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

                    //TNDLoc [ADD][27/09/2016][Round by currency],START
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objReceiptsInfo.FK_GECurrencyID);
                    //TNDLoc [ADD][27/09/2016][Round by currency],END

                    item = entry;
                }


                ACDocumentsInfo objDocumentsInfo = entity.DocumentList.FirstOrDefault(d => d.ACDocumentTypeName == AccDocumentType.NhapKhoTaiSan.ToString());
                if (objDocumentsInfo == null)
                {
                    objDocumentsInfo = new ACDocumentsInfo();
                    objDocumentsInfo.FK_ACDocumentTypeID = item.FK_ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = item.ACDocumentTypeName;
                    entity.DocumentList.Add(objDocumentsInfo);
                }
            }

            //remove the redundance document entries 
            List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.NhapKhoTaiSan.ToString()
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACDebitAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }


            //foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            //{
            //    if (entry.ACEntryTypeName == AccEntryType.NhapCCDC.ToString())
            //    {                    
            //        entry.ACDocumentEntryAmount = entity.ReceiptItemList.Sum(i => i.ICReceiptItemInventoryCost * i.ICReceiptItemProductQty);
            //        entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
            //    }
            //    else if (entry.ACEntryTypeName == AccEntryType.ThueGTGTDuocKhauTru.ToString())
            //    {
            //        entry.ACDocumentEntryAmount = entity.ReceiptItemList.Sum(i => i.ICReceiptItemTaxAmount) + objReceiptsInfo.ICReceiptTaxAmount;
            //        entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
            //    }
            //}
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ResetModelDetail(ICReceiptItemsInfo item)
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
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
            entity.ReceiptItemList.GridControl.RefreshDataSource();
        }
        public void ApproveAssetIncreasing()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
                foreach (ICReceiptItemsInfo item in entity.ReceiptItemList)
                {
                    if (string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
                    {
                        MessageBox.Show(string.Format(AssetIncreasingLocalizedResources.SerieNoIsRequiredMessage, item.ICReceiptItemProductName),
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }

                entity.ReceiptItemList.EndCurrentEdit();
                UpdateTotalCost();

                //int receiptID = 0;
                if (entity.ReceiptItemList.IsInvalidInventory(TransactionUtil.cstInventoryReceipt))
                {
                    return;
                }
                ActionComplete();
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
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            ICReceiptItemsInfo itemdump = entity.ReceiptItemList.Where(x => x.FK_ICProductID == productId && (x.FK_ICModelID + "-" + x.FK_ICModelDetailID).Equals(Key)).First();
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
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
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
                    if (GetSTTInListCurrent(entity.ReceiptItemList, item.FK_ICProductID, item.ICReceiptItemProductDesc) == 0)
                    {
                        STT++;
                    }
                    else
                    {
                        STT = GetSTTInListCurrent(entity.ReceiptItemList, item.FK_ICProductID, item.ICReceiptItemProductDesc) + 1;
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


            entity.ReceiptItemList.GridControl.RefreshDataSource();


        }
        public override void InvalidateToolbar()
        {

            base.InvalidateToolbar();
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

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

        public void ChangeCurrency(int currencyID)
        {
            AssetIncreasingEntities entity = (AssetIncreasingEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objReceiptsInfo.FK_GECurrencyID, objReceiptsInfo.ICReceiptDate);
            objReceiptsInfo.ICReceiptExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            UpdateTotalCost();
        }
    }
}
