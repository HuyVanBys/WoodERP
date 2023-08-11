using BOSCommon;
using BOSLib;
using System;

namespace BOSERP.Modules.AllocationCost
{
    public class AllocationCostEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        public BOSList<APAllocationCostItemInvoicesInfo> InvoiceInItemList { get; set; }
        public BOSList<APAllocationCostItemsInfo> ReceiptItemList { get; set; }
        public BOSList<APAllocationCostItemInvoiceInsInfo> ACIInvoiceInList { get; set; }
        public BOSList<APAllocationCostItemShipmentsInfo> ACIShipmentList { get; set; }
        #endregion

        #region Constructor
        public AllocationCostEntities()
            : base()
        {
            InvoiceInItemList = new BOSList<APAllocationCostItemInvoicesInfo>();
            ReceiptItemList = new BOSList<APAllocationCostItemsInfo>();
            ACIInvoiceInList = new BOSList<APAllocationCostItemInvoiceInsInfo>();
            ACIShipmentList = new BOSList<APAllocationCostItemShipmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APAllocationCostsInfo();
            SearchObject = new APAllocationCostsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("APAllocationCostItemInvoices", new APAllocationCostItemInvoicesInfo());
            ModuleObjects.Add("APAllocationCostItems", new APAllocationCostItemsInfo());
            ModuleObjects.Add("APAllocationCostItemInvoiceIns", new APAllocationCostItemInvoiceInsInfo());
            ModuleObjects.Add("APAllocationCostItemShipments", new APAllocationCostItemShipmentsInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceInItemList.InitBOSList(
                                    this,
                                    "APAllocationCosts",
                                    "APAllocationCostItemInvoices",
                                    BOSList<APAllocationCostItemInvoicesInfo>.cstRelationForeign);
            InvoiceInItemList.ItemTableForeignKey = "FK_APAllocationCostID";

            ReceiptItemList.InitBOSList(
                                   this,
                                   "APAllocationCosts",
                                   "APAllocationCostItems",
                                   BOSList<APAllocationCostItemsInfo>.cstRelationForeign);
            ReceiptItemList.ItemTableForeignKey = "FK_APAllocationCostID";

            ACIInvoiceInList.InitBOSList(
                                    this,
                                    "APAllocationCosts",
                                    "APAllocationCostItemInvoiceIns",
                                    BOSList<APAllocationCostItemInvoiceInsInfo>.cstRelationForeign);
            ACIInvoiceInList.ItemTableForeignKey = "FK_APAllocationCostID";

            ACIShipmentList.InitBOSList(
                                    this,
                                    "APAllocationCosts",
                                    "APAllocationCostItemShipments",
                                    BOSList<APAllocationCostItemShipmentsInfo>.cstRelationForeign);
            ACIShipmentList.ItemTableForeignKey = "FK_APAllocationCostID";

        }

        public override void InitGridControlInBOSList()
        {
            InvoiceInItemList.InitBOSListGridControl("fld_dgcAPAllocationCostItemInvoices");
            ReceiptItemList.InitBOSListGridControl("fld_dgcAPAllocationCostItems");
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
            ACIInvoiceInList.InitBOSListGridControl("fld_dgcAPAllocationCostItemInvoiceIns");
            ACIShipmentList.InitBOSListGridControl("fld_dgcAPAllocationCostItemShipments");
        }



        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceInItemList.SetDefaultListAndRefreshGridControl();
                ReceiptItemList.SetDefaultListAndRefreshGridControl();
                ACIInvoiceInList.SetDefaultListAndRefreshGridControl();
                ACIShipmentList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion
        public override bool SaveAccountingData()
        {
            APAllocationCostsInfo objAllocationCostsInfo = (APAllocationCostsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objAllocationCostsInfo, objDocumentsInfo);

            }
            return base.SaveAccountingData();
        }
        public override void SaveModuleObjects()
        {
            InvoiceInItemList.SaveItemObjects();
            ReceiptItemList.SaveItemObjects();
            ACIInvoiceInList.SaveItemObjects();
            ACIShipmentList.SaveItemObjects();
            SaveAccountingData();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            InvoiceInItemList.Invalidate(iObjectID);
            ReceiptItemList.Invalidate(iObjectID);
            ACIInvoiceInList.Invalidate(iObjectID);
            ACIShipmentList.Invalidate(iObjectID);
        }
        public override bool CompleteTransaction()
        {
            APAllocationCostsInfo objAllocationCostsInfo = (APAllocationCostsInfo)MainObject;
            if (objAllocationCostsInfo.APAllocationCostStatus == AllocationCostStatus.New.ToString())
            {
                objAllocationCostsInfo.APAllocationCostStatus = AllocationCostStatus.Complete.ToString();
                UpdateMainObject();
            }

            return base.CompleteTransaction();
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APAllocationCostsInfo objAllocationCostsInfo = (APAllocationCostsInfo)MainObject;
            objAllocationCostsInfo.APAllocationCostDate = DateTime.Now;
            objAllocationCostsInfo.APAllocationCostStatus = AllocationCostStatus.New.ToString();
            objAllocationCostsInfo.APAllocationCostCriterion = AllocationCostCriterion.Qty.ToString();
            objAllocationCostsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAllocationCostsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            UpdateMainObjectBindingSource();
        }
    }
}
