using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.HRTrainningCourse
{
    public class HRTrainningCourseEntities : ERPModuleEntities
    {
        #region Declare Constant
        //public const string CreateSchedulesButtonName = "fld_btnCreateSchedule";
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of trainning class
        /// </summary>
        public BOSList<HRTrainningClassInfo> HRTrainningClassList { get; set; }
        /// <summary>
        /// Gets or sets the list of trainning employees
        /// </summary>
        public BOSList<HRTrainningEmployeesInfo> HRTrainningEmployeesList { get; set; }
        /// <summary>
        /// Gets or sets the list of class schedules
        /// </summary>
        public BOSList<HRClassSchedulesInfo> HRClassSchedulesList { get; set; }
        /// <summary>
        /// Gets or sets the list of trainning schedules
        /// </summary>
        public BOSList<HRTrainningSchedulesInfo> HRTrainningSchedulesList { get; set; }
        /// <summary>
        /// Gets or sets the temp list of trainning schedules
        /// </summary>
        public BOSList<HRTrainningSchedulesInfo> HRTrainningSchedulesListTemp { get; set; }
        #endregion

        #region Constructor
        public HRTrainningCourseEntities()
            : base()
        {
            HRTrainningClassList = new BOSList<HRTrainningClassInfo>();
            HRTrainningEmployeesList = new BOSList<HRTrainningEmployeesInfo>();
            HRClassSchedulesList = new BOSList<HRClassSchedulesInfo>();
            HRTrainningSchedulesList = new BOSList<HRTrainningSchedulesInfo>();
            HRTrainningSchedulesListTemp = new BOSList<HRTrainningSchedulesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRTrainningCoursesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRTrainningClassTableName, new HRTrainningClassInfo());
            ModuleObjects.Add(TableName.HRTrainningEmployeesTableName, new HRTrainningEmployeesInfo());
            ModuleObjects.Add(TableName.HRClassSchedulesTableName, new HRClassSchedulesInfo());
            ModuleObjects.Add(TableName.HRTrainningSchedulesTableName, new HRTrainningSchedulesInfo());
        }

        public override void InitModuleObjectList()
        {
            HRTrainningClassList.InitBOSList(
                                            this,
                                            TableName.HRTrainningCoursesTableName,
                                            TableName.HRTrainningClassTableName,
                                            BOSList<HRTrainningClassInfo>.cstRelationForeign);
            HRTrainningClassList.ItemTableForeignKey = "FK_HRTrainningCourseID";
            HRTrainningEmployeesList.InitBOSList(
                                            this,
                                            TableName.HRTrainningCoursesTableName,
                                            TableName.HRTrainningEmployeesTableName,
                                            BOSList<HRTrainningEmployeesInfo>.cstRelationForeign);
            HRTrainningEmployeesList.ItemTableForeignKey = "FK_HRTrainningCourseID";
            HRClassSchedulesList.InitBOSList(
                                            this,
                                            TableName.HRTrainningClassTableName,
                                            TableName.HRClassSchedulesTableName,
                                            BOSList<HRClassSchedulesInfo>.cstRelationForeign);
            HRClassSchedulesList.ItemTableForeignKey = "FK_HRTrainningClassID";
            HRTrainningSchedulesList.InitBOSList(
                                            this,
                                            TableName.HRClassSchedulesTableName,
                                            TableName.HRTrainningSchedulesTableName,
                                            BOSList<HRTrainningSchedulesInfo>.cstRelationNone);
            HRTrainningSchedulesList.ItemTableForeignKey = "FK_HRClassScheduleID";
            HRTrainningSchedulesListTemp.InitBOSList(
                                            this,
                                            TableName.HRClassSchedulesTableName,
                                            TableName.HRTrainningSchedulesTableName,
                                            BOSList<HRTrainningSchedulesInfo>.cstRelationNone);
            HRTrainningSchedulesList.ItemTableForeignKey = "FK_HRClassScheduleID";
        }

        public override void InitGridControlInBOSList()
        {
            HRTrainningClassList.InitBOSListGridControl(HRTrainningCourseModule.TrainningClassGridControlName);
            HRTrainningEmployeesList.InitBOSListGridControl();
            HRClassSchedulesList.InitBOSListGridControl(HRTrainningCourseModule.ClassSchedulesGridControlName);
            HRTrainningSchedulesList.InitBOSListGridControl();
            HRTrainningSchedulesListTemp.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRTrainningClassList.SetDefaultListAndRefreshGridControl();
                HRTrainningEmployeesList.SetDefaultListAndRefreshGridControl();
                HRClassSchedulesList.SetDefaultListAndRefreshGridControl();
                HRTrainningSchedulesList.SetDefaultListAndRefreshGridControl();
                HRTrainningSchedulesListTemp.SetDefaultListAndRefreshGridControl();
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
            HRTrainningClassList.Invalidate(iObjectID);
            InvalidateClassSchedules();
            InvalidateTrainningEmployees(iObjectID);
            InvalidateTrainningSchedules(iObjectID);
        }
        /// <summary>
        /// Invalidate trainning employee
        /// </summary>
        /// <param name="trainningCourseID"></param>
        public void InvalidateTrainningEmployees(int trainningCourseID)
        {
            HRTrainningEmployeesController objTrainningEmployeesController = new HRTrainningEmployeesController();
            DataSet dsTrainningEmployees = objTrainningEmployeesController.GetTrainningEmployeesByTrainningCourseIDAndTrainningEmployeeType(trainningCourseID, TrainningEmployee.Teacher.ToString());
            HRTrainningEmployeesList.Invalidate(dsTrainningEmployees);
        }

        /// <summary>
        /// Invalidate Class Schedules
        /// </summary>
        public void InvalidateClassSchedules()
        {
            HRClassSchedulesGridControl classSchedulesGridControl = (HRClassSchedulesGridControl)Module.Controls[HRTrainningCourseModule.ClassSchedulesGridControlName];
            if (HRTrainningClassList.Count > 0)
            {
                HRTrainningClassInfo objTrainningClassInfo = HRTrainningClassList[0];
                if (objTrainningClassInfo.HRClassSchedulesList == null)
                {
                    objTrainningClassInfo.HRClassSchedulesList = new BOSList<HRClassSchedulesInfo>();
                    objTrainningClassInfo.HRClassSchedulesList.InitBOSList(this,
                                                                                    TableName.HRTrainningClassTableName,
                                                                                    TableName.HRClassSchedulesTableName,
                                                                                    BOSList<HRClassSchedulesInfo>.cstRelationForeign);
                    objTrainningClassInfo.HRClassSchedulesList.ItemTableForeignKey = "FK_HRTrainningClassID";
                    ((BOSList<HRClassSchedulesInfo>)objTrainningClassInfo.HRClassSchedulesList).GridControl = classSchedulesGridControl;
                    if (objTrainningClassInfo.HRTrainningClassID > 0)
                    {
                        objTrainningClassInfo.HRClassSchedulesList.Invalidate(objTrainningClassInfo.HRTrainningClassID);
                    }
                }
                classSchedulesGridControl.InvalidateDataSource(objTrainningClassInfo.HRClassSchedulesList);
            }

        }

        /// <summary>
        /// Invalidate trainning schedules when user choose trainning course
        /// or click the "Create Schedules" button
        /// </summary>
        /// <param name="trainningCourseID">ID of trainning course</param>
        public void InvalidateTrainningSchedules(int trainningCourseID)
        {
            HRTrainningSchedulesController objTrainningSchedulesController = new HRTrainningSchedulesController();
            DataSet dsTrainningSchedule = objTrainningSchedulesController.GetTrainningSchedulesByTrainningCourseID(trainningCourseID);
            HRTrainningSchedulesList.Invalidate(dsTrainningSchedule);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();

        }
        public override void SaveModuleObjects()
        {
            HRTrainningEmployeesList.SaveItemObjects();
            HRTrainningClassList.SaveItemObjects();
            SaveClassSchedules(HRTrainningClassList);
            HRTrainningSchedulesList.SaveItemObjects();
        }
        /// <summary>
        /// Save class schedules following each of trainning class
        /// </summary>
        /// <param name="trainningClassList">The list of trainning class</param>
        private void SaveClassSchedules(BOSList<HRTrainningClassInfo> trainningClassList)
        {
            foreach (HRTrainningClassInfo objTrainningClassInfo in trainningClassList)
            {
                if (objTrainningClassInfo.HRClassSchedulesList != null)
                {
                    foreach (HRClassSchedulesInfo objClassSchedulesInfo in objTrainningClassInfo.HRClassSchedulesList)
                    {
                        objClassSchedulesInfo.FK_HRTrainningClassID = objTrainningClassInfo.HRTrainningClassID;
                    }
                    objTrainningClassInfo.HRClassSchedulesList.SaveItemObjects();
                }
            }
        }

        #endregion

        #region local
        /// <summary>
        /// Calcuate num of day
        /// </summary>
        /// <param name="day">The day</param>
        /// <param name="month">The month</param>
        /// <param name="year">The year</param>
        /// <returns>num of day</returns>
        public int CalculateDay(int day, int month, int year)
        {
            if (month < 3)
            {
                month = month + 12;
                year = year - 1;
            }
            return (Math.Abs(day + 2 * month + 3 * (month + 1) / 5 + year + year / 4) % 7);
        }
        /// <summary>
        /// Calculate range of days of start date and current date
        /// </summary>
        /// <param name="startDate">The start date</param>
        /// <param name="numOfDay">The num of day</param>
        /// <returns>current date add more range</returns>
        public DateTime CalculateDate(DateTime startDate, string numOfDay)
        {
            int numDay = ConvertNumOfDayToNumDay(numOfDay);
            int startDay = CalculateDay(startDate.Day, startDate.Month, startDate.Year);
            startDay = startDay != 0 ? startDay : 7;
            int range = numDay - startDay;
            range = (range >= 0) ? range : (7 - Math.Abs(range));
            startDate = startDate.AddDays(range);
            return startDate;
        }
        /// <summary>
        /// Convert string num of day to int
        /// </summary>
        /// <param name="numOfDay">string num of day</param>
        /// <returns>int num of day</returns>
        public int ConvertNumOfDayToNumDay(string numOfDay)
        {
            if (numOfDay.Equals(HRDayOfWeek.Monday.ToString()))
                return 1;
            if (numOfDay.Equals(HRDayOfWeek.Tuesday.ToString()))
                return 2;
            if (numOfDay.Equals(HRDayOfWeek.Wednesday.ToString()))
                return 3;
            if (numOfDay.Equals(HRDayOfWeek.Thursday.ToString()))
                return 4;
            if (numOfDay.Equals(HRDayOfWeek.Friday.ToString()))
                return 5;
            if (numOfDay.Equals(HRDayOfWeek.Saturday.ToString()))
                return 6;
            return 7;
        }
        #endregion
    }
}
