using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.EmloyeePayRollFormula
{
    class EmloyeePayRollFormulaEntities : ERPModuleEntities
    {
        #region Declare Constant
        public BOSList<HREmployeePayrollFormulaItemsInfo> EmployeePayrollFormulaItemList { get; set; }
        public BOSList<HRWorkingShiftsInfo> HRWorkingShiftList { get; set; }
        public BOSList<HRTimesheetEmployeeLatesInfo> HRTimesheetEmployeeLateList { get; set; }
        public BOSList<HREmployeeCommissionBranchsInfo> EmployeeCommissionBranchsList { get; set; }
        public BOSList<HRTimesheetConfigsInfo> HRTimesheetConfigList { get; set; }
        public BOSList<HROTFactorsInfo> HROTFactorList { get; set; }
        public BOSList<HRBreakTimesInfo> HRBreakTimeList { get; set; }
        public BOSList<HRAllowanceConfigsInfo> HRAllowanceConfigList { get; set; }
        #endregion
        #region Declare all entities variables
        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public EmloyeePayRollFormulaEntities()
            : base()
        {
        }

        #endregion

        #region Init Main Object,Module Objects functions        
        public override void InitMainObject()
        {
            MainObject = new HREmployeePayrollFormulasInfo();
            EmployeePayrollFormulaItemList = new BOSList<HREmployeePayrollFormulaItemsInfo>();
            HRWorkingShiftList = new BOSList<HRWorkingShiftsInfo>();
            HRTimesheetEmployeeLateList = new BOSList<HRTimesheetEmployeeLatesInfo>();
            HRTimesheetConfigList = new BOSList<HRTimesheetConfigsInfo>();
            HROTFactorList = new BOSList<HROTFactorsInfo>();
            HRBreakTimeList = new BOSList<HRBreakTimesInfo>();
            EmployeeCommissionBranchsList = new BOSList<HREmployeeCommissionBranchsInfo>();
            HRAllowanceConfigList = new BOSList<HRAllowanceConfigsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeePayrollFormulaItemsTableName, new HREmployeePayrollFormulaItemsInfo());
            ModuleObjects.Add(TableName.HREmployeePayrollFormulasTableName, new HREmployeePayrollFormulasInfo());
            ModuleObjects.Add(TableName.HRWorkingShiftsTableName, new HRWorkingShiftsInfo());
            ModuleObjects.Add(TableName.HRAllowanceConfigsTableName, new HRAllowanceConfigsInfo());
        }
        public override void InitModuleObjectList()
        {
            EmployeePayrollFormulaItemList.InitBOSList(
                                            this,
                                            TableName.HREmployeePayrollFormulasTableName,
                                            TableName.HREmployeePayrollFormulaItemsTableName,
                                            BOSList<HREmployeePayrollFormulaItemsInfo>.cstRelationForeign);
            EmployeePayrollFormulaItemList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";

            HRWorkingShiftList.InitBOSList(
                                            this,
                                            TableName.HREmployeePayrollFormulasTableName,
                                            TableName.HRWorkingShiftsTableName,
                                            BOSList<HRWorkingShiftsInfo>.cstRelationForeign);
            HRWorkingShiftList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";

            HRTimesheetEmployeeLateList.InitBOSList(this,
                                            TableName.HREmployeePayrollFormulasTableName,
                                            TableName.HRTimesheetEmployeeLatesTableName,
                                            BOSList<HRTimesheetEmployeeLatesInfo>.cstRelationForeign);
            HRTimesheetEmployeeLateList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";

            HRTimesheetConfigList.InitBOSList(this,
                                            TableName.HREmployeePayrollFormulasTableName,
                                            TableName.HRTimesheetConfigsTableName,
                                            BOSList<HRTimesheetConfigsInfo>.cstRelationForeign);
            HRTimesheetConfigList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";

            HROTFactorList.InitBOSList(this,
                                        TableName.HREmployeePayrollFormulasTableName,
                                        TableName.HROTFactorsTableName,
                                        BOSList<HROTFactorsInfo>.cstRelationForeign);
            HROTFactorList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";

            HRBreakTimeList.InitBOSList(this,
                                       TableName.HREmployeePayrollFormulasTableName,
                                       TableName.HRBreakTimesTableName,
                                       BOSList<HROTFactorsInfo>.cstRelationForeign);
            HRBreakTimeList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";


            EmployeeCommissionBranchsList.InitBOSList(this,
                                        TableName.HREmployeePayrollFormulasTableName,
                                        TableName.HREmployeeCommissionBranchsTableName,
                                        BOSList<HREmployeeCommissionBranchsInfo>.cstRelationForeign);
            EmployeeCommissionBranchsList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";

            HRAllowanceConfigList.InitBOSList(
                                            this,
                                            TableName.HREmployeePayrollFormulasTableName,
                                            TableName.HRAllowanceConfigsTableName,
                                            BOSList<HRAllowanceConfigsInfo>.cstRelationForeign);
            HRAllowanceConfigList.ItemTableForeignKey = "FK_HREmployeePayrollFormulaID";
        }
        public override void InitGridControlInBOSList()
        {
            EmployeePayrollFormulaItemList.InitBOSListGridControl();
            HRWorkingShiftList.InitBOSListGridControl();
            HRTimesheetEmployeeLateList.InitBOSListGridControl();
            HRTimesheetConfigList.InitBOSListGridControl();
            HROTFactorList.InitBOSListGridControl();
            HRBreakTimeList.InitBOSListGridControl();
            EmployeeCommissionBranchsList.InitBOSListGridControl();
            HRAllowanceConfigList.InitBOSListGridControl();
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeePayrollFormulaItemList.SetDefaultListAndRefreshGridControl();
                HRWorkingShiftList.SetDefaultListAndRefreshGridControl();
                HRTimesheetEmployeeLateList.SetDefaultListAndRefreshGridControl();
                HRTimesheetConfigList.SetDefaultListAndRefreshGridControl();
                HROTFactorList.SetDefaultListAndRefreshGridControl();
                HRBreakTimeList.SetDefaultListAndRefreshGridControl();
                EmployeeCommissionBranchsList.SetDefaultListAndRefreshGridControl();
                HRAllowanceConfigList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Invalidate Module Objects Functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            EmployeePayrollFormulaItemList.Invalidate(iObjectID);
            HRWorkingShiftList.Invalidate(iObjectID);
            HRTimesheetEmployeeLateList.Invalidate(iObjectID);
            HRTimesheetConfigList.Invalidate(iObjectID);
            HROTFactorList.Invalidate(iObjectID);
            HRBreakTimeList.Invalidate(iObjectID);
            EmployeeCommissionBranchsList.Invalidate(iObjectID);
            HRAllowanceConfigList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            EmployeePayrollFormulaItemList.SaveItemObjects();
            HRWorkingShiftList.SaveItemObjects();
            HRTimesheetEmployeeLateList.SaveItemObjects();
            HRTimesheetConfigList.SaveItemObjects();
            HROTFactorList.SaveItemObjects();
            HRBreakTimeList.SaveItemObjects();
            EmployeeCommissionBranchsList.SaveItemObjects();
            HRAllowanceConfigList.SaveItemObjects();
        }
        #endregion
    }
}
