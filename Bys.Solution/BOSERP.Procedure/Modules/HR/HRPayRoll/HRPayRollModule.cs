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
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.HRPayRoll
{
    public class HRPayRollModule : BaseTransactionModule
    {
        #region Declare Constant
        /// <summary>
        /// The employee payroll grid control name
        /// </summary>
        public const string HREmployeePayRollsGridControlName = "fld_dgcHREmployeePayRolls";
        public const string THOKHOAN_TYPE = "Thợ khoán";
        #endregion

        #region Declare Variables
        /// <summary>
        /// Define employe payroll grid control
        /// </summary>
        private HREmployeePayRollsGridControl EmployeePayRollsGridControl;
        decimal HoursPerDay = 0;
        decimal DaysPerMonth = 0;
        decimal SubtractOT = 0;
        List<HREmployeesInfo> EmployeesList;
        List<HREmployeeTransmitItemsInfo> EmployeeTransmitItemList;
        #endregion

        public HRPayRollModule()
        {
            Name = "HRPayRoll";
            CurrentModuleEntity = new HRPayRollEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            EmployeePayRollsGridControl = (HREmployeePayRollsGridControl)Controls[HRPayRollModule.HREmployeePayRollsGridControlName];
            EmployeesList = new List<HREmployeesInfo>();
            EmployeeTransmitItemList = new List<HREmployeeTransmitItemsInfo>();

        }

        public override void InvalidateToolbar()
        {
            HRPayRollsInfo payroll = (HRPayRollsInfo)CurrentModuleEntity.MainObject;
            if (payroll.HRPayRollID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("Refresh", true);
                if (payroll.HRPayRollStatus == PayRollStatus.Posted.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("Refresh", false);
                }
                else if (payroll.HRPayRollStatus == PayRollStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("Refresh", false);
                }
                else if (payroll.HRPayRollStatus == PayRollStatus.New.ToString())
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
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
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

                entity.EmployeePayRollList.GridControl.RefreshDataSource();
            }
        }
        public void ApprovePayRoll()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
                entity.SetPropertyChangeEventLock(false);
                HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
                objPayRollsInfo.HRPayRollStatus = PayRollStatus.Approved.ToString();
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

            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRLevelsController objLevelsController = new HRLevelsController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            foreach (HREmployeePayRollsInfo objEmployeePayRollsInfo in entity.EmployeePayRollList)
            {
                HREmployeesInfo objEmployeesInfo = employeeList.Where(e => e.HREmployeeID == objEmployeePayRollsInfo.FK_HREmployeeID).FirstOrDefault();
                if (objEmployeesInfo != null)
                {
                    //listAllowanceConfigEmployee = listAllowanceConfig.Where(t=>t.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();
                    //CalculatePayRollTotalAmounts(objEmployeePayRollsInfo, listAllowanceConfigEmployee);
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
                HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
                entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);

                //TNDLoc [ADD][Issue allowane],START
                List<HRAllowanceConfigsInfo> listAllowanceConfigs = GetAllowanceConfigList();
                //TNDLoc [ADD][Issue allowane],END

                foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.EmployeePayRollList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeePayRollsInfo objEmployeePayRollsInfo = new HREmployeePayRollsInfo();
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
                            entity.EmployeePayRollList.Add(objEmployeePayRollsInfo);
                        }
                    }
                }
                entity.EmployeePayRollList.GridControl.RefreshDataSource();
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
            objPayRollsInfo.HRPayRollDate = DateTime.Now;
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
        public void ActionNewFromTimeSheet()
        {
            ActionNew();

            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            List<HRTimeSheetsInfo> timeSheetList = objTimeSheetsController.GetTimeSheetsForPayRoll();
            guiFind<HRTimeSheetsInfo> guiFind = new guiFind<HRTimeSheetsInfo>(TableName.HRTimeSheetsTableName, timeSheetList, null, this);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                int timeSheetID = Convert.ToInt32(guiFind.Tag.ToString());
                HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(timeSheetID);
                //Set default main object
                objPayRollsInfo.HRPayRollType = objTimeSheetsInfo.HRTimeSheetType;
                objPayRollsInfo.HRPayRollDate = objTimeSheetsInfo.HRTimeSheetDate;
                objPayRollsInfo.FromDate = objTimeSheetsInfo.HRTimeSheetFromDate;
                objPayRollsInfo.ToDate = objTimeSheetsInfo.HRTimeSheetToDate;
                objPayRollsInfo.FK_HRTimeSheetID = objTimeSheetsInfo.HRTimeSheetID;
                if (objTimeSheetsInfo != null)
                {
                    //TNDLoc [ADD][Issue allowance],START
                    List<HRAllowanceConfigsInfo> listAllowanceConfigs = GetAllowanceConfigList();
                    //TNDLoc [ADD][Issue allowance],END

                    //Add employee time sheet info to employee payroll list
                    // CTChinh - PayRoll BEGIN
                    HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
                    HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
                    HREmployeeTranfersController objEmployeeTranfersController = new HREmployeeTranfersController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();
                    List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList = objEmployeePieceWageItemsController.GetEmployeePieceWageItemByDate(objPayRollsInfo.FromDate, objPayRollsInfo.ToDate);
                    //TNDLoc [ADD][19/04/2016][Employee permission],START
                    // Origin :List<HREmployeeTimeSheetsInfo> employeeTimeSheets = objEmployeeTimeSheetsController.GetEmployeeTimeSheetsByTimeSheetID(objTimeSheetsInfo.HRTimeSheetID);
                    List<HREmployeeTimeSheetsInfo> employeeTimeSheets = objEmployeeTimeSheetsController.GetEmployeeTimeSheetByTimeSheetIDAndUserGroup(objTimeSheetsInfo.HRTimeSheetID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                    //TNDLoc [ADD][19/04/2016][Employee permission],END
                    HREmployeePayRollsInfo employeePayRoll = new HREmployeePayRollsInfo();

                    foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in employeeTimeSheets)
                    {
                        employeePayRoll = new HREmployeePayRollsInfo();
                        UpdateEmployeePayrollDetailsList(employeePayRoll, EmployeePieceWageItemList, employeeTimeSheet, objPayRollsInfo, listAllowanceConfigs);
                        entity.EmployeePayRollList.Add(employeePayRoll);
                        //if (objEmployeeTranfersInfo != null)
                        //{
                        //    entity.EmployeePayRollList.Add(employeePayRoll2);
                        //}
                    }
                    // CTChinh - PayRoll END
                }
                entity.EmployeePayRollList.GridControl.RefreshDataSource();
            }
            else
            {
                ActionCancel();
            }
        }

        public void CalculateRefreshPayRoll()
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();

            if (objPayRollsInfo.FromDate == DateTime.MinValue && objPayRollsInfo.ToDate == DateTime.MinValue)
            {
                if (objPayRollsInfo.FK_HRTimeSheetID > 0)
                {
                    HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(objPayRollsInfo.FK_HRTimeSheetID);
                    objPayRollsInfo.FromDate = objTimeSheetsInfo.HRTimeSheetFromDate;
                    objPayRollsInfo.ToDate = objTimeSheetsInfo.HRTimeSheetToDate;
                }
                else
                {
                    DateTime lastDate = new DateTime(objPayRollsInfo.HRPayRollDate.Year, objPayRollsInfo.HRPayRollDate.Month, DateTime.DaysInMonth(objPayRollsInfo.HRPayRollDate.Year, objPayRollsInfo.HRPayRollDate.Month));
                    DateTime firstDate = new DateTime(objPayRollsInfo.HRPayRollDate.Year, objPayRollsInfo.HRPayRollDate.Month, 1);

                    objPayRollsInfo.FromDate = firstDate;
                    objPayRollsInfo.ToDate = lastDate;

                }
            }

            List<HRAllowanceConfigsInfo> listAllowanceConfigs = GetAllowanceConfigList();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            HREmployeeTranfersController objEmployeeTranfersController = new HREmployeeTranfersController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();
            List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList = objEmployeePieceWageItemsController.GetEmployeePieceWageItemByDate(objPayRollsInfo.FromDate, objPayRollsInfo.ToDate);
            List<HREmployeeTimeSheetsInfo> employeeTimeSheets = objEmployeeTimeSheetsController.GetEmployeeTimeSheetByTimeSheetIDAndUserGroup(objPayRollsInfo.FK_HRTimeSheetID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            HREmployeePayRollsInfo employeePayRoll = new HREmployeePayRollsInfo();

            if (entity.EmployeePayRollList != null && entity.EmployeePayRollList.Count > 0)
            {
                foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in employeeTimeSheets)
                {
                    entity.EmployeePayRollList.ForEach(o =>
                    {
                        if (o.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID)
                        {
                            employeePayRoll = o;
                            UpdateEmployeePayrollDetailsList(employeePayRoll, EmployeePieceWageItemList, employeeTimeSheet, objPayRollsInfo, listAllowanceConfigs);
                        }
                    });
                }
                entity.EmployeePayRollList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Called when the user changes the payroll type
        /// </summary>
        /// <param name="payrollType">Target payroll type</param>
        public void ChangePayRollType(string payrollType)
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
            objPayRollsInfo.HRPayRollType = payrollType;
            CalculatePayRoll();
        }

        /// <summary>
        /// Remove the selected employee from the current employee payroll list
        /// </summary>
        public void RemoveEmployeeFromPayRollList()
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.EmployeePayRollList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.EmployeePayRollList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        #region Print
        /// <summary>
        /// Print employee payroll
        /// </summary>
        public void PrintPayRoll()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
                HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
                RPPayRoll report = new RPPayRoll();
                //report.LoadLayout(BOSCommon.Constants.Report.DevPayRollReportPath);

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
                XRLabel payrollMonth = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollMonth"];
                if (payrollMonth != null)
                    payrollMonth.Text = objPayRollsInfo.HRPayRollDate.Month.ToString();
                XRLabel payrollYear = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollYear"];
                if (payrollYear != null)
                    payrollYear.Text = objPayRollsInfo.HRPayRollDate.Year.ToString();

                report.DataSource = entity.EmployeePayRollList;
                //convert payroll total amount to word
                XRLabel amountToWord = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWord"];
                if (amountToWord != null)
                {
                    decimal payRollTotalAmt = entity.EmployeePayRollList.Sum(e => e.HREmployeePayRollTotalSalary);
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
        /// Print employee payroll lable
        /// </summary>
        public void PrintPayRollLable()
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
            //RPPayRollLable report = new RPPayRollLable();
            RPPayRollLableNew report = new RPPayRollLableNew();
            //report.LoadLayout(BOSCommon.Constants.Report.DevPayRollLableReportPath);

            //Set payroll date
            XRLabel payrollMonth = (XRLabel)report.Bands[BandKind.Detail].Controls["xr_lblHRPayRollMonth"];
            if (payrollMonth != null)
                payrollMonth.Text = objPayRollsInfo.HRPayRollDate.Month.ToString();
            XRLabel payrollYear = (XRLabel)report.Bands[BandKind.Detail].Controls["xr_lblHRPayRollYear"];
            if (payrollYear != null)
                payrollYear.Text = objPayRollsInfo.HRPayRollDate.Year.ToString();

            var employeePayrolls = (BOSList<HREmployeePayRollsInfo>)entity.EmployeePayRollList.Clone();
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var employeePayroll in employeePayrolls)
            {
                if (employeePayroll.HREmployeePayrollDetailsList != null)
                {
                    employeePayroll.OTFactory1 = 0;
                    employeePayroll.OTFactory3 = 0;
                    employeePayroll.OTFactory2 = 0;
                    employeePayroll.OTFactory4 = 0;
                    employeePayroll.HREmployeePayrollDetailsList.ForEach(o =>
                    {
                        if (o.HREmployeeTimeSheetOTDetailFactor == (decimal)1.5)
                        {
                            employeePayroll.OTFactory1 += o.HREmployeePayrollHours;
                            employeePayroll.OTFactory2 += o.HREmployeePayrollSalaryFactor;
                        }
                        else
                        {
                            employeePayroll.OTFactory4 += o.HREmployeePayrollSalaryFactor;
                            employeePayroll.OTFactory3 += o.HREmployeePayrollHours;
                        }
                    });
                }
            }
            report.DataSource = employeePayrolls;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPayRollLableReportPath, true);
            reviewer.Show();
        }

        /// <summary>
        /// Print payroll card
        /// </summary>
        /// <param name="report">Given card, can be either a template or a real one</param>
        public void PrintPayRollCard(XtraReport report)
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

                List<HRAllowanceConfigsInfo> listAllowanceConfig = GetAllowanceConfigList();
                List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();

                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo employeeInfo = new HREmployeesInfo();

                //Set payroll date    
                HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
                HRPayRollsInfo payroll = (HRPayRollsInfo)entity.MainObject;
                DateTime startYear = BOSUtil.GetYearBeginDate(payroll.HRPayRollDate);
                DateTime endYear = BOSUtil.GetYearEndDate(payroll.HRPayRollDate);
                XRLabel dateTitle = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblDateTitle"];
                if (dateTitle != null)
                {
                    dateTitle.Text = string.Format("{0} {1} {2} {3}",
                                                    ReportLocalizedResources.FromMonth,
                                                    startYear.ToString("MM/yyyy"),
                                                    ReportLocalizedResources.ToMonth,
                                                    endYear.ToString("MM/yyyy"));
                }
                ADReportsController objReportsController = new ADReportsController();
                var employeePayrolls = (IList<HREmployeePayRollsInfo>)entity.EmployeePayRollList.Clone();
                for (int i = 0; i < employeePayrolls.Count; i++)
                {
                    if (!guiSearchEmployee.SelectedEmployeeList.Exists(e => e.HREmployeeID == employeePayrolls[i].FK_HREmployeeID))
                    {
                        employeePayrolls.RemoveAt(i);
                        i--;
                    }
                }
                foreach (var employeePayRoll in employeePayrolls)
                {
                    employeePayRoll.HRPayRollDate = payroll.HRPayRollDate;

                    listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();
                    employeeInfo = (HREmployeesInfo)employeeController.GetObjectByID(employeePayRoll.FK_HREmployeeID);
                    if (employeeInfo != null)
                    {
                        listAllowanceConfigEmployee = listAllowanceConfig.Where(t => t.FK_HREmployeePayrollFormulaID == employeeInfo.FK_HREmployeePayrollFormulaID).ToList();
                    }

                    CalculatePayRollTotalAmounts(employeePayRoll, listAllowanceConfigEmployee);
                }
                foreach (HREmployeesInfo employee in guiSearchEmployee.SelectedEmployeeList)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i < payroll.HRPayRollDate.Month)
                        {
                            HREmployeePayRollsInfo employeePayroll = new HREmployeePayRollsInfo();
                            employeePayroll.HREmployeeNo = employee.HREmployeeNo;
                            employeePayroll.HREmployeeName = employee.HREmployeeName;
                            employeePayroll.HRDepartmentRoomName = employee.HRDepartmentRoomName;
                            employeePayroll.HRDepartmentRoomGroupItemName = employee.HRDepartmentRoomGroupItemName;
                            employeePayroll.HREmployeeBankAccount1 = employee.HREmployeeBankAccount1;
                            employeePayroll.HRLevelName = employee.HRLevelName;
                            employeePayrolls.Insert(i - 1, employeePayroll);
                        }
                        else if (i > payroll.HRPayRollDate.Month)
                        {
                            HREmployeePayRollsInfo employeePayroll = new HREmployeePayRollsInfo();
                            employeePayroll.HREmployeeNo = employee.HREmployeeNo;
                            employeePayroll.HREmployeeName = employee.HREmployeeName;
                            employeePayroll.HRDepartmentRoomName = employee.HRDepartmentRoomName;
                            employeePayroll.HRDepartmentRoomGroupItemName = employee.HRDepartmentRoomGroupItemName;
                            employeePayroll.HREmployeeBankAccount1 = employee.HREmployeeBankAccount1;
                            employeePayroll.HRLevelName = employee.HRLevelName;
                            employeePayrolls.Add(employeePayroll);
                        }
                    }
                }
                report.DataSource = employeePayrolls;

                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Print payroll card
        /// </summary>
        public void PrintPayRollCard()
        {
            RPPayRollCard report = new RPPayRollCard();
            PrintPayRollCard(report);
        }

        /// <summary>
        /// Print payroll card template
        /// </summary>
        public void PrintPayRollCardTemplate()
        {
            RPPayRollCardTemplate report = new RPPayRollCardTemplate();
            PrintPayRollCard(report);
        }

        /// <summary>
        /// Export pay roll to excel
        /// </summary>
        public void ExportPayRollToExcel()
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            if (entity.EmployeePayRollList.Count > 0)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = App.ExcelDialogFilter;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        AddSummaryToExportEcxel();
                        entity.EmployeePayRollList.GridControl.ExportToXls(sfd.FileName);
                        RemoveSummaryToExportEcxel();
                        Process.Start(sfd.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Add summary to export ecxel
        /// </summary>
        public void AddSummaryToExportEcxel()
        {
            HREmployeePayRollsInfo objEmployeePayrollInfo = new HREmployeePayRollsInfo();
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            if (entity.EmployeePayRollList.Count > 0)
            {
                foreach (HREmployeePayRollsInfo item in entity.EmployeePayRollList)
                {
                    objEmployeePayrollInfo.HREmployeeWorkingSlrAmtFull = objEmployeePayrollInfo.HREmployeeWorkingSlrAmtFull + item.HREmployeeWorkingSlrAmtFull;
                    objEmployeePayrollInfo.HREmployeePieceworkSalary = objEmployeePayrollInfo.HREmployeePieceworkSalary + item.HREmployeePieceworkSalary;
                    objEmployeePayrollInfo.HREmployeePayRollExtraSalary = objEmployeePayrollInfo.HREmployeePayRollExtraSalary + item.HREmployeePayRollExtraSalary;
                    objEmployeePayrollInfo.HREmployeeOffsetSalary = objEmployeePayrollInfo.HREmployeeOffsetSalary + item.HREmployeeOffsetSalary;
                    objEmployeePayrollInfo.HREmployeePayRollAdvance = objEmployeePayrollInfo.HREmployeePayRollAdvance + item.HREmployeePayRollAdvance;
                    objEmployeePayrollInfo.HREmployeePayRollSocialInsAmount = objEmployeePayrollInfo.HREmployeePayRollSocialInsAmount + item.HREmployeePayRollSocialInsAmount;
                    objEmployeePayrollInfo.HREmployeeLuongDaTru = objEmployeePayrollInfo.HREmployeeLuongDaTru + item.HREmployeeLuongDaTru;
                    objEmployeePayrollInfo.HREmployeeNoLuyTien = objEmployeePayrollInfo.HREmployeeNoLuyTien + item.HREmployeeNoLuyTien;
                    objEmployeePayrollInfo.HREmployeePayRollCommission = objEmployeePayrollInfo.HREmployeePayRollCommission + item.HREmployeePayRollCommission;
                    objEmployeePayrollInfo.HREmployeePayRollTotalSalary = objEmployeePayrollInfo.HREmployeePayRollTotalSalary + item.HREmployeePayRollTotalSalary;

                    objEmployeePayrollInfo.HREmployeeName = "Tổng cộng";
                    objEmployeePayrollInfo.HREmployeePayRollID = -1;
                }
                entity.EmployeePayRollList.Add(objEmployeePayrollInfo);
                entity.EmployeePayRollList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Remove summary to export ecxel
        /// </summary>
        public void RemoveSummaryToExportEcxel()
        {
            HREmployeePayRollsInfo objEmployeePayrollInfo = new HREmployeePayRollsInfo();
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            if (entity.EmployeePayRollList.Count > 0)
            {
                objEmployeePayrollInfo = entity.EmployeePayRollList.Where(x => x.HREmployeePayRollID == -1).FirstOrDefault();
                entity.EmployeePayRollList.Remove(objEmployeePayrollInfo);
                entity.EmployeePayRollList.GridControl.RefreshDataSource();
            }
        }
        #endregion

        #region Calculate payroll
        /// <summary>
        /// Set default values employee payroll from employee
        /// </summary>
        /// <param name="objEmployeePayRollsInfo">Given employee payroll</param>
        /// <param name="objEmployeesInfo">Given employee</param>

        public void SetDefaultValuesFromEmployeeTransfer(HREmployeePayRollsInfo objEmployeePayRollsInfo, HREmployeeTranfersInfo objEmployeeTranfersInfo, List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee)
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
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
            objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary = objEmployeesInfo.HREmployeeSalarySocialInsurance;

            //Lương thử việc
            objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary = 0;

            // Thưởng doanh số
            objEmployeePayRollsInfo.HREmployeePayRollBonusSale = objEmployeesInfo.HREmployeeBonusSale;

            // Phụ cấp
            objEmployeePayRollsInfo.HREmployeePayRollExtraSalary = objEmployeesInfo.HREmployeeExtraSalary1;

            //CalculatePayRoll(objEmployeePayRollsInfo, objEmployeesInfo, listAllowanceConfigEmployee);
            entity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollsTableName);
        }

        public void SetDefaultValuesFromEmployee(HREmployeePayRollsInfo objEmployeePayRollsInfo, HREmployeesInfo objEmployeesInfo, List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
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
            objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary = objEmployeesInfo.HREmployeeSalarySocialInsurance;

            //Lương thử việc
            objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary = 0;

            // Thưởng doanh số
            objEmployeePayRollsInfo.HREmployeePayRollBonusSale = objEmployeesInfo.HREmployeeBonusSale;

            //CalculatePayRoll(objEmployeePayRollsInfo, objEmployeesInfo, listAllowanceConfigs);
            entity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollsTableName);
        }

        public void SetDefaultValuesFromEmployee(HREmployeePayRollsInfo objEmployeePayRollsInfo, HREmployeesInfo objEmployeesInfo)
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
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
            objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary = objEmployeesInfo.HREmployeeSalarySocialInsurance;

            //Lương thử việc
            objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary = 0;

            // Thưởng doanh số
            objEmployeePayRollsInfo.HREmployeePayRollBonusSale = objEmployeesInfo.HREmployeeBonusSale;

            entity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollsTableName);
        }

        /// <summary>
        /// Calculate the current payroll
        /// </summary>
        public void CalculatePayRoll()
        {
            List<HRAllowanceConfigsInfo> listAllowanceConfig = GetAllowanceConfigList();
            List<HRAllowanceConfigsInfo> listAllowanceConfigEmployee = new List<HRAllowanceConfigsInfo>();

            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            foreach (HREmployeePayRollsInfo objEmployeePayRollsInfo in entity.EmployeePayRollList)
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
        public void CalculatePayRoll(HREmployeePayRollsInfo objEmployeePayRollsInfo)
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
        public void CalculatePayRoll(HREmployeePayRollsInfo employeePayRoll, HREmployeesInfo employee, List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
            HRPayRollsInfo payroll = (HRPayRollsInfo)entity.MainObject;
            ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
            ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();
            if (payroll.FromDate == DateTime.MinValue && payroll.ToDate == DateTime.MinValue)
            {
                if (payroll.FK_HRTimeSheetID > 0)
                {
                    HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
                    HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(payroll.FK_HRTimeSheetID);
                    payroll.FromDate = objTimeSheetsInfo.HRTimeSheetFromDate;
                    payroll.ToDate = objTimeSheetsInfo.HRTimeSheetToDate;
                }
                else
                {
                    DateTime lastDate = new DateTime(payroll.HRPayRollDate.Year, payroll.HRPayRollDate.Month, DateTime.DaysInMonth(payroll.HRPayRollDate.Year, payroll.HRPayRollDate.Month));
                    DateTime firstDate = new DateTime(payroll.HRPayRollDate.Year, payroll.HRPayRollDate.Month, 1);

                    payroll.FromDate = firstDate;
                    payroll.ToDate = lastDate;

                }
            }

            employeePayRoll.HREmployeePayRollJobPerformanceAmt = employee.HREmployeeJobPerformanceAmt;
            employeePayRoll.HREmployeePayRollSkillCoefficient = employee.HREmployeeSkillCoefficient;

            int daysInMonth = DateTime.DaysInMonth(payroll.HRPayRollDate.Year, payroll.HRPayRollDate.Month);
            int endOfWeekCount = 0;
            if (employee.HREmployeeDaysPerMonth == -1)
            {
                for (int i = 1; i <= daysInMonth; i++)
                {
                    DateTime date = new DateTime(payroll.HRPayRollDate.Year, payroll.HRPayRollDate.Month, i);
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

            employeePayRoll.HREmployeePayRollThuongKPI = 0;
            employeePayRoll.HREmployeePayrollPhiTheATM = 0;
            employeePayRoll.FK_HREmployeePayRollKPI = "";
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeePayRoll.FK_HREmployeeID);
            HREmployeeKPIEvaluationItemsController objEmployeeKPIEvaluationItemsController = new HREmployeeKPIEvaluationItemsController();
            HREmployeeATMCardManagesController objEmployeeATMCardManagesController = new HREmployeeATMCardManagesController();
            List<string> dsKPIID = new List<string>();
            if (objEmployeesInfo != null)
            {
                List<HREmployeeKPIEvaluationItemsInfo> employeeKPIEvaluation = objEmployeeKPIEvaluationItemsController.GetKPIEvaluationTotalAmountByFK_HREmployeeID(objEmployeesInfo.HREmployeeID, payroll.HRPayRollDate);
                if (employeeKPIEvaluation.Count() > 0)
                {
                    employeeKPIEvaluation.ForEach(o =>
                    {
                        dsKPIID.Add(o.FK_HRKPIEvaluationID.ToString());
                        employeePayRoll.HREmployeePayRollThuongKPI += o.HREmployeeKPIEvaluationItemTotalAmount;
                    });
                }

                List<HREmployeeATMCardManagesInfo> EmployeeATMCardManageList = objEmployeeATMCardManagesController.GetEmployeeATMCardByEmployeeIDAndDate(objEmployeesInfo.HREmployeeID, payroll.HRPayRollDate);
                if (EmployeeATMCardManageList.Count() > 0)
                {
                    EmployeeATMCardManageList.ForEach(o =>
                    {
                        employeePayRoll.HREmployeePayrollPhiTheATM += o.HREmployeeATMCardManageAmount;
                    });
                }
            }

            if (dsKPIID != null && dsKPIID.Count() > 0)
            {
                employeePayRoll.FK_HREmployeePayRollKPI = string.Join(",", dsKPIID.ToArray());
            }

            employeePayRoll.HREmployeePayRollAllowanceNangSuat = 0;

            foreach (HREmployeePayrollFormulaItemsInfo obj in payrollFormulaItemList)
            {
                // Lương thợ khoán
                //if (THOKHOAN_TYPE.Equals(objEmployeePayrollFormulasInfo.HREmployeePayrollFormulaName))
                //{
                //    decimal amount = 0;
                //    HREmployeePieceWorksController objEPW = new HREmployeePieceWorksController();
                //    HREmployeePieceWorksController employeePieceWorksController = new HREmployeePieceWorksController();
                //    HRManufactureTimeSheetsController manufactureTimeSheetsController = new HRManufactureTimeSheetsController();
                //    HRManufactureTimeSheetItemsController manufactureTimeSheetItemsController = new HRManufactureTimeSheetItemsController();
                //    DataSet ds = manufactureTimeSheetsController.GetManufactureTimeSheetList(null, null, null, dateFrom, dateTo);
                //    if (ds.Tables[0].Rows.Count > 0)
                //    {
                //        HRManufactureTimeSheetsInfo manufactureTimeSheetsInfo = new HRManufactureTimeSheetsInfo();
                //        foreach (DataRow row in ds.Tables[0].Rows)
                //        {
                //            manufactureTimeSheetsInfo = (HRManufactureTimeSheetsInfo)manufactureTimeSheetsController.GetObjectFromDataRow(row);
                //            List<HRManufactureTimeSheetItemsInfo> list = manufactureTimeSheetItemsController.GetManufactureTimeSheetItemsByIDAndEmployeeID(manufactureTimeSheetsInfo.HRManufactureTimeSheetID,employee.HREmployeeID);
                //            if (list != null && list.Count > 0)
                //            {
                //                foreach (HRManufactureTimeSheetItemsInfo objMTI in list)
                //                {
                //                    HREmployeePieceWorksInfo epw = (HREmployeePieceWorksInfo)objEPW.GetEmployeePieceWorkByProductAndOperation(objMTI.FK_ICProductID,objMTI.FK_MMOperationID);
                //                    amount = amount + epw.HREmployeePieceWorkAmount;
                //                }
                //            }
                //        }
                //    }
                //    employeePayRoll.HREmployeePieceworkSalary = amount;
                //}
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
                    totalWorkingSalary = employeePayRoll.HREmployeeContractSlrAmt;
                    employeePayRoll.HREmployeePayRollReward = 0;
                    employeePayRoll.HREmployeePayRollMaternityAndSickLeaveAmount = 0;
                    employeePayRoll.FK_HREmployeePayRollAllowance = "";
                    HRRewardsController objRewardsController = new HRRewardsController();
                    HREmployeeRewardsController objEmployeeRewardsController = new HREmployeeRewardsController();
                    //DataSet dsReward = objEmployeeRewardsController.GetEmployeeRewardByEmployeeIDAndDate(employee.HREmployeeID, payroll.HRPayRollDate);
                    DataSet dsReward = objRewardsController.GetRewardListByEmployeeIDAndRewardDate(employee.HREmployeeID, payroll.HRPayRollDate);
                    decimal rewardValue = 0;
                    if (dsReward.Tables[0].Rows.Count > 0)
                    {
                        HREmployeeRewardsInfo objEmployeeRewardsInfo = new HREmployeeRewardsInfo();
                        HRRewardsInfo objRewardsInfo = new HRRewardsInfo();
                        List<string> dsRewardID = new List<string>();
                        foreach (DataRow row in dsReward.Tables[0].Rows)
                        {
                            objRewardsInfo = (HRRewardsInfo)objRewardsController.GetObjectFromDataRow(row);
                            objEmployeeRewardsInfo = (HREmployeeRewardsInfo)objEmployeeRewardsController.GetEmployeeRewardsInfoByEmployeeIDAndRewardID(employee.HREmployeeID, objRewardsInfo.HRRewardID);
                            if (objRewardsInfo.HRRewardOption.Equals("AddToSalary"))
                            {
                                dsRewardID.Add(objRewardsInfo.HRRewardID.ToString());
                                if (objRewardsInfo.HRRewardType.Equals(RewardType.Amount.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollReward += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Percent.ToString()))
                                {
                                    bool isValid = decimal.TryParse(objEmployeeRewardsInfo.HREmployeeRewardValue, out rewardValue);
                                    if (isValid)
                                        employeePayRoll.HREmployeePayRollReward += (rewardValue * totalWorkingSalary) / 100;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Nangsuat.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollAllowanceNangSuat += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Omdauthaisan.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollMaternityAndSickLeaveAmount += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                                else if (objRewardsInfo.HRRewardType.Equals(RewardType.Other.ToString()))
                                {
                                    employeePayRoll.HREmployeePayRollReward += objEmployeeRewardsInfo.HREmployeeRewardValueAmount;
                                }
                            }
                        }
                        if (dsRewardID != null && dsRewardID.Count() > 0)
                        {
                            employeePayRoll.FK_HREmployeePayRollAllowance = string.Join(",", dsRewardID.ToArray());
                        }
                        employeePayRoll.HREmployeePayRollReward = employeePayRoll.HREmployeePayRollReward;
                    }
                }
                // Kỷ luật
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Kyluat"))
                {
                    employeePayRoll.HREmployeePayRollDiscipline = 0;
                    employeePayRoll.HREmployeePayrollBHTaiNan = 0;
                    employeePayRoll.HREmployeePayrollPhiTheTu = 0;
                    //employeePayRoll.HREmployeePayrollPhiTheATM = 0;
                    employeePayRoll.HREmployeePayrollPhiAo = 0;
                    employeePayRoll.HREmployeePayrollTruKhac = 0;
                    HREmployeeDisciplinesController objEmployeeDisciplinesController = new HREmployeeDisciplinesController();
                    HRDisciplinesController objDisciplinesController = new HRDisciplinesController();
                    //DataSet dsDiscipline = objEmployeeDisciplinesController.GetEmployeeDisciplinedByEmployeeIDAndDate(employee.HREmployeeID, payroll.HRPayRollDate);
                    DataSet dsDiscipline = objDisciplinesController.GetDisciplineListByEmployeeIDAndDisciplineDate(employee.HREmployeeID, payroll.HRPayRollDate);
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
                                    employeePayRoll.HREmployeePayRollDiscipline += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                //TNDLoc [ADD][26/01/2016][Issue discipline],START
                                #region Trừ phí
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.BHTN.ToString()))
                                {
                                    employeePayRoll.HREmployeePayrollBHTaiNan += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.PhiTheTu.ToString()))
                                {
                                    employeePayRoll.HREmployeePayrollPhiTheTu += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                //else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.PhiTheATM.ToString()))
                                //{
                                //    employeePayRoll.HREmployeePayrollPhiTheATM += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                //}
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.PhiAo.ToString()))
                                {
                                    employeePayRoll.HREmployeePayrollPhiAo += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                else if (objDisciplinesInfo.HRDisciplineType.Equals(DisciplineType.Other.ToString()))
                                {
                                    employeePayRoll.HREmployeePayrollTruKhac += objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount;
                                }
                                #endregion
                                //TNDLoc [ADD][26/01/2016][Issue discipline],END
                            }
                        }
                        employeePayRoll.HREmployeePayRollDiscipline = employeePayRoll.HREmployeePayRollDiscipline;
                    }


                }

                // Phụ cấp
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Phucap"))
                {
                    HRAllowancesController objAllowancesController = new HRAllowancesController();
                    HREmployeeAllowancesController objEmployeeAllowancesController = new HREmployeeAllowancesController();
                    DataSet dsAllowances = objAllowancesController.GetAllowanceListByEmployeeIDAndAllowanceDate(employee.HREmployeeID, payroll.HRPayRollDate);

                    //employeePayRoll.HREmployeePayRollFixedAllowance = employee.HREmployeeAllowanceHouse
                    //                                          + employee.HREmployeeAllowancePhone
                    //                                          + employee.HREmployeeAllowanceGas;

                    employeePayRoll.HREmployeePayRollFixedAllowance = 0;

                    //KhanhHuy-02-06-2020
                    //Thay đổi Lương/ CP hỗ trợ học nghề từ lương cơ bản thành mức lương 
                    //Phân bổ tiền hỗ trợ nhà ở/ xăng xe do chênh lệch từ mức lương và lương cơ bản
                    employeePayRoll.HREmployeePayRollFixedAllowance = (employeePayRoll.HREmployeeContractSlrAmt -
                                                                                employeePayRoll.HREmployeePayRollWorkingSalary)
                                                                              / employeePayRoll.HREmployeeDaysPerMonth
                                                                              * (employeePayRoll.HREmployeePayRollDaysPerMonth
                                                                              + employeePayRoll.HREmployeeRealNightsPerMonth * (decimal)0.3);
                    //End

                    employeePayRoll.HREmployeePayRollExtraSalary = employeePayRoll.HREmployeePayRollFixedAllowance;

                    // Phu cap co dinh
                    if (listAllowanceConfigs != null)
                    {
                        employeePayRoll.HREmployeePayRollPerennialAllowance = 0;
                        employeePayRoll.HREmployeePayRollHeavyToxicAllowance = 0;
                        employeePayRoll.HREmployeePayRollMealAllowance = 0;
                        employeePayRoll.HREmployeePayRollDiligenceAllowance = 0;

                        decimal allowanceAmount = 0;
                        foreach (HRAllowanceConfigsInfo item in listAllowanceConfigs)
                        {
                            allowanceAmount = GetAllowanceAmount(item.HRAllowanceConfigAmount
                                                                        , employeePayRoll.HREmployeeDaysPerMonth
                                                                        , employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth
                                                                        , employeePayRoll.HREmployeePayrollNghiPhepNam + employeePayRoll.HREmployeePayrollCtyChoNghi + employeePayRoll.HREmployeePayrollNghiCheDo
                                                                        , employeePayRoll.HREmployeePayrollNghiLe
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
                                //    employeePayRoll.HREmployeePayRollBonusDiLai += allowanceAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                //}
                                //else if (item.HRAllowanceConfigName == AllowanceType.NuoiCon.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollNuoiConNho += allowanceAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                //}
                                //else if (item.HRAllowanceConfigName == AllowanceType.OmDau.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollMaternityAndSickLeaveAmount += allowanceAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                //}
                                //else if (item.HRAllowanceConfigName == AllowanceType.TruyLanh.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollTruyLanh += allowanceAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                //}
                                //else if (item.HRAllowanceConfigName == AllowanceConfigName.LodgingHouse.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollLodgingHouseAllowance += allowanceAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                //}
                                if (item.HRAllowanceConfigName == AllowanceType.HeavyToxic.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollHeavyToxicAllowance += allowanceAmount;
                                    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                }
                                else if (item.HRAllowanceConfigName == AllowanceConfigName.Meal.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollMealAllowance += allowanceAmount;
                                    //employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                }
                                else if (item.HRAllowanceConfigName == AllowanceConfigName.Diligence.ToString())
                                {
                                    decimal dayWorking = 0;
                                    if (item.HRAllowanceConfigPermiYearAndHoliday)
                                    {
                                        dayWorking = employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth + employeePayRoll.HREmployeePayrollNghiLe;
                                        if (employeePayRoll.HREmployeePayrollNghiPhepNam > 1)
                                        {
                                            dayWorking++;
                                        }
                                        else
                                        {
                                            dayWorking += employeePayRoll.HREmployeePayrollNghiPhepNam;
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
                                            employeePayRoll.HREmployeePayRollDiligenceAllowance += item.HRAllowanceConfigAmount * dayWorking;
                                            employeePayRoll.HREmployeePayRollExtraSalary += item.HRAllowanceConfigAmount * dayWorking;
                                        }
                                        else
                                        {
                                            employeePayRoll.HREmployeePayRollDiligenceAllowance += allowanceAmount;
                                            employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                        }
                                    }
                                }
                                else if (item.HRAllowanceConfigName == AllowanceConfigName.Perennial.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollPerennialAllowance += allowanceAmount;
                                    employeePayRoll.HREmployeePayRollExtraSalary += allowanceAmount;
                                }
                            }
                        }
                    }

                    if (dsAllowances.Tables[0].Rows.Count > 0)
                    {
                        employeePayRoll.HREmployeePayRollBonusDiLai = 0;
                        employeePayRoll.HREmployeePayRollNuoiConNho = 0;
                        //employeePayRoll.HREmployeePayRollMaternityAndSickLeaveAmount = 0;
                        employeePayRoll.HREmployeePayRollTruyLanh = 0;
                        employeePayRoll.HREmployeePayRollOtherAllowance = 0;

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
                                    employeePayRoll.HREmployeePayRollBonusDiLai += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                //else if (objAllowancesInfo.HRAllowanceType == AllowanceType.OmDau.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollMaternityAndSickLeaveAmount += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //}
                                //else if (objAllowancesInfo.HRAllowanceType == AllowanceType.TienCom.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollMealAllowance += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //}
                                //else if (objAllowancesInfo.HRAllowanceType == AllowanceType.HeavyToxic.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollHeavyToxicAllowance += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //}
                                //else if (objAllowancesInfo.HRAllowanceType == AllowanceType.NangSuat.ToString())
                                //{
                                //    employeePayRoll.HREmployeePayRollAllowanceNangSuat += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //    //employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                //}
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.NuoiCon.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollNuoiConNho += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.TruyLanh.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollTruyLanh += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.Other.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollOtherAllowance += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                    employeePayRoll.HREmployeePayRollExtraSalary += objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount;
                                }
                                else if (objAllowancesInfo.HRAllowanceType == AllowanceType.Effective.ToString()
                                    && objAllowancesInfo.HRAllowanceCategory == AllowanceCategory.ForManage.ToString())
                                {
                                    employeePayRoll.HREmployeePayRollProductivity = objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria;
                                    employeePayRoll.HREmployeePayRollQuality = objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria;
                                    employeePayRoll.HREmployeePayRollManagement = objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria;
                                    employeePayRoll.HREmployeePayRollExactly = objEmployeeAllowancesInfo.HREmployeeAllowanceExactlyCriteria;

                                    employeePayRoll.HREmployeePayRollEffectiveAllowance =
                                        (objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredManageAmount
                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredProductivityAmount
                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredQualityAmount
                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceExactlyAmount)
                                        //* (employeePayRoll.HREmployeeRealDaysPerMonth
                                        //+ employeePayRoll.HREmployeeRealNightsPerMonth
                                        //+ employeePayRoll.HREmployeePayrollNghiPhepNam
                                        //+ employeePayRoll.HREmployeePayrollCtyChoNghi
                                        //+ employeePayRoll.HREmployeePayrollNghiLe)
                                        * employeePayRoll.HREmployeePayRollDaysPerMonth
                                        / employeePayRoll.HREmployeeDaysPerMonth;
                                }
                            }
                        }
                    }

                    employeePayRoll.HREmployeePayRollAllowanceNangSuat += employeePayRoll.HREmployeePayRollEffectiveAllowance
                                                                                + employee.HREmployeeExtraSalary1;
                    //if (employeePayRoll.HREmployeeContractSlrAmt - employeePayRoll.HREmployeePayRollWorkingSalary > 0)
                    //{
                    //    employeePayRoll.HREmployeePayRollAllowanceNangSuat +=
                    //        (employeePayRoll.HREmployeeContractSlrAmt - employeePayRoll.HREmployeePayRollWorkingSalary)
                    //        / employeePayRoll.HREmployeeDaysPerMonth *
                    //        //((employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth)
                    //        (employeePayRoll.HREmployeePayRollDaysPerMonth
                    //        +
                    //        employeePayRoll.HREmployeeHoursOT / 8);
                    //    ;
                    //}

                    employeePayRoll.HREmployeePayRollExtraSalary = employeePayRoll.HREmployeePayRollExtraSalary;
                }
                // Bảo hiểm xã hội, bảo hiểm y tế, bảo hiểm thu nhập
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("BHXHBHYTBHTN"))
                {
                    //decimal contractSalary = employeePayRoll.HREmployeePayRollWorkingSalary == 0 ? employeePayRoll.HREmployeePayRollProWorkingSalary : employeePayRoll.HREmployeePayRollWorkingSalary;
                    decimal contractSalary = employeePayRoll.HREmployeePayRollWorkingSalary;
                    employeePayRoll.HREmployeePayRollSocialInsAmount = 0;
                    employeePayRoll.HREmployeePayRollHealthInsAmount = 0;
                    employeePayRoll.HREmployeePayRollOutOfWorkInsAmount = 0;
                    if (employee.HREmployeeHaveInsurrance)
                    {
                        if (employee.HREmployeeStatusCombo == EmployeeStatus.Resigned.ToString())
                        {
                            if (objInsurrancesInfo != null)
                            {
                                DateTime dateApply = GetLastDayOfMonth(new DateTime(payroll.HRPayRollDate.Year, payroll.HRPayRollDate.Month, 1));
                                if (objInsurrancesInfo.HRInsurranceDateApply.Day > dateApply.Day)
                                {
                                    objInsurrancesInfo.HRInsurranceDateApply = dateApply;
                                }
                                else
                                {
                                    objInsurrancesInfo.HRInsurranceDateApply = new DateTime(payroll.HRPayRollDate.Year,
                                                                                            payroll.HRPayRollDate.Month,
                                                                                            objInsurrancesInfo.HRInsurranceDateApply.Day);
                                }
                                if (employee.HREmployeeStopWorkingDate.Date < objInsurrancesInfo.HRInsurranceDateApply.Date)
                                {
                                    employeePayRoll.HREmployeePayRollSocialInsAmount = objInsurrancesInfo.HRInsurranceSocialInsPercentPrevious * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollHealthInsAmount = objInsurrancesInfo.HRInsurranceHealthInsPercentPrevious * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollOutOfWorkInsAmount = objInsurrancesInfo.HRInsurranceOutOfWorkInsPercentPrevious * contractSalary / 100;
                                }
                                else if (employee.HREmployeeStopWorkingDate.Date >= objInsurrancesInfo.HRInsurranceDateApply.Date)
                                {
                                    employeePayRoll.HREmployeePayRollSocialInsAmount = objInsurrancesInfo.HRInsurranceSocialInsPercentNext * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollHealthInsAmount = objInsurrancesInfo.HRInsurranceHealthInsPercentNext * contractSalary / 100;
                                    employeePayRoll.HREmployeePayRollOutOfWorkInsAmount = objInsurrancesInfo.HRInsurranceOutOfWorkInsPercentNext * contractSalary / 100;
                                }
                            }
                            else
                            {
                                employeePayRoll.HREmployeePayRollSocialInsAmount = employee.HREmployeeSocialInsPaymentPercent * contractSalary / 100;
                                employeePayRoll.HREmployeePayRollHealthInsAmount = employee.HREmployeeHealthInsPaymentPercent * contractSalary / 100;
                                employeePayRoll.HREmployeePayRollOutOfWorkInsAmount = employee.HREmployeeOutOfWorkInsPaymentPercent * contractSalary / 100;
                            }
                        }
                        else
                        {
                            employeePayRoll.HREmployeePayRollSocialInsAmount = employee.HREmployeeSocialInsPaymentPercent * contractSalary / 100;
                            employeePayRoll.HREmployeePayRollHealthInsAmount = employee.HREmployeeHealthInsPaymentPercent * contractSalary / 100;
                            employeePayRoll.HREmployeePayRollOutOfWorkInsAmount = employee.HREmployeeOutOfWorkInsPaymentPercent * contractSalary / 100;
                            //employeePayRoll.HREmployeePayRollIncomeTaxAmount = employee.HREmployeeTaxPaymentPercent * contractSalary / 100;
                        }
                    }

                    if (employee.HREmployeeIsUnionMember)
                        employeePayRoll.HREmployeePayRollSyndicateFee = employee.HREmployeeSyndicatePaymentAmount;
                }
                // Tạm ứng tiền xăng dầu
                if (obj.HREmployeePayrollFormulaSalaryType.Equals("Tamung"))
                {
                    employeePayRoll.HREmployeePayRollAdvance = 0;
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
                                employeePayRoll.HREmployeePayRollAdvance += objAdvanceRequestItemsInfo.HRAdvanceRequestItemTotalAmount;
                            }
                        }
                        employeePayRoll.HREmployeePayRollAdvance = employeePayRoll.HREmployeePayRollAdvance;
                    }
                }
            }

            employeePayRoll.HREmployeePayRollSkillCoefficientAmount = 0;
            employeePayRoll.HREmployeePayRollSkillCoefficientAmount += (employeePayRoll.HREmployeeRealDaysPerMonth + employeePayRoll.HREmployeeRealNightsPerMonth) * 8;

            if (employeePayRoll.HREmployeePayrollDetailsList != null && employeePayRoll.HREmployeePayrollDetailsList.Count > 0)
            {
                employeePayRoll.HREmployeePayrollDetailsList.ForEach(o =>
                {
                    employeePayRoll.HREmployeePayRollSkillCoefficientAmount += o.HREmployeeTimeSheetOTDetailFactor * o.HREmployeePayrollHours;
                });
            }

            employeePayRoll.HREmployeePayRollSkillCoefficientAmount = employeePayRoll.HREmployeePayRollSkillCoefficientAmount * employeePayRoll.HREmployeePayRollSkillCoefficient;

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
        public void CalculatePayRollTotalAmounts(HREmployeePayRollsInfo objEmployeePayRollsInfo, List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            if (objEmployeePayRollsInfo != null)
            {
                //TNDLoc [ADD][Issue allowance],START
                HRAllowanceManageConfigsController allowanceConfigController = new HRAllowanceManageConfigsController();
                HRAllowanceManageConfigsInfo allowanceConfigInfo = new HRAllowanceManageConfigsInfo();
                //TNDLoc [ADD][Issue allowance],END
                HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;
                HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)entity.MainObject;
                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo employee = employeeController.GetObjectByID(objEmployeePayRollsInfo.FK_HREmployeeID) as HREmployeesInfo;
                HREmployeePayrollFormulasController employeePayrollFormulaController = new HREmployeePayrollFormulasController();
                HREmployeePayrollFormulasInfo employeePayrollFormula = null;
                if (employee != null)
                {
                    employeePayrollFormula = employeePayrollFormulaController.GetObjectByID(employee.FK_HREmployeePayrollFormulaID) as HREmployeePayrollFormulasInfo;
                    objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary = employee.HREmployeeProbationarySalaryAmount;
                }

                //TNDLoc [ADD][Issue allowance],START
                allowanceConfigInfo = (HRAllowanceManageConfigsInfo)allowanceConfigController.GetObjectByID(employee.FK_HRAllowanceManageConfigID);
                //TNDLoc [ADD][Issue allowance],END

                // Lương thu nhập = Lương thực tế theo công + Lương khoán + Lương tăng ca
                //if (objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary > 0)
                //{
                //    if (objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary < objEmployeePayRollsInfo.HREmployeeContractSlrAmt)
                //    {
                //        objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary = objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary /
                //                                                                        objEmployeePayRollsInfo.HREmployeeDaysPerMonth *
                //                                                                        (objEmployeePayRollsInfo.HREmployeeRealDaysPerMonth +
                //                                                                        objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth * (decimal)1.3 +
                //                                                                        objEmployeePayRollsInfo.HREmployeePayrollNghiLe +
                //                                                                        objEmployeePayRollsInfo.HREmployeePayrollNghiPhepNam +
                //                                                                        objEmployeePayRollsInfo.HREmployeePayrollCtyChoNghi + 
                //                                                                        objEmployeePayRollsInfo.HREmployeePayrollNghiCheDo
                //                                                                        );
                //    }
                //    else
                //    {
                //        objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary = objEmployeePayRollsInfo.HREmployeeContractSlrAmt /
                //                                                                    objEmployeePayRollsInfo.HREmployeeDaysPerMonth *
                //                                                                    (objEmployeePayRollsInfo.HREmployeeRealDaysPerMonth +
                //                                                                    objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth * (decimal)1.3 +
                //                                                                    objEmployeePayRollsInfo.HREmployeePayrollNghiLe +
                //                                                                    objEmployeePayRollsInfo.HREmployeePayrollNghiPhepNam +
                //                                                                    objEmployeePayRollsInfo.HREmployeePayrollCtyChoNghi +
                //                                                                    objEmployeePayRollsInfo.HREmployeePayrollNghiCheDo
                //                                                                    );
                //    }
                //}
                //else
                //{
                //    if (objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary > 0)
                //    {
                //        if (objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary > objEmployeePayRollsInfo.HREmployeeContractSlrAmt)
                //        {
                //            objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary = objEmployeePayRollsInfo.HREmployeeContractSlrAmt /
                //                                                                            objEmployeePayRollsInfo.HREmployeeDaysPerMonth *
                //                                                                            (objEmployeePayRollsInfo.HREmployeeRealDaysPerMonth +
                //                                                                            objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth * (decimal)1.3 +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiLe +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiPhepNam +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollCtyChoNghi +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiCheDo
                //                                                                            );
                //        }
                //        else
                //        {
                //            objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary = objEmployeePayRollsInfo.HREmployeePayRollProWorkingSalary /
                //                                                                            objEmployeePayRollsInfo.HREmployeeDaysPerMonth *
                //                                                                            (objEmployeePayRollsInfo.HREmployeeRealDaysPerMonth +
                //                                                                            objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth * (decimal)1.3 +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiLe +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiPhepNam +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollCtyChoNghi +
                //                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiCheDo
                //                                                                            );
                //        }
                //    }
                //}

                //KhanhHuy-02-06-2020
                //Đổi lương cơ bản thành mức lương
                objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary = //objEmployeePayRollsInfo.HREmployeeContractSlrAmt
                                                                                objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary
                                                                              / objEmployeePayRollsInfo.HREmployeeDaysPerMonth
                                                                              * (objEmployeePayRollsInfo.HREmployeePayRollDaysPerMonth
                                                                              + objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth * (decimal)0.3);

                objEmployeePayRollsInfo.HREmployeePayRollBonusSaleAmount = objEmployeePayRollsInfo.HREmployeePayRollBonusSale /
                                                                            objEmployeePayRollsInfo.HREmployeeDaysPerMonth *
                                                                            (objEmployeePayRollsInfo.HREmployeeRealDaysPerMonth +
                                                                            objEmployeePayRollsInfo.HREmployeeRealNightsPerMonth +
                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiLe +
                                                                            objEmployeePayRollsInfo.HREmployeePayrollNghiPhepNam +
                                                                            objEmployeePayRollsInfo.HREmployeePayrollCtyChoNghi
                                                                            );

                // Phạt / Trừ = Tạm ứng (xăng dầu) + Kỷ luật
                objEmployeePayRollsInfo.HREmployeePayRollTotalDeductedAmt = objEmployeePayRollsInfo.HREmployeePayRollAdvance +
                    objEmployeePayRollsInfo.HREmployeePayRollDiscipline;
                // Các khoản bảo hiểm
                objEmployeePayRollsInfo.HREmployeePayRollTotalInsAmt =
                    objEmployeePayRollsInfo.HREmployeePayRollSocialInsAmount
                    + objEmployeePayRollsInfo.HREmployeePayRollHealthInsAmount
                    //+ objEmployeePayRollsInfo.HREmployeePayRollIncomeTaxAmount
                    + objEmployeePayRollsInfo.HREmployeePayRollOutOfWorkInsAmount;
                //+ objEmployeePayRollsInfo.HREmployeePayRollSyndicateFee;
                // Lương đã trừ = Lương thu nhập + Phụ cấp + Khen thưởng - Bù lương - (Phạt / Trừ) - BHXH

                if (employeePayrollFormula != null)
                {
                    objEmployeePayRollsInfo.HREmployeePayrollTongThuNhap =
                        objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary
                        + objEmployeePayRollsInfo.HREmployeePayRollOTSalary
                        + objEmployeePayRollsInfo.HREmployeePayRollThuongKPI
                        + objEmployeePayRollsInfo.HREmployeePayRollReward
                        //+ objEmployeePayRollsInfo.HREmployeePayRollBonusSaleAmount
                        + objEmployeePayRollsInfo.HREmployeePayRollExtraSalary
                        + objEmployeePayRollsInfo.HREmployeePayRollAllowanceNangSuat;

                    objEmployeePayRollsInfo.HREmployeePayrollTruKhac += objEmployeePayRollsInfo.HREmployeePayRollPermissionOTDaysOff;

                    objEmployeePayRollsInfo.HREmployeePayrollTongCacKhoanTru =
                     objEmployeePayRollsInfo.HREmployeeOffsetSalary
                     + objEmployeePayRollsInfo.HREmployeePayRollTotalDeductedAmt
                     + objEmployeePayRollsInfo.HREmployeePayRollTotalInsAmt
                     + objEmployeePayRollsInfo.HREmployeePayRollSyndicateFee
                     + objEmployeePayRollsInfo.HREmployeePayrollPhiAo
                     + objEmployeePayRollsInfo.HREmployeePayrollPhiTheATM
                     + objEmployeePayRollsInfo.HREmployeePayrollPhiTheTu
                     + objEmployeePayRollsInfo.HREmployeePayrollBHTaiNan
                     + objEmployeePayRollsInfo.HREmployeePayrollTruKhac;

                    if (objEmployeePayRollsInfo.HREmployeePayrollDetailsList != null && objEmployeePayRollsInfo.HREmployeePayrollDetailsList.Count > 0)
                    {
                        objEmployeePayRollsInfo.HREmployeePayRollThuNhapChiuThue =
                            objEmployeePayRollsInfo.HREmployeeWorkingSlrAmtFull
                            / objEmployeePayRollsInfo.HREmployeeDaysPerMonth / 8
                            * (decimal)objEmployeePayRollsInfo.HREmployeePayrollDetailsList.Sum(o => o.HREmployeePayrollHours)
                            + objEmployeePayRollsInfo.HREmployeePayrollTongThuNhap
                            - objEmployeePayRollsInfo.HREmployeePayRollOTSalary
                            - objEmployeePayRollsInfo.HREmployeePayRollTotalInsAmt;
                    }

                    HREmployeeContactPersonsController objEmployeeContactPersonsController = new HREmployeeContactPersonsController();
                    List<HREmployeeContactPersonsInfo> list =
                        (List<HREmployeeContactPersonsInfo>)objEmployeeContactPersonsController.GetListFromDataSet(objEmployeeContactPersonsController.GetAllDataByForeignColumn("FK_HREmployeeID", employee.HREmployeeID));

                    if (list != null && list.Count > 0)
                    {
                        list = list.Where(o => o.HREmployeeContactPersonDependency == true).ToList();
                        if (list.Count > 0)
                        {
                            objEmployeePayRollsInfo.HREmployeePayRollSoNguoiPhuThuoc = (int)list.Count();
                        }
                    }
                    ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
                    ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();

                    objEmployeePayRollsInfo.HREmployeePayrollTruThueTNCN = objEmployeePayRollsInfo.HREmployeePayRollThuNhapChiuThue;

                    if (objInsurrancesInfo != null)
                    {
                        objEmployeePayRollsInfo.HREmployeePayrollTruThueTNCN -=
                            objInsurrancesInfo.ADInsurranceLevelNotTaxable
                            + objInsurrancesInfo.ADInsurranceDependencyLevel
                            * objEmployeePayRollsInfo.HREmployeePayRollSoNguoiPhuThuoc;

                        if (objEmployeePayRollsInfo.HREmployeePayrollTruThueTNCN < 0)
                        {
                            objEmployeePayRollsInfo.HREmployeePayrollTruThueTNCN = 0;
                        }
                    }

                    objEmployeePayRollsInfo.HREmployeePayRollIncomeTaxAmount = CalculationAmountThueTTCN(objEmployeePayRollsInfo.HREmployeePayrollTruThueTNCN);
                }

                // Tổng lương thực nhận = Lương đã trừ + Doanh số + Nợ lũy tiến + Ốm đau thai sản
                //objEmployeePayRollsInfo.HREmployeePayRollTotalSalary 
                //    = Convert.ToDecimal(BOSUtil.RoundToThousand(Convert.ToDouble(objEmployeePayRollsInfo.HREmployeeLuongDaTru 
                //                            + objEmployeePayRollsInfo.HREmployeePayRollCommission 
                //                            + objEmployeePayRollsInfo.HREmployeeNoLuyTien
                //                            + objEmployeePayRollsInfo.HREmployeePayRollMaternityAndSickLeaveAmount)));

                //objEmployeePayRollsInfo.HREmployeePayRollTotalSalary
                //    = Convert.ToDecimal(BOSUtil.RoundToThousand(Convert.ToDouble(objEmployeePayRollsInfo.HREmployeePayrollTongThuNhap
                //                                                - objEmployeePayRollsInfo.HREmployeePayrollTongCacKhoanTru)));

                objEmployeePayRollsInfo.HREmployeePayRollTotalSalary
                    = objEmployeePayRollsInfo.HREmployeePayrollTongThuNhap
                    - objEmployeePayRollsInfo.HREmployeePayrollTongCacKhoanTru
                    + objEmployeePayRollsInfo.HREmployeePayRollMaternityAndSickLeaveAmount;

                CurrentModuleEntity.UpdateModuleObjectBindingSource(TableName.HREmployeePayRollsTableName);
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
        public void UpdateEmployeePayrollDetailsList(HREmployeePayRollsInfo employeePayRoll,
                                                    List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemList,
                                                    HREmployeeTimeSheetsInfo employeeTimeSheet,
                                                    HRPayRollsInfo objPayRollsInfo,
                                                    List<HRAllowanceConfigsInfo> listAllowanceConfigs)
        {
            HRPayRollEntities entity = (HRPayRollEntities)CurrentModuleEntity;

            List<HRTimeSheetEntrysInfo> employeeTimeSheetEntryList = new List<HRTimeSheetEntrysInfo>();

            HREmployeeContractsController objEmployeeContractsController = new HREmployeeContractsController();
            HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
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

                objEmployeesInfo.HREmployeeDaysPerMonth = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objPayRollsInfo.HRPayRollDate.Month);
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
                //    employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(objTimeSheetsInfo.HRTimeSheetID, employeeTimeSheet.HREmployeeTimeSheetID);
                //    employeeTimeSheetEntryList1 = employeeTimeSheetEntryList.Where(x => x.HRTimeSheetEntryDate < objEmployeeTranfersInfo.HREmployeeTranferDateFrom).ToList();
                //    decimal totalSalaryFactor = 0;
                //    decimal totalSalaryOTHours = 0;
                //    foreach (HRTimeSheetEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList1)
                //    {
                //        if (objTimeSheetEntrysInfo.IsOT == false)
                //        {
                //            totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingQty;
                //        }
                //        else
                //        {
                //            totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingHours;
                //        }
                //    }
                //    // Công thực tế
                //    employeePayRoll.HREmployeeRealDaysPerMonth = totalSalaryFactor;
                //    // Giờ tăng ca
                //    employeePayRoll.HREmployeeHoursOT = totalSalaryOTHours;
                //    SetDefaultValuesFromEmployee(employeePayRoll, objEmployeesInfo);
                //    // Lương chưa trừ
                //    //employeePayRoll.HREmployeeContractSlrAmt = employeePayRoll.HREmployeePayRollWorkingSalary * employeePayRoll.HREmployeeRealDaysPerMonth / employeePayRoll.HREmployeeDaysPerMonth;
                //    // Lương tăng ca
                //    employeePayRoll.HREmployeePayRollOTSalary = (employeePayRoll.HREmployeeContractSlrAmt / employeePayRoll.HREmployeeDaysPerMonth / 8) * employeePayRoll.HREmployeeHoursOT;
                //    // Lương khoán

                //    employeePayRoll.HREmployeePieceworkSalary = 0;
                //    if (EmployeePieceWageItemList != null)
                //    {
                //        List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                //            EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                //        if (EmployeePieceWageItemTotal != null)
                //            employeePayRoll.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);

                //    }
                //    // Bù lương
                //    employeePayRoll.HREmployeeOffsetSalary = 0;
                //    CalculatePayRollTotalAmounts(employeePayRoll, listAllowanceConfigEmployee);
                //    // end phase 1
                //    // phase 2
                //    objEmployeesInfo2 = new HREmployeesInfo();
                //    BOSUtil.CopyObject(employeePayRoll, employeePayRoll2);
                //    BOSUtil.CopyObject(objEmployeesInfo, objEmployeesInfo2);

                //    employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(objTimeSheetsInfo.HRTimeSheetID, employeeTimeSheet.HREmployeeTimeSheetID);
                //    employeeTimeSheetEntryList2 = employeeTimeSheetEntryList.Where(x => x.HRTimeSheetEntryDate >= objEmployeeTranfersInfo.HREmployeeTranferDateFrom).ToList();
                //    totalSalaryFactor = 0;
                //    totalSalaryOTHours = 0;
                //    foreach (HRTimeSheetEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList2)
                //    {
                //        if (objTimeSheetEntrysInfo.IsOT == false)
                //        {
                //            totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingQty;
                //        }
                //        else
                //        {
                //            totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingHours;
                //        }
                //    }
                //    // Công thực tế
                //    employeePayRoll2.HREmployeeRealDaysPerMonth = totalSalaryFactor;
                //    // Giờ tăng ca
                //    employeePayRoll2.HREmployeeHoursOT = totalSalaryOTHours;
                //    SetDefaultValuesFromEmployeeTransfer(employeePayRoll2, objEmployeeTranfersInfo, listAllowanceConfigEmployee);
                //    // Lương chưa trừ
                //    //employeePayRoll2.HREmployeeContractSlrAmt = employeePayRoll2.HREmployeePayRollWorkingSalary * employeePayRoll2.HREmployeeRealDaysPerMonth / employeePayRoll2.HREmployeeDaysPerMonth;
                //    // Lương tăng ca
                //    employeePayRoll2.HREmployeePayRollOTSalary = (employeePayRoll2.HREmployeeContractSlrAmt / employeePayRoll2.HREmployeeDaysPerMonth / 8) * employeePayRoll2.HREmployeeHoursOT;
                //    // Lương khoán
                //    employeePayRoll2.HREmployeePieceworkSalary = 0;
                //    if (EmployeePieceWageItemList != null)
                //    {
                //        List<HREmployeePieceWageItemsInfo> EmployeePieceWageItemTotal =
                //            EmployeePieceWageItemList.Where(x => x.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                //        if (EmployeePieceWageItemTotal != null)
                //            employeePayRoll2.HREmployeePieceworkSalary = EmployeePieceWageItemTotal.Sum(x => x.HREmployeePieceWageItemAmount);

                //    }
                //    // Bù lương
                //    employeePayRoll2.HREmployeeOffsetSalary = 0;
                //    CalculatePayRoll(employeePayRoll2, objEmployeesInfo, listAllowanceConfigEmployee);
                //    //CalculatePayRollTotalAmounts(employeePayRoll2, listAllowanceConfigEmployee);
                //    // end phase 2
                //}
                //else
                {
                    employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(objPayRollsInfo.FK_HRTimeSheetID, employeeTimeSheet.HREmployeeTimeSheetID);

                    decimal totalSalaryFactorNight = 0;
                    decimal totalSalaryFactor = 0;
                    decimal totalSalaryOTHours = 0;
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
                    foreach (HRTimeSheetEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList)
                    {
                        if (objTimeSheetEntrysInfo.IsNightWorking)
                        {
                            totalSalaryFactorNight += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingQty;
                        }
                        else if (objTimeSheetEntrysInfo.HRTimeSheetParamType == TimeSheetParamType.Day.ToString()
                            || objTimeSheetEntrysInfo.HRTimeSheetParamType == TimeSheetParamType.Hour.ToString())
                        {
                            if (objTimeSheetEntrysInfo.IsOT == false)
                            {
                                totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingQty;
                            }
                            else
                            {
                                totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingHours;
                            }
                        }
                        //HRTimeSheetParamsInfo objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(objTimeSheetEntrysInfo.FK_HRTimeSheetParamID);
                        //if (objTimeSheetParamsInfo != null &&
                        //    (objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.PN.ToString()
                        //    || objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.PN1P2.ToString()))
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

                    employeePayRoll.HREmployeePayRollPermissionOTDaysOff = employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff * SubtractOT;

                    //Số ngày phép năm hưởng lương
                    HREmployeeRewardsController objEmployeeRewardsController = new HREmployeeRewardsController();
                    List<HREmployeeRewardsInfo> list = objEmployeeRewardsController.GetEmployeeRewardByEmployeeIDAndDate(objEmployeesInfo.HREmployeeID, objPayRollsInfo.HRPayRollDate, RewardType.PNTL.ToString());
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
                    SetDefaultValuesFromEmployee(employeePayRoll, objEmployeesInfo);
                    HREmployeeTimeSheetOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetOTDetailsController();
                    employeeTimeSheet.HREmployeeTimeSheetOTDetailsList = objEmployeeTimeSheetOTDetailsController.GetListTimeSheetOTDetailByEmployeeTimeSheet(employeeTimeSheet.HREmployeeTimeSheetID);
                    List<HREmployeePayrollDetailsInfo> employeePayrollDetails = new List<HREmployeePayrollDetailsInfo>();
                    //List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
                    List<HROTFactorsInfo> OTFactorlist = (List<HROTFactorsInfo>)objOTFactorsController.GetAllDistinctFactors();
                    foreach (var otfactor in OTFactorlist)
                    {
                        HREmployeePayrollDetailsInfo objEmployeePayrollDetailsInfo = new HREmployeePayrollDetailsInfo();
                        objEmployeePayrollDetailsInfo.HREmployeeTimeSheetOTDetailFactor = otfactor.HROTFactorValue;
                        objEmployeePayrollDetailsInfo.HREmployeeTimeSheetOTDetailName = otfactor.HROTFactorType + otfactor.HROTFactorValue.ToString();
                        if (otfactor.HROTFactorType == OTFactorType.WorkingDay.ToString())
                        {
                            //foreach (var item in employeeTimeSheet.HREmployeeTimeSheetOTDetailsList)
                            foreach (var item in employeeTimeSheetEntryList)
                            {
                                if (item.IsOT)
                                {
                                    if (!BOSApp.IsEndOfWeek(item.HRTimeSheetEntryDate.DayOfWeek) && !BOSApp.IsHoliday(item.HRTimeSheetEntryDate.Date))
                                    {
                                        if (otfactor.HROTFactorValue == item.HRTimeSheetEntryFactor)
                                        {
                                            objEmployeePayrollDetailsInfo.HREmployeePayrollHours += item.HRTimeSheetEntryWorkingHours / item.HRTimeSheetEntryFactor;
                                        }
                                    }
                                }
                            }
                            objEmployeePayrollDetailsInfo.HREmployeePayrollBasicSalary = employeePayRoll.HREmployeeContractSlrAmt;
                        }
                        else if (otfactor.HROTFactorType == OTFactorType.EndOfWeek.ToString())
                        {
                            //foreach (var item in employeeTimeSheet.HREmployeeTimeSheetOTDetailsList)
                            //{
                            //    if (BOSApp.IsEndOfWeek(item.HREmployeeTimeSheetOTDetailEntryDate.DayOfWeek))
                            //    {
                            //        if (otfactor.HROTFactorValue == item.HREmployeeTimeSheetOTDetailFactor)
                            //        {
                            //            objEmployeePayrollDetailsInfo.HREmployeePayrollHours += item.HREmployeeTimeSheetOTDetailHours;
                            //        }
                            //    }
                            //}
                            foreach (var item in employeeTimeSheetEntryList)
                            {
                                if (item.IsOT)
                                {
                                    if (BOSApp.IsEndOfWeek(item.HRTimeSheetEntryDate.DayOfWeek))
                                    {
                                        if (otfactor.HROTFactorValue == item.HRTimeSheetEntryFactor)
                                        {
                                            objEmployeePayrollDetailsInfo.HREmployeePayrollHours += item.HRTimeSheetEntryWorkingHours / item.HRTimeSheetEntryFactor;
                                        }
                                    }
                                }
                            }
                            objEmployeePayrollDetailsInfo.HREmployeePayrollBasicSalary = employeePayRoll.HREmployeeContractSlrAmt;
                        }
                        else if (otfactor.HROTFactorType == OTFactorType.Holiday.ToString())
                        {
                            foreach (var item in employeeTimeSheetEntryList)
                            {
                                if (item.IsOT)
                                {
                                    if (BOSApp.IsHoliday(item.HRTimeSheetEntryDate.Date))
                                    {
                                        if (otfactor.HROTFactorValue == item.HRTimeSheetEntryFactor)
                                        {
                                            objEmployeePayrollDetailsInfo.HREmployeePayrollHours += item.HRTimeSheetEntryWorkingHours / item.HRTimeSheetEntryFactor;
                                        }
                                    }
                                }
                            }
                            objEmployeePayrollDetailsInfo.HREmployeePayrollBasicSalary = employeePayRoll.HREmployeeContractSlrAmt;
                        }

                        objEmployeePayrollDetailsInfo.HREmployeePayrollSalaryFactor =
                                (objEmployeePayrollDetailsInfo.HREmployeePayrollBasicSalary / employeePayRoll.HREmployeeDaysPerMonth / 8) * (objEmployeePayrollDetailsInfo.HREmployeePayrollHours * objEmployeePayrollDetailsInfo.HREmployeeTimeSheetOTDetailFactor);
                        employeePayrollDetails.Add(objEmployeePayrollDetailsInfo);
                    }
                    employeePayRoll.HREmployeePayrollDetailsList = employeePayrollDetails;
                    //employeePayRoll.HREmployeePayrollNghiPhepNam = nghiPN;

                    //22-05-2020
                    //employeePayRoll.HREmployeePayrollNghiPhepNam = employeeTimeSheet.HREmployeeTimeSheetNghiPhepNam + phepnamTL;
                    //employeePayRoll.HREmployeePayrollCtyChoNghi = cTyChoNghi;
                    //employeePayRoll.HREmployeePayrollNghiLe = nghiLe;
                    //employeePayRoll.HREmployeePayrollNghiCheDo = nghiCheDo;
                    //employeePayRoll.HREmployeePayrollNghiCupDien = nghiCupDien;
                    //employeePayRoll.HREmployeePayrollNghiPhep = nghiPhep;
                    //employeePayRoll.HREmployeePayrollCtyChoNghi = ctyChoNghi;

                    employeePayRoll.HREmployeePayrollNghiPhepNam = employeeTimeSheet.HREmployeeTimeSheetNghiPhepNam + phepnamTL;
                    employeePayRoll.HREmployeePayrollCtyChoNghi = employeeTimeSheet.HREmployeeTimeSheetCongTyChoNghi;
                    employeePayRoll.HREmployeePayrollNghiLe = employeeTimeSheet.HREmployeeTimeSheetNghiLe;
                    employeePayRoll.HREmployeePayrollNghiCheDo = employeeTimeSheet.HREmployeeTimeSheetNghiCheDo;
                    employeePayRoll.HREmployeePayrollNghiPhep = employeeTimeSheet.HREmployeeTimeSheetNghiCoPhep;
                    //End 22-05-2020

                    //employeePayRoll.HREmployeePayrollNghiKPhep = nghiKPhep;
                    employeePayRoll.HREmployeePayrollNghiKPhep = employeeTimeSheet.HREmployeeTimeSheetNghiKhongPhep;
                    // Lương chưa trừ
                    //employeePayRoll.HREmployeeContractSlrAmt = employeePayRoll.HREmployeeContractSlrAmt * employeePayRoll.HREmployeeRealDaysPerMonth / employeePayRoll.HREmployeeDaysPerMonth;
                    // Lương tăng ca
                    employeePayRoll.HREmployeePayRollOTSalary = (employeePayRoll.HREmployeeContractSlrAmt
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

                    //employeePayRoll.HREmployeePayRollDaysPerMonth = totalSalaryFactorNight + totalSalaryFactor + nghiLe + ctyChoNghi + nghiPN + nghiCheDo;
                    employeePayRoll.HREmployeePayRollDaysPerMonth = employeePayRoll.HREmployeeRealNightsPerMonth
                                                                    + employeePayRoll.HREmployeeRealDaysPerMonth
                                                                    + employeePayRoll.HREmployeePayrollNghiLe
                                                                    + employeePayRoll.HREmployeePayrollCtyChoNghi
                                                                    + employeePayRoll.HREmployeePayrollNghiCheDo
                                                                    + employeePayRoll.HREmployeePayrollNghiPhepNam;

                    // Bù lương
                    employeePayRoll.HREmployeeOffsetSalary = 0;
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
                employeePayRoll.HREmployeePayRollWorkingSalary = 0;

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
