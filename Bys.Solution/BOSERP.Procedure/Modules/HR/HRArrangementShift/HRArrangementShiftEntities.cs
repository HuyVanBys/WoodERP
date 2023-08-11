using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRArrangementShift
{
    public class HRArrangementShiftEntities : BaseTransactionEntities
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
        public BOSList<HREmployeeArrangementShiftsInfo> EmployeeArrangementShiftList { get; set; }
        /// <summary>
        /// Gets or sets the time sheet entry list
        /// </summary>
        public BOSList<HRArrangementShiftEntrysInfo> ArrangementShiftEntryList { get; set; }

        /// <summary>
        /// Gets or sets the employee list
        /// </summary>
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }

        /// <summary>
        /// Gets or sets the list of all time sheet params
        /// </summary>
        public List<HRWorkingShiftsInfo> WorkingShifts { get; set; }
        #endregion

        #region Constructor
        public HRArrangementShiftEntities()
            : base()
        {
            EmployeeList = new BOSList<HREmployeesInfo>();
            ArrangementShiftEntryList = new BOSList<HRArrangementShiftEntrysInfo>();
            EmployeeArrangementShiftList = new BOSList<HREmployeeArrangementShiftsInfo>();

            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            WorkingShifts = objWorkingShiftsController.GetWorkingShiftListFromDataSet(objWorkingShiftsController.GetAllAliveObjects()).Where(o => o.FK_HRWorkingShiftID == 0).ToList();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRArrangementShiftsInfo();
            SearchObject = new HRArrangementShiftsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeArrangementShiftsTableName, new HREmployeeArrangementShiftsInfo());
            ModuleObjects.Add(TableName.HRArrangementShiftEntrysTableName, new HRArrangementShiftEntrysInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeArrangementShiftList.InitBOSList(
                                                this,
                                                TableName.HRArrangementShiftsTableName,
                                                TableName.HREmployeeArrangementShiftsTableName,
                                                BOSList<HREmployeeArrangementShiftsInfo>.cstRelationForeign);
            EmployeeArrangementShiftList.ItemTableForeignKey = "FK_HRArrangementShiftID";

            ArrangementShiftEntryList.InitBOSList(
                                             this,
                                             TableName.HRArrangementShiftsTableName,
                                             TableName.HRArrangementShiftEntrysTableName,
                                             BOSList<HRArrangementShiftEntrysInfo>.cstRelationForeign);
            ArrangementShiftEntryList.ItemTableForeignKey = "FK_HRArrangementShiftID";

            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeArrangementShiftList.InitBOSListGridControl();
            ArrangementShiftEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)MainObject;
            objArrangementShiftsInfo.HRArrangementShiftFromDate = BOSApp.GetCurrentServerDate();
            objArrangementShiftsInfo.HRArrangementShiftToDate = BOSApp.GetCurrentServerDate();
            objArrangementShiftsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeArrangementShiftList.SetDefaultListAndRefreshGridControl();
                ArrangementShiftEntryList.SetDefaultListAndRefreshGridControl();
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
            HRArrangementShiftEntrysController objArrangementShiftEntrysController = new HRArrangementShiftEntrysController();
            HREmployeeArrangementShiftsController objEmployeeArrangementShiftsController = new HREmployeeArrangementShiftsController();
            List<HREmployeeArrangementShiftsInfo> employeeArrangementShiftList = objEmployeeArrangementShiftsController.GetEmployeeArrangementShiftByArrangementShiftIDAndUserGroup(iObjectID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            EmployeeArrangementShiftList.Invalidate(employeeArrangementShiftList);
            foreach (HREmployeeArrangementShiftsInfo employeeArrangementShift in EmployeeArrangementShiftList)
            {
                employeeArrangementShift.HRArrangementShiftEntrysList = objArrangementShiftEntrysController.GetArrangementShiftEntrysByArrangementShiftIDAndEmployeeArrangementShiftID(
                                                                               employeeArrangementShift.FK_HRArrangementShiftID,
                                                                               employeeArrangementShift.HREmployeeArrangementShiftID);

                SetEmployeeArrangementShiftValue(employeeArrangementShift);
            }
        }

        /// <summary>
        /// Set employee time sheet value
        /// </summary>
        /// <param name="objEmployeeArrangementShiftsInfo">Given employee time sheet</param>        
        public void SetEmployeeArrangementShiftValue(HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo)
        {
            HRArrangementShiftsInfo arrangementShift = (HRArrangementShiftsInfo)MainObject;
            List<int> employeeArrangementShiftValueList = new List<int> {   0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                            0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
                                                                         };

            foreach (HRArrangementShiftEntrysInfo arrangementShiftEntry in objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList)
            {
                if (arrangementShiftEntry.HRArrangementShiftEntryDate.Date >= arrangementShift.HRArrangementShiftFromDate.Date &&
                    arrangementShiftEntry.HRArrangementShiftEntryDate.Date <= arrangementShift.HRArrangementShiftToDate.Date)
                {
                    int index = (int)(arrangementShiftEntry.HRArrangementShiftEntryDate.Date - arrangementShift.HRArrangementShiftFromDate.Date).TotalDays + 1;
                    if (index > 31)
                    {
                        MessageBox.Show("Bạn không thể chọn thời gian xếp ca quá 31 ngày!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int workingShifId = 0;
                    HRWorkingShiftsInfo objWorkingShiftsInfo = WorkingShifts.Where(o => o.HRWorkingShiftID == arrangementShiftEntry.FK_HRWorkingShiftID).FirstOrDefault();
                    if (objWorkingShiftsInfo != null)
                    {
                        workingShifId = objWorkingShiftsInfo.HRWorkingShiftID;
                    }
                    if (workingShifId > 0)
                    {
                        employeeArrangementShiftValueList[index - 1] = workingShifId;
                    }
                }
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            int numDays = ((HRArrangementShiftModule)Module).NumOfDayInMonth();
            for (int i = 1; i <= numDays; i++)
            {
                String propertyName = String.Format("{0}{1}", "HREmployeeArrangementShiftDate", i.ToString());
                dbUtil.SetPropertyValue(objEmployeeArrangementShiftsInfo, propertyName, employeeArrangementShiftValueList[i - 1]);
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
            HRArrangementShiftsInfo arrangementShift = (HRArrangementShiftsInfo)MainObject;
            //Save employee time sheet list
            EmployeeArrangementShiftList.SaveItemObjects();
            //Create entry for time sheet
            HRArrangementShiftEntrysController objArrangementShiftEntrysController = new HRArrangementShiftEntrysController();
            foreach (HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo in EmployeeArrangementShiftList)
            {
                objArrangementShiftEntrysController.DeleteByForeignColumn("FK_HREmployeeArrangementShiftID", objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftID);
                foreach (HRArrangementShiftEntrysInfo entry in objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList)
                {
                    if (entry.FK_HRWorkingShiftID == 0) continue;
                    entry.FK_HRArrangementShiftID = arrangementShift.HRArrangementShiftID;
                    entry.FK_HREmployeeArrangementShiftID = objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftID;
                    objArrangementShiftEntrysController.CreateObject(entry);
                }
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            if (strTableName == TableName.HRArrangementShiftsTableName)
            {
                HREmployeeArrangementShiftsController objEmployeeArrangementShiftsController = new HREmployeeArrangementShiftsController();
                objEmployeeArrangementShiftsController.DeleteByArrangementShiftID(iObjectID);
            }
        }

        public void GenerateEmployeeArrangementShift(HRArrangementShiftsInfo objArrangementShiftsInfo)
        {
            HRArrangementShiftEntrysController objArrangementShiftEntrysController = new HRArrangementShiftEntrysController();
            HREmployeeArrangementShiftsController objEmployeeArrangementShiftsController = new HREmployeeArrangementShiftsController();
            List<HREmployeeArrangementShiftsInfo> employeeArrangementShiftList = objEmployeeArrangementShiftsController.GetEmployeeArrangementShiftByArrangementShiftIDAndUserGroup(objArrangementShiftsInfo.HRArrangementShiftID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            employeeArrangementShiftList.ForEach(o =>
            {
                o.FK_HRArrangementShiftID = 0;
                o.HREmployeeArrangementShiftID = 0;
            });
            EmployeeArrangementShiftList.Invalidate(employeeArrangementShiftList);
        }
    }
}

