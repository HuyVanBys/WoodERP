using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTrainningEmployee
{
    public class HRTrainningEmployeeModule : BaseModuleERP
    {
        #region Constant
        public const string TrainningEmployeeLookupEditName = "fld_lkeFK_HREmployeeID";
        public const string TrainningClassLookupEditName = "fld_lkeFK_HRTrainningClassID";
        public const string TrainningCourseLookupEditName = "fld_lkeFK_HRTrainningCourseID";
        public const string TrainningCourseLookupEditName1 = "fld_lkeFK_HRTrainningCourseID1";
        public const string EmployeeAbsencesGridControlName = "fld_dgcHREmployeeAbsences";
        public const string TrainningEmployeesGridControlName = "fld_dgcHRTrainningEmployees1";
        public const string EmployeeAbsenceClassLookupEditName = "fld_lkeFK_HRTrainningClassID1";
        public const string EmployeeAbsenceCourseLookupEditName = "fld_lkeFK_HRTrainningCourseID1";
        public const string TrainningClassMaxQtyLabelName = "fld_lblHRTrainningClassMaxQty";
        public const string TrainningClassRegisteredQtyLabelName = "fld_lblHRTrainningClassRegisteredQty";
        #endregion

        /// <summary>
        /// Object class schedule for update employee absences
        /// </summary>
        private HRClassSchedulesInfo ObjClassSchedulesInfo = new HRClassSchedulesInfo();

        #region Constructor
        public HRTrainningEmployeeModule()
        {
            Name = "HRTrainningEmployee";
            CurrentModuleEntity = new HRTrainningEmployeeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        #region Method
        public override int ActionSave()
        {
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
            BOSLookupEdit trainningCourse1Name = (BOSLookupEdit)Controls[HRTrainningEmployeeModule.TrainningCourseLookupEditName1];
            foreach (HRTrainningEmployeesInfo objTrainningEmployeesInfo in entity.HRTrainningEmployeesList)
            {
                objTrainningEmployeesInfo.HRTrainningEmployeeType = TrainningEmployee.Student.ToString();
                objTrainningEmployeesInfo.FK_HRTrainningClassID = objTrainningEmployeesInfo.FK_HRTrainningClassID;
                objTrainningEmployeesInfo.FK_HRTrainningCourseID = objTrainningEmployeesInfo.FK_HRTrainningCourseID;
            }
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    entity.HRTrainningEmployees1List.EndCurrentEdit();
                    CurrentModuleEntity.SaveModuleObjects();
                    entity.SaveEmployeeAbsences(ObjClassSchedulesInfo, Convert.ToInt32(trainningCourse1Name.EditValue));
                    scope.Complete();
                    MessageBox.Show(TrainningEmployeeLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
                return 0;
            }
        }

        /// <summary>
        /// Adds the item to trainning emloyee list.
        /// </summary>
        public void AddItemToTrainningEmloyeeList(int employeeID)
        {
            BOSLookupEdit trainningClassName = (BOSLookupEdit)Controls[HRTrainningEmployeeModule.TrainningClassLookupEditName];
            BOSLookupEdit trainningCourseName = (BOSLookupEdit)Controls[HRTrainningEmployeeModule.TrainningCourseLookupEditName];
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
            HRTrainningEmployeesInfo objTrainningEmployeesInfo = (HRTrainningEmployeesInfo)entity.ModuleObjects[TableName.HRTrainningEmployeesTableName];
            HREmployeesInfo objEmployeeInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            objEmployeeInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);

            BOSLabel trainningClassMaxQty = (BOSLabel)Controls[TrainningClassMaxQtyLabelName];
            BOSLabel trainningClassRegisteredQty = (BOSLabel)Controls[TrainningClassRegisteredQtyLabelName];
            if (employeeID > 0)
            {
                objTrainningEmployeesInfo.FK_HRTrainningCourseID = Convert.ToInt32(trainningCourseName.EditValue);
                objTrainningEmployeesInfo.FK_HRTrainningClassID = Convert.ToInt32(trainningClassName.EditValue);
                objTrainningEmployeesInfo.FK_HREmployeeID = objEmployeeInfo.HREmployeeID;
                objTrainningEmployeesInfo.HRTrainningEmployeeType = TrainningEmployee.Student.ToString();
                objTrainningEmployeesInfo.HREmployeeNo = objEmployeeInfo.HREmployeeNo;
                if (Convert.ToInt32(trainningClassRegisteredQty.Text) >= Convert.ToInt32(trainningClassMaxQty.Text))
                {
                    if (MessageBox.Show(TrainningEmployeeLocalizedResources.CompareMaxQtyAndRegisteredQty, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entity.HRTrainningEmployeesList.ChangeObjectFromList();
                        trainningClassMaxQty.Focus();
                        trainningClassRegisteredQty.Text = entity.HRTrainningEmployeesList.Count.ToString();
                    }
                }
                else
                {
                    entity.HRTrainningEmployeesList.ChangeObjectFromList();
                    trainningClassMaxQty.Focus();
                    trainningClassRegisteredQty.Text = entity.HRTrainningEmployeesList.Count.ToString();
                }
            }
        }


        /// <summary>
        /// Check whether is existed or not of employee in tranning employee grid control
        /// </summary>
        /// <param name="employeeID">ID of employee</param>
        /// <returns>0 if employee is existed, 1 if employee is teacher, -1 in otherwise</returns>
        public int CheckListExistTrainningEmployeeName(int employeeID)
        {
            BOSLookupEdit trainningClassName = (BOSLookupEdit)Controls[HRTrainningEmployeeModule.TrainningClassLookupEditName];
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
            if (entity.HRTrainningEmployeesList.Where(e => e.FK_HREmployeeID == employeeID).FirstOrDefault() != null)
            {
                return 0;
            }
            else if (CheckEmployeeIsTeacher(employeeID) == true)
            {
                return 1;
            }
            else if (trainningClassName.EditValue == null)
            {
                return 2;
            }
            return -1;
        }

        /// <summary>
        /// Checks an employee whether to be a teacher
        /// </summary>
        /// <param name="employeeID">The employee ID.</param>
        public bool CheckEmployeeIsTeacher(int employeeID)
        {
            bool isExist = false;

            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
            HRTrainningEmployeesController objTrainningEmployeesController = new HRTrainningEmployeesController();
            DataSet ds = objTrainningEmployeesController.GetTrainningEmployeeByEmployeeID(employeeID, TrainningEmployee.Teacher.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                isExist = true;
            }
            return isExist;
        }

        /// <summary>
        /// Chooses the trainning class for update to employee list.
        /// </summary>
        /// <param name="trainningClassID">The trainning class ID.</param>
        public void ChooseTrainningClass(int trainningClassID)
        {
            BOSLabel trainningClassMaxQty = (BOSLabel)Controls[TrainningClassMaxQtyLabelName];
            BOSLabel trainningClassRegisteredQty = (BOSLabel)Controls[TrainningClassRegisteredQtyLabelName];
            BOSLookupEdit trainningCourseLookupEdit = (BOSLookupEdit)Controls[TrainningCourseLookupEditName];
            BOSLookupEdit trainningClassLookupEdit = (BOSLookupEdit)Controls[HRTrainningEmployeeModule.TrainningClassLookupEditName];
            if (trainningClassID > 0)
            {
                HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
                HRTrainningEmployeesInfo objTrainningEmployeesInfo = (HRTrainningEmployeesInfo)entity.ModuleObjects[TableName.HRTrainningEmployeesTableName];
                HRTrainningEmployeesController objTrainningEmployeesController = new HRTrainningEmployeesController();
                DataSet ds = objTrainningEmployeesController.GetTrainningEmployeeByTrainningClassID(trainningClassID, TrainningEmployee.Student.ToString());
                HRTrainningClassInfo objTrainningClassInfo = new HRTrainningClassInfo();
                HRTrainningClassController objTrainningClassController = new HRTrainningClassController();
                objTrainningClassInfo = (HRTrainningClassInfo)objTrainningClassController.GetObjectByID(trainningClassID);
                entity.HRTrainningEmployeesList.Invalidate(ds);

                trainningClassMaxQty.Text = objTrainningClassInfo.HRTrainningClassMaxQty.ToString();
                trainningClassRegisteredQty.Text = entity.HRTrainningEmployeesList.Count.ToString();
            }
            else
            {
                trainningClassMaxQty.Text = "0";
                trainningClassRegisteredQty.Text = "0";
            }
        }
        /// <summary>
        /// Chooses the trainning class to update class schedule.
        /// </summary>
        /// <param name="trainningClassID">The trainning class ID.</param>
        public void ChooseClassSchedule(int trainningClassID)
        {
            if (trainningClassID > 0)
            {
                HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
                BOSLookupEdit trainningCourseLookupEdit = (BOSLookupEdit)Controls[HRTrainningEmployeeModule.EmployeeAbsenceCourseLookupEditName];
                int trainningCourseID = Convert.ToInt32(trainningCourseLookupEdit.EditValue);
                HRTrainningCoursesController objTrainningCoursesController = new HRTrainningCoursesController();
                HRTrainningCoursesInfo objTrainningCoursesInfo = new HRTrainningCoursesInfo();
                objTrainningCoursesInfo = (HRTrainningCoursesInfo)objTrainningCoursesController.GetObjectByID(trainningCourseID);
                int numWeek = CalculateNumWeek(objTrainningCoursesInfo.HRTranningCourseStartDate, objTrainningCoursesInfo.HRTrainningCourseEndDate);
                int numDay = CalculateNumDay(objTrainningCoursesInfo.HRTranningCourseStartDate, objTrainningCoursesInfo.HRTrainningCourseEndDate);

                HRClassSchedulesController objClassSchedulesController = new HRClassSchedulesController();
                DataSet dsClassSchedules = objClassSchedulesController.GetEmployeeAbsencesByTrainningClassID(trainningClassID);

                entity.HRClassSchedulesListTemp.Clear();

                if (dsClassSchedules.Tables[0].Rows.Count > 0)
                {
                    if (numWeek > 0)
                    {
                        for (int i = 0; i < numWeek; i++)
                        {
                            foreach (DataRow drClassSchedules in dsClassSchedules.Tables[0].Rows)
                            {
                                HRClassSchedulesInfo objClassSchedulesInfo = new HRClassSchedulesInfo();
                                objClassSchedulesInfo = (HRClassSchedulesInfo)objClassSchedulesController.GetObjectFromDataRow(drClassSchedules);
                                objClassSchedulesInfo.HRClassSchedulesDate = entity.CalculateDate(objTrainningCoursesInfo.HRTranningCourseStartDate,
                                                                                                    objClassSchedulesInfo.HRDayOfWeek);
                                objClassSchedulesInfo.HRClassSchedulesDate = objClassSchedulesInfo.HRClassSchedulesDate.AddDays(i * 7);
                                entity.HRClassSchedulesListTemp.Add(objClassSchedulesInfo);
                            }
                        }
                    }
                    if (numDay > 0)
                    {
                        DateTime endDate = objTrainningCoursesInfo.HRTrainningCourseEndDate.AddDays(-numDay);
                        for (int i = 1; i <= numDay; i++)
                        {
                            DateTime endDateTmp = endDate.AddDays(i);
                            int numOfDay = entity.CalculateDay(endDateTmp.Day, endDateTmp.Month, endDateTmp.Year);
                            foreach (DataRow drClassSchedules in dsClassSchedules.Tables[0].Rows)
                            {
                                HRClassSchedulesInfo objClassSchedulesInfo = new HRClassSchedulesInfo();
                                objClassSchedulesInfo = (HRClassSchedulesInfo)objClassSchedulesController.GetObjectFromDataRow(drClassSchedules);
                                if (numOfDay == entity.ConvertNumOfDayToNumDay(objClassSchedulesInfo.HRDayOfWeek.ToString()))
                                {
                                    objClassSchedulesInfo.HRClassSchedulesDate = endDateTmp;
                                    entity.HRClassSchedulesListTemp.Add(objClassSchedulesInfo);
                                }
                            }
                        }
                    }
                }
                entity.HRClassSchedulesList.Invalidate(entity.HRClassSchedulesListTemp);
                entity.HRClassSchedulesListTemp.Clear();
            }
        }
        /// <summary>
        /// Chosses the trainning employee.
        /// </summary>
        /// <param name="objClassSchedulesInfo">The obj class schedules info.</param>
        public void ChosseTrainningEmployee(HRClassSchedulesInfo objClassSchedulesInfo)
        {
            ObjClassSchedulesInfo = objClassSchedulesInfo;
            HRTrainningEmployeesController objTrainningEmployeesController = new HRTrainningEmployeesController();
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)CurrentModuleEntity;
            DataSet dsTrainningEmployee = objTrainningEmployeesController.GetTrainningEmployeeByClassScheduleID(objClassSchedulesInfo.HRClassScheduleID, TrainningEmployee.Student.ToString(), objClassSchedulesInfo.HRClassSchedulesDate);
            entity.HRTrainningEmployees1List.Invalidate(dsTrainningEmployee);
            entity.UpdateModuleObjectsBindingSource();
        }
        /// <summary>
        /// Calculates the num week.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>num of week</returns>
        public int CalculateNumWeek(DateTime startDate, DateTime endDate)
        {
            int numDay = (int)Math.Ceiling((endDate.Subtract(startDate).TotalDays));
            int numWeek = (int)(numDay / 7);
            return numWeek;
        }
        /// <summary>
        /// Calculate num day
        /// </summary>
        /// <param name="startDay">The start date</param>
        /// <param name="endDate">The start date</param>
        /// <returns>num of day</returns>
        public int CalculateNumDay(DateTime startDay, DateTime endDate)
        {
            int numDay = (int)Math.Ceiling((endDate.Subtract(startDay).TotalDays));
            int numWeek = (int)(numDay / 7);
            int day = (int)(numDay - (numWeek * 7));
            return day;
        }
        #endregion
    }
}
