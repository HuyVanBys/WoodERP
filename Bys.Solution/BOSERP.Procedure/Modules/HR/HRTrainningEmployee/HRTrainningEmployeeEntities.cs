using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Data;


namespace BOSERP.Modules.HRTrainningEmployee
{
    public class HRTrainningEmployeeEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRTrainningClassInfo> HRTrainningClassList { get; set; }
        public BOSList<HRTrainningEmployeesInfo> HRTrainningEmployeesList { get; set; }
        public BOSList<HRTrainningEmployeesInfo> HRTrainningEmployees1List { get; set; }
        public BOSList<HRClassSchedulesInfo> HRClassSchedulesList { get; set; }
        public BOSList<HRClassSchedulesInfo> HRClassSchedulesListTemp { get; set; }
        #endregion

        #region Constructor
        public HRTrainningEmployeeEntities()
            : base()
        {
            HRTrainningClassList = new BOSList<HRTrainningClassInfo>();
            HRTrainningEmployeesList = new BOSList<HRTrainningEmployeesInfo>();
            HRTrainningEmployees1List = new BOSList<HRTrainningEmployeesInfo>();
            HRClassSchedulesList = new BOSList<HRClassSchedulesInfo>();
            HRClassSchedulesListTemp = new BOSList<HRClassSchedulesInfo>();
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
            ModuleObjects.Add(TableName.HRClassSchedulesTableName, new HRClassSchedulesInfo());
            ModuleObjects.Add(TableName.HRTrainningEmployeesTableName, new HRTrainningEmployeesInfo());
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
            HRTrainningEmployees1List.InitBOSList(
                                          this,
                                          TableName.HRTrainningCoursesTableName,
                                          TableName.HRTrainningEmployeesTableName,
                                          BOSList<HRTrainningEmployeesInfo>.cstRelationForeign);
            HRTrainningEmployeesList.ItemTableForeignKey = "FK_HRTrainningCourseID";

            HRClassSchedulesList.InitBOSList(
                                            this,
                                            TableName.HRTrainningCoursesTableName,
                                            TableName.HRClassSchedulesTableName,
                                            BOSList<HRTrainningEmployeesInfo>.cstRelationForeign);
            HRClassSchedulesList.ItemTableForeignKey = "FK_HRTrainningCourseID";
            HRClassSchedulesListTemp.InitBOSList(
                                           this,
                                           TableName.HRTrainningCoursesTableName,
                                           TableName.HRClassSchedulesTableName,
                                           BOSList<HRTrainningEmployeesInfo>.cstRelationForeign);
            HRClassSchedulesList.ItemTableForeignKey = "FK_HRTrainningCourseID";
        }

        public override void InitGridControlInBOSList()
        {
            HRTrainningClassList.InitBOSListGridControl();
            HRTrainningEmployeesList.InitBOSListGridControl();
            HRTrainningEmployees1List.InitBOSListGridControl();
            HRClassSchedulesList.InitBOSListGridControl();
            HRClassSchedulesListTemp.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRTrainningClassList.SetDefaultListAndRefreshGridControl();
                HRTrainningEmployeesList.SetDefaultListAndRefreshGridControl();
                HRTrainningEmployees1List.SetDefaultListAndRefreshGridControl();
                HRClassSchedulesList.SetDefaultListAndRefreshGridControl();
                HRClassSchedulesListTemp.SetDefaultListAndRefreshGridControl();
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
            InvalidateTrainningEmployees(iObjectID);
        }
        /// <summary>
        /// Invalidate trainning employee for update
        /// </summary>
        /// <param name="trainningCourseID">the trainning course ID</param>
        public void InvalidateTrainningEmployees(int trainningCourseID)
        {
            HRTrainningEmployeesController objTrainningEmployeesController = new HRTrainningEmployeesController();
            DataSet dsTrainningEmployees = objTrainningEmployeesController.GetTrainningEmployeesByTrainningCourseIDAndTrainningEmployeeType(trainningCourseID, TrainningEmployee.Student.ToString());
            HRTrainningEmployeesList.Invalidate(dsTrainningEmployees);
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
        }
        /// <summary>
        /// Saves the employee absences.
        /// </summary>
        /// <param name="objClassScheduleInfo">The obj class schedule info.</param>
        /// <param name="trainningCourseID">The trainning course ID.</param>
        public void SaveEmployeeAbsences(HRClassSchedulesInfo objClassScheduleInfo, int trainningCourseID)
        {
            HREmployeeAbsencesController objEmployeeAbsencesController = new HREmployeeAbsencesController();

            foreach (HRTrainningEmployeesInfo objTrainningEmployeesInfo in HRTrainningEmployees1List)
            {
                HREmployeeAbsencesInfo objEmployeeAbsencesInfo = new HREmployeeAbsencesInfo();
                objEmployeeAbsencesInfo.FK_HRTrainningCourseID = trainningCourseID;
                objEmployeeAbsencesInfo.FK_HRTrainningClassID = objClassScheduleInfo.FK_HRTrainningClassID;
                objEmployeeAbsencesInfo.FK_HRClassScheduleID = objClassScheduleInfo.HRClassScheduleID;
                objEmployeeAbsencesInfo.FK_HREmployeeStudentID = objTrainningEmployeesInfo.FK_HREmployeeID;
                objEmployeeAbsencesInfo.HREmployeeAbsenceDate = objClassScheduleInfo.HRClassSchedulesDate;
                objEmployeeAbsencesInfo.IsPresent = objTrainningEmployeesInfo.IsPresent;
                objEmployeeAbsencesInfo.HREmployeeAbsenceID = objTrainningEmployeesInfo.HREmployeeAbsenceID;
                if (objEmployeeAbsencesInfo.HREmployeeAbsenceID > 0)
                {
                    objEmployeeAbsencesController.UpdateObject(objEmployeeAbsencesInfo);
                }
                else
                {
                    objEmployeeAbsencesController.CreateObject(objEmployeeAbsencesInfo);
                }
            }
        }
        #endregion

        #region Calculate date
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
