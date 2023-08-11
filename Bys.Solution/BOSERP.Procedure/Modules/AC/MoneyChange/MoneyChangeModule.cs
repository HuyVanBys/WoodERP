using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.MoneyChange
{
    public class MoneyChangeModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        public const string ToolbarButtonApprove = "Approve";

        #endregion

        #region Constructor
        public MoneyChangeModule()
        {
            Name = ModuleName.MoneyChange;
            CurrentModuleEntity = new MoneyChangeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
        }
        #endregion

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

        #region Overrides
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACMoneyChangesController controller = new ACMoneyChangesController();
            ACMoneyChangesInfo searchObject = (ACMoneyChangesInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue == null
                || SearchBranchLookupEditControl.EditValue.ToString() == ""
                || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = controller.GetDataSetByID(-1);
                }
                else
                {
                    ds = ds = controller.GetSearchData(searchObject.ACMoneyChangeNo, BranchList, searchObject.ACMoneyChangeFromDate, searchObject.ACMoneyChangeToDate);
                }
            }
            else
            {
                ds = controller.GetMoneyChangesByBranchID(searchObject.ACMoneyChangeNo, searchObject.FK_BRBranchID, searchObject.ACMoneyChangeFromDate, searchObject.ACMoneyChangeToDate);
            }
            return ds;
        }

        public override int ActionSave()
        {
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            entity.MoneyChangeItemList.EndCurrentEdit();
            int moneyChangeID = base.ActionSave();
            return moneyChangeID;
        }

        #endregion

        #region Methods
        public void RemoveSelectedItem()
        {
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            entity.MoneyChangeItemList.RemoveSelectedRowObjectFromList();
        }
        #endregion

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
                ACMoneyChangesInfo mainObject = (ACMoneyChangesInfo)entity.MainObject;
                mainObject.ACMoneyChangeStatus = MoneyChangeStatus.Approved.ToString();
                mainObject.FK_HREmployeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                entity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public override bool ActionComplete()
        {
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            ACMoneyChangesInfo mainObject = (ACMoneyChangesInfo)entity.MainObject;
            mainObject.ACMoneyChangeStatus = MoneyChangeStatus.Completed.ToString();
            mainObject.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            return base.ActionComplete();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            ACMoneyChangesInfo mainObject = (ACMoneyChangesInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(MoneyChangeModule.ToolbarButtonApprove, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            if (mainObject.ACMoneyChangeID > 0)
            {
                if (mainObject.ACMoneyChangeStatus == MoneyChangeStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(MoneyChangeModule.ToolbarButtonApprove, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
                else if (mainObject.ACMoneyChangeStatus == MoneyChangeStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(MoneyChangeModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);

                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(MoneyChangeModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                         mainObject.ACMoneyChangePostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        mainObject.ACMoneyChangePostedStatus == PostedTransactionStatus.Posted.ToString());
                }
            }
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            ACMoneyChangesInfo mainObject = (ACMoneyChangesInfo)entity.MainObject;
            mainObject.ACMoneyChangePostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACMoneyChangeID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, mainObject.ACMoneyChangeID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            ACMoneyChangesInfo mainObject = (ACMoneyChangesInfo)entity.MainObject;
            mainObject.ACMoneyChangePostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACMoneyChangeID, PostedTransactionStatus.UnPosted.ToString());
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACMoneyChangeID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ChangeItemObject(string objectAccessKey)
        {
            MoneyChangeEntities entity = (MoneyChangeEntities)CurrentModuleEntity;
            ACMoneyChangeItemsInfo item = entity.MoneyChangeItemList[entity.MoneyChangeItemList.CurrentIndex];
            if (item == null)
                return;

            item.ACObjectAccessKey = objectAccessKey;
            ACObjectsController controller = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = controller.GetObjectByAccessKey(objectAccessKey);
            item.FK_ACObjectID = objObjectsInfo.ACObjectID;
            item.ACObjectType = objObjectsInfo.ACObjectType;
            entity.MoneyChangeItemList.GridControl.RefreshDataSource();
        }

        public void ChangeCashFund(ACMoneyChangeItemsInfo item)
        {
            string accountID = BOSApp.GetDisplayTextFromCatche(TableName.CSCashFundsTableName, "CSCashFundID", item.FK_CSCashFundID, "FK_ACAcountID");
            if (!string.IsNullOrEmpty(accountID))
                item.FK_ACAccountID = Convert.ToInt32(accountID);
        }

        public void ChangeCompanyBank(ACMoneyChangeItemsInfo item)
        {
            string accountID = BOSApp.GetDisplayTextFromCatche(TableName.CSCompanyBanksTable, "CSCompanyBankID", item.FK_CSCompanyBankID, "FK_ACAcountID");
            if (!string.IsNullOrEmpty(accountID))
                item.FK_ACAccountID = Convert.ToInt32(accountID);
        }

        public void ChangeItemAmount(ACMoneyChangeItemsInfo item)
        {
            item.ACMoneyChangeItemDebitExchangeAmount = item.ACMoneyChangeItemDebitAmount * item.ACMoneyChangeItemExchangeRate;
            item.ACMoneyChangeItemCreditExchangeAmount = item.ACMoneyChangeItemCreditAmount * item.ACMoneyChangeItemExchangeRate;
        }

        public override void ModuleAfterCompleted()
        {
            ActionPosted();
        }
    }
}
