using BOSCommon;
using BOSCommon.Constants;
using BOSLib;

namespace BOSERP.Modules.ConfigSalesFormulaPayroll
{
    public class ConfigSalesFormulaPayrollModule : BaseTransactionModule
    {
        #region Constant

        #endregion

        #region Public properties

        #endregion

        #region Constructor
        public ConfigSalesFormulaPayrollModule()
        {
            Name = ModuleName.ConfigSalesFormulaPayroll;
            CurrentModuleEntity = new ConfigSalesFormulaPayrollEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        //protected override DataSet GetSearchData(ref string searchQuery)
        //{
        //    base.GetSearchData(searchQuery);
        //}

        #region Methods
        public override void ActionNew()
        {
            base.ActionNew();
        }


        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ConfigSalesFormulaPayrollEntities entity = (ConfigSalesFormulaPayrollEntities)CurrentModuleEntity;
            HRConfigSalesFormulaPayrollsInfo mainobject = (HRConfigSalesFormulaPayrollsInfo)entity.MainObject;
            if (mainobject.HRConfigSalesFormulaPayrollID > 0)
            {
                if (mainobject.HRConfigSalesFormulaPayrollStatus == ConfigSalesFormulaPayrollStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                }
                else if (mainobject.HRConfigSalesFormulaPayrollStatus == ConfigSalesFormulaPayrollStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                }
            }
        }

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                ConfigSalesFormulaPayrollEntities entity = (ConfigSalesFormulaPayrollEntities)CurrentModuleEntity;
                HRConfigSalesFormulaPayrollsInfo mainobject = (HRConfigSalesFormulaPayrollsInfo)entity.MainObject;
                mainobject.FK_HREmployeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                mainobject.HRConfigSalesFormulaPayrollStatus = ConfigSalesFormulaPayrollStatus.Approved.ToString();
                entity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }
        #endregion
    }
}
