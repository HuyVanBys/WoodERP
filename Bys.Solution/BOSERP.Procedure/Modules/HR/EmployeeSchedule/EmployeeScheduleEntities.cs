using BOSCommon.Constants;
using BOSComponent;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.EmployeeSchedule
{
    class EmployeeScheduleEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        public BOSList<HREmployeeSchedulesInfo> EmployeeScheduleList { get; set; }
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public EmployeeScheduleEntities()
            : base()
        {



        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRSchedulesInfo();
            SearchObject = new HRSchedulesInfo();
            EmployeeList = new BOSList<HREmployeesInfo>();
            EmployeeScheduleList = new BOSList<HREmployeeSchedulesInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeSchedulesTableName, new HREmployeeSchedulesInfo());
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRSchedulesInfo objMainObject = (HRSchedulesInfo)MainObject;

            objMainObject.HRScheduleDate = DateTime.Now;
            objMainObject.HRScheduleFromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            objMainObject.HRScheduleToDate = objMainObject.HRScheduleFromDate.AddMonths(1).AddDays(-1);
            objMainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        public override void InitModuleObjectList()
        {

            EmployeeScheduleList.InitBOSList(
                                       this,
                                       TableName.HRSchedulesTableName,
                                       TableName.HREmployeeSchedulesTableName,
                                       BOSList<HREmployeeSchedulesInfo>.cstRelationForeign);
            EmployeeScheduleList.ItemTableForeignKey = "FK_HRScheduleID";
            EmployeeList.InitBOSList(
                                    this,
                                    String.Empty,
                                    TableName.HREmployeesTableName,
                                    BOSList<HREmployeesInfo>.cstRelationNone);
        }
        public override void InitGridControlInBOSList()
        {
            EmployeeScheduleList.InitBOSListGridControl();

        }
        public override void SaveModuleObjects()
        {
            //EmployeeScheduleList.SaveItemObjects();
            HRSchedulesInfo objMainObject = (HRSchedulesInfo)MainObject;
            HREmployeeSchedulesController employeeScheduleController = new HREmployeeSchedulesController();
            employeeScheduleController.DeleteByForeignColumn("FK_HRScheduleID", objMainObject.HRScheduleID);
            foreach (HREmployeeSchedulesInfo employeeSchedule in EmployeeScheduleList)
            {
                employeeSchedule.FK_HRScheduleID = objMainObject.HRScheduleID;
                employeeScheduleController.CreateObject(employeeSchedule);
            }
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeScheduleList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }


        #endregion

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HREmployeeSchedulesController controller = new HREmployeeSchedulesController();
            List<HREmployeeSchedulesInfo> listInfo = controller.GetEmployeeScheduleByScheduleID(iObjectID);
            if (listInfo.Count > 0)
            {
                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo eInfo = new HREmployeesInfo();
                HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
                HRWorkingShiftsInfo wInfo = new HRWorkingShiftsInfo();
                //foreach (HREmployeeSchedulesInfo info in listInfo)
                //{
                //    eInfo = (HREmployeesInfo)employeeController.GetObjectByID(info.FK_HREmployeeID);
                //    wInfo = (HRWorkingShiftsInfo)workingShiftController.GetObjectByID(info.FK_HRWorkingShiftID);
                //    if (eInfo != null)
                //    {
                //        info.EmployeeName = eInfo.HREmployeeName;
                //        info.EmployeeNo = eInfo.HREmployeeNo;
                //    }
                //    if (wInfo != null)
                //        info.Sheet = wInfo.HRWorkingShiftName;

                //}
            }

            EmployeeScheduleList.Invalidate(listInfo);
            if (EmployeeScheduleList.Count > 0)
            {
                initRLKEDataSource();
            }
        }
        public override void Invalidate(int iObjectID)
        {

            base.Invalidate(iObjectID);
            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo objWorkingShiftsInfo = new HRWorkingShiftsInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            //for (int i = 0; i < EmployeeScheduleList.Count; i++)
            //{
            //    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(EmployeeScheduleList.ToArray()[i].FK_HREmployeeID);
            //    objWorkingShiftsInfo = (HRWorkingShiftsInfo)objWorkingShiftsController.GetObjectByID(EmployeeScheduleList.ToArray()[i].FK_HRWorkingShiftID);
            //    if (objWorkingShiftsInfo != null)
            //        EmployeeScheduleList.ToArray()[i].Sheet = objWorkingShiftsInfo.HRWorkingShiftName;
            //    if (objEmployeesInfo != null)
            //    {
            //        EmployeeScheduleList.ToArray()[i].EmployeeName = objEmployeesInfo.HREmployeeName;
            //        EmployeeScheduleList.ToArray()[i].EmployeeNo = objEmployeesInfo.HREmployeeNo;
            //    }
            //} 
        }
        #region Save Module Objects functions



        #endregion
        #region LookupEdit gridControl]
        public RepositoryItemBOSLookupEdit reLKEWorkingShift;
        public void initRLKEWorkingShift()
        {
            reLKEWorkingShift = new RepositoryItemBOSLookupEdit();
            reLKEWorkingShift.AutoHeight = false;
            //reLKEWorkingShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reLKEWorkingShift.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRWorkingShiftName", "Ca làm việc")});

            reLKEWorkingShift.DisplayMember = "HRWorkingShiftName";
            reLKEWorkingShift.ValueMember = "HRWorkingShiftID";

        }
        public List<HRWorkingShiftsInfo> getRLKEDataSource()
        {

            List<HRWorkingShiftsInfo> returnList = new List<HRWorkingShiftsInfo>();
            if (EmployeeScheduleList.Count > 0)
            {
                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo employeeInfo = (HREmployeesInfo)employeeController.GetObjectByID(EmployeeScheduleList[0].FK_HREmployeeID);
                HRWorkingShiftsController workingController = new HRWorkingShiftsController();
                if (employeeInfo != null)
                    returnList = workingController.GetWorkingShiftByPayrollFormulaID(employeeInfo.FK_HREmployeePayrollFormulaID);
            }
            return returnList;
        }
        public void initRLKEDataSource()
        {
            initRLKEWorkingShift();
            reLKEWorkingShift.DataSource = getRLKEDataSource();


            EmployeeScheduleList.GridControl.Columns["FK_HRWorkingShiftID"].ColumnEdit = reLKEWorkingShift;
            HREmployeesController employeeController = new HREmployeesController();
            HREmployeesInfo eInfo = new HREmployeesInfo();
            HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo wInfo = new HRWorkingShiftsInfo();
            //foreach (HREmployeeSchedulesInfo info in EmployeeScheduleList)
            //{
            //    eInfo = (HREmployeesInfo)employeeController.GetObjectByID(info.FK_HREmployeeID);
            //    wInfo = (HRWorkingShiftsInfo)workingShiftController.GetObjectByID(info.FK_HRWorkingShiftID);
            //    if (eInfo != null)
            //    {
            //        info.EmployeeName = eInfo.HREmployeeName;
            //        info.EmployeeNo = eInfo.HREmployeeNo;
            //    }
            //    if (wInfo != null)
            //        info.Sheet = wInfo.HRWorkingShiftName;

            //}
        }
        #endregion
    }
}
