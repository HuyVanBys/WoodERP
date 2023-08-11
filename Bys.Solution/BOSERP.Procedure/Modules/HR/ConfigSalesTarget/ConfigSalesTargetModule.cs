using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.ConfigSalesTarget
{
    public class ConfigSalesTargetModule : BaseTransactionModule
    {
        #region Constants
        public const string HRConfigSalesTargetItemsGridControlName = "fld_dgcHRConfigSalesTargetItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string CompanyLookupEditControlName = "fld_lkeFK_CSCompanyID";

        public const string ConfigSalesTargetAmountTextBoxControlName = "fld_txtHRConfigSalesTargetAmount";

        public const string BranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ApproveButtonTag = "Approve";

        public const string ModuleName = "ConfigSalesTarget";

        #endregion

        #region Public properties

        #endregion 

        #region Public properties
        public HRConfigSalesTargetItemsGridControl ConfigSalesTargetItemsGridControl;
        //public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSLookupEdit CompanyLookupEditControl;
        public BOSLookupEdit BranchLookupEditControl;
        public BOSTextBox ConfigSalesTargetAmountTextBoxControl;
        #endregion
        public ConfigSalesTargetModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new ConfigSalesTargetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            //SearchBranchLookupEditControl = (BOSLookupEdit)Controls[ConfigSalesTargetModule.SearchBranchLookupEditControlName];
            //SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            ConfigSalesTargetItemsGridControl = (HRConfigSalesTargetItemsGridControl)Controls[ConfigSalesTargetModule.HRConfigSalesTargetItemsGridControlName];
            CompanyLookupEditControl = (BOSLookupEdit)Controls[ConfigSalesTargetModule.CompanyLookupEditControlName];
            BranchLookupEditControl = (BOSLookupEdit)Controls[ConfigSalesTargetModule.BranchLookupEditControlName];
            ConfigSalesTargetAmountTextBoxControl = (BOSTextBox)Controls[ConfigSalesTargetModule.ConfigSalesTargetAmountTextBoxControlName];
        }

        public override int ActionSave()
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
            entity.ConfigSalesTargetItemList.EndCurrentEdit();
            ConfigSalesTargetItemsGridControl.InvalidateData();

            return base.ActionSave(); ;
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

        public override void InvalidateToolbar()
        {
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)CurrentModuleEntity.MainObject;

            if (mainObject.HRConfigSalesTargetID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(ConfigSalesTargetModule.ApproveButtonTag, true);
                if (mainObject.HRConfigSalesTargetStatus == ConfigSalesTargetStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ConfigSalesTargetModule.ApproveButtonTag, false);
                }
                if (mainObject.HRConfigSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString() || mainObject.HRConfigSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    CompanyLookupEditControl.Properties.ReadOnly = false;
                else
                    CompanyLookupEditControl.Properties.ReadOnly = true;
                if (mainObject.HRConfigSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    BranchLookupEditControl.Properties.ReadOnly = false;
                else
                    BranchLookupEditControl.Properties.ReadOnly = true;
                if (mainObject.FK_HRConfigSalesTargetParentID == 0)
                    ConfigSalesTargetAmountTextBoxControl.Properties.ReadOnly = false;
                else
                    ConfigSalesTargetAmountTextBoxControl.Properties.ReadOnly = true;
            }

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ConfigSalesTargetItemsGridControl.InitializeControl();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            CompanyLookupEditControl.Properties.ReadOnly = true;
            BranchLookupEditControl.Properties.ReadOnly = true;
        }

        public override bool ActionComplete()
        {
            bool isComplete = base.ActionComplete();
            return isComplete;
        }

        public void ChangeConfigSalesTargetType(string configSalesTargetType)
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)CurrentModuleEntity.MainObject;
            mainObject.HRConfigSalesTargetType = configSalesTargetType;
            entity.UpdateMainObjectBindingSource();
            if (string.IsNullOrEmpty(mainObject.HRConfigSalesTargetApplicableSubjects) || string.IsNullOrEmpty(configSalesTargetType))
                return;
            entity.GenarateConfigSalesTargetItems(configSalesTargetType, mainObject.HRConfigSalesTargetApplicableSubjects, mainObject.HRConfigSalesTargetApplyFromDate, mainObject.HRConfigSalesTargetApplyToDate);
        }

        public void ChangeConfigSalesTargetApplicableSubjects(string configSalesTargetApplicableSubjects)
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)CurrentModuleEntity.MainObject;
            mainObject.HRConfigSalesTargetApplicableSubjects = configSalesTargetApplicableSubjects;
            entity.UpdateMainObjectBindingSource();
            if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString() || configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                CompanyLookupEditControl.Properties.ReadOnly = false;
            else
                CompanyLookupEditControl.Properties.ReadOnly = true;
            if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                BranchLookupEditControl.Properties.ReadOnly = false;
            else
                BranchLookupEditControl.Properties.ReadOnly = true;
            if (string.IsNullOrEmpty(configSalesTargetApplicableSubjects) || string.IsNullOrEmpty(mainObject.HRConfigSalesTargetType))
                return;
            entity.GenarateConfigSalesTargetItems(mainObject.HRConfigSalesTargetType, configSalesTargetApplicableSubjects, mainObject.HRConfigSalesTargetApplyFromDate, mainObject.HRConfigSalesTargetApplyToDate);
        }

        public void ChangeConfigSalesTargetApplyFromDate(DateTime configSalesTargetApplyFromDate)
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrEmpty(mainObject.HRConfigSalesTargetApplicableSubjects) || string.IsNullOrEmpty(mainObject.HRConfigSalesTargetType))
                return;
            entity.GenarateConfigSalesTargetItems(mainObject.HRConfigSalesTargetType, mainObject.HRConfigSalesTargetApplicableSubjects, configSalesTargetApplyFromDate, mainObject.HRConfigSalesTargetApplyToDate);
        }

        public void ChangeConfigSalesTargetApplyToDate(DateTime configSalesTargetApplyToDate)
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrEmpty(mainObject.HRConfigSalesTargetApplicableSubjects) || string.IsNullOrEmpty(mainObject.HRConfigSalesTargetType))
                return;
            entity.GenarateConfigSalesTargetItems(mainObject.HRConfigSalesTargetType, mainObject.HRConfigSalesTargetApplicableSubjects, mainObject.HRConfigSalesTargetApplyFromDate, configSalesTargetApplyToDate);
        }

        public void ChangeConfigSalesTargetParent(int configSalesTargetParentID)
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_HRConfigSalesTargetParentID = configSalesTargetParentID;
            if (configSalesTargetParentID > 0)
            {
                ConfigSalesTargetAmountTextBoxControl.Properties.ReadOnly = true;

                HRConfigSalesTargetsController objConfigSalesTargetsController = new HRConfigSalesTargetsController();
                HRConfigSalesTargetsInfo objConfigSalesTargetsInfo = (HRConfigSalesTargetsInfo)objConfigSalesTargetsController.GetObjectByID(configSalesTargetParentID);
                if (objConfigSalesTargetsInfo != null)
                {
                    mainObject.HRConfigSalesTargetAmount = objConfigSalesTargetsInfo.HRConfigSalesTargetAmount;
                }
            }
            else
                ConfigSalesTargetAmountTextBoxControl.Properties.ReadOnly = false;
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)CurrentModuleEntity;
                bool isApproved = entity.Approve();
                if (isApproved)
                    InvalidateToolbar();
            }
        }
    }
}
