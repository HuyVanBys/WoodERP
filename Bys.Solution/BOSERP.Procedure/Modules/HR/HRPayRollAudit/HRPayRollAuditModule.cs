using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRollAudit
{
    public class HRPayRollAuditModule : BaseTransactionModule
    {
        #region Declare Constant
        /// <summary>
        /// The employee payroll grid control name
        /// </summary>
        public const string HREmployeePayRollAuditsGridControlName = "fld_dgcHREmployeePayRollAudits";
        #endregion

        #region Declare Variables
        /// <summary>
        /// Define employe payroll grid control
        /// </summary>
        private HREmployeePayRollAuditsGridControl EmployeePayRollAuditsGridControl;
        decimal HoursPerDay = 0;
        decimal DaysPerMonth = 0;
        decimal SubtractOT = 0;
        List<HREmployeesInfo> EmployeesList;
        List<HREmployeeTransmitItemsInfo> EmployeeTransmitItemList;

        #endregion
        public HRPayRollAuditModule()
        {
            Name = "HRPayRollAudit";
            CurrentModuleEntity = new HRPayRollAuditEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            EmployeePayRollAuditsGridControl = (HREmployeePayRollAuditsGridControl)Controls[HRPayRollAuditModule.HREmployeePayRollAuditsGridControlName];
        }

        public override void InvalidateToolbar()
        {
            HRPayRollAuditsInfo payroll = (HRPayRollAuditsInfo)CurrentModuleEntity.MainObject;
            if (payroll.HRPayRollAuditID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("Refresh", true);
                if (payroll.HRPayRollAuditStatus == PayRollStatus.Posted.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("Refresh", false);
                }
                else if (payroll.HRPayRollAuditStatus == PayRollStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("Refresh", false);
                }
                else if (payroll.HRPayRollAuditStatus == PayRollStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                    ParentScreen.SetEnableOfToolbarButton("Refresh", true);
                }
            }

            base.InvalidateToolbar();
        }

        public void RefreshPayRoll()
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            if (MessageBox.Show("Bạn có muốn làm mới bảng lương không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Toolbar.IsEditAction() || Toolbar.IsNewAction())
                {
                    //CalculatePayRoll();
                    CalculateRefreshPayRoll();
                }
                else if (Toolbar.IsNullOrNoneAction())
                {
                    base.ActionEdit();
                    //CalculatePayRoll();
                    CalculateRefreshPayRoll();
                }

                entity.EmployeePayRollAuditList.GridControl.RefreshDataSource();
            }
        }
        public void ApprovePayRoll()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
                entity.SetPropertyChangeEventLock(false);
                HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
                objPayRollsInfo.HRPayRollAuditStatus = PayRollStatus.Approved.ToString();
                entity.UpdateMainObject();
                InvalidateToolbar();
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<HRAllowanceConfigsInfo> listAllowanceConfig = GetAllowanceConfigList();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
            decimal.TryParse(objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SubtractOT.ToString()).ADConfigKeyValue, out SubtractOT);

            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRLevelsController objLevelsController = new HRLevelsController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            foreach (HREmployeePayRollAuditsInfo objEmployeePayRollsInfo in entity.EmployeePayRollAuditList)
            {
                HREmployeesInfo objEmployeesInfo = employeeList.Where(e => e.HREmployeeID == objEmployeePayRollsInfo.FK_HREmployeeID).FirstOrDefault();
                if (objEmployeesInfo != null)
                {
                    if (objEmployeesInfo.FK_HRLevelID > 0)
                    {
                        HRLevelsInfo objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                        if (objLevelsInfo != null)
                        {
                            objEmployeePayRollsInfo.HRLevelNo = objLevelsInfo.HRLevelNo;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add employee to the current payroll
        /// </summary>
        public void AddEmployeeToPayRoll()
        {
            guiSearchEmployee guiEmployee = new guiSearchEmployee();
            guiEmployee.Module = this;
            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
                entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);

                //TNDLoc [ADD][Issue allowane],START
                List<HRAllowanceConfigsInfo> listAllowanceConfigs = GetAllowanceConfigList();
                //TNDLoc [ADD][Issue allowane],END

                foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.EmployeePayRollAuditList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeePayRollAuditsInfo objEmployeePayRollsInfo = new HREmployeePayRollAuditsInfo();
                            SetDefaultValuesFromEmployee(objEmployeePayRollsInfo, objEmployeesInfo, listAllowanceConfigs);
                            objEmployeePayRollsInfo.HRDepartmentRoomName = objEmployeesInfo.HRDepartmentRoomName;
                            objEmployeePayRollsInfo.HRDepartmentName = objEmployeesInfo.HRDepartmentName;
                            objEmployeePayRollsInfo.HRDepartmentRoomGroupItemName = objEmployeesInfo.HRDepartmentRoomGroupItemName;
                            objEmployeePayRollsInfo.HREmployeeBankAccount1 = objEmployeesInfo.HREmployeeBankAccount1;
                            objEmployeePayRollsInfo.HRLevelName = objEmployeesInfo.HRLevelName;
                            objEmployeePayRollsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            // Get pay roll formulla of Employee
                            HREmployeePayrollFormulaItemsController objEPFIController = new HREmployeePayrollFormulaItemsController();
                            List<HREmployeePayrollFormulaItemsInfo> payrollFormulaItemList = objEPFIController.GetEmployeePayrollFormulaItemsByEmployeePayrollFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
                            foreach (HREmployeePayrollFormulaItemsInfo obj in payrollFormulaItemList)
                            {
                            }
                            // CTChinh - PayRoll BEGIN
                            // CTChinh - PayRoll END
                            entity.EmployeePayRollAuditList.Add(objEmployeePayRollsInfo);
                        }
                    }
                }
                entity.EmployeePayRollAuditList.GridControl.RefreshDataSource();
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            objPayRollsInfo.HRPayRollAuditDate = DateTime.Now;
            objPayRollsInfo.FromDate = DateTime.Now;
            objPayRollsInfo.ToDate = DateTime.Now;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            decimal.TryParse(objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.HoursPerDay.ToString()).ADConfigKeyValue, out HoursPerDay);
            decimal.TryParse(objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.DaysPerMonth.ToString()).ADConfigKeyValue, out DaysPerMonth);
            decimal.TryParse(objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SubtractOT.ToString()).ADConfigKeyValue, out SubtractOT);

            if (HoursPerDay == 0)
            {
                MessageBox.Show("Hệ thống chưa xác định số h làm việc trong ngày cho nhân viên."
                    + Environment.NewLine
                    + "Vui lòng xác định tại chức năng Cấu hình hệ thống/ Số giờ làm việc trong ngày"
                    ,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                ActionCancel();
                return;
            }
        }
        //TNDLoc [ADD][Issue allowance],START
        public List<HRAllowanceConfigsInfo> GetAllowanceConfigList()
        {
            HRAllowanceConfigsController objAllowanceConfigsController = new HRAllowanceConfigsController();
            List<HRAllowanceConfigsInfo> listAllowanceConfigs = objAllowanceConfigsController.GetAllAllowanceConfig();

            return listAllowanceConfigs;
        }
        //TNDLoc [ADD][Issue allowance],END
        /// <summary>
        /// Create employee payroll from employee time sheet
        /// </summary>
        public void ActionNewFromTimeSheetAudit()
        {
            ActionNew();

            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            HRTimeSheetAuditsController objTimeSheetsController = new HRTimeSheetAuditsController();
            List<HRTimeSheetAuditsInfo> timeSheetList = objTimeSheetsController.GetTimeSheetAuditsForPayRollAudit();
            guiFind<HRTimeSheetAuditsInfo> guiFind = new guiFind<HRTimeSheetAuditsInfo>(TableName.HRTimeSheetAuditsTableName, timeSheetList, null, this);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                int timeSheetID = Convert.ToInt32(guiFind.Tag.ToString());
                HRTimeSheetAuditsInfo objTimeSheetsInfo = (HRTimeSheetAuditsInfo)objTimeSheetsController.GetObjectByID(timeSheetID);
                //Set default main object
                objPayRollsInfo.HRPayRollAuditType = objTimeSheetsInfo.HRTimeSheetAuditType;
                objPayRollsInfo.HRPayRollAuditDate = objTimeSheetsInfo.HRTimeSheetAuditDate;
                objPayRollsInfo.FromDate = objTimeSheetsInfo.HRTimeSheetAuditFromDate;
                objPayRollsInfo.ToDate = objTimeSheetsInfo.HRTimeSheetAuditToDate;
                objPayRollsInfo.FK_HRTimeSheetAuditID = objTimeSheetsInfo.HRTimeSheetAuditID;
                if (objTimeSheetsInfo != null)
                {
                    //TNDLoc [ADD][Issue allowance],START
                    List<HRAllowanceConfigsInfo> listAllowanceConfigs = GetAllowanceConfigList();
                    //TNDLoc [ADD][Issue allowance],END

                    //Add employee time sheet info to employee payroll list
                    // CTChinh - PayRoll BEGIN
                    HREmployeeTimeSheetAuditsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetAuditsController();
                    HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();
                    List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList = objEmployeePieceWageItemsController.GetEmployeePieceWageItemByDate(objPayRollsInfo.FromDate, objPayRollsInfo.ToDate);
                    //TNDLoc [ADD][19/04/2016][Employee permission],START
                    List<HREmployeeTimeSheetAuditsInfo> employeeTimeSheets = objEmployeeTimeSheetsController.GetEmployeeTimeSheetAuditByTimeSheetAuditIDAndUserGroup(objTimeSheetsInfo.HRTimeSheetAuditID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                    //TNDLoc [ADD][19/04/2016][Employee permission],END
                    HREmployeePayRollAuditsInfo employeePayRoll = new HREmployeePayRollAuditsInfo();

                    foreach (HREmployeeTimeSheetAuditsInfo employeeTimeSheet in employeeTimeSheets)
                    {
                        employeePayRoll = new HREmployeePayRollAuditsInfo();
                        UpdateEmployeePayrollDetailsList(employeePayRoll, EmployeePieceWageItemList, employeeTimeSheet, objPayRollsInfo, listAllowanceConfigs);
                        entity.EmployeePayRollAuditList.Add(employeePayRoll);
                        //if (objEmployeeTranfersInfo != null)
                        //{
                        //    entity.EmployeePayRollAuditList.Add(employeePayRoll2);
                        //}
                    }
                    // CTChinh - PayRoll END
                }
                entity.EmployeePayRollAuditList.GridControl.RefreshDataSource();
            }
            else
            {
                ActionCancel();
            }
        }

        public void CalculateRefreshPayRoll()
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            HRTimeSheetAuditsController objTimeSheetsController = new HRTimeSheetAuditsController();

            if (objPayRollsInfo.FromDate == DateTime.MinValue && objPayRollsInfo.ToDate == DateTime.MinValue)
            {
                if (objPayRollsInfo.FK_HRTimeSheetAuditID > 0)
                {
                    HRTimeSheetAuditsInfo objTimeSheetsInfo = (HRTimeSheetAuditsInfo)objTimeSheetsController.GetObjectByID(objPayRollsInfo.FK_HRTimeSheetAuditID);
                    objPayRollsInfo.FromDate = objTimeSheetsInfo.HRTimeSheetAuditFromDate;
                    objPayRollsInfo.ToDate = objTimeSheetsInfo.HRTimeSheetAuditToDate;
                }
                else
                {
                    DateTime lastDate = new DateTime(objPayRollsInfo.HRPayRollAuditDate.Year, objPayRollsInfo.HRPayRollAuditDate.Month, DateTime.DaysInMonth(objPayRollsInfo.HRPayRollAuditDate.Year, objPayRollsInfo.HRPayRollAuditDate.Month));
                    DateTime firstDate = new DateTime(objPayRollsInfo.HRPayRollAuditDate.Year, objPayRollsInfo.HRPayRollAuditDate.Month, 1);

                    objPayRollsInfo.FromDate = firstDate;
                    objPayRollsInfo.ToDate = lastDate;

                }
            }

            List<HRAllowanceConfigsInfo> listAllowanceConfigs = GetAllowanceConfigList();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
            HREmployeeTimeSheetAuditsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetAuditsController();
            HRTimeSheetAuditEntrysController objTimeSheetEntrysController = new HRTimeSheetAuditEntrysController();
            HREmployeeTranfersController objEmployeeTranfersController = new HREmployeeTranfersController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();
            List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList = objEmployeePieceWageItemsController.GetEmployeePieceWageItemByDate(objPayRollsInfo.FromDate, objPayRollsInfo.ToDate);
            List<HREmployeeTimeSheetAuditsInfo> employeeTimeSheets = objEmployeeTimeSheetsController.GetEmployeeTimeSheetAuditByTimeSheetAuditIDAndUserGroup(objPayRollsInfo.FK_HRTimeSheetAuditID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            HREmployeePayRollAuditsInfo employeePayRoll = new HREmployeePayRollAuditsInfo();

            if (entity.EmployeePayRollAuditList != null && entity.EmployeePayRollAuditList.Count > 0)
            {
                foreach (HREmployeeTimeSheetAuditsInfo employeeTimeSheet in employeeTimeSheets)
                {
                    entity.EmployeePayRollAuditList.ForEach(o =>
                    {
                        if (o.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID)
                        {
                            employeePayRoll = o;
                            UpdateEmployeePayrollDetailsList(employeePayRoll, EmployeePieceWageItemList, employeeTimeSheet, objPayRollsInfo, listAllowanceConfigs);
                        }
                    });
                }
                entity.EmployeePayRollAuditList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Called when the user changes the payroll type
        /// </summary>
        /// <param name="payrollType">Target payroll type</param>
        public void ChangePayRollType(string payrollType)
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            objPayRollsInfo.HRPayRollAuditType = payrollType;
            CalculatePayRoll();
        }

        /// <summary>
        /// Remove the selected employee from the current employee payroll list
        /// </summary>
        public void RemoveEmployeeFromPayRollList()
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.EmployeePayRollAuditList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.EmployeePayRollAuditList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        #region Calculate payroll
        /// <summary>
        /// Set default values employee payroll from employee
        /// </summary>
        /// <param name="objEmployeePayRollsInfo">Given employee payroll</param>
        /// <param name="objEmployeesInfo">Given employee</param>

        public void SetDefaultValuesFromEmployeeTransfer(HREmployeePayRollAuditsInfo objEmployeePayRollsInfo, HREmployeeTranfersInfo objEmployeeTranfersInfo, List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee)
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeTranfersInfo.FK_HREmployeeID);
            objEmployeesInfo.FK_HRDepartmentRoomID = objEmployeeTranfersInfo.FK_HRDepartmentRoomID;
            objEmployeesInfo.FK_HRLevelID = objEmployeeTranfersInfo.FK_HRLevelID;
            objEmployeesInfo.HREmployeeSalaryFactor = objEmployeeTranfersInfo.HREmployeeTranferSalaryFactor;
            //objEmployeesInfo.HREmployeeContractSlrAmt = objEmployeeTranfersInfo.HREmployeeTranferSalary;
            //objEmployeesInfo.HREmployeeSalarySocialInsurance = objEmployeeTranfersInfo.HREmployeeTranferExtraSalary;
            objEmployeesInfo.HREmployeeExtraSalary1 = objEmployeeTranfersInfo.HREmployeeTranferAllowances;

            objEmployeePayRollsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
            objEmployeePayRollsInfo.FK_HRLevelID = objEmployeesInfo.FK_HRLevelID;
            objEmployeePayRollsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeePayRollsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
            // Ngày công qui định
            if (DaysPerMonth == 0)
                objEmployeePayRollsInfo.HREmployeeDaysPerMonth = objEmployeesInfo.HREmployeeDaysPerMonth;
            else
                objEmployeePayRollsInfo.HREmployeeDaysPerMonth = DaysPerMonth;
            // Hệ số
            objEmployeePayRollsInfo.HREmployeeSalaryFactor = objEmployeesInfo.HREmployeeSalaryFactor;
            //Mức lương tổng
            objEmployeePayRollsInfo.HREmployeeWorkingSlrAmtFull = objEmployeesInfo.HREmployeeWorkingSlrAmt;

            //Lương cơ bản
            objEmployeePayRollsInfo.HREmployeeContractSlrAmt = objEmployeesInfo.HREmployeeContractSlrAmt;

            //Mức lương
            objEmployeePayRollsInfo.HREmployeePayRollAuditWorkingSalary = objEmployeesInfo.HREmployeeSalarySocialInsurance;

            //Lương thử việc
            objEmployeePayRollsInfo.HREmployeePayRollAuditProWorkingSalary = 0;

            // Thưởng doanh số
            objEmployeePayRollsInfo.HREmployeePayRollAuditBonusSale = objEmployeesInfo.HREmployeeBonusSale;

            // Phụ cấp
            objEmployeePayRollsInfo.HREmployeePayRollAuditExtraSalary = objEmployeesInfo.HREmployeeExtraSalary1;
            CalculatePayRoll(objEmployeePayRollsInfo, objEmployeesInfo, listAllowanceConfigEmployee);
            entity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollAuditsTableName);
        }

        public void SetDefaultValuesFromEmployee(HREmployeePayRollAuditsInfo objEmployeePayRollsInfo, HREmployeesInfo objEmployeesInfo, List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            objEmployeePayRollsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeePayRollsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
            objEmployeePayRollsInfo.FK_HRLevelID = objEmployeesInfo.FK_HRLevelID;
            objEmployeePayRollsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeePayRollsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
            // Ngày công qui định
            objEmployeePayRollsInfo.HREmployeeDaysPerMonth = objEmployeesInfo.HREmployeeDaysPerMonth;
            if (objEmployeePayRollsInfo.HREmployeeDaysPerMonth == 0)
                objEmployeePayRollsInfo.HREmployeeDaysPerMonth = DaysPerMonth;
            // Hệ số
            objEmployeePayRollsInfo.HREmployeeSalaryFactor = objEmployeesInfo.HREmployeeSalaryFactor;
            //Mức lương tổng
            objEmployeePayRollsInfo.HREmployeeWorkingSlrAmtFull = objEmployeesInfo.HREmployeeWorkingSlrAmt;

            //Lương cơ bản
            objEmployeePayRollsInfo.HREmployeeContractSlrAmt = objEmployeesInfo.HREmployeeContractSlrAmt;

            //Mức lương
            objEmployeePayRollsInfo.HREmployeePayRollAuditWorkingSalary = objEmployeesInfo.HREmployeeSalarySocialInsurance;

            //Lương thử việc
            objEmployeePayRollsInfo.HREmployeePayRollAuditProWorkingSalary = 0;

            // Thưởng doanh số
            objEmployeePayRollsInfo.HREmployeePayRollAuditBonusSale = objEmployeesInfo.HREmployeeBonusSale;

            CalculatePayRoll(objEmployeePayRollsInfo, objEmployeesInfo, listAllowanceConfigs);
            entity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollAuditsTableName);
        }

        public void SetDefaultValuesFromEmployee(HREmployeePayRollAuditsInfo objEmployeePayRollsInfo, HREmployeesInfo objEmployeesInfo)
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            objEmployeePayRollsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeePayRollsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
            objEmployeePayRollsInfo.FK_HRLevelID = objEmployeesInfo.FK_HRLevelID;
            objEmployeePayRollsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeePayRollsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
            // Ngày công qui định
            objEmployeePayRollsInfo.HREmployeeDaysPerMonth = objEmployeesInfo.HREmployeeDaysPerMonth;
            if (objEmployeePayRollsInfo.HREmployeeDaysPerMonth == 0)
                objEmployeePayRollsInfo.HREmployeeDaysPerMonth = DaysPerMonth;
            // Hệ số
            objEmployeePayRollsInfo.HREmployeeSalaryFactor = objEmployeesInfo.HREmployeeSalaryFactor;

            //Mức lương tổng
            objEmployeePayRollsInfo.HREmployeeWorkingSlrAmtFull = objEmployeesInfo.HREmployeeWorkingSlrAmt;

            //Lương cơ bản
            objEmployeePayRollsInfo.HREmployeeContractSlrAmt = objEmployeesInfo.HREmployeeContractSlrAmt;

            //Mức lương
            objEmployeePayRollsInfo.HREmployeePayRollAuditWorkingSalary = objEmployeesInfo.HREmployeeSalarySocialInsurance;

            //Lương thử việc
            objEmployeePayRollsInfo.HREmployeePayRollAuditProWorkingSalary = 0;

            // Thưởng doanh số
            objEmployeePayRollsInfo.HREmployeePayRollAuditBonusSale = objEmployeesInfo.HREmployeeBonusSale;

            entity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollAuditsTableName);
        }

        /// <summary>
        /// Calculate the current payroll
        /// </summary>
        public void CalculatePayRoll()
        {
            List<HRAllowanceConfigsInfo> listAllowanceConfig = GetAllowanceConfigList();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();

            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            foreach (HREmployeePayRollAuditsInfo objEmployeePayRollsInfo in entity.EmployeePayRollAuditList)
            {
                HREmployeesInfo objEmployeesInfo = employeeList.Where(e => e.HREmployeeID == objEmployeePayRollsInfo.FK_HREmployeeID).FirstOrDefault();
                if (objEmployeesInfo != null)
                {
                    listAllowanceConfigEmployee = listAllowanceConfig.Where(t => t.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();
                    CalculatePayRoll(objEmployeePayRollsInfo, objEmployeesInfo, listAllowanceConfigEmployee);
                }
            }
        }

        /// <summary>
        /// Calculate the payroll of an employee
        /// </summary>
        /// <param name="objEmployeePayRollsInfo">Given employee payroll</param>
        public void CalculatePayRoll(HREmployeePayRollAuditsInfo objEmployeePayRollsInfo)
        {
            List<HRAllowanceConfigsInfo> listAllowanceConfig = GetAllowanceConfigList();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo employee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeePayRollsInfo.FK_HREmployeeID);
            if (employee != null)
            {
                listAllowanceConfigEmployee = listAllowanceConfig.Where(t => t.FK_HREmployeePayrollFormulaID == employee.FK_HREmployeePayrollFormulaID).ToList();
                CalculatePayRoll(objEmployeePayRollsInfo, employee, listAllowanceConfigEmployee);
            }
        }

        /// <summary>
        /// Calculate the payroll of an employee
        /// </summary>
        /// <param name="employeePayRoll">Given employee payroll</param>
        /// <param name="employee">Given employee</param>
        public void CalculatePayRoll(HREmployeePayRollAuditsInfo employeePayRoll, HREmployeesInfo employee, List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo payroll = (HRPayRollAuditsInfo)entity.MainObject;

            if (payroll.FromDate == DateTime.MinValue && payroll.ToDate == DateTime.MinValue)
            {
                if (payroll.FK_HRTimeSheetAuditID > 0)
                {
                    HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
                    HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(payroll.FK_HRTimeSheetAuditID);
                    payroll.FromDate = objTimeSheetsInfo.HRTimeSheetFromDate;
                    payroll.ToDate = objTimeSheetsInfo.HRTimeSheetToDate;
                }
                else
                {
                    DateTime lastDate = new DateTime(payroll.HRPayRollAuditDate.Year, payroll.HRPayRollAuditDate.Month, DateTime.DaysInMonth(payroll.HRPayRollAuditDate.Year, payroll.HRPayRollAuditDate.Month));
                    DateTime firstDate = new DateTime(payroll.HRPayRollAuditDate.Year, payroll.HRPayRollAuditDate.Month, 1);

                    payroll.FromDate = firstDate;
                    payroll.ToDate = lastDate;

                }
            }

            employeePayRoll.HREmployeePayRollAuditJobPerformanceAmt = employee.HREmployeeJobPerformanceAmt;
            employeePayRoll.HREmployeePayRollAuditSkillCoefficient = employee.HREmployeeSkillCoefficient;

            int daysInMonth = DateTime.DaysInMonth(payroll.HRPayRollAuditDate.Year, payroll.HRPayRollAuditDate.Month);
            int endOfWeekCount = 0;
            if (employee.HREmployeeDaysPerMonth == -1)
            {
                for (int i = 1; i <= daysInMonth; i++)
                {
                    DateTime date = new DateTime(payroll.HRPayRollAuditDate.Year, payroll.HRPayRollAuditDate.Month, i);
                    if (BOSApp.IsEndOfWeek(date.DayOfWeek))
                    {
                        endOfWeekCount++;
                    }
                }
            }
            else
            {
                endOfWeekCount = Convert.ToInt32(employee.HREmployeeDaysPerMonth);
            }
            HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();
            List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList = objEmployeePieceWageItemsController.GetEmployeePieceWageItemByDate(payroll.FromDate, payroll.ToDate);

            // Lương = Công thức tính lương
            DateTime dateFrom = payroll.FromDate;
            DateTime dateTo = payroll.ToDate;
            decimal totalWorkingSalary = 0;
            HREmployeePayrollFormulasController payrollController = new HREmployeePayrollFormulasController();
            HREmployeePayrollFormulasInfo objEmployeePayrollFormulasInfo = (HREmployeePayrollFormulasInfo)payrollController.GetObjectByID(employee.FK_HREmployeePayrollFormulaID);
            HREmployeePayrollFormulaItemsController objEPFIController = new HREmployeePayrollFormulaItemsController();
            List<HREmployeePayrollFormulaItemsInfo> payrollFormulaItemList = objEPFIController.GetEmployeePayrollFormulaItemsByEmployeePayrollFormullaID(employee.FK_HREmployeePayrollFormulaID);

            employeePayRoll.HREmployeePayRollAuditThuongKPI = 0;
            employeePayRoll.HREmployeePayRollAuditPhiTheATM = 0;
            employeePayRoll.FK_HREmployeePayRollKPI = "";
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeePayRoll.FK_HREmployeeID);
            HREmployeeKPIEvaluationItemsController objEmployeeKPIEvaluationItemsController = new HREmployeeKPIEvaluationItemsController();
            HREmployeeATMCardManagesController objEmployeeATMCardManagesController = new HREmployeeATMCardManagesController();
            List<string> dsKPIID = new List<string>();
            if (objEmployeesInfo != null)
            {
                List<HREmployeeKPIEvaluationItemsInfo> employeeKPIEvaluation = objEmployeeKPIEvaluationItemsController.GetKPIEvaluationTotalAmountByFK_HREmployeeID(objEmployeesInfo.HREmployeeID, payroll.HRPayRollAuditDate);
                if (employeeKPIEvaluation.Count() > 0)
                {
                    employeeKPIEvaluation.ForEach(o =>
                    {
                        dsKPIID.Add(o.FK_HRKPIEvaluationID.ToString());
                        employeePayRoll.HREmployeePayRollAuditThuongKPI += o.HREmployeeKPIEvaluationItemTotalAmount;
                    });
                }

                List<HREmployeeATMCardManagesInfo> EmployeeATMCardManageList = objEmployeeATMCardManagesController.GetEmployeeATMCardByEmployeeIDAndDate(objEmployeesInfo.HREmployeeID, payroll.HRPayRollAuditDate);
                if (EmployeeATMCardManageList.Count() > 0)
                {
                    EmployeeATMCardManageList.ForEach(o =>
                    {
                        employeePayRoll.HREmployeePayRollAuditPhiTheATM += o.HREmployeeATMCardManageAmount;
                    });
                }
            }

            if (dsKPIID != null && dsKPIID.Count() > 0)
            {
                employeePayRoll.FK_HREmployeePayRollKPI = string.Join(",", dsKPIID.ToArray());
            }

            employeePayRoll.HREmployeePayRollAuditAllowanceNangSuat = 0;

            foreach (HREmployeePayrollFormulaItemsInfo obj in payrollFormulaItemList)
            {
                if (EmployeePieceWageItemList != null)
                {
                    List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                        EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employee.HREmployeeID).ToList();
                    if (EmployeePieceWageItemTotal != null)
                        employeePayRoll.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);
                }
                // Khen thưởng  
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Khenthuong"))
                {
                    totalWorkingSalary = employeePayRoll.HREmployeePayRollAuditWorkingSalary;
                    employeePayRoll.HREmployeePayRollAuditReward = 0;
                    employeePayRoll.HREmployeePayRollAuditMaternityAndSickLeaveAmount = 0;
                    HRRewardsController objRewardsController = new HRRewardsController();
                    HREmployeeRewardsController objEmployeeRewardsController = new HREmployeeRewardsController();
                    //DataSet dsReward = objEmployeeRewardsController.GetEmployeeRewardByEmployeeIDAndDate(employee.HREmployeeID, payroll.HRPayRollAuditDate);
                    DataSet dsReward = objRewardsController.GetRewardListByEmployeeIDAndRewardDate(employee.HREmployeeID, payroll.HRPayRollAuditDate);
                    decimal rewardValue = 0;
                    if (dsReward.Tables[0].Rows.Count > 0)
                    {
                        HREmployeeRewardsInfo objEmployeeRewardsInfo = new HREmployeeRewardsInfo();
                        HRRewardsInfo objRewardsInfo = new HRRewardsInfo();
                        foreach (DataRow row in dsReward.Tables[0].Rows)
                        {
                            objRewardsInfo = (HRRewardsInfo)objRewardsController.GetObjectFromDataRow(row);
                            objEmployeeRewardsInfo = (HREmployeeRewardsInfo)objEmployeeRewardsController.GetEmployeeRewardsInfoByEmployeeIDAndRewardID(employee.HREmployeeID, objRewardsInfo.HRRewardID);
                            if (objRewardsInfo.HRRewardOption.Equals("AddToSalary"))
                            {
                                if (objRewardsInfo.HRRewardType.Equals(RewardType.Amount.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditReward += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Percent.ToString()))
                                {
                                    bool isValid = decimal.TryParse(objEmployeeRewardsInfo.HREmployeeRewardValue, out rewardValue);
                                    if (isValid)
                                        employeePayRoll.HREmployeePayRollAuditReward += (rewardValue * totalWorkingSalary) / 100;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Nangsuat.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditAllowanceNangSuat += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Omdauthaisan.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditMaternityAndSickLeaveAmount += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Other.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditReward += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                            }
                        }
                        employeePayRoll.HREmployeePayRollAuditReward = employeePayRoll.HREmployeePayRollAuditReward;
                    }
                }
                // Kỷ luật
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Kyluat"))
                {
                    employeePayRoll.HREmployeePayRollAuditDiscipline = 0;
                    employeePayRoll.HREmployeePayRollAuditBHTaiNan = 0;
                    employeePayRoll.HREmployeePayRollAuditPhiTheTu = 0;
                    //employeePayRoll.HREmployeePayRollAuditPhiTheATM = 0;
                    employeePayRoll.HREmployeePayRollAuditPhiAo = 0;
                    employeePayRoll.HREmployeePayRollAuditTruKhac = 0;
                    HREmployeeDisciplinesController objEmployeeDisciplinesController = new HREmployeeDisciplinesController();
                    HRDisciplinesController objDisciplinesController = new HRDisciplinesController();
                    //DataSet dsDiscipline = objEmployeeDisciplinesController.GetEmployeeDisciplinedByEmployeeIDAndDate(employee.HREmployeeID, payroll.HRPayRollAuditDate);
                    DataSet dsDiscipline = objDisciplinesController.GetDisciplineListByEmployeeIDAndDisciplineDate(employee.HREmployeeID, payroll.HRPayRollAuditDate);
                    if (dsDiscipline.Tables[0].Rows.Count > 0)
                    {
                        HREmployeeDisciplinesInfo objEmployeeDisciplinesInfo = new HREmployeeDisciplinesInfo();
                        HRDisciplinesInfo objDisciplinesInfo = new HRDisciplinesInfo();
                        foreach (DataRow row in dsDiscipline.Tables[0].Rows)
                        {
                            objDisciplinesInfo = (HRDisciplinesInfo)objDisciplinesController.GetObjectFromDataRow(row);
                            objEmployeeDisciplinesInfo = (HREmployeeDisciplinesInfo)objEmployeeDisciplinesController.GetEmployeeDisciplinesInfoByEmployeeIDAndDisciplineID(employee.HREmployeeID, objDisciplinesInfo.HRDisciplineID);
                            if (objDisciplinesInfo.HRDisciplineOption.Equals("AddToSalary"))
                            {
                                if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.Amount.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditDiscipline += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                //TNDLoc [ADD][26/01/2016][Issue discipline],START
                                #region Trừ phí
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.BHTN.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditBHTaiNan += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.PhiTheTu.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditPhiTheTu += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                //else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.PhiTheATM.ToString()))
                                //{
                                //    employeePayRoll.HREmployeePayRollAuditPhiTheATM += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                //}
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.PhiAo.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditPhiAo += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.Other.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAuditTruKhac += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                #endregion
                                //TNDLoc [ADD][26/01/2016][Issue discipline],END
                            }
                        }
                        employeePayRoll.HREmployeePayRollAuditDiscipline = employeePayRoll.HREmployeePayRollAuditDiscipline;
                    }
                }

                // Phụ cấp
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Phucap"))
                {
                    HRAllowancesController objAllowancesController = new HRAllowancesController();
                    HREmployeeAllowancesController objEmployeeAllowancesController = new HREmployeeAllowancesController();
                    DataSet dsAllowances = objAllowancesController.GetAllowanceListByEmployeeIDAndAllowanceDate(employee.HREmployeeID, payroll.HRPayRollAuditDate);

                    employeePayRoll.HREmployeePayRollAuditFixedAllowance = (employee.HREmployeeAllowanceHouse
                                                              + employee.HREmployeeAllowancePhone
                                                              + employee.HREmployeeAllowanceGas) / employeePayRoll.HREmployeeDaysPerMonth * employeePayRoll.HREmployeePayRollAuditDaysPerMonth;

                    employeePayRoll.HREmployeePayRollAuditExtraSalary = employeePayRoll.HREmployeePayRollAuditFixedAllowance;

                    // Phu cap co dinh
                    if (listAllowanceConfigs != null)
                    {
                        employeePayRoll.HREmployeePayRollAuditHeavyToxicAllowance = 0;
                        employeePayRoll.HREmployeePayRollAuditPerennialAllowance = 0;
                        employeePayRoll.HREmployeePayRollAuditDiligenceAllowance = 0;
                        employeePayRoll.HREmployeePayRollAuditMealAllowance = 0;

                        decimal allowanceAmount = 0;
                        foreach (HRAllowanceConfigsInfo item in listAllowanceConfigs)
                        {
                            allowanceAmount = GetAllowanceAmount(item.HRAllowanceConfigAmount
                                                                        , employeePayRoll.HREmployeeDaysPerMonth
                                                                        , employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth
                                                                        , employeePayRoll.HREmployeePayRollAuditNghiPhepNam + employeePayRoll.HREmployeePayRollAuditCtyChoNghi
                                                                        , employeePayRoll.HREmployeePayRollAuditNghiLe
                                                                        , item.HRAllowanceConfigPermiYearAndHoliday
                                                                        , item.HRAllowanceConfigIsTimeKeeping
                                                                        , item.HRAllowanceConfigContdifferenceWithReality);

                            int date = (int)(dateTo.Date - employee.HREmployeeStartWorkingDate.Date).TotalDays / 365;
                            if ((date >= item.HRAllowanceConfigFromDate && date < item.HRAllowanceConfigToDate)
                                || (item.HRAllowanceConfigFromDate == 0 && item.HRAllowanceConfigToDate == 0)
                                || (date >= item.HRAllowanceConfigFromDate && item.HRAllowanceConfigToDate == 0))
                            {
                                //if (item.HRAllowanceConfigName == AllowanceType.DiLai.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollAuditBonusDiLai += allowanceAmount;
                                //    employeePayRoll.HREmployeePayRollAuditExtraSalary += allowanceAmount;
                                //}
                                if (item.HRAllowanceConfigName == AllowanceType.HeavyToxic.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditHeavyToxicAllowance += allowanceAmount;
                                    employeePayRoll.HREmployeePayRollAuditExtraSalary += allowanceAmount;
                                }
                                else if (item.HRAllowanceConfigName == AllowanceConfigName.Meal.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditMealAllowance += allowanceAmount;
                                    //employeePayRoll.HREmployeePayRollAuditExtraSalary += allowanceAmount;
                                }
                                else if (item.HRAllowanceConfigName == AllowanceConfigName.Diligence.ToString())
                                {
                                    decimal dayWorking = 0;
                                    if (item.HRAllowanceConfigPermiYearAndHoliday)
                                    {
                                        dayWorking = employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth + employeePayRoll.HREmployeePayRollAuditNghiLe;
                                        if (employeePayRoll.HREmployeePayRollAuditNghiPhepNam > 1)
                                        {
                                            dayWorking++;
                                        }
                                        else
                                        {
                                            dayWorking += employeePayRoll.HREmployeePayRollAuditNghiPhepNam;
                                        }
                                    }
                                    else
                                    {
                                        dayWorking = employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth;
                                    }

                                    if (dayWorking >= employeePayRoll.HREmployeeDaysPerMonth)
                                    {
                                        if (item.HRAllowanceConfigIsTimeKeeping)
                                        {
                                            employeePayRoll.HREmployeePayRollAuditDiligenceAllowance += item.HRAllowanceConfigAmount * dayWorking;
                                            employeePayRoll.HREmployeePayRollAuditExtraSalary += item.HRAllowanceConfigAmount * dayWorking;
                                        }
                                        else
                                        {
                                            employeePayRoll.HREmployeePayRollAuditDiligenceAllowance += allowanceAmount;
                                            employeePayRoll.HREmployeePayRollAuditExtraSalary += allowanceAmount;
                                        }
                                    }
                                }
                                else if (item.HRAllowanceConfigName == AllowanceConfigName.Perennial.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditPerennialAllowance += allowanceAmount;
                                    employeePayRoll.HREmployeePayRollAuditExtraSalary += allowanceAmount;
                                }
                            }
                        }
                    }

                    if (dsAllowances.Tables[0].Rows.Count > 0)
                    {
                        employeePayRoll.HREmployeePayRollAuditBonusDiLai = 0;
                        employeePayRoll.HREmployeePayRollAuditNuoiConNho = 0;
                        //employeePayRoll.HREmployeePayRollAuditMaternityAndSickLeaveAmount = 0;
                        employeePayRoll.HREmployeePayRollAuditTruyLanh = 0;
                        employeePayRoll.HREmployeePayRollAuditOtherAllowance = 0;

                        HREmployeeAllowancesInfo objEmployeeAllowancesInfo = new HREmployeeAllowancesInfo();
                        HRAllowancesInfo objAllowancesInfo = new HRAllowancesInfo();
                        foreach (DataRow row in dsAllowances.Tables[0].Rows)
                        {
                            objAllowancesInfo = (HRAllowancesInfo)objAllowancesController.GetObjectFromDataRow(row);
                            objEmployeeAllowancesInfo = (HREmployeeAllowancesInfo)objEmployeeAllowancesController.GetEmployeeAllowancesInfoByEmployeeIDAndAllowanceID(employee.HREmployeeID, objAllowancesInfo.HRAllowanceID);
                            if (objAllowancesInfo.HRAllowanceOption.Equals("AddToSalary"))
                            {
                                if (objAllowancesInfo.HRAllowanceType == AllowanceType.WorkFees.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditBonusDiLai += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollAuditExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.NuoiCon.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditNuoiConNho += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollAuditExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.TruyLanh.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditTruyLanh += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollAuditExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.Other.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditOtherAllowance += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollAuditExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.Effective.ToString()
                                    && objAllowancesInfo.HRAllowanceCategory == AllowanceCategory.ForManage.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollAuditProductivity = objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria;
                                    employeePayRoll.HREmployeePayRollAuditQuality = objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria;
                                    employeePayRoll.HREmployeePayRollAuditManagement = objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria;
                                    employeePayRoll.HREmployeePayRollAuditExactly = objEmployeeAllowancesInfo.HREmployeeAllowanceExactlyCriteria;

                                    employeePayRoll.HREmployeePayRollAuditEffectiveAllowance =
                                        (objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredManageAmount
                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredProductivityAmount
                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredQualityAmount
                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceExactlyAmount)
                                        //* (employeePayRoll.HREmployeeRealDaysPerMonth
                                        //+ employeePayRoll.HREmployeeRealNightsPerMonth
                                        //+ employeePayRoll.HREmployeePayRollAuditNghiPhepNam
                                        //+ employeePayRoll.HREmployeePayRollAuditCtyChoNghi
                                        //+ employeePayRoll.HREmployeePayRollAuditNghiLe)
                                        * employeePayRoll.HREmployeePayRollAuditDaysPerMonth
                                        / employeePayRoll.HREmployeeDaysPerMonth;
                                }
                            }
                        }
                    }
                    employeePayRoll.HREmployeePayRollAuditAllowanceNangSuat += employeePayRoll.HREmployeePayRollAuditEffectiveAllowance
                                                                                + employee.HREmployeeExtraSalary1
                                                                                + employeePayRoll.HREmployeeOffsetSalary;

                    if (employeePayRoll.HREmployeeContractSlrAmt - employeePayRoll.HREmployeePayRollAuditWorkingSalary > 0)
                    {
                        employeePayRoll.HREmployeePayRollAuditAllowanceNangSuat +=
                            (employeePayRoll.HREmployeeContractSlrAmt - employeePayRoll.HREmployeePayRollAuditWorkingSalary -
                            (employee.HREmployeeAllowanceHouse
                                                              + employee.HREmployeeAllowancePhone
                                                              + employee.HREmployeeAllowanceGas))
                            / employeePayRoll.HREmployeeDaysPerMonth * employeePayRoll.HREmployeePayRollAuditDaysPerMonth;

                        employeePayRoll.HREmployeePayRollAuditAllowanceNangSuat +=
                            (employeePayRoll.HREmployeeContractSlrAmt - employeePayRoll.HREmployeePayRollAuditWorkingSalary)
                            / employeePayRoll.HREmployeeDaysPerMonth * employeePayRoll.HREmployeeHoursOT / 8;
                    }

                    employeePayRoll.HREmployeePayRollAuditExtraSalary = employeePayRoll.HREmployeePayRollAuditExtraSalary;
                }
                // Bảo hiểm xã hội, bảo hiểm y tế, bảo hiểm thu nhập
                ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
                ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("BHXHBHYTBHTN"))
                {
                    decimal contractSalary = employeePayRoll.HREmployeePayRollAuditWorkingSalary == 0 ? employeePayRoll.HREmployeePayRollAuditProWorkingSalary : employeePayRoll.HREmployeePayRollAuditWorkingSalary;

                    employeePayRoll.HREmployeePayRollAuditSocialInsAmount = 0;
                    employeePayRoll.HREmployeePayRollAuditHealthInsAmount = 0;
                    employeePayRoll.HREmployeePayRollAuditOutOfWorkInsAmount = 0;
                    if (employee.HREmployeeHaveInsurrance)
                    {
                        if (employee.HREmployeeStatusCombo == EmployeeStatus.Resigned.ToString())
                        {
                            if (objInsurrancesInfo != null)
                            {
                                DateTime dateApply = GetLastDayOfMonth(new DateTime(payroll.HRPayRollAuditDate.Year, payroll.HRPayRollAuditDate.Month, 1));
                                if (objInsurrancesInfo.HRInsurranceDateApply.Day > dateApply.Day)
                                {
                                    objInsurrancesInfo.HRInsurranceDateApply = dateApply;
                                }
                                else
                                {
                                    objInsurrancesInfo.HRInsurranceDateApply = new DateTime(payroll.HRPayRollAuditDate.Year,
                                                                                            payroll.HRPayRollAuditDate.Month,
                                                                                            objInsurrancesInfo.HRInsurranceDateApply.Day);
                                }

                                if (employee.HREmployeeStopWorkingDate.Date < objInsurrancesInfo.HRInsurranceDateApply.Date)
                                {
                                    employeePayRoll.HREmployeePayRollAuditSocialInsAmount = objInsurrancesInfo.HRInsurranceSocialInsPercentPrevious * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollAuditHealthInsAmount = objInsurrancesInfo.HRInsurranceHealthInsPercentPrevious * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollAuditOutOfWorkInsAmount = objInsurrancesInfo.HRInsurranceOutOfWorkInsPercentPrevious * contractSalary / 100;
                                }
                                else if (employee.HREmployeeStopWorkingDate.Date >= objInsurrancesInfo.HRInsurranceDateApply.Date)
                                {
                                    employeePayRoll.HREmployeePayRollAuditSocialInsAmount = objInsurrancesInfo.HRInsurranceSocialInsPercentNext * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollAuditHealthInsAmount = objInsurrancesInfo.HRInsurranceHealthInsPercentNext * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollAuditOutOfWorkInsAmount = objInsurrancesInfo.HRInsurranceOutOfWorkInsPercentNext * contractSalary / 100;
                                }
                            }
                            else
                            {
                                employeePayRoll.HREmployeePayRollAuditSocialInsAmount = employee.HREmployeeSocialInsPaymentPercent * contractSalary / 100;
                                employeePayRoll.HREmployeePayRollAuditHealthInsAmount = employee.HREmployeeHealthInsPaymentPercent * contractSalary / 100;
                                employeePayRoll.HREmployeePayRollAuditOutOfWorkInsAmount = employee.HREmployeeOutOfWorkInsPaymentPercent * contractSalary / 100;
                            }
                        }
                        else
                        {
                            employeePayRoll.HREmployeePayRollAuditSocialInsAmount = employee.HREmployeeSocialInsPaymentPercent * contractSalary / 100;
                            employeePayRoll.HREmployeePayRollAuditHealthInsAmount = employee.HREmployeeHealthInsPaymentPercent * contractSalary / 100;
                            employeePayRoll.HREmployeePayRollAuditOutOfWorkInsAmount = employee.HREmployeeOutOfWorkInsPaymentPercent * contractSalary / 100;
                            //employeePayRoll.HREmployeePayRollIncomeTaxAmount = employee.HREmployeeTaxPaymentPercent * contractSalary / 100;
                        }
                    }

                    if (employee.HREmployeeIsUnionMember)
                        employeePayRoll.HREmployeePayRollAuditSyndicateFee = employee.HREmployeeSyndicatePaymentAmount;
                }
                // Tạm ứng tiền xăng dầu
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Tamung"))
                {
                    employeePayRoll.HREmployeePayRollAuditAdvance = 0;
                    HRAdvanceRequestItemsController objAdvanceRequestItemsController = new HRAdvanceRequestItemsController();
                    DataSet dsAdvance = objAdvanceRequestItemsController.GetAdvanceRequestItemsByEmployeeIDAndFromDateToDate(employee.HREmployeeID, dateFrom, dateTo, AdvanceRequestType.UL.ToString());
                    if (dsAdvance.Tables[0].Rows.Count > 0)
                    {
                        HRAdvanceRequestItemsInfo objAdvanceRequestItemsInfo;
                        foreach (DataRow row in dsAdvance.Tables[0].Rows)
                        {
                            objAdvanceRequestItemsInfo = (HRAdvanceRequestItemsInfo)objAdvanceRequestItemsController.GetObjectFromDataRow(row);
                            if (objAdvanceRequestItemsInfo != null && objAdvanceRequestItemsInfo.HRAdvanceRequestItemStatus.Equals(AdvanceRequestStatus.Complete.ToString()))
                            {
                                employeePayRoll.HREmployeePayRollAuditAdvance += objAdvanceRequestItemsInfo.HRAdvanceRequestItemTotalAmount;
                            }
                        }
                        employeePayRoll.HREmployeePayRollAuditAdvance = employeePayRoll.HREmployeePayRollAuditAdvance;
                    }
                }
            }

            employeePayRoll.HREmployeePayRollAuditSkillCoefficientAmount = 0;
            employeePayRoll.HREmployeePayRollAuditSkillCoefficientAmount += (employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth) * 8;

            if (employeePayRoll.HREmployeePayRollAuditDetailsList != null && employeePayRoll.HREmployeePayRollAuditDetailsList.Count > 0)
            {
                employeePayRoll.HREmployeePayRollAuditDetailsList.ForEach(o =>
                {
                    employeePayRoll.HREmployeePayRollAuditSkillCoefficientAmount += o.HREmployeeTimeSheetAuditOTDetailFactor * o.HREmployeePayRollAuditHours;
                });
            }

            employeePayRoll.HREmployeePayRollAuditSkillCoefficientAmount = employeePayRoll.HREmployeePayRollAuditSkillCoefficientAmount * employeePayRoll.HREmployeePayRollAuditSkillCoefficient;

            CalculatePayRollTotalAmounts(employeePayRoll, listAllowanceConfigs);
        }

        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        public decimal GetAllowanceAmount(decimal allowAmount, decimal qtyConfig, decimal qtyReal, decimal qtyOff, decimal qtyHoliday, bool isAddOffDay, bool isCalByQty, decimal diffQtyConfig)
        {
            decimal result = 0;

            decimal dateQtyForCal = 0;
            if (isAddOffDay)
            {
                dateQtyForCal = qtyReal + qtyOff + qtyHoliday;
            }
            else
            {
                dateQtyForCal = qtyReal;
            }

            if (qtyConfig == 0)
            {
                return 0;
            }

            if (isCalByQty)
            {
                //result = allowAmount / qtyConfig * dateQtyForCal;
                result = allowAmount * dateQtyForCal;
            }
            else
            {
                if (diffQtyConfig == 0)
                {
                    result = allowAmount;
                }
                else
                {
                    if (qtyReal + diffQtyConfig == qtyConfig)
                    {
                        //result = allowAmount / qtyConfig * dateQtyForCal;
                        result = allowAmount * dateQtyForCal;
                    }
                    else
                    {
                        result = 0;
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// Calculate the total amounts of an employee's payroll
        /// </summary>
        /// <param name="objEmployeePayRollsInfo">Given employee payroll</param>        
        public void CalculatePayRollTotalAmounts(HREmployeePayRollAuditsInfo objEmployeePayRollsInfo, List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            if (objEmployeePayRollsInfo != null)
            {
                //TNDLoc [ADD][Issue allowance],START
                HRAllowanceManageConfigsController allowanceConfigController = new HRAllowanceManageConfigsController();
                HRAllowanceManageConfigsInfo allowanceConfigInfo = new HRAllowanceManageConfigsInfo();
                //TNDLoc [ADD][Issue allowance],END
                HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
                HRPayRollAuditsInfo objPayRollsInfo = (HRPayRollAuditsInfo)entity.MainObject;
                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo employee = employeeController.GetObjectByID(objEmployeePayRollsInfo.FK_HREmployeeID) as HREmployeesInfo;
                HREmployeePayrollFormulasController employeePayrollFormulaController = new HREmployeePayrollFormulasController();
                HREmployeePayrollFormulasInfo employeePayrollFormula = null;
                if (employee != null)
                {
                    employeePayrollFormula = employeePayrollFormulaController.GetObjectByID(employee.FK_HREmployeePayrollFormulaID) as HREmployeePayrollFormulasInfo;
                    objEmployeePayRollsInfo.HREmployeePayRollAuditProWorkingSalary = employee.HREmployeeProbationarySalaryAmount;
                }

                //TNDLoc [ADD][Issue allowance],START
                allowanceConfigInfo = (HRAllowanceManageConfigsInfo)allowanceConfigController.GetObjectByID(employee.FK_HRAllowanceManageConfigID);
                //TNDLoc [ADD][Issue allowance],END

                objEmployeePayRollsInfo.HREmployeePayRollAuditTotalWorkingSalary = objEmployeePayRollsInfo.HREmployeePayRollAuditWorkingSalary
                                                                              / objEmployeePayRollsInfo.HREmployeeDaysPerMonth
                                                                              * (objEmployeePayRollsInfo.HREmployeePayRollAuditDaysPerMonth
                                                                              + objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth * (decimal)0.3);

                objEmployeePayRollsInfo.HREmployeePayRollAuditBonusSaleAmount = objEmployeePayRollsInfo.HREmployeePayRollAuditBonusSale /
                                                                            objEmployeePayRollsInfo.HREmployeeDaysPerMonth *
                                                                            (objEmployeePayRollsInfo.HREmployeeRealDaysPerMonth +
                                                                            objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth +
                                                                            objEmployeePayRollsInfo.HREmployeePayRollAuditNghiLe +
                                                                            objEmployeePayRollsInfo.HREmployeePayRollAuditNghiPhepNam +
                                                                            objEmployeePayRollsInfo.HREmployeePayRollAuditCtyChoNghi
                                                                            );

                // Phạt / Trừ = Tạm ứng (xăng dầu) + Kỷ luật
                objEmployeePayRollsInfo.HREmployeePayRollAuditTotalDeductedAmt = objEmployeePayRollsInfo.HREmployeePayRollAuditAdvance +
                    objEmployeePayRollsInfo.HREmployeePayRollAuditDiscipline;
                // Các khoản bảo hiểm
                objEmployeePayRollsInfo.HREmployeePayRollAuditTotalInsAmt =
                    objEmployeePayRollsInfo.HREmployeePayRollAuditSocialInsAmount
                    + objEmployeePayRollsInfo.HREmployeePayRollAuditHealthInsAmount
                    + objEmployeePayRollsInfo.HREmployeePayRollAuditOutOfWorkInsAmount;
                // Lương đã trừ = Lương thu nhập + Phụ cấp + Khen thưởng - Bù lương => tiền thừa tăng ca - (Phạt / Trừ) - BHXH

                if (employeePayrollFormula != null)
                {
                    //objEmployeePayRollsInfo.HREmployeePayRollAuditAllowanceNangSuat -= objEmployeePayRollsInfo.HREmployeePayRollAuditFixedAllowance;
                    objEmployeePayRollsInfo.HREmployeePayRollAuditTongThuNhap =
                        objEmployeePayRollsInfo.HREmployeePayRollAuditTotalWorkingSalary
                        + objEmployeePayRollsInfo.HREmployeePayRollAuditOTSalary
                        + objEmployeePayRollsInfo.HREmployeePayRollAuditThuongKPI
                        + objEmployeePayRollsInfo.HREmployeePayRollAuditReward
                        //+ objEmployeePayRollsInfo.HREmployeePayRollAuditBonusSaleAmount
                        + objEmployeePayRollsInfo.HREmployeePayRollAuditExtraSalary
                        + objEmployeePayRollsInfo.HREmployeePayRollAuditAllowanceNangSuat;

                    objEmployeePayRollsInfo.HREmployeePayRollAuditTruKhac += objEmployeePayRollsInfo.HREmployeePayRollAuditPermissionOTDaysOff;

                    objEmployeePayRollsInfo.HREmployeePayRollAuditTongCacKhoanTru =
                     //objEmployeePayRollsInfo.HREmployeeOffsetSalary +
                     objEmployeePayRollsInfo.HREmployeePayRollAuditTotalDeductedAmt
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditTotalInsAmt
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditSyndicateFee
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditPhiAo
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditPhiTheATM
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditPhiTheTu
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditBHTaiNan
                     + objEmployeePayRollsInfo.HREmployeePayRollAuditTruKhac;

                    if (objEmployeePayRollsInfo.HREmployeePayRollAuditDetailsList != null && objEmployeePayRollsInfo.HREmployeePayRollAuditDetailsList.Count > 0)
                    {
                        objEmployeePayRollsInfo.HREmployeePayRollAuditThuNhapChiuThue =
                            objEmployeePayRollsInfo.HREmployeeWorkingSlrAmtFull
                            / objEmployeePayRollsInfo.HREmployeeDaysPerMonth / 8
                            * (decimal)objEmployeePayRollsInfo.HREmployeePayRollAuditDetailsList.Sum(o => o.HREmployeePayRollAuditHours)
                            + objEmployeePayRollsInfo.HREmployeePayRollAuditTongThuNhap
                            - objEmployeePayRollsInfo.HREmployeePayRollAuditOTSalary
                            - objEmployeePayRollsInfo.HREmployeePayRollAuditTotalInsAmt;
                    }

                    HREmployeeContactPersonsController objEmployeeContactPersonsController = new HREmployeeContactPersonsController();
                    List<HREmployeeContactPersonsInfo> list =
                        (List<HREmployeeContactPersonsInfo>)objEmployeeContactPersonsController.GetListFromDataSet(objEmployeeContactPersonsController.GetAllDataByForeignColumn("FK_HREmployeeID", employee.HREmployeeID));

                    if (list != null && list.Count > 0)
                    {
                        list = list.Where(o => o.HREmployeeContactPersonDependency == true).ToList();
                        if (list.Count > 0)
                        {
                            objEmployeePayRollsInfo.HREmployeePayRollAuditSoNguoiPhuThuoc = (int)list.Count();
                        }
                    }
                    ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
                    ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();

                    objEmployeePayRollsInfo.HREmployeePayRollAuditTruThueTNCN = objEmployeePayRollsInfo.HREmployeePayRollAuditThuNhapChiuThue;

                    if (objInsurrancesInfo != null)
                    {
                        objEmployeePayRollsInfo.HREmployeePayRollAuditTruThueTNCN -=
                            objInsurrancesInfo.ADInsurranceLevelNotTaxable
                            + objInsurrancesInfo.ADInsurranceDependencyLevel
                            * objEmployeePayRollsInfo.HREmployeePayRollAuditSoNguoiPhuThuoc;

                        if (objEmployeePayRollsInfo.HREmployeePayRollAuditTruThueTNCN < 0)
                        {
                            objEmployeePayRollsInfo.HREmployeePayRollAuditTruThueTNCN = 0;
                        }
                    }

                    objEmployeePayRollsInfo.HREmployeePayRollAuditIncomeTaxAmount = CalculationAmountThueTTCN(objEmployeePayRollsInfo.HREmployeePayRollAuditTruThueTNCN);
                }

                //objEmployeePayRollsInfo.HREmployeePayRollAuditTotalSalary
                //    = Convert.ToDecimal(BOSUtil.RoundToThousand(Convert.ToDouble(objEmployeePayRollsInfo.HREmployeePayRollAuditTongThuNhap
                //                                                - objEmployeePayRollsInfo.HREmployeePayRollAuditTongCacKhoanTru)));

                objEmployeePayRollsInfo.HREmployeePayRollAuditTotalSalary
                    = objEmployeePayRollsInfo.HREmployeePayRollAuditTongThuNhap
                    - objEmployeePayRollsInfo.HREmployeePayRollAuditTongCacKhoanTru
                    + objEmployeePayRollsInfo.HREmployeePayRollAuditMaternityAndSickLeaveAmount;

                CurrentModuleEntity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollAuditsTableName);
            }
        }

        public decimal CalculationAmountGTThueTTCN(int employeeID)
        {
            ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
            ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();
            HREmployeeContactPersonsController objEmployeeContactPersonsController = new HREmployeeContactPersonsController();
            List<HREmployeeContactPersonsInfo> list =
                (List<HREmployeeContactPersonsInfo>)objEmployeeContactPersonsController.GetListFromDataSet(objEmployeeContactPersonsController.GetAllDataByForeignColumn("FK_HREmployeeID", employeeID));
            decimal result = 0;

            if (objInsurrancesInfo != null)
            {
                result = objInsurrancesInfo.ADInsurranceLevelNotTaxable + objInsurrancesInfo.ADInsurranceDependencyLevel * (int)list.Count();
            }
            return result;
        }

        public decimal CalculationAmountThueTTCN(decimal amount)
        {
            decimal result = 0;
            if (amount >= 0)
            {
                if (amount <= 5000000)
                {
                    result = (decimal)amount * (decimal)0.05;
                }
                else if (amount <= 10000000)
                {
                    result = (decimal)(amount - 5000000) * (decimal)0.1 + 250000;
                }
                else if (amount <= 18000000)
                {
                    result = (decimal)(amount - 10000000) * (decimal)0.15 + 750000;
                }
                else if (amount <= 32000000)
                {
                    result = (decimal)(amount - 18000000) * (decimal)0.2 + 1950000;
                }
                else if (amount <= 52000000)
                {
                    result = (decimal)(amount - 32000000) * (decimal)0.25 + 4750000;
                }
                else if (amount <= 80000000)
                {
                    result = (decimal)(amount - 52000000) * (decimal)0.3 + 9750000;
                }
                else if (amount > 80000000)
                {
                    result = (decimal)(amount - 80000000) * (decimal)0.35 + 18150000;
                }
            }
            return result;
        }
        #endregion

        public override void ActionEdit()
        {
            base.ActionEdit();
        }

        #region Print

        /// <summary>
        /// Bảng thanh toán tiền lươnng
        /// </summary>
        public void PrintPayRollAudit()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
                HRPayRollAuditsInfo objPayRollAuditsInfo = (HRPayRollAuditsInfo)entity.MainObject;
                RPPayRollAudit report = new RPPayRollAudit();
                //Set current branch
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (branchAddressLine3 != null)
                    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
                XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (branchPhone != null)
                    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
                XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (branchFax != null)
                    branchFax.Text = objBranchsInfo.BRBranchContactFax;

                //Set payroll date
                XRLabel payrollMonthAudit = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollAuditMonth"];
                if (payrollMonthAudit != null)
                    payrollMonthAudit.Text = objPayRollAuditsInfo.HRPayRollAuditDate.Month.ToString();
                XRLabel payrollYearAudit = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollAuditYear"];
                if (payrollYearAudit != null)
                    payrollYearAudit.Text = objPayRollAuditsInfo.HRPayRollAuditDate.Year.ToString();

                report.DataSource = entity.EmployeePayRollAuditList;
                //convert payroll total amount to word
                XRLabel amountToWord = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWord"];
                if (amountToWord != null)
                {
                    decimal payRollTotalAmt = entity.EmployeePayRollAuditList.Sum(e => e.HREmployeePayRollAuditTotalSalary);
                    if (payRollTotalAmt > 0)
                    {
                        GECurrenciesController objCurrenciesController = new GECurrenciesController();
                        amountToWord.Text = ConvertAmountToWord.ReadAmount(payRollTotalAmt.ToString(), BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID);
                    }
                }
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPayRollReportPath, true);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Phiếu lương
        /// </summary>
        public void PrintPayRollAuditLable()
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
            HRPayRollAuditsInfo objPayRollAuditsInfo = (HRPayRollAuditsInfo)entity.MainObject;
            RPPayRollAuditLable report = new RPPayRollAuditLable();
            //report.LoadLayout(BOSCommon.Constants.Report.DevPayRollLableReportPath);

            //Set payroll date
            XRLabel payrollAuditMonth = (XRLabel)report.Bands[BandKind.Detail].Controls["xr_lblHRPayRollAuditMonth"];
            if (payrollAuditMonth != null)
                payrollAuditMonth.Text = objPayRollAuditsInfo.HRPayRollAuditDate.Month.ToString();
            XRLabel payrollAuditYear = (XRLabel)report.Bands[BandKind.Detail].Controls["xr_lblHRPayRollAuditYear"];
            if (payrollAuditYear != null)
                payrollAuditYear.Text = objPayRollAuditsInfo.HRPayRollAuditDate.Year.ToString();

            var employeePayRollAudits = (BOSList<HREmployeePayRollAuditsInfo>)entity.EmployeePayRollAuditList.Clone();
            HREmployeesController objEmployeesController = new HREmployeesController();
            //foreach (var employeePayRollAudit in employeePayRollAudits)
            //{
            //    //TNDLoc [ADD][10/12/2015][set mức phụ cấp trách nhiệm],START
            //    HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeePayRollAudit.FK_HREmployeeID);
            //    if (objEmployeesInfo != null)
            //    {
            //        employeePayRollAudit.HREmployeePayRollAuditEffectiveAllowanceFactor = objEmployeesInfo.HREmployeeExtraSalary1;
            //    }
            //    //TNDLoc [ADD][10/12/2015][set mức phụ cấp trách nhiệm],END
            //    employeePayRollAudit.HREmployeePayRollAuditTotalDeductedAmt = -employeePayRollAudit.HREmployeePayRollAuditTotalDeductedAmt;
            //    for (int item = 1; item <= employeePayRollAudit.HREmployeePayRollAuditDetailsList.Count; item++)
            //    {
            //        if (item == 1)
            //        {
            //            employeePayRollAudit.OTFactory1 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditHours;
            //            employeePayRollAudit.OTValue1 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditSalaryFactor;
            //        }
            //        if (item == 2)
            //        {
            //            employeePayRollAudit.OTFactory2 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditHours;
            //            employeePayRollAudit.OTValue2 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditSalaryFactor;
            //        }
            //        if (item == 3)
            //        {
            //            employeePayRollAudit.OTFactory3 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditHours;
            //            employeePayRollAudit.OTValue3 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditSalaryFactor;
            //        }
            //        if (item == 4)
            //        {
            //            employeePayRollAudit.OTFactory4 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditHours;
            //            employeePayRollAudit.OTValue4 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditSalaryFactor;
            //        }
            //        if (item == 5)
            //        {
            //            employeePayRollAudit.OTFactory5 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditHours;
            //            employeePayRollAudit.OTValue5 = employeePayRollAudit.HREmployeePayRollAuditDetailsList[item - 1].HREmployeePayRollAuditSalaryFactor;
            //        }
            //    }
            //}
            report.DataSource = employeePayRollAudits;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPayRollLableReportPath, true);
            reviewer.Show();
        }

        /// <summary>
        /// In thẻ lương
        /// </summary>
        public void PrintPayRollAuditCard()
        {
            RPPayRollAuditCard report = new RPPayRollAuditCard();
            PrintPayRollAuditCard(report);
        }

        public void PrintPayRollAuditCard(XtraReport report)
        {
            guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
            guiSearchEmployee.Module = this;
            if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
            {
                //Set current branch
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (branchAddressLine3 != null)
                    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
                XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
                if (branchPhone != null)
                    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
                XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
                if (branchFax != null)
                    branchFax.Text = objBranchsInfo.BRBranchContactFax;

                //Set payroll date    
                HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;
                HRPayRollAuditsInfo payRollAudit = (HRPayRollAuditsInfo)entity.MainObject;
                DateTime startYear = BOSUtil.GetYearBeginDate(payRollAudit.HRPayRollAuditDate);
                DateTime endYear = BOSUtil.GetYearEndDate(payRollAudit.HRPayRollAuditDate);
                XRLabel dateTitle = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblDateTitle"];

                List<HRAllowanceConfigsInfo> listAllowanceConfig = GetAllowanceConfigList();
                List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo employeeInfo = new HREmployeesInfo();

                if (dateTitle != null)
                {
                    dateTitle.Text = string.Format("{0} {1} {2} {3}",
                                                    ReportLocalizedResources.FromMonth,
                                                    startYear.ToString("MM/yyyy"),
                                                    ReportLocalizedResources.ToMonth,
                                                    endYear.ToString("MM/yyyy"));
                }
                ADReportsController objReportsController = new ADReportsController();
                var employeePayRollAudits = (IList<HREmployeePayRollAuditsInfo>)entity.EmployeePayRollAuditList.Clone();
                for (int i = 0; i < employeePayRollAudits.Count; i++)
                {
                    if (!guiSearchEmployee.SelectedEmployeeList.Exists(e => e.HREmployeeID == employeePayRollAudits[i].FK_HREmployeeID))
                    {
                        employeePayRollAudits.RemoveAt(i);
                        i--;
                    }
                }
                foreach (var employeePayRollAudit in employeePayRollAudits)
                {
                    employeePayRollAudit.HRPayRollAuditDate = payRollAudit.HRPayRollAuditDate;
                    listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
                    employeeInfo = (HREmployeesInfo)employeeController.GetObjectByID(employeePayRollAudit.FK_HREmployeeID);
                    if (employeeInfo != null)
                    {
                        listAllowanceConfigEmployee = listAllowanceConfig.Where(t => t.FK_HREmployeePayrollFormulaID == employeeInfo.FK_HREmployeePayrollFormulaID).ToList();
                    }
                    CalculatePayRollTotalAmounts(employeePayRollAudit, listAllowanceConfigEmployee);
                }
                foreach (HREmployeesInfo employee in guiSearchEmployee.SelectedEmployeeList)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i < payRollAudit.HRPayRollAuditDate.Month)
                        {
                            HREmployeePayRollAuditsInfo employeePayRollAudit = new HREmployeePayRollAuditsInfo();
                            employeePayRollAudit.HREmployeeNo = employee.HREmployeeNo;
                            employeePayRollAudit.HREmployeeName = employee.HREmployeeName;
                            employeePayRollAudit.HRDepartmentRoomName = employee.HRDepartmentRoomName;
                            employeePayRollAudit.HRDepartmentName = employee.HRDepartmentName;
                            employeePayRollAudit.HRDepartmentRoomGroupItemName = employee.HRDepartmentRoomGroupItemName;
                            employeePayRollAudit.HREmployeeBankAccount1 = employee.HREmployeeBankAccount1;
                            employeePayRollAudit.HRLevelName = employee.HRLevelName;
                            employeePayRollAudits.Insert(i - 1, employeePayRollAudit);
                        }
                        else if (i > payRollAudit.HRPayRollAuditDate.Month)
                        {
                            HREmployeePayRollAuditsInfo employeePayRollAudit = new HREmployeePayRollAuditsInfo();
                            employeePayRollAudit.HREmployeeNo = employee.HREmployeeNo;
                            employeePayRollAudit.HREmployeeName = employee.HREmployeeName;
                            employeePayRollAudit.HRDepartmentRoomName = employee.HRDepartmentRoomName;
                            employeePayRollAudit.HRDepartmentName = employee.HRDepartmentName;
                            employeePayRollAudit.HRDepartmentRoomGroupItemName = employee.HRDepartmentRoomGroupItemName;
                            employeePayRollAudit.HREmployeeBankAccount1 = employee.HREmployeeBankAccount1;
                            employeePayRollAudit.HRLevelName = employee.HRLevelName;
                            employeePayRollAudits.Add(employeePayRollAudit);
                        }
                    }
                }
                report.DataSource = employeePayRollAudits;

                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }

        /// <summary>
        /// In mẫu thẻ lương
        /// </summary>
        public void PrintPayRollAuditCardTemplate()
        {
            RPPayRollAuditCardTemplate report = new RPPayRollAuditCardTemplate();
            PrintPayRollAuditCard(report);
        }
        #endregion

        public void UpdateEmployeePayrollDetailsList(HREmployeePayRollAuditsInfo employeePayRoll,
                                                    List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList,
                                                    HREmployeeTimeSheetAuditsInfo employeeTimeSheet,
                                                    HRPayRollAuditsInfo objPayRollsInfo,
                                                    List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            HRPayRollAuditEntities entity = (HRPayRollAuditEntities)CurrentModuleEntity;

            List<HRTimeSheetAuditEntrysInfo> employeeTimeSheetEntryList = new List<HRTimeSheetAuditEntrysInfo>();

            HREmployeeContractsController objEmployeeContractsController = new HREmployeeContractsController();
            HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();
            HREmployeeTimeSheetAuditsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetAuditsController();
            HRTimeSheetAuditEntrysController objTimeSheetEntrysController = new HRTimeSheetAuditEntrysController();
            HREmployeeTranfersController objEmployeeTranfersController = new HREmployeeTranfersController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRLevelsController objLevelsController = new HRLevelsController();

            HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();

            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();

            employeePayRoll.FK_HREmployeeID = employeeTimeSheet.FK_HREmployeeID;
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetEmployeeByID(employeeTimeSheet.FK_HREmployeeID);
            HREmployeeTranfersInfo objEmployeeTranfersInfo = objEmployeeTranfersController.GetEmployeeTranfersByEmployeeIDAndDate(objEmployeesInfo.HREmployeeID, objPayRollsInfo.FromDate, objPayRollsInfo.ToDate);
            if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0)
            {
                listAllowanceConfigEmployee = listAllowanceConfigs.Where(t => t.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                objEmployeesInfo.HREmployeeDaysPerMonth = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objPayRollsInfo.HRPayRollAuditDate.Month);
                //SetDefaultValuesFromEmployee(employeePayRoll, objEmployeesInfo);
                employeePayRoll.HRDepartmentRoomName = objEmployeesInfo.HRDepartmentRoomName;
                employeePayRoll.HRDepartmentName = objEmployeesInfo.HRDepartmentName;
                employeePayRoll.HRDepartmentRoomGroupItemName = objEmployeesInfo.HRDepartmentRoomGroupItemName;
                employeePayRoll.HREmployeeBankAccount1 = objEmployeesInfo.HREmployeeBankAccount1;
                employeePayRoll.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                employeePayRoll.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;

                if (objEmployeesInfo.FK_HRLevelID > 0)
                {
                    HRLevelsInfo objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                    if (objLevelsInfo != null)
                    {
                        employeePayRoll.HRLevelNo = objLevelsInfo.HRLevelNo;
                        employeePayRoll.HRLevelName = objLevelsInfo.HRLevelName;
                    }
                }

                //if (objEmployeeTranfersInfo != null)
                //{
                //    // phase 1
                //    employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(objTimeSheetsInfo.HRTimeSheetAuditID, employeeTimeSheet.HREmployeeTimeSheetAuditID);
                //    employeeTimeSheetEntryList1 = employeeTimeSheetEntryList.Where(x => x.HRTimeSheetAuditEntryDate < objEmployeeTranfersInfo.HREmployeeTranferDateFrom).ToList();
                //    decimal totalSalaryFactor = 0;
                //    decimal totalSalaryOTHours = 0;
                //    foreach (HRTimeSheetAuditEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList1)
                //    {
                //        if (objTimeSheetEntrysInfo.IsOT == false)
                //        {
                //            totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingQty;
                //        }
                //        else
                //        {
                //            totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingHours;
                //        }
                //    }
                //    // Công thực tế
                //    employeePayRoll.HREmployeeRealDaysPerMonth = totalSalaryFactor;
                //    // Giờ tăng ca
                //    employeePayRoll.HREmployeeHoursOT = totalSalaryOTHours;
                //    SetDefaultValuesFromEmployee(employeePayRoll, objEmployeesInfo);
                //    // Lương chưa trừ
                //    //employeePayRoll.HREmployeeWorkingSlrAmtFull = employeePayRoll.HREmployeePayRollAuditWorkingSalary * employeePayRoll.HREmployeeRealDaysPerMonth / employeePayRoll.HREmployeeDaysPerMonth;
                //    // Lương tăng ca
                //    employeePayRoll.HREmployeePayRollAuditOTSalary = (employeePayRoll.HREmployeePayRollAuditWorkingSalary / employeePayRoll.HREmployeeDaysPerMonth / 8) * employeePayRoll.HREmployeeHoursOT;
                //    // Lương khoán

                //    employeePayRoll.HREmployeePieceworkSalary = 0;
                //    if (EmployeePieceWageItemList != null)
                //    {
                //        List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                //            EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                //        if (EmployeePieceWageItemTotal != null)
                //            employeePayRoll.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);

                //    }
                //    decimal heso = 0;
                //    if (employeeTimeSheetEntryList != null)
                //    {
                //        HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = (HRTimeSheetAuditEntrysInfo)employeeTimeSheetEntryList.Where(o => o.IsOT == true).FirstOrDefault();
                //        if (objTimeSheetAuditEntrysInfo != null)
                //        {
                //            heso = objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFactor;
                //        }
                //    }
                //    // Bù lương => tiền thừa tăng ca
                //    employeePayRoll.HREmployeeOffsetSalary = employeePayRoll.HREmployeeContractSlrAmt
                //                                            * employeeTimeSheet.HREmployeeTimeSheetAuditHourProductivity * heso
                //                                            / employeePayRoll.HREmployeeDaysPerMonth
                //                                            / 8;
                //    CalculatePayRollTotalAmounts(employeePayRoll, listAllowanceConfigEmployee);
                //    // end phase 1
                //    // phase 2
                //    objEmployeesInfo2 = new HREmployeesInfo();
                //    BOSUtil.CopyObject(employeePayRoll, employeePayRoll2);
                //    BOSUtil.CopyObject(objEmployeesInfo, objEmployeesInfo2);

                //    employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(objTimeSheetsInfo.HRTimeSheetAuditID, employeeTimeSheet.HREmployeeTimeSheetAuditID);
                //    employeeTimeSheetEntryList2 = employeeTimeSheetEntryList.Where(x => x.HRTimeSheetAuditEntryDate >= objEmployeeTranfersInfo.HREmployeeTranferDateFrom).ToList();
                //    totalSalaryFactor = 0;
                //    totalSalaryOTHours = 0;
                //    foreach (HRTimeSheetAuditEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList2)
                //    {
                //        if (objTimeSheetEntrysInfo.IsOT == false)
                //        {
                //            totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingQty;
                //        }
                //        else
                //        {
                //            totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingHours;
                //        }
                //    }
                //    // Công thực tế
                //    employeePayRoll2.HREmployeeRealDaysPerMonth = totalSalaryFactor;
                //    // Giờ tăng ca
                //    employeePayRoll2.HREmployeeHoursOT = totalSalaryOTHours;
                //    SetDefaultValuesFromEmployeeTransfer(employeePayRoll2, objEmployeeTranfersInfo, listAllowanceConfigEmployee);
                //    // Lương chưa trừ
                //    //employeePayRoll2.HREmployeeWorkingSlrAmtFull = employeePayRoll2.HREmployeePayRollAuditWorkingSalary * employeePayRoll2.HREmployeeRealDaysPerMonth / employeePayRoll2.HREmployeeDaysPerMonth;
                //    // Lương tăng ca
                //    employeePayRoll2.HREmployeePayRollAuditOTSalary = (employeePayRoll2.HREmployeePayRollAuditWorkingSalary / employeePayRoll2.HREmployeeDaysPerMonth / 8) * employeePayRoll2.HREmployeeHoursOT;
                //    // Lương khoán
                //    employeePayRoll2.HREmployeePieceworkSalary = 0;
                //    if (EmployeePieceWageItemList != null)
                //    {
                //        List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                //            EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                //        if (EmployeePieceWageItemTotal != null)
                //            employeePayRoll2.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);

                //    }

                //    heso = 0;
                //    if (employeeTimeSheetEntryList != null)
                //    {
                //        HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = (HRTimeSheetAuditEntrysInfo)employeeTimeSheetEntryList.Where(o => o.IsOT == true).FirstOrDefault();
                //        if (objTimeSheetAuditEntrysInfo != null)
                //        {
                //            heso = objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFactor;
                //        }
                //    }
                //    // Bù lương => tiền thừa tăng ca
                //    employeePayRoll2.HREmployeeOffsetSalary = employeePayRoll2.HREmployeeContractSlrAmt
                //                                                * employeeTimeSheet.HREmployeeTimeSheetAuditHourProductivity * heso
                //                                                / 8
                //                                                / employeePayRoll2.HREmployeeDaysPerMonth;
                //    CalculatePayRoll(employeePayRoll2, objEmployeesInfo, listAllowanceConfigEmployee);
                //    //CalculatePayRollTotalAmounts(employeePayRoll2, listAllowanceConfigEmployee);
                //    // end phase 2
                //}
                //else
                {
                    employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(objPayRollsInfo.FK_HRTimeSheetAuditID, employeeTimeSheet.HREmployeeTimeSheetAuditID);

                    decimal totalSalaryFactorNight = 0;
                    decimal totalSalaryFactor = 0;
                    decimal totalSalaryOTHours = 0;
                    decimal totalOTHour = 0;
                    decimal nghiPN = 0;
                    decimal cTyChoNghi = 0;
                    decimal nghiLe = 0;
                    decimal nghiCheDo = 0;
                    decimal nghiCupDien = 0;
                    decimal nghiPhep = 0;
                    decimal ctyChoNghi = 0;
                    decimal nghiKPhep = 0;
                    HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                    HROTFactorsController objOTFactorsController = new HROTFactorsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    foreach (HRTimeSheetAuditEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList)
                    {
                        if (objTimeSheetEntrysInfo.IsNightWorking)
                        {
                            totalSalaryFactorNight += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingQty;
                        }
                        else if (objTimeSheetEntrysInfo.HRTimeSheetParamType == TimeSheetParamType.Day.ToString()
                            || objTimeSheetEntrysInfo.HRTimeSheetParamType == TimeSheetParamType.Hour.ToString())
                        {
                            if (objTimeSheetEntrysInfo.IsOT == false)
                            {
                                totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingQty;
                            }
                            else
                            {
                                totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingHours;
                                totalOTHour += objTimeSheetEntrysInfo.HRTimeSheetAuditEntryWorkingHours / objTimeSheetEntrysInfo.HRTimeSheetAuditEntryFactor;
                            }
                        }
                        //HRTimeSheetParamsInfo objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(objTimeSheetEntrysInfo.FK_HRTimeSheetParamID);
                        //if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.PN.ToString())
                        //{
                        //    nghiPN += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.CTCN.ToString())
                        //{
                        //    cTyChoNghi += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.LE.ToString())
                        //{
                        //    nghiLe += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.NCDO.ToString())
                        //{
                        //    nghiCheDo += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.NCD.ToString())
                        //{
                        //    nghiCupDien += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null &&
                        //    (objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.NCP.ToString()
                        //    || objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.NCP1P2.ToString()))
                        //{
                        //    nghiPhep += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.CTCN.ToString())
                        //{
                        //    ctyChoNghi += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                        //if (objTimeSheetParamsInfo != null &&
                        //    (objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.NKP.ToString()
                        //    || objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.NKP1P2.ToString()))
                        //{
                        //    nghiKPhep += objTimeSheetParamsInfo.HRTimeSheetParamValue1 / 8;
                        //}
                    }
                    employeePayRoll.HREmployeePayRollAuditPermissionOTDaysOff = employeeTimeSheet.HREmployeeTimeSheetAuditPermissionOTDaysOff * SubtractOT;
                    //employeePayRoll.HREmployeePayRollAuditDaysPerMonth = totalSalaryFactorNight + totalSalaryFactor + nghiLe + ctyChoNghi + nghiCheDo + employeeTimeSheet.HREmployeeTimeSheetAuditNghiPhepNam;

                    //Số ngày phép năm hưởng lương
                    HREmployeeRewardsController objEmployeeRewardsController = new HREmployeeRewardsController();
                    List<HREmployeeRewardsInfo> list = objEmployeeRewardsController.GetEmployeeRewardByEmployeeIDAndDate(objEmployeesInfo.HREmployeeID, objPayRollsInfo.HRPayRollAuditDate, RewardType.PNTL.ToString());
                    decimal phepnamTL = 0;
                    if (list.Count() > 0)
                    {
                        phepnamTL = (decimal)list.Sum(o => o.HREmployeeRewardSPN);
                    }
                    //=============================

                    // Công thực tế
                    employeePayRoll.HREmployeeRealDaysPerMonth = RoundingTimeSheet(totalSalaryFactor);
                    //Ca đêm
                    employeePayRoll.HREmployeeRealNightsPerMonth = RoundingTimeSheet(totalSalaryFactorNight);
                    // Giờ tăng ca
                    employeePayRoll.HREmployeeHoursOT = totalSalaryOTHours;
                    employeePayRoll.HREmployeePayRollProHoursOT = totalOTHour;
                    SetDefaultValuesFromEmployee(employeePayRoll, objEmployeesInfo);
                    HREmployeeTimeSheetAuditOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetAuditOTDetailsController();
                    employeeTimeSheet.HREmployeeTimeSheetAuditOTDetailsList = objEmployeeTimeSheetOTDetailsController.GetListTimeSheetAuditOTDetailByEmployeeTimeSheetAudit(employeeTimeSheet.HREmployeeTimeSheetAuditID);
                    List<HREmployeePayRollAuditDetailsInfo> employeePayrollDetails = new List<HREmployeePayRollAuditDetailsInfo>();
                    //List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
                    List<HROTFactorsInfo> OTFactorlist = (List<HROTFactorsInfo>)objOTFactorsController.GetAllDistinctFactors();
                    foreach (var otfactor in OTFactorlist)
                    {
                        HREmployeePayRollAuditDetailsInfo objEmployeePayrollDetailsInfo = new HREmployeePayRollAuditDetailsInfo();
                        objEmployeePayrollDetailsInfo.HREmployeeTimeSheetAuditOTDetailFactor = otfactor.HROTFactorValue;
                        objEmployeePayrollDetailsInfo.HREmployeeTimeSheetAuditOTDetailName = otfactor.HROTFactorType + otfactor.HROTFactorValue.ToString();
                        if (otfactor.HROTFactorType == OTFactorType.WorkingDay.ToString())
                        {
                            foreach (var item in employeeTimeSheetEntryList)
                            {
                                if (item.IsOT)
                                {
                                    if (!BOSApp.IsEndOfWeek(item.HRTimeSheetAuditEntryDate.DayOfWeek) && !BOSApp.IsHoliday(item.HRTimeSheetAuditEntryDate.Date))
                                    {
                                        if (otfactor.HROTFactorValue == item.HRTimeSheetAuditEntryFactor)
                                        {
                                            objEmployeePayrollDetailsInfo.HREmployeePayRollAuditHours += item.HRTimeSheetAuditEntryWorkingHours / item.HRTimeSheetAuditEntryFactor;
                                        }
                                    }
                                }
                            }
                            objEmployeePayrollDetailsInfo.HREmployeePayRollAuditBasicSalary = employeePayRoll.HREmployeePayRollAuditWorkingSalary;
                        }
                        else if (otfactor.HROTFactorType == OTFactorType.EndOfWeek.ToString())
                        {
                            foreach (var item in employeeTimeSheetEntryList)
                            {
                                if (item.IsOT)
                                {
                                    if (BOSApp.IsEndOfWeek(item.HRTimeSheetAuditEntryDate.DayOfWeek))
                                    {
                                        if (otfactor.HROTFactorValue == item.HRTimeSheetAuditEntryFactor)
                                        {
                                            objEmployeePayrollDetailsInfo.HREmployeePayRollAuditHours += item.HRTimeSheetAuditEntryWorkingHours / item.HRTimeSheetAuditEntryFactor;
                                        }
                                    }
                                }
                            }
                            objEmployeePayrollDetailsInfo.HREmployeePayRollAuditBasicSalary = employeePayRoll.HREmployeePayRollAuditWorkingSalary;
                        }
                        else if (otfactor.HROTFactorType == OTFactorType.Holiday.ToString())
                        {
                            foreach (var item in employeeTimeSheetEntryList)
                            {
                                if (item.IsOT)
                                {
                                    if (BOSApp.IsHoliday(item.HRTimeSheetAuditEntryDate.Date))
                                    {
                                        if (otfactor.HROTFactorValue == item.HRTimeSheetAuditEntryFactor)
                                        {
                                            objEmployeePayrollDetailsInfo.HREmployeePayRollAuditHours += item.HRTimeSheetAuditEntryWorkingHours / item.HRTimeSheetAuditEntryFactor;
                                        }
                                    }
                                }
                            }
                            objEmployeePayrollDetailsInfo.HREmployeePayRollAuditBasicSalary = employeePayRoll.HREmployeePayRollAuditWorkingSalary;
                        }

                        objEmployeePayrollDetailsInfo.HREmployeePayRollAuditSalaryFactor =
                                (objEmployeePayrollDetailsInfo.HREmployeePayRollAuditBasicSalary / employeePayRoll.HREmployeeDaysPerMonth / 8) * (objEmployeePayrollDetailsInfo.HREmployeePayRollAuditHours * objEmployeePayrollDetailsInfo.HREmployeeTimeSheetAuditOTDetailFactor);
                        employeePayrollDetails.Add(objEmployeePayrollDetailsInfo);
                    }
                    employeePayRoll.HREmployeePayRollAuditDetailsList = employeePayrollDetails;
                    //employeePayRoll.HREmployeePayRollAuditNghiPhepNam = nghiPN;
                    employeePayRoll.HREmployeePayRollAuditNghiPhepNam = employeeTimeSheet.HREmployeeTimeSheetAuditNghiPhepNam + phepnamTL;
                    employeePayRoll.HREmployeePayRollAuditCtyChoNghi = employeeTimeSheet.HREmployeeTimeSheetAuditCongTyChoNghi;
                    employeePayRoll.HREmployeePayRollAuditNghiLe = employeeTimeSheet.HREmployeeTimeSheetAuditNghiLe;
                    employeePayRoll.HREmployeePayRollAuditNghiCheDo = employeeTimeSheet.HREmployeeTimeSheetAuditNghiCheDo;
                    employeePayRoll.HREmployeePayRollAuditNghiCupDien = nghiCupDien;
                    employeePayRoll.HREmployeePayRollAuditNghiPhep = employeeTimeSheet.HREmployeeTimeSheetAuditNghiCoPhep;
                    //employeePayRoll.HREmployeePayRollAuditNghiKPhep = nghiKPhep;
                    employeePayRoll.HREmployeePayRollAuditNghiKPhep = employeeTimeSheet.HREmployeeTimeSheetAuditNghiKhongPhep;
                    // Lương tăng ca
                    employeePayRoll.HREmployeePayRollAuditOTSalary = (employeePayRoll.HREmployeePayRollAuditWorkingSalary
                        / employeePayRoll.HREmployeeDaysPerMonth / 8) * employeePayRoll.HREmployeeHoursOT;
                    // Lương khoán
                    employeePayRoll.HREmployeePieceworkSalary = 0;
                    if (EmployeePieceWageItemList != null)
                    {
                        List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                            EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                        if (EmployeePieceWageItemTotal != null)
                            employeePayRoll.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);

                    }
                    decimal heso = 0;
                    if (employeeTimeSheetEntryList != null)
                    {
                        HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = (HRTimeSheetAuditEntrysInfo)employeeTimeSheetEntryList.Where(o => o.IsOT == true).FirstOrDefault();
                        if (objTimeSheetAuditEntrysInfo != null)
                        {
                            heso = objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFactor;
                        }
                    }

                    //employeePayRoll.HREmployeePayRollAuditDaysPerMonth = totalSalaryFactorNight + totalSalaryFactor + nghiLe + ctyChoNghi + nghiCheDo + employeeTimeSheet.HREmployeeTimeSheetAuditNghiPhepNam;
                    employeePayRoll.HREmployeePayRollAuditDaysPerMonth = employeePayRoll.HREmployeeRealNightsPerMonth
                                                                    + employeePayRoll.HREmployeeRealDaysPerMonth
                                                                    + employeePayRoll.HREmployeePayRollAuditNghiLe
                                                                    + employeePayRoll.HREmployeePayRollAuditCtyChoNghi
                                                                    + employeePayRoll.HREmployeePayRollAuditNghiCheDo
                                                                    + employeePayRoll.HREmployeePayRollAuditNghiPhepNam;

                    // Bù lương => tiền thừa tăng ca
                    employeePayRoll.HREmployeeOffsetSalary = employeePayRoll.HREmployeeContractSlrAmt
                                                            * employeeTimeSheet.HREmployeeTimeSheetAuditHourProductivity * heso
                                                            / employeePayRoll.HREmployeeDaysPerMonth / 8;
                    CalculatePayRoll(employeePayRoll, objEmployeesInfo, listAllowanceConfigEmployee);

                    //CalculatePayRollTotalAmounts(employeePayRoll, listAllowanceConfigEmployee);
                }
            }
            else
            {
                employeePayRoll.HRDepartmentRoomName = objEmployeesInfo.HRDepartmentRoomName;
                employeePayRoll.HRDepartmentName = objEmployeesInfo.HRDepartmentName;
                employeePayRoll.HRDepartmentRoomGroupItemName = objEmployeesInfo.HRDepartmentRoomGroupItemName;
                employeePayRoll.HREmployeeBankAccount1 = objEmployeesInfo.HREmployeeBankAccount1;
                employeePayRoll.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                employeePayRoll.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                employeePayRoll.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                employeePayRoll.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                employeePayRoll.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                employeePayRoll.HREmployeeName = objEmployeesInfo.HREmployeeName;
                // Ngày công qui định
                employeePayRoll.HREmployeeDaysPerMonth = 0;
                // Hệ số
                employeePayRoll.HREmployeeSalaryFactor = 0;
                // Lương cơ bản
                employeePayRoll.HREmployeeContractSlrAmt = 0;
                // Lương công việc
                employeePayRoll.HREmployeePayRollAuditWorkingSalary = 0;

                if (EmployeePieceWageItemList != null)
                {
                    List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                        EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                    if (EmployeePieceWageItemTotal != null)
                        employeePayRoll.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);

                }
            }
        }

        public decimal RoundingTimeSheet(decimal number)
        {
            decimal soNguyen = Math.Floor(number);
            decimal soDu = number - soNguyen;

            decimal result = 0;
            if (soDu >= 0 && soDu < (decimal)0.5)
            {
                result = soNguyen;
            }
            else if (soDu >= (decimal)0.5 && soDu < (decimal)0.8)
            {
                result = soNguyen + (decimal)0.5;
            }
            else
            {
                result = Math.Ceiling(number);
            }

            return result;
        }
    }
}
