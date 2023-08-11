using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EmloyeePayRollFormula
{
    class EmloyeePayRollFormulaModule : BaseModuleERP
    {
        #region Constant
        #endregion

        public EmloyeePayRollFormulaModule()
        {
            Name = "EmloyeePayRollFormula";
            CurrentModuleEntity = new EmloyeePayRollFormulaEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            GridView view = (GridView)entity.HRAllowanceConfigList.GridControl.MainView;
            if (view != null)
            {
                if (view.Columns[0] != null)
                {
                    view.FocusedColumn = view.Columns[0];
                }

            }


        }

        public override int ActionSave()
        {
            if (MessageBox.Show("Bạn có tính lại thời gian nghỉ giữa giờ?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CalculatorBreakTime();
            }
            return base.ActionSave();
        }

        public void RemoveSelectedItemFromEmployeePayrollFormulaList()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.EmployeePayrollFormulaItemList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedWorkingShift()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HRWorkingShiftList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedAllowanceConfig()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HRAllowanceConfigList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedTimesheetEmployeeLate()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HRTimesheetEmployeeLateList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedEmployeeCommissionBranchs()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.EmployeeCommissionBranchsList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedFactor()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HROTFactorList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedBreakTime()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HRBreakTimeList.RemoveSelectedRowObjectFromList();
        }

        public void ChangeCalculationType(string type)
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HRTimesheetConfigList.Clear();
            ADTimesheetConfigsController objTimesheetConfigsController = new ADTimesheetConfigsController();
            List<ADTimesheetConfigsInfo> timesheetConfigs = (List<ADTimesheetConfigsInfo>)objTimesheetConfigsController.GetListFromDataSet(objTimesheetConfigsController.GetAllObjects());
            DateTime currentDay = BOSApp.GetCurrentServerDate();
            if (type == EmployeePayrollFormulaCalculation.Nomal.ToString())
            {
                if (timesheetConfigs.Count() > 0)
                {
                    ADTimesheetConfigsInfo objTimesheetConfigsInfo = (ADTimesheetConfigsInfo)timesheetConfigs.FirstOrDefault(o => o.ADTimesheetConfigYear.Year == currentDay.Year);
                    HRTimesheetConfigsInfo objHRTimesheetConfigsInfo = new HRTimesheetConfigsInfo();
                    BOSUtil.CopyObject(objTimesheetConfigsInfo, objHRTimesheetConfigsInfo);
                    entity.HRTimesheetConfigList.Add(objHRTimesheetConfigsInfo);
                }
            }
            else
            {
                entity.HRTimesheetConfigList.Add(CalculationWorkDay(currentDay, type));
            }
            entity.HRTimesheetConfigList.GridControl.RefreshDataSource();
        }

        public HRTimesheetConfigsInfo CalculationWorkDay(DateTime date, string type)
        {
            int dem = 0;
            List<int> dayInMonth = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                dem = 0;
                int loop = 1;
                DateTime f = new DateTime(date.Year, i, 01);
                int x = DateTime.DaysInMonth(date.Year, i);
                while (loop <= x)
                {
                    dem = dem + 1;
                    if (type == EmployeePayrollFormulaCalculation.TruChuNhat.ToString())
                    {
                        if (f.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dem = dem - 1;
                        }
                    }
                    else if (type == EmployeePayrollFormulaCalculation.TruCuoiTuan.ToString())
                    {
                        if (f.DayOfWeek == DayOfWeek.Sunday || f.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dem = dem - 1;
                        }
                    }
                    f = f.AddDays(1);
                    loop++;
                }
                dayInMonth.Add(dem);
            }

            HRTimesheetConfigsInfo objTimesheetConfigsInfo = new HRTimesheetConfigsInfo();
            objTimesheetConfigsInfo.HRTimesheetConfigJan = dayInMonth[0];
            objTimesheetConfigsInfo.HRTimesheetConfigFeb = dayInMonth[1];
            objTimesheetConfigsInfo.HRTimesheetConfigMar = dayInMonth[2];
            objTimesheetConfigsInfo.HRTimesheetConfigApr = dayInMonth[3];
            objTimesheetConfigsInfo.HRTimesheetConfigMay = dayInMonth[4];
            objTimesheetConfigsInfo.HRTimesheetConfigJun = dayInMonth[5];
            objTimesheetConfigsInfo.HRTimesheetConfigJul = dayInMonth[6];
            objTimesheetConfigsInfo.HRTimesheetConfigAug = dayInMonth[7];
            objTimesheetConfigsInfo.HRTimesheetConfigSep = dayInMonth[8];
            objTimesheetConfigsInfo.HRTimesheetConfigOct = dayInMonth[9];
            objTimesheetConfigsInfo.HRTimesheetConfigNov = dayInMonth[10];
            objTimesheetConfigsInfo.HRTimesheetConfigDec = dayInMonth[11];
            objTimesheetConfigsInfo.HRTimesheetConfigYear = date;

            return objTimesheetConfigsInfo;
        }

        public void CalculatorBreakTime()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)CurrentModuleEntity;
            entity.HRBreakTimeList.Clear();
            HRBreakTimesInfo objBreakTimesInfo;
            entity.HRWorkingShiftList.ToList().ForEach(o =>
            {
                objBreakTimesInfo = new HRBreakTimesInfo();
                objBreakTimesInfo.HRBreakTimeFromTime = o.HRWorkingShiftBreakTimeBetweenShiftFrom;
                objBreakTimesInfo.HRBreakTimeToTime = o.HRWorkingShiftBreakTimeBetweenShiftTo;
                objBreakTimesInfo.HRBreakTimeName = "Nghỉ trưa " + o.HRWorkingShiftName;
                entity.HRBreakTimeList.Add(objBreakTimesInfo);
            });
            entity.HRBreakTimeList.GridControl.RefreshDataSource();
        }
    }
}
