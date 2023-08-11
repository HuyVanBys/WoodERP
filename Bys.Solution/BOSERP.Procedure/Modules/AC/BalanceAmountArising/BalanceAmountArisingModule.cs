using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.BalanceAmountArising
{
    class BalanceAmountArisingModule : BaseModuleERP
    {
        #region Constant

        public const string ToolbarButtonSaveBalance = "SaveBalance";
        #endregion

        #region Public properties
        #endregion

        public BalanceAmountArisingModule()
        {
            Name = "BalanceAmountArising";
            CurrentModuleEntity = new BalanceAmountArisingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public override void InvalidateToolbar()
        {
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)CurrentModuleEntity;
            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)entity.MainObject;
            if (mainObject.ACBalanceAmountArisingID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BalanceAmountArisingModule.ToolbarButtonSaveBalance, true);
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton(BalanceAmountArisingModule.ToolbarButtonSaveBalance, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }

            base.InvalidateToolbar();
        }

        public override int ActionSave()
        {
            return base.ActionSave();
        }
        public override void ActionDelete()
        {
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)CurrentModuleEntity;
            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)entity.MainObject;
            ACBalanceAmountArisingObjectDetailsController objBalanceAmountArisingObjectDetailsController = new ACBalanceAmountArisingObjectDetailsController();
            ACBalanceAmountArisingDetailsController objBalanceAmountArisingDetailsController = new ACBalanceAmountArisingDetailsController();
            ACAccountDetailsController objAccountDetailsController = new ACAccountDetailsController();
            if (mainObject.ACBalanceAmountArisingID > 0)
            {
                objBalanceAmountArisingObjectDetailsController.DeleteByForeignColumn("FK_ACBalanceAmountArisingID", mainObject.ACBalanceAmountArisingID);
                objBalanceAmountArisingDetailsController.DeleteByForeignColumn("FK_ACBalanceAmountArisingID", mainObject.ACBalanceAmountArisingID);
            }
            List<string> accountID = entity.BalanceAmountArisingObjectDetailsList.Select(o => o.FK_ACAccountID.ToString()).Distinct().ToList();
            if (accountID != null)
            {
                objAccountDetailsController.DeleteOldObjectBalanceByAcountIDAndDate(string.Join(",", accountID.ToArray()), mainObject.ACBalanceAmountArisingToDate.Date, mainObject.FK_BRBranchID);
            }
            base.ActionDelete();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)CurrentModuleEntity;
            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)entity.MainObject;
            mainObject.ACBalanceAmountArisingFromDate = BOSApp.GetPeriodStartDate(DateTime.Now);
            mainObject.ACBalanceAmountArisingToDate = BOSApp.GetPeriodEndDate(DateTime.Now);
            //mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public void SaveBalance()
        {
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)CurrentModuleEntity;
            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)entity.MainObject;
            List<ACBalanceAmountArisingDetailsInfo> balanceAmountArisingDetails = entity.BalanceAmountArisingDetailsList;
            List<ACBalanceAmountArisingObjectDetailsInfo> balanceAmountArisingObjectDetails = entity.BalanceAmountArisingObjectDetailsList;

            entity.AccountDetailsList.Clear();

            balanceAmountArisingObjectDetails.ForEach(o =>
            {
                ACAccountDetailsInfo objAccountDetailsInfo = new ACAccountDetailsInfo();
                objAccountDetailsInfo.FK_ACAccountID = o.FK_ACAccountID;
                objAccountDetailsInfo.FK_ACObjectID = o.FK_ACObjectID;
                objAccountDetailsInfo.ACObjectType = o.ACObjectType;
                objAccountDetailsInfo.FK_BRBranchID = o.FK_BRBranchID;
                objAccountDetailsInfo.FK_GECurrencyID = o.FK_GECurrencyID;
                objAccountDetailsInfo.FK_CSCompanyBankID = o.FK_CSCompanyBankID;
                objAccountDetailsInfo.ACAccountDetailInitialBalanceByCurrency = o.ACBalanceAmountArisingObjectDetailInitialBalanceByCurrency;
                objAccountDetailsInfo.ACAccountDetailExchangeRate = o.ACBalanceAmountArisingObjectDetailExchangeRate;
                objAccountDetailsInfo.ACAccountDetailInitialBalance = o.ACBalanceAmountArisingObjectDetailInitialBalance;
                objAccountDetailsInfo.ACAccountDetailDate = o.ACBalanceAmountArisingObjectDetailToDate;
                if (objAccountDetailsInfo.ACAccountDetailInitialBalance != 0)
                {
                    entity.AccountDetailsList.Add(objAccountDetailsInfo);
                }
            });

            entity.SaveBalanceObject();
        }

        public void GetData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)CurrentModuleEntity;
            entity.BalanceAmountArisingDetailsList.Clear();
            entity.BalanceAmountArisingObjectDetailsList.Clear();
            ACAccountsController objAccountsController = new ACAccountsController();
            ACBalanceAmountArisingDetailsController objBalanceAmountArisingDetailsController = new ACBalanceAmountArisingDetailsController();
            ACBalanceAmountArisingObjectDetailsController objBalanceAmountArisingObjectDetailsController = new ACBalanceAmountArisingObjectDetailsController();
            ACBalanceAmountArisingsInfo mainObject = (ACBalanceAmountArisingsInfo)entity.MainObject;
            List<ACBalanceAmountArisingDetailsInfo> ArisingDetailsList = objBalanceAmountArisingDetailsController.GetBalanceAmountArisingDetailCDPS(
                   mainObject.ACBalanceAmountArisingFromDate
                 , mainObject.ACBalanceAmountArisingToDate
                 , null
                 , mainObject.FK_BRBranchID);

            if (ArisingDetailsList != null && ArisingDetailsList.Any())
            {
                List<ACBalanceAmountArisingDetailsInfo> ArisingDetailResultList = new List<ACBalanceAmountArisingDetailsInfo>();
                ArisingDetailResultList = ArisingDetailResultList.Union(ArisingDetailsList).OrderBy(o => o.ACBalanceAmountArisingDetailAcountNumber).ToList();
                entity.BalanceAmountArisingDetailsList.Invalidate(ArisingDetailResultList);
                entity.BalanceAmountArisingDetailsList.GridControl.RefreshDataSource();

                List<ACBalanceAmountArisingObjectDetailsInfo> ArisingObjectDetailsList = objBalanceAmountArisingObjectDetailsController.GetBalanceAmountArisingObjectDetailCDPS(
                   mainObject.ACBalanceAmountArisingFromDate
                 , mainObject.ACBalanceAmountArisingToDate
                 , null
                 , mainObject.FK_BRBranchID);

                if (ArisingObjectDetailsList != null)
                {
                    entity.BalanceAmountArisingObjectDetailsList.Invalidate(ArisingObjectDetailsList);
                    entity.BalanceAmountArisingObjectDetailsList.GridControl.RefreshDataSource();
                }

            }
            BOSProgressBar.Close();
        }
    }
}
