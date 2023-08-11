using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Modules.HRTimeSheetAudit;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Module.HRTimeSheetAudit
{
    public class HRTimeSheetAuditEntities : BaseTransactionEntities
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
        public BOSList<HREmployeeTimeSheetAuditsInfo> EmployeeTimeSheetAuditList { get; set; }
        /// <summary>
        /// Gets or sets the time sheet entry list
        /// </summary>
        public BOSList<HRTimeSheetAuditEntrysInfo> TimeSheetAuditEntrysList { get; set; }

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
        public HRTimeSheetAuditEntities()
            : base()
        {
            EmployeeList = new BOSList<HREmployeesInfo>();
            TimeSheetAuditEntrysList = new BOSList<HRTimeSheetAuditEntrysInfo>();
            EmployeeTimeSheetAuditList = new BOSList<HREmployeeTimeSheetAuditsInfo>();

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            TimeSheetParams = objTimeSheetParamsController.GetTimeSheetParamsList(string.Empty);

            HROTFactorsController otFactorController = new HROTFactorsController();
            OTFactors = otFactorController.GetAllEmployeeFactors();
        }

        #endregion

        public override void InitMainObject()
        {
            MainObject = new HRTimeSheetAuditsInfo();
            SearchObject = new HRTimeSheetAuditsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeTimeSheetAuditsTableName, new HREmployeeTimeSheetAuditsInfo());
            ModuleObjects.Add(TableName.HRTimeSheetAuditEntrysTableName, new HRTimeSheetAuditEntrysInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {

            EmployeeTimeSheetAuditList.InitBOSList(
                                                this,
                                                TableName.HRTimeSheetAuditsTableName,
                                                TableName.HREmployeeTimeSheetAuditsTableName,
                                                BOSList<HREmployeeTimeSheetAuditsInfo>.cstRelationForeign);
            EmployeeTimeSheetAuditList.ItemTableForeignKey = "FK_HRTimeSheetAuditID";

            TimeSheetAuditEntrysList.InitBOSList(
                                             this,
                                             TableName.HRTimeSheetAuditsTableName,
                                             TableName.HRTimeSheetAuditEntrysTableName,
                                             BOSList<HRTimeSheetAuditEntrysInfo>.cstRelationForeign);
            TimeSheetAuditEntrysList.ItemTableForeignKey = "FK_HRTimeSheetAuditID";

            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeTimeSheetAuditList.InitBOSListGridControl();
            TimeSheetAuditEntrysList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRTimeSheetAuditsInfo objTimeSheetAuditsInfo = (HRTimeSheetAuditsInfo)MainObject;
            objTimeSheetAuditsInfo.HRTimeSheetAuditDate = DateTime.Now;
            objTimeSheetAuditsInfo.HRTimeSheetAuditFromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            objTimeSheetAuditsInfo.HRTimeSheetAuditToDate = BOSUtil.GetMonthEndDate(DateTime.Now);
            objTimeSheetAuditsInfo.HRTimeSheetAuditType = TimeSheetAuditType.Day.ToString();
            objTimeSheetAuditsInfo.HRTimeSheetAuditStatus = TimeSheetAuditStatus.New.ToString();
            objTimeSheetAuditsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeTimeSheetAuditList.SetDefaultListAndRefreshGridControl();
                TimeSheetAuditEntrysList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRTimeSheetAuditEntrysController objTimeSheetAuditEntrysController = new HRTimeSheetAuditEntrysController();
            HREmployeeTimeSheetAuditsController objEmployeeTimeSheetAuditsController = new HREmployeeTimeSheetAuditsController();
            HREmployeeTimeSheetAuditOTDetailsController objEmployeeTimeSheetAuditOTDetailsController = new HREmployeeTimeSheetAuditOTDetailsController();
            List<HREmployeeTimeSheetAuditsInfo> employeeTimeSheetAudit = objEmployeeTimeSheetAuditsController.GetEmployeeTimeSheetByTimeSheetAuditIDAndUserGroup(iObjectID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            EmployeeTimeSheetAuditList.Invalidate(employeeTimeSheetAudit);
            foreach (HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAudit in EmployeeTimeSheetAuditList)
            {
                objEmployeeTimeSheetAudit.HRTimeSheetAuditEntrysList = objTimeSheetAuditEntrysController.GetTimeSheetAuditEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(
                                                                               objEmployeeTimeSheetAudit.FK_HRTimeSheetAuditID,
                                                                               objEmployeeTimeSheetAudit.HREmployeeTimeSheetAuditID);

                objEmployeeTimeSheetAudit.HREmployeeTimeSheetAuditOTDetailsList = objEmployeeTimeSheetAuditOTDetailsController.GetListTimeSheetAuditOTDetailByEmployeeTimeSheetAudit(objEmployeeTimeSheetAudit.HREmployeeTimeSheetAuditID);
                SetEmployeeTimeSheetAuditValue(objEmployeeTimeSheetAudit);
            }
        }

        /// <summary>
        /// Set employee time sheet value
        /// </summary>
        /// <param name="objEmployeeTimeSheetsInfo">Given employee time sheet</param>        
        public void SetEmployeeTimeSheetAuditValue(HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo)
        {
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)MainObject;
            List<string> employeeTimeSheetAuditValueList = new List<string> {   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                                                   string.Empty
                                                                            };

            foreach (HRTimeSheetAuditEntrysInfo timeSheetEntry in objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList)
            {
                if (timeSheetEntry.HRTimeSheetAuditEntryDate.Date >= timeSheetAudit.HRTimeSheetAuditFromDate.Date &&
                    timeSheetEntry.HRTimeSheetAuditEntryDate.Date <= timeSheetAudit.HRTimeSheetAuditToDate.Date)
                {
                    int index = (int)(timeSheetEntry.HRTimeSheetAuditEntryDate.Date - timeSheetAudit.HRTimeSheetAuditFromDate.Date).TotalDays + 1;
                    string timeSheetParamNo = string.Empty;
                    HRTimeSheetParamsInfo objTimeSheetParamsInfo = TimeSheetParams.Where(t => t.HRTimeSheetParamID == timeSheetEntry.FK_HRTimeSheetParamID).FirstOrDefault();
                    if (objTimeSheetParamsInfo != null)
                    {
                        timeSheetParamNo = objTimeSheetParamsInfo.HRTimeSheetParamNo;
                    }
                    if (!string.IsNullOrEmpty(timeSheetParamNo))
                    {
                        if (string.IsNullOrEmpty(employeeTimeSheetAuditValueList[index - 1].Trim()))
                        {
                            employeeTimeSheetAuditValueList[index - 1] = timeSheetParamNo;
                        }
                        else
                        {
                            employeeTimeSheetAuditValueList[index - 1] += String.Format(", {0}", timeSheetParamNo);
                        }
                    }
                }
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            int numDays = ((HRTimeSheetAuditModule)Module).NumOfDayInMonth();
            for (int i = 1; i <= numDays; i++)
            {
                String propertyName = String.Format("{0}{1}", "HREmployeeTimeSheetAuditDate", i.ToString());
                dbUtil.SetPropertyValue(objEmployeeTimeSheetAuditsInfo, propertyName, employeeTimeSheetAuditValueList[i - 1]);
            }
        }

        //public override void SaveModuleObjects()
        //{
        //    HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)MainObject;
        //    EmployeeTimeSheetAuditList.SaveItemObjects();
        //    HRTimeSheetAuditEntrysController objTimeSheetEntrysController = new HRTimeSheetAuditEntrysController();
        //    HREmployeeTimeSheetAuditOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetAuditOTDetailsController();
        //    foreach (HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo in EmployeeTimeSheetAuditList)
        //    {
        //        objTimeSheetEntrysController.DeleteByForeignColumn("FK_HREmployeeTimeSheetAuditID", objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID);
        //        foreach (HRTimeSheetAuditEntrysInfo entry in objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList)
        //        {
        //            if (entry.FK_HRTimeSheetParamID == 0) continue;
        //            entry.FK_HRTimeSheetAuditID = timeSheetAudit.HRTimeSheetAuditID;
        //            entry.FK_HREmployeeTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID;
        //            objTimeSheetEntrysController.CreateObject(entry);
        //        }
        //        objEmployeeTimeSheetOTDetailsController.DeleteByForeignColumn("FK_HREmployeeTimeSheetAuditID", objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID);
        //        foreach (HREmployeeTimeSheetAuditOTDetailsInfo obj in objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList)
        //        {
        //            obj.FK_HREmployeeTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID;
        //            objEmployeeTimeSheetOTDetailsController.CreateObject(obj);
        //        }
        //    }
        //}

        public override void SaveModuleObjects()
        {
            HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)MainObject;
            EmployeeTimeSheetAuditList.SaveItemObjects();
            HRTimeSheetAuditEntrysController objTimeSheetEntrysController = new HRTimeSheetAuditEntrysController();
            HREmployeeTimeSheetAuditOTDetailsController objEmployeeTimeSheetOTDetailsController = new HREmployeeTimeSheetAuditOTDetailsController();

            List<HRTimeSheetAuditEntrysInfo> listTimeSheetAuditEntry = new List<HRTimeSheetAuditEntrysInfo>();
            List<HREmployeeTimeSheetAuditOTDetailsInfo> listEmployeeTimeSheetAuditOTDetail = new List<HREmployeeTimeSheetAuditOTDetailsInfo>();

            bool result = objTimeSheetEntrysController.DeleteTimeSheetAuditEntryByTimeSheetAuditID(timeSheetAudit.HRTimeSheetAuditID);
            if (result)
            {
                foreach (HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo in EmployeeTimeSheetAuditList)
                {
                    //objTimeSheetEntrysController.DeleteByForeignColumn("FK_HREmployeeTimeSheetAuditID", objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID);
                    objEmployeeTimeSheetOTDetailsController.DeleteByForeignColumn("FK_HREmployeeTimeSheetAuditID", objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID);

                    foreach (HRTimeSheetAuditEntrysInfo entry in objEmployeeTimeSheetAuditsInfo.HRTimeSheetAuditEntrysList)
                    {
                        if (entry.FK_HRTimeSheetParamID == 0) continue;
                        entry.FK_HRTimeSheetAuditID = timeSheetAudit.HRTimeSheetAuditID;
                        entry.FK_HREmployeeTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID;
                        entry.HRTimeSheetAuditEntryID = 0;
                        //objTimeSheetEntrysController.CreateObject(entry);
                        listTimeSheetAuditEntry.Add(entry);
                    }

                    foreach (HREmployeeTimeSheetAuditOTDetailsInfo obj in objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditOTDetailsList)
                    {
                        obj.FK_HREmployeeTimeSheetAuditID = objEmployeeTimeSheetAuditsInfo.HREmployeeTimeSheetAuditID;
                        obj.HREmployeeTimeSheetAuditOTDetailID = 0;
                        //objEmployeeTimeSheetOTDetailsController.CreateObject(obj);
                        listEmployeeTimeSheetAuditOTDetail.Add(obj);
                    }
                }
            }

            if (listTimeSheetAuditEntry.Count() > 0)
            {
                SaveItemWithDataTableType.SaveItemWithoutDelete<HRTimeSheetAuditEntrysInfo>(listTimeSheetAuditEntry,
                    "HRTimeSheetAuditEntryID", "HRTimeSheetAuditEntrys", timeSheetAudit.HRTimeSheetAuditID, BOSApp.CurrentUsersInfo.ADUserName);
            }

            if (listEmployeeTimeSheetAuditOTDetail.Count() > 0)
            {
                SaveItemWithDataTableType.SaveItemWithoutDelete<HREmployeeTimeSheetAuditOTDetailsInfo>(listEmployeeTimeSheetAuditOTDetail,
                    "HREmployeeTimeSheetAuditOTDetailID", "HREmployeeTimeSheetAuditOTDetails", timeSheetAudit.HRTimeSheetAuditID, BOSApp.CurrentUsersInfo.ADUserName);
            }
        }

        #endregion
    }
}
