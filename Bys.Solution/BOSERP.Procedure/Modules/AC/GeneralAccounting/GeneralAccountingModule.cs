using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public class GeneralAccountingModule : BaseTransactionModule
    {
        #region Constants
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        public const string DocumentEntryGridControlName1 = "fld_dgcDocumentEntryGridControl";
        public const string DepreciationAssetTranTabPageName = "fld_tabPageACDepreciationAssetTrans";
        public const string AllocationEquipmentTranTabPageName = "fld_tabPageACAllocationEquipmentTrans";
        public const string AllocationCostObjectTranTabPageName = "fld_tabPageACAllocationCostObjectTrans";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string TabControlName = "fld_tabControl";
        public const string DocumentInvoiceDateEditControlName = "fld_dteACDocumentInvoiceDate";
        public const string DocumentPaymentDueDateEditControlName = "fld_dteACDocumentPaymentDueDate";
        public const string RefreshButtonName = "fld_btnRefresh";
        #endregion

        #region Variables
        private guiAdjustCostOfGoodsSoldWizard AdjustCostOfGoodsSoldWizard;
        private XtraTabPage PageDepreciationAssetTran;
        private XtraTabPage PageAllocationEquipmentTran;
        private XtraTabPage PageCostObjectTran;
        #endregion

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public BOSDateEdit DocumentInvoiceDateEditControl;
        public BOSDateEdit DocumentPaymentDueDateEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSButton RefreshButton;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSTabControl TabControl;
        #endregion

        public GeneralAccountingModule()
        {
            Name = ModuleName.GeneralAccounting;
            CurrentModuleEntity = new GeneralAccountingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            TabControl = (BOSTabControl)Controls[TabControlName];
            DocumentInvoiceDateEditControl = (BOSDateEdit)Controls[DocumentInvoiceDateEditControlName];
            DocumentPaymentDueDateEditControl = (BOSDateEdit)Controls[DocumentPaymentDueDateEditControlName];
            RefreshButton = (BOSButton)Controls[RefreshButtonName];
            PageDepreciationAssetTran = TabControl.TabPages.FirstOrDefault(t => t.Name == DepreciationAssetTranTabPageName);
            PageAllocationEquipmentTran = TabControl.TabPages.FirstOrDefault(t => t.Name == AllocationEquipmentTranTabPageName);
            PageCostObjectTran = TabControl.TabPages.FirstOrDefault(t => t.Name == AllocationCostObjectTranTabPageName);
        }

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

        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objDocumentsController.GetGeneralDocumentList(
            //                                                    searchObject.ACDocumentNo,
            //                                                    searchObject.FK_ACDocumentTypeID,
            //                                                    searchObject.FK_HREmployeeID,
            //                                                    searchObject.DocumentDateFrom,
            //                                                    searchObject.DocumentDateTo);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objDocumentsController.GetGeneralDocumentListByListOfBranchID(
                                                                searchObject.ACDocumentNo,
                                                                searchObject.FK_ACDocumentTypeID,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.DocumentDateFrom,
                                                                searchObject.DocumentDateTo,
                                                                searchObject.FK_BRBranchID,
                                                                BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetGeneralDocumentListByBranchID(
                                                                searchObject.ACDocumentNo,
                                                                searchObject.FK_ACDocumentTypeID,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.DocumentDateFrom,
                                                                searchObject.DocumentDateTo,
                                                                searchObject.FK_BRBranchID);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();
            DataSet ds = documentEntryController.GetAllDataByForeignColumn("FK_ACDocumentID", iObjectID);


            List<ACDocumentEntrysInfo> copiedList = new List<ACDocumentEntrysInfo>();
            if (ds != null && ds.Tables.Count != 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACDocumentEntrysInfo documentEntry = documentEntryController.GetObjectFromDataRow(row) as ACDocumentEntrysInfo;
                    copiedList.Add(documentEntry);
                }
            }
            if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
            {
                copiedList = documentEntryController.GetAccountingEntries(this.Name, 0, mainObject.ACDocumentNo);
            }

            ACObjectsController objObjectsController = new ACObjectsController();
            foreach (ACDocumentEntrysInfo item in copiedList)
            {
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(item.FK_ACObjectID, item.ACObjectType);
                if (objObjectsInfo != null)
                {
                    item.ACObjectNo = objObjectsInfo.ACObjectNo;
                    item.ACObjectName = objObjectsInfo.ACObjectName;
                }
            }

            entity.DocumentEntryList.Invalidate(copiedList);
            InvalidateAccountingEntries();
            //            
            InvalidateBriefDocumentEntrys(entity.DocumentEntryList);
            if (PageDepreciationAssetTran != null)
            {
                if (entity.DepreciationAssetTranList.Count() > 0)
                    PageDepreciationAssetTran.PageVisible = true;
                else
                    PageDepreciationAssetTran.PageVisible = false;
            }
            if (PageAllocationEquipmentTran != null)
            {
                if (entity.AllocationEquipmentTranList.Count() > 0)
                    PageAllocationEquipmentTran.PageVisible = true;
                else
                    PageAllocationEquipmentTran.PageVisible = false;
            }
            if (PageCostObjectTran != null)
            {
                if (entity.AllocationCostObjectTranList.Count() > 0)
                    PageCostObjectTran.PageVisible = true;
                else
                    PageCostObjectTran.PageVisible = false;
            }
            RefreshButton.Enabled = false;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                Document.DocumentModule.PrintDocument(Toolbar.CurrentObjectID);
            }
        }

        public void ActionAdjustCostOfGoodsSold()
        {
            ActionNew();

            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            AdjustCostOfGoodsSoldWizard = new guiAdjustCostOfGoodsSoldWizard(startDate, endDate);
            AdjustCostOfGoodsSoldWizard.Module = this;
            AdjustCostOfGoodsSoldWizard.GoToStep(0);
            AdjustCostOfGoodsSoldWizard.ShowDialog();
        }

        /// <summary>
        /// Calculate cost of goods sold in a report period
        /// </summary>        
        public void CalculateCostOfGoodsSold()
        {
            ActionNew();
            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            guiChooseReportPeriod guiChooseReportPeriod = new guiChooseReportPeriod(startDate, endDate);
            guiChooseReportPeriod.Module = this;
            if (guiChooseReportPeriod.ShowDialog() == DialogResult.OK)
            {
                CalculateCostOfGoodsSold(guiChooseReportPeriod.FromDate, guiChooseReportPeriod.ToDate);

            }
            else
            {
                ActionCancel();
            }
        }

        /// <summary>
        /// Process a step of the calculation wizard
        /// </summary>
        /// <param name="step">Given step</param>
        public void ProcessStep(int step)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            if (step == 3)
            {
                if (AdjustCostOfGoodsSoldWizard.AdjustmentRatio == -1)
                {
                    MessageBox.Show(GeneralAccountingLocalizedResources.AdjustmentRatioRequiredMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    return;
                }

                var objReceiptItemsController = new ICReceiptItemsController();
                List<ICReceiptItemsInfo> series = objReceiptItemsController.GetSeriesForCostAdjustment(
                                                                    AdjustCostOfGoodsSoldWizard.FromDate,
                                                                    AdjustCostOfGoodsSoldWizard.ToDate);

                Dictionary<string, List<ICReceiptItemsInfo>> dictionary = new Dictionary<string, List<ICReceiptItemsInfo>>();
                foreach (ICReceiptItemsInfo item in series)
                {
                    string key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                    if (!dictionary.Keys.Contains(key))
                        dictionary.Add(key, new List<ICReceiptItemsInfo>());
                    dictionary[key].Add(item);
                }

                series.Clear();
                decimal quantity = 0;
                decimal price = 0;
                foreach (string key in dictionary.Keys)
                {
                    quantity = 0;
                    price = 0;
                    ICReceiptItemsInfo receiptItem = new ICReceiptItemsInfo();
                    foreach (ICReceiptItemsInfo item in dictionary[key])
                    {
                        receiptItem.Id = item.Id;
                        receiptItem.ICReceiptDate = item.ICReceiptDate;
                        receiptItem.ICReceiptNo = item.ICReceiptNo;
                        receiptItem.FK_ICProductID = item.FK_ICProductID;
                        receiptItem.ICReceiptItemProductSerialNo = item.ICReceiptItemProductSerialNo;
                        receiptItem.AdjustedInventoryCost = item.AdjustedInventoryCost;
                        quantity += item.ICReceiptItemProductQty;
                        price += item.OriginalInventoryCost * item.ICReceiptItemProductQty;
                    }
                    receiptItem.OriginalInventoryCost = quantity == 0 ? 0 : price / quantity;
                    BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    series.Add(receiptItem);
                }

                series.ForEach(s => s.Selected = true);
                series = series.OrderBy(s => s.ICReceiptDate).ToList();
                entity.ProductSerieList.Invalidate(series);
                AdjustCostOfGoodsSoldWizard.GoToNextStep();
            }
            else if (step == 5)
            {
                AdjustCostOfGoodsSoldWizard.Finish();
                AdjustCostOfGoodsSold();
            }
            else
            {
                AdjustCostOfGoodsSoldWizard.GoToNextStep();
            }
        }

        /// <summary>
        /// View series of which the difference between the original inventory cost 
        /// and the adjusted ones exceeds the adjustment ratio
        /// </summary>
        /// <param name="viewWrongSeries">A value indicates whether the user is viewing wrong series</param>
        /// <param name="adjustmentRatio">Given adjustment ratio</param>
        public void ViewWrongSeries(bool viewWrongSeries, decimal adjustmentRatio)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            if (viewWrongSeries)
            {
                var series = entity.ProductSerieList.OriginalList
                                        .Where(s => s.AdjustedInventoryCost - s.OriginalInventoryCost > s.OriginalInventoryCost * adjustmentRatio / 100)
                                        .ToList();
                entity.ProductSerieList.Clear();
                foreach (var serie in series)
                {
                    entity.ProductSerieList.Add(serie);
                }

                entity.ProductSerieList.GridControl.RefreshDataSource();
                AdjustCostOfGoodsSoldWizard.DisableNextStep();
            }
            else
            {
                entity.ProductSerieList.Invalidate(entity.ProductSerieList.OriginalList);
                AdjustCostOfGoodsSoldWizard.EnableNextStep();
            }
        }

        /// <summary>
        /// Adjust cost of goods sold for series received in a fiscal period
        /// This process will be performed on all branches
        /// </summary>        
        public void AdjustCostOfGoodsSold()
        {
            BOSProgressBar.Start(GeneralAccountingLocalizedResources.ProcessingDataMessage);
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (var branch in entity.BranchList)
            {
                if (branch.Selected)
                {
                    try
                    {
                        branch.BRBranchTransferMessage = GeneralAccountingLocalizedResources.ProcessingDataMessage;
                        entity.BranchList.GridControl.RefreshDataSource();

                        foreach (var serie in entity.ProductSerieList)
                        {
                            if (serie.Selected)
                            {
                                BOSApp.RoundByCurrency(serie, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", serie.FK_ICProductID, serie.ICReceiptItemProductSerialNo, serie.AdjustedInventoryCost, serie.FK_ICReceiptID);
                            }
                        }

                        branch.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                    }
                    catch (Exception)
                    {
                        branch.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferErrorMessage;
                    }
                }
            }
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Calculate cost of goods sold in a report period
        /// </summary>
        /// <param name="fromDate">Start date of the report period</param>
        /// <param name="toDate">End date of the report period</param>
        public void CalculateCostOfGoodsSold(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start(GeneralAccountingLocalizedResources.ProcessingDataMessage);

            //Calculate for shipments
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentsInfo> shipments = objShipmentsController.GetShipmentsByDate(fromDate, toDate);
            foreach (ICShipmentsInfo objShipmentsInfo in shipments)
            {

                List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetItemsByShipmentID(objShipmentsInfo.ICShipmentID);
                objShipmentsInfo.ShipmentItems = new BOSList<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName);
                objShipmentsInfo.ShipmentItems.Invalidate(shipmentItems);
                foreach (ICShipmentItemsInfo objShipmentItemsInfo in shipmentItems)
                {
                    decimal oldValue = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = AccountHelper.CalculateGoodsSoldCost(
                                                                                                objShipmentItemsInfo.FK_ICStockID,
                                                                                                objShipmentItemsInfo.FK_ICProductID,
                                                                                                objShipmentItemsInfo.FK_ICProductSerieID,
                                                                                                fromDate,
                                                                                                toDate,
                                                                                                objShipmentsInfo.ICShipmentDate);
                    if (objShipmentItemsInfo.ICShipmentItemProductUnitPrice == decimal.MinValue)
                    {
                        objShipmentItemsInfo.ICShipmentItemProductUnitPrice = oldValue;
                    }
                    objShipmentItemsInfo.ICShipmentItemPrice = objShipmentItemsInfo.ICShipmentItemProductUnitPrice * objShipmentItemsInfo.ICShipmentItemProductQty;
                    objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductUnitPrice * objShipmentItemsInfo.ICShipmentItemProductQty;
                    BOSApp.RoundByCurrency(objShipmentItemsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                }
                objShipmentsInfo.ICShipmentSubTotalAmount = shipmentItems.Sum(i => i.ICShipmentItemTotalAmount);
                objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
                BOSApp.RoundByCurrency(objShipmentsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                objShipmentsController.UpdateObject(objShipmentsInfo);
            }

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (ICShipmentsInfo objShipmentsInfo in shipments)
            {
                ACDocumentsInfo objDocumentsInfo = null;
                if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.Shipment.ToString())
                {
                    objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKho.ToString(), objShipmentsInfo.ICShipmentNo);
                }
                else if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.SaleShipment.ToString())
                {
                    objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKhoBanHang.ToString(), objShipmentsInfo.ICShipmentNo);
                }
                else if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.EquipmentShipment.ToString())
                {
                    objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatCCDC.ToString(), objShipmentsInfo.ICShipmentNo);
                }
                if (objDocumentsInfo != null)
                {
                    List<ACDocumentEntrysInfo> entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(objDocumentsInfo.ACDocumentID);
                    for (int i = 0; i < entries.Count; i++)
                    {
                        ACDocumentEntrysInfo objDocumentEntrysInfo = entries[i];
                        if (objDocumentEntrysInfo.ACEntryTypeName == AccEntryType.XuatKhoBanHang.ToString() ||
                            objDocumentEntrysInfo.ACEntryTypeName == AccEntryType.XuatKhoDieuChinh.ToString())
                        {
                            objDocumentEntrysInfo.ACDocumentEntryAmount = objShipmentsInfo.ICShipmentTotalAmount;
                            objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = objDocumentEntrysInfo.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                            BOSApp.RoundByCurrency(objDocumentEntrysInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objDocumentEntrysController.UpdateObject(objDocumentEntrysInfo);
                        }
                        else if (objDocumentEntrysInfo.ACEntryTypeName == AccEntryType.XuatCCDC.ToString() ||
                                objDocumentEntrysInfo.ACEntryTypeName == AccEntryType.XuatCCDCPhanBo.ToString())
                        {
                            if (i < objShipmentsInfo.ShipmentItems.Count)
                            {
                                objDocumentEntrysInfo.ACDocumentEntryAmount = objShipmentsInfo.ShipmentItems[i].ICShipmentItemPrice;
                                objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = objDocumentEntrysInfo.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                                BOSApp.RoundByCurrency(objDocumentEntrysInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                objDocumentEntrysController.UpdateObject(objDocumentEntrysInfo);
                            }
                        }
                    }
                    objDocumentsInfo.ACDocumentTotalAmount = entries.Sum(e => e.ACDocumentEntryAmount);
                    objDocumentsInfo.ACDocumentExchangeAmount = entries.Sum(e => e.ACDocumentEntryExchangeAmount);
                    BOSApp.RoundByCurrency(objDocumentsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objDocumentsController.UpdateObject(objDocumentsInfo);
                }
            }

            //Calculate for return receipts
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptsInfo> receipts = objReceiptsController.GetReturnReceiptsByDate(fromDate, toDate);
            foreach (ICReceiptsInfo objReceiptsInfo in receipts)
            {
                List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetItemsByReceiptID(objReceiptsInfo.ICReceiptID);
                foreach (ICReceiptItemsInfo objReceiptItemsInfo in receiptItems)
                {
                    objReceiptItemsInfo.ICReceiptItemProductUnitCost = objReceiptItemsController.GetCostOfGoodsSold(objReceiptItemsInfo.Id);
                    objReceiptItemsInfo.ICReceiptItemExtCost = objReceiptItemsInfo.ICReceiptItemProductUnitCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                    objReceiptItemsInfo.ICReceiptItemTotalCost = objReceiptItemsInfo.ICReceiptItemProductUnitCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                    BOSApp.RoundByCurrency(objReceiptItemsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objReceiptItemsController.UpdateObject(objReceiptItemsInfo);
                }
                objReceiptsInfo.ICReceiptSubTotalCost = receiptItems.Sum(i => i.ICReceiptItemTotalCost);
                objReceiptsInfo.ICReceiptTotalCost = objReceiptsInfo.ICReceiptSubTotalCost;
            }

            foreach (ICReceiptsInfo objReceiptsInfo in receipts)
            {
                ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetDocumentByTypeAndNo(
                                                                                                AccDocumentType.NhapKhoHangTra.ToString(),
                                                                                                objReceiptsInfo.ICReceiptNo);
                if (objDocumentsInfo != null)
                {
                    List<ACDocumentEntrysInfo> entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(objDocumentsInfo.ACDocumentID);
                    foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in entries)
                    {
                        if (objDocumentEntrysInfo.ACEntryTypeName == AccEntryType.NhapKhoHangTra.ToString())
                        {
                            objDocumentEntrysInfo.ACDocumentEntryAmount = objReceiptsInfo.ICReceiptTotalCost * objReceiptsInfo.ICReceiptExchangeRate;
                            objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = objDocumentEntrysInfo.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                            BOSApp.RoundByCurrency(objDocumentEntrysInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objDocumentEntrysController.UpdateObject(objDocumentEntrysInfo);
                        }
                    }
                    objDocumentsInfo.ACDocumentTotalAmount = entries.Sum(e => e.ACDocumentEntryAmount);
                    objDocumentsInfo.ACDocumentExchangeAmount = entries.Sum(e => e.ACDocumentEntryExchangeAmount);
                    BOSApp.RoundByCurrency(objDocumentsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objDocumentsController.UpdateObject(objDocumentsInfo);
                }
            }


            BOSProgressBar.Close();
            MessageBox.Show(
                        GeneralAccountingLocalizedResources.ProcessDataSuccessfullyMessage,
                        CommonLocalizedResources.MessageBoxDefaultCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        /// <summary>
        /// Calculate the exchange rate difference at the end of a report period
        /// </summary>
        public void CalculateExchangeRateDiff()
        {
            ActionNew();

            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);

            //guiChooseReportPeriod guiChooseReportPeriod = new guiChooseReportPeriod(startDate, endDate);
            //guiChooseReportPeriod.Module = this;
            guiCalculateExchangeRateDiff guiCalculateExchangeRateDiff = new guiCalculateExchangeRateDiff(startDate, endDate);
            guiCalculateExchangeRateDiff.Module = this;

            if (guiCalculateExchangeRateDiff.ShowDialog() == DialogResult.OK)
            {
                BOSProgressBar.Start(GeneralAccountingLocalizedResources.ProcessingDataMessage);

                ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.ChenhLechTyGia.ToString());
                if (objDocumentTypesInfo != null)
                {
                    DateTime fromDate = guiCalculateExchangeRateDiff.FromDate;
                    DateTime toDate = guiCalculateExchangeRateDiff.ToDate;
                    int currencyID = guiCalculateExchangeRateDiff.CurrencyID;

                    GECurrenciesController objCurrenciesController = new GECurrenciesController();
                    GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(currencyID);

                    GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
                    ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
                    objDocumentsInfo.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;

                    objDocumentsInfo.ACDocumentDesc = "Chênh lệch tỷ giá " + objCurrenciesInfo.GECurrencyNo + " từ ngày " + fromDate.ToString("dd/MM/yyyy") + " -> " + toDate.ToString("dd/MM/yyyy");
                    objDocumentsInfo.FK_GECurrencyID = currencyID;

                    List<ACDocumentEntrysInfo> exchangeRateDiffEntries = new List<ACDocumentEntrysInfo>();
                    ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                    ACDocTypeEntrysInfo defaultExchangeRateDiffEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                                    AccDocumentType.ChenhLechTyGia.ToString(),
                                                                                                                    AccEntryType.ChenhLechTyGia.ToString());

                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    List<ACDocumentEntrysInfo> calculatedEntries = new List<ACDocumentEntrysInfo>();
                    List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();

                    //List<ACDocumentEntrysInfo> entriesFromAccountDetail = GetOwingEntriesByInitAccount(entries);

                    List<ACDocumentEntrysInfo> owingEntries = objDocumentEntrysController.GetOwingEntriesByDateAndCurrencyID(fromDate, toDate, currencyID);
                    //owingEntries = owingEntries.Where(item => item.FK_ACObjectID == 836 || item.FK_ACAssObjectID == 836).ToList();

                    List<int> objectIDs = new List<int>();
                    List<int> objIDs = owingEntries.Select(x => x.FK_ACObjectID).Distinct().ToList();
                    if (objIDs != null)
                        objectIDs.AddRange(objIDs);
                    objIDs = owingEntries.Select(x => x.FK_ACAssObjectID).Distinct().ToList();
                    if (objIDs != null)
                        objectIDs.AddRange(objIDs);
                    objectIDs = objectIDs.Where(id => id != 0).Distinct().ToList();

                    List<ACDocumentEntrysInfo> entriesFromAccountDetail = GetOwingEntriesByInitAccountByCurrencyID(objectIDs, currencyID, fromDate.AddDays(-1));

                    if (entriesFromAccountDetail != null && entriesFromAccountDetail.Count != 0)
                        entries.AddRange(entriesFromAccountDetail);

                    if (owingEntries != null && owingEntries.Count != 0)
                    {
                        owingEntries = owingEntries.Where(item => !entries.Any(item1 => item.ACDocumentEntryID == item1.ACDocumentEntryID)).ToList();
                        if (owingEntries != null)
                            entries.AddRange(owingEntries);
                    }
                    //entries = entries.Where(item => item.FK_ACObjectID == 836 || item.FK_ACAssObjectID == 836).ToList();

                    foreach (ACDocumentEntrysInfo entry in entries)
                    {
                        if (entry.FK_GECurrencyID != BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID)
                        {
                            CalculateExchangeRateDiff(entry, ref calculatedEntries, ref exchangeRateDiffEntries, defaultExchangeRateDiffEntry);
                        }
                    }

                    ACAccountsController objAccountsController = new ACAccountsController();
                    int financialIncomeAccountID = objAccountsController.GetObjectIDByNo(AccAccount.Acc515);
                    int financialCostAccountID = objAccountsController.GetObjectIDByNo(AccAccount.Acc635);
                    exchangeRateDiffEntries = exchangeRateDiffEntries.Where(e => e.ACDocumentEntryAmount != 0).ToList();
                    foreach (ACDocumentEntrysInfo exchangeRateDiffEntry in exchangeRateDiffEntries)
                    {
                        if (exchangeRateDiffEntry.ACDocumentEntryAmount > 0)
                        {
                            exchangeRateDiffEntry.FK_ACCreditAccountID = financialIncomeAccountID;
                        }
                        else
                        {
                            exchangeRateDiffEntry.FK_ACCreditAccountID = exchangeRateDiffEntry.FK_ACDebitAccountID;
                            exchangeRateDiffEntry.FK_ACDebitAccountID = financialCostAccountID;
                        }
                        exchangeRateDiffEntry.ACDocumentEntryAmount = Math.Abs(exchangeRateDiffEntry.ACDocumentEntryAmount);
                        exchangeRateDiffEntry.ACDocumentEntryExchangeAmount = exchangeRateDiffEntry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;

                        //
                        exchangeRateDiffEntry.ACDocumentEntryAmount = 0;

                        //Get object name
                        if (exchangeRateDiffEntry.ACDocumentEntrySourceID > 0)
                        {
                            ACDocumentEntrysInfo objSourceDocumentEntrysInfo = (ACDocumentEntrysInfo)objDocumentEntrysController.GetObjectByID(exchangeRateDiffEntry.ACDocumentEntrySourceID);

                            ACDocumentsController objDocumentsController = new ACDocumentsController();
                            ACDocumentsInfo objExchangeRateDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByID(objSourceDocumentEntrysInfo.FK_ACDocumentID);

                            if (objExchangeRateDocumentsInfo != null)
                            {
                                ACObjectsController objObjectsController = new ACObjectsController();
                                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(exchangeRateDiffEntry.FK_ACObjectID, objExchangeRateDocumentsInfo.ACObjectType);
                                if (objObjectsInfo != null)
                                {
                                    exchangeRateDiffEntry.ACObjectNo = objObjectsInfo.ACObjectNo;
                                    exchangeRateDiffEntry.ACObjectName = objObjectsInfo.ACObjectName;
                                    exchangeRateDiffEntry.ACObjectType = objObjectsInfo.ACObjectType;
                                }
                            }
                        }
                        else
                        {
                            //Entry from Account Detail
                            if (exchangeRateDiffEntry.ACDocumentEntrySourceID == -1)
                            {
                                ACObjectsController objObjectsController = new ACObjectsController();
                                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(exchangeRateDiffEntry.FK_ACObjectID, exchangeRateDiffEntry.ACObjectType);
                                if (objObjectsInfo != null)
                                {
                                    exchangeRateDiffEntry.ACObjectNo = objObjectsInfo.ACObjectNo;
                                    exchangeRateDiffEntry.ACObjectName = objObjectsInfo.ACObjectName;
                                    exchangeRateDiffEntry.ACObjectType = objObjectsInfo.ACObjectType;
                                }
                            }
                        }
                        BOSApp.RoundByCurrency(exchangeRateDiffEntry, objDocumentsInfo.FK_GECurrencyID);
                    }
                    entity.DocumentEntryList.Invalidate(exchangeRateDiffEntries);
                    RefreshBriefDocumentEntrys();
                    BOSProgressBar.Close();
                }
            }
            else
            {
                ActionCancel();
            }
        }

        public List<ACDocumentEntrysInfo> GetOwingEntriesByInitAccount(List<ACDocumentEntrysInfo> documentEntrys)
        {
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();

            int[] arrDocumentEntrys = documentEntrys.Select(x => x.FK_ACObjectID).Distinct().ToArray();

            for (int i = 0; i <= arrDocumentEntrys.Count() - 1; i++)
            {
                ACAccountDetailsController objAccountDetailsController = new ACAccountDetailsController();
                List<ACAccountDetailsInfo> accountDetailList = objAccountDetailsController.GetAccountDetailByObjectIDAndSomeCriteria(arrDocumentEntrys[i], BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID);

                foreach (ACAccountDetailsInfo objAccountDetailsInfo in accountDetailList)
                {
                    ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                    if (objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency >= 0)
                    {
                        entry.OwingByCredit = true;
                        entry.OwingByDebit = false;
                        entry.FK_ACCreditAccountID = objAccountDetailsInfo.FK_ACAccountID;
                        entry.ACDocumentCreditAccount = objAccountDetailsInfo.ACAccountNo;
                        entry.FK_ACObjectID = objAccountDetailsInfo.FK_ACObjectID;
                        entry.FK_GECurrencyID = objAccountDetailsInfo.FK_GECurrencyID;
                        entry.ACObjectType = objAccountDetailsInfo.ACObjectType;
                        entry.ACDocumentEntryAmount = objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency;
                        entry.ACDocumentExchangeRate = objAccountDetailsInfo.ACAccountDetailExchangeRate;
                        entry.ACDocumentEntryExchangeAmount = objAccountDetailsInfo.ACAccountDetailInitialBalance;
                        entry.CreditAccountPostingRule = objAccountDetailsInfo.ACAccountPostingRule;
                    }
                    else
                    {
                        entry.OwingByCredit = false;
                        entry.OwingByDebit = true;
                        entry.FK_ACDebitAccountID = objAccountDetailsInfo.FK_ACAccountID;
                        entry.ACDocumentDebitAccount = objAccountDetailsInfo.ACAccountNo;
                        entry.FK_ACObjectID = objAccountDetailsInfo.FK_ACObjectID;
                        entry.FK_GECurrencyID = objAccountDetailsInfo.FK_GECurrencyID;
                        entry.ACObjectType = objAccountDetailsInfo.ACObjectType;
                        entry.ACDocumentEntryAmount = objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency;
                        entry.ACDocumentExchangeRate = objAccountDetailsInfo.ACAccountDetailExchangeRate;
                        entry.ACDocumentEntryExchangeAmount = objAccountDetailsInfo.ACAccountDetailInitialBalance;
                        entry.DebitAccountPostingRule = objAccountDetailsInfo.ACAccountPostingRule;
                    }
                    entry.ACDocumentEntryID = -1;
                    entry.ACDocumentEntrySourceID = -1;

                    entries.Add(entry);
                }
            }

            return entries;
        }

        public List<ACDocumentEntrysInfo> GetOwingEntriesByInitAccountByCurrencyID(List<int> objectIDs, int currencyID, DateTime toDate)
        {
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            ACAccountDetailsController objAccountDetailsController = new ACAccountDetailsController();
            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();

            List<ACAccountDetailsInfo> accountDetailList;
            List<ACDocumentEntrysInfo> owingEntries;
            List<ACDocumentEntrysInfo> owingEntrieCollection = new List<ACDocumentEntrysInfo>();
            List<ACDocumentEntrysInfo> exchangeRateDiffEntries = new List<ACDocumentEntrysInfo>();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultExchangeRateDiffEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                            AccDocumentType.ChenhLechTyGia.ToString(),
                                                                                                            AccEntryType.ChenhLechTyGia.ToString());
            List<ACDocumentEntrysInfo> calculatedEntries = new List<ACDocumentEntrysInfo>();

            for (int i = 0; i <= objectIDs.Count() - 1; i++)
            {
                //initialized account balanace
                accountDetailList = objAccountDetailsController.GetAccountDetailByObjectIDAndCurrencyID(objectIDs[i], currencyID);

                foreach (ACAccountDetailsInfo objAccountDetailsInfo in accountDetailList)
                {
                    ACDocumentEntrysInfo entry = AccountDetailsInfoToDocumentEntrysInfo(objAccountDetailsInfo);

                    entries.Add(entry);
                }
                //get owing entries by from date
                owingEntries = documentEntryController.GetOwingEntriesByObjectIDAndDateAndCurrencyID(objectIDs[i], null, toDate, currencyID);
                if (owingEntries != null)
                {
                    owingEntries = owingEntries.Where(item => !owingEntrieCollection.Any(item1 => item.ACDocumentEntryID == item1.ACDocumentEntryID)).ToList();
                    if (owingEntries != null)
                        owingEntrieCollection.AddRange(owingEntries);
                }
            }

            owingEntrieCollection = owingEntrieCollection.OrderBy(entry => entry.ACDocumentDate).ToList();
            entries.AddRange(owingEntrieCollection);

            ////get owing entries by from date
            //owingEntries = documentEntryController.GetOwingEntriesByObjectIDAndDateAndCurrencyID(fromDate, toDate, currencyID);
            //if (owingEntries != null)
            //{
            //    //owingEntries = owingEntries.Where(entry => entry.FK_ACObjectID == 836 || entry.FK_ACAssObjectID == 836).ToList();
            //    entries.AddRange(owingEntries);
            //}
            if (entries != null)
            {
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.FK_GECurrencyID != BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID)
                    {
                        CalculateExchangeRateDiff(entry, ref calculatedEntries, ref exchangeRateDiffEntries, defaultExchangeRateDiffEntry);
                    }
                }

                entries = calculatedEntries.Where(item => objectIDs.Any(id => id == item.FK_ACObjectID) &&
                                                            item.ACDocumentEntryAmount != 0
                                                            //&& item.FK_ACObjectID == 836
                                                            ).ToList();

                if (entries != null)
                {
                    foreach (ACDocumentEntrysInfo entry in entries)
                    {
                        if (entry.ACDocumentEntryAmount >= 0)
                        {
                            entry.OwingByCredit = true;
                            entry.OwingByDebit = false;
                            entry.FK_ACCreditAccountID = entry.FK_ACDebitAccountID;
                            entry.CreditAccountPostingRule = AccountPostingRule.IncreasingByCredit.ToString();
                        }
                        else
                        {
                            entry.OwingByCredit = false;
                            entry.OwingByDebit = true;
                            entry.ACDocumentEntryAmount = -entry.ACDocumentEntryAmount;
                            entry.DebitAccountPostingRule = AccountPostingRule.IncreasingByCredit.ToString();
                        }
                    }
                }
            }

            return entries;
        }

        private ACDocumentEntrysInfo AccountDetailsInfoToDocumentEntrysInfo(ACAccountDetailsInfo objAccountDetailsInfo)
        {
            ACDocumentEntrysInfo entry = null;
            if (objAccountDetailsInfo != null)
            {
                entry = new ACDocumentEntrysInfo();
                if (objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency >= 0)
                {
                    entry.OwingByCredit = true;
                    entry.OwingByDebit = false;
                    entry.FK_ACCreditAccountID = objAccountDetailsInfo.FK_ACAccountID;
                    entry.ACDocumentCreditAccount = objAccountDetailsInfo.ACAccountNo;
                    entry.FK_ACObjectID = objAccountDetailsInfo.FK_ACObjectID;
                    entry.FK_GECurrencyID = objAccountDetailsInfo.FK_GECurrencyID;
                    entry.ACObjectType = objAccountDetailsInfo.ACObjectType;
                    entry.ACDocumentEntryAmount = objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency;
                    entry.ACDocumentExchangeRate = objAccountDetailsInfo.ACAccountDetailExchangeRate;
                    entry.ACDocumentEntryExchangeAmount = objAccountDetailsInfo.ACAccountDetailInitialBalance;
                    entry.CreditAccountPostingRule = objAccountDetailsInfo.ACAccountPostingRule;
                }
                else
                {
                    entry.OwingByCredit = false;
                    entry.OwingByDebit = true;
                    entry.FK_ACDebitAccountID = objAccountDetailsInfo.FK_ACAccountID;
                    entry.ACDocumentDebitAccount = objAccountDetailsInfo.ACAccountNo;
                    entry.FK_ACObjectID = objAccountDetailsInfo.FK_ACObjectID;
                    entry.FK_GECurrencyID = objAccountDetailsInfo.FK_GECurrencyID;
                    entry.ACObjectType = objAccountDetailsInfo.ACObjectType;
                    entry.ACDocumentEntryAmount = -objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency;
                    entry.ACDocumentExchangeRate = objAccountDetailsInfo.ACAccountDetailExchangeRate;
                    entry.ACDocumentEntryExchangeAmount = -objAccountDetailsInfo.ACAccountDetailInitialBalance;
                    entry.DebitAccountPostingRule = objAccountDetailsInfo.ACAccountPostingRule;
                }
                entry.ACDocumentEntryID = -1;
                entry.ACDocumentEntrySourceID = -1;
            }

            return entry;
        }

        /// <summary>
        /// Calculate the exchange rate difference for an generated entry
        /// </summary>
        /// <param name="entry">Entry</param>
        /// <param name="calculatedEntries">List of entries for calculation</param>
        /// <param name="exchangeRateDiffEntries">If has exchange rate difference, a new entry will be added to this list</param>
        /// <param name="defaultExchangeRateDiffEntry">Default exchange rate diffenrece entry</param>
        private void CalculateExchangeRateDiff(ACDocumentEntrysInfo entry,
                                                ref List<ACDocumentEntrysInfo> calculatedEntries,
                                                ref List<ACDocumentEntrysInfo> exchangeRateDiffEntries,
                                                ACDocTypeEntrysInfo defaultExchangeRateDiffEntry)
        {
            if (entry.OwingByDebit)
            {
                int objectID = entry.FK_ACObjectID;
                int accountID = entry.FK_ACDebitAccountID;
                decimal factor = 1;
                if (entry.DebitAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                {
                    factor = -1;
                }
                CalculateExchangeRateDiff(
                                objectID,
                                accountID,
                                entry.DebitAccountPostingRule,
                                entry,
                                ref calculatedEntries,
                                ref exchangeRateDiffEntries,
                                defaultExchangeRateDiffEntry,
                                factor);
            }
            if (entry.OwingByCredit)
            {
                int objectID = entry.FK_ACObjectID;
                if (entry.FK_ACAssObjectID > 0)
                {
                    objectID = entry.FK_ACAssObjectID;
                }
                int accountID = entry.FK_ACCreditAccountID;
                decimal factor = -1;
                if (entry.CreditAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                {
                    factor = 1;
                }
                CalculateExchangeRateDiff(
                                    objectID,
                                    accountID,
                                    entry.CreditAccountPostingRule,
                                    entry,
                                    ref calculatedEntries,
                                    ref exchangeRateDiffEntries,
                                    defaultExchangeRateDiffEntry,
                                    factor);
            }
        }

        /// <summary>
        /// Calculate the exchange rate difference for an generated entry
        /// </summary>
        /// <param name="objectID">Object id</param>
        /// <param name="accountID">Account id</param>
        /// <param name="postingRule">Posting rule of the account</param>
        /// <param name="entry">Entry</param>
        /// <param name="calculatedEntries">List of entries for calculation</param>
        /// <param name="exchangeRateDiffEntries">If has exchange rate difference, a new entry will be added to this list</param>
        /// <param name="defaultExchangeRateDiffEntry">Default exchange rate diffenrece entry</param>
        /// <param name="factor">Factor for calculation</param>
        private void CalculateExchangeRateDiff(int objectID,
                                                int accountID,
                                                string postingRule,
                                                ACDocumentEntrysInfo entry,
                                                ref List<ACDocumentEntrysInfo> calculatedEntries,
                                                ref List<ACDocumentEntrysInfo> exchangeRateDiffEntries,
                                                ACDocTypeEntrysInfo defaultExchangeRateDiffEntry,
                                                decimal factor)
        {
            GECurrenciesController objCurrencyController = new GECurrenciesController();
            decimal documentEntryAmount = entry.ACDocumentEntryAmount;
            foreach (ACDocumentEntrysInfo calculatedEntry in calculatedEntries)
            {
                if (calculatedEntry.FK_ACObjectID == objectID &&
                    calculatedEntry.FK_ACDebitAccountID == accountID &&
                    calculatedEntry.FK_GECurrencyID == entry.FK_GECurrencyID &&
                    calculatedEntry.ACDocumentEntryAmount * factor < 0)
                {
                    decimal amount = Math.Min(Math.Abs(documentEntryAmount), Math.Abs(calculatedEntry.ACDocumentEntryAmount));
                    ACDocumentEntrysInfo exchangeRateDiffEntry = exchangeRateDiffEntries.Where(e => e.FK_ACObjectID == objectID &&
                                                                                                e.FK_ACDebitAccountID == accountID &&
                                                                                                e.FK_GECurrencyID == entry.FK_GECurrencyID).FirstOrDefault();
                    if (exchangeRateDiffEntry == null)
                    {
                        exchangeRateDiffEntry = AccountHelper.AddItemToDocumentEntryList(defaultExchangeRateDiffEntry, exchangeRateDiffEntries);
                        exchangeRateDiffEntry.FK_ACObjectID = objectID;
                        exchangeRateDiffEntry.FK_ACDebitAccountID = accountID;
                        exchangeRateDiffEntry.FK_GECurrencyID = entry.FK_GECurrencyID;
                        string currencyName = objCurrencyController.GetObjectNameByID(exchangeRateDiffEntry.FK_GECurrencyID);
                        exchangeRateDiffEntry.ACDocumentEntryDesc += string.Format(" {0}", currencyName);
                        exchangeRateDiffEntry.ACDocumentEntrySourceID = entry.ACDocumentEntryID;

                        if (entry.ACDocumentEntryID == -1)
                        {
                            exchangeRateDiffEntry.ACObjectType = entry.ACObjectType;
                        }
                    }
                    if (postingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        exchangeRateDiffEntry.ACDocumentEntryAmount += amount * (calculatedEntry.ACDocumentExchangeRate - entry.ACDocumentExchangeRate) * factor;
                    }
                    else if (postingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        exchangeRateDiffEntry.ACDocumentEntryAmount += amount * (entry.ACDocumentExchangeRate - calculatedEntry.ACDocumentExchangeRate) * factor;
                    }
                    calculatedEntry.ACDocumentEntryAmount += amount * factor;
                    documentEntryAmount -= amount;
                    if (documentEntryAmount == 0)
                    {
                        break;
                    }
                    BOSApp.RoundByCurrency(calculatedEntry, calculatedEntry.FK_GECurrencyID);
                }
            }

            if (documentEntryAmount != 0)
            {
                //ACDocumentEntrysInfo calculatedEntry = calculatedEntries.Where(
                //                                                    e => e.FK_ACObjectID == objectID &&
                //                                                    e.FK_ACDebitAccountID == accountID &&
                //                                                    e.FK_GECurrencyID == entry.FK_GECurrencyID &&
                //                                                    e.ACDocumentExchangeRate == entry.ACDocumentExchangeRate
                //                                                    ).FirstOrDefault();

                ACDocumentEntrysInfo calculatedEntry = null;
                if (calculatedEntry == null)
                {
                    calculatedEntry = new ACDocumentEntrysInfo();
                    calculatedEntry.FK_ACObjectID = objectID;
                    calculatedEntry.FK_ACDebitAccountID = accountID;
                    calculatedEntry.FK_GECurrencyID = entry.FK_GECurrencyID;
                    calculatedEntry.ACDocumentExchangeRate = entry.ACDocumentExchangeRate;
                    calculatedEntries.Add(calculatedEntry);
                }
                calculatedEntry.ACDocumentEntryAmount += documentEntryAmount * factor;
            }

        }

        /// <summary>
        /// Allocate purchase cost at the end of a report period
        /// </summary>        
        public void AllocatePurchaseCost()
        {
            ActionNew();

            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            guiChooseReportPeriod guiChooseReportPeriod = new guiChooseReportPeriod(startDate, endDate);
            guiChooseReportPeriod.Module = this;
            if (guiChooseReportPeriod.ShowDialog() == DialogResult.OK)
            {
                ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.PhanBoChiPhi.ToString());
                if (objDocumentTypesInfo != null)
                {
                    DateTime fromDate = guiChooseReportPeriod.FromDate;
                    DateTime toDate = guiChooseReportPeriod.ToDate;

                    GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
                    ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
                    objDocumentsInfo.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;

                    ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                    ACDocTypeEntrysInfo entry = (ACDocTypeEntrysInfo)objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                                    AccDocumentType.PhanBoChiPhi.ToString(),
                                                                                                                    AccEntryType.PhanBoChiPhiMuaHang.ToString());
                    if (entry != null)
                    {
                        ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                        DateTime prevPeriodEndDate = fromDate.AddDays(-1);
                        decimal prevPeriodFeeBalance = objDocumentEntrysController.GetAccountBalance(AccAccount.Acc1562, prevPeriodEndDate);
                        decimal periodFeeDebitAmount = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc1562, fromDate, toDate);
                        decimal prevPeriodCostBalance = objDocumentEntrysController.GetAccountBalance(AccAccount.Acc1561, prevPeriodEndDate);
                        decimal periodCostDebitAmount = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc1561, fromDate, toDate);
                        ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                        decimal periodCostOfGoodsSold = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc632, fromDate, toDate);
                        ACDocumentEntrysInfo objDocumentEntrysInfo = AccountHelper.AddItemToDocumentEntryList(entry, entity.DocumentEntryList);
                        objDocumentEntrysInfo.ACDocumentEntryAmount = ((prevPeriodFeeBalance + periodFeeDebitAmount) * periodCostOfGoodsSold) / (prevPeriodCostBalance + periodCostDebitAmount);
                        objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = objDocumentEntrysInfo.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                        BOSApp.RoundByCurrency(objDocumentEntrysInfo, objDocumentsInfo.FK_GECurrencyID);
                        entity.DocumentEntryList.GridControl.RefreshDataSource();
                        RefreshBriefDocumentEntrys();
                    }
                }
            }
            else
            {
                ActionCancel();
            }
        }
        public void AllocateCost(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
                entity.DocumentEntryList.Clear();
                entity.AllocationCostObjectTranList.Clear();
            }
            DateTime startDate = mainObject.ACDocumentInvoiceDate;
            DateTime endDate = mainObject.ACDocumentPaymentDueDate;
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.PhanBoChiPhi.ToString());
            if (objDocumentTypesInfo != null)
            {

                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                mainObject.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = (ACDocTypeEntrysInfo)objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                                AccDocumentType.PhanBoChiPhi.ToString(),
                                                                                                                AccEntryType.PhanBoChiPhiTraTruoc.ToString());

                string[] branchIDs = branches != null ? branches.Select(o => o.BRBranchID.ToString()).ToArray() : new[] { mainObject.FK_BRBranchID.ToString() };
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsDoc(mainObject.ACDocumentTypeName, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate,
                        (branchIDs != null && branchIDs.Length > 0) ? string.Join(",", branchIDs) :
                        mainObject.FK_BRBranchID.ToString()))
                    {
                        entity.AllocationCostObjectTranList.Clear();
                        entity.AllocationCostObjectTranList.GridControl.RefreshDataSource();
                        return;
                    }

                if (defaultEntry != null)
                {
                    ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
                    ACAllocationCostObjectTransInfo objAllocationCostObjectTransInfo = null;

                    for (int i = 0; i < branchIDs.Length; i++)
                    {
                        int branchID = Convert.ToInt32(branchIDs[i]);
                        List<ACCostObjectItemsInfo> listCostObjectItems = new List<ACCostObjectItemsInfo>();
                        if (mainObject.ACDocumentID == 0)
                            listCostObjectItems = objCostObjectItemsController.GetCostObjectItemsForAllocated(branchID, endDate);
                        else
                            listCostObjectItems = objCostObjectItemsController.GetCostObjectItemsForAllocatedUpdate(branchID, endDate, mainObject.ACDocumentID);
                        listCostObjectItems = listCostObjectItems.Where(t => t.ACCostObjectItemAllocationMonths > 0).ToList();
                        foreach (ACCostObjectItemsInfo item in listCostObjectItems)
                        {
                            objAllocationCostObjectTransInfo = new ACAllocationCostObjectTransInfo();
                            objAllocationCostObjectTransInfo.FK_BRBranchID = branchID;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranReferenceNo = item.ACCostObjectItemRefNo;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranModuleName = item.ACCostObjectItemModuleName;
                            STModuleDescriptionsController objModuleDescriptionsController = new STModuleDescriptionsController();
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranModuleDescription = objModuleDescriptionsController.GetDescriptionByModuleNameAndLanguageName(objAllocationCostObjectTransInfo.ACAllocationCostObjectTranModuleName, BOSApp.CurrentLang);
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranReferenceDate = item.ACCostObjectItemDate;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranYear = endDate.Year;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranPeriod = endDate.Month;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranDate = endDate.Date;
                            objAllocationCostObjectTransInfo.FK_ACCostAccountID = item.FK_ACAllocationAccountID;
                            objAllocationCostObjectTransInfo.FK_ACDepreciationWaitAccountID = item.FK_ACCostAllocationWaitAccountID;
                            objAllocationCostObjectTransInfo.FK_ACCostObjectID = item.FK_ACCostObjectID;
                            objAllocationCostObjectTransInfo.FK_ACCostObjectItemID = item.ACCostObjectItemID;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranCostObjectName = item.ACCostObjectItemCostObjectName;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranTotalAmount = item.ACCostObjectItemTotalAmount;
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranDepreciatedAmount = item.ACCostObjectItemAllocatedAmount; // Giá trị đã phân bổ
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranRemainedAmount = item.ACAllocationCostObjectTranRemainedAmount; //Giá trị còn lại
                            objAllocationCostObjectTransInfo.ACAllocationCostObjectTranAmount = Math.Min(item.ACAllocationCostObjectTranRemainedAmount, item.ACCostObjectItemAllocationMonthAmount); //Giá trị khấu hao kỳ
                            objAllocationCostObjectTransInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                            objAllocationCostObjectTransInfo.FK_ACSegmentID = item.FK_ACSegmentID;
                            objAllocationCostObjectTransInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                            objAllocationCostObjectTransInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                            objAllocationCostObjectTransInfo.FK_MMWorkShopID = 0; //item.FK_MMWorkShopID;
                            objAllocationCostObjectTransInfo.FK_MMLineID = 0; //item.FK_MMLineID;
                            objAllocationCostObjectTransInfo.FK_HRDepartmentRoomGroupItemID = 0; //item.FK_HRDepartmentRoomGroupItemID;
                            objAllocationCostObjectTransInfo.FK_PMProjectID = item.FK_PMProjectID;

                            entity.AllocationCostObjectTranList.Add(objAllocationCostObjectTransInfo);
                        }
                    }
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                    entity.AllocationCostObjectTranList.GridControl.RefreshDataSource();
                    InvalidateDocumentEntrys(entity.AllocationCostObjectTranList);
                    RefreshBriefDocumentEntrys();
                }
            }
        }
        /// <summary>
        /// Allocate cost at the end of a report period
        /// </summary>
        public void AllocateCost()
        {
            ActionNew();
            if (PageCostObjectTran != null)
                PageCostObjectTran.PageVisible = true;
            AllocateCost(false);
        }

        public bool CheckExitsAllocateCost(int ACDocumentTypeID, DateTime startDate, DateTime endDate)
        {

            //Check exits AllocateCost
            List<ACDocumentsInfo> objDocumentExitsList = (new ACDocumentsController()).GetExitsAllocateCost(ACDocumentTypeID, startDate, endDate);
            if (objDocumentExitsList != null && objDocumentExitsList.Count > 0)
            {
                MessageBox.Show("Đã tồn tại chứng từ phân bổ cho kỳ: " + endDate.Month + ":" + Environment.NewLine +
                                string.Join(",", objDocumentExitsList.Select(d => d.ACDocumentNo).Distinct().ToArray())
                                ,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool CheckExitsGeneralAccountingByTpye(int ACDocumentTypeID, DateTime startDate, DateTime endDate)
        {

            //Check exits AllocateCost
            List<ACDocumentsInfo> objDocumentExitsList = (new ACDocumentsController()).GetExitsGeneralAccountingByTpye(ACDocumentTypeID, startDate, endDate);
            if (objDocumentExitsList != null && objDocumentExitsList.Count > 0)
            {
                MessageBox.Show("Đã tồn tại chứng từ cho kỳ: " + endDate.Month + ":" + Environment.NewLine +
                                string.Join(",", objDocumentExitsList.Select(d => d.ACDocumentNo).Distinct().ToArray())
                                ,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool CheckExitsDoc(string documentTypeName, DateTime FromDate, DateTime ToDate, string SelectedBranchIDs)
        {
            bool result = true;
            int m1 = (ToDate.Month - FromDate.Month);
            int m2 = (ToDate.Year - FromDate.Year) * 12;
            int months = m1 + m2;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDepreciationAssetTransController objDepreciationAssetTransController = new ACDepreciationAssetTransController();
            ACAssetsController objAssetsController = new ACAssetsController();
            if (documentTypeName == AccDocumentType.KhauHaoTSCD.ToString())
            {
                if (months != 0)
                {
                    MessageBox.Show("Vui lòng chạy khấu hao theo từng tháng!",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }

                List<ACDepreciationAssetTransInfo> depreciationAssetTrans = null;
                List<int> branchIDsDepreciated = null;
                if (!(BOSApp.CurrentCompanyInfo.CSCompanyStartDate.Month == ToDate.Month && BOSApp.CurrentCompanyInfo.CSCompanyStartDate.Year == ToDate.Year))
                {
                    depreciationAssetTrans = objDepreciationAssetTransController.GetDepreciationAssetTransByMonthAndBranchIDs(ToDate.AddMonths(-1), SelectedBranchIDs);

                    List<ACAssetsInfo> depreciatedAssets = new List<ACAssetsInfo>();
                    string[] branchIDs = SelectedBranchIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < branchIDs.Length; i++)
                    {
                        depreciatedAssets.AddRange(objAssetsController.GetAssetsForDepreciating(i, ToDate.AddMonths(-1)));
                    }
                    if (depreciationAssetTrans.Count() == 0 && depreciatedAssets.Count() > 0 && DateTime.Compare(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Date, ToDate.AddMonths(-1).Date) < 0)
                    {
                        MessageBox.Show("Vui lòng chạy khấu hao tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }

                    branchIDsDepreciated = depreciationAssetTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                    List<int> branchIDsUnDepreciate = new List<int>();
                    int x = 0;
                    branchIDs.All(o =>
                    {
                        x = 0;
                        if (Int32.TryParse(o, out x))
                        {
                            depreciatedAssets = new List<ACAssetsInfo>();
                            depreciatedAssets.AddRange(objAssetsController.GetAssetsForDepreciating(x, ToDate.AddMonths(-1)));
                            if (!branchIDsDepreciated.Any(y => y == x) && depreciatedAssets.Count() > 0)
                                branchIDsUnDepreciate.Add(x);
                        }
                        return true;
                    });

                    if (branchIDsUnDepreciate.Count() > 0 && DateTime.Compare(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Date, ToDate.AddMonths(-1).Date) < 0)
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        BRBranchsInfo objBranchsInfo = null;
                        string mes = string.Empty;
                        branchIDsUnDepreciate.ForEach(o =>
                        {
                            objBranchsInfo = objBranchsController.GetObjectByID(o) as BRBranchsInfo;
                            if (objBranchsInfo != null)
                                mes += Environment.NewLine + objBranchsInfo.BRBranchName;
                        });
                        MessageBox.Show("Vui lòng chạy khấu hao tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "  cho các chi nhánh sau:" + Environment.NewLine + mes,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }

                depreciationAssetTrans = objDepreciationAssetTransController.GetDepreciationAssetTransByMonthAndBranchIDs(ToDate, SelectedBranchIDs);
                List<ACDepreciationAssetTransInfo> branchIDDepreciateds = depreciationAssetTrans.GroupBy(o => o.FK_BRBranchID).Select(o => o.First()).ToList();
                branchIDsDepreciated = depreciationAssetTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                if (branchIDDepreciateds.Count() > 0)
                {
                    string mes = string.Empty;
                    branchIDDepreciateds.ForEach(o =>
                    {
                        mes += Environment.NewLine + o.BRBranchName;
                    });
                    MessageBox.Show("Các chi nhánh sau đã được chạy khấu hao cho tháng " + ToDate.Month + ":" + Environment.NewLine + mes,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (documentTypeName == AccDocumentType.PhanBoCCDC.ToString())
            {
                if (months != 0)
                {
                    MessageBox.Show("Vui lòng chạy phân bổ theo từng tháng!",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
                ACAllocationEquipmentTransController objAllocationEquipmentTransController = new ACAllocationEquipmentTransController();
                ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                List<ACAllocationEquipmentTransInfo> allocationEquipmentTrans = null;
                List<int> branchIDsDepreciated = null;
                if (!(BOSApp.CurrentCompanyInfo.CSCompanyStartDate.Month == ToDate.Month && BOSApp.CurrentCompanyInfo.CSCompanyStartDate.Year == ToDate.Year))
                {
                    allocationEquipmentTrans = objAllocationEquipmentTransController.GetAllocationEquipmentTransByMonthAndBranchIDs(ToDate.AddMonths(-1), SelectedBranchIDs);

                    List<ICShipmentItemsInfo> depreciatedEquipments = new List<ICShipmentItemsInfo>();
                    string[] branchIDs = SelectedBranchIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < branchIDs.Length; i++)
                    {
                        depreciatedEquipments.AddRange(objShipmentItemsController.GetEquipmentItemsForDepreciating(i, ToDate.AddMonths(-1)));
                    }
                    depreciatedEquipments = depreciatedEquipments.Where(t => t.ICProductIdentifiedEquipmentInitDepriciationMonths > 0).ToList();
                    if (allocationEquipmentTrans.Count() == 0 && depreciatedEquipments.Count() > 0 && DateTime.Compare(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Date, ToDate.AddMonths(-1).Date) < 0)
                    {
                        MessageBox.Show("Vui lòng chạy phân bổ tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }

                    branchIDsDepreciated = allocationEquipmentTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                    List<int> branchIDsUnDepreciate = new List<int>();
                    int x = 0;
                    branchIDs.All(o =>
                    {
                        x = 0;
                        if (Int32.TryParse(o, out x))
                        {
                            depreciatedEquipments = new List<ICShipmentItemsInfo>();
                            depreciatedEquipments.AddRange(objShipmentItemsController.GetEquipmentItemsForDepreciating(x, ToDate.AddMonths(-1)));
                            depreciatedEquipments = depreciatedEquipments.Where(t => t.ICProductIdentifiedEquipmentInitDepriciationMonths > 0).ToList();
                            if (!branchIDsDepreciated.Any(y => y == x) && depreciatedEquipments.Count() > 0)
                                branchIDsUnDepreciate.Add(x);
                        }
                        return true;
                    });

                    if (branchIDsUnDepreciate.Count() > 0 && DateTime.Compare(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Date, ToDate.AddMonths(-1).Date) < 0)
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        BRBranchsInfo objBranchsInfo = null;
                        string mes = string.Empty;
                        branchIDsUnDepreciate.ForEach(o =>
                        {
                            objBranchsInfo = objBranchsController.GetObjectByID(o) as BRBranchsInfo;
                            if (objBranchsInfo != null)
                                mes += Environment.NewLine + objBranchsInfo.BRBranchName;
                        });
                        MessageBox.Show("Vui lòng chạy khấu hao tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "  cho các chi nhánh sau:" + Environment.NewLine + mes,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }

                allocationEquipmentTrans = objAllocationEquipmentTransController.GetAllocationEquipmentTransByMonthAndBranchIDs(ToDate, SelectedBranchIDs);
                List<ACAllocationEquipmentTransInfo> branchIDDepreciateds = allocationEquipmentTrans.GroupBy(o => o.FK_BRBranchID).Select(o => o.First()).ToList();
                branchIDsDepreciated = allocationEquipmentTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                if (branchIDDepreciateds.Count() > 0)
                {
                    string mes = string.Empty;
                    branchIDDepreciateds.ForEach(o =>
                    {
                        mes += Environment.NewLine + o.BRBranchName;
                    });
                    MessageBox.Show("Các chi nhánh sau đã được chạy phân bổ cho tháng " + ToDate.Month + ":" + Environment.NewLine + mes,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (documentTypeName == AccDocumentType.PhanBoChiPhi.ToString())
            {
                if (months != 0)
                {
                    MessageBox.Show("Vui lòng chạy phân bổ theo từng tháng!",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
                ACAllocationCostObjectTransController objAllocationCostObjectTransController = new ACAllocationCostObjectTransController();
                ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
                List<ACAllocationCostObjectTransInfo> listAllocationCostObjectTransInfo = null;
                List<int> branchIDsDepreciated = null;
                if (!(BOSApp.CurrentCompanyInfo.CSCompanyStartDate.Month == ToDate.Month && BOSApp.CurrentCompanyInfo.CSCompanyStartDate.Year == ToDate.Year))
                {
                    listAllocationCostObjectTransInfo = objAllocationCostObjectTransController.GetAllocationCostObjectTransByMonthAndBranchIDs(ToDate.AddMonths(-1), SelectedBranchIDs);

                    List<ACCostObjectItemsInfo> listCostObjectItemsInfo = new List<ACCostObjectItemsInfo>();
                    string[] branchIDs = SelectedBranchIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < branchIDs.Length; i++)
                    {
                        listCostObjectItemsInfo.AddRange(objCostObjectItemsController.GetCostObjectItemsForAllocated(i, ToDate.AddMonths(-1)));
                    }
                    listCostObjectItemsInfo = listCostObjectItemsInfo.Where(t => t.ACCostObjectItemAllocationMonths > 0).ToList();
                    if (listAllocationCostObjectTransInfo.Count() == 0 && listCostObjectItemsInfo.Count() > 0 && DateTime.Compare(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Date, ToDate.AddMonths(-1).Date) < 0)
                    {
                        MessageBox.Show("Vui lòng chạy phân bổ tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy phân bổ tháng " + ToDate.Month + "!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }

                    branchIDsDepreciated = listAllocationCostObjectTransInfo.Select(o => o.FK_BRBranchID).Distinct().ToList();
                    List<int> branchIDsUnDepreciate = new List<int>();
                    int x = 0;
                    branchIDs.All(o =>
                    {
                        x = 0;
                        if (Int32.TryParse(o, out x))
                        {
                            listCostObjectItemsInfo = new List<ACCostObjectItemsInfo>();
                            listCostObjectItemsInfo.AddRange(objCostObjectItemsController.GetCostObjectItemsForAllocated(x, ToDate.AddMonths(-1)));
                            listCostObjectItemsInfo = listCostObjectItemsInfo.Where(t => t.ACCostObjectItemAllocationMonths > 0).ToList();
                            if (!branchIDsDepreciated.Any(y => y == x) && listCostObjectItemsInfo.Count() > 0)
                                branchIDsUnDepreciate.Add(x);
                        }
                        return true;
                    });

                    if (branchIDsUnDepreciate.Count() > 0 && DateTime.Compare(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Date, ToDate.AddMonths(-1).Date) < 0)
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        BRBranchsInfo objBranchsInfo = null;
                        string mes = string.Empty;
                        branchIDsUnDepreciate.ForEach(o =>
                        {
                            objBranchsInfo = objBranchsController.GetObjectByID(o) as BRBranchsInfo;
                            if (objBranchsInfo != null)
                                mes += Environment.NewLine + objBranchsInfo.BRBranchName;
                        });
                        MessageBox.Show("Vui lòng chạy phân bổ tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy phân bổ tháng " + ToDate.Month + "  cho các chi nhánh sau:" + Environment.NewLine + mes,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }

                listAllocationCostObjectTransInfo = objAllocationCostObjectTransController.GetAllocationCostObjectTransByMonthAndBranchIDs(ToDate, SelectedBranchIDs);
                List<ACAllocationCostObjectTransInfo> branchIDDepreciateds = listAllocationCostObjectTransInfo.GroupBy(o => o.FK_BRBranchID).Select(o => o.First()).ToList();
                branchIDsDepreciated = listAllocationCostObjectTransInfo.Select(o => o.FK_BRBranchID).Distinct().ToList();
                if (branchIDDepreciateds.Count() > 0)
                {
                    string mes = string.Empty;
                    branchIDDepreciateds.ForEach(o =>
                    {
                        mes += Environment.NewLine + o.BRBranchName;
                    });
                    MessageBox.Show("Các chi nhánh sau đã được chạy phân bổ cho tháng " + ToDate.Month + ":" + Environment.NewLine + mes,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            return result;
        }

        /// <summary>
        /// Calculate tax deduct at the end of a report period
        /// </summary>
        public void CalculateTaxDeduct()
        {
            ActionNew();
            CalculateTaxDeduct(false);
        }
        public void CalculateTaxDeduct(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
            }

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.KhauTruThue.ToString());
            if (objDocumentTypesInfo != null)
            {
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsGeneralAccountingByTpye(mainObject.FK_ACDocumentTypeID, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate)) return;

                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                mainObject.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                List<ACDocumentEntrysInfo> EntryList = objDocumentEntrysController.GetAccountTranferCostBySomeCriteria(mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate, AccDocumentType.KhauTruThue.ToString());
                entity.DocumentEntryList.Invalidate(EntryList);
                entity.DocumentEntryList.GridControl.RefreshDataSource();
                RefreshBriefDocumentEntrys();
            }
        }
        /// <summary>
        /// Evaluate foreign exchange difference at the end of a fiscal year
        /// </summary>        
        public void EvaluateForeignExchangeDiff()
        {
            ActionNew();

            DateTime startDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            DateTime endDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            guiEvaluateForeignExchangeDiff guiEvaluateExchangeRateDiff = new guiEvaluateForeignExchangeDiff(startDate, endDate);
            guiEvaluateExchangeRateDiff.Module = this;
            if (guiEvaluateExchangeRateDiff.ShowDialog() == DialogResult.OK)
            {
                DateTime fromDate = guiEvaluateExchangeRateDiff.FromDate;
                DateTime toDate = guiEvaluateExchangeRateDiff.ToDate;
                int currencyID = guiEvaluateExchangeRateDiff.CurrencyID;
                decimal exchangeRate = guiEvaluateExchangeRateDiff.ExchangeRate;
                List<ACAccountsInfo> SelectedAccountList = guiEvaluateExchangeRateDiff.SelectedAccountList;
                bool ByObject = guiEvaluateExchangeRateDiff.ByObject;
                bool ByInvoice = guiEvaluateExchangeRateDiff.ByInvoice;
                // 0: Tài sản (Phải thu) 
                // 1: Công nợ (Phải trả)
                int EvaluateType = guiEvaluateExchangeRateDiff.EvaluateType;


                GECurrenciesController objCurrencysController = new GECurrenciesController();
                string currencyNo = objCurrencysController.GetObjectNoByID(currencyID);
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.DanhGiaNgoaiTe.ToString());
                if (objDocumentTypesInfo != null)
                {
                    GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
                    ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
                    objDocumentsInfo.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                    objDocumentsInfo.FK_GECurrencyID = currencyID;
                    objDocumentsInfo.ACDocumentExchangeRate = exchangeRate;
                    List<ACDocumentEntrysInfo> EntryList = new List<ACDocumentEntrysInfo>();
                    if (EvaluateType == 0)
                    {
                        EntryList = objDocumentEntrysController.GetReceivableAssetEvaluateBySomeCriteria(fromDate, toDate
                                                                                                                , AccDocumentType.DanhGiaNgoaiTe.ToString()
                                                                                                                , currencyID, exchangeRate
                                                                                                                , string.Join(",", SelectedAccountList.Select(a => a.ACAccountID.ToString()).ToArray())
                                                                                                                , ByObject, ByInvoice);

                    }
                    else if (EvaluateType == 1)
                    {
                        EntryList = objDocumentEntrysController.GetPayableEvaluateBySomeCriteria(fromDate, toDate
                                                                                                                , AccDocumentType.DanhGiaNgoaiTe.ToString()
                                                                                                                , currencyID, exchangeRate
                                                                                                                , string.Join(",", SelectedAccountList.Select(a => a.ACAccountID.ToString()).ToArray())
                                                                                                                , ByObject, ByInvoice);
                    }
                    #region Frame Code


                    //ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                    //ACDocTypeEntrysInfo defaultEntry = (ACDocTypeEntrysInfo)objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                    //                                                                                                AccDocumentType.DanhGiaNgoaiTe.ToString(),
                    //                                                                                                AccEntryType.DanhGiaNgoaiTe.ToString());
                    //if (defaultEntry != null)
                    //{
                    //    ACAccountsController objAccountsController = new ACAccountsController();
                    //    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    //    List<ACAccountsInfo> accounts = objAccountsController.GetAccountsForEvaluatingExchangeRateDiff();
                    //    foreach (ACAccountsInfo account in accounts)
                    //    {
                    //        ACDocumentEntrysInfo entry = AccountHelper.GetDocumentEntryFromDefaultEntry(defaultEntry);
                    //        entry.ACDocumentEntryDesc += string.Format(" {0} {1} {2}", currencyNo, GeneralAccountingLocalizedResources.Of, account.ACAccountName);
                    //        decimal exchangeBalance = objDocumentEntrysController.GetAccountBalance(account.ACAccountNo, toDate, currencyID);
                    //        decimal balance = objDocumentEntrysController.GetAccountBalanceByCurrency(account.ACAccountNo, toDate, currencyID);
                    //        decimal profit = 0;
                    //        if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    //        {
                    //            profit = balance * exchangeRate - exchangeBalance;
                    //        }
                    //        else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    //        {
                    //            profit = exchangeBalance - balance * exchangeRate;
                    //        }

                    //        if (profit != 0)
                    //        {
                    //            if (profit > 0)
                    //            {
                    //                entry.FK_ACDebitAccountID = account.ACAccountID;
                    //            }
                    //            else
                    //            {
                    //                entry.FK_ACDebitAccountID = entry.FK_ACCreditAccountID;
                    //                entry.FK_ACCreditAccountID = account.ACAccountID;
                    //            }
                    //            entry.ACDocumentEntryAmount = 0;
                    //            entry.ACDocumentEntryExchangeAmount = Math.Abs(profit);
                    //            BOSApp.RoundByCurrency(entry, objDocumentsInfo.FK_GECurrencyID);
                    //            entity.DocumentEntryList.Add(entry);
                    //        }
                    //    }

                    //}
                    #endregion
                    entity.DocumentEntryList.Invalidate(EntryList);
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                    RefreshBriefDocumentEntrys();
                }
            }
            else
            {
                ActionCancel();
            }
        }

        /// <summary>
        /// Calculate income tax at the end of a report period
        /// </summary>
        public void CalculateIncomeTax()
        {
            ActionNew();
            CalculateIncomeTax(false);

        }
        public void CalculateIncomeTax(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
            }
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.TinhThueTNDN.ToString());
            if (objDocumentTypesInfo != null)
            {
                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                mainObject.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsGeneralAccountingByTpye(mainObject.FK_ACDocumentTypeID, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate)) return;

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo entry = (ACDocTypeEntrysInfo)objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                                AccDocumentType.TinhThueTNDN.ToString(),
                                                                                                                AccEntryType.TinhThueTNDN.ToString());
                if (entry != null)
                {
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    ACDocumentEntrysInfo objDocumentEntrysInfo = AccountHelper.AddItemToDocumentEntryList(entry, entity.DocumentEntryList);
                    //AccountCredit
                    decimal saleIncome = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc511, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (saleIncome < 0) saleIncome = Math.Abs(saleIncome); else saleIncome = 0;
                    //AccountDebit - AccountCredit
                    decimal saleDiscount = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc521, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    //AccountDebit - AccountCredit
                    decimal salePriceDeduct = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc532, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    //AccountDebit
                    decimal saleReturn = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc531, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (saleReturn < 0) saleReturn = 0;
                    //AccountCredit
                    decimal financialIncome = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc515, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (financialIncome < 0) financialIncome = Math.Abs(financialIncome); else financialIncome = 0;
                    //AccountCredit
                    decimal otherIncome = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc711, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (otherIncome < 0) otherIncome = Math.Abs(otherIncome); else otherIncome = 0;
                    //AccountDebit
                    decimal costOfGoodsSold = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc632, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (costOfGoodsSold < 0) costOfGoodsSold = 0;
                    //AccountDebit
                    decimal saleCost = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc641, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (saleCost < 0) saleCost = 0;
                    //AccountDebit
                    decimal managingCost = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc642, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (managingCost < 0) managingCost = 0;
                    //AccountDebit
                    decimal financialCost = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc635, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (financialCost < 0) financialCost = 0;
                    //AccountDebit
                    decimal otherCost = objDocumentEntrysController.GetTransactionAccountAmount(AccAccount.Acc811, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate);
                    if (otherCost < 0) otherCost = 0;
                    decimal incomeTax = saleIncome + financialIncome + otherIncome -
                                        (saleDiscount + salePriceDeduct + saleReturn + costOfGoodsSold + saleCost + managingCost +
                                        financialCost + otherCost);
                    if (incomeTax > 0)
                    {
                        objDocumentEntrysInfo.ACDocumentEntryAmount = incomeTax * BOSApp.CurrentCompanyInfo.CSCompanyIncomeTaxPercent / 100;
                        objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = objDocumentEntrysInfo.ACDocumentEntryAmount * mainObject.ACDocumentExchangeRate;
                    }
                    BOSApp.RoundByCurrency(objDocumentEntrysInfo, mainObject.FK_GECurrencyID);
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                    RefreshBriefDocumentEntrys();
                }
            }
        }
        /// <summary>
        /// Evaluate business result at the end of a report period
        /// </summary>
        public void EvaluateBusinessResult()
        {
            ActionNew();
            EvaluateBusinessResult(false);

        }
        public void EvaluateBusinessResult(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
            }
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.XacDinhKQKD.ToString());
            if (objDocumentTypesInfo != null)
            {

                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsGeneralAccountingByTpye(mainObject.FK_ACDocumentTypeID, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate)) return;

                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                mainObject.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                //mainObject.FK_ACObjectID = 1;
                mainObject.FK_ACObjectID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                mainObject.ACObjectType = BranchType.Branch.ToString();
                mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                List<ACDocumentEntrysInfo> EntryList = objDocumentEntrysController.GetEvaluateBusinessResultBySomeCriteria(mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate, AccDocumentType.XacDinhKQKD.ToString());
                entity.DocumentEntryList.Invalidate(EntryList);
                entity.DocumentEntryList.GridControl.RefreshDataSource();
                RefreshBriefDocumentEntrys();
            }
        }
        public void DepreciateAssets(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
                entity.DocumentEntryList.Clear();
                entity.DepreciationAssetTranList.Clear();
            }
            DateTime startDate = mainObject.ACDocumentInvoiceDate;
            DateTime endDate = mainObject.ACDocumentPaymentDueDate;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.KhauHaoTSCD.ToString());

            //guiAllocate guiAllocate = new guiAllocate(startDate, endDate, objDocumentTypesInfo.ACDocumentTypeID);
            //guiAllocate.Module = this;

            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
            if (objDocumentTypesInfo != null)
            {
                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                mainObject.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo entry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                AccDocumentType.KhauHaoTSCD.ToString(),
                                                                                                AccEntryType.KhauHaoTSCD.ToString());
                string[] branchIDs = branches != null ? branches.Select(o => o.BRBranchID.ToString()).ToArray() : new[] { mainObject.FK_BRBranchID.ToString() };
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsDoc(mainObject.ACDocumentTypeName, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate,
                        (branchIDs != null && branchIDs.Length > 0) ? string.Join(",", branchIDs) :
                        mainObject.FK_BRBranchID.ToString())) return;

                List<ACDocumentEntrysInfo> list = new List<ACDocumentEntrysInfo>();
                if (entry != null)
                {
                    ACAssetsController objAssetsController = new ACAssetsController();
                    ACAssetTransferItemsController objAssetTransferItemsController = new ACAssetTransferItemsController();
                    ACDepreciationAssetTransInfo objDepreciationAssetTransInfo = null;

                    for (int i = 0; i < branchIDs.Length; i++)
                    {
                        int branchID = Convert.ToInt32(branchIDs[i]);
                        List<ACAssetsInfo> depreciatedAssets = objAssetsController.GetAssetsForDepreciating(branchID, endDate);
                        foreach (ACAssetsInfo objAssetsInfo in depreciatedAssets)
                        {
                            int depreciationMonths = Convert.ToInt32(Math.Floor((endDate.Subtract(startDate).Days + 1) / 28.0));
                            decimal depreciatedAmount = Math.Min(objAssetsInfo.ACAssetDepreciationAmount * depreciationMonths, objAssetsInfo.ACAssetRemainedAmount);
                            objDepreciationAssetTransInfo = new ACDepreciationAssetTransInfo();
                            objDepreciationAssetTransInfo.FK_ACAssetID = objAssetsInfo.ACAssetID;
                            objDepreciationAssetTransInfo.ACAssetName = objAssetsInfo.ACAssetName;
                            objDepreciationAssetTransInfo.FK_BRBranchID = branchID;
                            objDepreciationAssetTransInfo.FK_ACAdjustIncreaseOrDecreaseAssetID = objAssetsInfo.FK_ACAdjustIncreaseOrDecreaseAssetID;
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranYear = endDate.Year;
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranPeriod = endDate.Month;
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranDate = endDate.Date;
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranIsEdit = false;
                            objDepreciationAssetTransInfo.FK_ACAccountID = objAssetsInfo.FK_ACAccountID;
                            objDepreciationAssetTransInfo.FK_ACDepreciationAccountID = objAssetsInfo.FK_ACDepreciationAccountID;
                            objDepreciationAssetTransInfo.FK_ACDepreciationCostAccountID = objAssetsInfo.FK_ACDepreciationCostAccountID;
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranOriginalAmount = Math.Round(objAssetsInfo.ACAssetOriginalAmount);
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranDepreciatedAmount = Math.Round(objAssetsInfo.ACAssetDepreciatedAmount);
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranRemainedAmount = Math.Round(objAssetsInfo.ACAssetRemainedAmount);
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranAmount = Math.Round(depreciatedAmount);
                            objDepreciationAssetTransInfo.FK_ACCostCenterID = objAssetsInfo.FK_ACCostCenterID;
                            objDepreciationAssetTransInfo.FK_ACSegmentID = objAssetsInfo.FK_ACSegmentID;
                            objDepreciationAssetTransInfo.FK_HRDepartmentID = objAssetsInfo.FK_HRDepartmentID;
                            objDepreciationAssetTransInfo.FK_HRDepartmentRoomID = objAssetsInfo.FK_HRDepartmentRoomID;
                            objDepreciationAssetTransInfo.FK_MMWorkShopID = objAssetsInfo.FK_MMWorkShopID;
                            objDepreciationAssetTransInfo.FK_MMLineID = objAssetsInfo.FK_MMLineID;
                            objDepreciationAssetTransInfo.FK_HRDepartmentRoomGroupItemID = objAssetsInfo.FK_HRDepartmentRoomGroupItemID;
                            objDepreciationAssetTransInfo.ACDepreciationAssetTranAdjustType = objAssetsInfo.ACAdjustIncreaseOrDecreaseAssetType;
                            entity.DepreciationAssetTranList.Add(objDepreciationAssetTransInfo);
                        }
                    }
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                    entity.DepreciationAssetTranList.GridControl.RefreshDataSource();
                    InvalidateDocumentEntrys(entity.DepreciationAssetTranList);
                }
            }
        }
        /// <summary>
        /// Depreciate assets at the end of a report period
        /// </summary>
        public void DepreciateAssets()
        {
            ActionNew();
            if (PageDepreciationAssetTran != null)
                PageDepreciationAssetTran.PageVisible = true;
            DepreciateAssets(false);
        }

        public void AllocateEquipments(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
                entity.DocumentEntryList.Clear();
                entity.AllocationEquipmentTranList.Clear();
            }

            DateTime startDate = mainObject.ACDocumentInvoiceDate;
            DateTime endDate = mainObject.ACDocumentPaymentDueDate;
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.PhanBoCCDC.ToString());
            if (objDocumentTypesInfo != null)
            {

                objDocumentsInfo.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                objDocumentsInfo.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;

                string[] branchIDs = branches != null ? branches.Select(o => o.BRBranchID.ToString()).ToArray() : new[] { mainObject.FK_BRBranchID.ToString() };
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsDoc(mainObject.ACDocumentTypeName, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate,
                        (branchIDs != null && branchIDs.Length > 0) ? string.Join(",", branchIDs) :
                        mainObject.FK_BRBranchID.ToString())) return;

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo entry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                AccDocumentType.PhanBoCCDC.ToString(),
                                                                                                AccEntryType.PhanBoCCDC.ToString());
                if (entry != null)
                {
                    ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                    ACAllocationEquipmentTransInfo objAllocationEquipmentTransInfo = null;

                    for (int i = 0; i < branchIDs.Length; i++)
                    {
                        int branchID = Convert.ToInt32(branchIDs[i]);
                        List<ICShipmentItemsInfo> depreciatedEquipments = objShipmentItemsController.GetEquipmentItemsForDepreciating(branchID, endDate);
                        depreciatedEquipments = depreciatedEquipments.Where(t => t.ICProductIdentifiedEquipmentInitDepriciationMonths > 0).ToList();

                        foreach (ICShipmentItemsInfo item in depreciatedEquipments)
                        {
                            decimal depreciationAmount = item.ICProductIdentifiedEquipmentOriginalAmount / item.ICProductIdentifiedEquipmentInitDepriciationMonths;
                            int depreciationMonths = Convert.ToInt32(Math.Floor((endDate.Subtract(startDate).Days + 1) / 28.0));
                            decimal depreciatedAmount = Math.Min(depreciationAmount * depreciationMonths, item.ICProductIdentifiedEquipmentOriginalAmount - item.ICProductIdentifiedEquipmentDepriciatedAmount);

                            objAllocationEquipmentTransInfo = new ACAllocationEquipmentTransInfo();
                            objAllocationEquipmentTransInfo.FK_ICProductID = item.FK_ICProductID;
                            objAllocationEquipmentTransInfo.FK_BRBranchID = branchID;
                            objAllocationEquipmentTransInfo.FK_ICProductIdentifiedEquipmentID = item.ICProductIdentifiedEquipmentID;
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranYear = endDate.Year;
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranPeriod = endDate.Month;
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranDate = endDate.Date;
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranIsEdit = false;
                            ICProductsController objProductsController = new ICProductsController();
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                objAllocationEquipmentTransInfo.FK_ACAllocationAccountID = objProductsInfo.FK_ACDepreciationAccountID;
                            }
                            objAllocationEquipmentTransInfo.FK_ACAllocationCostAccountID = item.FK_ACDepreciationCostAccountID;
                            ICProductIdentifiedEquipmentsController objPIEquipmentsController = new ICProductIdentifiedEquipmentsController();
                            ICProductIdentifiedEquipmentsInfo objPIEquipmentsInfo = objPIEquipmentsController.GetObjectByID(item.ICProductIdentifiedEquipmentID) as ICProductIdentifiedEquipmentsInfo;
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranOriginalAmount = Math.Round(objPIEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount);
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranDepreciatedAmount = Math.Round(objPIEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount
                                                                                                                    + objPIEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciatedAmount);
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranRemainedAmount = Math.Round(objPIEquipmentsInfo.ICProductIdentifiedEquipmentOriginalAmount
                                                                                                                    - objPIEquipmentsInfo.ICProductIdentifiedEquipmentInitDepriciatedAmount
                                                                                                                    - objPIEquipmentsInfo.ICProductIdentifiedEquipmentDepriciatedAmount);
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranAmount = Math.Round(depreciatedAmount);
                            objAllocationEquipmentTransInfo.ACAllocationEquipmentTranQty = 1;

                            objAllocationEquipmentTransInfo.FK_ACCostCenterID = objPIEquipmentsInfo.FK_ACCostCenterID;
                            objAllocationEquipmentTransInfo.FK_ACSegmentID = objPIEquipmentsInfo.FK_ACSegmentID;
                            objAllocationEquipmentTransInfo.FK_HRDepartmentID = objPIEquipmentsInfo.FK_HRDepartmentID;
                            objAllocationEquipmentTransInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                            objAllocationEquipmentTransInfo.FK_MMWorkShopID = objPIEquipmentsInfo.FK_MMWorkShopID;
                            objAllocationEquipmentTransInfo.FK_MMLineID = objPIEquipmentsInfo.FK_MMLineID;
                            objAllocationEquipmentTransInfo.FK_HRDepartmentRoomGroupItemID = objPIEquipmentsInfo.FK_HRDepartmentRoomGroupItemID;
                            entity.AllocationEquipmentTranList.Add(objAllocationEquipmentTransInfo);
                        }
                    }
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                    entity.AllocationEquipmentTranList.GridControl.RefreshDataSource();
                    InvalidateDocumentEntrys(entity.AllocationEquipmentTranList);
                    RefreshBriefDocumentEntrys();
                }
            }
        }
        /// <summary>
        /// Allocate equipments at the end of a report period
        /// </summary>
        public void AllocateEquipments()
        {
            ActionNew();
            if (PageAllocationEquipmentTran != null)
                PageAllocationEquipmentTran.PageVisible = true;
            AllocateEquipments(false);
        }

        public override int GetDocumentTypeID()
        {
            ACDocumentsInfo document = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            return document.FK_ACDocumentTypeID;
        }

        private void InvalidateDocumentEntrys(List<ACDepreciationAssetTransInfo> depreciationAssetTrans)
        {
            List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentTypesController documentTypeController = new ACDocumentTypesController();
            ACDocumentTypesInfo documentType = documentTypeController.GetObjectByID(mainObject.FK_ACDocumentTypeID) as ACDocumentTypesInfo;
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                    AccDocumentType.KhauHaoTSCD.ToString(),
                                                                                                    AccEntryType.KhauHaoTSCD.ToString());
            string documentEntryDesc = string.Empty;
            if (documentType != null)
                documentEntryDesc = documentType.ACDocumentTypeDesc;
            if (depreciationAssetTrans != null)
            {
                depreciationAssetTrans.GroupBy(o => new { o.FK_ACDepreciationCostAccountID, o.FK_ACDepreciationAccountID, o.FK_ACCostCenterID, o.FK_ACSegmentID, o.FK_PMProjectID, o.FK_BRBranchID }).All(o =>
                {
                    ACDocumentEntrysInfo objDocumentEntrysInfo = documentEntrys.FirstOrDefault(n => n.FK_ACCreditAccountID == o.Key.FK_ACDepreciationAccountID
                                                                                                && n.FK_ACDebitAccountID == o.Key.FK_ACDepreciationCostAccountID
                                                                                                && n.FK_ACCostCenterID == o.Key.FK_ACCostCenterID
                                                                                                && n.FK_ACSegmentID == o.Key.FK_ACSegmentID
                                                                                                && n.FK_PMProjectID == o.Key.FK_PMProjectID
                                                                                                && n.FK_BRCostedBranchID == o.Key.FK_BRBranchID);
                    if (objDocumentEntrysInfo == null)
                    {
                        objDocumentEntrysInfo = AccountHelper.AddItemToDocumentEntryList(objDocTypeEntrysInfo, entity.DocumentEntryList);
                        objDocumentEntrysInfo.FK_ACCostCenterID = o.Key.FK_ACCostCenterID;
                        objDocumentEntrysInfo.FK_ACSegmentID = o.Key.FK_ACSegmentID;
                        objDocumentEntrysInfo.FK_PMProjectID = o.Key.FK_PMProjectID;
                        objDocumentEntrysInfo.FK_ACCreditAccountID = o.Key.FK_ACDepreciationAccountID;
                        objDocumentEntrysInfo.FK_ACDebitAccountID = o.Key.FK_ACDepreciationCostAccountID;
                        objDocumentEntrysInfo.FK_BRCostedBranchID = o.Key.FK_BRBranchID;
                        documentEntrys.Add(objDocumentEntrysInfo);
                    }
                    return true;
                });
            }

            documentEntrys.ForEach(o =>
                {
                    List<ACDepreciationAssetTransInfo> depreciationAssetTransList = new List<ACDepreciationAssetTransInfo>();
                    depreciationAssetTransList = depreciationAssetTrans.Where(n => n.FK_ACDepreciationAccountID == o.FK_ACCreditAccountID
                                                                            && n.FK_ACDepreciationCostAccountID == o.FK_ACDebitAccountID
                                                                            && n.FK_ACCostCenterID == o.FK_ACCostCenterID
                                                                            && n.FK_ACSegmentID == o.FK_ACSegmentID
                                                                            && n.FK_PMProjectID == o.FK_PMProjectID).ToList();
                    o.ACDocumentEntryAmount = depreciationAssetTransList.Where(n => string.IsNullOrEmpty(n.ACDepreciationAssetTranAdjustType))
                                                                        .Sum(n => n.ACDepreciationAssetTranAmount)
                                                + depreciationAssetTransList.Where(n => n.ACDepreciationAssetTranAdjustType == AdjustIncreaseOrDecreaseAssetType.Increase.ToString())
                                                                        .Sum(n => n.ACDepreciationAssetTranAmount)
                                                - depreciationAssetTransList.Where(n => n.ACDepreciationAssetTranAdjustType == AdjustIncreaseOrDecreaseAssetType.Decrease.ToString())
                                                                        .Sum(n => n.ACDepreciationAssetTranAmount);

                    o.ACDocumentEntryExchangeAmount = o.ACDocumentEntryAmount * mainObject.ACDocumentExchangeRate;
                    BOSApp.RoundByCurrency(o, mainObject.FK_GECurrencyID);
                });

            entity.DocumentEntryList.Invalidate(documentEntrys);
        }

        private void InvalidateDocumentEntrys(List<ACAllocationEquipmentTransInfo> allocationEquipmentTrans)
        {
            List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentTypesController documentTypeController = new ACDocumentTypesController();
            ACDocumentTypesInfo documentType = documentTypeController.GetObjectByID(mainObject.FK_ACDocumentTypeID) as ACDocumentTypesInfo;
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                    AccDocumentType.PhanBoCCDC.ToString(),
                                                                                                    AccEntryType.PhanBoCCDC.ToString());
            string documentEntryDesc = string.Empty;
            if (documentType != null)
                documentEntryDesc = documentType.ACDocumentTypeDesc;
            if (allocationEquipmentTrans != null)
            {
                allocationEquipmentTrans.GroupBy(o => new { o.FK_ACAllocationCostAccountID, o.FK_ACAllocationAccountID, o.FK_ACCostCenterID, o.FK_ACSegmentID, o.FK_PMProjectID, o.FK_BRBranchID }).All(o =>
                {
                    ACDocumentEntrysInfo objDocumentEntrysInfo = documentEntrys.FirstOrDefault(n => n.FK_ACCreditAccountID == o.Key.FK_ACAllocationAccountID
                                                                                                && n.FK_ACDebitAccountID == o.Key.FK_ACAllocationCostAccountID
                                                                                                && n.FK_ACCostCenterID == o.Key.FK_ACCostCenterID
                                                                                                && n.FK_ACSegmentID == o.Key.FK_ACSegmentID
                                                                                                && n.FK_PMProjectID == o.Key.FK_PMProjectID
                                                                                                && n.FK_BRCostedBranchID == o.Key.FK_BRBranchID);
                    if (objDocumentEntrysInfo == null)
                    {
                        objDocumentEntrysInfo = AccountHelper.AddItemToDocumentEntryList(objDocTypeEntrysInfo, entity.DocumentEntryList);
                        objDocumentEntrysInfo.FK_ACCostCenterID = o.Key.FK_ACCostCenterID;
                        objDocumentEntrysInfo.FK_ACSegmentID = o.Key.FK_ACSegmentID;
                        objDocumentEntrysInfo.FK_PMProjectID = o.Key.FK_PMProjectID;
                        objDocumentEntrysInfo.FK_ACCreditAccountID = o.Key.FK_ACAllocationAccountID;
                        objDocumentEntrysInfo.FK_ACDebitAccountID = o.Key.FK_ACAllocationCostAccountID;
                        objDocumentEntrysInfo.FK_BRCostedBranchID = o.Key.FK_BRBranchID;
                        documentEntrys.Add(objDocumentEntrysInfo);
                    }
                    return true;
                });
            }

            documentEntrys.ForEach(o =>
            {
                o.ACDocumentEntryAmount = allocationEquipmentTrans.Where(n => n.FK_ACAllocationAccountID == o.FK_ACCreditAccountID
                                                                            && n.FK_ACAllocationCostAccountID == o.FK_ACDebitAccountID
                                                                            && n.FK_ACCostCenterID == o.FK_ACCostCenterID
                                                                            && n.FK_ACSegmentID == o.FK_ACSegmentID
                                                                            && n.FK_PMProjectID == o.FK_PMProjectID).Sum(n => n.ACAllocationEquipmentTranAmount);

                o.ACDocumentEntryExchangeAmount = o.ACDocumentEntryAmount * mainObject.ACDocumentExchangeRate;
                BOSApp.RoundByCurrency(o, mainObject.FK_GECurrencyID);
            });

            entity.DocumentEntryList.Invalidate(documentEntrys);
        }

        private void InvalidateDocumentEntrys(List<ACAllocationCostObjectTransInfo> allocationCostObjectTrans)
        {
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (mainObject.ACDocumentID > 0)
            {
                entity.DocumentEntryList.ForEach(o =>
                {
                    o.ACDocumentEntryAmount = allocationCostObjectTrans.Where(n => n.FK_ACDepreciationWaitAccountID == o.FK_ACCreditAccountID
                                                                                && n.FK_ACCostAccountID == o.FK_ACDebitAccountID
                                                                                && n.FK_ACCostCenterID == o.FK_ACCostCenterID
                                                                                && n.FK_ACSegmentID == o.FK_ACSegmentID
                                                                                && n.FK_PMProjectID == o.FK_PMProjectID).Sum(n => n.ACAllocationCostObjectTranAmount);

                    o.ACDocumentEntryExchangeAmount = o.ACDocumentEntryAmount * mainObject.ACDocumentExchangeRate;
                    BOSApp.RoundByCurrency(o, mainObject.FK_GECurrencyID);
                });
            }
            else
            {
                List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
                ACDocumentTypesController documentTypeController = new ACDocumentTypesController();
                ACDocumentTypesInfo documentType = documentTypeController.GetObjectByID(mainObject.FK_ACDocumentTypeID) as ACDocumentTypesInfo;
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo objDocTypeEntrysInfo = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                        AccDocumentType.PhanBoChiPhi.ToString(),
                                                                                                        AccEntryType.PhanBoChiPhiTraTruoc.ToString());
                string documentEntryDesc = string.Empty;
                if (documentType != null)
                    documentEntryDesc = documentType.ACDocumentTypeDesc;
                if (allocationCostObjectTrans != null)
                {
                    allocationCostObjectTrans.GroupBy(o => new { o.FK_ACCostAccountID, o.FK_ACDepreciationWaitAccountID, o.FK_ACCostCenterID, o.FK_ACSegmentID, o.FK_PMProjectID, o.FK_BRBranchID }).All(o =>
                    {
                        ACDocumentEntrysInfo objDocumentEntrysInfo = documentEntrys.FirstOrDefault(n => n.FK_ACCreditAccountID == o.Key.FK_ACDepreciationWaitAccountID
                                                                                                    && n.FK_ACDebitAccountID == o.Key.FK_ACCostAccountID
                                                                                                    && n.FK_ACCostCenterID == o.Key.FK_ACCostCenterID
                                                                                                    && n.FK_ACSegmentID == o.Key.FK_ACSegmentID
                                                                                                    && n.FK_PMProjectID == o.Key.FK_PMProjectID
                                                                                                    && n.FK_BRCostedBranchID == o.Key.FK_BRBranchID);
                        if (objDocumentEntrysInfo == null)
                        {
                            objDocumentEntrysInfo = AccountHelper.AddItemToDocumentEntryList(objDocTypeEntrysInfo, entity.DocumentEntryList);
                            objDocumentEntrysInfo.FK_ACCostCenterID = o.Key.FK_ACCostCenterID;
                            objDocumentEntrysInfo.FK_ACSegmentID = o.Key.FK_ACSegmentID;
                            objDocumentEntrysInfo.FK_PMProjectID = o.Key.FK_PMProjectID;
                            objDocumentEntrysInfo.FK_ACCreditAccountID = o.Key.FK_ACDepreciationWaitAccountID;
                            objDocumentEntrysInfo.FK_ACDebitAccountID = o.Key.FK_ACCostAccountID;
                            objDocumentEntrysInfo.FK_BRCostedBranchID = o.Key.FK_BRBranchID;
                            documentEntrys.Add(objDocumentEntrysInfo);
                        }
                        return true;
                    });
                }

                documentEntrys.ForEach(o =>
                {
                    o.ACDocumentEntryAmount = allocationCostObjectTrans.Where(n => n.FK_ACDepreciationWaitAccountID == o.FK_ACCreditAccountID
                                                                                && n.FK_ACCostAccountID == o.FK_ACDebitAccountID
                                                                                && n.FK_ACCostCenterID == o.FK_ACCostCenterID
                                                                                && n.FK_ACSegmentID == o.FK_ACSegmentID
                                                                                && n.FK_PMProjectID == o.FK_PMProjectID).Sum(n => n.ACAllocationCostObjectTranAmount);

                    o.ACDocumentEntryExchangeAmount = o.ACDocumentEntryAmount * mainObject.ACDocumentExchangeRate;
                    BOSApp.RoundByCurrency(o, mainObject.FK_GECurrencyID);
                });
                entity.DocumentEntryList.Invalidate(documentEntrys);
            }
        }
        protected override void InvalidateAccountingEntries()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString())
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                string documentNo = GetCurrentDocumentNo();
                entity.DocumentTypeID = GetDocumentTypeID();
                entity.DocumentList = objDocumentsController.GetRelativeDocumentsByDocumentTypeIDAndDocumentNo(entity.DocumentTypeID, documentNo);
                List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
                foreach (ACDocumentsInfo objDocumentsInfo in entity.DocumentList)
                {
                    List<ACDocumentEntrysInfo> result = objDocumentEntrysController.GetDocumentEntryByDocumentID(objDocumentsInfo.ACDocumentID);
                    entries = entries.Concat(result).ToList();
                }
                entity.DocumentEntryList.Invalidate(entries.OrderBy(p => p.ACDocumentEntryID).ToList());
                if (entity.DocumentEntryList.GridControl != null)
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
            }
            else
                base.InvalidateAccountingEntries();
        }
        private void InvalidateBriefDocumentEntrys(List<ACDocumentEntrysInfo> entries)
        {
            List<ACDocumentEntrysInfo> list = new List<ACDocumentEntrysInfo>();
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentTypesController documentTypeController = new ACDocumentTypesController();
            ACDocumentTypesInfo documentType = documentTypeController.GetObjectByID(mainObject.FK_ACDocumentTypeID) as ACDocumentTypesInfo;
            string documentEntryDesc = string.Empty;
            if (documentType != null)
                documentEntryDesc = documentType.ACDocumentTypeDesc;
            if (entries != null)
            {
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    ACDocumentEntrysInfo foundItem = list.FirstOrDefault(item => item.FK_ACCreditAccountID == entry.FK_ACCreditAccountID
                                                                                && item.FK_ACDebitAccountID == entry.FK_ACDebitAccountID);
                    if (foundItem == null)
                    {
                        foundItem = entry.Clone() as ACDocumentEntrysInfo;
                        foundItem.ACDocumentEntryDesc = documentEntryDesc;
                        BOSApp.RoundByCurrency(foundItem, mainObject.FK_GECurrencyID);
                        list.Add(foundItem);
                    }
                    else
                    {
                        foundItem.ACDocumentEntryAmount += entry.ACDocumentEntryAmount;
                        foundItem.ACDocumentEntryExchangeAmount += entry.ACDocumentEntryExchangeAmount;
                        foundItem.ACDocumentEntryDebitAmount += entry.ACDocumentEntryDebitAmount;
                        foundItem.ACDocumentEntryDebitExchangeAmount += entry.ACDocumentEntryDebitExchangeAmount;
                        foundItem.ACDocumentEntryCreditAmount += entry.ACDocumentEntryCreditAmount;
                        foundItem.ACDocumentEntryCreditExchangeAmount += entry.ACDocumentEntryCreditExchangeAmount;
                    }
                    if(mainObject.ACDocumentID <= 0)
                    {
                        foundItem.ACDocumentEntryDebitAmount = foundItem.ACDocumentEntryAmount;
                        foundItem.ACDocumentEntryDebitExchangeAmount = foundItem.ACDocumentEntryExchangeAmount;
                    }
                }
            }

            entity.BriefDocumentEntryList.Invalidate(list);
        }

        public void RefreshBriefDocumentEntrys()
        {
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            InvalidateBriefDocumentEntrys(entity.DocumentEntryList);
        }
        public void ChangeDate()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (Toolbar.IsEditAction())
                return;
            mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(mainObject.ACDocumentDate);
            mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(mainObject.ACDocumentDate);
            entity.UpdateMainObjectBindingSource();
        }
        public void RefreshData()
        {
            GeneralAccountingEntities entity = CurrentModuleEntity as GeneralAccountingEntities;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            switch (mainObject.STToolbarActionName)
            {
                case "KhauTruThue":
                    CalculateTaxDeduct(true);
                    break;
                case "TinhThueTNDN":
                    CalculateIncomeTax(true);
                    break;
                case "KhauHaoTSCD":
                    DepreciateAssets(true);
                    break;
                case "PhanBoCCDC":
                    AllocateEquipments(true);
                    break;
                case "XacDinhKQKD":
                    EvaluateBusinessResult(true);
                    break;
                case "PhanBoChiPhi":
                    AllocateCost(true);
                    break;
                case "KetChuyenChiPhi":
                    KetChuyenChiPhi(true);
                    break;
                case "KetChuyenNghiemThuDuAn":
                    GetKetChuyenNghiemThuDuAn(true);
                    break;
                default:
                    break;
            }
        }

        #region Data locking
        /// <summary>
        /// Called when the user wants to lock data
        /// </summary>
        public void LockData()
        {
            guiDataLocks guiDataLocks = new guiDataLocks();
            guiDataLocks.Module = this;
            guiDataLocks.ShowDialog();
        }

        /// <summary>
        /// View data locks based on some criteria
        /// </summary>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        public void ViewDataLocks(DateTime fromDate, DateTime toDate)
        {
            ADLocksController objLocksController = new ADLocksController();
            List<ADLocksInfo> locks = objLocksController.GetLockList(fromDate, toDate);
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            entity.LockList.Invalidate(locks);
        }

        /// <summary>
        /// Called when the user wants to add a new data lock
        /// </summary>
        public void AddDataLock()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            entity.SetDefaultModuleObject(TableName.ADLocksTableName);
            ADLocksInfo lockInfo = (ADLocksInfo)entity.ModuleObjects[TableName.ADLocksTableName];
            lockInfo.ADLockFromDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            lockInfo.ADLockToDate = BOSApp.GetPeriodEndDate(DateTime.Now);

            guiEditLock guiEditLock = new guiEditLock();
            guiEditLock.Module = this;
            if (guiEditLock.ShowDialog() == DialogResult.OK)
            {
                ADLocksController objLocksController = new ADLocksController();
                objLocksController.CreateObject(lockInfo);
                entity.LockList.AddObjectToList();
            }
        }

        /// <summary>
        /// Called when the user wants to edit a data lock
        /// </summary>
        /// <param name="lockInfo">Edited lock</param>
        public void EditDataLock(ADLocksInfo lockInfo)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            entity.ModuleObjects[TableName.ADLocksTableName] = (ADLocksInfo)lockInfo.Clone();
            entity.UpdateModuleObjectBindingSource(TableName.ADLocksTableName);

            guiEditLock guiEditLock = new guiEditLock();
            guiEditLock.Module = this;
            if (guiEditLock.ShowDialog() == DialogResult.OK)
            {
                ADLocksController objLocksController = new ADLocksController();
                lockInfo = (ADLocksInfo)entity.ModuleObjects[TableName.ADLocksTableName].Clone();
                lockInfo.AAUpdatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                objLocksController.UpdateObject(lockInfo);
                entity.LockList.ChangeObjectFromList();
            }
        }
        public void KetChuyenChiPhi(bool isRefresh)
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
                }
            }

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.KetChuyenChiPhi.ToString());
            if (objDocumentTypesInfo != null)
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
                objDocumentsInfo.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                objDocumentsInfo.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsGeneralAccountingByTpye(mainObject.FK_ACDocumentTypeID, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate)) return;

                List<ACDocumentEntrysInfo> EntryList = objDocumentEntrysController.GetAccountTranferCostBySomeCriteria(mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate, AccDocumentType.KetChuyenChiPhi.ToString());
                entity.DocumentEntryList.Invalidate(EntryList);
                entity.DocumentEntryList.GridControl.RefreshDataSource();
                RefreshBriefDocumentEntrys();
            }
        }
        public void KetChuyenChiPhi()
        {
            ActionNew();
            KetChuyenChiPhi(false);
        }
        public void KetChuyenNghiemThuDuAn()
        {
            ActionNew();
            GetKetChuyenNghiemThuDuAn(false);
        }
        public void GetKetChuyenNghiemThuDuAn(bool isRefresh)
        {

            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!isRefresh)
            {
                mainObject.ACDocumentInvoiceDate = BOSApp.GetPeriodStartDate(DateTime.Now);
                mainObject.ACDocumentPaymentDueDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            }
            else
            {
                if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                    GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);

                }
                entity.DocumentEntryList.Clear();
            }

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName("KetChuyenNghiemThuDuAn");
            if (objDocumentTypesInfo != null)
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();

                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                mainObject.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;
                if (mainObject.ACDocumentID == 0)
                    if (!CheckExitsGeneralAccountingByTpye(mainObject.FK_ACDocumentTypeID, mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate)) return;
                List<ACDocumentEntrysInfo> EntryList = objDocumentEntrysController.GetProjectTranferCostBySomeCriteria(mainObject.ACDocumentInvoiceDate, mainObject.ACDocumentPaymentDueDate, "KetChuyenNghiemThuDuAn");
                entity.DocumentEntryList.Invalidate(EntryList);
                entity.DocumentEntryList.GridControl.RefreshDataSource();
                entity.UpdateMainObjectBindingSource();
                RefreshBriefDocumentEntrys();
            }
        }

        public void PhanBoChiPhi6279()
        {
            ActionNew();
            MMProductionCostsController productionCostsController = new MMProductionCostsController();

            List<MMProductionCostsInfo> productionCostList = productionCostsController.GetProductionCost(ProductionCostType.ProductionCost.ToString());

            guiFind<MMProductionCostsInfo> guiFind = new guiFind<MMProductionCostsInfo>("MMProductionCosts",
                                                                                        productionCostList,
                                                                                        this,
                                                                                        false);
            guiFind.Module = this;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                int productionCostID = int.Parse(guiFind.Tag.ToString());
                if (productionCostID > 0)
                {
                    MMProductionCostsInfo productionCostsInfo = productionCostList.FirstOrDefault(t => t.MMProductionCostID == productionCostID);
                    if (productionCostsInfo != null)
                    {
                        ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                        ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.PhanBoChiPhi6279.ToString());
                        if (objDocumentTypesInfo != null)
                        {
                            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
                            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
                            objDocumentsInfo.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                            objDocumentsInfo.ACDocumentTypeName = objDocumentTypesInfo.ACDocumentTypeName;

                            DateTime fromDate = productionCostsInfo.MMProductionCostFromDate;
                            DateTime toDate = productionCostsInfo.MMProductionCostToDate;
                            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                            ACAccountsController objAccountsController = new ACAccountsController();
                            List<ACDocTypeEntrysInfo> entries = new List<ACDocTypeEntrysInfo>();
                            List<ACDocTypeEntrysInfo> result = objDocTypeEntrysController.GetEntriesByDocumentType(AccDocumentType.PhanBoChiPhi6279.ToString());

                            List<ACAccountsInfo> subAccounts = new List<ACAccountsInfo>();
                            foreach (ACDocTypeEntrysInfo entry in result)
                            {
                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanPhoi.ToString())
                                {
                                    subAccounts = objAccountsController.GetSubAccountsByAccountNo(entry.DefaultCreditAccountNo);
                                    subAccounts = subAccounts.Where(a => !subAccounts.Exists(sa => sa.ACAccountParentID == a.ACAccountID)).ToList();
                                    foreach (ACAccountsInfo account in subAccounts)
                                    {
                                        ACDocTypeEntrysInfo subEntry = (ACDocTypeEntrysInfo)entry.Clone();
                                        subEntry.ACDocTypeEntryAccountDefaultCredit = account.ACAccountID;
                                        subEntry.DefaultCreditAccountNo = account.ACAccountNo;
                                        subEntry.ACEntryTypeDesc = string.Format("{0} {1} {2}", GeneralAccountingLocalizedResources.TransferAccount, account.ACAccountName, "công đoạn Phôi");
                                        entries.Add(subEntry);
                                    }
                                }

                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanSoChe.ToString())
                                {
                                    subAccounts = objAccountsController.GetSubAccountsByAccountNo(entry.DefaultCreditAccountNo);
                                    subAccounts = subAccounts.Where(a => !subAccounts.Exists(sa => sa.ACAccountParentID == a.ACAccountID)).ToList();
                                    foreach (ACAccountsInfo account in subAccounts)
                                    {
                                        ACDocTypeEntrysInfo subEntry = (ACDocTypeEntrysInfo)entry.Clone();
                                        subEntry.ACDocTypeEntryAccountDefaultCredit = account.ACAccountID;
                                        subEntry.DefaultCreditAccountNo = account.ACAccountNo;
                                        subEntry.ACEntryTypeDesc = string.Format("{0} {1} {2}", GeneralAccountingLocalizedResources.TransferAccount, account.ACAccountName, "công đoạn sơ chế");
                                        entries.Add(subEntry);
                                    }
                                }

                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanTinhChe.ToString())
                                {
                                    subAccounts = objAccountsController.GetSubAccountsByAccountNo(entry.DefaultCreditAccountNo);
                                    subAccounts = subAccounts.Where(a => !subAccounts.Exists(sa => sa.ACAccountParentID == a.ACAccountID)).ToList();
                                    foreach (ACAccountsInfo account in subAccounts)
                                    {
                                        ACDocTypeEntrysInfo subEntry = (ACDocTypeEntrysInfo)entry.Clone();
                                        subEntry.ACDocTypeEntryAccountDefaultCredit = account.ACAccountID;
                                        subEntry.DefaultCreditAccountNo = account.ACAccountNo;
                                        subEntry.ACEntryTypeDesc = string.Format("{0} {1} {2}", GeneralAccountingLocalizedResources.TransferAccount, account.ACAccountName, "công đoạn tinh chế");
                                        entries.Add(subEntry);
                                    }
                                }

                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanLapRap.ToString())
                                {
                                    subAccounts = objAccountsController.GetSubAccountsByAccountNo(entry.DefaultCreditAccountNo);
                                    subAccounts = subAccounts.Where(a => !subAccounts.Exists(sa => sa.ACAccountParentID == a.ACAccountID)).ToList();
                                    foreach (ACAccountsInfo account in subAccounts)
                                    {
                                        ACDocTypeEntrysInfo subEntry = (ACDocTypeEntrysInfo)entry.Clone();
                                        subEntry.ACDocTypeEntryAccountDefaultCredit = account.ACAccountID;
                                        subEntry.DefaultCreditAccountNo = account.ACAccountNo;
                                        subEntry.ACEntryTypeDesc = string.Format("{0} {1} {2}", GeneralAccountingLocalizedResources.TransferAccount, account.ACAccountName, "công đoạn lắp ráp");
                                        entries.Add(subEntry);
                                    }
                                }

                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanSon.ToString())
                                {
                                    subAccounts = objAccountsController.GetSubAccountsByAccountNo(entry.DefaultCreditAccountNo);
                                    subAccounts = subAccounts.Where(a => !subAccounts.Exists(sa => sa.ACAccountParentID == a.ACAccountID)).ToList();
                                    foreach (ACAccountsInfo account in subAccounts)
                                    {
                                        ACDocTypeEntrysInfo subEntry = (ACDocTypeEntrysInfo)entry.Clone();
                                        subEntry.ACDocTypeEntryAccountDefaultCredit = account.ACAccountID;
                                        subEntry.DefaultCreditAccountNo = account.ACAccountNo;
                                        subEntry.ACEntryTypeDesc = string.Format("{0} {1} {2}", GeneralAccountingLocalizedResources.TransferAccount, account.ACAccountName, "công đoạn sơn");
                                        entries.Add(subEntry);
                                    }
                                }

                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanDongGoi.ToString())
                                {
                                    subAccounts = objAccountsController.GetSubAccountsByAccountNo(entry.DefaultCreditAccountNo);
                                    subAccounts = subAccounts.Where(a => !subAccounts.Exists(sa => sa.ACAccountParentID == a.ACAccountID)).ToList();
                                    foreach (ACAccountsInfo account in subAccounts)
                                    {
                                        ACDocTypeEntrysInfo subEntry = (ACDocTypeEntrysInfo)entry.Clone();
                                        subEntry.ACDocTypeEntryAccountDefaultCredit = account.ACAccountID;
                                        subEntry.DefaultCreditAccountNo = account.ACAccountNo;
                                        subEntry.ACEntryTypeDesc = string.Format("{0} {1} {2}", GeneralAccountingLocalizedResources.TransferAccount, account.ACAccountName, "công đoạn đóng gói");
                                        entries.Add(subEntry);
                                    }
                                }
                            }
                            string CDPhoiNo = "CD-003";
                            string CDSoCheNo = "CD-004";
                            string CDTinhCheNo = "CD-005";
                            string CDLapRapNo = "CD-084";
                            string CDSonNo = "CD-006";
                            string CDDongGoiNo = "CD-007";

                            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
                            MMOperationsController objOperationsController = new MMOperationsController();
                            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetReceiptItemByAllOperationIDAndDate(fromDate, toDate);
                            decimal TongM3Tinh = 0;
                            decimal tongM3TinhToanNhaMay = receiptItems.Sum(e => e.ICReceiptItemWoodQty);
                            decimal amount = 0;

                            foreach (ACDocTypeEntrysInfo entry in entries)
                            {
                                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                                ACDocumentEntrysInfo documentEntry = AccountHelper.AddItemToDocumentEntryList(entry, entity.DocumentEntryList);
                                documentEntry.ACDocumentDebitAccount = entry.DefaultDebitAccountNo;
                                documentEntry.ACDocumentCreditAccount = entry.DefaultCreditAccountNo;
                                if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanPhoi.ToString())
                                {
                                    //documentEntry.ACDocumentEntryAmount = productionCostsInfo.MMProductionCost6279FeeP;
                                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);
                                    receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, fromDate, toDate);
                                    TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                                    amount = objDocumentEntrysController.GetAccountDebitAmount(entry.DefaultCreditAccountNo, fromDate, toDate) -
                                                                      objDocumentEntrysController.GetAccountCreditAmount(entry.DefaultCreditAccountNo, fromDate, toDate);
                                    documentEntry.ACDocumentEntryAmount = (TongM3Tinh / tongM3TinhToanNhaMay) * amount;
                                }
                                else if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanDongGoi.ToString())
                                {
                                    //documentEntry.ACDocumentEntryAmount = productionCostsInfo.MMProductionCost6279FeeDG;
                                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);
                                    receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, fromDate, toDate);
                                    TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                                    amount = objDocumentEntrysController.GetAccountDebitAmount(entry.DefaultCreditAccountNo, fromDate, toDate) -
                                                                      objDocumentEntrysController.GetAccountCreditAmount(entry.DefaultCreditAccountNo, fromDate, toDate);
                                    documentEntry.ACDocumentEntryAmount = (TongM3Tinh / tongM3TinhToanNhaMay) * amount;
                                }
                                else if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanSoChe.ToString())
                                {
                                    //documentEntry.ACDocumentEntryAmount = productionCostsInfo.MMProductionCost6279FeeSC;
                                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);
                                    receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, fromDate, toDate);
                                    TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                                    amount = objDocumentEntrysController.GetAccountDebitAmount(entry.DefaultCreditAccountNo, fromDate, toDate) -
                                                                      objDocumentEntrysController.GetAccountCreditAmount(entry.DefaultCreditAccountNo, fromDate, toDate);
                                    documentEntry.ACDocumentEntryAmount = (TongM3Tinh / tongM3TinhToanNhaMay) * amount;
                                }
                                else if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanTinhChe.ToString())
                                {
                                    //documentEntry.ACDocumentEntryAmount = productionCostsInfo.MMProductionCost6279FeeTC;
                                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);
                                    receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, fromDate, toDate);
                                    TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                                    amount = objDocumentEntrysController.GetAccountDebitAmount(entry.DefaultCreditAccountNo, fromDate, toDate) -
                                                                      objDocumentEntrysController.GetAccountCreditAmount(entry.DefaultCreditAccountNo, fromDate, toDate);
                                    documentEntry.ACDocumentEntryAmount = (TongM3Tinh / tongM3TinhToanNhaMay) * amount;
                                }
                                else if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanSon.ToString())
                                {
                                    //documentEntry.ACDocumentEntryAmount = productionCostsInfo.MMProductionCost6279FeeS;
                                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);
                                    receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, fromDate, toDate);
                                    TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                                    amount = objDocumentEntrysController.GetAccountDebitAmount(entry.DefaultCreditAccountNo, fromDate, toDate) -
                                                                      objDocumentEntrysController.GetAccountCreditAmount(entry.DefaultCreditAccountNo, fromDate, toDate);
                                    documentEntry.ACDocumentEntryAmount = (TongM3Tinh / tongM3TinhToanNhaMay) * amount;
                                }
                                else if (entry.ACEntryTypeName == AccEntryType.PhanBoChiPhi6279CongDoanLapRap.ToString())
                                {
                                    //documentEntry.ACDocumentEntryAmount = productionCostsInfo.MMProductionCost6279FeeLR;
                                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);
                                    receiptItemList = objReceiptItemsController.GetReceiptItemByOperationIDAndDate(objOperationsInfo.MMOperationID, fromDate, toDate);
                                    TongM3Tinh = receiptItemList.Sum(e => e.ICReceiptItemWoodQty);
                                    amount = objDocumentEntrysController.GetAccountDebitAmount(entry.DefaultCreditAccountNo, fromDate, toDate) -
                                                                      objDocumentEntrysController.GetAccountCreditAmount(entry.DefaultCreditAccountNo, fromDate, toDate);
                                    documentEntry.ACDocumentEntryAmount = (TongM3Tinh / tongM3TinhToanNhaMay) * amount;
                                }
                                documentEntry.ACDocumentEntryExchangeAmount = documentEntry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                                //BOSApp.RoundByCurrency(documentEntry, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            }
                            entity.DocumentEntryList.GridControl.RefreshDataSource();
                            RefreshBriefDocumentEntrys();
                        }
                    }
                }
            }
            else
            {
                ActionCancel();
            }
        }
        #endregion

        public override int ActionSave()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = objDocumentTypesController.GetDocumentTypeByDocumentTypeName(AccDocumentType.KhauHaoTSCD.ToString());
            //if (objDocumentTypesInfo != null && objDocumentTypesInfo.ACDocumentTypeID == mainObject.FK_ACDocumentTypeID)
            //    ValidateDepreciateAssets();
            //if (mainObject.ACDocumentID > 0)
            //    (new ACDocumentEntrysController()) .DeleteByForeignColumn("FK_ACDocumentID", mainObject.ACDocumentID);
            RefreshButton.Enabled = false;
            return base.ActionSave();
        }

        public void ValidateDepreciateAssets()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;

            string[] branchIDsDepreciate = entity.DocumentEntryList.Select(o => o.FK_BRCostedBranchID.ToString()).ToArray();
            string SelectedBranchIDs = string.Join(",", branchIDsDepreciate);
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> documentEntrys = null;
            List<int> branchIDsDepreciated = null;
            if (!(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Month == mainObject.ACDocumentDate.Month && BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Year == mainObject.ACDocumentDate.Year))
            {
                documentEntrys = objDocumentEntrysController.GetDocumentEntrysByMonthAndBranchIDs(mainObject.ACDocumentDate.AddMonths(-1), SelectedBranchIDs, AccDocumentType.KhauHaoTSCD.ToString());
                if (documentEntrys.Count() == 0)
                {
                    MessageBox.Show("Vui lòng chạy khấu hao tháng " + mainObject.ACDocumentDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + mainObject.ACDocumentDate.Month + "!",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                branchIDsDepreciated = documentEntrys.Select(o => o.FK_BRCostedBranchID).Distinct().ToList();
                string[] branchIDs = SelectedBranchIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                List<int> branchIDsUnDepreciate = new List<int>();
                int x = 0;
                branchIDs.All(o =>
                {
                    x = 0;
                    if (Int32.TryParse(o, out x))
                        if (!branchIDsDepreciated.Any(y => y == x))
                            branchIDsUnDepreciate.Add(x);
                    return true;
                });

                if (branchIDsUnDepreciate.Count() > 0)
                {
                    BRBranchsController objBranchsController = new BRBranchsController();
                    BRBranchsInfo objBranchsInfo = null;
                    string mes = string.Empty;
                    branchIDsUnDepreciate.ForEach(o =>
                    {
                        objBranchsInfo = objBranchsController.GetObjectByID(o) as BRBranchsInfo;
                        if (objBranchsInfo != null)
                            mes += Environment.NewLine + objBranchsInfo.BRBranchName;
                    });
                    MessageBox.Show("Vui lòng chạy khấu hao tháng " + mainObject.ACDocumentDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + mainObject.ACDocumentDate.Month + "  cho các chi nhánh sau:" + Environment.NewLine + mes,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
            }

            documentEntrys = objDocumentEntrysController.GetDocumentEntrysByMonthAndBranchIDs(mainObject.ACDocumentDate, SelectedBranchIDs, AccDocumentType.KhauHaoTSCD.ToString());
            List<ACDocumentEntrysInfo> branchIDDepreciateds = documentEntrys.GroupBy(o => o.FK_BRCostedBranchID).Select(o => o.First()).ToList();
            branchIDsDepreciated = documentEntrys.Select(o => o.FK_BRCostedBranchID).Distinct().ToList();
            if (branchIDDepreciateds.Count() > 0)
            {
                string mes = string.Empty;
                branchIDDepreciateds.ForEach(o =>
                {
                    mes += Environment.NewLine + o.BRBranchName;
                });
                MessageBox.Show("Các chi nhánh sau đã được chạy khấu hao cho tháng " + mainObject.ACDocumentDate.Month + ":" + Environment.NewLine + mes,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (!(Toolbar.IsNullOrNoneAction()))
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            }
            if (mainObject.ACDocumentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit,
                    mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);
            ActionPosted();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
            //PhanBoChiPhi
            entity.UpdateCostObjectItems(true);
            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
            //PhanBoChiPhi
            entity.UpdateCostObjectItems(false);
            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public override void ModuleAfterCompleted()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
            base.ModuleAfterCompleted();
        }

        public void ChangeAllocationEquipmentTranAmount()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            InvalidateDocumentEntrys(entity.AllocationEquipmentTranList);
            RefreshBriefDocumentEntrys();
        }

        public void ChangeAllocationCostObjectTranAmount()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            InvalidateDocumentEntrys(entity.AllocationCostObjectTranList);
            RefreshBriefDocumentEntrys();
        }

        public void ChangeDepreciationAssetTranAmount()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            InvalidateDocumentEntrys(entity.DepreciationAssetTranList);
        }

        public override void ActionDelete()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            int documentID = mainObject.ACDocumentID;
            ActionUnPosted();
            base.ActionDelete();
            ACDepreciationAssetTransController objDepreciationAssetTransController = new ACDepreciationAssetTransController();
            ACAllocationEquipmentTransController objAllocationEquipmentTransController = new ACAllocationEquipmentTransController();
            ACAllocationCostObjectTransController objAllocationCostObjectTransController = new ACAllocationCostObjectTransController();
            objDepreciationAssetTransController.DeleteByForeignColumn("FK_ACDocumentID", documentID);
            objAllocationEquipmentTransController.DeleteByForeignColumn("FK_ACDocumentID", documentID);
            objAllocationCostObjectTransController.DeleteByForeignColumn("FK_ACDocumentID", documentID);
        }

        public void ClosingStockBalances()
        {
            ActionNew();

            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult != DialogResult.OK)
                return;
            DateTime closingDate = chooseDate.FromMonth;
            closingDate = new DateTime(closingDate.Year, closingDate.Month, DateTime.DaysInMonth(closingDate.Year, closingDate.Month));
            ICInvBalancesController controller = new ICInvBalancesController();
            if (controller.CheckExitsClosingStockBalances(closingDate))
            {
                if (MessageBox.Show(string.Format("Đã tồn tại chốt sổ kho ngày {0}. Ban có muốn thực hiện chốt sổ ?", closingDate.ToString("dd/MM/yyyy")), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }
            controller.ClosingStockBalances(closingDate);
            MessageBox.Show("Chốt sổ thành công !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ClosingAccountBalances()
        {
            ActionNew();

            GeneralAccountingEntities entity = (GeneralAccountingEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult != DialogResult.OK)
                return;
            DateTime closingDate = chooseDate.FromMonth;
            closingDate = new DateTime(closingDate.Year, closingDate.Month, DateTime.DaysInMonth(closingDate.Year, closingDate.Month));
            ACBalancesController controller = new ACBalancesController();
            if (controller.CheckExitsClosingAccountBalances(closingDate))
            {
                if (MessageBox.Show(string.Format("Đã tồn tại chốt sổ kế toán ngày {0}. Ban có muốn thực hiện chốt sổ ?", closingDate.ToString("dd/MM/yyyy")), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }
            controller.ClosingAccountBalances(closingDate);
            MessageBox.Show("Chốt sổ thành công !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            DocumentInvoiceDateEditControl.Enabled = false;
            DocumentPaymentDueDateEditControl.Enabled = false;
            RefreshButton.Enabled = false;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            mainObject.STToolbarActionName = ToolbarActionName;
            DocumentInvoiceDateEditControl.Enabled = true;
            DocumentPaymentDueDateEditControl.Enabled = true;
            RefreshButton.Enabled = true;

            if (PageAllocationEquipmentTran != null)
                PageAllocationEquipmentTran.PageVisible = false;
            if (PageDepreciationAssetTran != null)
                PageDepreciationAssetTran.PageVisible = false;
            if (PageCostObjectTran != null)
                PageCostObjectTran.PageVisible = false;
        }
    }
}
