using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.HRTimeSheet
{
    public class HRTimeSheetEntities : BaseTransactionEntities
    {
        #region Declare Constant
        /// <summary>
        /// List day of month
        /// </summary>
        private static int[] DayOfMonth = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                                            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                                            29, 30, 31 };
        #endregion

        #region Declare all entities variables        
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the employee time sheet list
        /// </summary>
        public BOSList<HREmployeeTimeSheetsInfo> EmployeeTimeSheetList { get; set; }
        /// <summary>
        /// Gets or sets the time sheet entry list
        /// </summary>
        public BOSList<HRTimeSheetEntrysInfo> TimeSheetEntryList { get; set; }

        /// <summary>
        /// Gets or sets the employee list
        /// </summary>
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }

        /// <summary>
        /// Gets or sets the list of all time sheet params
        /// </summary>
        public List<HRTimeSheetParamsInfo> TimeSheetParams { get; set; }

        /// <summary>
        /// Gets or sets the list of all overtime factors of all employees
        /// </summary>
        //public List<HREmployeeOTFactorsInfo> OTFactors { get; set; }
        public List<HROTFactorsInfo> OTFactors { get; set; }

        /// <summary>
        /// Gets or sets the list of all holiday calendar entries
        /// </summary>
        public List<HRCalendarEntrysInfo> HolidayCalendarEntries { get; set; }
        #endregion

        #region Constructor
        public HRTimeSheetEntities()
            : base()
        {
            EmployeeList = new BOSList<HREmployeesInfo>();
            TimeSheetEntryList = new BOSList<HRTimeSheetEntrysInfo>();
            EmployeeTimeSheetList = new BOSList<HREmployeeTimeSheetsInfo>();

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            TimeSheetParams = objTimeSheetParamsController.GetTimeSheetParamsList(string.Empty);
            //NUThao get OTFactor in payroll formula
            //HREmployeeOTFactorsController objEmployeeOTFactorsController = new HREmployeeOTFactorsController();
            //OTFactors = objEmployeeOTFactorsController.GetAllFactors();
            HROTFactorsController otFactorController = new HROTFactorsController();
            OTFactors = otFactorController.GetAllEmployeeFactors();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRTimeSheetsInfo();
            SearchObject = new HRTimeSheetsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeTimeSheetsTableName, new HREmployeeTimeSheetsInfo());
            ModuleObjects.Add(TableName.HRTimeSheetEntrysTableName, new HRTimeSheetEntrysInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {

            EmployeeTimeSheetList.InitBOSList(
                                                this,
                                                TableName.HRTimeSheetsTableName,
                                                TableName.HREmployeeTimeSheetsTableName,
                                                BOSList<HREmployeeTimeSheetsInfo>.cstRelationForeign);
            EmployeeTimeSheetList.ItemTableForeignKey = "FK_HRTimeSheetID";

            TimeSheetEntryList.InitBOSList(
                                             this,
                                             TableName.HRTimeSheetsTableName,
                                             TableName.HRTimeSheetEntrysTableName,
                                             BOSList<HRTimeSheetEntrysInfo>.cstRelationForeign);
            TimeSheetEntryList.ItemTableForeignKey = "FK_HRTimeSheetID";

            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeTimeSheetList.InitBOSListGridControl();
            TimeSheetEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)MainObject;
            objTimeSheetsInfo.HRTimeSheetDate = DateTime.Now;
            objTimeSheetsInfo.HRTimeSheetFromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            objTimeSheetsInfo.HRTimeSheetToDate = BOSUtil.GetMonthEndDate(DateTime.Now);
            objTimeSheetsInfo.HRTimeSheetType = TimeSheetType.Day.ToString();
            objTimeSheetsInfo.HRTimeSheetStatus = TimeSheetStatus.New.ToString();
            objTimeSheetsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeTimeSheetList.SetDefaultListAndRefreshGridControl();
                TimeSheetEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HREmployeeTimeSheetOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetOTDetailsController();
            // Origin : List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = objEmployeeTimeSheetsController.GetEmployeeTimeSheetsByTimeSheetID(iObjectID);
            List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = objEmployeeTimeSheetsController.GetEmployeeTimeSheetByTimeSheetIDAndUserGroup(iObjectID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            EmployeeTimeSheetList.Invalidate(employeeTimeSheetList);
            foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in EmployeeTimeSheetList)
            {
                employeeTimeSheet.HRTimeSheetEntrysList = objTimeSheetEntrysController.GetTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(
                                                                               employeeTimeSheet.FK_HRTimeSheetID,
                                                                               employeeTimeSheet.HREmployeeTimeSheetID);
                //if (employeeTimeSheet.HRTimeSheetEntrysList != null)
                //    employeeTimeSheet.HREmployeeTimeSheetPermissionOTDaysOff = employeeTimeSheet.HRTimeSheetEntrysList.Sum(x => x.HRTimeSheetEntryPermissionOTDaysOff);
                employeeTimeSheet.HREmployeeTimeSheetOTDetailsList = objEmployeeTimeSheetOTDetailsController.GetListTimeSheetOTDetailByEmployeeTimeSheet(employeeTimeSheet.HREmployeeTimeSheetID);
                SetEmployeeTimeSheetValue(employeeTimeSheet);
            }
        }

        /// <summary>
        /// Set employee time sheet value
        /// </summary>
        /// <param name="objEmployeeTimeSheetsInfo">Given employee time sheet</param>        
        public void SetEmployeeTimeSheetValue(HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo)
        {
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)MainObject;
            List<string> employeeTimeSheetValueList = new List<string> {   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty
                                                                            };

            foreach (HRTimeSheetEntrysInfo timeSheetEntry in objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList)
            {
                if (timeSheetEntry.HRTimeSheetEntryDate.Date >= timeSheet.HRTimeSheetFromDate.Date &&
                    timeSheetEntry.HRTimeSheetEntryDate.Date <= timeSheet.HRTimeSheetToDate.Date)
                {
                    int index = (int)(timeSheetEntry.HRTimeSheetEntryDate.Date - timeSheet.HRTimeSheetFromDate.Date).TotalDays + 1;
                    string timeSheetParamNo = string.Empty;
                    HRTimeSheetParamsInfo objTimeSheetParamsInfo = TimeSheetParams.Where(t => t.HRTimeSheetParamID == timeSheetEntry.FK_HRTimeSheetParamID).FirstOrDefault();
                    if (objTimeSheetParamsInfo != null)
                    {
                        timeSheetParamNo = objTimeSheetParamsInfo.HRTimeSheetParamNo;
                    }
                    if (!string.IsNullOrEmpty(timeSheetParamNo))
                    {
                        if (index - 1 >= employeeTimeSheetValueList.Count) continue;
                        if (string.IsNullOrEmpty(employeeTimeSheetValueList[index - 1].Trim()))
                        {
                            employeeTimeSheetValueList[index - 1] = timeSheetParamNo;
                        }
                        else
                        {
                            employeeTimeSheetValueList[index - 1] += String.Format(", {0}", timeSheetParamNo);
                        }
                    }
                }
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            int numDays = ((HRTimeSheetModule)Module).NumOfDayInMonth();
            for (int i = 1; i <= numDays; i++)
            {
                String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetDate", i.ToString());
                if (i - 1 < employeeTimeSheetValueList.Count)
                    dbUtil.SetPropertyValue(objEmployeeTimeSheetsInfo, propertyName, employeeTimeSheetValueList[i - 1]);
            }
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)MainObject;
            //Save employee time sheet list
            List<int> EmployeeTimeSheetID = EmployeeTimeSheetList.Where(x => x.HREmployeeTimeSheetID == 0).Select(x => x.HREmployeeTimeSheetID).Distinct().ToList();
            EmployeeTimeSheetList.SaveItemObjects();
            //Create entry for time sheet
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            HREmployeeTimeSheetOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetOTDetailsController();
            //Trường hợp tạo mới
            if (EmployeeTimeSheetID != null && EmployeeTimeSheetID.Count > 0)
            {
                foreach (HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo in EmployeeTimeSheetList)
                {
                    objTimeSheetEntrysController.DeleteByForeignColumn("FK_HREmployeeTimeSheetID", objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID);
                    foreach (HRTimeSheetEntrysInfo entry in objEmployeeTimeSheetsInfo.HRTimeSheetEntrysList)
                    {
                        if (entry.FK_HRTimeSheetParamID == 0) continue;
                        entry.FK_HRTimeSheetID = timeSheet.HRTimeSheetID;
                        entry.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                        objTimeSheetEntrysController.CreateObject(entry);
                    }
                    objEmployeeTimeSheetOTDetailsController.DeleteByForeignColumn("FK_HREmployeeTimeSheetID", objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID);
                    foreach (HREmployeeTimeSheetOTDetailsInfo obj in objEmployeeTimeSheetsInfo.HREmployeeTimeSheetOTDetailsList)
                    {
                        obj.FK_HREmployeeTimeSheetID = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetID;
                        objEmployeeTimeSheetOTDetailsController.CreateObject(obj);
                    }
                }
            }

        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            if (strTableName == TableName.HRTimeSheetsTableName)
            {
                HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
                objEmployeeTimeSheetsController.DeleteByTimeSheetID(iObjectID);
            }
        }
    }
}

