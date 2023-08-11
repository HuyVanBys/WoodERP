using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraReports.UI;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTimeSheet
{
    public class HRTimeSheetModule : BaseTransactionModule
    {
        #region Constants
        /// <summary>
        /// The employee time sheet gird control name
        /// </summary>
        public const string HREmployeeTimeSheetsGridControlName = "fld_dgcHREmployeeTimeSheets";
        private decimal HoursPerDay = 0;
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public bool isCustomDrawCell = false;
        #endregion

        #region Variable
        /// <summary>
        /// Define application in excel
        /// </summary>
        private Microsoft.Office.Interop.Excel.Application App;
        /// <summary>
        /// Define work book in excel
        /// </summary>
        private Workbook WorkBook;
        /// <summary>
        /// Define work sheet in excel
        /// </summary>
        private Worksheet WorkSheet;
        #endregion

        #region Public Properties
        List<HREmployeesInfo> EmployeesList;
        List<HRTimesheetEmployeeLatesInfo> TimesheetEmployeeLateList;
        #endregion

        public HRTimeSheetModule()
        {
            Name = "HRTimeSheet";
            CurrentModuleEntity = new HRTimeSheetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            HoursPerDay = GetHourPerDay();
            EmployeesList = new List<HREmployeesInfo>();
            TimesheetEmployeeLateList = new List<HRTimesheetEmployeeLatesInfo>();

        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            HRTimeSheetsInfo searchObject = (HRTimeSheetsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();

            ds = objTimeSheetsController.GetTimeSheetList(searchObject.HRTimeSheetNo,
                                                            searchObject.HRTimeSheetName,
                                                            searchObject.HRTimeSheetType,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.HRTimeSheetDateFrom,
                                                            searchObject.HRTimeSheetDateTo);
            return ds;
        }

        public override void InvalidateToolbar()
        {
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;
            if (timeSheet.HRTimeSheetID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                if (timeSheet.HRTimeSheetStatus == TimeSheetStatus.SalaryCalculated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRTimesheetEmployeeLatesController objTimesheetEmployeeLatesController = new HRTimesheetEmployeeLatesController();
            HoursPerDay = GetHourPerDay();
            EmployeesList = objEmployeesController.GetAllEmployees();
            List<HRDepartmentsInfo> DepartmentList = objDepartmentsController.GetAllList();
            List<HRDepartmentRoomsInfo> DepartmentRoomList = objDepartmentRoomsController.GetAllRooms();
            TimesheetEmployeeLateList = objTimesheetEmployeeLatesController.GetAllTimeSheetEmployeeLates();
            foreach (var objEmployeeTimeSheetsInfo in entity.EmployeeTimeSheetList)
            {
                HREmployeesInfo objEmployeesInfo = EmployeesList.Where(x => x.HREmployeeID == objEmployeeTimeSheetsInfo.FK_HREmployeeID).FirstOrDefault();
                if (DepartmentRoomList != null)
                {
                    HRDepartmentsInfo objDepartmentsInfo = DepartmentList.Where(d => d.HRDepartmentID == objEmployeesInfo.FK_HRDepartmentID).FirstOrDefault();
                    if (objDepartmentsInfo != null)
                    {
                        objEmployeeTimeSheetsInfo.HRDepartmentName = objDepartmentsInfo.HRDepartmentName;
                    }
                }
                //if (DepartmentRoomList != null)
                //{
                //    HRDepartmentRoomsInfo objDepartmentRoomsInfo = DepartmentRoomList.Where(r => r.HRDepartmentRoomID == objEmployeesInfo.FK_HRDepartmentRoomID).FirstOrDefault();
                //    if (objDepartmentRoomsInfo != null)
                //    {
                //        objEmployeeTimeSheetsInfo.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                //    }
                //}
                objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingHour = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * HoursPerDay;
            }
            InitializeTimeSheetEntryGridControl();
            isCustomDrawCell = false;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)entity.MainObject;
            timeSheet.HRTimeSheetType = TimeSheetType.Day.ToString();
            InitializeTimeSheetEntryGridControl();
            isCustomDrawCell = false;
        }

        public override int ActionSave()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)entity.MainObject;
            entity.EmployeeTimeSheetList.EndCurrentEdit();
            bool isNew = false;
            if (timeSheet.HRTimeSheetID == 0)
                isNew = true;
            string mess = "Đang cập nhật dữ liệu";
            BOSProgressBar.Start(mess);
            UpdateTimeSheetTotalQty();
            BOSProgressBar.Close();

            int objectID = base.ActionSave();
            if (objectID > 0 && !isNew)
            {
                //Create entry for time sheet
                HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
                HREmployeeTimeSheetOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetOTDetailsController();
                List<HRTimeSheetParamsInfo> timeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList();
                int percent = 0;
                mess = "Đang lưu dữ liệu: ";
                objTimeSheetEntrysController.DeleteByForeignColumn("FK_HRTimeSheetID", timeSheet.HRTimeSheetID);
                List<string> EmployeeTimeSheetID = entity.EmployeeTimeSheetList.Select(x => x.HREmployeeTimeSheetID.ToString()).Distinct().ToList();
                string strListID = string.Join(",", EmployeeTimeSheetID.ToArray());
                if (strListID != null)
                    objEmployeeTimeSheetOTDetailsController.DeleteByEmployeeTimeSheetList(strListID);
                foreach (HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo in entity.EmployeeTimeSheetList)
                {
                    percent++;
                    double pct = (percent * 100) / entity.EmployeeTimeSheetList.Count;
                    BOSProgressBar.Start(mess + ": " + Math.Round(pct) + " % ");
                    foreach (HRTimeSheetEntrysInfo entry in objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList)
                    {
                        if (entry.FK_HRTimeSheetParamID == 0) continue;
                        entry.FK_HRTimeSheetID = timeSheet.HRTimeSheetID;
                        entry.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                        if (entry.HRTimeSheetEntryFactor == 0 && entry.FK_HRTimeSheetParamID > 0 && timeSheetParamsList != null)
                        {
                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = timeSheetParamsList.Where(x => x.HRTimeSheetParamID == entry.FK_HRTimeSheetParamID).FirstOrDefault();
                            if (objTimeSheetParamsInfo != null)
                                entry.HRTimeSheetEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                        }
                        objTimeSheetEntrysController.CreateObject(entry);
                    }
                    if (objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList != null)
                    {
                        foreach (HREmployeeTimeSheetOTDetailsInfo obj in objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList)
                        {
                            obj.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                            objEmployeeTimeSheetOTDetailsController.CreateObject(obj);
                        }
                    }
                }
                isNew = false;
                BOSProgressBar.Close();
            }
            return objectID;
        }

        /// <summary>
        /// Called when the user sets time sheet params for an employee
        /// </summary>
        public void ActionSetTimeSheetParam()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)entity.MainObject;
                guiSetTimeSheetParam guiSetTimeSheetParam = new guiSetTimeSheetParam();
                guiSetTimeSheetParam.Fromdate = timeSheet.HRTimeSheetFromDate;
                guiSetTimeSheetParam.Todate = timeSheet.HRTimeSheetToDate;
                guiSetTimeSheetParam.Module = this;
                guiSetTimeSheetParam.Show();
            }
        }

        /// <summary>
        /// Set a time sheet param to the current time sheet of an employee
        /// </summary>
        /// <param name="employeeID">Employee id</param>
        /// <param name="paramID">Time sheet param id</param>
        /// <param name="fromDate">Date the time sheet will be set from</param>
        /// <param name="toDate">Date the time sheet will be set to</param>
        public void SetTimeSheetParam(int employeeID, int paramID, DateTime fromDate, DateTime toDate, bool autoCheck)
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            BOSDbUtil dbUtil = new BOSDbUtil();
            HREmployeeTimeSheetsInfo employeeTimeSheet = entity.EmployeeTimeSheetList.Where(et => et.FK_HREmployeeID == employeeID).FirstOrDefault();
            int daysInMonth = NumOfDayInMonth();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRTimesheetEmployeeLatesController objTimesheetEmployeeLatesController = new HRTimesheetEmployeeLatesController();
            EmployeesList = objEmployeesController.GetAllEmployees();
            TimesheetEmployeeLateList = objTimesheetEmployeeLatesController.GetAllTimeSheetEmployeeLates();
            if (employeeTimeSheet != null || employeeID == 0)
            {

                if (paramID != 0)
                {
                    if (employeeID > 0)
                    {
                        HRTimeSheetParamsInfo param = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamID == paramID).FirstOrDefault();
                        if (param != null)
                        {
                            for (int i = 1; i <= daysInMonth; i++)
                            {
                                dbUtil.SetPropertyValue(employeeTimeSheet, string.Format("HREmployeeTimeSheetDate{0}", i), param.HRTimeSheetParamNo);
                            }
                        }
                        UpdateTimeSheetTotalQty(employeeTimeSheet);
                    }
                }
                else
                {
                    if (employeeID > 0)
                    {

                        HREmployeesInfo objEmployeesInfo = EmployeesList.Where(x => x.HREmployeeID == employeeID).FirstOrDefault();
                        LoadTimeKeeper(fromDate, toDate, objEmployeesInfo.HREmployeeCardNumber, true, employeeID);
                    }
                    else
                    {
                        LoadTimeKeeper(fromDate, toDate, null, true, null);
                    }

                }

            }
        }

        /// <summary>
        /// Add employee to the current time sheet
        /// </summary>
        public void AddEmployeeToTimeSheet()
        {
            try
            {
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                    HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)entity.MainObject;
                    entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                    HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
                    List<HRLeaveDaysInfo> leaveDays = objLeaveDaysController.GetLeaveDayList(timeSheet.HRTimeSheetFromDate, timeSheet.HRTimeSheetToDate);
                    List<HRTimeSheetParamsInfo> timeSheetParams = entity.TimeSheetParams;
                    HRTimeSheetParamsInfo defaultParam = (HRTimeSheetParamsInfo)timeSheetParams.Where(
                                                                                p => p.IsDefault == true &&
                                                                                p.HRTimeSheetParamType == timeSheet.HRTimeSheetType).FirstOrDefault();
                    string alert = "";
                    string alert2 = "";

                    foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                    {
                        if (objEmployeesInfo.Selected)
                        {
                            if (objEmployeesInfo.FK_HREmployeePayrollFormulaID == 0)
                            {
                                alert2 += objEmployeesInfo.HREmployeeName + " [" + objEmployeesInfo.HREmployeeNo + "]," + Environment.NewLine;
                            }
                            else if (string.IsNullOrEmpty(objEmployeesInfo.HREmployeeCardNumber))
                            {
                                alert += objEmployeesInfo.HREmployeeName + " [" + objEmployeesInfo.HREmployeeNo + "]," + Environment.NewLine;
                            }
                            else if (!entity.EmployeeTimeSheetList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                            {
                                //set default employee information
                                HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = SetEmployeeTimeSheetInfoFromEmployee(objEmployeesInfo);

                                //add default holiday timesheet param
                                AddDefaulTimeSheetEntries(objEmployeeTimeSheetsInfo);

                                List<HRTimeSheetEntrysInfo> timeSheetEntrys = objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList.Where(t => t.FK_HREmployeeID == objEmployeeTimeSheetsInfo.FK_HREmployeeID).ToList();

                                //Add time sheet entries from leave days
                                List<HRLeaveDaysInfo> employeeLeaveDays = leaveDays.Where(ld => ld.FK_HREmployeeID == objEmployeeTimeSheetsInfo.FK_HREmployeeID).ToList();
                                foreach (HRLeaveDaysInfo employeeLeaveDay in employeeLeaveDays)
                                {
                                    HRTimeSheetEntrysInfo entry = timeSheetEntrys.Where(e => e.FK_HREmployeeID == employeeLeaveDay.FK_HREmployeeID &&
                                                                                        e.HRTimeSheetEntryDate.Date == employeeLeaveDay.HRLeaveDayDate.Date).FirstOrDefault();
                                    if (entry != null)
                                    {
                                        entry.FK_HRTimeSheetParamID = employeeLeaveDay.FK_HRTimeSheetParamID;
                                    }
                                    else
                                    {
                                        entry = new HRTimeSheetEntrysInfo();
                                        entry.FK_HREmployeeID = employeeLeaveDay.FK_HREmployeeID;
                                        entry.FK_HRTimeSheetParamID = employeeLeaveDay.FK_HRTimeSheetParamID;
                                        entry.HRTimeSheetEntryDate = employeeLeaveDay.HRLeaveDayDate;
                                        timeSheetEntrys.Add(entry);
                                    }
                                }

                                objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList = timeSheetEntrys;
                                //entity.SetEmployeeTimeSheetValue(objEmployeeTimeSheetsInfo);
                                //UpdateTimeSheetTotalQty(objEmployeeTimeSheetsInfo);
                                entity.EmployeeTimeSheetList.Add(objEmployeeTimeSheetsInfo);
                                if (guiEmployee.SelectedEmployeeList.Count() <= 10)
                                {
                                    LoadTimeKeeper(timeSheet.HRTimeSheetFromDate.Date, timeSheet.HRTimeSheetToDate.Date, null, false, objEmployeesInfo.HREmployeeID);
                                }
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(alert2))
                    {
                        MessageBox.Show(alert2.Substring(0, alert2.LastIndexOf(',')) + Environment.NewLine + "Chưa chọn nhóm chấm công.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!string.IsNullOrEmpty(alert))
                    {
                        MessageBox.Show(alert.Substring(0, alert.LastIndexOf(',')) + Environment.NewLine + TimeSheetLocalizedResources.NotExistsCardNumber, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //LoadTimeKeeper();
                    // CTC Edit 11-09-2015 Begin
                    if (guiEmployee.SelectedEmployeeList.Count() > 10)
                    {
                        LoadTimeKeeper(timeSheet.HRTimeSheetFromDate.Date, timeSheet.HRTimeSheetToDate.Date, null, false, null);
                    }
                    // CTC Edit 11-09-2015 Begin
                    entity.EmployeeTimeSheetList.GridControl.RefreshDataSource();
                }
                isCustomDrawCell = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                BOSProgressBar.Close();
            }
        }

        /// <summary>
        /// Add default entries to a time sheet of an employee
        /// </summary>
        /// <param name="objEmployeeTimeSheetsInfo">Given employee time sheet</param>
        public void AddDefaulTimeSheetEntries(HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo)
        {
            objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList.Clear();

            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> timeSheetParams = entity.TimeSheetParams;
            HRTimeSheetParamsInfo defaultParam = (HRTimeSheetParamsInfo)timeSheetParams.Where(
                                                                                        p => p.IsDefault == true &&
                                                                                        p.HRTimeSheetParamType == objTimeSheetsInfo.HRTimeSheetType).FirstOrDefault();
            //TODO: Need to refactor this as we don't have a better way to get holiday param currently
            HRTimeSheetParamsInfo holidayParam = timeSheetParams.Where(p => p.HRTimeSheetParamNo.ToLower() == "le").FirstOrDefault();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            if (defaultParam != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                // fill column if end of week
                List<string> columnFieldNameEndOfWeek = GetColumnFieldNameByTypeEndOfWeek();
                // fill column if holiday
                List<string> columnFieldNameHoliday = GetColumnFieldNameByTypeHoliday();
                int numDays = NumOfDayInMonth();
                for (int i = 1; i <= numDays; i++)
                {
                    DateTime currentDate = objTimeSheetsInfo.HRTimeSheetFromDate.Date.AddDays(i - 1);
                    HRTimeSheetEntrysInfo entry = new HRTimeSheetEntrysInfo();
                    entry.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                    entry.FK_HRTimeSheetID = objEmployeeTimeSheetsInfo.FK_HRTimeSheetID;
                    entry.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                    entry.HRTimeSheetEntryDate = currentDate;

                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(entry.FK_HREmployeeID);
                    //Set default param to entry
                    //entry.FK_HRTimeSheetParamID = defaultParam.HRTimeSheetParamID;
                    String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", i);
                    bool isHoliday = columnFieldNameHoliday.Exists(delegate (string holiday) { return propertyName == holiday; });
                    if (isHoliday && holidayParam != null)
                    {
                        entry.FK_HRTimeSheetParamID = holidayParam.HRTimeSheetParamID;
                    }

                    bool isEndOfWeek = columnFieldNameEndOfWeek.Exists(delegate (string endOfWeek) { return propertyName == endOfWeek; });
                    if (!isEndOfWeek && objEmployeesInfo != null && objEmployeesInfo.HREmployeeStartWorkingDate.Date < currentDate.Date)
                    {
                        objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList.Add(entry);
                    }
                }
            }
        }

        /// <summary>
        /// Number of days in month
        /// </summary>
        /// <returns></returns>
        public int NumOfDayInMonth()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            //int numDays = DateTime.DaysInMonth(objTimeSheetsInfo.HRTimeSheetDate.Year, objTimeSheetsInfo.HRTimeSheetDate.Month);
            int numDays = (int)(objTimeSheetsInfo.HRTimeSheetToDate.Date - objTimeSheetsInfo.HRTimeSheetFromDate.Date).TotalDays + 1;
            return numDays;
        }

        /// <summary>
        ///  Initialize grid control
        /// </summary>
        public void InitializeTimeSheetEntryGridControl()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            HREmployeeTimeSheetsGridControl gridControl = (HREmployeeTimeSheetsGridControl)Controls[HRTimeSheetModule.HREmployeeTimeSheetsGridControlName];
            gridControl.InitializeControl();
            InitColumnRepository(objTimeSheetsInfo.HRTimeSheetType);
        }

        /// <summary>
        /// Show repository item checked combobox edit
        /// </summary>
        /// <param name="timeSheetType">Type of the time sheet</param>
        public void InitColumnRepository(string timeSheetType)
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            BOSGridControl timeSheetEntrysGridControl = (BOSGridControl)Controls[HRTimeSheetModule.HREmployeeTimeSheetsGridControlName];
            RepositoryItemCheckedComboBoxEdit reposItemCheckedCombo = new RepositoryItemCheckedComboBoxEdit();

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> mainParams = objTimeSheetParamsController.GetTimeSheetParamsByTimeSheetType(timeSheetType);
            List<HRTimeSheetParamsInfo> commonParams = objTimeSheetParamsController.GetTimeSheetParamsByCommonType();
            List<HRTimeSheetParamsInfo> otParams = objTimeSheetParamsController.GetOTTimeSheetParamsList();

            mainParams = mainParams.Concat(commonParams).ToList();
            mainParams = mainParams.Concat(otParams).ToList();
            reposItemCheckedCombo.DataSource = mainParams;

            reposItemCheckedCombo.DisplayMember = "HRTimeSheetParamNo";
            reposItemCheckedCombo.ValueMember = "HRTimeSheetParamNo";
            timeSheetEntrysGridControl.RepositoryItems.Add(reposItemCheckedCombo);

            for (int i = 4; i < timeSheetEntrysGridControl.Columns.Count; i++)
            {
                entity.EmployeeTimeSheetList.GridControl.Columns[i].ColumnEdit = reposItemCheckedCombo;
            }
            reposItemCheckedCombo.EditValueChanged += new EventHandler(ReposItemCheckedCombo_EditValueChanged);
        }

        /// <summary>
        /// Called when the user changes params of the time sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReposItemCheckedCombo_EditValueChanged(object sender, EventArgs e)
        {
            CheckedComboBoxEdit checkCombo = (CheckedComboBoxEdit)sender;
            string value = checkCombo.EditValue.ToString();
            string comboText = String.Empty;
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
            string[] arrayValue = value.Split(',');
            for (int i = 0; i < arrayValue.Length; i++)
            {
                if (arrayValue[i].Trim() != String.Empty)
                {
                    int paramID = objTimeSheetParamsController.GetObjectIDByNo(arrayValue[i].Trim());
                    comboText += String.Format("{0}, ", objTimeSheetParamsController.GetObjectNoByID(paramID));
                }
            }
            if (comboText.Length > 2)
                checkCombo.Text = comboText.Substring(0, comboText.Length - 2);
        }


        /// <summary>
        /// Check value of repository item checked combobox when edit value changed
        /// </summary>
        /// <param name="value">The time sheet entry value</param>
        /// <returns>True if allow choose time sheet entry, otherwise false</returns>
        public bool CheckChooseTimeSheetEntry(string value)
        {
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
            List<HRTimeSheetParamsInfo> dayParams = objTimeSheetParamsController.GetTimeSheetParamsByTimeSheetType(TimeSheetParamType.Day.ToString());
            List<HRTimeSheetParamsInfo> hourParams = objTimeSheetParamsController.GetTimeSheetParamsByTimeSheetType(TimeSheetParamType.Hour.ToString());
            List<HRTimeSheetParamsInfo> commonParams = objTimeSheetParamsController.GetTimeSheetParamsByCommonType();

            List<string> typeDayList = new List<string>();
            List<string> typeHourList = new List<string>();
            List<string> typeCommonList = new List<string>();

            string[] arrayValue = value.Split(',');
            if (arrayValue.Length > 2)
            {
                MessageBox.Show(TimeSheetLocalizedResources.RepositoryItemLagerTwoMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                for (int i = 0; i < arrayValue.Length; i++)
                {
                    if (arrayValue[i].Trim() != String.Empty)
                    {
                        int paramID = objTimeSheetParamsController.GetObjectIDByNo(arrayValue[i].Trim());
                        if (dayParams.Exists(p => p.HRTimeSheetParamID == paramID))
                        {
                            HRTimeSheetParamsInfo param = dayParams.Where(p => p.HRTimeSheetParamID == paramID).FirstOrDefault();
                            if (param != null)
                            {
                                typeDayList.Add(param.HRTimeSheetParamName);
                            }
                        }

                        if (hourParams.Exists(p => p.HRTimeSheetParamID == paramID))
                        {
                            HRTimeSheetParamsInfo param = hourParams.Where(p => p.HRTimeSheetParamID == paramID).FirstOrDefault();
                            if (param != null)
                            {
                                typeHourList.Add(param.HRTimeSheetParamName);
                            }
                        }

                        if (commonParams.Exists(p => p.HRTimeSheetParamID == paramID))
                        {
                            HRTimeSheetParamsInfo param = commonParams.Where(p => p.HRTimeSheetParamID == paramID).FirstOrDefault();
                            if (param != null)
                            {
                                typeCommonList.Add(param.HRTimeSheetParamName);
                            }
                        }
                    }

                }
                if (typeDayList.Count > 1)
                {
                    MessageBox.Show(String.Format(TimeSheetLocalizedResources.RepositoryItemCheckedAllowMessage, typeDayList[0], typeDayList[1]), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (typeHourList.Count > 1)
                {
                    MessageBox.Show(String.Format(TimeSheetLocalizedResources.RepositoryItemCheckedAllowMessage, typeHourList[0], typeHourList[1]), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (typeCommonList.Count > 1)
                {
                    MessageBox.Show(String.Format(TimeSheetLocalizedResources.RepositoryItemCheckedAllowMessage, typeCommonList[0], typeCommonList[1]), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Get column field name with calender type is holiday
        /// </summary>
        /// <returns>List of the column field name</returns>
        public List<string> GetColumnFieldNameByTypeHoliday()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            List<string> list = new List<string>();
            HRCalendarEntrysController objCalendarEntrysController = new HRCalendarEntrysController();
            List<HRCalendarEntrysInfo> entries = objCalendarEntrysController.GetCalendarEntryByDateAndCalenderType(CalendarType.Holiday.ToString(), objTimeSheetsInfo.HRTimeSheetFromDate, objTimeSheetsInfo.HRTimeSheetToDate);
            foreach (HRCalendarEntrysInfo objCalendarEntrysInfo in entries)
            {
                //int day = (int)(objCalendarEntrysInfo.HRCalendarEntryDate.Date - objTimeSheetsInfo.HRTimeSheetFromDate.AddDays(-1).Date).TotalDays;
                int day = (int)objCalendarEntrysInfo.HRCalendarEntryDate.Day;
                string columnName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", day);
                list.Add(columnName);
            }
            return list;
        }

        /// <summary>
        /// Get column field name with calender type is end of week
        /// </summary>
        /// <returns>List of the column field name</returns>
        public List<string> GetColumnFieldNameByTypeEndOfWeek()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            List<string> list = new List<string>();
            int numDays = NumOfDayInMonth();
            for (int i = 1; i <= numDays; i++)
            {
                DateTime dayofMonth = objTimeSheetsInfo.HRTimeSheetFromDate.AddDays(i - 1);
                DayOfWeek dayOfWeek = dayofMonth.DayOfWeek;
                if (BOSApp.IsEndOfWeek(dayOfWeek))
                {
                    string columnName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", i.ToString());
                    list.Add(columnName);
                }
            }
            return list;
        }

        /// <summary>
        /// Remove the selected employee from the current employee time sheet list
        /// </summary>
        public void RemoveEmployeeFromTimeSheetList()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.EmployeeTimeSheetList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.EmployeeTimeSheetList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        /// <summary>
        /// Called when the user changes the time sheet type
        /// </summary>
        /// <param name="timeSheetType">Target time sheet type</param>
        public void ChangeTimeSheetType(string timeSheetType)
        {
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;
            timeSheet.HRTimeSheetType = timeSheetType;
            InvalidateTimeSheetValues();
            InitializeTimeSheetEntryGridControl();
        }

        /// <summary>
        /// Called from the screen, when the user changes the time of time sheet
        /// </summary>
        public void ChangeTimeSheetTime()
        {
            InvalidateTimeSheetValues();
            InitializeTimeSheetEntryGridControl();
        }

        /// <summary>
        /// Invalidate values for the current time sheet
        /// </summary>
        private void InvalidateTimeSheetValues()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in entity.EmployeeTimeSheetList)
            {
                entity.SetEmployeeTimeSheetValue(employeeTimeSheet);
                UpdateTimeSheetTotalQty(employeeTimeSheet);
            }
        }

        #region Print

        /// <summary>
        /// Print time sheet detail
        /// </summary>
        public void PrintTimeSheetDetail()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;

                HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
                ADReportsController objReportsController = new ADReportsController();
                RPTimeSheetDetailA3 report = new RPTimeSheetDetailA3(objTimeSheetsInfo);
                report.AddDynamicColumn();
                System.Data.DataTable dt = null;
                dt = objTimeSheetEntrysController.GetTimeSheetEntryListByTimeSheetID(objTimeSheetsInfo.HRTimeSheetID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dt.Columns.Add("giocongchuan", typeof(decimal));
                    dt.Columns.Add("sumot", typeof(decimal));
                    dt.Columns.Add("sumotnotsun", typeof(decimal));
                    dt.Columns.Add("nghicophep", typeof(decimal));
                    dt.Columns.Add("nghikhongphep", typeof(decimal));
                    dt.Columns.Add("xuongcacophep", typeof(decimal));
                    dt.Columns.Add("xuongcakhongphep", typeof(decimal));
                    List<HRTimeSheetEntrysInfo> timeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
                    timeSheetEntryList = objTimeSheetEntrysController.GetTimeSheetEntryListByTimeSheetIDReport(objTimeSheetsInfo.HRTimeSheetID);
                    if (timeSheetEntryList != null && timeSheetEntryList.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            int employeeID = Convert.ToInt32(row["HREmployeeID"].ToString());
                            row["giocongchuan"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && x.HRTimeSheetParamType == TimeSheetParamType.Day.ToString()).Sum(x => x.HRTimeSheetParamValue);
                            row["sumot"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && x.HRTimeSheetParamType == TimeSheetParamType.Hour.ToString()).Sum(x => x.HRTimeSheetParamValue);
                            row["sumotnotsun"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && x.HRTimeSheetParamType == TimeSheetParamType.Hour.ToString() && x.HRTimeSheetEntryDate.DayOfWeek.ToString() != "Sunday").Sum(x => x.HRTimeSheetParamValue);
                            row["nghicophep"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && (x.HRTimeSheetParamType == TimeSheetParamType.NCP.ToString()
                                                                                                                || x.HRTimeSheetParamType == TimeSheetParamType.NCP1P2.ToString())).Sum(x => x.HRTimeSheetParamValue);
                            row["nghikhongphep"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && (x.HRTimeSheetParamType == TimeSheetParamType.NKP.ToString()
                                                                                                                || x.HRTimeSheetParamType == TimeSheetParamType.NKP1P2.ToString())).Sum(x => x.HRTimeSheetParamValue);
                            row["xuongcacophep"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && x.HRTimeSheetParamType == TimeSheetParamType.TC.ToString()).Sum(x => x.HRTimeSheetParamValue);
                            row["xuongcakhongphep"] = timeSheetEntryList.Where(x => x.HREmployeeID == employeeID && x.HRTimeSheetParamType == TimeSheetParamType.KTC.ToString()).Sum(x => x.HRTimeSheetParamValue);
                        }
                    }
                }
                report.DataSource = dt;
                report.DataMember = "Report_GetTimeSheetEntryListByTimeSheetID";
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }


        //TNDLoc [ADD][14/12/2015][Bảng chấm công gửi các bộ phận],START
        public decimal GetWorkQtyByType(HREmployeeTimeSheetsInfo empTimeSheet, string type)
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            decimal workQty = 0;
            List<string> employeeTimeSheetDayList = new List<string> {  empTimeSheet.HREmployeeTimeSheetDate1, empTimeSheet.HREmployeeTimeSheetDate2,
                                                                        empTimeSheet.HREmployeeTimeSheetDate3, empTimeSheet.HREmployeeTimeSheetDate4,
                                                                        empTimeSheet.HREmployeeTimeSheetDate5, empTimeSheet.HREmployeeTimeSheetDate6,
                                                                        empTimeSheet.HREmployeeTimeSheetDate7, empTimeSheet.HREmployeeTimeSheetDate8,
                                                                        empTimeSheet.HREmployeeTimeSheetDate9, empTimeSheet.HREmployeeTimeSheetDate10,
                                                                        empTimeSheet.HREmployeeTimeSheetDate11, empTimeSheet.HREmployeeTimeSheetDate12,
                                                                        empTimeSheet.HREmployeeTimeSheetDate13, empTimeSheet.HREmployeeTimeSheetDate14,
                                                                        empTimeSheet.HREmployeeTimeSheetDate15, empTimeSheet.HREmployeeTimeSheetDate16,
                                                                        empTimeSheet.HREmployeeTimeSheetDate17, empTimeSheet.HREmployeeTimeSheetDate18,
                                                                        empTimeSheet.HREmployeeTimeSheetDate19, empTimeSheet.HREmployeeTimeSheetDate20,
                                                                        empTimeSheet.HREmployeeTimeSheetDate21, empTimeSheet.HREmployeeTimeSheetDate22,
                                                                        empTimeSheet.HREmployeeTimeSheetDate23, empTimeSheet.HREmployeeTimeSheetDate24,
                                                                        empTimeSheet.HREmployeeTimeSheetDate25, empTimeSheet.HREmployeeTimeSheetDate26,
                                                                        empTimeSheet.HREmployeeTimeSheetDate27, empTimeSheet.HREmployeeTimeSheetDate28,
                                                                        empTimeSheet.HREmployeeTimeSheetDate29, empTimeSheet.HREmployeeTimeSheetDate30,
                                                                        empTimeSheet.HREmployeeTimeSheetDate31 };
            int numDays = NumOfDayInMonth();
            HoursPerDay = GetHourPerDay();
            for (int i = 0; i < numDays; i++)
            {
                string[] paramNumbers = employeeTimeSheetDayList[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < paramNumbers.Length; j++)
                {
                    if (paramNumbers[j].Equals(type))
                    {
                        string paramNo = paramNumbers[j].Trim();
                        HRTimeSheetParamsInfo param = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamNo == paramNo).FirstOrDefault();
                        if (param != null)
                        {
                            if (param.HRTimeSheetParamType == TimeSheetParamType.Day.ToString())
                            {
                                workQty += param.HRTimeSheetParamValue1;
                            }
                            else
                            {
                                workQty += (param.HRTimeSheetParamValue1) / HoursPerDay;
                            }
                        }
                    }
                }
            }
            return workQty;
        }

        public bool IsHoliday(List<HRCalendarEntrysInfo> objCalendarEntrysList, DateTime time)
        {
            bool isHoliday = false;
            if (objCalendarEntrysList != null && objCalendarEntrysList.Count > 0)
            {
                foreach (HRCalendarEntrysInfo holidayTime in objCalendarEntrysList)
                {
                    if (holidayTime.HRCalendarEntryDate.Date == time.Date)
                    {
                        isHoliday = true;
                        break;
                    }
                }
            }

            return isHoliday;
        }

        public void PrintTimeSheetDetailA4Landscape()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
                ADReportsController objReportsController = new ADReportsController();
                RPTimeSheetDetailA4Landscape report = new RPTimeSheetDetailA4Landscape();
                //report.LoadLayout(BOSCommon.Constants.Report.DevTimeSheetDetailReportPath);

                //Set current branch
                SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                entity.EmployeeTimeSheetList.ForEach(p => p.HRTimeSheetFromDate = objTimeSheetsInfo.HRTimeSheetFromDate);
                entity.EmployeeTimeSheetList.ForEach(p => p.HRTimeSheetToDate = objTimeSheetsInfo.HRTimeSheetToDate);

                HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
                HRCalendarEntrysController objCalendarEntrysController = new HRCalendarEntrysController();
                List<HRCalendarEntrysInfo> objCalendarEntrysList = objCalendarEntrysController.GetCalendarEntryByDateAndCalenderType(CalendarType.Holiday.ToString(), null, null);
                HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                foreach (HREmployeeTimeSheetsInfo empTimeSheet in entity.EmployeeTimeSheetList)
                {

                    empTimeSheet.HREmployeeTimeSheetCD = GetWorkQtyByType(empTimeSheet, WorkQtyType.NCD.ToString());
                    empTimeSheet.HREmployeeTimeSheetP = GetWorkQtyByType(empTimeSheet, WorkQtyType.NCP.ToString());
                    empTimeSheet.HREmployeeTimeSheetTS = GetWorkQtyByType(empTimeSheet, WorkQtyType.TS.ToString());
                    empTimeSheet.HREmployeeTimeSheetKP = GetWorkQtyByType(empTimeSheet, WorkQtyType.NKP.ToString());
                    empTimeSheet.HREmployeeTimeSheetPN = GetWorkQtyByType(empTimeSheet, WorkQtyType.NPN.ToString());
                    empTimeSheet.HREmployeeTimeSheetKP += GetWorkQtyByType(empTimeSheet, WorkQtyType.NKP1P2.ToString());
                    empTimeSheet.HREmployeeTimeSheetPN += GetWorkQtyByType(empTimeSheet, WorkQtyType.PN1P2.ToString());
                    empTimeSheet.HREmployeeTimeSheetP += GetWorkQtyByType(empTimeSheet, WorkQtyType.NCP1P2.ToString());

                    //=> OT Value
                    List<HRTimeSheetEntrysInfo> timeSheetEntrysList = objTimeSheetEntrysController.GetTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(objTimeSheetsInfo.HRTimeSheetID,
                                                                                                                                                    empTimeSheet.HREmployeeTimeSheetID);
                    if (timeSheetEntrysList != null && timeSheetEntrysList.Count > 0)
                    {
                        foreach (HRTimeSheetEntrysInfo entry in timeSheetEntrysList)
                        {
                            HRTimeSheetParamsInfo objParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByNo(entry.HRTimeSheetParamNo);
                            if (objParamsInfo != null && objParamsInfo.IsOTCalculated)
                            {
                                if (IsHoliday(objCalendarEntrysList, entry.HRTimeSheetEntryDate))
                                {
                                    empTimeSheet.HREmployeeTimeSheetTCLe += entry.HRTimeSheetEntryWorkingHours;
                                }
                                else
                                {

                                    if (objParamsInfo.HRTimeSheetParamValue2 == Convert.ToDecimal(1.5))
                                    {
                                        empTimeSheet.HREmployeeTimeSheetTCNT15 += entry.HRTimeSheetEntryWorkingHours;
                                    }
                                    else if (objParamsInfo.HRTimeSheetParamValue2 == Convert.ToDecimal(2))
                                    {
                                        empTimeSheet.HREmployeeTimeSheetTCNT20 += entry.HRTimeSheetEntryWorkingHours;
                                    }
                                    else if (objParamsInfo.HRTimeSheetParamValue2 == Convert.ToDecimal(2.15))
                                    {
                                        empTimeSheet.HREmployeeTimeSheetTCDem215 += entry.HRTimeSheetEntryWorkingHours;
                                    }

                                }
                            }
                        }
                    }
                    //=> Số ngày làm việc
                    empTimeSheet.HREmployeeTimeSheetSoNgayLamViec = empTimeSheet.HREmployeeTimeSheetWorkingQty;
                    //=> Tổng cộng công
                    empTimeSheet.HREmployeeTimeSheetTotalWorkQty = empTimeSheet.HREmployeeTimeSheetSoNgayLamViec
                                                                    + empTimeSheet.HREmployeeTimeSheetTS
                                                                    + empTimeSheet.HREmployeeTimeSheetPN
                                                                    + empTimeSheet.HREmployeeTimeSheetLeTet
                                                                    + empTimeSheet.HREmployeeTimeSheetLuanPhien
                                                                    + empTimeSheet.HREmployeeTimeSheetCD;
                    //=> Công dư
                    if (empTimeSheet.HREmployeeTimeSheetTotalWorkQty > 27)
                    {
                        empTimeSheet.HREmployeeTimeSheetCongDuChuyenPN = empTimeSheet.HREmployeeTimeSheetTotalWorkQty - 27;
                    }
                    else
                    {
                        empTimeSheet.HREmployeeTimeSheetCongDuChuyenPN = 0;
                    }
                    //=> Tổng công tính lương
                    if (empTimeSheet.HREmployeeTimeSheetTotalWorkQty == 27)
                    {
                        empTimeSheet.HREmployeeTimeSheetTotalPayRollWorkQty = 27;
                    }
                    else
                    {
                        empTimeSheet.HREmployeeTimeSheetTotalPayRollWorkQty = empTimeSheet.HREmployeeTimeSheetTotalWorkQty - empTimeSheet.HREmployeeTimeSheetCongDuChuyenPN;
                    }
                    //=> phép năm tồn
                    decimal totalNPNQty = objTimeSheetEntrysController.GetTotalNPNQty(empTimeSheet.FK_HREmployeeID);
                    string constantleavedaystr = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.AnnualLeaveDays.ToString()).ADConfigKeyValue;
                    decimal constantleaveday = 0;
                    if (decimal.TryParse(constantleavedaystr, out constantleaveday))
                    {
                        empTimeSheet.HREmployeeTimeSheetSoCongTon = constantleaveday - totalNPNQty;
                    }
                }

                report.DataSource = entity.EmployeeTimeSheetList;

                //Set report source for sub report time sheet param
                RPTimeSheetParam reportTimeSheetParam = new RPTimeSheetParam();
                //reportTimeSheetParam.LoadLayout(BOSCommon.Constants.Report.DevTimeSheetParamsReportPath);
                List<HRTimeSheetParamsInfo> timeSheetParamList = objReportsController.GetTimeSheetParamByTimeSheetParamType(objTimeSheetsInfo.HRTimeSheetType);
                reportTimeSheetParam.DataSource = timeSheetParamList;
                XRSubreport subReportTimeSheetParam = (XRSubreport)report.Bands[BandKind.ReportFooter].Controls["xr_SubreportTimeSheetParam"];
                if (subReportTimeSheetParam != null)
                    subReportTimeSheetParam.ReportSource = reportTimeSheetParam;

                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevTimeSheetDetailReportPath, true);
                reviewer.Show();
            }
        }

        public void SetDefaultCurrentBranchAndTitle(XtraReport report, int branchID)
        {
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
            {

                XRTableCell tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrThue"].Controls["xr_tbcThue"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyTaxNumber;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrdchd"].Controls["xrtbcdiachihoadon"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyAddressLine1;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrAddress"].Controls["xrtbcdiachinhamay"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrWeb"].Controls["xr_tbcWebsite"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyWebsite;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrEmail"].Controls["xr_tbcEmail"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyEmail;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrCellphone"].Controls["xr_tbcCellphone"];
                if (tablecell != null)
                {
                    tablecell.Text = objCompanyInfo.CSCompanyCellPhone;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrCompanyphone"].Controls["xr_tbcCompanyphone"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyPhone;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls[0].Controls[0];
                if (tablecell != null)
                {
                    tablecell.Text = objCompanyInfo.CSCompanyDesc;
                }

            }
        }

        //TNDLoc [ADD][14/12/2015][Bảng chấm công gửi các bộ phận],END
        /// <summary>
        /// Print time sheet
        /// </summary>
        public void PrintTimeSheet()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
                ADReportsController objReportsController = new ADReportsController();
                RPTimeSheet report = new RPTimeSheet();
                decimal hourPerDay = GetHourPerDay();
                HREmployeeTimeSheetsController employeeTimeSheetController = new HREmployeeTimeSheetsController();
                //TNDLoc [ADD][19/04/2016][Employee permission],START
                //Origin: List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = employeeTimeSheetController.GetEmployeeTimeSheetByTimeSheetID(objTimeSheetsInfo.HRTimeSheetID);
                List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = employeeTimeSheetController.GetEmployeeTimeSheetByTimeSheetIDAndUserGroup(objTimeSheetsInfo.HRTimeSheetID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                //TNDLoc [ADD][19/04/2016][Employee permission],END
                if (employeeTimeSheetList != null)
                {
                    foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in employeeTimeSheetList)
                    {
                        if (hourPerDay != 0)
                            employeeTimeSheet.HREmployeeAbsentUnpermission = employeeTimeSheet.HREmployeeAbsentUnpermission / hourPerDay;
                    }
                }
                //report.LoadLayout(BOSCommon.Constants.Report.DevTimeSheetReportPath);

                //Set current branch

                CSCompanysController objCompanysController = new CSCompanysController();
                CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                if (objCompanyInfo != null)
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrThue"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyTaxNumber;
                    }

                    label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrDiachihoadon"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyAddressLine1;
                    }

                    label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrDiachinhamay"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyAddressLine2;
                    }

                    label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrWebsite"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyWebsite;
                    }

                    label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrEmail"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyEmail;
                    }

                    label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCellphone"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyCellPhone;
                    }

                    label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCompanyphone"];
                    if (label != null)
                    {
                        label.Text += objCompanyInfo.CSCompanyPhone;
                    }
                }

                foreach (HREmployeeTimeSheetsInfo item in employeeTimeSheetList)
                {
                    item.HRTimeSheetFromDate = objTimeSheetsInfo.HRTimeSheetFromDate;
                    item.HRTimeSheetToDate = objTimeSheetsInfo.HRTimeSheetToDate;
                }
                //entity.EmployeeTimeSheetList.ForEach(p => p.HRTimeSheetFromDate = objTimeSheetsInfo.HRTimeSheetFromDate);
                //entity.EmployeeTimeSheetList.ForEach(p => p.HRTimeSheetToDate = objTimeSheetsInfo.HRTimeSheetToDate);
                report.DataSource = employeeTimeSheetList;
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevTimeSheetReportPath, true);
                reviewer.Show();
            }
        }
        #endregion

        #region Load time sheet from timekeeper

        /// <summary>
        /// Initialize data import from file excel
        /// </summary>
        /// <returns>Range of file excel</returns>
        public Range InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ImportDataLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;
            if (!String.IsNullOrEmpty(filePath))
            {
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                Range range = WorkSheet.UsedRange;
                return range;
            }
            return null;
        }

        /// <summary>
        /// Release data import from file excel
        /// </summary>
        public void ReleaseDataImport()
        {
            WorkBook.Close(true, null, null);
            App.Quit();
            ReleaseObject(WorkSheet);
            ReleaseObject(WorkBook);
            ReleaseObject(App);
        }

        /// <summary>
        /// Release object
        /// </summary>
        /// <param name="obj">Given object</param>
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        /// <summary>
        /// Get time sheet from time keeper
        /// </summary>
        /// <returns>List of the time sheet entry</returns>
        public List<HRTimeSheetEntrysInfo> GetTimeSheetEntryFromTimeKeeper()
        {
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;
            List<HRTimeSheetEntrysInfo> timeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
            Range range = InitializeDataImport();
            if (range != null)
            {
                if (MessageBox.Show(TimeSheetLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);
                    HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployeeByPermission(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                    HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                    List<HRTimeSheetParamsInfo> timeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList(timeSheet.HRTimeSheetType);
                    Regex regTime = new Regex("^([0-9]{1,2}):([0-9]{1,2})");
                    for (int row = 4; row <= range.Rows.Count; row++)
                    {
                        HRTimeSheetEntrysInfo entry = new HRTimeSheetEntrysInfo();
                        entry.HREmployeeCardNumber = (range.Cells[row, "B"] as Range).Text.ToString().Trim();
                        HREmployeesInfo objEmployeesInfo = employeeList.Where(e => e.HREmployeeCardNumber == entry.HREmployeeCardNumber).FirstOrDefault();
                        if (objEmployeesInfo != null)
                        {
                            if (!entity.EmployeeTimeSheetList.Exists(e => e.FK_HREmployeeID == objEmployeesInfo.HREmployeeID))
                            {
                                HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = new HREmployeeTimeSheetsInfo();
                                objEmployeeTimeSheetsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                objEmployeeTimeSheetsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                                objEmployeeTimeSheetsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                                objEmployeeTimeSheetsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                                objEmployeeTimeSheetsInfo.HRLevelName = objEmployeesInfo.HRLevelName;
                                objEmployeeTimeSheetsInfo.HREmployeeStartWorkingTime = objEmployeesInfo.HREmployeeStartWorkingTime;
                                objEmployeeTimeSheetsInfo.HREmployeeEndWorkingTime = objEmployeesInfo.HREmployeeEndWorkingTime;
                                objEmployeeTimeSheetsInfo.HREmployeeHoursPerDay = objEmployeesInfo.HREmployeeHoursPerDay;
                                entity.EmployeeTimeSheetList.Add(objEmployeeTimeSheetsInfo);
                            }

                            entry.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            Range r = range.Cells[row, "E"] as Range;
                            DateTime date = DateTime.ParseExact(r.Text.ToString().Trim(), r.NumberFormatLocal.ToString().Replace('m', 'M'), CultureInfo.InvariantCulture);
                            entry.HRTimeSheetEntryDate = date;

                            string timeSheetParamValue = (range.Cells[row, "G"] as Range).Text.ToString().Trim();
                            string timeSheetParamValue2 = (range.Cells[row, "H"] as Range).Text.ToString().Trim();
                            if (regTime.IsMatch(timeSheetParamValue))
                            {
                                string[] values = timeSheetParamValue.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                                DateTime d1 = new DateTime(date.Year, date.Month, date.Day, int.Parse(values[0]), int.Parse(values[1]), 0);
                                entry.HRTimeSheetEntryFrom = d1;
                                if (regTime.IsMatch(timeSheetParamValue2))
                                {
                                    values = timeSheetParamValue2.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                                    d1 = new DateTime(date.Year, date.Month, date.Day, int.Parse(values[0]), int.Parse(values[1]), 0);
                                    entry.HRTimeSheetEntryTo = d1;
                                    timeSheetEntryList.Add(entry);
                                }
                            }
                        }
                    }
                }
                ReleaseDataImport();
            }
            return timeSheetEntryList;
        }
        private HRTimeSheetParamsInfo GetTimeSheetParam(List<HRTimeSheetParamsInfo> timeSheetParamsList, decimal val, int workingShiftID)
        {
            return GetTimeSheetParam(timeSheetParamsList, val, false, workingShiftID);
        }
        private decimal GetTimeSheetScale(HREmployeesInfo objEmployeesInfo, decimal val)
        {
            if (objEmployeesInfo != null && objEmployeesInfo.FK_HRTimeSheetScaleID > 0)
            {
                HRTimeSheetLevelsController objTimeSheetLevelsController = new HRTimeSheetLevelsController();
                List<HRTimeSheetLevelsInfo> list = objTimeSheetLevelsController.GetLevelsByScaleID(objEmployeesInfo.FK_HRTimeSheetScaleID);
                HRTimeSheetLevelsInfo objTimeSheetLevelsInfo = list.Where(p => (p.HRTimeSheetLevelFrom <= (val / Convert.ToDecimal(60.0))
                                                                                && p.HRTimeSheetLevelTo >= (val / Convert.ToDecimal(60.0)))).FirstOrDefault();
                if (objTimeSheetLevelsInfo != null)
                {
                    val = objTimeSheetLevelsInfo.HRTimeSheetLevelValue * 60;
                }
            }
            return val;
        }
        private HRTimeSheetParamsInfo GetTimeSheetParam(List<HRTimeSheetParamsInfo> timeSheetParamsList, decimal val, bool isOT, int workingShiftID)
        {
            HRTimeSheetParamsInfo obj = timeSheetParamsList.Where(p => (p.IsOTCalculated == isOT && p.HRTimeSheetParamValue1 <= val && CheckWorkingShift(p, workingShiftID)))
                .OrderByDescending(p => p.HRTimeSheetParamValue1).FirstOrDefault();
            if (obj == null) obj = new HRTimeSheetParamsInfo();
            return obj;
        }

        private bool CheckWorkingShift(HRTimeSheetParamsInfo objTimeSheetParamsInfo, int workingShiftID)
        {
            string[] list = objTimeSheetParamsInfo.FK_HRWorkingShiftID.Split(',').ToArray();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Trim() == workingShiftID.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private HRTimeSheetParamsInfo GetOTTimeSheetParam(List<HRTimeSheetParamsInfo> timeSheetParamsList, decimal value1, decimal value2)
        {
            HRTimeSheetParamsInfo obj = timeSheetParamsList.Where(p => (p.IsOTCalculated == true &&
                                                            p.HRTimeSheetParamValue1 <= value1 && p.HRTimeSheetParamValue2 == value2))
                .OrderByDescending(p => p.HRTimeSheetParamValue1).FirstOrDefault();
            if (obj == null) obj = new HRTimeSheetParamsInfo();
            return obj;
        }

        private HRTimeSheetParamsInfo GetAllTimeSheetParamByIsOTCalculated(List<HRTimeSheetParamsInfo> timeSheetParamsList, bool isOTCalculated, string timeSheetParamType, decimal value1, decimal value2, HRTimesheetEmployeeLatesInfo objTimesheetEmployeeLatesInfo)
        {
            HRTimeSheetParamsInfo obj = timeSheetParamsList.Where(p => (p.IsOTCalculated == isOTCalculated && p.HRTimeSheetParamType == timeSheetParamType &&
                                                            p.HRTimeSheetParamValue1 <= value1 && p.HRTimeSheetParamValue2 == value2))
                .OrderByDescending(p => p.HRTimeSheetParamValue1).FirstOrDefault();
            // trường hợp TC ra sớm trong giới hạn dc phép => không bị trừ TC
            //27/05/2019
            //if (isOTCalculated && obj != null && objTimesheetEmployeeLatesInfo != null && (value1 - obj.HRTimeSheetParamValue1 > 0) && timeSheetParamType == TimeSheetType.Hour.ToString())
            //{
            //    value1 = value1 + ((decimal)(objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateTimeTo - objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateTimeFrom) / (decimal)60);
            //    HRTimeSheetParamsInfo objPlusTime = timeSheetParamsList.Where(p => (p.IsOTCalculated == isOTCalculated && p.HRTimeSheetParamType == timeSheetParamType &&
            //                                                p.HRTimeSheetParamValue1 <= value1 && p.HRTimeSheetParamValue2 == value2))
            //                                                .OrderByDescending(p => p.HRTimeSheetParamValue1).FirstOrDefault();
            //    if (objPlusTime != null)
            //        return objPlusTime;
            //}

            if (obj == null) obj = new HRTimeSheetParamsInfo();
            return obj;
        }

        private HRWorkingShiftsInfo GetWorkingShiftsInfoFromSchedule(int employeeID, DateTime date)
        {
            HRWorkingShiftsInfo workingShift = null;
            HREmployeeSchedulesController employeeScheduleController = new HREmployeeSchedulesController();
            HREmployeeSchedulesInfo employeeSchedule = employeeScheduleController.GetEmployeeScheduleByEmployeeIDAndEmployeeScheduleWorkDate(employeeID, date);
            if (employeeSchedule != null)
            {
                HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
                workingShift = workingShiftController.GetObjectByID(employeeSchedule.FK_HRWorkingShiftID) as HRWorkingShiftsInfo;
                //set the working time to employee schedule time at that time 
                if (workingShift != null)
                {
                    workingShift.HRWorkingShiftFromTime = employeeSchedule.HREmployeeScheduleFromTime;
                    workingShift.HRWorkingShiftToTime = employeeSchedule.HREmployeeScheduleToTime;
                }
            }
            return workingShift;
        }
        private List<HRTimeKeepersInfo> DistinctList(List<HRTimeKeepersInfo> list)
        {
            bool re = true;
            while (re && list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    re = false;
                    if (list[i].HRTimeKeeperTimeOut == list[i - 1].HRTimeKeeperTimeOut)
                    {
                        list.RemoveAt(i);
                        re = true;
                        break;
                    }
                }
            }
            return list;
        }

        public void LoadTimeKeeper(DateTime dateFrom, DateTime dateTo, string employeeCardNo, bool isReset, int? employeeID)
        {
            List<HRTimeSheetEntrysInfo> timeEntries = new List<HRTimeSheetEntrysInfo>();
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;
            HRTimeKeeperCompletesController objTimeKeeperCompletesController = new HRTimeKeeperCompletesController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRTimesheetEmployeeLatesController objTimesheetEmployeeLatesController = new HRTimesheetEmployeeLatesController();
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            HRArrangementShiftEntrysController objArrangementShiftEntrysController = new HRArrangementShiftEntrysController();
            string mess = "Đang chấm công....";
            BOSProgressBar.Start(mess);
            if (EmployeesList == null || EmployeesList.Count == 0)
            {
                EmployeesList = objEmployeesController.GetAllEmployees();
            }
            if (TimesheetEmployeeLateList == null || TimesheetEmployeeLateList.Count == 0)
            {
                TimesheetEmployeeLateList = objTimesheetEmployeeLatesController.GetAllTimeSheetEmployeeLates();
            }
            foreach (HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo in entity.EmployeeTimeSheetList)
            {
                if (employeeID > 0 && objEmployeeTimeSheetsInfo.FK_HREmployeeID != employeeID)
                {
                    continue;
                }
                string employeeCardNoInFor = "";
                if (employeeCardNo != null)
                {
                    employeeCardNoInFor = employeeCardNo;
                    if (employeeCardNo != objEmployeeTimeSheetsInfo.HREmployeeCardNumber)
                    {
                        goto ENDFOR;
                    }
                }
                else
                {
                    employeeCardNoInFor = objEmployeeTimeSheetsInfo.HREmployeeCardNumber;
                }

                List<HRTimeKeeperCompletesInfo> timeKeeperCompleteList = new List<HRTimeKeeperCompletesInfo>();
                timeKeeperCompleteList = objTimeKeeperCompletesController.GetTimeKeeperByDate(employeeCardNoInFor, dateFrom, dateTo);
                if (string.IsNullOrEmpty(objEmployeeTimeSheetsInfo.HREmployeeCardNumber)) continue;
                if (!string.IsNullOrEmpty(employeeCardNo) && objEmployeeTimeSheetsInfo.HREmployeeCardNumber != employeeCardNo) continue;


                HREmployeesInfo objEmployeesInfo = EmployeesList.Where(e => e.HREmployeeID == objEmployeeTimeSheetsInfo.FK_HREmployeeID).FirstOrDefault();

                objEmployeeTimeSheetsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                int daysInMonth = NumOfDayInMonth();
                for (int i = 1; i <= daysInMonth; i++)
                {
                    DateTime dt = timeSheet.HRTimeSheetFromDate.AddDays(i - 1).Date;
                    if (dt < dateFrom.Date || dt > dateTo.Date) continue;

                    List<HRWorkingShiftsInfo> workingShiftList = objWorkingShiftsController.GetAllData(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
                    HRWorkingShiftsInfo objWorkingShiftsInfo = new HRWorkingShiftsInfo();
                    if (workingShiftList != null && workingShiftList.Count > 0)
                    {
                        objWorkingShiftsInfo = workingShiftList.FirstOrDefault();
                    }

                    if (objWorkingShiftsInfo != null && objWorkingShiftsInfo.HRWorkingShiftToTime.TimeOfDay < objWorkingShiftsInfo.HRWorkingShiftFromTime.TimeOfDay)
                    {
                        List<HRTimeKeeperCompletesInfo> listTemp =
                            timeKeeperCompleteList
                            .Where(p => p.HRTimeKeeperCompletesEmployeeCardNo == objEmployeeTimeSheetsInfo.HREmployeeCardNumber
                                && (p.HRTimeKeeperCompleteDate.Date >= dt.Date && p.HRTimeKeeperCompleteDate <= dt.AddDays(1).Date))
                            .OrderBy(p => p.HRTimeKeeperCompleteTimeCheck)
                            .ToList();

                        for (int j = 0; j < listTemp.Count - 1; j += 1)
                        {
                            HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = new HRTimeSheetEntrysInfo();
                            objTimeSheetEntrysInfo.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                            objTimeSheetEntrysInfo.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                            objTimeSheetEntrysInfo.FK_HRTimeSheetID = objEmployeeTimeSheetsInfo.FK_HRTimeSheetID;
                            objTimeSheetEntrysInfo.HREmployeeCardNumber = objEmployeeTimeSheetsInfo.HREmployeeCardNumber;
                            objTimeSheetEntrysInfo.HRTimeSheetEntryDate = dt;

                            if (listTemp[j].HRTimeKeeperCompleteTimeCheck.TimeOfDay >= objWorkingShiftsInfo.HRWorkingShiftFrameTimeFrom.TimeOfDay)
                            {
                                objTimeSheetEntrysInfo.HRTimeSheetEntryFrom = listTemp[j].HRTimeKeeperCompleteTimeCheck;
                            }

                            if (listTemp[j + 1].HRTimeKeeperCompleteTimeCheck.TimeOfDay <= objWorkingShiftsInfo.HRWorkingShiftFrameTimeTo.TimeOfDay)
                            {
                                objTimeSheetEntrysInfo.HRTimeSheetEntryTo = listTemp[j + 1].HRTimeKeeperCompleteTimeCheck;
                            }
                            if (objTimeSheetEntrysInfo.HRTimeSheetEntryFrom != DateTime.MaxValue
                                && objTimeSheetEntrysInfo.HRTimeSheetEntryTo != DateTime.MaxValue)
                            {
                                timeEntries.Add(objTimeSheetEntrysInfo);
                            }

                        }
                    }
                    else
                    {
                        List<HRTimeKeeperCompletesInfo> listTemp = timeKeeperCompleteList.Where(p => p.HRTimeKeeperCompletesEmployeeCardNo == objEmployeeTimeSheetsInfo.HREmployeeCardNumber &&
                            p.HRTimeKeeperCompleteDate.Date == dt.Date).OrderBy(p => p.HRTimeKeeperCompleteTimeCheck).ToList(); //HRTimeKeeperCompleteTimeCheck

                        HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = new HRTimeSheetEntrysInfo();
                        objTimeSheetEntrysInfo.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                        objTimeSheetEntrysInfo.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                        objTimeSheetEntrysInfo.FK_HRTimeSheetID = objEmployeeTimeSheetsInfo.FK_HRTimeSheetID;
                        objTimeSheetEntrysInfo.HREmployeeCardNumber = objEmployeeTimeSheetsInfo.HREmployeeCardNumber;
                        objTimeSheetEntrysInfo.HRTimeSheetEntryDate = dt;

                        if (listTemp.Count() > 1)
                        {
                            objTimeSheetEntrysInfo.HRTimeSheetEntryFrom = listTemp[0].HRTimeKeeperCompleteTimeCheck;
                            objTimeSheetEntrysInfo.HRTimeSheetEntryTo = listTemp[listTemp.Count - 1].HRTimeKeeperCompleteTimeCheck;
                            timeEntries.Add(objTimeSheetEntrysInfo);
                        }

                        //for (int j = 0; j < listTemp.Count - 1; j += 2)
                        //{
                        //    HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = new HRTimeSheetEntrysInfo();
                        //    objTimeSheetEntrysInfo.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                        //    objTimeSheetEntrysInfo.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                        //    objTimeSheetEntrysInfo.FK_HRTimeSheetID = objEmployeeTimeSheetsInfo.FK_HRTimeSheetID;
                        //    objTimeSheetEntrysInfo.HREmployeeCardNumber = objEmployeeTimeSheetsInfo.HREmployeeCardNumber;
                        //    objTimeSheetEntrysInfo.HRTimeSheetEntryDate = dt;
                        //    //if (listTemp[j].HRTimeKeeperCompleteInOutMode == 0)
                        //    //{
                        //    //    if (listTemp[j].HRTimeKeeperCompleteTimeCheck != listTemp[j + 1].HRTimeKeeperCompleteTimeCheck)
                        //    //    {
                        //    //        objTimeSheetEntrysInfo.HRTimeSheetEntryFrom = listTemp[j].HRTimeKeeperCompleteTimeCheck;
                        //    //        objTimeSheetEntrysInfo.HRTimeSheetEntryTo = listTemp[j + 1].HRTimeKeeperCompleteTimeCheck;
                        //    //    }
                        //    //}
                        //    //else
                        //    //{
                        //    //    if (listTemp[j].HRTimeKeeperCompleteTimeCheck != listTemp[j + 1].HRTimeKeeperCompleteTimeCheck)
                        //    //    {
                        //    //        objTimeSheetEntrysInfo.HRTimeSheetEntryFrom = listTemp[j + 1].HRTimeKeeperCompleteTimeCheck;
                        //    //        objTimeSheetEntrysInfo.HRTimeSheetEntryTo = listTemp[j].HRTimeKeeperCompleteTimeCheck;
                        //    //    }
                        //    //}

                        //    if (listTemp[j].HRTimeKeeperCompleteInOutMode == 0)
                        //    {
                        //        objTimeSheetEntrysInfo.HRTimeSheetEntryFrom = listTemp[j].HRTimeKeeperCompleteTimeCheck;
                        //        objTimeSheetEntrysInfo.HRTimeSheetEntryTo = listTemp[j + 1].HRTimeKeeperCompleteTimeCheck;
                        //    }
                        //    else
                        //    {
                        //        objTimeSheetEntrysInfo.HRTimeSheetEntryFrom = listTemp[j + 1].HRTimeKeeperCompleteTimeCheck;
                        //        objTimeSheetEntrysInfo.HRTimeSheetEntryTo = listTemp[j].HRTimeKeeperCompleteTimeCheck;
                        //    }

                        //    timeEntries.Add(objTimeSheetEntrysInfo);
                        //}
                    }
                }
            ENDFOR:;
            }

            AddEmployeesFromTimeKeeper(timeEntries.OrderBy(x => x.HRTimeSheetEntryFrom).ToList(), dateFrom, dateTo, isReset, employeeID);
            BOSProgressBar.Close();
        }

        public void AddEmployeesFromTimeKeeper()
        {
            List<HRTimeSheetEntrysInfo> timeEntries = GetTimeSheetEntryFromTimeKeeper();
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;
            HRTimesheetEmployeeLatesController objTimesheetEmployeeLatesController = new HRTimesheetEmployeeLatesController();
            if (TimesheetEmployeeLateList == null || TimesheetEmployeeLateList.Count == 0)
            {
                TimesheetEmployeeLateList = objTimesheetEmployeeLatesController.GetAllTimeSheetEmployeeLates();
            }
            AddEmployeesFromTimeKeeper(timeEntries, timeSheet.HRTimeSheetFromDate, timeSheet.HRTimeSheetToDate, false, null);
        }
        /// <summary>
        /// Load time sheet from time keeper and refresh employee time sheet
        /// </summary>
        public void AddEmployeesFromTimeKeeper(List<HRTimeSheetEntrysInfo> timeEntries, DateTime dateFrom, DateTime dateTo, bool isReset, int? employeeID)
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;

            if (timeEntries == null)
                timeEntries = new List<HRTimeSheetEntrysInfo>();

            //get time sheet params
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> timeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList(timeSheet.HRTimeSheetType);
            List<HRTimeSheetParamsInfo> allTimeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList();
            List<HRTimeSheetParamsInfo> otTimeSheetParamsList = objTimeSheetParamsController.GetOTTimeSheetParamsList();

            //DateTime dateFrom = timeSheet.HRTimeSheetFromDate;
            //DateTime dateTo = timeSheet.HRTimeSheetToDate;

            //get employee's leave days
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            List<HRLeaveDaysInfo> leaveDays = objLeaveDaysController.GetLeaveDayList(dateFrom, dateTo);
            HRAllowanceConfigsController objAllowanceConfigsController = new HRAllowanceConfigsController();
            //List<HRAllowanceConfigsInfo> ListConfig = objAllowanceConfigsController.GetAllowanceConfigByFKEmployeePayrollFormula(null);

            HRBreakTimesController breakTimeController = new HRBreakTimesController();
            List<HRBreakTimesInfo> breakTimeList = breakTimeController.GetBreakTimeList();
            HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();

            //get hour per day
            HoursPerDay = GetHourPerDay();

            //add time sheeet entries from employee's work schedule
            List<HRTimeSheetEntrysInfo> workScheduleEntries = AddTimeSheetEntryFromEmployeeWorkSchedule();
            //timeEntries.AddRange(workingShiftTimeEntries);


            List<string> columnFieldNameHoliday = GetColumnFieldNameByTypeHoliday();
            List<HRTimeSheetEntrysInfo> timeKeeperEntries = new List<HRTimeSheetEntrysInfo>();
            List<HRTimeSheetEntrysInfo> removedEntries = null;
            HRTimesheetEmployeeLatesInfo objEmployeeLatesInfo = new HRTimesheetEmployeeLatesInfo();
            List<HRArrangementShiftEntrysInfo> arrangementShiftEntrys = new List<HRArrangementShiftEntrysInfo>();
            HRArrangementShiftEntrysController objArrangementShiftEntrysController = new HRArrangementShiftEntrysController();

            DateTime maxWorkingShiftDateTo = DateTime.MinValue;
            #region add time sheet entry from schedule
            int maxMinuteLate = 60;
            //add time sheet entry from schedule
            foreach (var item in timeEntries)
            {
                if (!timeKeeperEntries.Exists(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                p.HRTimeSheetEntryDate.Date == item.HRTimeSheetEntryDate.Date)))
                {
                    List<HRTimeSheetEntrysInfo> temp = timeEntries.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                p.HRTimeSheetEntryDate.Date == item.HRTimeSheetEntryDate.Date)).ToList();
                    HREmployeesInfo objEmployeesInfo = EmployeesList.Where(e => e.HREmployeeID == item.FK_HREmployeeID).FirstOrDefault();

                    if (objEmployeesInfo != null)
                    {
                        //Lấy số phút tối thiểu không bị trừ công HRTimesheetEmployeeLateDeduct == 0
                        objEmployeeLatesInfo = TimesheetEmployeeLateList.Where(l => l.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID
                            && l.HRTimesheetEmployeeLateDeduct == 0
                            && (String.IsNullOrEmpty(l.HRTimesheetEmployeeLateType)
                                || l.HRTimesheetEmployeeLateType == TimesheetEmployeeLateType.Late.ToString())
                            ).FirstOrDefault();
                        if (objEmployeeLatesInfo != null && objEmployeeLatesInfo.HRTimesheetEmployeeLateTimeTo > 0)
                        {
                            maxMinuteLate = objEmployeeLatesInfo.HRTimesheetEmployeeLateTimeTo;
                        }
                    }

                    item.HRTimeSheetEntryWorkingHours = 0;
                    item.HRTimeSheetEntryWorkingQty = 0;
                    DateTime dateMinTimeSheet = DateTime.MaxValue;
                    DateTime dateMaxTimeSheet = DateTime.MinValue;
                    foreach (var i in temp)
                    {
                        if (i.HRTimeSheetEntryFrom < dateMinTimeSheet) dateMinTimeSheet = i.HRTimeSheetEntryFrom;
                    }
                    // có hơn một cặp công trong 1 ngày : HRTimeSheetEntryDate.Date
                    if (temp.Count > 1 && objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0 && timeSheet.HRTimeSheetType == TimeSheetType.Day.ToString())
                    {
                        HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfo(objEmployeesInfo.FK_HREmployeePayrollFormulaID, dateMinTimeSheet, dateMinTimeSheet, maxMinuteLate);
                        //HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfoFromSchedule(objEmployeesInfo.HREmployeeID, dateMinTimeSheet);

                        if (objWorkingShiftsInfo != null)
                        {

                            List<HRTimeSheetEntrysInfo> tempGetAllTime = timeEntries.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                    p.HRTimeSheetEntryDate.Date == item.HRTimeSheetEntryDate.Date)).ToList();
                            if (tempGetAllTime != null && tempGetAllTime.Count > 1)
                            {
                                // sắp xếp lại theo thứ tự giờ ra tăng dần và merge thành 1 cặp vào ra : ADD thêm số phút ra - vào của từng cặp
                                tempGetAllTime = tempGetAllTime.OrderBy(x => x.HRTimeSheetEntryTo).ToList();
                                foreach (var timeInOut in tempGetAllTime)
                                {
                                    if (timeInOut.HRTimeSheetEntryFrom != tempGetAllTime[0].HRTimeSheetEntryFrom)
                                    {
                                        TimeSpan sp = timeInOut.HRTimeSheetEntryTo - timeInOut.HRTimeSheetEntryFrom;
                                        tempGetAllTime[0].HRTimeSheetEntryTo = tempGetAllTime[0].HRTimeSheetEntryTo.Add(sp);
                                    }
                                }
                            }

                            List<HRTimeSheetEntrysInfo> temp2 = tempGetAllTime.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                    p.HRTimeSheetEntryDate.Date == item.HRTimeSheetEntryDate.Date &&
                                                    int.Parse(p.HRTimeSheetEntryFrom.ToString("HHmm")) < int.Parse(objWorkingShiftsInfo.HRWorkingShiftToTime.ToString("HHmm")))).ToList();


                            if (temp2.Count > 0)
                            {
                                temp.Clear();
                                temp2.ForEach(p => temp.Add((HRTimeSheetEntrysInfo)p.Clone()));
                            }
                        }
                    }
                    foreach (var i in temp)
                    {
                        item.HRTimeSheetEntryWorkingHours += ((decimal)(i.HRTimeSheetEntryTo - i.HRTimeSheetEntryFrom).TotalMinutes) / Convert.ToDecimal(60.0);
                        item.HRTimeSheetEntryWorkingQty = item.HRTimeSheetEntryWorkingHours;
                        if (i.HRTimeSheetEntryTo > dateMaxTimeSheet)
                            dateMaxTimeSheet = i.HRTimeSheetEntryTo;
                    }

                    if (timeSheet.HRTimeSheetType == TimeSheetType.Hour.ToString())
                    {
                        //HRTimeSheetParamsInfo info = GetTimeSheetParam(timeSheetParamsList, item.HRTimeSheetEntryWorkingHours);
                        //if (info != null)
                        //{
                        //    item.FK_HRTimeSheetParamID = info.HRTimeSheetParamID;
                        //}
                    }
                    else
                    {
                        if (objEmployeesInfo.FK_HRTimeSheetScaleID > 0)
                        {
                            decimal minutes = GetTimeSheetScale(objEmployeesInfo, (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes);
                            if (dateMinTimeSheet.AddMinutes(Convert.ToDouble(minutes)) > dateMaxTimeSheet)
                            {
                                dateMaxTimeSheet = dateMinTimeSheet.AddMinutes(Convert.ToDouble(minutes));
                            }
                        }
                        #region Holiday
                        bool isHoliday = false;
                        if (BOSApp.IsEndOfWeek(item.HRTimeSheetEntryDate.DayOfWeek)
                            || BOSApp.IsHoliday(item.HRTimeSheetEntryDate))
                        {
                            isHoliday = true;
                        }

                        #endregion
                        item.HRTimeSheetEntryFrom = dateMinTimeSheet;
                        item.HRTimeSheetEntryTo = dateMaxTimeSheet;
                        if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0 && !isHoliday)
                        {
                            //Truyền công thức tính lương -
                            HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfo(objEmployeesInfo.FK_HREmployeePayrollFormulaID, dateMinTimeSheet, item.HRTimeSheetEntryDate, maxMinuteLate);
                            if (objEmployeesInfo.HREmployeePayRollCalculatedWorkType == EmployeePayRollCalculatedWorkType.TableWork.ToString())
                            {
                                arrangementShiftEntrys = (List<HRArrangementShiftEntrysInfo>)objArrangementShiftEntrysController.GetKHRArrangementShiftEntryByFK_HREmployeeIDAndDate(objEmployeesInfo.HREmployeeID, item.HRTimeSheetEntryDate.Date);
                                if (arrangementShiftEntrys.Count() > 0)
                                {
                                    HRArrangementShiftEntrysInfo objArrangementShiftEntrysInfo = (HRArrangementShiftEntrysInfo)arrangementShiftEntrys.FirstOrDefault();
                                    if (objArrangementShiftEntrysInfo != null)
                                    {
                                        objWorkingShiftsInfo = (HRWorkingShiftsInfo)workingShiftController.GetObjectByID(objArrangementShiftEntrysInfo.FK_HRWorkingShiftID);
                                        if (objWorkingShiftsInfo.FK_HRWorkingShiftID == 0)
                                        {
                                            objWorkingShiftsInfo.FK_HRWorkingShiftID = objWorkingShiftsInfo.HRWorkingShiftID;
                                        }
                                    }
                                }
                            }
                            if (objWorkingShiftsInfo != null)
                            {
                                List<HRBreakTimesInfo> breakTimes = breakTimeList.Where(bt => bt.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                                DateTime dateMinWorkingShift = DateTime.ParseExact(dateMinTimeSheet.ToString("dd/MM/yyyy") + " " + objWorkingShiftsInfo.HRWorkingShiftFromTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                                DateTime dateMaxWorkingShift = DateTime.ParseExact(dateMinTimeSheet.ToString("dd/MM/yyyy") + " " + objWorkingShiftsInfo.HRWorkingShiftToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                                //Làm việc từ ngày hôm nay sang ngày hôm sau : EX:12h trưa tới 6h sáng hôm sau
                                //Ca làm việc chỉ có từ giờ đến giờ
                                if (dateMaxWorkingShift <= dateMinWorkingShift) dateMaxWorkingShift = dateMaxWorkingShift.AddDays(1);
                                int n = (int)(item.HRTimeSheetEntryDate.Date - timeSheet.HRTimeSheetFromDate.Date).TotalDays + 1;
                                String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", n);

                                DateTime dateMaxOT = dateMaxTimeSheet;

                                if (dateMinTimeSheet < dateMinWorkingShift) dateMinTimeSheet = dateMinWorkingShift;
                                if (dateMaxTimeSheet >= dateMaxWorkingShift)
                                {
                                    dateMaxTimeSheet = dateMaxWorkingShift;
                                }
                                decimal workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                decimal workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                decimal factor = workingMinutes / workingShiftMinutes;
                                if (dateMinTimeSheet <= dateMinWorkingShift)
                                {
                                    if (dateMaxTimeSheet >= dateMaxWorkingShift)
                                    {
                                        foreach (HRBreakTimesInfo breakTime in breakTimes)
                                        {
                                            breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                            breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                            DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                                            DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;


                                            decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                            decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                            if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                                workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                            if (totalBreakTimeMinutes > 0)
                                            {
                                                workingMinutes -= totalBreakTimeMinutes;
                                            }
                                        }
                                        factor = Math.Round(workingMinutes / workingShiftMinutes, 5);
                                        HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                        item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                        item.HRTimeSheetEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                        item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                        if (objWorkingShiftsInfo.HRWorkingShiftNight)
                                        {
                                            item.IsNightWorking = true;
                                        }
                                    }
                                    else
                                    {
                                        HRTimesheetEmployeeLatesInfo objTimesheetEmployeeLatesInfo =
                                            TimesheetEmployeeLateList
                                            .Where(l => (l.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID)
                                           && (l.HRTimesheetEmployeeLateTimeFrom <= (int)(dateMaxWorkingShift - dateMaxTimeSheet).TotalMinutes)
                                           && (l.HRTimesheetEmployeeLateTimeTo >= (int)(dateMaxWorkingShift - dateMaxTimeSheet).TotalMinutes)
                                           && (l.HRTimesheetEmployeeLateType == TimesheetEmployeeLateType.Early.ToString())).FirstOrDefault();

                                        workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                        workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                        factor = workingMinutes / workingShiftMinutes;

                                        foreach (HRBreakTimesInfo breakTime in breakTimes)
                                        {
                                            breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                            breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                            DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                                            DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                                            decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                            decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                            if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                                workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;

                                            if (totalBreakTimeMinutes > 0)
                                            {
                                                workingMinutes -= totalBreakTimeMinutes;
                                            }
                                        }
                                        factor = Math.Round(workingMinutes / workingShiftMinutes, 5);

                                        if (objTimesheetEmployeeLatesInfo != null)
                                        {
                                            decimal val = 1 - objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateDeduct;
                                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, val, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                            if (objTimeSheetParamsInfo != null)
                                            {
                                                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                                item.HRTimeSheetEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                if (objWorkingShiftsInfo.HRWorkingShiftNight)
                                                {
                                                    item.IsNightWorking = true;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                            if (objTimeSheetParamsInfo != null)
                                            {
                                                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                                item.HRTimeSheetEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                if (objWorkingShiftsInfo.HRWorkingShiftNight)
                                                {
                                                    item.IsNightWorking = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (dateMinTimeSheet > dateMinWorkingShift)
                                {
                                    HRTimesheetEmployeeLatesInfo objTimesheetEmployeeLatesInfo =
                                        TimesheetEmployeeLateList.Where(l => (l.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID)
                                       && (l.HRTimesheetEmployeeLateTimeFrom <= (int)(dateMinTimeSheet - dateMinWorkingShift).TotalMinutes)
                                       && (l.HRTimesheetEmployeeLateTimeTo >= (int)(dateMinTimeSheet - dateMinWorkingShift).TotalMinutes)
                                       && (l.HRTimesheetEmployeeLateType == TimesheetEmployeeLateType.Late.ToString())).FirstOrDefault();

                                    decimal totalEarly = 0;

                                    if (objTimesheetEmployeeLatesInfo != null)
                                    {
                                        if (workScheduleEntries == null || workScheduleEntries.Count == 0
                                            || !workScheduleEntries.Exists(o => o.HRTimeSheetEntryDate.Date == dateMinTimeSheet.Date && o.FK_HREmployeeID == item.FK_HREmployeeID))
                                        {
                                            dateMinTimeSheet = dateMinWorkingShift;
                                        }
                                    }

                                    if (dateMaxTimeSheet >= dateMaxWorkingShift)
                                    {
                                        if (objTimesheetEmployeeLatesInfo != null && (workScheduleEntries == null || workScheduleEntries.Count == 0))
                                        {
                                            if (objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateOTTime != 0)
                                            {
                                                dateMaxWorkingShift = dateMaxWorkingShift.AddMinutes(objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateOTTime);
                                                dateMaxTimeSheet = dateMaxOT;
                                            }

                                            workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                            workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                            factor = workingMinutes / workingShiftMinutes;

                                            foreach (HRBreakTimesInfo breakTime in breakTimes)
                                            {
                                                breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                                breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                                DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                                                DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                                                decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                                decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                                if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                                    workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                                if (totalBreakTimeMinutes > 0)
                                                {
                                                    workingMinutes -= totalBreakTimeMinutes;
                                                }
                                            }
                                            factor = Math.Round(workingMinutes / workingShiftMinutes, 5);
                                        }
                                        else
                                        {
                                            workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                            workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                            factor = workingMinutes / workingShiftMinutes;

                                            foreach (HRBreakTimesInfo breakTime in breakTimes)
                                            {
                                                breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                                breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                                DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                                                DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                                                decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                                decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                                if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                                    workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                                if (totalBreakTimeMinutes > 0)
                                                {
                                                    workingMinutes -= totalBreakTimeMinutes;
                                                }
                                            }
                                            factor = Math.Round(workingMinutes / workingShiftMinutes, 5);
                                        }
                                    }
                                    else
                                    {
                                        HRTimesheetEmployeeLatesInfo objTimesheetEmployeeEarlysInfo =
                                        TimesheetEmployeeLateList.Where(l => (l.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID)
                                       && (l.HRTimesheetEmployeeLateTimeFrom <= (int)(dateMaxWorkingShift - dateMaxTimeSheet).TotalMinutes)
                                       && (l.HRTimesheetEmployeeLateTimeTo >= (int)(dateMaxWorkingShift - dateMaxTimeSheet).TotalMinutes)
                                       && (l.HRTimesheetEmployeeLateType == TimesheetEmployeeLateType.Early.ToString())).FirstOrDefault();

                                        if (objTimesheetEmployeeEarlysInfo != null)
                                        {
                                            dateMaxTimeSheet = dateMaxWorkingShift;
                                        }

                                        workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                        workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                        factor = workingMinutes / workingShiftMinutes;

                                        foreach (HRBreakTimesInfo breakTime in breakTimes)
                                        {
                                            breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                            breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                            DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                                            DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                                            decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                            decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                            if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                                workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                            if (totalBreakTimeMinutes > 0)
                                            {
                                                workingMinutes -= totalBreakTimeMinutes;
                                            }
                                        }
                                        factor = Math.Round(workingMinutes / workingShiftMinutes, 5);

                                        if (objTimesheetEmployeeEarlysInfo != null)
                                        {
                                            totalEarly = objTimesheetEmployeeEarlysInfo.HRTimesheetEmployeeLateDeduct;
                                        }
                                    }
                                    if (objTimesheetEmployeeLatesInfo != null)
                                    {
                                        if (workScheduleEntries == null || workScheduleEntries.Count == 0
                                            || !workScheduleEntries.Exists(o => o.HRTimeSheetEntryDate.Date == dateMinTimeSheet.Date && o.FK_HREmployeeID == item.FK_HREmployeeID))
                                        {
                                            decimal val = factor - objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateDeduct - totalEarly;
                                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, val, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                            if (objTimeSheetParamsInfo != null)
                                            {
                                                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                                item.HRTimeSheetEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                if (objWorkingShiftsInfo.HRWorkingShiftNight)
                                                {
                                                    item.IsNightWorking = true;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor - totalEarly, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                        if (objTimeSheetParamsInfo != null)
                                        {
                                            item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                            item.HRTimeSheetEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                            item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                            if (objWorkingShiftsInfo.HRWorkingShiftNight)
                                            {
                                                item.IsNightWorking = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (item.FK_HRTimeSheetParamID == 0)
                    {
                        if (leaveDays.Exists(ld => (ld.FK_HREmployeeID == item.FK_HREmployeeID
                            && ld.HRLeaveDayDate.Date == item.HRTimeSheetEntryDate.Date)))
                        {
                            HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfo(objEmployeesInfo.FK_HREmployeePayrollFormulaID, dateMinTimeSheet, item.HRTimeSheetEntryDate, maxMinuteLate);
                            if (objWorkingShiftsInfo != null)
                            {
                                List<HRBreakTimesInfo> breakTimes = breakTimeList.Where(bt => bt.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                                DateTime dateMinWorkingShift = DateTime.ParseExact(dateMinTimeSheet.ToString("dd/MM/yyyy") + " " + objWorkingShiftsInfo.HRWorkingShiftFromTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                                DateTime dateMaxWorkingShift = DateTime.ParseExact(dateMinTimeSheet.ToString("dd/MM/yyyy") + " " + objWorkingShiftsInfo.HRWorkingShiftToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                                //Làm việc từ ngày hôm nay sang ngày hôm sau : EX:12h trưa tới 6h sáng hôm sau
                                //Ca làm việc chỉ có từ giờ đến giờ
                                if (dateMaxWorkingShift <= dateMinWorkingShift) dateMaxWorkingShift = dateMaxWorkingShift.AddDays(1);
                                int n = (int)(item.HRTimeSheetEntryDate.Date - timeSheet.HRTimeSheetFromDate.Date).TotalDays + 1;
                                String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", n);

                                if (dateMinTimeSheet < dateMinWorkingShift) dateMinTimeSheet = dateMinWorkingShift;
                                if (dateMaxTimeSheet >= dateMaxWorkingShift) dateMaxTimeSheet = dateMaxWorkingShift;
                                decimal workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                decimal workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                decimal factor = workingMinutes / workingShiftMinutes;
                                foreach (HRBreakTimesInfo breakTime in breakTimes)
                                {
                                    breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                    breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                    DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                                    DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                                    //decimal  totalBreakTime = (breakTimeTo - breakTimeFrom).TotalMinutes / 60.0;
                                    //if (totalBreakTime > 0)
                                    //    time -= totalBreakTime;
                                    decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                    decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                    if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                        workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                    if (totalBreakTimeMinutes > 0)
                                    {
                                        workingMinutes -= totalBreakTimeMinutes;
                                    }

                                }
                                factor = Math.Round(workingMinutes / workingShiftMinutes, 5);

                                HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor, false, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                if (objWorkingShiftsInfo.HRWorkingShiftNight)
                                {
                                    item.IsNightWorking = true;
                                }
                            }
                            else
                            {
                                HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, item.HRTimeSheetEntryWorkingHours / HoursPerDay, false, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                            }
                        }
                    }

                    if (!(BOSApp.IsEndOfWeek(item.HRTimeSheetEntryDate.DayOfWeek)
                            || BOSApp.IsHoliday(item.HRTimeSheetEntryDate)))
                    {
                        HRTimeSheetEntrysInfo item1 = (HRTimeSheetEntrysInfo)item.Clone();
                        item1.HRTimeSheetEntryFrom = dateMinTimeSheet;
                        item1.HRTimeSheetEntryTo = dateMaxTimeSheet;
                        timeKeeperEntries.Add(item1);
                    }
                }
            }
            #endregion
            #region work schedule


            foreach (var item in workScheduleEntries)
            {
                List<HRTimeSheetEntrysInfo> temp = workScheduleEntries.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                            p.HRTimeSheetEntryDate.Date == item.HRTimeSheetEntryDate.Date)).ToList();

                HREmployeesInfo objEmployeesInfo = EmployeesList.Where(e => e.HREmployeeID == item.FK_HREmployeeID).FirstOrDefault();
                item.HRTimeSheetEntryWorkingHours = 0;
                item.HRTimeSheetEntryWorkingQty = 0;
                DateTime dateMinTimeSheet = DateTime.MaxValue;
                DateTime dateMaxTimeSheet = DateTime.MinValue;
                foreach (var i in temp)
                {
                    if (i.HRTimeSheetEntryFrom < dateMinTimeSheet) dateMinTimeSheet = i.HRTimeSheetEntryFrom;
                    if (i.HRTimeSheetEntryTo > dateMaxTimeSheet) dateMaxTimeSheet = i.HRTimeSheetEntryTo;
                }

                if (timeSheet.HRTimeSheetType == TimeSheetType.Hour.ToString())
                {
                    //HRTimeSheetParamsInfo info = GetTimeSheetParam(timeSheetParamsList, item.HRTimeSheetEntryWorkingHours);
                    //if (info != null)
                    //{
                    //    item.FK_HRTimeSheetParamID = info.HRTimeSheetParamID;
                    //}
                }
                else
                {
                    if (objEmployeesInfo.FK_HRTimeSheetScaleID > 0)
                    {
                        decimal minutes = GetTimeSheetScale(objEmployeesInfo, (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes);
                        if (dateMinTimeSheet.AddMinutes(Convert.ToDouble(minutes)) > dateMaxTimeSheet)
                        {
                            dateMaxTimeSheet = dateMinTimeSheet.AddMinutes(Convert.ToDouble(minutes));
                        }
                    }
                    item.HRTimeSheetEntryFrom = dateMinTimeSheet;
                    item.HRTimeSheetEntryTo = dateMaxTimeSheet;

                    List<HRBreakTimesInfo> breakTimes = breakTimeList.Where(bt => bt.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                    if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0)
                    {
                        //get default working shift for work schedule
                        HRWorkingShiftsInfo objWorkingShiftsInfo = workingShiftController.
                                            GetDefaultWorkingShiftByPayrollFormulaIDAndWorkingShiftDayOfWeek(objEmployeesInfo.FK_HREmployeePayrollFormulaID,
                                                                                                            WorkingShiftDayOffWeek.All.ToString());
                        if (objWorkingShiftsInfo != null)
                        {
                            DateTime dateMinWorkingShift = dateMinTimeSheet.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftFromTime.Hour)
                                                                        .AddMinutes(objWorkingShiftsInfo.HRWorkingShiftFromTime.Minute);
                            DateTime dateMaxWorkingShift = dateMaxTimeSheet.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftToTime.Hour)
                                                                        .AddMinutes(objWorkingShiftsInfo.HRWorkingShiftToTime.Minute);

                            if (dateMaxWorkingShift <= dateMinWorkingShift) dateMaxWorkingShift = dateMaxWorkingShift.AddDays(1);

                            if (dateMinTimeSheet < dateMinWorkingShift)
                                dateMinTimeSheet = dateMinWorkingShift;
                            if (dateMaxTimeSheet > dateMaxWorkingShift)
                                dateMaxTimeSheet = dateMaxWorkingShift;

                            decimal workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                            decimal workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;

                            //27/05/2019
                            //foreach (HRBreakTimesInfo breakTime in breakTimes)
                            //{
                            //    breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                            //    breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                            //    DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                            //    DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                            //    //decimal  totalBreakTime = (breakTimeTo - breakTimeFrom).TotalMinutes / 60.0;
                            //    //if (totalBreakTime > 0)
                            //    //    time -= totalBreakTime;
                            //    decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                            //    decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                            //    if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                            //        workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                            //    if (totalBreakTimeMinutes > 0)
                            //    {
                            //        workingMinutes -= totalBreakTimeMinutes;
                            //    }

                            //}
                            //end

                            HRBreakTimesInfo breakTime = new HRBreakTimesInfo();

                            breakTime.HRBreakTimeFromTime = dateMinTimeSheet.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftFrom.Hour).AddMinutes(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftFrom.Minute);
                            breakTime.HRBreakTimeToTime = dateMinTimeSheet.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftTo.Hour).AddMinutes(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftTo.Minute);

                            DateTime breakTimeFrom = dateMinTimeSheet < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : dateMinTimeSheet;
                            DateTime breakTimeTo = dateMaxTimeSheet < breakTime.HRBreakTimeToTime ? dateMaxTimeSheet : breakTime.HRBreakTimeToTime;

                            decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                            decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                            if (totalWokingShiftBreakTimeMinutes > 0 && (breakTime.HRBreakTimeToTime < dateMaxWorkingShift))
                                workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                            if (totalBreakTimeMinutes > 0)
                            {
                                workingMinutes -= totalBreakTimeMinutes;
                            }


                            decimal factor = workingMinutes / workingShiftMinutes;
                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                            item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                            item.HRTimeSheetEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                            item.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                        }
                    }

                    HRTimeSheetEntrysInfo item1 = (HRTimeSheetEntrysInfo)item.Clone();
                    item1.HRTimeSheetEntryFrom = dateMinTimeSheet;
                    item1.HRTimeSheetEntryTo = dateMaxTimeSheet;
                    timeKeeperEntries.Add(item1);
                }
            }
            #endregion

            #region OT


            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            List<HROTFactorsInfo> objOTFactorsList2 = objOTFactorsController.GetAllOTFactors();


            foreach (HREmployeeTimeSheetsInfo item in entity.EmployeeTimeSheetList)
            {
                item.HREmployeeTimeSheetPermissionOTDaysOff = 0;
                HREmployeesInfo objEmployeesInfo = EmployeesList.Where(e => e.HREmployeeID == item.FK_HREmployeeID).FirstOrDefault();
                HREmployeeOTsController objEmployeeOTsController = new HREmployeeOTsController();
                List<HREmployeeOTsInfo> listOTs = objEmployeeOTsController.GetEmployeeOTList(item.FK_HREmployeeID, dateFrom, dateTo);
                List<HRBreakTimesInfo> breakTimes = breakTimeList.Where(bt => bt.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                //HRWorkingShiftsInfo objWorkingShiftsInfo = workingShiftController.
                //                            GetDefaultWorkingShiftByPayrollFormulaIDAndWorkingShiftDayOfWeek(objEmployeesInfo.FK_HREmployeePayrollFormulaID,
                //                                                                                            WorkingShiftDayOffWeek.All.ToString());
                HRWorkingShiftsInfo objWorkingShiftsInfo = (HRWorkingShiftsInfo)workingShiftController.
                    GetFirstWorkingShiftByPayrollFormulaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
                HRTimesheetEmployeeLatesInfo objTimesheetEmployeeLatesInfo = TimesheetEmployeeLateList.Where(l => l.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID
                            && l.HRTimesheetEmployeeLateDeduct == 0
                            && (String.IsNullOrEmpty(l.HRTimesheetEmployeeLateType)
                                || l.HRTimesheetEmployeeLateType == TimesheetEmployeeLateType.Late.ToString())).FirstOrDefault();

                if (listOTs != null && listOTs.Count > 0)
                {
                    List<HREmployeeOTsInfo> listOT2 = new List<HREmployeeOTsInfo>();
                    listOTs.ForEach(o =>
                    {
                        if (o.HREmployeeOTDate.Date < o.HREmployeeOTDateEnd.Date)
                        {
                            DateTime dateEmployeeOT = o.HREmployeeOTDate.Date;
                            while (dateEmployeeOT < o.HREmployeeOTDateEnd.Date)
                            {
                                HREmployeeOTsInfo objEmployeeOTsInfo = new HREmployeeOTsInfo();
                                objEmployeeOTsInfo = (HREmployeeOTsInfo)o.Clone();
                                objEmployeeOTsInfo.HREmployeeOTDate = dateEmployeeOT.AddDays(1);
                                objEmployeeOTsInfo.HREmployeeOTFromDate = dateEmployeeOT.AddDays(1);

                                listOT2.Add(objEmployeeOTsInfo);
                                dateEmployeeOT = dateEmployeeOT.AddDays(1);
                            }
                        }
                    });

                    if (listOT2 != null && listOT2.Count > 0)
                    {
                        listOT2.ForEach(o =>
                        {
                            listOTs.Add(o);
                        });
                    }
                }
                //Set OT default by config
                //03/05/2019 Start

                //if (objEmployeeLatesInfo != null && objEmployeeLatesInfo.HRTimesheetEmployeeLateOTDefault > 0 && objWorkingShiftsInfo != null)
                //{
                //    List<HRTimeSheetEntrysInfo> dddOTDefaultList = timeEntries.Where(tke => tke.FK_HREmployeeID == item.FK_HREmployeeID).ToList();
                //    if (dddOTDefaultList != null)
                //    {
                //        List<DateTime> listEntryDate = new List<DateTime>();
                //        foreach (HRTimeSheetEntrysInfo entry in dddOTDefaultList)
                //        {
                //            if (!listEntryDate.Contains(entry.HRTimeSheetEntryDate.Date))
                //            {
                //                listEntryDate.Add(entry.HRTimeSheetEntryDate.Date);

                //                if (listOTs == null)
                //                    listOTs = new List<HREmployeeOTsInfo>();

                //                HREmployeeOTsInfo objEmployeeOTsInfo = listOTs.Where(x => x.FK_HREmployeeID == item.FK_HREmployeeID
                //                            && x.HREmployeeOTDate.Date == entry.HRTimeSheetEntryDate.Date).FirstOrDefault();

                //                if ((objEmployeeOTsInfo == null || objEmployeeOTsInfo.FK_HREmployeeID == 0) && entry.HRTimeSheetEntryFrom != entry.HRTimeSheetEntryTo)
                //                {
                //                    HREmployeeOTsInfo objDefaultOTsInfo = new HREmployeeOTsInfo();
                //                    objDefaultOTsInfo.FK_HREmployeeID = item.FK_HREmployeeID;
                //                    objDefaultOTsInfo.HREmployeeOTDate = entry.HRTimeSheetEntryDate.Date;
                //                    objDefaultOTsInfo.HREmployeeOTDateEnd = entry.HRTimeSheetEntryDate.Date;
                //                    //
                //                    DateTime WorkingShiftToTime = objWorkingShiftsInfo.HRWorkingShiftToTime.AddMinutes((double)objEmployeeLatesInfo.HRTimesheetEmployeeLateOTDefault);
                //                    objDefaultOTsInfo.HREmployeeOTFromDate = DateTime.ParseExact(entry.HRTimeSheetEntryDate.ToString("dd/MM/yyyy") + " "
                //                     + objWorkingShiftsInfo.HRWorkingShiftToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                //                    objDefaultOTsInfo.HREmployeeOTToDate = DateTime.ParseExact(entry.HRTimeSheetEntryDate.ToString("dd/MM/yyyy") + " "
                //                                 + WorkingShiftToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                //                    objDefaultOTsInfo.HROverTimeDefaultOT = true;
                //                    listOTs.Add(objDefaultOTsInfo);
                //                }

                //            }
                //        }
                //    }

                //}

                //03/05/2019 END

                foreach (var ot in listOTs)
                {
                    int n = ot.HREmployeeOTDate.Day;
                    String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", n);

                    //set OT time to the real time from time keeper 
                    HRTimeSheetEntrysInfo timeSheetEntry = timeEntries.FirstOrDefault(tke => tke.HRTimeSheetEntryDate.Date == ot.HREmployeeOTDate.Date
                        && tke.FK_HREmployeeID == item.FK_HREmployeeID && tke.HRTimeSheetEntryFrom != tke.HRTimeSheetEntryTo);
                    if (timeSheetEntry != null)
                    {
                        HRTimeSheetEntrysInfo timeSheetEntry1 = timeKeeperEntries.FirstOrDefault(tke => tke.HRTimeSheetEntryDate.Date == ot.HREmployeeOTDate.Date
                                                                                                        && tke.FK_HRTimeSheetParamID != 0 && tke.FK_HREmployeeID == item.FK_HREmployeeID);
                        if (timeSheetEntry1 != null)
                        {
                            #region Holiday
                            bool isHoliday = false;
                            if (BOSApp.IsEndOfWeek(timeSheetEntry1.HRTimeSheetEntryDate.DayOfWeek)
                                || BOSApp.IsHoliday(timeSheetEntry1.HRTimeSheetEntryDate))
                            {
                                isHoliday = true;
                            }

                            #endregion
                            //Set defualt OT for HRTimeSheetEntryFrom IsEndOfWeek, IsHoliday
                            //if (timeSheetEntry1.HRTimeSheetEntryTo > ot.HREmployeeOTFromDate && !isHoliday)
                            if (timeSheetEntry1.HRTimeSheetEntryTo > ot.HREmployeeOTFromDate)
                                ot.HREmployeeOTFromDate = timeSheetEntry1.HRTimeSheetEntryTo;

                        }
                        //Tính ngày xuống ca OT (trừ cơm)
                        //HRAllowanceConfigsInfo objAllowanceConfigsInfo = ListConfig.Where(x => x.HRAllowanceConfigName == AllowanceConfigName.Meal.ToString() 
                        //    && x.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).FirstOrDefault();
                        // if (objAllowanceConfigsInfo != null)
                        // {
                        //     if (timeSheetEntry.HRTimeSheetEntryTo < ot.HREmployeeOTToDate && ot.HROverTimeHaveMeal)
                        //     {
                        //         decimal minuteOTs = (decimal)(ot.HREmployeeOTToDate - timeSheetEntry.HRTimeSheetEntryTo ).TotalMinutes;
                        //         decimal otHour = Math.Round(minuteOTs / 60, 0);
                        //         if (otHour >= objAllowanceConfigsInfo.HRAllowanceConfigToTime)
                        //         {
                        //             //List<HRTimeSheetEntrysInfo> objTimeSheetEntryList = timeKeeperEntries.Where(tke => tke.HRTimeSheetEntryDate.Date == ot.HREmployeeOTDate.Date
                        //             //                                               && tke.FK_HREmployeeID == item.FK_HREmployeeID ).ToList();
                        //             //if (objTimeSheetEntryList != null)
                        //             //{ 
                        //             //   objTimeSheetEntryList.ForEach( x=> {x.HRTimeSheetEntryPermissionOTDaysOff =1; });
                        //             //}
                        //             ot.HREmployeeOTPermissionOTDaysOff = 1;
                        //             item.HREmployeeTimeSheetPermissionOTDaysOff += 1;
                        //         }
                        //     }
                        // }

                        if (ot.HREmployeeOTToDate > timeSheetEntry.HRTimeSheetEntryTo)
                            ot.HREmployeeOTToDate = timeSheetEntry.HRTimeSheetEntryTo;

                        if (ot.HREmployeeOTFromDate < timeSheetEntry.HRTimeSheetEntryFrom
                            && timeSheetEntry.HRTimeSheetEntryFrom <= ot.HREmployeeOTToDate)
                            ot.HREmployeeOTFromDate = timeSheetEntry.HRTimeSheetEntryFrom;


                        decimal minutes = (decimal)(ot.HREmployeeOTToDate - ot.HREmployeeOTFromDate).TotalMinutes;

                        List<HROTFactorsInfo> objOTFactorsList = new List<HROTFactorsInfo>();
                        if (columnFieldNameHoliday.IndexOf(propertyName) > -1)
                        {
                            objOTFactorsList = objOTFactorsList2.Where(p => (p.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID &&
                                p.HROTFactorType == OTFactorType.Holiday.ToString())).ToList();
                        }
                        else if (BOSApp.IsEndOfWeek(ot.HREmployeeOTDate.DayOfWeek))
                        {
                            objOTFactorsList = objOTFactorsList2.Where(p => (p.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID &&
                                    p.HROTFactorType == OTFactorType.EndOfWeek.ToString())).ToList();
                        }
                        else
                        {
                            objOTFactorsList = objOTFactorsList2.Where(p => (p.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID &&
                                    p.HROTFactorType == OTFactorType.WorkingDay.ToString())).ToList();
                        }
                        foreach (var objOTFactor in objOTFactorsList)
                        {
                            DateTime d1 = DateTime.ParseExact(ot.HREmployeeOTDate.ToString("dd/MM/yyyy") + " " + objOTFactor.HROTFactorFromTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            DateTime d2 = DateTime.ParseExact(ot.HREmployeeOTDate.ToString("dd/MM/yyyy") + " " + objOTFactor.HROTFactorToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            objOTFactor.HROTFactorFromTime = d1;
                            if (d2 < d1)
                            {
                                d2 = d2.AddDays(1);
                            }
                            objOTFactor.HROTFactorToTime = d2;
                        }

                        decimal f = 0;
                        decimal otHours = 0;
                        DateTime fromDate = dateFrom;
                        DateTime toDate = dateTo;

                        foreach (var objOTFactor in objOTFactorsList)
                        {
                            decimal time = 0;
                            decimal totalMinutes = 0;
                            fromDate = ot.HREmployeeOTFromDate < objOTFactor.HROTFactorFromTime ? objOTFactor.HROTFactorFromTime : ot.HREmployeeOTFromDate;
                            toDate = ot.HREmployeeOTToDate < objOTFactor.HROTFactorToTime ? ot.HREmployeeOTToDate : objOTFactor.HROTFactorToTime;

                            //time = (toDate - fromDate).TotalMinutes / 60.0;
                            totalMinutes = (decimal)(toDate - fromDate).TotalMinutes;
                            bool isHoliday = false;
                            if (BOSApp.IsEndOfWeek(ot.HREmployeeOTDate.DayOfWeek)
                                || BOSApp.IsHoliday(ot.HREmployeeOTDate))
                            {
                                isHoliday = true;
                            }

                            if (objWorkingShiftsInfo != null)
                            {
                                HRBreakTimesInfo breakTime = new HRBreakTimesInfo();

                                breakTime.HRBreakTimeFromTime = fromDate.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftFrom.Hour).AddMinutes(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftFrom.Minute);
                                breakTime.HRBreakTimeToTime = fromDate.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftTo.Hour).AddMinutes(objWorkingShiftsInfo.HRWorkingShiftBreakTimeBetweenShiftTo.Minute);

                                DateTime breakTimeFrom = fromDate < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : fromDate;
                                DateTime breakTimeTo = toDate < breakTime.HRBreakTimeToTime ? toDate : breakTime.HRBreakTimeToTime;
                                decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;

                                if (totalBreakTimeMinutes > 0 && !ot.HROverTimeDefaultOT)
                                    totalMinutes -= totalBreakTimeMinutes;
                            }
                            //foreach (HRBreakTimesInfo breakTime in breakTimes)
                            //{
                            //    breakTime.HRBreakTimeFromTime = fromDate.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                            //    breakTime.HRBreakTimeToTime = fromDate.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                            //    DateTime breakTimeFrom = fromDate < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : fromDate;
                            //    DateTime breakTimeTo = toDate < breakTime.HRBreakTimeToTime ? toDate : breakTime.HRBreakTimeToTime;

                            //    decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;

                            //    //Không trừ defualt OT, và phải DK ăn cơm và cấu hình rơi vào khoảng thời gian Tăng ca
                            //    if (totalBreakTimeMinutes > 0 && !ot.HROverTimeDefaultOT && (ot.HROverTimeHaveMeal || isHoliday))
                            //        totalMinutes -= totalBreakTimeMinutes;
                            //}

                            time = Math.Round(totalMinutes / 60, 5);
                            // Ưu tiên lấy hệ số tăng ca theo HREmployeeOTFactor
                            //, Nếu hệ số tăng ca bằng 1 thì tính qua ngày còn khoảng thời gian tăng ca quá 8h thì hệ số tăng ca theo cấu hình
                            System.Data.DataTable dt = new System.Data.DataTable();
                            dt.Columns.Add("TimeValue", typeof(decimal));
                            dt.Columns.Add("FactorValue", typeof(decimal));
                            dt.Columns.Add("IsOTFactor", typeof(bool));
                            dt.Columns.Add("isOTCalculated", typeof(bool));
                            dt.Columns.Add("TimeSheetParamType", typeof(string));
                            if (ot.HREmployeeOTFactor == 1)
                            {
                                if (time > HoursPerDay)
                                {
                                    decimal timeDetail = (timeSheet.HRTimeSheetType == TimeSheetType.Day.ToString()) ? 1 : HoursPerDay;
                                    dt.Rows.Add(new Object[] { timeDetail, ot.HREmployeeOTFactor, true, false, timeSheet.HRTimeSheetType });
                                    dt.Rows.Add(new Object[] { time - HoursPerDay, objOTFactor.HROTFactorValue, false, true, TimeSheetType.Hour.ToString() });
                                }
                                else
                                {
                                    decimal timeDetail = (timeSheet.HRTimeSheetType == TimeSheetType.Day.ToString()) ? time / HoursPerDay : time;
                                    dt.Rows.Add(new Object[] { timeDetail, ot.HREmployeeOTFactor, true, false, timeSheet.HRTimeSheetType });
                                }
                            }
                            else if (ot.HREmployeeOTFactor > 0)
                            {
                                if (isHoliday)
                                {
                                    string date = ot.HREmployeeOTDate.ToString();
                                    string Factor = objOTFactor.HROTFactorValue.ToString();
                                }
                                dt.Rows.Add(new Object[] { time, ot.HREmployeeOTFactor, true, true, TimeSheetType.Hour.ToString() });
                            }
                            else
                            {
                                dt.Rows.Add(new Object[] { time, objOTFactor.HROTFactorValue, false, true, TimeSheetType.Hour.ToString() });
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetAllTimeSheetParamByIsOTCalculated(otTimeSheetParamsList
                                    , (bool)dt.Rows[i]["isOTCalculated"]
                                    , (string)dt.Rows[i]["TimeSheetParamType"]
                                    , (decimal)dt.Rows[i]["TimeValue"]
                                    , (decimal)dt.Rows[i]["FactorValue"]
                                    , objTimesheetEmployeeLatesInfo);
                                if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamID != 0)
                                {
                                    otHours = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                    //f = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objOTFactor.HROTFactorValue;
                                    f = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * (decimal)dt.Rows[i]["FactorValue"];
                                    HRTimeSheetEntrysInfo obj = new HRTimeSheetEntrysInfo();
                                    bool isOTCalculated = (bool)dt.Rows[i]["isOTCalculated"];
                                    obj.FK_HREmployeeID = item.FK_HREmployeeID;
                                    obj.FK_HREmployeeTimeSheetID = item.HREmployeeTimeSheetID;
                                    obj.FK_HRTimeSheetID = item.FK_HRTimeSheetID;
                                    obj.HRTimeSheetEntryDate = ot.HREmployeeOTDate;
                                    //obj.HRTimeSheetEntryPermissionOTDaysOff = ot.HREmployeeOTPermissionOTDaysOff;
                                    if (otHours < 2 && ot.HROverTimeHaveMeal)
                                    {
                                        obj.HRTimeSheetEntryPermissionOTDaysOff = 1;
                                    }
                                    obj.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                    obj.HRTimeSheetEntryFrom = fromDate;
                                    obj.HRTimeSheetEntryTo = toDate;
                                    obj.HRTimeSheetParamNo = objTimeSheetParamsInfo.HRTimeSheetParamNo;
                                    if (isOTCalculated)// Tính tăng ca
                                    {
                                        obj.HRTimeSheetEntryWorkingQty = f / HoursPerDay;
                                        obj.HRTimeSheetEntryWorkingHours = f;
                                        obj.IsOTFactor = (bool)dt.Rows[i]["IsOTFactor"];
                                        obj.HRTimeSheetEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                        #region Holiday
                                        isHoliday = false;
                                        if (BOSApp.IsEndOfWeek(ot.HREmployeeOTDate.DayOfWeek)
                                            || BOSApp.IsHoliday(ot.HREmployeeOTDate))
                                        {
                                            isHoliday = true;
                                        }

                                        #endregion
                                        if (isHoliday)
                                            obj.HRTimeSheetEntryHolidayWorkingHours = f;
                                    }
                                    else// Tính ngày công
                                    {
                                        if (objTimeSheetParamsInfo.HRTimeSheetParamType == TimeSheetParamType.Day.ToString())
                                        {
                                            obj.HRTimeSheetEntryWorkingQty = (decimal)dt.Rows[i]["TimeValue"];
                                            obj.HRTimeSheetEntryWorkingHours = (decimal)dt.Rows[i]["TimeValue"] * HoursPerDay;
                                        }
                                        else
                                        {
                                            obj.HRTimeSheetEntryWorkingHours = (decimal)dt.Rows[i]["TimeValue"];
                                            obj.HRTimeSheetEntryWorkingQty = (decimal)dt.Rows[i]["TimeValue"] / HoursPerDay;
                                        }
                                        obj.HRTimeSheetEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                    }

                                    timeKeeperEntries.Add(obj);
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region EmployeeTimeSheetList
            List<HREmployeeTimeSheetsInfo> employeeTimeSheets = new List<HREmployeeTimeSheetsInfo>();
            //TODO: Need to refactor this as we don't have a better way to get holiday param currently
            HRTimeSheetParamsInfo holidayParam = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamType == TimeSheetParamType.LE.ToString()).FirstOrDefault();
            HRTimeSheetParamsInfo bonusTimeParam = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamType == TimeSheetParamType.BonusTime.ToString()).FirstOrDefault();
            HRTimeSheetParamsInfo defaultParam = entity.TimeSheetParams.Where(p => p.IsDefault == true).FirstOrDefault();
            List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            HREmployeesInfo objREmployeesInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo in entity.EmployeeTimeSheetList)
            {
                List<HRTimeSheetEntrysInfo> timeSheetEntrys = timeKeeperEntries.Where(t => t.FK_HREmployeeID == objEmployeeTimeSheetsInfo.FK_HREmployeeID).ToList();
                List<HREmployeeTimeSheetOTDetailsInfo> timeSheetOTDetails = new List<HREmployeeTimeSheetOTDetailsInfo>();

                objREmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeTimeSheetsInfo.FK_HREmployeeID);
                // Add time sheet entries for holiday days
                int daysInMonth = NumOfDayInMonth();
                //for (int i = dateFromNum; i <= dateToNum; i++)
                for (DateTime dt = dateFrom; dt <= dateTo; dt = dt.AddDays(1))
                {
                    int i = dt.Day;
                    String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", i);
                    bool isHoliday = columnFieldNameHoliday.Exists(delegate (string holiday) { return propertyName == holiday; });
                    //DateTime date = timeSheet.HRTimeSheetFromDate.AddDays(i - 1).Date;
                    DateTime date = dt.Date;
                    if ((isHoliday && holidayParam != null && objREmployeesInfo != null && objREmployeesInfo.HREmployeeStartWorkingDate.Date < date))
                    {
                        HRTimeSheetEntrysInfo entry = timeSheetEntrys.Where(e => e.HRTimeSheetEntryDate.Date == date).FirstOrDefault();
                        if (entry != null)
                        {
                            if (entry.FK_HRTimeSheetParamID == 0)
                            {
                                entry.FK_HRTimeSheetParamID = defaultParam.HRTimeSheetParamID;
                                entry.HRTimeSheetEntryWorkingHours = defaultParam.HRTimeSheetParamValue1 * defaultParam.HRTimeSheetParamValue2;
                                entry.HRTimeSheetEntryWorkingQty = entry.HRTimeSheetEntryWorkingHours / HoursPerDay;
                            }
                            else
                            {
                                entry = new HRTimeSheetEntrysInfo();
                                entry.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                                entry.FK_HRTimeSheetParamID = holidayParam.HRTimeSheetParamID;
                                entry.HRTimeSheetEntryWorkingHours = holidayParam.HRTimeSheetParamValue1 * holidayParam.HRTimeSheetParamValue2;
                                entry.HRTimeSheetEntryWorkingQty = entry.HRTimeSheetEntryWorkingHours / HoursPerDay;
                                entry.HRTimeSheetEntryDate = date;
                                timeSheetEntrys.Add(entry);
                            }
                        }
                        else if (entry == null)
                        {
                            entry = new HRTimeSheetEntrysInfo();
                            entry.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                            entry.FK_HRTimeSheetParamID = holidayParam.HRTimeSheetParamID;
                            entry.HRTimeSheetEntryWorkingHours = holidayParam.HRTimeSheetParamValue1 * holidayParam.HRTimeSheetParamValue2;
                            entry.HRTimeSheetEntryWorkingQty = entry.HRTimeSheetEntryWorkingHours / HoursPerDay;
                            entry.HRTimeSheetEntryDate = date;
                            timeSheetEntrys.Add(entry);
                        }
                    }
                    if (bonusTimeParam != null && timeSheetEntrys != null)
                    {
                        decimal totalWorkingHours = timeSheetEntrys.Where(e => e.HRTimeSheetEntryDate.Date == date).Sum(x => x.HRTimeSheetEntryWorkingHours);

                        //27/05/2019
                        //if (totalWorkingHours >= bonusTimeParam.HRTimeSheetParamBonusTimeConfig)
                        //{
                        //    HRTimeSheetEntrysInfo entry = new HRTimeSheetEntrysInfo();
                        //    entry.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
                        //    entry.FK_HRTimeSheetParamID = bonusTimeParam.HRTimeSheetParamID;
                        //    entry.HRTimeSheetEntryWorkingHours = bonusTimeParam.HRTimeSheetParamValue1 * bonusTimeParam.HRTimeSheetParamValue2;
                        //    entry.HRTimeSheetEntryWorkingQty = entry.HRTimeSheetEntryWorkingHours / HoursPerDay;
                        //    entry.HRTimeSheetEntryFactor = bonusTimeParam.HRTimeSheetParamValue2;
                        //    DateTime bonusFrom = timeSheetEntrys.Where(x => x.HRTimeSheetEntryTo.Date != DateTime.MaxValue.Date).Max(d => d.HRTimeSheetEntryTo);
                        //    if (bonusFrom.Date != DateTime.MaxValue.Date && bonusFrom.Date != DateTime.MinValue.Date)
                        //    {
                        //        entry.HRTimeSheetEntryFrom = bonusFrom;
                        //        entry.HRTimeSheetEntryTo = bonusFrom.AddHours((double)bonusTimeParam.HRTimeSheetParamValue1);
                        //    }
                        //    entry.HRTimeSheetEntryDate = date;
                        //    timeSheetEntrys.Add(entry);
                        //}
                    }
                }

                //Add time sheet entries from leave days
                List<HRLeaveDaysInfo> employeeLeaveDays = leaveDays.Where(ld => ld.FK_HREmployeeID == objEmployeeTimeSheetsInfo.FK_HREmployeeID).ToList();
                foreach (HRLeaveDaysInfo employeeLeaveDay in employeeLeaveDays)
                {
                    HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeLeaveDay.FK_HREmployeeID);
                    HRWorkingShiftsInfo objWorkingShiftsInfo = workingShiftController.
                                            GetWorkingShiftByPayrollFormulaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID).FirstOrDefault();
                    if (objWorkingShiftsInfo != null)
                    {
                        HRTimeSheetEntrysInfo entry = new HRTimeSheetEntrysInfo();
                        entry.FK_HREmployeeID = employeeLeaveDay.FK_HREmployeeID;
                        entry.FK_HRTimeSheetParamID = employeeLeaveDay.FK_HRTimeSheetParamID;
                        HRTimeSheetParamsInfo obj = allTimeSheetParamsList.Where(x => x.HRTimeSheetParamID == employeeLeaveDay.FK_HRTimeSheetParamID).FirstOrDefault();
                        if (obj != null)
                        {
                            entry.HRTimeSheetEntryWorkingHours = obj.HRTimeSheetParamValue1 * obj.HRTimeSheetParamValue2;
                            //entry.HRTimeSheetEntryWorkingQty = entry.HRTimeSheetEntryWorkingHours / HoursPerDay;
                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, entry.HRTimeSheetEntryWorkingHours / HoursPerDay, false, objWorkingShiftsInfo.FK_HRWorkingShiftID);
                            entry.HRTimeSheetEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                        }
                        entry.HRTimeSheetEntryDate = employeeLeaveDay.HRLeaveDayDate;
                        timeSheetEntrys.Add(entry);
                    }
                }
                foreach (var item in timeSheetEntrys)
                {
                    if (item.FK_HRTimeSheetParamID == 0)
                    {
                        item.HRTimeSheetEntryWorkingHours = 0;
                        item.HRTimeSheetEntryWorkingQty = 0;
                    }
                }


                //noi cong cho chuc nang cham cong nhanh [start]
                //objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList = timeSheetEntrys;
                //objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList = timeSheetOTDetails;
                DateTime da = dateFrom;
                while (da.Date <= dateTo.Date)
                {
                    removedEntries = objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList.Where(item => item.HRTimeSheetEntryDate.Date == da).ToList();
                    if (removedEntries != null)
                    {
                        foreach (HRTimeSheetEntrysInfo entry in removedEntries)
                        {
                            objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList.Remove(entry);
                        }
                    }
                    da = da.AddDays(1);
                }
                objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList.AddRange(timeSheetEntrys);
                //noi cong cho chuc nang cham cong nhanh [end]


                foreach (var otfactor in OTFactorlist)
                {
                    HREmployeeTimeSheetOTDetailsInfo objEmployeeTimeSheetOTDetailsInfo = new HREmployeeTimeSheetOTDetailsInfo();
                    objEmployeeTimeSheetOTDetailsInfo.HREmployeeTimeSheetOTDetailFactor = otfactor.HRTimeSheetParamValue2;
                    objEmployeeTimeSheetOTDetailsInfo.HREmployeeTimeSheetOTDetailName = otfactor.HRTimeSheetParamValue2.ToString();
                    foreach (var item in objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList)
                    {
                        HRTimeSheetParamsInfo obj = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(item.FK_HRTimeSheetParamID);
                        if (obj != null && obj.HRTimeSheetParamValue2 == otfactor.HRTimeSheetParamValue2)
                        {
                            objEmployeeTimeSheetOTDetailsInfo.FK_HRTimeSheetParamID = obj.HRTimeSheetParamID;
                            objEmployeeTimeSheetOTDetailsInfo.HREmployeeTimeSheetOTDetailHours += item.HRTimeSheetEntryWorkingHours / obj.HRTimeSheetParamValue2;
                            objEmployeeTimeSheetOTDetailsInfo.HREmployeeTimeSheetOTDetailEntryDate = item.HRTimeSheetEntryDate;
                        }
                    }
                    timeSheetOTDetails.Add(objEmployeeTimeSheetOTDetailsInfo);
                }

                if (employeeID > 0)
                {
                    if (objEmployeeTimeSheetsInfo.FK_HREmployeeID == employeeID)
                    {
                        objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList = timeSheetOTDetails;
                        //Set employee time sheet value
                        entity.SetEmployeeTimeSheetValue(objEmployeeTimeSheetsInfo);
                        //Update time sheet total quantity

                        UpdateTimeSheetTotalQty(objEmployeeTimeSheetsInfo);
                    }

                }
                else
                {
                    objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList = timeSheetOTDetails;
                    //Set employee time sheet value
                    entity.SetEmployeeTimeSheetValue(objEmployeeTimeSheetsInfo);
                    //Update time sheet total quantity

                    UpdateTimeSheetTotalQty(objEmployeeTimeSheetsInfo);
                }

                if (employeeID == null || employeeID == 0)
                {
                    employeeTimeSheets.Add(objEmployeeTimeSheetsInfo);
                }
            }
            if (employeeID == null || employeeID == 0)
            {
                foreach (HREmployeeTimeSheetsInfo item in employeeTimeSheets)
                {
                    HREmployeeTimeSheetsInfo check = entity.EmployeeTimeSheetList.Where(x => x.FK_HREmployeeID == item.FK_HREmployeeID).FirstOrDefault();
                    if (check == null)
                        entity.EmployeeTimeSheetList.Add(item);
                    else
                    {
                        if (entity.EmployeeTimeSheetList.IndexOf(check) >= 0)
                            entity.EmployeeTimeSheetList.RemoveAt(entity.EmployeeTimeSheetList.IndexOf(check));
                        entity.EmployeeTimeSheetList.Add(item);
                    }

                }
                //entity.EmployeeTimeSheetList.Invalidate(employeeTimeSheets);
                employeeTimeSheets.Clear();
            }

            #endregion
            BOSProgressBar.Close();
        }

        #endregion

        /// <summary>
        /// Update the total quantities for the current time sheet
        /// </summary>
        public void UpdateTimeSheetTotalQty()
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in entity.EmployeeTimeSheetList)
            {
                UpdateTimeSheetTotalQty(employeeTimeSheet);
            }
        }

        /// <summary>
        /// Update time sheet total quantity of an employee
        /// </summary>
        /// <param name="employeeTimeSheet">Infomation of employee </param>
        public void UpdateTimeSheetTotalQty(HREmployeeTimeSheetsInfo employeeTimeSheet)
        {
            employeeTimeSheet.HREmployeeTimeSheetWorkingQty = 0;
            employeeTimeSheet.HREmployeeTimeSheetWorkingHour = 0;
            employeeTimeSheet.HREmployeeTimeSheetWorkingSalaryFactor = 0;
            employeeTimeSheet.HREmployeeTimeSheetOTQty = 0;
            employeeTimeSheet.HREmployeeTimeSheetOTSalaryFactor = 0;
            employeeTimeSheet.HREmployeeTimeSheetLeaveQty = 0;
            employeeTimeSheet.HREmployeeTimeSheetLeaveSalaryFactor = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiCheDo = 0;
            employeeTimeSheet.HREmployeeTimeSheetCongTyChoNghi = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiPhepNam = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiLe = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiKhongPhep = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiCoPhep = 0;
            //employeeTimeSheet.HREmployeeTimeSheetWorkDayQty = 0;
            employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiKhongLuong = 0;
            employeeTimeSheet.HREmployeeTimeSheetNghiPhepNamTruCong = 0;
            if (employeeTimeSheet.HREmployeeTimeSheetID == 201)
            {

            }

            decimal timeSheetWorkingQty = 0;
            decimal timeSheetWorkingQtyNight = 0;
            //get hour per day
            HoursPerDay = GetHourPerDay();

            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            List<string> employeeTimeSheetDayList = new List<string> {  employeeTimeSheet.HREmployeeTimeSheetDate1, employeeTimeSheet.HREmployeeTimeSheetDate2,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate3, employeeTimeSheet.HREmployeeTimeSheetDate4,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate5, employeeTimeSheet.HREmployeeTimeSheetDate6,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate7, employeeTimeSheet.HREmployeeTimeSheetDate8,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate9, employeeTimeSheet.HREmployeeTimeSheetDate10,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate11, employeeTimeSheet.HREmployeeTimeSheetDate12,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate13, employeeTimeSheet.HREmployeeTimeSheetDate14,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate15, employeeTimeSheet.HREmployeeTimeSheetDate16,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate17, employeeTimeSheet.HREmployeeTimeSheetDate18,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate19, employeeTimeSheet.HREmployeeTimeSheetDate20,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate21, employeeTimeSheet.HREmployeeTimeSheetDate22,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate23, employeeTimeSheet.HREmployeeTimeSheetDate24,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate25, employeeTimeSheet.HREmployeeTimeSheetDate26,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate27, employeeTimeSheet.HREmployeeTimeSheetDate28,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate29, employeeTimeSheet.HREmployeeTimeSheetDate30,
                                                                        employeeTimeSheet.HREmployeeTimeSheetDate31 };

            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo objWorkingShiftsInfo = new HRWorkingShiftsInfo();

            employeeTimeSheet.HRTimeSheetEntrysList.ForEach(e => e.IsResetEmployeeTimeSheet = false);

            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            List<HROTFactorsInfo> OTFactorsList2 = objOTFactorsController.GetOTFactorByEmployeeID(employeeTimeSheet.FK_HREmployeeID);

            HREmployeeOTsController objEmployeeOTsController = new HREmployeeOTsController();
            List<HREmployeeOTsInfo> listOTs =
                objEmployeeOTsController.GetEmployeeOTList(employeeTimeSheet.FK_HREmployeeID, objTimeSheetsInfo.HRTimeSheetFromDate, objTimeSheetsInfo.HRTimeSheetToDate);
            if (listOTs != null && listOTs.Count > 0)
            {
                List<HREmployeeOTsInfo> listOT2 = new List<HREmployeeOTsInfo>();
                listOTs.ForEach(o =>
                {
                    if (o.HREmployeeOTDate.Date < o.HREmployeeOTDateEnd.Date)
                    {
                        DateTime dateEmployeeOT = o.HREmployeeOTDate.Date;
                        while (dateEmployeeOT < o.HREmployeeOTDateEnd.Date)
                        {
                            HREmployeeOTsInfo objEmployeeOTsInfo = new HREmployeeOTsInfo();
                            objEmployeeOTsInfo = (HREmployeeOTsInfo)o.Clone();
                            objEmployeeOTsInfo.HREmployeeOTDate = dateEmployeeOT.AddDays(1);
                            objEmployeeOTsInfo.HREmployeeOTFromDate = dateEmployeeOT.AddDays(1);

                            listOT2.Add(objEmployeeOTsInfo);
                            dateEmployeeOT = dateEmployeeOT.AddDays(1);
                        }
                    }
                });

                if (listOT2 != null && listOT2.Count > 0)
                {
                    listOT2.ForEach(o =>
                    {
                        listOTs.Add(o);
                    });
                }
            }

            bool checkOTMeal = false;

            foreach (var item in employeeTimeSheet.HREmployeeTimeSheetOTDetailsList)
            {
                item.HREmployeeTimeSheetOTDetailHours = 0;
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("HRTimeSheetEntryDate", typeof(string));
            dt.Columns.Add("HRTimeSheetParamNo", typeof(string));
            dt.Columns.Add("HRTimeSheetParamID", typeof(string));
            dt.Columns.Add("HRTimeSheetParamValue1", typeof(decimal));
            dt.Columns.Add("HRTimeSheetParamValue2", typeof(decimal));
            dt.Columns.Add("HRTimeSheetEntryWorkingHours", typeof(decimal));
            int numDays = NumOfDayInMonth();

            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeTimeSheet.FK_HREmployeeID);

            for (int i = 0; i < numDays; i++)
            {
                checkOTMeal = false;
                if (i > employeeTimeSheetDayList.Count - 1) continue;
                string[] paramNumbers = employeeTimeSheetDayList[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                DateTime currentDate = objTimeSheetsInfo.HRTimeSheetFromDate.AddDays(i);
                decimal mainEntryValue = 0;

                if (listOTs != null && OTFactorsList2.Count() > 0)
                {
                    listOTs.ForEach(o =>
                    {
                        if (o.HREmployeeOTFromDate.Date == currentDate.Date && paramNumbers.Length == 0 && o.HROverTimeHaveMeal)
                        {
                            employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff++;
                        }
                        else if (o.HREmployeeOTFromDate.Date == currentDate.Date && paramNumbers.Length > 0 && o.HROverTimeHaveMeal)
                        {
                            checkOTMeal = true;
                        }
                    });
                }

                for (int j = 0; j < paramNumbers.Length; j++)
                {
                    string paramNo = paramNumbers[j].Trim();

                    HRTimeSheetParamsInfo parama = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamNo == paramNo).FirstOrDefault();
                    HRTimeSheetParamsInfo param = new HRTimeSheetParamsInfo();
                    if (parama != null)
                    {
                        BOSUtil.CopyObject(parama, param);
                        param.HRTimeSheetParamID = parama.HRTimeSheetParamID;
                    }
                    if (param != null)
                    {
                        HRTimeSheetEntrysInfo timeSheetEntry = employeeTimeSheet.HRTimeSheetEntrysList.Where(e => e.HRTimeSheetEntryDate.Date == currentDate.Date &&
                                                                                                                    e.FK_HRTimeSheetParamID == param.HRTimeSheetParamID &&
                                                                                                                    //e.FK_HRTimeSheetParamID == param.HRTimeSheetParamID &&
                                                                                                                    employeeTimeSheet.FK_HREmployeeID == e.FK_HREmployeeID)
                                                                                                              .FirstOrDefault();

                        if (timeSheetEntry == null)
                        {
                            timeSheetEntry = new HRTimeSheetEntrysInfo();
                            if (param.HRTimeSheetParamType == TimeSheetParamType.Day.ToString())
                            {
                                timeSheetEntry.HRTimeSheetEntryWorkingQty = param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                timeSheetEntry.HRTimeSheetEntryWorkingHours = timeSheetEntry.HRTimeSheetEntryWorkingQty * HoursPerDay;
                            }
                            else
                            {
                                timeSheetEntry.HRTimeSheetEntryWorkingHours = param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                timeSheetEntry.HRTimeSheetEntryWorkingQty = timeSheetEntry.HRTimeSheetEntryWorkingHours / HoursPerDay;
                            }

                            if (objEmployeesInfo != null)
                            {
                                objWorkingShiftsInfo = (HRWorkingShiftsInfo)workingShiftController.GetFirstWorkingShiftByPayrollFormulaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
                            }
                            if (objWorkingShiftsInfo != null)
                            {
                                if (objWorkingShiftsInfo.HRWorkingShiftNight
                                    || objWorkingShiftsInfo.HRWorkingShiftToTime.TimeOfDay < objWorkingShiftsInfo.HRWorkingShiftFromTime.TimeOfDay)
                                {
                                    timeSheetEntry.IsNightWorking = true;
                                }
                            }

                            employeeTimeSheet.HRTimeSheetEntrysList.Add(timeSheetEntry);
                        }
                        timeSheetEntry.FK_HREmployeeTimeSheetID = employeeTimeSheet.HREmployeeTimeSheetID;
                        timeSheetEntry.FK_HRTimeSheetID = employeeTimeSheet.FK_HRTimeSheetID;
                        timeSheetEntry.FK_HREmployeeID = employeeTimeSheet.FK_HREmployeeID;
                        timeSheetEntry.FK_HRTimeSheetParamID = param.HRTimeSheetParamID;
                        timeSheetEntry.HRTimeSheetEntryDate = currentDate;
                        timeSheetEntry.HRTimeSheetEntryFactor = param.HRTimeSheetParamValue2;
                        timeSheetEntry.IsResetEmployeeTimeSheet = true;

                        List<HROTFactorsInfo> factors = GetOTFactors(employeeTimeSheet, timeSheetEntry, param);

                        if (param.HRTimeSheetParamType == TimeSheetParamType.Day.ToString() ||
                            param.HRTimeSheetParamType == TimeSheetParamType.Hour.ToString())
                        {
                            if (param.IsOTCalculated)
                            {
                                checkOTMeal = false;
                                //HieuNT [Ưu tiên lấy hệ số tăng ca theo HREmployeeOTFactor]
                                if (timeSheetEntry.IsOTFactor)
                                {
                                    timeSheetEntry.HRTimeSheetEntryWorkingHours = param.HRTimeSheetParamValue1 * timeSheetEntry.HRTimeSheetEntryFactor;
                                    timeSheetEntry.HRTimeSheetEntryWorkingQty = timeSheetEntry.HRTimeSheetEntryWorkingHours / HoursPerDay;

                                    employeeTimeSheet.HREmployeeTimeSheetOTQty += param.HRTimeSheetParamValue1;
                                    employeeTimeSheet.HREmployeeTimeSheetOTSalaryFactor += param.HRTimeSheetParamValue1 * timeSheetEntry.HRTimeSheetEntryFactor;
                                    employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff += timeSheetEntry.HRTimeSheetEntryPermissionOTDaysOff;
                                    foreach (var item in employeeTimeSheet.HREmployeeTimeSheetOTDetailsList)
                                    {
                                        if (item.HREmployeeTimeSheetOTDetailFactor == timeSheetEntry.HRTimeSheetEntryFactor)
                                        {
                                            item.HREmployeeTimeSheetOTDetailHours += param.HRTimeSheetParamValue1;
                                        }
                                    }
                                }
                                else
                                    if (factors != null && factors.Count != 0)
                                {

                                    timeSheetEntry.HRTimeSheetEntryWorkingHours = param.HRTimeSheetParamValue1 * factors[0].HROTFactorValue;
                                    timeSheetEntry.HRTimeSheetEntryWorkingQty = timeSheetEntry.HRTimeSheetEntryWorkingHours / HoursPerDay;

                                    employeeTimeSheet.HREmployeeTimeSheetOTQty += param.HRTimeSheetParamValue1;
                                    employeeTimeSheet.HREmployeeTimeSheetOTSalaryFactor += param.HRTimeSheetParamValue1 * factors[0].HROTFactorValue;
                                    employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff += timeSheetEntry.HRTimeSheetEntryPermissionOTDaysOff;

                                    foreach (var item in employeeTimeSheet.HREmployeeTimeSheetOTDetailsList)
                                    {
                                        if (item.HREmployeeTimeSheetOTDetailFactor == factors[0].HROTFactorValue)
                                        {
                                            item.HREmployeeTimeSheetOTDetailHours += param.HRTimeSheetParamValue1;
                                        }
                                    }
                                }
                                else
                                {
                                    timeSheetEntry.HRTimeSheetEntryWorkingHours = param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                    timeSheetEntry.HRTimeSheetEntryWorkingQty = timeSheetEntry.HRTimeSheetEntryWorkingHours / HoursPerDay;

                                    employeeTimeSheet.HREmployeeTimeSheetOTQty += param.HRTimeSheetParamValue1;
                                    employeeTimeSheet.HREmployeeTimeSheetOTSalaryFactor += param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;

                                    employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff += timeSheetEntry.HRTimeSheetEntryPermissionOTDaysOff;

                                    foreach (var item in employeeTimeSheet.HREmployeeTimeSheetOTDetailsList)
                                    {
                                        if (item.HREmployeeTimeSheetOTDetailFactor == param.HRTimeSheetParamValue2)
                                        {
                                            item.HREmployeeTimeSheetOTDetailHours += param.HRTimeSheetParamValue1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                mainEntryValue = param.HRTimeSheetParamValue1;
                                decimal totalOTTime = factors.Sum(f => f.OTTime);
                                employeeTimeSheet.HREmployeeTimeSheetWorkingQty += param.HRTimeSheetParamValue1 - totalOTTime;
                                employeeTimeSheet.HREmployeeTimeSheetWorkingSalaryFactor += (param.HRTimeSheetParamValue1 - totalOTTime) * param.HRTimeSheetParamValue2;
                                employeeTimeSheet.HREmployeeTimeSheetOTQty += factors.Sum(f => f.OTTime * f.HROTFactorValue);
                                employeeTimeSheet.HREmployeeTimeSheetOTSalaryFactor += factors.Sum(f => f.OTTime * f.HROTFactorValue) * param.HRTimeSheetParamValue2;
                                if (timeSheetEntry.IsNightWorking)
                                {
                                    timeSheetWorkingQtyNight += param.HRTimeSheetParamValue1 - totalOTTime;
                                }
                                else
                                {
                                    timeSheetWorkingQty += param.HRTimeSheetParamValue1 - totalOTTime;
                                }
                            }
                            //dt.Rows.Add(new Object[] { currentDate
                            //        ,paramNo, param.HRTimeSheetParamID,param.HRTimeSheetParamValue1, param.HRTimeSheetParamValue2,timeSheetEntry.HRTimeSheetEntryWorkingHours});
                        }
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.Common.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.LE.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.NKP.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCP1P2.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCP.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.PN.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCL.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.PN1P2.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.NKP1P2.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.NKP1P2.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.TC.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.TS.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.PN1P2.ToString()) ||
                        //    param.HRTimeSheetParamType.Equals(TimeSheetParamType.LeavedaySpecial.ToString()))
                        //{
                        //    if (objTimeSheetsInfo.HRTimeSheetType.Equals(TimeSheetType.Day.ToString()))
                        //    {
                        //        employeeTimeSheet.HREmployeeTimeSheetLeaveQty += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //        employeeTimeSheet.HREmployeeTimeSheetLeaveSalaryFactor += (param.HRTimeSheetParamValue1 / HoursPerDay) * param.HRTimeSheetParamValue2;
                        //    }
                        //    if (objTimeSheetsInfo.HRTimeSheetType.Equals(TimeSheetType.Hour.ToString()))
                        //    {
                        //        employeeTimeSheet.HREmployeeTimeSheetLeaveQty += param.HRTimeSheetParamValue1;
                        //        employeeTimeSheet.HREmployeeTimeSheetLeaveSalaryFactor += (param.HRTimeSheetParamValue1) * param.HRTimeSheetParamValue2;
                        //    }
                        //}
                        else
                        {
                            if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.LE.ToString()))
                            {
                                employeeTimeSheet.HREmployeeTimeSheetNghiLe += param.HRTimeSheetParamValue1 / HoursPerDay;
                            }
                            //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.NKP.ToString()) 
                            //    || param.HRTimeSheetParamType.Equals(TimeSheetParamType.NKP1P2.ToString()))
                            //{
                            //    employeeTimeSheet.HREmployeeTimeSheetNghiKhongPhep += param.HRTimeSheetParamValue1 / HoursPerDay;
                            //}
                            else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCP.ToString())
                                || param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCP1P2.ToString()))
                            {
                                employeeTimeSheet.HREmployeeTimeSheetNghiCoPhep += param.HRTimeSheetParamValue1 / HoursPerDay;
                            }
                            else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.PN.ToString())
                                || param.HRTimeSheetParamType.Equals(TimeSheetParamType.PN1P2.ToString()))
                            {
                                employeeTimeSheet.HREmployeeTimeSheetNghiPhepNam += param.HRTimeSheetParamValue1 / HoursPerDay;
                                employeeTimeSheet.HREmployeeTimeSheetNghiPhepNamTruCong += param.HRTimeSheetParamValue1 / HoursPerDay;
                            }
                            else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.CTCN.ToString()))
                            {
                                employeeTimeSheet.HREmployeeTimeSheetCongTyChoNghi += param.HRTimeSheetParamValue1 / HoursPerDay;
                            }
                            else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCDO.ToString()))
                            {
                                employeeTimeSheet.HREmployeeTimeSheetNghiCheDo += param.HRTimeSheetParamValue1 / HoursPerDay;
                            }
                            else if (param.HRTimeSheetParamValue2 == 0)
                            {
                                employeeTimeSheet.HREmployeeTimeSheetNghiKhongLuong += param.HRTimeSheetParamValue1 / HoursPerDay;
                            }
                        }
                    }
                }
                if (checkOTMeal)
                {
                    employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff++;
                }
            }
            if (objEmployeesInfo != null)
            {
                if (objEmployeesInfo.HREmployeeStatusCombo == EmployeeStatus.Resigned.ToString()
                    && objEmployeesInfo.HREmployeeStopWorkingDate.Date >= objTimeSheetsInfo.HRTimeSheetFromDate.Date
                    && objEmployeesInfo.HREmployeeStopWorkingDate.Date <= objTimeSheetsInfo.HRTimeSheetToDate.Date)
                {
                    employeeTimeSheet.HREmployeeTimeSheetNghiPhepNam = CalculatorLeaveDay(objEmployeesInfo);
                }
            }

            employeeTimeSheet.HREmployeeTimeSheetWorkingQty = RoundingTimeSheet(timeSheetWorkingQty) + RoundingTimeSheet(timeSheetWorkingQtyNight);

            HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();
            decimal congChuan = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objTimeSheetsInfo.HRTimeSheetDate.Month);

            employeeTimeSheet.HREmployeeTimeSheetNghiKhongPhep = congChuan - employeeTimeSheet.HREmployeeTimeSheetWorkingQty -
                                                                            employeeTimeSheet.HREmployeeTimeSheetNghiLe -
                                                                            employeeTimeSheet.HREmployeeTimeSheetNghiPhepNamTruCong -
                                                                            employeeTimeSheet.HREmployeeTimeSheetCongTyChoNghi -
                                                                            employeeTimeSheet.HREmployeeTimeSheetNghiCheDo -
                                                                            employeeTimeSheet.HREmployeeTimeSheetNghiCoPhep -
                                                                            employeeTimeSheet.HREmployeeTimeSheetNghiKhongLuong;

            //Làm tròn số
            employeeTimeSheet.HREmployeeTimeSheetNghiKhongPhep = RoundingTimeSheet(employeeTimeSheet.HREmployeeTimeSheetNghiKhongPhep);

            employeeTimeSheet.HRTimeSheetEntrysList = employeeTimeSheet.HRTimeSheetEntrysList.Where(e => e.IsResetEmployeeTimeSheet).ToList();
            entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Check day is holiday or not
        /// </summary>
        /// <param name="dayOfMonth">Day of the month</param>
        /// <returns>true if day is holiday</returns>
        public bool CheckHoliday(DateTime dayOfMonth)
        {
            return BOSApp.IsHoliday(dayOfMonth);
        }

        /// <summary>
        /// Get the overtime factors relating to a time sheet entry
        /// </summary>
        /// <param name="employeeTimeSheet">Time sheet of the employee that the entry belongs to</param>
        /// <param name="entry">Time sheet entry</param>
        /// <param name="param">Time sheet param associates with the entry</param>
        /// <returns>List of factors</returns>
        public List<HROTFactorsInfo> GetOTFactors(HREmployeeTimeSheetsInfo employeeTimeSheet, HRTimeSheetEntrysInfo entry, HRTimeSheetParamsInfo param)
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            decimal holidayFactorValue = 0;
            HROTFactorsController objOTFactorsController = new HROTFactorsController();

            List<HROTFactorsInfo> workingDayFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.WorkingDay.ToString() &&
                                                                                f.HREmployeeID == employeeTimeSheet.FK_HREmployeeID &&
                                                                                f.HROTFactorValue == param.HRTimeSheetParamValue2).ToList();

            List<HROTFactorsInfo> holidayFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.Holiday.ToString() &&
                                                                                f.HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
            List<HROTFactorsInfo> endOfWeekFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.EndOfWeek.ToString() &&
                                                                                f.HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();

            if (!BOSApp.IsEndOfWeek(entry.HRTimeSheetEntryDate.DayOfWeek))
            {
                if (workingDayFactors.Count > 0)
                {
                    holidayFactorValue = workingDayFactors[0].HROTFactorValue;
                }
            }
            if (BOSApp.IsEndOfWeek(entry.HRTimeSheetEntryDate.DayOfWeek))
            {
                if (endOfWeekFactors.Count > 0)
                {
                    holidayFactorValue = endOfWeekFactors[0].HROTFactorValue;
                }
            }
            if (CheckHoliday(entry.HRTimeSheetEntryDate))
            {
                if (holidayFactors.Count > 0)
                {
                    // Get max holiday factor value if day is end of week and holiday
                    if (holidayFactors[0].HROTFactorValue > holidayFactorValue)
                    {
                        holidayFactorValue = holidayFactors[0].HROTFactorValue;
                    }
                }
            }

            //Add end of week and holiday factor to the returned result
            List<HROTFactorsInfo> result = new List<HROTFactorsInfo>();
            if (holidayFactorValue > 0)
            {
                HROTFactorsInfo holidayFactor = new HROTFactorsInfo();
                if (param.IsOTCalculated)
                    holidayFactor.OTTime = param.HRTimeSheetParamValue1;
                else
                {
                    holidayFactor.OTTime = param.HRTimeSheetParamValue1 * HoursPerDay;
                    if (BOSApp.IsEndOfWeek(entry.HRTimeSheetEntryDate.DayOfWeek) || CheckHoliday(entry.HRTimeSheetEntryDate))
                        param.IsOTCalculated = true;
                }
                holidayFactor.HROTFactorValue = holidayFactorValue;
                result.Add(holidayFactor);
            }

            //Add working factor in case the time sheet is hour-calculated
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)entity.MainObject;
            decimal startHour = employeeTimeSheet.HREmployeeStartWorkingTime.Hour;
            decimal endHour = employeeTimeSheet.HREmployeeEndWorkingTime.Hour;
            if (param.HRTimeSheetParamValue1 > employeeTimeSheet.HREmployeeHoursPerDay)
            {
                endHour += param.HRTimeSheetParamValue1 - employeeTimeSheet.HREmployeeHoursPerDay;
            }
            if (timeSheet.HRTimeSheetType == TimeSheetType.Hour.ToString())
            {
                //List<HREmployeeOTFactorsInfo> workingFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.WorkingDay.ToString() &&
                //                                                                    f.FK_HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();
                List<HROTFactorsInfo> workingFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.WorkingDay.ToString() &&
                                                                                    f.HREmployeeID == employeeTimeSheet.FK_HREmployeeID).ToList();


                foreach (HROTFactorsInfo workingFactor in workingFactors)
                {
                    decimal factorFromHour = workingFactor.HROTFactorFromTime.Hour;
                    decimal factorToHour = workingFactor.HROTFactorToTime.Hour;
                    if (factorToHour == 0)
                    {
                        factorToHour = 24;
                    }

                    if (workingFactor.HROTFactorValue > holidayFactorValue)
                    {
                        if (endHour > factorToHour)
                        {
                            if (startHour <= factorToHour)
                            {
                                workingFactor.OTTime = factorToHour - Math.Max(factorFromHour, startHour);
                                result.Add(workingFactor);
                            }
                        }
                        else if (endHour > factorFromHour)
                        {
                            workingFactor.OTTime = endHour - Math.Max(factorFromHour, startHour);
                            result.Add(workingFactor);
                        }
                    }
                }
            }

            return result;
        }

        private HREmployeeTimeSheetsInfo SetEmployeeTimeSheetInfoFromEmployee(HREmployeesInfo objEmployeesInfo)
        {
            HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = new HREmployeeTimeSheetsInfo();

            if (objEmployeesInfo != null)
            {
                objEmployeeTimeSheetsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                objEmployeeTimeSheetsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                objEmployeeTimeSheetsInfo.HRDepartmentName = objEmployeesInfo.HRDepartmentName;
                objEmployeeTimeSheetsInfo.HRDepartmentRoomName = objEmployeesInfo.HRDepartmentRoomName;
                objEmployeeTimeSheetsInfo.HRDepartmentRoomGroupItemName = objEmployeesInfo.HRDepartmentRoomGroupItemName;
                objEmployeeTimeSheetsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                objEmployeeTimeSheetsInfo.HRLevelName = objEmployeesInfo.HRLevelName;
                objEmployeeTimeSheetsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                objEmployeeTimeSheetsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                objEmployeeTimeSheetsInfo.HREmployeeStartWorkingTime = objEmployeesInfo.HREmployeeStartWorkingTime;
                objEmployeeTimeSheetsInfo.HREmployeeEndWorkingTime = objEmployeesInfo.HREmployeeEndWorkingTime;
                objEmployeeTimeSheetsInfo.HREmployeeHoursPerDay = objEmployeesInfo.HREmployeeHoursPerDay;
                objEmployeeTimeSheetsInfo.HRDepartmentRoomGroupTeamItemName = objEmployeesInfo.HRDepartmentRoomGroupTeamItemName;
            }

            return objEmployeeTimeSheetsInfo;

        }

        private decimal GetHourPerDay()
        {
            decimal hourPerDay = 0;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            string objConfigValuesInfo = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.HoursPerDay.ToString()).ToString();
            if (objConfigValuesInfo != null)
            {
                hourPerDay = decimal.Parse(objConfigValuesInfo);
            }
            return hourPerDay;
        }

        private List<HRTimeSheetEntrysInfo> AddTimeSheetEntryFromEmployeeWorkSchedule()
        {
            List<HRTimeSheetEntrysInfo> timeEntries = new List<HRTimeSheetEntrysInfo>();

            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)CurrentModuleEntity.MainObject;

            DateTime dateFrom = timeSheet.HRTimeSheetFromDate;
            DateTime dateTo = timeSheet.HRTimeSheetToDate;

            HREmployeesController objEmployeesController = new HREmployeesController();

            //get employee's work schedule
            HREmployeeWorkSchedulesController objEmployeeWorkSchedulesController = new HREmployeeWorkSchedulesController();
            List<HREmployeeWorkSchedulesInfo> employeeWorkScheduleList = objEmployeeWorkSchedulesController.GetByEmployeeID(dateFrom, dateTo, null);

            foreach (var employeeWorkSchedule in employeeWorkScheduleList)
            {
                //if (!timeEntries.Exists(p => p.FK_HREmployeeID == employeeWorkSchedule.FK_HREmployeeID))
                //{
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeWorkSchedule.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    //loop from EmployeeWorkScheduleDateFrom to EmployeeWorkScheduleDateTo to date to create time sheet entries for the employee
                    for (DateTime dt = employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.Date;
                                    dt < employeeWorkSchedule.HREmployeeWorkScheduleDateTo; dt = dt.AddDays(1))
                    {
                        if (!BOSApp.IsEndOfWeek(dt.Date.DayOfWeek))
                        {
                            HRTimeSheetEntrysInfo obj = new HRTimeSheetEntrysInfo();
                            obj.FK_HREmployeeID = employeeWorkSchedule.FK_HREmployeeID;
                            obj.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            obj.HRTimeSheetEntryDate = dt.Date;
                            if (dt.Date == employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.Date)
                            {
                                obj.HRTimeSheetEntryFrom = employeeWorkSchedule.HREmployeeWorkScheduleDateFrom;
                                if (employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Date == employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.Date)
                                    obj.HRTimeSheetEntryTo = DateTime.ParseExact(employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.ToString("dd/MM/yyyy") + " " +
                                                employeeWorkSchedule.HREmployeeWorkScheduleDateTo.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                                else
                                    obj.HRTimeSheetEntryTo = employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                            }
                            else
                            {
                                obj.HRTimeSheetEntryFrom = dt;
                                if (dt.Date == employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Date)
                                    obj.HRTimeSheetEntryTo = dt.AddHours(employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Hour)
                                                                .AddMinutes(employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Minute)
                                                                .AddSeconds(employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Second);
                                else
                                    obj.HRTimeSheetEntryTo = dt.AddHours(23).AddMinutes(59).AddSeconds(59);
                            }
                            timeEntries.Add(obj);
                        }
                    }
                }
                //}
            }

            return timeEntries;
        }
        private HRWorkingShiftsInfo GetWorkingShiftsInfo(int employeePayrollFormulaID, DateTime? date, DateTime dateToCheck, int maxMinuteLate)
        {
            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            List<HRWorkingShiftsInfo> workingShiftList = objWorkingShiftsController.GetAllData(employeePayrollFormulaID);
            HRWorkingShiftsInfo objWorkingShiftsInfo = null;
            if (workingShiftList.Count > 0)
            {
                objWorkingShiftsInfo = workingShiftList[0];
                if (date != null)
                {
                    bool re = false;
                    workingShiftList = workingShiftList.OrderByDescending(p => p.HRWorkingShiftDayOffWeek).ToList();
                    foreach (var objWorkingShift in workingShiftList)
                    {
                        /*
                         * Thứ trong ca làm việc -  Nếu không chọn tất cả và không chọn 
                         * Thứ trong ca làm việc khác với thứ trong máy chấm công
                         */
                        if (objWorkingShift.HRWorkingShiftDayOffWeek == string.Empty)
                            objWorkingShift.HRWorkingShiftDayOffWeek = WorkingShiftDayOffWeek.All.ToString();
                        if (objWorkingShift.HRWorkingShiftDayOffWeek != WorkingShiftDayOffWeek.All.ToString()
                            && (int)dateToCheck.DayOfWeek != (int)(WorkingShiftDayOffWeek)Enum.Parse(typeof(WorkingShiftDayOffWeek), objWorkingShift.HRWorkingShiftDayOffWeek))
                        {
                            continue;
                        }
                        int time1 = int.Parse(objWorkingShift.HRWorkingShiftFromTime.ToString("HHmm"));
                        time1 = (time1 / 100) * 60 + time1 % 100;
                        int time2 = int.Parse(date.Value.ToString("HHmm"));
                        time2 = (time2 / 100) * 60 + time2 % 100;
                        //(time2 < time1 && time2 > time1 - 60) : Đi sớm và phải sớm hơn 1 tiếng trở lên
                        if ((time2 < time1 && time2 > time1 - maxMinuteLate))
                        {
                            objWorkingShiftsInfo = objWorkingShift;
                            re = true;
                            break;
                        }
                    }
                    if (!re)
                    {
                        foreach (var objWorkingShift in workingShiftList)
                        {
                            /*
                         * Thứ trong ca làm việc -  Nếu không chọn tất cả 
                         * Thứ trong ca làm việc khác với thứ trong máy chấm công
                         */
                            if (objWorkingShift.HRWorkingShiftDayOffWeek == string.Empty)
                                objWorkingShift.HRWorkingShiftDayOffWeek = WorkingShiftDayOffWeek.All.ToString();
                            if (objWorkingShift.HRWorkingShiftDayOffWeek != WorkingShiftDayOffWeek.All.ToString()
                                && (int)dateToCheck.DayOfWeek != (int)(WorkingShiftDayOffWeek)Enum.Parse(typeof(WorkingShiftDayOffWeek), objWorkingShift.HRWorkingShiftDayOffWeek))
                            {
                                continue;
                            }
                            int time1 = int.Parse(objWorkingShift.HRWorkingShiftFromTime.ToString("HHmm"));
                            time1 = (time1 / 100) * 60 + time1 % 100;
                            int time2 = int.Parse(date.Value.ToString("HHmm"));
                            time2 = (time2 / 100) * 60 + time2 % 100;
                            //((time2 > time1 && time1 > time2 - 60)) : Đi muộn và đi muộn không quá 60p
                            if ((time2 > time1 && time1 > time2 - maxMinuteLate))
                            {
                                objWorkingShiftsInfo = objWorkingShift;
                                re = true;
                                break;
                            }
                        }
                    }
                    if (!re)
                    {
                        workingShiftList = workingShiftList.OrderBy(p => p.HRWorkingShiftFromTime).ToList();
                        foreach (var objWorkingShift in workingShiftList)
                        {
                            if (objWorkingShift.HRWorkingShiftDayOffWeek == string.Empty)
                                objWorkingShift.HRWorkingShiftDayOffWeek = WorkingShiftDayOffWeek.All.ToString();
                            //Ngày trong ca làm việc # ngày của chấm công
                            if ((int)dateToCheck.DayOfWeek != (int)(WorkingShiftDayOffWeek)Enum.Parse(typeof(WorkingShiftDayOffWeek), objWorkingShift.HRWorkingShiftDayOffWeek))
                            {
                                continue;
                            }
                            int time1 = int.Parse(objWorkingShift.HRWorkingShiftFromTime.ToString("HHmm"));
                            time1 = (time1 / 100) * 60 + time1 % 100;
                            int time2 = int.Parse(date.Value.ToString("HHmm"));
                            time2 = (time2 / 100) * 60 + time2 % 100;
                            //Đi sớm or đi đúng giờ
                            if (time2 <= time1)
                            {
                                objWorkingShiftsInfo = objWorkingShift;
                                re = true;
                                break;
                            }
                        }
                    }
                    if (!re)
                    {
                        workingShiftList = workingShiftList.OrderBy(p => p.HRWorkingShiftFromTime).ToList();
                        foreach (var objWorkingShift in workingShiftList)
                        {
                            /*
                              * Thứ trong ca làm việc -  Nếu không chọn tất cả 
                            */
                            if (objWorkingShift.HRWorkingShiftDayOffWeek != WorkingShiftDayOffWeek.All.ToString())
                            {
                                continue;
                            }
                            int time1 = int.Parse(objWorkingShift.HRWorkingShiftFromTime.ToString("HHmm"));
                            time1 = (time1 / 100) * 60 + time1 % 100;
                            int time2 = int.Parse(date.Value.ToString("HHmm"));
                            time2 = (time2 / 100) * 60 + time2 % 100;
                            if (time2 <= time1) //Đi sớm or đi đúng giờ
                            {
                                objWorkingShiftsInfo = objWorkingShift;
                                re = true;
                                break;
                            }
                        }
                    }
                }
            }
            return objWorkingShiftsInfo;
        }
        public decimal CalculatorLeaveDay(HREmployeesInfo objEmployeesInfo)
        {
            HRTimeSheetEntities entity = (HRTimeSheetEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objHRTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            HREmployeeLRegsController objEmployeeLRegsController = new HREmployeeLRegsController();
            HREmployeeLRegsInfo objEmployeeLRegsInfo = new HREmployeeLRegsInfo();
            objEmployeeLRegsInfo = (HREmployeeLRegsInfo)objEmployeeLRegsController.GetEmployeeLRegByEmployeeIDAndYear(objEmployeesInfo.HREmployeeID, objEmployeesInfo.HREmployeeStopWorkingDate.AddYears(-1).Year);

            DateTime dtFirstOfYear = new DateTime(objEmployeesInfo.HREmployeeStopWorkingDate.Year, 1, 1);
            DateTime dtEndOfYear = new DateTime(objEmployeesInfo.HREmployeeStopWorkingDate.Year, 12, 31).AddYears(-1);
            decimal result = 0;
            decimal departmentRoomLeaveDay = 0;
            decimal otherLeaveDay = 0;
            decimal expDay = 0;
            decimal dbSothanglamviec = 0, dbDftDay = 0;

            if (objEmployeeLRegsInfo != null)
            {
                result += objEmployeeLRegsInfo.HREmployeeLRegRemainDays;
            }

            //phép cộng theo khu vực khác
            DataSet dsAnnualLeaveOther = new HRDepartmentRoomLeaveDayConfigsController().GetAllDataByForeignColumn("FK_HRDepartmentRoomID", objEmployeesInfo.FK_HRDepartmentRoomID);
            if (dsAnnualLeaveOther != null && dsAnnualLeaveOther.Tables.Count > 0 && dsAnnualLeaveOther.Tables[0].Rows.Count > 0)
            {
                List<HRDepartmentRoomLeaveDayConfigsInfo> lstAnnualLeaveOther = (List<HRDepartmentRoomLeaveDayConfigsInfo>)new HRDepartmentRoomLeaveDayConfigsController().GetListFromDataSet(dsAnnualLeaveOther);

                lstAnnualLeaveOther.ForEach(o =>
                {
                    if (o.FK_HRDepartmentRoomID > 0 && o.FK_HRDepartmentRoomID == objEmployeesInfo.FK_HRDepartmentRoomID)
                    {
                        departmentRoomLeaveDay = o.HRDepartmentRoomLeaveDayConfigQty; //dòng nào thỏa điều kiện cuối cùng nhất sẽ lấy
                    }
                });
            }

            //phép cộng năm khác
            HROtherLeaveDayConfigsController objOtherLeaveDayConfigsController = new HROtherLeaveDayConfigsController();
            List<HROtherLeaveDayConfigsInfo> lstOtherLeaveDayConfigs = (List<HROtherLeaveDayConfigsInfo>)objOtherLeaveDayConfigsController.GetListFromDataSet(objOtherLeaveDayConfigsController.GetAllObjects());
            lstOtherLeaveDayConfigs.Where(o => o.FK_HREmployeeID == objEmployeesInfo.HREmployeeID && o.FK_HRDepartmentID == objEmployeesInfo.FK_HRDepartmentID && o.FK_HRLevelID == objEmployeesInfo.FK_HRLevelID && o.HROtherLeaveDayConfigQty > 0).ToList().ForEach(x =>
            {
                otherLeaveDay = x.HROtherLeaveDayConfigQty;
            });

            //Tính phép thâm niên
            if (objEmployeesInfo.HREmployeeStartWorkingDate != null)
            {
                dbSothanglamviec = SoThangLamviec(dtEndOfYear, objEmployeesInfo.HREmployeeStartWorkingDate);
                decimal dbExpYear = dbSothanglamviec / 12;
                if (dbExpYear > 0)
                {
                    DataSet ds = new HRSeniorityLeaveDayConfigsController().GetAllObjects();
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        List<HRSeniorityLeaveDayConfigsInfo> lst = (List<HRSeniorityLeaveDayConfigsInfo>)new HRSeniorityLeaveDayConfigsController().GetListFromDataSet(ds);
                        foreach (HRSeniorityLeaveDayConfigsInfo item in lst)
                        {
                            if ((dbExpYear >= item.HRSeniorityLeaveDayConfigFrom) && (dbExpYear <= item.HRSeniorityLeaveDayConfigTo || item.HRSeniorityLeaveDayConfigTo == 0))
                            {
                                expDay = item.HRSeniorityLeaveDayConfigQty;
                                break;
                            }
                        }
                    }
                }
            }

            //Tính lại tổng ngày phép được hưởng trong năm
            if (objEmployeesInfo.HREmployeeStartWorkingDate != DateTime.MaxValue)
            {
                //năm vào làm = năm tính phép
                if (objEmployeesInfo.HREmployeeStartWorkingDate.Year == objEmployeesInfo.HREmployeeStopWorkingDate.Year)
                {
                    dbDftDay = SoThangLamviec(objEmployeesInfo.HREmployeeStopWorkingDate, objEmployeesInfo.HREmployeeStartWorkingDate);
                }
                else if (objEmployeesInfo.HREmployeeStartWorkingDate.Year < objEmployeesInfo.HREmployeeStopWorkingDate.Year)
                {
                    dbDftDay = SoThangLamviec(objEmployeesInfo.HREmployeeStopWorkingDate, new DateTime(objEmployeesInfo.HREmployeeStopWorkingDate.Year, 1, 1));
                }
            }

            //Số ngày nghỉ trong năm
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            decimal ngayNghi = (decimal)objLeaveDaysController.GetSumPNLeavedays(objEmployeesInfo.HREmployeeID, objHRTimeSheetsInfo.HRTimeSheetToDate, objEmployeesInfo.HREmployeeStopWorkingDate);
            result += departmentRoomLeaveDay + dbDftDay + expDay + otherLeaveDay - ngayNghi;

            return result;
        }

        public int SoThangLamviec(DateTime dtEnd, DateTime dtStart)
        {
            int iSoThang = (dtEnd.Year * 12 + dtEnd.Month) - (dtStart.Year * 12 + dtStart.Month);
            if (dtStart.Day < 16)
                iSoThang = iSoThang + 1;
            if (iSoThang < 0) iSoThang = 0;
            return iSoThang;
        }

        public decimal RoundingTimeSheet(decimal number)
        {
            decimal soNguyen = Math.Floor(number);
            decimal soDu = number - soNguyen;

            decimal result = 0;
            if (soDu >= 0 && soDu < (decimal)0.4)
            {
                result = soNguyen;
            }
            else if (soDu >= (decimal)0.4 && soDu < (decimal)0.8)
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
