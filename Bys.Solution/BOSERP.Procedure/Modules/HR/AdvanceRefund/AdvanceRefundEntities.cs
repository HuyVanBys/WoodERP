using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AdvanceRefund
{
    public class AdvanceRefundEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRAdvanceRefundItemRequestsInfo> HRAdvanceRefundItemRequestList { get; set; }
        public BOSList<HRAdvanceRefundItemInvoicesInfo> HRAdvanceRefundItemInvoiceHasInvoiceList { get; set; }
        public BOSList<HRAdvanceRefundItemInvoicesInfo> HRAdvanceRefundItemInvoiceNoneInvoiceList { get; set; }
        public BOSList<HRAdvanceRefundTemplatesInfo> AdvanceRefundTemplatesList { get; set; }
        public Dictionary<int, string> AdvanceRefundTemplateURLDic { get; set; }
        #endregion

        #region Constructor
        public AdvanceRefundEntities()
            : base()
        {
            HRAdvanceRefundItemRequestList = new BOSList<HRAdvanceRefundItemRequestsInfo>();
            HRAdvanceRefundItemInvoiceHasInvoiceList = new BOSList<HRAdvanceRefundItemInvoicesInfo>();
            HRAdvanceRefundItemInvoiceNoneInvoiceList = new BOSList<HRAdvanceRefundItemInvoicesInfo>();
            AdvanceRefundTemplatesList = new BOSList<HRAdvanceRefundTemplatesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRAdvanceRefundsInfo();
            SearchObject = new HRAdvanceRefundsInfo();
        }

        public override void InitModuleObjectList()
        {
            HRAdvanceRefundItemRequestList.InitBOSList(
                                              this,
                                              TableName.HRAdvanceRefundsTableName,
                                              TableName.HRAdvanceRefundItemRequestsTableName,
                                              BOSList<HRAdvanceRefundItemRequestsInfo>.cstRelationForeign);
            HRAdvanceRefundItemRequestList.ItemTableForeignKey = "FK_HRAdvanceRefundID";

            HRAdvanceRefundItemInvoiceHasInvoiceList.InitBOSList(
                                             this,
                                             TableName.HRAdvanceRefundsTableName,
                                             TableName.HRAdvanceRefundItemInvoicesTableName,
                                             BOSList<HRAdvanceRefundItemInvoicesInfo>.cstRelationForeign);
            HRAdvanceRefundItemInvoiceHasInvoiceList.ItemTableForeignKey = "FK_HRAdvanceRefundID";

            HRAdvanceRefundItemInvoiceNoneInvoiceList.InitBOSList(
                                             this,
                                             TableName.HRAdvanceRefundsTableName,
                                             TableName.HRAdvanceRefundItemInvoicesTableName,
                                             BOSList<HRAdvanceRefundItemInvoicesInfo>.cstRelationForeign);
            HRAdvanceRefundItemInvoiceNoneInvoiceList.ItemTableForeignKey = "FK_HRAdvanceRefundID";

            AdvanceRefundTemplatesList.InitBOSList(
                                            this,
                                            TableName.HRAdvanceRefundsTableName,
                                            TableName.HRAdvanceRefundTemplatesTableName,
                                            BOSList<HRAdvanceRefundTemplatesInfo>.cstRelationForeign);
            AdvanceRefundTemplatesList.ItemTableForeignKey = "FK_HRAdvanceRefundID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            HRAdvanceRefundItemRequestList.InitBOSListGridControl();
            HRAdvanceRefundItemInvoiceHasInvoiceList.InitBOSListGridControl();
            HRAdvanceRefundItemInvoiceNoneInvoiceList.InitBOSListGridControl("fld_dgcHRAdvanceRefundItemInvoices2");
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
            AdvanceRefundTemplatesList.InitBOSListGridControl(AdvanceRefundModule.AdvanceRefundTemplateGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRAdvanceRefundItemRequestList.SetDefaultListAndRefreshGridControl();
                HRAdvanceRefundItemInvoiceHasInvoiceList.SetDefaultListAndRefreshGridControl();
                HRAdvanceRefundItemInvoiceNoneInvoiceList.SetDefaultListAndRefreshGridControl();
                HRAdvanceRefundItemInvoiceHasInvoiceList.ForEach(p => p.HRAdvanceRefundItemInvoiceType = AdvanceRefundItemInvoiceType.HasInvoice.ToString());
                HRAdvanceRefundItemInvoiceNoneInvoiceList.ForEach(p => p.HRAdvanceRefundItemInvoiceType = AdvanceRefundItemInvoiceType.NoneInvoice.ToString());
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
                AdvanceRefundTemplatesList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRAdvanceRefundItemInvoicesController objAdvanceRefundItemInvoicesController = new HRAdvanceRefundItemInvoicesController();

            HRAdvanceRefundItemRequestList.Invalidate(iObjectID);
            List<HRAdvanceRefundItemInvoicesInfo> listAdvanceRefundItemInvoicesInfo = new List<HRAdvanceRefundItemInvoicesInfo>();
            listAdvanceRefundItemInvoicesInfo = objAdvanceRefundItemInvoicesController.GetListAdvanceRefundItemInvoicesByAdvanceRefundIDAndType(iObjectID, AdvanceRefundItemInvoiceType.HasInvoice.ToString());
            if (listAdvanceRefundItemInvoicesInfo != null)
                HRAdvanceRefundItemInvoiceHasInvoiceList.Invalidate(listAdvanceRefundItemInvoicesInfo);
            listAdvanceRefundItemInvoicesInfo = objAdvanceRefundItemInvoicesController.GetListAdvanceRefundItemInvoicesByAdvanceRefundIDAndType(iObjectID, AdvanceRefundItemInvoiceType.NoneInvoice.ToString());
            if (listAdvanceRefundItemInvoicesInfo != null)
                HRAdvanceRefundItemInvoiceNoneInvoiceList.Invalidate(listAdvanceRefundItemInvoicesInfo);
            HRAdvanceRefundItemInvoiceNoneInvoiceList.ForEach(o => o.ACObjectAccessKey = o.FK_HRObjectID + ";" + o.HRObjectType);
            AdvanceRefundTemplatesList.Invalidate(iObjectID);
            foreach (HRAdvanceRefundTemplatesInfo objAdvanceRefundTemplatesInfo in AdvanceRefundTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objAdvanceRefundTemplatesInfo.AACreatedUser);
                string SaleForecastID = objAdvanceRefundTemplatesInfo.FK_HRAdvanceRefundID.ToString();
                objAdvanceRefundTemplatesInfo.HRAdvanceRefundTemplateName = objAdvanceRefundTemplatesInfo.HRAdvanceRefundTemplateName.Replace(SaleForecastID + "_", "");
                objAdvanceRefundTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
            }
        }

        public override bool CompleteTransaction()
        {
            HRAdvanceRefundsInfo revenueBudget = (HRAdvanceRefundsInfo)MainObject;

            if (revenueBudget.HRAdvanceRefundStatus == AdvanceRefundStatus.New.ToString())
            {
                revenueBudget.HRAdvanceRefundStatus = AdvanceRefundStatus.Complete.ToString();
                UpdateMainObject();
                UpdateMainObjectBindingSource();
                if (HRAdvanceRefundItemInvoiceNoneInvoiceList.Count > 0)
                {
                    UpdateUnifinishedCost();
                }
            }

            return base.CompleteTransaction();
        }

        public override void SaveModuleObjects()
        {
            HRAdvanceRefundItemRequestList.SaveItemObjects();
            HRAdvanceRefundItemInvoiceHasInvoiceList.ForEach(p => p.HRAdvanceRefundItemInvoiceType = AdvanceRefundItemInvoiceType.HasInvoice.ToString());
            HRAdvanceRefundItemInvoiceNoneInvoiceList.ForEach(p => p.HRAdvanceRefundItemInvoiceType = AdvanceRefundItemInvoiceType.NoneInvoice.ToString());
            HRAdvanceRefundItemInvoiceHasInvoiceList.SaveItemObjects();
            HRAdvanceRefundItemInvoiceNoneInvoiceList.SaveItemObjects();
            AdvanceRefundTemplatesList.SaveItemObjects();
            AdvanceRefundTemplateURLDic = AdvanceRefundTemplatesList.ToDictionary(o => o.HRAdvanceRefundTemplateID, o => o.FullPathFile);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRAdvanceRefundsInfo revenueBudget = (HRAdvanceRefundsInfo)MainObject;
            revenueBudget.HRAdvanceRefundDate = DateTime.Now;
            revenueBudget.HRAdvanceRefundStatus = AdvanceRefundStatus.New.ToString();
            revenueBudget.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            revenueBudget.HRAdvanceRefundExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            revenueBudget.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            revenueBudget.FK_HREmployeeID = 0;
            //revenueBudget.HRAdvanceRefundType = AdvanceRefundType.NoneInvoice.ToString();
            UpdateMainObjectBindingSource();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRAdvanceRefundItemRequestsTableName, new HRAdvanceRefundItemRequestsInfo());
            ModuleObjects.Add(TableName.HRAdvanceRefundItemInvoicesTableName, new HRAdvanceRefundItemInvoicesInfo());
        }

        public void UpdateUnifinishedCost()
        {
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            HRAdvanceRefundsInfo revenueBudget = (HRAdvanceRefundsInfo)MainObject;
            foreach (HRAdvanceRefundItemInvoicesInfo objAdvanceRefundItemInvoicesInfo in HRAdvanceRefundItemInvoiceNoneInvoiceList)
            {
                ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = objUnfinishedConstructionCostsController.GetObjectByID(objAdvanceRefundItemInvoicesInfo.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                if (objUnfinishedConstructionCostsInfo != null)
                {
                    objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostValue += objAdvanceRefundItemInvoicesInfo.HRAdvanceRefundItemInvoiceSubTotalAmount * revenueBudget.HRAdvanceRefundExchangeRate;
                    objUnfinishedConstructionCostsController.UpdateObject(objUnfinishedConstructionCostsInfo);
                }
            }
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                HRAdvanceRefundItemRequestList.DeleteItemObjects();
                HRAdvanceRefundItemInvoiceHasInvoiceList.DeleteItemObjects();
                HRAdvanceRefundItemInvoiceNoneInvoiceList.DeleteItemObjects();
                AdvanceRefundTemplatesList.DeleteItemObjects();
            }
        }
    }

    public class AcccountIDs
    {
        public int AccountID { get; set; }
        public int VehicleID { get; set; }
    }
}