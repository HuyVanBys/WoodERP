using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.AdvanceRefundDirect
{
    public class AdvanceRefundDirectEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRAdvanceRefundItemInvoicesInfo> HRAdvanceRefundItemInvoiceList { get; set; }
        #endregion

        #region Constructor
        public AdvanceRefundDirectEntities()
            : base()
        {
            HRAdvanceRefundItemInvoiceList = new BOSList<HRAdvanceRefundItemInvoicesInfo>();
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
            HRAdvanceRefundItemInvoiceList.InitBOSList(
                                             this,
                                             TableName.HRAdvanceRefundsTableName,
                                             TableName.HRAdvanceRefundItemInvoicesTableName,
                                             BOSList<HRAdvanceRefundItemInvoicesInfo>.cstRelationForeign);
            HRAdvanceRefundItemInvoiceList.ItemTableForeignKey = "FK_HRAdvanceRefundID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            HRAdvanceRefundItemInvoiceList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRAdvanceRefundItemInvoiceList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRAdvanceRefundItemInvoiceList.Invalidate(iObjectID);
            HRAdvanceRefundItemInvoiceList.ForEach(o => o.ACObjectAccessKey = o.FK_HRObjectID + ";" + o.HRObjectType);
        }

        public override bool CompleteTransaction()
        {
            HRAdvanceRefundsInfo revenueBudget = (HRAdvanceRefundsInfo)MainObject;

            if (revenueBudget.HRAdvanceRefundStatus == AdvanceRefundStatus.New.ToString())
            {
                revenueBudget.HRAdvanceRefundStatus = AdvanceRefundStatus.Complete.ToString();
                UpdateMainObject();
                UpdateMainObjectBindingSource();
                //UpdateUnifinishedCost();
            }

            return base.CompleteTransaction();
        }

        public override void SaveModuleObjects()
        {
            HRAdvanceRefundItemInvoiceList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRAdvanceRefundsInfo revenueBudget = (HRAdvanceRefundsInfo)MainObject;
            revenueBudget.HRAdvanceRefundDate = BOSApp.GetCurrentServerDate();
            revenueBudget.HRAdvanceRefundDueDate = BOSApp.GetCurrentServerDate();
            revenueBudget.HRAdvanceRefundStatus = AdvanceRefundStatus.New.ToString();
            revenueBudget.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            revenueBudget.HRAdvanceRefundExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            revenueBudget.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            revenueBudget.FK_HREmployeeID = 0;
            revenueBudget.HRAdvanceRefundType = AdvanceRefundType.DirectPayment.ToString();
            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRAdvanceRefundItemInvoicesTableName, new HRAdvanceRefundItemInvoicesInfo());
        }

        //public void UpdateUnifinishedCost()
        //{
        //    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
        //    foreach (HRAdvanceRefundItemInvoicesInfo objAdvanceRefundItemInvoicesInfo in HRAdvanceRefundItemInvoiceList)
        //    {
        //        ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = objUnfinishedConstructionCostsController.GetObjectByID(objAdvanceRefundItemInvoicesInfo.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
        //        if (objUnfinishedConstructionCostsInfo != null)
        //        {
        //            objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostValue += objAdvanceRefundItemInvoicesInfo.HRAdvanceRefundItemInvoiceTotalAmount;
        //            objUnfinishedConstructionCostsController.UpdateObject(objUnfinishedConstructionCostsInfo);
        //        }
        //    }
        //}
        public override bool CancelCompleteTransaction()
        {
            HRAdvanceRefundsInfo mainObject = (HRAdvanceRefundsInfo)MainObject;
            if (mainObject.HRAdvanceRefundStatus == AdvanceRefundStatus.Complete.ToString())
            {
                mainObject.HRAdvanceRefundStatus = AdvanceRefundStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }
    }
}
