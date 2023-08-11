using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Module.HRTimeSheetAudit;
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

namespace BOSERP.Modules.HRTimeSheetAudit
{
    public class HRTimeSheetAuditModule : BaseTransactionModule
    {
        public const string HREmployeeTimeSheetAuditsGridControlName = "fld_dgcHREmployeeTimeSheetAudits";
        private decimal HoursPerDay = 0;

        public bool isCustomDrawCell = false;

        private Microsoft.Office.Interop.Excel.Application App;
        /// <summary>
        /// Define work book in excel
        /// </summary>
        private Workbook WorkBook;
        /// <summary>
        /// Define work sheet in excel
        /// </summary>
        private Worksheet WorkSheet;

        public HRTimeSheetAuditModule()
        {
            Name = "HRTimeSheetAudit";
            CurrentModuleEntity = new HRTimeSheetAuditEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRTimeSheetAuditsController objTimeSheetAuditsController = new HRTimeSheetAuditsController();
            HRTimeSheetAuditsInfo searchObject = (HRTimeSheetAuditsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();

            ds = objTimeSheetAuditsController.GetTimeSheetAuditList(searchObject.HRTimeSheetAuditNo,
                                                            searchObject.HRTimeSheetAuditName,
                                                            searchObject.HRTimeSheetAuditType,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.HRTimeSheetAuditDateFrom,
                                                            searchObject.HRTimeSheetAuditDateTo);
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var objEmployeeTimeSheetAuditsInfo in entity.EmployeeTimeSheetAuditList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID);
                HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentID);
                if (objDepartmentsInfo != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HRDepartmentName = objDepartmentsInfo.HRDepartmentName;
                }
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomID);
                if (objDepartmentRoomsInfo != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                }
            }
            InitializeTimeSheetAuditEntryGridControl();
            isCustomDrawCell = false;
        }

        public override void InvalidateToolbar()
        {
            HRTimeSheetAuditsInfo timeSheet = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;
            if (timeSheet.HRTimeSheetAuditID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                if (timeSheet.HRTimeSheetAuditStatus == TimeSheetAuditStatus.SalaryCalculated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)entity.MainObject;
            timeSheetAudit.HRTimeSheetAuditType = TimeSheetAuditType.Day.ToString();
            isCustomDrawCell = false;

            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            List<HRTimeSheetsInfo> timeSheetList = objTimeSheetsController.GetTimeSheetsForTimeSheetAudit();
            guiFind<HRTimeSheetsInfo> guiFind = new guiFind<HRTimeSheetsInfo>(TableName.HRTimeSheetsTableName, timeSheetList, null, this);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                int timeSheetID = Convert.ToInt32(guiFind.Tag.ToString());
                HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(timeSheetID);
                if (objTimeSheetsInfo != null)
                {
                    timeSheetAudit.HRTimeSheetAuditFromDate = objTimeSheetsInfo.HRTimeSheetFromDate;
                    timeSheetAudit.HRTimeSheetAuditToDate = objTimeSheetsInfo.HRTimeSheetToDate;
                    timeSheetAudit.HRTimeSheetAuditDate = objTimeSheetsInfo.HRTimeSheetDate;
                    timeSheetAudit.HRTimeSheetAuditType = objTimeSheetsInfo.HRTimeSheetType;
                    timeSheetAudit.HRTimeSheetAuditName = objTimeSheetsInfo.HRTimeSheetName + "_Audit";
                    timeSheetAudit.FK_HRTimeSheetID = objTimeSheetsInfo.HRTimeSheetID;
                    InitializeTimeSheetAuditEntryGridControl();

                    GenerateTimeSheetAuditFromTimeSheet(timeSheetID);
                }
            }
        }

        public override int ActionSave()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            entity.EmployeeTimeSheetAuditList.EndCurrentEdit();
            UpdateTimeSheetAuditTotalQty();
            return base.ActionSave();
        }

        public void ActionSetTimeSheetParam()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
                HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)entity.MainObject;
                guiSetTimeSheetAuditParam guiSetTimeSheetAuditParam = new guiSetTimeSheetAuditParam();
                guiSetTimeSheetAuditParam.Fromdate = timeSheetAudit.HRTimeSheetAuditFromDate;
                guiSetTimeSheetAuditParam.Todate = timeSheetAudit.HRTimeSheetAuditToDate;
                guiSetTimeSheetAuditParam.Module = this;
                guiSetTimeSheetAuditParam.Show();
            }
        }

        public void SetTimeSheetAuditParam(int employeeID, int paramID, DateTime fromDate, DateTime toDate, bool autoCheck)
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            BOSDbUtil dbUtil = new BOSDbUtil();
            HREmployeeTimeSheetAuditsInfo employeeTimeSheet = entity.EmployeeTimeSheetAuditList.Where(et => et.FK_HREmployeeID == employeeID).FirstOrDefault();
            if (employeeTimeSheet != null || employeeID == 0)
            {
                for (int i = fromDate.Day; i <= toDate.Day; i++)
                {
                    if (paramID != 0)
                    {
                        if (employeeID > 0)
                        {
                            HRTimeSheetParamsInfo param = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamID == paramID).FirstOrDefault();
                            if (param != null && param.IsOTCalculated == true)
                            {
                                HREmployeeTimeSheetAuditsInfo employeeTimeAuditSheet = entity.EmployeeTimeSheetAuditList.Where(et => et.FK_HREmployeeID == employeeID).FirstOrDefault();
                                List<string> timeOTList = new List<string>();
                                timeOTList.Add(param.HRTimeSheetParamNo);
                                string timeSheetParamNo = UpdateEmployeeTimeSheetAudit(employeeTimeAuditSheet, timeOTList);
                                if (!string.IsNullOrEmpty(timeSheetParamNo))
                                    timeSheetParamNo = timeSheetParamNo.Substring(0, timeSheetParamNo.Length - 1);
                                dbUtil.SetPropertyValue(employeeTimeSheet, string.Format("HREmployeeTimeSheetAuditDate{0}", i), timeSheetParamNo);
                            }
                            else if (param != null)
                            {
                                dbUtil.SetPropertyValue(employeeTimeSheet, string.Format("HREmployeeTimeSheetAuditDate{0}", i), param.HRTimeSheetParamNo);
                            }
                            UpdateTimeSheetAuditTotalQty(employeeTimeSheet);
                        }
                    }
                    else
                    {
                        if (employeeID > 0)
                        {
                            HREmployeesController objEmployeesController = new HREmployeesController();
                            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);
                            LoadTimeKeeper(fromDate, toDate, objEmployeesInfo.HREmployeeCardNumber, true, employeeID);
                            break;
                        }
                        else
                        {
                            LoadTimeKeeper(fromDate, toDate, null, true, null);
                            break;
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Add employee to the current time sheet
        /// </summary>
        public void AddEmployeeToTimeSheetAudit()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                try
                {
                    guiSearchEmployee guiEmployee = new guiSearchEmployee();
                    guiEmployee.Module = this;
                    if (guiEmployee.ShowDialog() == DialogResult.OK)
                    {
                        HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
                        HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)entity.MainObject;
                        entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                        HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
                        List<HRLeaveDaysInfo> leaveDays = objLeaveDaysController.GetLeaveDayList(timeSheetAudit.HRTimeSheetAuditFromDate, timeSheetAudit.HRTimeSheetAuditToDate);
                        List<HRTimeSheetParamsInfo> timeSheetParams = entity.TimeSheetParams;
                        HRTimeSheetParamsInfo defaultParam = (HRTimeSheetParamsInfo)timeSheetParams.Where(
                                                                                    p => p.IsDefault == true &&
                                                                                    p.HRTimeSheetParamType == timeSheetAudit.HRTimeSheetAuditType).FirstOrDefault();
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
                                else if (!entity.EmployeeTimeSheetAuditList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                                {
                                    //set default employee information
                                    HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = SetEmployeeTimeSheetAuditInfoFromEmployee(objEmployeesInfo);

                                    //add default holiday timesheet param
                                    AddDefaulTimeSheetAuditEntries(objEmployeeTimeSheetAuditsInfo);

                                    List<HRTimeSheetAuditEntrysInfo> timeSheetEntrys = objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Where(t => t.FK_HREmployeeID == objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID).ToList();

                                    //Add time sheet entries from leave days
                                    List<HRLeaveDaysInfo> employeeLeaveDays = leaveDays.Where(ld => ld.FK_HREmployeeID == objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID).ToList();
                                    foreach (HRLeaveDaysInfo employeeLeaveDay in employeeLeaveDays)
                                    {
                                        HRTimeSheetAuditEntrysInfo entry = timeSheetEntrys.Where(e => e.FK_HREmployeeID == employeeLeaveDay.FK_HREmployeeID &&
                                                                                            e.HRTimeSheetAuditEntryDate.Date == employeeLeaveDay.HRLeaveDayDate.Date).FirstOrDefault();
                                        if (entry != null)
                                        {
                                            entry.FK_HRTimeSheetParamID = employeeLeaveDay.FK_HRTimeSheetParamID;
                                        }
                                        else
                                        {
                                            entry = new HRTimeSheetAuditEntrysInfo();
                                            entry.FK_HREmployeeID = employeeLeaveDay.FK_HREmployeeID;
                                            entry.FK_HRTimeSheetParamID = employeeLeaveDay.FK_HRTimeSheetParamID;
                                            entry.HRTimeSheetAuditEntryDate = employeeLeaveDay.HRLeaveDayDate;
                                            timeSheetEntrys.Add(entry);
                                        }
                                    }

                                    objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList = timeSheetEntrys;
                                    entity.SetEmployeeTimeSheetAuditValue(objEmployeeTimeSheetAuditsInfo);
                                    UpdateTimeSheetAuditTotalQty(objEmployeeTimeSheetAuditsInfo);
                                    entity.EmployeeTimeSheetAuditList.Add(objEmployeeTimeSheetAuditsInfo);
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
                        LoadTimeKeeper(timeSheetAudit.HRTimeSheetAuditFromDate.Date, timeSheetAudit.HRTimeSheetAuditToDate.Date, null, false, null);
                        // CTC Edit 11-09-2015 Begin
                        entity.EmployeeTimeSheetAuditList.GridControl.RefreshDataSource();
                    }
                    isCustomDrawCell = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadTimeKeeper(DateTime dateFrom, DateTime dateTo, string employeeCardNo, bool isReset, int? employeeID)
        {
            List<HRTimeSheetAuditEntrysInfo> timeAuditEntries = new List<HRTimeSheetAuditEntrysInfo>();
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;
            HRTimeKeeperCompletesController objTimeKeeperCompletesController = new HRTimeKeeperCompletesController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            BOSProgressBar.Start("Đang xử lý dữ liệu");

            foreach (HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo in entity.EmployeeTimeSheetAuditList)
            {
                if (employeeID > 0 && objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID != employeeID)
                {
                    continue;
                }
                string employeeCardNoInFor = "";
                if (employeeCardNo != null)
                {
                    employeeCardNoInFor = employeeCardNo;
                    if (employeeCardNo != objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber)
                    {
                        goto ENDFOR;
                    }
                }
                else
                {
                    employeeCardNoInFor = objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber;
                }
                List<HRTimeKeeperCompletesInfo> timeKeeperCompleteList = new List<HRTimeKeeperCompletesInfo>();
                timeKeeperCompleteList = objTimeKeeperCompletesController.GetTimeKeeperByDate(employeeCardNoInFor, dateFrom, dateTo);
                if (string.IsNullOrEmpty(objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber)) continue;
                if (!string.IsNullOrEmpty(employeeCardNo) && objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber != employeeCardNo) continue;
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID);
                objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                int daysInMonth = NumOfDayInMonth();
                for (int i = 1; i <= daysInMonth; i++)
                {
                    DateTime dt = timeSheetAudit.HRTimeSheetAuditFromDate.AddDays(i - 1).Date;
                    if (dt < dateFrom.Date || dt > dateTo.Date) continue;
                    List<HRTimeKeeperCompletesInfo> listTemp = timeKeeperCompleteList.Where(p => p.HRTimeKeeperCompletesEmployeeCardNo == objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber &&
                        p.HRTimeKeeperCompleteDate == dt.Date).OrderBy(p => p.HRTimeKeeperCompleteDate).ToList(); //HRTimeKeeperCompleteTimeCheck

                    for (int j = 0; j < listTemp.Count - 1; j += 2)
                    {
                        HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = new HRTimeSheetAuditEntrysInfo();
                        objTimeSheetAuditEntrysInfo.FK_HREmployeeID = objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID;
                        objTimeSheetAuditEntrysInfo.FK_HREmployeeTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID;
                        objTimeSheetAuditEntrysInfo.FK_HRTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.FK_HRTimeSheetAuditID;
                        objTimeSheetAuditEntrysInfo.HREmployeeCardNumber = objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber;
                        objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryDate = dt;
                        objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFrom = listTemp[j].HRTimeKeeperCompleteTimeCheck;
                        if (listTemp[j + 1].HRTimeKeeperCompleteDateCheck > listTemp[j].HRTimeKeeperCompleteDateCheck)
                        {
                            objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryTo =
                                listTemp[j + 1].HRTimeKeeperCompleteDateCheck.Date.AddHours(listTemp[j + 1].HRTimeKeeperCompleteTimeCheck.Hour).AddMinutes(listTemp[j + 1].HRTimeKeeperCompleteTimeCheck.Minute);
                        }
                        else
                        {
                            objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryTo = listTemp[j + 1].HRTimeKeeperCompleteTimeCheck;
                        }
                        timeAuditEntries.Add(objTimeSheetAuditEntrysInfo);
                    }
                }
            ENDFOR:;
            }
            AddEmployeesFromTimeKeeper(timeAuditEntries, dateFrom, dateTo, isReset, employeeID);
        }

        public void AddEmployeesFromTimeKeeper()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                List<HRTimeSheetAuditEntrysInfo> timeEntries = GetTimeSheetEntryFromTimeKeeper();
                HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;
                AddEmployeesFromTimeKeeper(timeEntries, timeSheetAudit.HRTimeSheetAuditFromDate, timeSheetAudit.HRTimeSheetAuditFromDate, false, null);
            }
        }

        public List<HRTimeSheetAuditEntrysInfo> GetTimeSheetEntryFromTimeKeeper()
        {
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;
            List<HRTimeSheetAuditEntrysInfo> timeSheetAuditEntryList = new List<HRTimeSheetAuditEntrysInfo>();
            Range range = InitializeDataImport();
            if (range != null)
            {
                if (MessageBox.Show(TimeSheetAuditLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);
                    HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployeeByPermission(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                    HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                    List<HRTimeSheetParamsInfo> timeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList(timeSheetAudit.HRTimeSheetAuditType);
                    Regex regTime = new Regex("^([0-9]{1,2}):([0-9]{1,2})");
                    for (int row = 4; row <= range.Rows.Count; row++)
                    {
                        HRTimeSheetAuditEntrysInfo entry = new HRTimeSheetAuditEntrysInfo();
                        entry.HREmployeeCardNumber = (range.Cells[row, "B"] as Range).Text.ToString().Trim();
                        HREmployeesInfo objEmployeesInfo = employeeList.Where(e => e.HREmployeeCardNumber == entry.HREmployeeCardNumber).FirstOrDefault();
                        if (objEmployeesInfo != null)
                        {
                            if (!entity.EmployeeTimeSheetAuditList.Exists(e => e.FK_HREmployeeID == objEmployeesInfo.HREmployeeID))
                            {
                                HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = new HREmployeeTimeSheetAuditsInfo();
                                objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                objEmployeeTimeSheetAuditsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                                objEmployeeTimeSheetAuditsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                                objEmployeeTimeSheetAuditsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                                objEmployeeTimeSheetAuditsInfo.HRLevelName = objEmployeesInfo.HRLevelName;
                                objEmployeeTimeSheetAuditsInfo.HREmployeeStartWorkingTime = objEmployeesInfo.HREmployeeStartWorkingTime;
                                objEmployeeTimeSheetAuditsInfo.HREmployeeEndWorkingTime = objEmployeesInfo.HREmployeeEndWorkingTime;
                                objEmployeeTimeSheetAuditsInfo.HREmployeeHoursPerDay = objEmployeesInfo.HREmployeeHoursPerDay;
                                entity.EmployeeTimeSheetAuditList.Add(objEmployeeTimeSheetAuditsInfo);
                            }

                            entry.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            Range r = range.Cells[row, "E"] as Range;
                            DateTime date = DateTime.ParseExact(r.Text.ToString().Trim(), r.NumberFormatLocal.ToString().Replace('m', 'M'), CultureInfo.InvariantCulture);
                            entry.HRTimeSheetAuditEntryDate = date;

                            string timeSheetParamValue = (range.Cells[row, "G"] as Range).Text.ToString().Trim();
                            string timeSheetParamValue2 = (range.Cells[row, "H"] as Range).Text.ToString().Trim();
                            if (regTime.IsMatch(timeSheetParamValue))
                            {
                                string[] values = timeSheetParamValue.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                                DateTime d1 = new DateTime(date.Year, date.Month, date.Day, int.Parse(values[0]), int.Parse(values[1]), 0);
                                entry.HRTimeSheetAuditEntryFrom = d1;
                                if (regTime.IsMatch(timeSheetParamValue2))
                                {
                                    values = timeSheetParamValue2.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                                    d1 = new DateTime(date.Year, date.Month, date.Day, int.Parse(values[0]), int.Parse(values[1]), 0);
                                    entry.HRTimeSheetAuditEntryTo = d1;
                                    timeSheetAuditEntryList.Add(entry);
                                }
                            }
                        }
                    }
                }
                ReleaseDataImport();
            }
            return timeSheetAuditEntryList;
        }

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

        public void ReleaseDataImport()
        {
            WorkBook.Close(true, null, null);
            App.Quit();
            ReleaseObject(WorkSheet);
            ReleaseObject(WorkBook);
            ReleaseObject(App);
        }

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
        /// Load time sheet from time keeper and refresh employee time sheet
        /// </summary>
        public void AddEmployeesFromTimeKeeper(List<HRTimeSheetAuditEntrysInfo> timeEntries, DateTime dateFrom, DateTime dateTo, bool isReset, int? employeeID)
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;

            if (timeEntries == null)
                timeEntries = new List<HRTimeSheetAuditEntrysInfo>();

            //get time sheet params
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> timeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList(timeSheetAudit.HRTimeSheetAuditType);
            List<HRTimeSheetParamsInfo> allTimeSheetParamsList = objTimeSheetParamsController.GetTimeSheetParamsList();
            List<HRTimeSheetParamsInfo> otTimeSheetParamsList = objTimeSheetParamsController.GetOTTimeSheetParamsList();

            //DateTime dateFrom = timeSheet.HRTimeSheetFromDate;
            //DateTime dateTo = timeSheet.HRTimeSheetToDate;

            //get employee's leave days
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            List<HRLeaveDaysInfo> leaveDays = objLeaveDaysController.GetLeaveDayList(dateFrom, dateTo);

            HREmployeesController objEmployeesController = new HREmployeesController();

            HRBreakTimesController breakTimeController = new HRBreakTimesController();
            List<HRBreakTimesInfo> breakTimeList = breakTimeController.GetBreakTimeList();
            HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
            HRTimesheetEmployeeLatesController objTimesheetEmployeeLatesController = new HRTimesheetEmployeeLatesController();
            //get hour per day
            HoursPerDay = GetHourPerDay();

            //add time sheeet entries from employee's work schedule
            List<HRTimeSheetAuditEntrysInfo> workScheduleEntries = AddTimeSheetAuditEntryFromEmployeeWorkSchedule();
            //timeEntries.AddRange(workingShiftTimeEntries);


            List<string> columnFieldNameHoliday = GetColumnFieldNameByTypeHoliday();
            List<HRTimeSheetAuditEntrysInfo> timeKeeperEntries = new List<HRTimeSheetAuditEntrysInfo>();
            List<HRTimeSheetAuditEntrysInfo> removedEntries = null;
            #region add time sheet entry from schedule
            int maxMinuteLate = 60;
            //add time sheet entry from schedule
            foreach (var item in timeEntries)
            {
                if (!timeKeeperEntries.Exists(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                p.HRTimeSheetAuditEntryDate.Date == item.HRTimeSheetAuditEntryDate.Date)))
                {
                    List<HRTimeSheetAuditEntrysInfo> temp = timeEntries.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                p.HRTimeSheetAuditEntryDate.Date == item.HRTimeSheetAuditEntryDate.Date)).ToList();
                    HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);

                    if (objEmployeesInfo != null)
                    {
                        HRTimesheetEmployeeLatesInfo objTimesheetEmployeeLatesInfo = objTimesheetEmployeeLatesController.GetHRTimesheetEmployeeMaxLate(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
                        if (objTimesheetEmployeeLatesInfo != null && objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateTimeTo > 0)
                        {
                            maxMinuteLate = objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateTimeTo;
                        }
                    }

                    item.HRTimeSheetAuditEntryWorkingHours = 0;
                    item.HRTimeSheetAuditEntryWorkingQty = 0;
                    DateTime dateMinTimeSheet = DateTime.MaxValue;
                    DateTime dateMaxTimeSheet = DateTime.MinValue;
                    foreach (var i in temp)
                    {
                        if (i.HRTimeSheetAuditEntryFrom < dateMinTimeSheet) dateMinTimeSheet = i.HRTimeSheetAuditEntryFrom;
                    }
                    // có hơn một cặp công trong 1 ngày : HRTimeSheetEntryDate.Date
                    if (temp.Count > 1 && objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0 && timeSheetAudit.HRTimeSheetAuditType == TimeSheetAuditType.Day.ToString())
                    {
                        HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfo(objEmployeesInfo.FK_HREmployeePayrollFormulaID, dateMinTimeSheet, dateMinTimeSheet, maxMinuteLate);

                        if (objWorkingShiftsInfo != null)
                        {

                            List<HRTimeSheetAuditEntrysInfo> tempGetAllTime = timeEntries.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                    p.HRTimeSheetAuditEntryDate.Date == item.HRTimeSheetAuditEntryDate.Date)).ToList();
                            if (tempGetAllTime != null && tempGetAllTime.Count > 1)
                            {
                                // sắp xếp lại theo thứ tự giờ ra tăng dần và merge thành 1 cặp vào ra : ADD thêm số phút ra - vào của từng cặp
                                tempGetAllTime = tempGetAllTime.OrderBy(x => x.HRTimeSheetAuditEntryTo).ToList();
                                foreach (var timeInOut in tempGetAllTime)
                                {
                                    if (timeInOut.HRTimeSheetAuditEntryFrom != tempGetAllTime[0].HRTimeSheetAuditEntryFrom)
                                    {
                                        TimeSpan sp = timeInOut.HRTimeSheetAuditEntryTo - timeInOut.HRTimeSheetAuditEntryFrom;
                                        tempGetAllTime[0].HRTimeSheetAuditEntryTo = tempGetAllTime[0].HRTimeSheetAuditEntryTo.Add(sp);
                                    }
                                }
                            }

                            List<HRTimeSheetAuditEntrysInfo> temp2 = tempGetAllTime.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
                                                    p.HRTimeSheetAuditEntryDate.Date == item.HRTimeSheetAuditEntryDate.Date &&
                                                    int.Parse(p.HRTimeSheetAuditEntryFrom.ToString("HHmm")) < int.Parse(objWorkingShiftsInfo.HRWorkingShiftToTime.ToString("HHmm")))).ToList();


                            if (temp2.Count > 0)
                            {
                                temp.Clear();
                                temp2.ForEach(p => temp.Add((HRTimeSheetAuditEntrysInfo)p.Clone()));
                            }
                        }
                    }
                    foreach (var i in temp)
                    {
                        item.HRTimeSheetAuditEntryWorkingHours += ((decimal)(i.HRTimeSheetAuditEntryTo - i.HRTimeSheetAuditEntryFrom).TotalMinutes) / Convert.ToDecimal(60.0);
                        item.HRTimeSheetAuditEntryWorkingQty = item.HRTimeSheetAuditEntryWorkingHours;
                        if (i.HRTimeSheetAuditEntryTo > dateMaxTimeSheet)
                            dateMaxTimeSheet = i.HRTimeSheetAuditEntryTo;
                    }
                    if (timeSheetAudit.HRTimeSheetAuditType == TimeSheetAuditType.Hour.ToString())
                    {
                        HRTimeSheetParamsInfo info = GetTimeSheetParam(timeSheetParamsList, item.HRTimeSheetAuditEntryWorkingHours);
                        if (info != null)
                        {
                            item.FK_HRTimeSheetParamID = info.HRTimeSheetParamID;
                        }
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
                        item.HRTimeSheetAuditEntryFrom = dateMinTimeSheet;
                        item.HRTimeSheetAuditEntryTo = dateMaxTimeSheet;
                        if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0)
                        {
                            //HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfo(objEmployeesInfo.FK_HREmployeePayrollFormulaID, dateMinTimeSheet, dateMaxTimeSheet);
                            //HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfoFromSchedule(objEmployeesInfo.HREmployeeID, dateMaxTimeSheet);
                            //HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfoFromSchedule(objEmployeesInfo.HREmployeeID, dateMinTimeSheet);
                            //Truyền công thức tính lương -
                            HRWorkingShiftsInfo objWorkingShiftsInfo = GetWorkingShiftsInfo(objEmployeesInfo.FK_HREmployeePayrollFormulaID, dateMinTimeSheet, item.HRTimeSheetAuditEntryDate, maxMinuteLate);
                            if (objWorkingShiftsInfo != null)
                            {
                                List<HRBreakTimesInfo> breakTimes = breakTimeList.Where(bt => bt.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                                DateTime dateMinWorkingShift = DateTime.ParseExact(dateMinTimeSheet.ToString("dd/MM/yyyy") + " " + objWorkingShiftsInfo.HRWorkingShiftFromTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                                DateTime dateMaxWorkingShift = DateTime.ParseExact(dateMinTimeSheet.ToString("dd/MM/yyyy") + " " + objWorkingShiftsInfo.HRWorkingShiftToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                                //DateTime dateMinWorkingShift = objWorkingShiftsInfo.HRWorkingShiftFromTime;
                                //DateTime dateMaxWorkingShift = objWorkingShiftsInfo.HRWorkingShiftToTime;



                                //Làm việc từ ngày hôm nay sang ngày hôm sau : EX:12h trưa tới 6h sáng hôm sau
                                //Ca làm việc chỉ có từ giờ đến giờ
                                if (dateMaxWorkingShift <= dateMinWorkingShift) dateMaxWorkingShift = dateMaxWorkingShift.AddDays(1);
                                int n = (int)(item.HRTimeSheetAuditEntryDate.Date - timeSheetAudit.HRTimeSheetAuditFromDate.Date).TotalDays + 1;
                                String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", n);

                                if (dateMinTimeSheet < dateMinWorkingShift) dateMinTimeSheet = dateMinWorkingShift;
                                //if (dateMaxTimeSheet.AddMinutes(20) >= dateMaxWorkingShift) dateMaxTimeSheet = dateMaxWorkingShift;
                                if (dateMaxTimeSheet >= dateMaxWorkingShift) dateMaxTimeSheet = dateMaxWorkingShift;
                                decimal workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                decimal workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                decimal factor = workingMinutes / workingShiftMinutes;
                                if (dateMinTimeSheet <= dateMinWorkingShift && dateMaxTimeSheet >= dateMaxWorkingShift)
                                {
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
                                        if (totalBreakTimeMinutes > 0)
                                        {
                                            workingMinutes -= totalBreakTimeMinutes;
                                            decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                            if (totalWokingShiftBreakTimeMinutes > 0)
                                                workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                        }
                                    }
                                    factor = Math.Round(workingMinutes / workingShiftMinutes, 2);
                                    HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor);
                                    item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                    item.HRTimeSheetAuditEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                    item.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                    //item.HRTimeSheetEntryFrom = dateMinTimeSheet;
                                    //item.HRTimeSheetEntryTo = dateMaxTimeSheet;
                                }
                                else if (dateMinTimeSheet > dateMinWorkingShift)
                                {

                                    HRTimesheetEmployeeLatesInfo objTimesheetEmployeeLatesInfo = objTimesheetEmployeeLatesController.GetTimesheetEmployee(objEmployeesInfo.FK_HREmployeePayrollFormulaID, (int)(dateMinTimeSheet - dateMinWorkingShift).TotalMinutes);
                                    if (objTimesheetEmployeeLatesInfo != null)
                                    {
                                        if (objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateOTTime != 0)
                                            dateMaxWorkingShift = dateMaxWorkingShift.AddMinutes(objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateOTTime);
                                        workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                        workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                        factor = workingMinutes / workingShiftMinutes;
                                        if (objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateOTTime != 0)
                                        {
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
                                                if (totalBreakTimeMinutes > 0)
                                                {
                                                    workingMinutes -= totalBreakTimeMinutes;
                                                    decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                                    if (totalWokingShiftBreakTimeMinutes > 0)
                                                        workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                                }
                                            }
                                            factor = Math.Round(workingMinutes / workingShiftMinutes, 2);

                                            HRTimeSheetParamsInfo obj = GetTimeSheetParam(timeSheetParamsList, factor);
                                            // HRTimeSheetParamsInfo obj = GetTimeSheetParam(timeSheetParamsList, objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateDeduct);
                                            item.FK_HRTimeSheetParamID = obj.HRTimeSheetParamID;
                                            item.HRTimeSheetAuditEntryWorkingHours = HoursPerDay;
                                            item.HRTimeSheetAuditEntryWorkingQty = obj.HRTimeSheetParamValue1;
                                        }
                                        else
                                        {
                                            //dateMaxWorkingShift = dateMaxWorkingShift.AddMinutes(-objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateOTTime);
                                            if (dateMaxTimeSheet < dateMaxWorkingShift)
                                            {
                                                //dateMaxTimeSheet = dateMaxWorkingShift;
                                                workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                                workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                                factor = workingMinutes / workingShiftMinutes;

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
                                                    if (totalBreakTimeMinutes > 0)
                                                    {
                                                        workingMinutes -= totalBreakTimeMinutes;
                                                        decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                                        if (totalWokingShiftBreakTimeMinutes > 0)
                                                            workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                                    }
                                                }
                                                factor = Math.Round(workingMinutes / workingShiftMinutes, 2);
                                            }
                                            else
                                            {
                                                factor = Convert.ToDecimal(1.0);
                                            }

                                            decimal val = factor - objTimesheetEmployeeLatesInfo.HRTimesheetEmployeeLateDeduct;
                                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, val);
                                            if (objTimeSheetParamsInfo != null)
                                            {
                                                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                                item.HRTimeSheetAuditEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                                item.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                            }
                                        }
                                    }
                                }
                                else if (dateMinTimeSheet <= dateMinWorkingShift && dateMaxTimeSheet < dateMaxWorkingShift)
                                {
                                    dateMinTimeSheet = dateMinWorkingShift;
                                    workingShiftMinutes = (decimal)(dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
                                    workingMinutes = (decimal)(dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
                                    factor = workingMinutes / workingShiftMinutes;

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
                                        if (totalBreakTimeMinutes > 0)
                                        {
                                            workingMinutes -= totalBreakTimeMinutes;
                                            decimal totalWokingShiftBreakTimeMinutes = (decimal)(breakTime.HRBreakTimeToTime - breakTime.HRBreakTimeFromTime).TotalMinutes;
                                            if (totalWokingShiftBreakTimeMinutes > 0)
                                                workingShiftMinutes -= totalWokingShiftBreakTimeMinutes;
                                        }

                                    }
                                    factor = Math.Round(workingMinutes / workingShiftMinutes, 2);

                                    HRTimeSheetParamsInfo obj = GetTimeSheetParam(timeSheetParamsList, factor);
                                    item.FK_HRTimeSheetParamID = obj.HRTimeSheetParamID;
                                    item.HRTimeSheetAuditEntryWorkingQty = obj.HRTimeSheetParamValue1;
                                    item.HRTimeSheetAuditEntryWorkingHours = HoursPerDay * obj.HRTimeSheetParamValue1;
                                }
                            }
                        }
                    }
                    if (item.FK_HRTimeSheetParamID == 0)
                    {
                        if (leaveDays.Exists(ld => (ld.FK_HREmployeeID == item.FK_HREmployeeID
                            && ld.HRLeaveDayDate.Date == item.HRTimeSheetAuditEntryDate.Date)))
                        {
                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, item.HRTimeSheetAuditEntryWorkingHours / HoursPerDay, false);
                            item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                            item.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                        }
                    }
                    HRTimeSheetAuditEntrysInfo item1 = (HRTimeSheetAuditEntrysInfo)item.Clone();
                    item1.HRTimeSheetAuditEntryFrom = dateMinTimeSheet;
                    item1.HRTimeSheetAuditEntryTo = dateMaxTimeSheet;
                    timeKeeperEntries.Add(item1);
                }
            }
            #endregion
            #region work schedule


            //foreach (var item in workScheduleEntries)
            //{
            //    List<HRTimeSheetAuditEntrysInfo> temp = workScheduleEntries.Where(p => (p.FK_HREmployeeID == item.FK_HREmployeeID &&
            //                                p.HRTimeSheetAuditEntryDate.Date == item.HRTimeSheetAuditEntryDate.Date)).ToList();

            //    HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
            //    item.HRTimeSheetAuditEntryWorkingHours = 0;
            //    item.HRTimeSheetAuditEntryWorkingQty = 0;
            //    DateTime dateMinTimeSheet = DateTime.MaxValue;
            //    DateTime dateMaxTimeSheet = DateTime.MinValue;
            //    foreach (var i in temp)
            //    {
            //        if (i.HRTimeSheetAuditEntryFrom < dateMinTimeSheet) dateMinTimeSheet = i.HRTimeSheetAuditEntryFrom;
            //        if (i.HRTimeSheetAuditEntryTo > dateMaxTimeSheet) dateMaxTimeSheet = i.HRTimeSheetAuditEntryTo;
            //    }

            //    if (timeSheetAudit.HRTimeSheetAuditType == TimeSheetAuditType.Hour.ToString())
            //    {
            //        HRTimeSheetParamsInfo info = GetTimeSheetParam(timeSheetParamsList, item.HRTimeSheetAuditEntryWorkingHours);
            //        if (info != null)
            //        {
            //            item.FK_HRTimeSheetParamID = info.HRTimeSheetParamID;
            //        }
            //    }
            //    else
            //    {
            //        if (objEmployeesInfo.FK_HRTimeSheetScaleID > 0)
            //        {
            //            decimal  minutes = GetTimeSheetScale(objEmployeesInfo, (dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes);
            //            if (dateMinTimeSheet.AddMinutes(minutes) > dateMaxTimeSheet)
            //            {
            //                dateMaxTimeSheet = dateMinTimeSheet.AddMinutes(minutes);
            //            }
            //        }
            //        item.HRTimeSheetAuditEntryFrom = dateMinTimeSheet;
            //        item.HRTimeSheetAuditEntryTo = dateMaxTimeSheet;
            //        if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0)
            //        {
            //            //get default working shift for work schedule
            //            HRWorkingShiftsInfo objWorkingShiftsInfo = workingShiftController.
            //                                GetDefaultWorkingShiftByPayrollFormulaIDAndWorkingShiftDayOfWeek(objEmployeesInfo.FK_HREmployeePayrollFormulaID,
            //                                                                                                WorkingShiftDayOffWeek.All.ToString());
            //            if (objWorkingShiftsInfo != null)
            //            {
            //                DateTime dateMinWorkingShift = dateMinTimeSheet.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftFromTime.Hour)
            //                                                            .AddMinutes(objWorkingShiftsInfo.HRWorkingShiftFromTime.Minute);
            //                DateTime dateMaxWorkingShift = dateMaxTimeSheet.Date.AddHours(objWorkingShiftsInfo.HRWorkingShiftToTime.Hour)
            //                                                            .AddMinutes(objWorkingShiftsInfo.HRWorkingShiftToTime.Minute);

            //                if (dateMaxWorkingShift <= dateMinWorkingShift) dateMaxWorkingShift = dateMaxWorkingShift.AddDays(1);

            //                if (dateMinTimeSheet < dateMinWorkingShift)
            //                    dateMinTimeSheet = dateMinWorkingShift;
            //                if (dateMaxTimeSheet > dateMaxWorkingShift)
            //                    dateMaxTimeSheet = dateMaxWorkingShift;

            //                decimal  workingShiftMinutes = (dateMaxWorkingShift - dateMinWorkingShift).TotalMinutes;
            //                decimal  workingMinutes = (dateMaxTimeSheet - dateMinTimeSheet).TotalMinutes;
            //                decimal  factor = workingMinutes / workingShiftMinutes;
            //                HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, factor);
            //                item.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
            //                item.HRTimeSheetAuditEntryWorkingHours = HoursPerDay * objTimeSheetParamsInfo.HRTimeSheetParamValue1;
            //                item.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
            //            }

            //        }

            //        HRTimeSheetAuditEntrysInfo item1 = (HRTimeSheetAuditEntrysInfo)item.Clone();
            //        item1.HRTimeSheetAuditEntryFrom = dateMinTimeSheet;
            //        item1.HRTimeSheetAuditEntryTo = dateMaxTimeSheet;
            //        timeKeeperEntries.Add(item1);
            //    }
            //}

            #endregion

            #region OT


            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            List<HROTFactorsInfo> objOTFactorsList2 = objOTFactorsController.GetAllOTFactors();
            foreach (HREmployeeTimeSheetAuditsInfo item in entity.EmployeeTimeSheetAuditList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                HREmployeeOTsController objEmployeeOTsController = new HREmployeeOTsController();
                List<HREmployeeOTsInfo> listOTs = objEmployeeOTsController.GetEmployeeOTList(item.FK_HREmployeeID, dateFrom, dateTo);
                List<HRBreakTimesInfo> breakTimes = breakTimeList.Where(bt => bt.FK_HREmployeePayrollFormulaID == objEmployeesInfo.FK_HREmployeePayrollFormulaID).ToList();

                foreach (var ot in listOTs)
                {
                    int n = ot.HREmployeeOTDate.Day;

                    //HieuNt Fix: lấy ngày bắt đầu và kết thúc của thời gian tăng ca bằng ngày tăng ca HREmployeeOTDate Start
                    ot.HREmployeeOTFromDate = DateTime.ParseExact(ot.HREmployeeOTDate.ToString("dd/MM/yyyy") + " " + ot.HREmployeeOTFromDate.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    ot.HREmployeeOTToDate = DateTime.ParseExact(ot.HREmployeeOTDate.ToString("dd/MM/yyyy") + " " + ot.HREmployeeOTToDate.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    if (ot.HREmployeeOTToDate < ot.HREmployeeOTFromDate)
                    {
                        ot.HREmployeeOTToDate = ot.HREmployeeOTToDate.AddDays(1);
                    }
                    //HieuNt Fix: lấy ngày bắt đầu và kết thúc của thời gian tăng ca bằng ngày tăng ca HREmployeeOTDate END

                    String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", n);

                    //set OT time to the real time from time keeper 
                    HRTimeSheetAuditEntrysInfo timeSheetEntry = timeEntries.FirstOrDefault(tke => tke.HRTimeSheetAuditEntryDate.Date == ot.HREmployeeOTDate.Date
                        && tke.FK_HREmployeeID == item.FK_HREmployeeID);
                    if (timeSheetEntry != null)
                    {
                        HRTimeSheetAuditEntrysInfo timeSheetEntry1 = timeKeeperEntries.FirstOrDefault(tke => tke.HRTimeSheetAuditEntryDate.Date == ot.HREmployeeOTDate.Date
                                                                                                        && tke.FK_HRTimeSheetParamID != 0 && tke.FK_HREmployeeID == item.FK_HREmployeeID);
                        if (timeSheetEntry1 != null)
                        {
                            if (timeSheetEntry1.HRTimeSheetAuditEntryTo > ot.HREmployeeOTFromDate)
                                ot.HREmployeeOTFromDate = timeSheetEntry1.HRTimeSheetAuditEntryTo;
                        }
                        // Nếu thời gian đăng ký lớn thời gian thực tế làm thì chỉ đựơc tính tăng ca đến thời gian thực tế làm
                        if (ot.HREmployeeOTToDate > timeSheetEntry.HRTimeSheetAuditEntryTo)
                            ot.HREmployeeOTToDate = timeSheetEntry.HRTimeSheetAuditEntryTo;


                        string otFromTime = GetValueADConfigValues(ConfigValueKey.OTFromTime);
                        string otToTime = GetValueADConfigValues(ConfigValueKey.OTToTime);
                        int oTValueTime = Convert.ToInt32(GetValueADConfigValues(ConfigValueKey.OTValueTime));

                        #region LV OT from 18:10:00 -> 18:40:00
                        DateTime dOTfrom = DateTime.ParseExact(timeSheetEntry.HRTimeSheetAuditEntryTo.ToString("dd/MM/yyyy") + " "
                                     + otFromTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime dOTTo = DateTime.ParseExact(timeSheetEntry.HRTimeSheetAuditEntryTo.ToString("dd/MM/yyyy") + " "
                                     + otToTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                        if (ot.HREmployeeOTToDate >= dOTfrom && ot.HREmployeeOTToDate <= dOTTo)
                        {
                            ot.HREmployeeOTToDate = ot.HREmployeeOTFromDate.AddMinutes(oTValueTime);
                        }
                        #endregion


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
                            totalMinutes = (decimal)(toDate - fromDate).TotalMinutes;

                            foreach (HRBreakTimesInfo breakTime in breakTimes)
                            {
                                breakTime.HRBreakTimeFromTime = fromDate.Date.AddHours(breakTime.HRBreakTimeFromTime.Hour).AddMinutes(breakTime.HRBreakTimeFromTime.Minute);
                                breakTime.HRBreakTimeToTime = fromDate.Date.AddHours(breakTime.HRBreakTimeToTime.Hour).AddMinutes(breakTime.HRBreakTimeToTime.Minute);

                                DateTime breakTimeFrom = fromDate < breakTime.HRBreakTimeFromTime ? breakTime.HRBreakTimeFromTime : fromDate;
                                DateTime breakTimeTo = toDate < breakTime.HRBreakTimeToTime ? toDate : breakTime.HRBreakTimeToTime;

                                decimal totalBreakTimeMinutes = (decimal)(breakTimeTo - breakTimeFrom).TotalMinutes;
                                if (totalBreakTimeMinutes > 0)
                                    totalMinutes -= totalBreakTimeMinutes;
                            }

                            time = Math.Round(totalMinutes / 60, 2);
                            //Kiểm tra thời gian OT
                            if (time > 0)
                                time = CheckOverTimeAuditMonth(timeKeeperEntries, time, item.FK_HREmployeeID, ot.HREmployeeOTDate);

                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetOTTimeSheetParam(otTimeSheetParamsList, time, objOTFactor.HROTFactorValue);
                            if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamID != 0)
                            {
                                otHours = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                                f = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objOTFactor.HROTFactorValue;

                                HRTimeSheetAuditEntrysInfo obj = new HRTimeSheetAuditEntrysInfo();
                                obj.FK_HREmployeeID = item.FK_HREmployeeID;
                                obj.FK_HREmployeeTimeSheetAuditID = item.HREmployeeTimeSheetAuditID;
                                obj.FK_HRTimeSheetAuditID = item.FK_HRTimeSheetAuditID;
                                obj.HRTimeSheetAuditEntryDate = ot.HREmployeeOTDate;
                                obj.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                obj.HRTimeSheetAuditEntryWorkingQty = f / HoursPerDay;
                                obj.HRTimeSheetAuditEntryWorkingHours = f;
                                obj.HRTimeSheetAuditEntryFrom = fromDate;
                                obj.HRTimeSheetAuditEntryTo = toDate;
                                obj.HRTimeSheetAuditParamNo = objTimeSheetParamsInfo.HRTimeSheetParamNo;
                                obj.HRTimeSheetAuditEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                timeKeeperEntries.Add(obj);
                            }


                        }
                    }
                }
            }
            #endregion

            #region EmployeeTimeSheetList
            {
                List<HREmployeeTimeSheetAuditsInfo> employeeTimeSheets = new List<HREmployeeTimeSheetAuditsInfo>();
                //TODO: Need to refactor this as we don't have a better way to get holiday param currently
                HRTimeSheetParamsInfo holidayParam = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamNo.ToLower() == "le").FirstOrDefault();
                HRTimeSheetParamsInfo defaultParam = entity.TimeSheetParams.Where(p => p.IsDefault == true).FirstOrDefault();
                foreach (HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo in entity.EmployeeTimeSheetAuditList)
                {
                    List<HRTimeSheetAuditEntrysInfo> timeSheetEntrys = timeKeeperEntries.Where(t => t.FK_HREmployeeID == objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID).ToList();
                    List<HREmployeeTimeSheetAuditOTDetailsInfo> timeSheetAuditOTDetails = new List<HREmployeeTimeSheetAuditOTDetailsInfo>();
                    // Add time sheet entries for holiday days
                    int daysInMonth = NumOfDayInMonth();
                    //for (int i = dateFromNum; i <= dateToNum; i++)
                    for (DateTime dt = dateFrom; dt <= dateTo; dt = dt.AddDays(1))
                    {
                        int i = dt.Day;
                        String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", i);
                        bool isHoliday = columnFieldNameHoliday.Exists(delegate (string holiday) { return propertyName == holiday; });
                        //DateTime date = timeSheet.HRTimeSheetFromDate.AddDays(i - 1).Date;
                        DateTime date = dt.Date;
                        if ((isHoliday && holidayParam != null))
                        {
                            HRTimeSheetAuditEntrysInfo entry = timeSheetEntrys.Where(e => e.HRTimeSheetAuditEntryDate.Date == date).FirstOrDefault();
                            if (entry != null)
                            {
                                if (entry.FK_HRTimeSheetParamID == 0)
                                {
                                    entry.FK_HRTimeSheetParamID = defaultParam.HRTimeSheetParamID;
                                    entry.HRTimeSheetAuditEntryWorkingHours = defaultParam.HRTimeSheetParamValue1 * defaultParam.HRTimeSheetParamValue2;
                                    entry.HRTimeSheetAuditEntryWorkingQty = entry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay;
                                }
                            }
                            else
                                if (entry == null)
                            {
                                entry = new HRTimeSheetAuditEntrysInfo();
                                entry.FK_HREmployeeID = objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID;
                                entry.FK_HRTimeSheetParamID = holidayParam.HRTimeSheetParamID;
                                entry.HRTimeSheetAuditEntryWorkingHours = holidayParam.HRTimeSheetParamValue1 * holidayParam.HRTimeSheetParamValue2;
                                entry.HRTimeSheetAuditEntryWorkingQty = entry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay;
                                entry.HRTimeSheetAuditEntryDate = date;
                                timeSheetEntrys.Add(entry);
                            }
                        }
                    }

                    //Add time sheet entries from leave days
                    List<HRLeaveDaysInfo> employeeLeaveDays = leaveDays.Where(ld => ld.FK_HREmployeeID == objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID).ToList();
                    foreach (HRLeaveDaysInfo employeeLeaveDay in employeeLeaveDays)
                    {
                        {
                            HRTimeSheetAuditEntrysInfo entry = new HRTimeSheetAuditEntrysInfo();
                            entry.FK_HREmployeeID = employeeLeaveDay.FK_HREmployeeID;
                            entry.FK_HRTimeSheetParamID = employeeLeaveDay.FK_HRTimeSheetParamID;
                            HRTimeSheetParamsInfo obj = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(employeeLeaveDay.FK_HRTimeSheetParamID);
                            if (obj != null)
                            {
                                entry.HRTimeSheetAuditEntryWorkingHours = obj.HRTimeSheetParamValue1 * obj.HRTimeSheetParamValue2;
                                HRTimeSheetParamsInfo objTimeSheetParamsInfo = GetTimeSheetParam(timeSheetParamsList, entry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay, false);
                                entry.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1;
                            }
                            entry.HRTimeSheetAuditEntryDate = employeeLeaveDay.HRLeaveDayDate;
                            timeSheetEntrys.Add(entry);
                        }
                    }
                    foreach (var item in timeSheetEntrys)
                    {
                        if (item.FK_HRTimeSheetParamID == 0)
                        {
                            item.HRTimeSheetAuditEntryWorkingHours = 0;
                            item.HRTimeSheetAuditEntryWorkingQty = 0;
                        }
                    }
                    //noi cong cho chuc nang cham cong nhanh [start]
                    //objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList = timeSheetEntrys;
                    //objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList = timeSheetOTDetails;
                    DateTime d = dateFrom;
                    while (d.Date <= dateTo.Date)
                    {
                        removedEntries = objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Where(item => item.HRTimeSheetAuditEntryDate.Date == d).ToList();
                        if (removedEntries != null)
                        {
                            foreach (HRTimeSheetAuditEntrysInfo entry in removedEntries)
                            {
                                objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Remove(entry);
                            }
                        }
                        d = d.AddDays(1);
                    }
                    objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.AddRange(timeSheetEntrys);
                    //noi cong cho chuc nang cham cong nhanh [end]

                    List<HRTimeSheetParamsInfo> OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
                    foreach (var otfactor in OTFactorlist)
                    {
                        HREmployeeTimeSheetAuditOTDetailsInfo objEmployeeTimeSheetAuditOTDetailsInfo = new HREmployeeTimeSheetAuditOTDetailsInfo();
                        objEmployeeTimeSheetAuditOTDetailsInfo.HREmployeeTimeSheetAuditOTDetailFactor = otfactor.HRTimeSheetParamValue2;
                        objEmployeeTimeSheetAuditOTDetailsInfo.HREmployeeTimeSheetAuditOTDetailName = otfactor.HRTimeSheetParamValue2.ToString();
                        foreach (var item in objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList)
                        {
                            HRTimeSheetParamsInfo obj = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(item.FK_HRTimeSheetParamID);
                            if (obj != null && obj.HRTimeSheetParamValue2 == otfactor.HRTimeSheetParamValue2)
                            {
                                objEmployeeTimeSheetAuditOTDetailsInfo.HREmployeeTimeSheetAuditOTDetailHours += item.HRTimeSheetAuditEntryWorkingHours / obj.HRTimeSheetParamValue2;
                            }
                        }
                        timeSheetAuditOTDetails.Add(objEmployeeTimeSheetAuditOTDetailsInfo);
                    }
                    if (employeeID > 0)
                    {
                        if (objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID == employeeID)
                        {
                            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList = timeSheetAuditOTDetails;
                            //Set employee time sheet audit value
                            entity.SetEmployeeTimeSheetAuditValue(objEmployeeTimeSheetAuditsInfo);
                            //Update time sheet total quantity

                            UpdateTimeSheetAuditTotalQty(objEmployeeTimeSheetAuditsInfo);
                        }

                    }
                    else
                    {
                        objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList = timeSheetAuditOTDetails;
                        //Set employee time sheet audit value
                        entity.SetEmployeeTimeSheetAuditValue(objEmployeeTimeSheetAuditsInfo);
                        //Update time sheet total quantity

                        UpdateTimeSheetAuditTotalQty(objEmployeeTimeSheetAuditsInfo);
                    }

                    if (employeeID == null || employeeID == 0)
                    {
                        employeeTimeSheets.Add(objEmployeeTimeSheetAuditsInfo);
                    }
                    //employeeTimeSheets.Add(objEmployeeTimeSheetsInfo);                                        
                }
                if (employeeID == null || employeeID == 0)
                {
                    entity.EmployeeTimeSheetAuditList.Invalidate(employeeTimeSheets);
                    employeeTimeSheets.Clear();
                }
            }
            #endregion
            BOSProgressBar.Close();
        }

        private decimal CheckOverTimeAuditMonth(List<HRTimeSheetAuditEntrysInfo> timeSheetEntrys, decimal time, int employeeID, DateTime timeSheetAuditEntryDate)
        {
            decimal otAuditDay = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.OTAuditDay));
            decimal otAuditMonth = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.OTAuditMonth));
            //Lấy danh sách nhân viên tăng ca trong tháng.
            List<HRTimeSheetAuditEntrysInfo> timeSheet = timeSheetEntrys.Where(x => x.FK_HREmployeeID == employeeID && x.HRTimeSheetAuditEntryDate.Month == timeSheetAuditEntryDate.Month && x.HRTimeSheetAuditEntryFactor > 0).ToList();
            if (timeSheet != null && timeSheet.Count > 0)
            {
                //một tháng OT không quá otAuditMonth ngày
                decimal check = timeSheet.Sum(x => x.HRTimeSheetAuditEntryWorkingHours / x.HRTimeSheetAuditEntryFactor);
                if (check >= otAuditMonth)
                {
                    time = 0;
                }
                else
                {
                    check = otAuditMonth - check;
                    if (check >= otAuditDay)
                    {
                        //1 ngày không được làm quá otAuditDay giờ
                        if (time > otAuditDay)
                            time = otAuditDay;
                    }
                    else
                    {
                        time = check;
                    }
                }
            }
            else
            {
                //1 ngày không được làm quá otAuditDay giờ
                if (time > otAuditDay)
                    time = otAuditDay;
            }
            return time;
        }
        public string UpdateEmployeeTimeSheetAudit(HREmployeeTimeSheetAuditsInfo employeeTimeSheetAuditsInfo, List<string> timeOTList)
        {
            //kiểm tra ngày theo cấu hình
            string timeOTValues = string.Empty;
            if (timeOTList.Count > 0)
            {
                decimal otAuditDay = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.OTAuditDay));
                decimal otAuditMonth = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.OTAuditMonth));
                HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                if (employeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTQty < otAuditMonth)
                {
                    decimal hour = otAuditMonth - employeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTQty;
                    bool isUpdate = false;
                    for (int i = 0; i < timeOTList.Count; i++)
                    {
                        if (isUpdate == false)
                        {
                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByNo(timeOTList[i].Trim());
                            if (objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamValue1 <= otAuditDay && objTimeSheetParamsInfo.HRTimeSheetParamValue1 <= hour)
                            {
                                isUpdate = true;
                                timeOTValues += objTimeSheetParamsInfo.HRTimeSheetParamNo + ",";
                            }
                        }
                    }
                }
            }
            return timeOTValues;
        }

        private HRTimeSheetParamsInfo GetTimeSheetParam(List<HRTimeSheetParamsInfo> timeSheetParamsList, decimal val)
        {
            return GetTimeSheetParam(timeSheetParamsList, val, false);
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
                    val = objTimeSheetLevelsInfo.HRTimeSheetLevelValue * Convert.ToDecimal(60);
                }
            }
            return val;
        }
        private HRTimeSheetParamsInfo GetTimeSheetParam(List<HRTimeSheetParamsInfo> timeSheetParamsList, decimal val, bool isOT)
        {
            HRTimeSheetParamsInfo obj = timeSheetParamsList.Where(p => (p.IsOTCalculated == isOT && p.HRTimeSheetParamValue1 <= val))
                .OrderByDescending(p => p.HRTimeSheetParamValue1).FirstOrDefault();
            if (obj == null) obj = new HRTimeSheetParamsInfo();
            return obj;
        }

        private HRTimeSheetParamsInfo GetOTTimeSheetParam(List<HRTimeSheetParamsInfo> timeSheetParamsList, decimal value1, decimal value2)
        {
            HRTimeSheetParamsInfo obj = timeSheetParamsList.Where(p => (p.IsOTCalculated == true &&
                                                            p.HRTimeSheetParamValue1 <= value1 && p.HRTimeSheetParamValue2 == value2))
                .OrderByDescending(p => p.HRTimeSheetParamValue1).FirstOrDefault();
            if (obj == null) obj = new HRTimeSheetParamsInfo();
            return obj;
        }

        private List<HRTimeSheetAuditEntrysInfo> AddTimeSheetAuditEntryFromEmployeeWorkSchedule()
        {
            List<HRTimeSheetAuditEntrysInfo> timeAuditEntries = new List<HRTimeSheetAuditEntrysInfo>();

            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;

            DateTime dateFrom = timeSheetAudit.HRTimeSheetAuditFromDate;
            DateTime dateTo = timeSheetAudit.HRTimeSheetAuditToDate;

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
                        HRTimeSheetAuditEntrysInfo obj = new HRTimeSheetAuditEntrysInfo();
                        obj.FK_HREmployeeID = employeeWorkSchedule.FK_HREmployeeID;
                        obj.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                        obj.HRTimeSheetAuditEntryDate = dt.Date;
                        if (dt.Date == employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.Date)
                        {
                            obj.HRTimeSheetAuditEntryFrom = employeeWorkSchedule.HREmployeeWorkScheduleDateFrom;
                            if (employeeWorkSchedule.HREmployeeWorkScheduleDateTo == employeeWorkSchedule.HREmployeeWorkScheduleDateFrom)
                                obj.HRTimeSheetAuditEntryTo = DateTime.ParseExact(employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.ToString("dd/MM/yyyy") + " " +
                                            employeeWorkSchedule.HREmployeeWorkScheduleDateTo.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            else
                                obj.HRTimeSheetAuditEntryTo = employeeWorkSchedule.HREmployeeWorkScheduleDateFrom.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                        }
                        else
                        {
                            obj.HRTimeSheetAuditEntryFrom = dt;
                            if (dt.Date == employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Date)
                                obj.HRTimeSheetAuditEntryTo = dt.AddHours(employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Hour)
                                                            .AddMinutes(employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Minute)
                                                            .AddSeconds(employeeWorkSchedule.HREmployeeWorkScheduleDateTo.Second);
                            else
                                obj.HRTimeSheetAuditEntryTo = dt.AddHours(23).AddMinutes(59).AddSeconds(59);
                        }
                        timeAuditEntries.Add(obj);
                    }
                }
                //}
            }

            return timeAuditEntries;
        }

        private HREmployeeTimeSheetAuditsInfo SetEmployeeTimeSheetAuditInfoFromEmployee(HREmployeesInfo objEmployeesInfo)
        {
            HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = new HREmployeeTimeSheetAuditsInfo();

            if (objEmployeesInfo != null)
            {
                objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                objEmployeeTimeSheetAuditsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                objEmployeeTimeSheetAuditsInfo.HRDepartmentName = objEmployeesInfo.HRDepartmentName;
                objEmployeeTimeSheetAuditsInfo.HRDepartmentRoomName = objEmployeesInfo.HRDepartmentRoomName;
                objEmployeeTimeSheetAuditsInfo.HRDepartmentRoomGroupItemName = objEmployeesInfo.HRDepartmentRoomGroupItemName;
                objEmployeeTimeSheetAuditsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                objEmployeeTimeSheetAuditsInfo.HRLevelName = objEmployeesInfo.HRLevelName;
                objEmployeeTimeSheetAuditsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                objEmployeeTimeSheetAuditsInfo.HREmployeeStartWorkingTime = objEmployeesInfo.HREmployeeStartWorkingTime;
                objEmployeeTimeSheetAuditsInfo.HREmployeeEndWorkingTime = objEmployeesInfo.HREmployeeEndWorkingTime;
                objEmployeeTimeSheetAuditsInfo.HREmployeeHoursPerDay = objEmployeesInfo.HREmployeeHoursPerDay;
            }

            return objEmployeeTimeSheetAuditsInfo;

        }


        /// <summary>
        /// Add default entries to a time sheet of an employee
        /// </summary>
        /// <param name="objEmployeeTimeSheetsInfo">Given employee time sheet</param>
        public void AddDefaulTimeSheetAuditEntries(HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo)
        {
            objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Clear();
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> timeSheetParams = entity.TimeSheetParams;
            HRTimeSheetParamsInfo defaultParam = (HRTimeSheetParamsInfo)timeSheetParams.Where(
                                                                                        p => p.IsDefault == true &&
                                                                                        p.HRTimeSheetParamType == objTimeSheetAuditsInfo.HRTimeSheetAuditType).FirstOrDefault();
            //TODO: Need to refactor this as we don't have a better way to get holiday param currently
            HRTimeSheetParamsInfo holidayParam = timeSheetParams.Where(p => p.HRTimeSheetParamNo.ToLower() == "le").FirstOrDefault();
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
                    DateTime currentDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.Date.AddDays(i - 1);
                    HRTimeSheetAuditEntrysInfo entry = new HRTimeSheetAuditEntrysInfo();
                    entry.FK_HREmployeeTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID;
                    entry.FK_HRTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.FK_HRTimeSheetAuditID;
                    entry.FK_HREmployeeID = objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID;
                    entry.HRTimeSheetAuditEntryDate = currentDate;

                    //Set default param to entry
                    //entry.FK_HRTimeSheetParamID = defaultParam.HRTimeSheetParamID;
                    String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", i);
                    bool isHoliday = columnFieldNameHoliday.Exists(delegate (string holiday) { return propertyName == holiday; });
                    if (isHoliday && holidayParam != null)
                    {
                        entry.FK_HRTimeSheetParamID = holidayParam.HRTimeSheetParamID;
                    }

                    bool isEndOfWeek = columnFieldNameEndOfWeek.Exists(delegate (string endOfWeek) { return propertyName == endOfWeek; });
                    if (!isEndOfWeek)
                    {
                        objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Add(entry);
                    }
                }
            }
        }

        /// <summary>
        /// Update the total quantities for the current time sheet
        /// </summary>
        public void UpdateTimeSheetAuditTotalQty()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            foreach (HREmployeeTimeSheetAuditsInfo employeeTimeSheetAudit in entity.EmployeeTimeSheetAuditList)
            {

                UpdateTimeSheetAuditTotalQty(employeeTimeSheetAudit);
            }
        }

        /// <summary>
        /// Update time sheet total quantity of an employee
        /// </summary>
        /// <param name="employeeTimeSheet">Infomation of employee </param>
        public void UpdateTimeSheetAuditTotalQty(HREmployeeTimeSheetAuditsInfo employeeTimeSheetAudit)
        {

            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditWorkingQty = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditWorkingSalaryFactor = 0;
            employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTQty = 0;
            employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTSalaryFactor = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditLeaveQty = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditLeaveSalaryFactor = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiCheDo = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditCongTyChoNghi = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiPhepNam = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiLe = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiKhongPhep = 0;
            //employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiCoPhep = 0;

            HoursPerDay = GetHourPerDay();

            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;

            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            List<string> employeeTimeSheetDayList = new List<string> {  employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate1, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate2,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate3, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate4,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate5, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate6,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate7, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate8,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate9, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate10,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate11, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate12,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate13, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate14,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate15, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate16,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate17, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate18,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate19, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate20,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate21, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate22,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate23, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate24,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate25, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate26,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate27, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate28,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate29, employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate30,
                                                                        employeeTimeSheetAudit.HREmployeeTimeSheetAuditDate31 };

            //employeeTimeSheetAudit.HRTimeSheetAuditEntrysList.ForEach(e => e.FK_HRTimeSheetParamID = 0);
            foreach (var item in employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTDetailsList)
            {
                item.HREmployeeTimeSheetAuditOTDetailHours = 0;
            }
            int numDays = NumOfDayInMonth();
            for (int i = 0; i < numDays; i++)
            {
                string[] paramNumbers = employeeTimeSheetDayList[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                DateTime currentDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(i);
                decimal mainEntryValue = 0;

                for (int j = 0; j < paramNumbers.Length; j++)
                {
                    string paramNo = paramNumbers[j].Trim();
                    HRTimeSheetParamsInfo param = entity.TimeSheetParams.Where(p => p.HRTimeSheetParamNo == paramNo).FirstOrDefault();
                    if (param != null)
                    {
                        HRTimeSheetAuditEntrysInfo timeSheetAuditEntry = employeeTimeSheetAudit.HRTimeSheetAuditEntrysList.Where(e => e.HRTimeSheetAuditEntryDate.Date == currentDate.Date &&
                                                                         e.FK_HRTimeSheetParamID == param.HRTimeSheetParamID &&
                                                                         //e.HRTimeSheetAuditParamNo == paramNo && 
                                                                         employeeTimeSheetAudit.FK_HREmployeeID == e.FK_HREmployeeID).FirstOrDefault();
                        if (timeSheetAuditEntry == null)
                        {
                            timeSheetAuditEntry = new HRTimeSheetAuditEntrysInfo();
                            if (param.HRTimeSheetParamType == TimeSheetParamType.Day.ToString())
                            {
                                timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingQty = param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours = timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingQty * HoursPerDay;
                            }
                            else
                            {
                                timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours = param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingQty = timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay;
                            }
                            employeeTimeSheetAudit.HRTimeSheetAuditEntrysList.Add(timeSheetAuditEntry);
                        }
                        timeSheetAuditEntry.FK_HREmployeeTimeSheetAuditID = employeeTimeSheetAudit.HREmployeeTimeSheetAuditID;
                        timeSheetAuditEntry.FK_HRTimeSheetAuditID = employeeTimeSheetAudit.FK_HRTimeSheetAuditID;
                        timeSheetAuditEntry.FK_HREmployeeID = employeeTimeSheetAudit.FK_HREmployeeID;
                        timeSheetAuditEntry.FK_HRTimeSheetParamID = param.HRTimeSheetParamID;
                        timeSheetAuditEntry.HRTimeSheetAuditEntryDate = currentDate;


                        List<HROTFactorsInfo> factors = GetOTFactors(employeeTimeSheetAudit, timeSheetAuditEntry, param);

                        if (param.HRTimeSheetParamType == TimeSheetParamType.Day.ToString() ||
                            param.HRTimeSheetParamType == TimeSheetParamType.Hour.ToString())
                        {
                            if (param.IsOTCalculated)
                            {
                                if (timeSheetAuditEntry.IsOTFactor)
                                {
                                    timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours = param.HRTimeSheetParamValue1 * timeSheetAuditEntry.HRTimeSheetAuditEntryFactor;
                                    timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingQty = timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay;

                                    employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTQty += param.HRTimeSheetParamValue1;
                                    employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTSalaryFactor += param.HRTimeSheetParamValue1 * timeSheetAuditEntry.HRTimeSheetAuditEntryFactor;
                                    foreach (var item in employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTDetailsList)
                                    {
                                        if (item.HREmployeeTimeSheetAuditOTDetailFactor == timeSheetAuditEntry.HRTimeSheetAuditEntryFactor)
                                        {
                                            item.HREmployeeTimeSheetAuditOTDetailHours += param.HRTimeSheetParamValue1;
                                        }
                                    }
                                }
                                else
                                    if (factors != null && factors.Count != 0)
                                {
                                    timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours = param.HRTimeSheetParamValue1 * factors[0].HROTFactorValue;
                                    timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingQty = timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay;

                                    employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTQty += param.HRTimeSheetParamValue1;
                                    employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTSalaryFactor += param.HRTimeSheetParamValue1 * factors[0].HROTFactorValue;
                                    foreach (var item in employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTDetailsList)
                                    {
                                        if (item.HREmployeeTimeSheetAuditOTDetailFactor == factors[0].HROTFactorValue)
                                        {
                                            item.HREmployeeTimeSheetAuditOTDetailHours += param.HRTimeSheetParamValue1;
                                        }
                                    }
                                }
                                else
                                {
                                    timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours = param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                    timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingQty = timeSheetAuditEntry.HRTimeSheetAuditEntryWorkingHours / HoursPerDay;

                                    employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTQty += param.HRTimeSheetParamValue1;
                                    employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTSalaryFactor += param.HRTimeSheetParamValue1 * param.HRTimeSheetParamValue2;
                                    foreach (var item in employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTDetailsList)
                                    {
                                        if (item.HREmployeeTimeSheetAuditOTDetailFactor == param.HRTimeSheetParamValue2)
                                        {
                                            item.HREmployeeTimeSheetAuditOTDetailHours += param.HRTimeSheetParamValue1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                mainEntryValue = param.HRTimeSheetParamValue1;
                                decimal totalOTTime = factors.Sum(f => f.OTTime);
                                //employeeTimeSheetAudit.HREmployeeTimeSheetAuditWorkingQty += param.HRTimeSheetParamValue1 - totalOTTime;
                                //employeeTimeSheetAudit.HREmployeeTimeSheetAuditWorkingSalaryFactor += (param.HRTimeSheetParamValue1 - totalOTTime) * param.HRTimeSheetParamValue2;
                                employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTQty += factors.Sum(f => f.OTTime * f.HROTFactorValue);
                                employeeTimeSheetAudit.HREmployeeTimeSheetAuditOTSalaryFactor += factors.Sum(f => f.OTTime * f.HROTFactorValue) * param.HRTimeSheetParamValue2;
                            }
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
                        //    if (objTimeSheetAuditsInfo.HRTimeSheetAuditType.Equals(TimeSheetAuditType.Day.ToString()))
                        //    {
                        //        employeeTimeSheetAudit.HREmployeeTimeSheetAuditLeaveQty += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //        employeeTimeSheetAudit.HREmployeeTimeSheetAuditLeaveSalaryFactor += (param.HRTimeSheetParamValue1 / HoursPerDay) * param.HRTimeSheetParamValue2;
                        //    }
                        //    if (objTimeSheetAuditsInfo.HRTimeSheetAuditType.Equals(TimeSheetAuditType.Hour.ToString()))
                        //    {
                        //        employeeTimeSheetAudit.HREmployeeTimeSheetAuditLeaveQty += 8 - mainEntryValue;
                        //        employeeTimeSheetAudit.HREmployeeTimeSheetAuditLeaveSalaryFactor += (8 - mainEntryValue) * param.HRTimeSheetParamValue2;
                        //    }
                        //}

                        //01-11-2019
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.LE.ToString()))
                        //{
                        //    employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiLe += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //}
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.NKP.ToString()))
                        //{
                        //    employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiKhongPhep += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //}
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCP.ToString()))
                        //{
                        //    employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiCoPhep += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //}
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.PN.ToString()))
                        //{
                        //    employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiPhepNam += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //}
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.CTCN.ToString()))
                        //{
                        //    employeeTimeSheetAudit.HREmployeeTimeSheetAuditCongTyChoNghi += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //}
                        //else if (param.HRTimeSheetParamType.Equals(TimeSheetParamType.NCDO.ToString()))
                        //{
                        //    employeeTimeSheetAudit.HREmployeeTimeSheetAuditNghiCheDo += param.HRTimeSheetParamValue1 / HoursPerDay;
                        //}
                    }
                }
            }
            entity.UpdateMainObjectBindingSource();
        }


        /// <summary>
        /// Get the overtime factors relating to a time sheet entry
        /// </summary>
        /// <param name="employeeTimeSheet">Time sheet of the employee that the entry belongs to</param>
        /// <param name="entry">Time sheet entry</param>
        /// <param name="param">Time sheet param associates with the entry</param>
        /// <returns>List of factors</returns>
        public List<HROTFactorsInfo> GetOTFactors(HREmployeeTimeSheetAuditsInfo employeeTimeSheetAudit, HRTimeSheetAuditEntrysInfo entry, HRTimeSheetParamsInfo param)
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            decimal holidayFactorValue = 0;
            HROTFactorsController objOTFactorsController = new HROTFactorsController();

            List<HROTFactorsInfo> workingDayFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.WorkingDay.ToString() &&
                                                                                f.HREmployeeID == employeeTimeSheetAudit.FK_HREmployeeID &&
                                                                                f.HROTFactorValue == param.HRTimeSheetParamValue2).ToList();

            List<HROTFactorsInfo> holidayFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.Holiday.ToString() &&
                                                                                f.HREmployeeID == employeeTimeSheetAudit.FK_HREmployeeID &&
                                                                                f.HROTFactorValue == param.HRTimeSheetParamValue2).ToList();
            List<HROTFactorsInfo> endOfWeekFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.EndOfWeek.ToString() &&
                                                                                f.HREmployeeID == employeeTimeSheetAudit.FK_HREmployeeID &&
                                                                                f.HROTFactorValue == param.HRTimeSheetParamValue2).ToList();

            if (!BOSApp.IsEndOfWeek(entry.HRTimeSheetAuditEntryDate.DayOfWeek) && param.IsOTCalculated)
            {
                if (workingDayFactors.Count > 0)
                {
                    holidayFactorValue = workingDayFactors[0].HROTFactorValue;
                }
            }
            if (BOSApp.IsEndOfWeek(entry.HRTimeSheetAuditEntryDate.DayOfWeek) && param.IsOTCalculated)
            {
                if (endOfWeekFactors.Count > 0)
                {
                    holidayFactorValue = endOfWeekFactors[0].HROTFactorValue;
                }
            }
            if (CheckHoliday(entry.HRTimeSheetAuditEntryDate))
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
                holidayFactor.OTTime = param.HRTimeSheetParamValue1;
                holidayFactor.HROTFactorValue = holidayFactorValue;
                result.Add(holidayFactor);
            }

            //Add working factor in case the time sheet is hour-calculated
            HRTimeSheetAuditsInfo timeSheet = (HRTimeSheetAuditsInfo)entity.MainObject;
            decimal startHour = employeeTimeSheetAudit.HREmployeeStartWorkingTime.Hour;
            decimal endHour = employeeTimeSheetAudit.HREmployeeEndWorkingTime.Hour;
            if (param.HRTimeSheetParamValue1 > employeeTimeSheetAudit.HREmployeeHoursPerDay)
            {
                endHour += param.HRTimeSheetParamValue1 - employeeTimeSheetAudit.HREmployeeHoursPerDay;
            }
            if (timeSheet.HRTimeSheetAuditType == TimeSheetAuditType.Hour.ToString())
            {
                List<HROTFactorsInfo> workingFactors = entity.OTFactors.Where(f => f.HROTFactorType == OTFactorType.WorkingDay.ToString() &&
                                                                                    f.HREmployeeID == employeeTimeSheetAudit.FK_HREmployeeID).ToList();

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


        /// <summary>
        /// Check day is holiday or not
        /// </summary>
        /// <param name="dayOfMonth">Day of the month</param>
        /// <returns>true if day is holiday</returns>
        public bool CheckHoliday(DateTime dayOfMonth)
        {
            return BOSApp.IsHoliday(dayOfMonth);
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

        public string GetValueADConfigValues(string configValueKey)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            string objConfigKeyValue = objConfigValuesController.GetValueByConfigKey(configValueKey).ToString();
            return objConfigKeyValue;
        }

        /// <summary>
        /// Number of days in month
        /// </summary>
        /// <returns></returns>
        public int NumOfDayInMonth()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            int numDays = (int)(objTimeSheetAuditsInfo.HRTimeSheetAuditToDate.Date - objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.Date).TotalDays + 1;
            return numDays;
        }

        /// <summary>
        /// Get column field name with calender type is holiday
        /// </summary>
        /// <returns>List of the column field name</returns>
        public List<string> GetColumnFieldNameByTypeHoliday()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            List<string> list = new List<string>();
            HRCalendarEntrysController objCalendarEntrysController = new HRCalendarEntrysController();
            List<HRCalendarEntrysInfo> entries = objCalendarEntrysController.GetCalendarEntryByDateAndCalenderType(CalendarType.Holiday.ToString(), objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate, objTimeSheetAuditsInfo.HRTimeSheetAuditToDate);
            foreach (HRCalendarEntrysInfo objCalendarEntrysInfo in entries)
            {
                //int day = (int)(objCalendarEntrysInfo.HRCalendarEntryDate.Date - objTimeSheetsInfo.HRTimeSheetFromDate.AddDays(-1).Date).TotalDays;
                int day = (int)objCalendarEntrysInfo.HRCalendarEntryDate.Day;
                string columnName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", day);
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
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            List<string> list = new List<string>();
            int numDays = NumOfDayInMonth();
            for (int i = 1; i <= numDays; i++)
            {
                DateTime dayofMonth = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(i - 1);
                DayOfWeek dayOfWeek = dayofMonth.DayOfWeek;
                if (BOSApp.IsEndOfWeek(dayOfWeek))
                {
                    string columnName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", i.ToString());
                    list.Add(columnName);
                }
            }
            return list;
        }

        /// <summary>
        /// Remove the selected employee from the current employee time sheet list
        /// </summary>
        public void RemoveEmployeeFromTimeSheetAuditList()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.EmployeeTimeSheetAuditList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.EmployeeTimeSheetAuditList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        public void ChangeTimeSheetTimeAudit()
        {
            InvalidateTimeSheetAuditValues();
            InitializeTimeSheetAuditEntryGridControl();
        }

        public void ChangeTimeSheetAuditType(string timeSheetAuditType)
        {
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;
            timeSheetAudit.HRTimeSheetAuditType = timeSheetAuditType;
            InvalidateTimeSheetAuditValues();
            InitializeTimeSheetAuditEntryGridControl();
        }

        private void InvalidateTimeSheetAuditValues()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            foreach (HREmployeeTimeSheetAuditsInfo employeeTimeSheet in entity.EmployeeTimeSheetAuditList)
            {
                entity.SetEmployeeTimeSheetAuditValue(employeeTimeSheet);
                UpdateTimeSheetAuditTotalQty(employeeTimeSheet);
            }
        }

        public void InitializeTimeSheetAuditEntryGridControl()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            HREmployeeTimeSheetAuditsGridControl gridControl = (HREmployeeTimeSheetAuditsGridControl)Controls[HRTimeSheetAuditModule.HREmployeeTimeSheetAuditsGridControlName];
            gridControl.InitializeControl();
            InitColumnRepository(objTimeSheetAuditsInfo.HRTimeSheetAuditType);
        }

        public void InitColumnRepository(string timeSheetAuditType)
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
            BOSGridControl timeSheetEntrysGridControl = (BOSGridControl)Controls[HRTimeSheetAuditModule.HREmployeeTimeSheetAuditsGridControlName];
            RepositoryItemCheckedComboBoxEdit reposItemCheckedCombo = new RepositoryItemCheckedComboBoxEdit();

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> mainParams = objTimeSheetParamsController.GetTimeSheetParamsByTimeSheetType(timeSheetAuditType);
            List<HRTimeSheetParamsInfo> commonParams = objTimeSheetParamsController.GetTimeSheetParamsByTimeSheetType(TimeSheetParamType.Common.ToString());
            List<HRTimeSheetParamsInfo> otParams = objTimeSheetParamsController.GetOTTimeSheetParamsList();

            mainParams = mainParams.Concat(commonParams).ToList();
            mainParams = mainParams.Concat(otParams).ToList();
            reposItemCheckedCombo.DataSource = mainParams;

            reposItemCheckedCombo.DisplayMember = "HRTimeSheetParamNo";
            reposItemCheckedCombo.ValueMember = "HRTimeSheetParamNo";
            timeSheetEntrysGridControl.RepositoryItems.Add(reposItemCheckedCombo);

            for (int i = 4; i < timeSheetEntrysGridControl.Columns.Count; i++)
            {
                if (entity.EmployeeTimeSheetAuditList.GridControl.Columns[i].FieldName == "HREmployeeTimeSheetAuditHourProductivity")
                    continue;

                entity.EmployeeTimeSheetAuditList.GridControl.Columns[i].ColumnEdit = reposItemCheckedCombo;
            }
            reposItemCheckedCombo.EditValueChanged += new EventHandler(ReposItemCheckedCombo_EditValueChanged);
        }

        private void ReposItemCheckedCombo_EditValueChanged(object sender, EventArgs e)
        {
            CheckedComboBoxEdit checkCombo = (CheckedComboBoxEdit)sender;
            string value = checkCombo.EditValue.ToString();
            string comboText = String.Empty;
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

        #region reports

        public void PrintTimeSheetAudit()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
                HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
                ADReportsController objReportsController = new ADReportsController();
                RPTimeSheetAudit report = new RPTimeSheetAudit();
                decimal hourPerDay = GetHourPerDay();
                HREmployeeTimeSheetAuditsController objEmployeeTimeSheetAuditsController = new HREmployeeTimeSheetAuditsController();
                List<HREmployeeTimeSheetAuditsInfo> employeeTimeSheetAuditList = objEmployeeTimeSheetAuditsController.GetEmployeeTimeSheetAuditByTimeSheetAuditIDAndUserGroup(objTimeSheetAuditsInfo.HRTimeSheetAuditID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
                if (employeeTimeSheetAuditList != null)
                {
                    foreach (HREmployeeTimeSheetAuditsInfo employeeTimeSheetAudit in employeeTimeSheetAuditList)
                    {
                        if (hourPerDay != 0)
                            employeeTimeSheetAudit.HREmployeeAbsentUnpermission = employeeTimeSheetAudit.HREmployeeAbsentUnpermission / hourPerDay;
                    }
                }

                SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                foreach (HREmployeeTimeSheetAuditsInfo item in employeeTimeSheetAuditList)
                {
                    item.HRTimeSheetAuditFromDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate;
                    item.HRTimeSheetAuditToDate = objTimeSheetAuditsInfo.HRTimeSheetAuditToDate;
                }
                report.DataSource = employeeTimeSheetAuditList;
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevTimeSheetReportPath, true);
                reviewer.Show();
            }
        }

        public void PrintTimeSheetAuditDetail()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
                HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;
                ADReportsController objReportsController = new ADReportsController();
                RPTimeSheetAuditDetail report = new RPTimeSheetAuditDetail();
                //Set current branch

                SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                entity.EmployeeTimeSheetAuditList.ForEach(p => p.HRTimeSheetAuditFromDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate);
                entity.EmployeeTimeSheetAuditList.ForEach(p => p.HRTimeSheetAuditToDate = objTimeSheetAuditsInfo.HRTimeSheetAuditToDate);
                report.DataSource = entity.EmployeeTimeSheetAuditList;
                //Set report source for sub report time sheet param
                RPTimeSheetParam reportTimeSheetParam = new RPTimeSheetParam();
                //reportTimeSheetParam.LoadLayout(BOSCommon.Constants.Report.DevTimeSheetParamsReportPath);
                List<HRTimeSheetParamsInfo> timeSheetParamList = objReportsController.GetTimeSheetParamByTimeSheetParamType(objTimeSheetAuditsInfo.HRTimeSheetAuditType);
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

        //Copy Bảng công sang bảng công Audit
        //Khánh Huy
        //19-07-2019

        #region Bảng công Audit
        public void GenerateTimeSheetAuditFromTimeSheet(int timeSheetID)
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;

            entity.EmployeeTimeSheetAuditList.Clear();

            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HREmployeeTimeSheetOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetOTDetailsController();
            List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = objEmployeeTimeSheetsController.GetEmployeeTimeSheetByTimeSheetIDAndUserGroup(timeSheetID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);

            foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in employeeTimeSheetList)
            {
                HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = GenerateTimeSheetAuditFromTimeSheet(employeeTimeSheet);
                employeeTimeSheet.HRTimeSheetEntrysList = objTimeSheetEntrysController.GetTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(
                                                                               employeeTimeSheet.FK_HRTimeSheetID,
                                                                               employeeTimeSheet.HREmployeeTimeSheetID);
                if (employeeTimeSheet.HRTimeSheetEntrysList != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList = new List<HRTimeSheetAuditEntrysInfo>();

                    employeeTimeSheet.HRTimeSheetEntrysList.ForEach(o =>
                    {
                        HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = new HRTimeSheetAuditEntrysInfo();
                        BOSUtil.CopyObject(o, objTimeSheetAuditEntrysInfo);
                        objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Add(objTimeSheetAuditEntrysInfo);
                    });

                    AllocatedOverTimeAuditMonth(objEmployeeTimeSheetAuditsInfo, employeeTimeSheet.FK_HREmployeeID);
                }

                employeeTimeSheet.HREmployeeTimeSheetOTDetailsList = objEmployeeTimeSheetOTDetailsController.GetListTimeSheetOTDetailByEmployeeTimeSheet(employeeTimeSheet.HREmployeeTimeSheetID);
                if (employeeTimeSheet.HREmployeeTimeSheetOTDetailsList != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList = new List<HREmployeeTimeSheetAuditOTDetailsInfo>();

                    employeeTimeSheet.HREmployeeTimeSheetOTDetailsList.ForEach(o =>
                    {
                        HREmployeeTimeSheetAuditOTDetailsInfo objEmployeeTimeSheetAuditOTDetailsInfo = new HREmployeeTimeSheetAuditOTDetailsInfo();
                        BOSUtil.CopyObject(o, objEmployeeTimeSheetAuditOTDetailsInfo);
                        objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList.Add(objEmployeeTimeSheetAuditOTDetailsInfo);
                    });
                }
                entity.SetEmployeeTimeSheetAuditValue(objEmployeeTimeSheetAuditsInfo);
                UpdateTimeSheetAuditTotalQty(objEmployeeTimeSheetAuditsInfo);
                entity.EmployeeTimeSheetAuditList.Add(objEmployeeTimeSheetAuditsInfo);
            }
            entity.EmployeeTimeSheetAuditList.GridControl.RefreshDataSource();
        }

        public HREmployeeTimeSheetAuditsInfo GenerateTimeSheetAuditFromTimeSheet(HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo)
        {
            HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = new HREmployeeTimeSheetAuditsInfo();
            objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID = objEmployeeTimeSheetsInfo.FK_HREmployeeID;
            objEmployeeTimeSheetAuditsInfo.FK_HRDepartmentRoomID = objEmployeeTimeSheetsInfo.FK_HRDepartmentRoomID;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditWorkingQty = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTQty = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTQty;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditLeaveQty = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetLeaveQty;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditWorkingSalaryFactor = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingSalaryFactor;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTSalaryFactor = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTSalaryFactor;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditLeaveSalaryFactor = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetLeaveSalaryFactor;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditNightQty = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetNightQty;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditWorkDayQty = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkDayQty;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditNghiCoPhep = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetNghiCoPhep;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditNghiKhongPhep = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetNghiKhongPhep;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditNghiLe = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetNghiLe;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditNghiCheDo = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetNghiCheDo;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditCongTyChoNghi = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetCongTyChoNghi;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditNghiPhepNam = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetNghiPhepNam;
            objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditPermissionOTDaysOff = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetPermissionOTDaysOff;

            HREmployeesController objEmployeesController = new HREmployeesController();
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HRLevelsController objLevelsController = new HRLevelsController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeTimeSheetAuditsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentID);
                if (objDepartmentsInfo != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HRDepartmentName = objDepartmentsInfo.HRDepartmentName;
                }
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomID);
                if (objDepartmentRoomsInfo != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                }
                HRLevelsInfo objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                if (objLevelsInfo != null)
                {
                    objEmployeeTimeSheetAuditsInfo.HRLevelName = objLevelsInfo.HRLevelName;
                }
                objEmployeeTimeSheetAuditsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                objEmployeeTimeSheetAuditsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                objEmployeeTimeSheetAuditsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }

            return objEmployeeTimeSheetAuditsInfo;
        }

        public void RefreshTimeSheetAudit()
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)CurrentModuleEntity.MainObject;
            if (MessageBox.Show("Bạn có muốn làm mới bảng công không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Toolbar.IsEditAction())
                {
                    GenerateTimeSheetAuditFromTimeSheet(objTimeSheetAuditsInfo.FK_HRTimeSheetID);
                }
                else if (Toolbar.IsNullOrNoneAction())
                {
                    base.ActionEdit();
                    GenerateTimeSheetAuditFromTimeSheet(objTimeSheetAuditsInfo.FK_HRTimeSheetID);
                }

                entity.EmployeeTimeSheetAuditList.GridControl.RefreshDataSource();
            }
        }

        public void AllocatedOverTimeAuditMonth(HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo, int employeeID)
        {
            HRTimeSheetAuditEntities entity = (HRTimeSheetAuditEntities)CurrentModuleEntity;
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)entity.MainObject;

            decimal otAuditDay = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.OTAuditDay));
            decimal otAuditMonth = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.OTAuditMonth));
            decimal hoursPerDay = Convert.ToDecimal(GetValueADConfigValues(ConfigValueKey.HoursPerDay));
            if (hoursPerDay == 0)
            {
                hoursPerDay = 8;
            }
            //Lấy danh sách nhân viên tăng ca trong tháng.
            if (objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList != null && objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList.Count > 0)
            {
                List<HRTimeSheetAuditEntrysInfo> timeSheetEntrys = objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList;
                List<HRTimeSheetAuditEntrysInfo> timeSheet = timeSheetEntrys.Where(x => x.FK_HREmployeeID == employeeID
                    && x.HRTimeSheetAuditEntryDate.Month == objTimeSheetAuditsInfo.HRTimeSheetAuditDate.Month
                    && x.HRTimeSheetAuditEntryDate.Year == objTimeSheetAuditsInfo.HRTimeSheetAuditDate.Year
                    && x.HRTimeSheetAuditEntryFactor > 0
                    && x.IsOT == true).ToList();

                List<DateTime> dateList = new List<DateTime>();
                List<DateTime> dateListEndOffWeek = new List<DateTime>();
                if (timeSheetEntrys != null)
                {
                    timeSheetEntrys.ForEach(o =>
                    {
                        if (!dateList.Exists(x => x.Date == o.HRTimeSheetAuditEntryDate.Date))
                        {
                            dateList.Add(o.HRTimeSheetAuditEntryDate.Date);
                        }
                    });
                }

                if (timeSheet != null)
                {
                    timeSheet.ForEach(o =>
                    {
                        if (!dateListEndOffWeek.Exists(x => x.Date == o.HRTimeSheetAuditEntryDate.Date))
                        {
                            if (BOSApp.IsEndOfWeek(o.HRTimeSheetAuditEntryDate.DayOfWeek)
                               || BOSApp.IsHoliday(o.HRTimeSheetAuditEntryDate))
                            {
                                dateListEndOffWeek.Add(o.HRTimeSheetAuditEntryDate.Date);
                            }
                        }
                    });
                }

                int daysInMonth = NumOfDayInMonth();

                HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
                List<HRTimeSheetParamsInfo> list = objTimeSheetParamsController.GetTimeSheetParamByTimeSheetParamValueAndIsOT();
                objTimeSheetParamsInfo = list.Where(o => o.HRTimeSheetParamValue1 == otAuditDay).FirstOrDefault();

                List<HRTimeSheetParamsInfo> listTimeSheetParams = (List<HRTimeSheetParamsInfo>)objTimeSheetParamsController.GetTimeSheetParamsByLeaveDayType();
                List<HRTimeSheetAuditEntrysInfo> timeSheet2 = new List<HRTimeSheetAuditEntrysInfo>();
                if (listTimeSheetParams != null)
                {
                    timeSheet2 = timeSheetEntrys.Where(x => x.FK_HREmployeeID == employeeID
                                && x.HRTimeSheetAuditEntryDate.Month == objTimeSheetAuditsInfo.HRTimeSheetAuditDate.Month
                                && x.HRTimeSheetAuditEntryDate.Year == objTimeSheetAuditsInfo.HRTimeSheetAuditDate.Year
                                && listTimeSheetParams.Exists(o => o.HRTimeSheetParamID == x.FK_HRTimeSheetParamID)).ToList();
                }


                if (timeSheet != null && timeSheet.Count > 0 && otAuditDay > 0 &&
                    objTimeSheetParamsInfo != null && objTimeSheetParamsInfo.HRTimeSheetParamValue2 > 0)
                {
                    //một tháng OT không quá otAuditMonth giờ
                    //decimal check = timeSheet.Sum(x => x.HRTimeSheetAuditEntryWorkingHours / x.HRTimeSheetAuditEntryFactor);
                    decimal check = timeSheet.Sum(x => x.HRTimeSheetAuditEntryWorkingHours / objTimeSheetParamsInfo.HRTimeSheetParamValue2);

                    decimal hour = Convert.ToInt32(otAuditMonth % otAuditDay);
                    int dem = Convert.ToInt32(Math.Floor(otAuditMonth / otAuditDay));

                    if (check < otAuditMonth)
                    {
                        hour = Convert.ToInt32(check % otAuditDay);
                        dem = Convert.ToInt32(Math.Floor(check / otAuditDay));
                        if (dateList != null)
                        {
                            if (dateList.Count - dateListEndOffWeek.Count - timeSheet2.Count < dem)
                            {
                                objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditHourProductivity =
                                    check - (dateList.Count - dateListEndOffWeek.Count - timeSheet2.Count) * otAuditDay;
                                dem = dateList.Count - dateListEndOffWeek.Count - timeSheet2.Count;
                            }
                        }
                    }
                    else
                    {
                        objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditHourProductivity = check - otAuditMonth;
                        if (dateList != null)
                        {
                            if (dateList.Count - dateListEndOffWeek.Count - timeSheet2.Count < dem)
                            {
                                objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditHourProductivity =
                                    check - otAuditMonth + (dem - (dateList.Count - dateListEndOffWeek.Count - timeSheet2.Count)) * otAuditDay;
                                dem = dateList.Count - dateListEndOffWeek.Count - timeSheet2.Count;
                            }
                        }
                    }

                    if (objTimeSheetParamsInfo != null)
                    {
                        timeSheet.ForEach(o =>
                        {
                            timeSheetEntrys.Remove(o);
                        });
                        if (hour == 0)
                        {
                            List<string> ngay = new List<string>();
                            Random rd = new Random();

                            for (int i = 0; i < dem; i++)
                            {
                                int ngayrd = 0;
                                bool result = true;
                                while (result)
                                {
                                    ngayrd = rd.Next(1, daysInMonth + 1);
                                    if (!ngay.Exists(o => o == ngayrd.ToString())
                                        && !BOSApp.IsEndOfWeek(objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1).DayOfWeek)
                                        && !BOSApp.IsHoliday(objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1)))
                                    {
                                        result = false;
                                        if (timeSheet2 != null
                                            && timeSheet2.Exists(o => o.HRTimeSheetAuditEntryDate.Date == objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1).Date)
                                            || !dateList.Exists(o => o.Date == objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1).Date))
                                        {
                                            result = true;
                                        }
                                    }
                                }
                                ngay.Add(ngayrd.ToString());
                                HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = new HRTimeSheetAuditEntrysInfo();
                                objTimeSheetAuditEntrysInfo.FK_HREmployeeID = employeeID;
                                objTimeSheetAuditEntrysInfo.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1);
                                objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryWorkingHours = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objTimeSheetParamsInfo.HRTimeSheetParamValue2 / hoursPerDay;
                                objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                timeSheetEntrys.Add(objTimeSheetAuditEntrysInfo);
                            }
                        }
                        else
                        {
                            decimal soDu = otAuditMonth - dem * otAuditDay;
                            if (check < otAuditMonth)
                            {
                                soDu = check - dem * otAuditDay;
                            }
                            List<string> ngay = new List<string>();
                            Random rd = new Random();

                            for (int i = 0; i <= dem; i++)
                            {
                                int ngayrd = 0;
                                bool result = true;
                                while (result)
                                {
                                    ngayrd = rd.Next(1, daysInMonth + 1);
                                    if (!ngay.Exists(o => o == ngayrd.ToString())
                                        && !BOSApp.IsEndOfWeek(objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1).DayOfWeek)
                                        && !BOSApp.IsHoliday(objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1)))
                                    {
                                        result = false;
                                        if (timeSheet2 != null
                                            && timeSheet2.Exists(o => o.HRTimeSheetAuditEntryDate.Date == objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1).Date)
                                            || !dateList.Exists(o => o.Date == objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1).Date))
                                        {
                                            result = true;
                                        }
                                    }
                                }
                                ngay.Add(ngayrd.ToString());
                                if (i == dem)
                                {
                                    objTimeSheetParamsInfo = list.Where(o => o.HRTimeSheetParamValue1 == soDu).FirstOrDefault();
                                    if (objTimeSheetParamsInfo != null)
                                    {
                                        HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = new HRTimeSheetAuditEntrysInfo();
                                        objTimeSheetAuditEntrysInfo.FK_HREmployeeID = employeeID;
                                        objTimeSheetAuditEntrysInfo.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                        objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1);
                                        objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryWorkingHours = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                        objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objTimeSheetParamsInfo.HRTimeSheetParamValue2 / hoursPerDay;
                                        objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                        timeSheetEntrys.Add(objTimeSheetAuditEntrysInfo);
                                    }
                                }
                                else
                                {
                                    HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = new HRTimeSheetAuditEntrysInfo();
                                    objTimeSheetAuditEntrysInfo.FK_HREmployeeID = employeeID;
                                    objTimeSheetAuditEntrysInfo.FK_HRTimeSheetParamID = objTimeSheetParamsInfo.HRTimeSheetParamID;
                                    objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryDate = objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate.AddDays(ngayrd - 1);
                                    objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryWorkingHours = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                    objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryWorkingQty = objTimeSheetParamsInfo.HRTimeSheetParamValue1 * objTimeSheetParamsInfo.HRTimeSheetParamValue2 / hoursPerDay;
                                    objTimeSheetAuditEntrysInfo.HRTimeSheetAuditEntryFactor = objTimeSheetParamsInfo.HRTimeSheetParamValue2;
                                    timeSheetEntrys.Add(objTimeSheetAuditEntrysInfo);
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        //End

        #endregion
    }
}
