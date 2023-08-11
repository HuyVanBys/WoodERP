using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP057 : ReportForm
    {
        public RP057()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            int timeSheetTypeValue = Convert.ToInt32(fld_rdgTimeSheetType.EditValue);
            if (timeSheetTypeValue == 1)
            {
                RPTimeSheet report = new RPTimeSheet();
                //report.LoadLayout(BOSCommon.Constants.Report.DevTimeSheetReportPath);
                InitTimeSheetReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevTimeSheetReportPath, true);
                reviewer.Show();
            }
            else
            {
                ADReportsController objReportsController = new ADReportsController();
                RPTimeSheetDetail report = new RPTimeSheetDetail();
                //report.LoadLayout(BOSCommon.Constants.Report.DevTimeSheetDetailReportPath);
                InitTimeSheetReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevTimeSheetDetailReportPath, true);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Init time report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitTimeSheetReport(XtraReport report)
        {
            List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = SetEmployeeTimeSheetReportDataSource();
            if (employeeTimeSheetList.Count > 0)
            {
                //Set current branch
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                CSCompanysController objCompanysController = new CSCompanysController();
                CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                XRLabel xrMonth = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrMonth"];
                if (xrMonth != null)
                {

                    DateTime month = fld_dteTimeSheetDate.DateTime;
                    xrMonth.Text = month.ToString("MM/yyyy");
                }
                report.DataSource = employeeTimeSheetList;
            }
        }

        private void RP057_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteTimeSheetDate.EditValue = DateTime.Now;

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }
        }

        /// <summary>
        /// Sets the employee time sheet list for report data source
        /// </summary>
        /// <returns>Employee time sheet list</returns>
        private List<HREmployeeTimeSheetsInfo> SetEmployeeTimeSheetReportDataSource()
        {
            List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = new List<HREmployeeTimeSheetsInfo>();
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> timeSheetParamList = objTimeSheetParamsController.GetTimeSheetParamsList(string.Empty);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int timeSheetID = Convert.ToInt32(fld_lkeHRTimeSheetID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            DateTime month = fld_dteTimeSheetDate.DateTime;

            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<HREmployeeTimeSheetsInfo> result = objEmployeeTimeSheetsController.GetEmployeeTimeSheetList(null, branch.BRBranchID, departmentID, departmentRoomID, timeSheetID, month);
                    employeeTimeSheetList.AddRange(result);
                }
            }
            HRTimeSheetsInfo objTimeSheetInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(timeSheetID);
            DateTime beginMonthDate = new DateTime(fld_dteTimeSheetDate.DateTime.Year, fld_dteTimeSheetDate.DateTime.Month, 1);
            DateTime endMonthDate = BOSUtil.GetMonthEndDate(beginMonthDate);
            if (objTimeSheetInfo != null)
            {
                beginMonthDate = objTimeSheetInfo.HRTimeSheetFromDate;
                endMonthDate = objTimeSheetInfo.HRTimeSheetToDate;
            }
            HRCalendarEntrysController objCalendarEntrysController = new HRCalendarEntrysController();
            List<HRCalendarEntrysInfo> entries = objCalendarEntrysController.GetCalendarEntryByDateAndCalenderType(CalendarType.Holiday.ToString(), beginMonthDate, endMonthDate);
            decimal HoursPerDay = GetHourPerDay();
            if (employeeTimeSheetList.Count > 0)
            {
                foreach (HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo in employeeTimeSheetList)
                {
                    List<string> employeeTimeSheetValueList = new List<string> {   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty
                                                                            };
                    List<HRTimeSheetEntrysInfo> timeSheetEntryList = objTimeSheetEntrysController.GetTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(
                                                                                            objEmployeeTimeSheetsInfo.FK_HRTimeSheetID,
                                                                                            objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID);
                    foreach (HRTimeSheetEntrysInfo timeSheetEntry in timeSheetEntryList)
                    {
                        int index = timeSheetEntry.HRTimeSheetEntryDate.Day;
                        string timeSheetParamNo = string.Empty;
                        HRTimeSheetParamsInfo objTimeSheetParamsInfo = timeSheetParamList.Where(t => t.HRTimeSheetParamID == timeSheetEntry.FK_HRTimeSheetParamID).FirstOrDefault();
                        if (objTimeSheetParamsInfo != null)
                        {
                            timeSheetParamNo = objTimeSheetParamsInfo.HRTimeSheetParamNo;
                        }

                        if (string.IsNullOrEmpty(employeeTimeSheetValueList[index - 1].Trim()))
                        {
                            employeeTimeSheetValueList[index - 1] = timeSheetParamNo;
                        }
                        else
                        {
                            employeeTimeSheetValueList[index - 1] += String.Format(", {0}", timeSheetParamNo);
                        }
                        // is holiday
                        HRCalendarEntrysInfo holiday = entries.Where(x => x.HRCalendarEntryDate.Date == timeSheetEntry.HRTimeSheetEntryDate.Date).FirstOrDefault();
                        DateTime isNightOTDateTime = new DateTime(timeSheetEntry.HRTimeSheetEntryTo.Year, timeSheetEntry.HRTimeSheetEntryTo.Month, timeSheetEntry.HRTimeSheetEntryTo.Day);
                        DateTime isOTDateTime = new DateTime(timeSheetEntry.HRTimeSheetEntryTo.Year, timeSheetEntry.HRTimeSheetEntryTo.Month, timeSheetEntry.HRTimeSheetEntryTo.Day);
                        isNightOTDateTime = isNightOTDateTime.AddHours(22);
                        isOTDateTime = isOTDateTime.AddHours(17);
                        //HRTimeSheetEntryFactor > 0 is OT
                        if (timeSheetEntry.HRTimeSheetEntryFactor > 0 && BOSApp.IsEndOfWeek(timeSheetEntry.HRTimeSheetEntryDate.DayOfWeek))
                        {


                            if (timeSheetEntry.HRTimeSheetEntryTo > isNightOTDateTime)
                            {
                                objEmployeeTimeSheetsInfo.HREmployeeOTOnSundayAtNight += timeSheetEntry.HRTimeSheetEntryWorkingHours;
                            }
                            else
                            {
                                objEmployeeTimeSheetsInfo.HREmployeeOTOnSundayAtDay += timeSheetEntry.HRTimeSheetEntryWorkingHours;
                            }
                        }
                        else if (timeSheetEntry.HRTimeSheetEntryFactor > 0 && holiday != null && holiday.HRCalendarEntryDate.Date == timeSheetEntry.HRTimeSheetEntryDate.Date)
                        {
                            if (timeSheetEntry.HRTimeSheetEntryTo > isNightOTDateTime)
                            {
                                objEmployeeTimeSheetsInfo.HREmployeeOTLeAtNight += timeSheetEntry.HRTimeSheetEntryWorkingHours;
                            }
                            else
                            {
                                objEmployeeTimeSheetsInfo.HREmployeeOTLeAtDay += timeSheetEntry.HRTimeSheetEntryWorkingHours;
                            }
                        }
                        else if (timeSheetEntry.HRTimeSheetEntryFactor > 0)
                        {
                            if (timeSheetEntry.HRTimeSheetEntryTo > isNightOTDateTime)
                            {
                                objEmployeeTimeSheetsInfo.HREmployeeOTAtNight += timeSheetEntry.HRTimeSheetEntryWorkingHours;
                            }
                            else
                            {
                                objEmployeeTimeSheetsInfo.HREmployeeOTAtDay += timeSheetEntry.HRTimeSheetEntryWorkingHours;
                            }

                        }
                    }

                    BOSDbUtil dbUtil = new BOSDbUtil();
                    for (int i = 0; i < 31; i++)
                    {
                        String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", (i + 1).ToString());
                        dbUtil.SetPropertyValue(objEmployeeTimeSheetsInfo, propertyName, employeeTimeSheetValueList[i]);
                    }
                    objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingHour = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * HoursPerDay;
                }
            }
            return employeeTimeSheetList;
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
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_lkeHRTimeSheetID_QueryPopUp(object sender, CancelEventArgs e)
        {
            DateTime date = new DateTime();
            if (fld_dteTimeSheetDate.EditValue != null)
            {
                DateTime.TryParse(fld_dteTimeSheetDate.EditValue.ToString(), out date);
            }
            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            List<HRTimeSheetsInfo> TimeSheetList = new List<HRTimeSheetsInfo>();
            TimeSheetList = objTimeSheetsController.GetTimeSheetListByMonth(date);
            if (TimeSheetList != null)
                fld_lkeHRTimeSheetID.Properties.DataSource = TimeSheetList;
        }
    }
}
