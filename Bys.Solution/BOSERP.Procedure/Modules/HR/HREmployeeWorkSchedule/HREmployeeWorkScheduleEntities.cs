using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.HREmployeeWorkSchedule
{
    class HREmployeeWorkScheduleEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        public BOSList<HREmployeeWorkScheduleItemsInfo> HREmployeeWorkScheduleList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public HREmployeeWorkScheduleEntities()
            : base()
        {
            HREmployeeWorkScheduleList = new BOSList<HREmployeeWorkScheduleItemsInfo>();
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HREmployeeWorkSchedulesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeWorkScheduleItemsTableName, new HREmployeeWorkScheduleItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeWorkScheduleList.InitBOSList(
                                            this,
                                            TableName.HREmployeeWorkSchedulesTableName,
                                            TableName.HREmployeeWorkScheduleItemsTableName,
                                            BOSList<HREmployeeWorkScheduleItemsInfo>.cstRelationForeign);
            HREmployeeWorkScheduleList.ItemTableForeignKey = "FK_HREmployeeWorkScheduleID";

            HREmployeeList.InitBOSList(
                                       this,
                                       String.Empty,
                                       TableName.HREmployeesTableName,
                                       BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeWorkScheduleList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeWorkScheduleList.InitBOSListGridControl();
        }

        #endregion

        #region Invalidate Module Objects functions      


        public override void InvalidateModuleObjects(int iObjectID)
        {
            HREmployeeWorkScheduleItemsController objEmployeeWorkSchedulesController = new HREmployeeWorkScheduleItemsController();
            DataSet ds = objEmployeeWorkSchedulesController.GetAllDataByOverTimeID(iObjectID);
            HREmployeeWorkScheduleList.Invalidate(ds);
            //HREmployeeWorkScheduleList.Invalidate(iObjectID);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)MainObject;
            obj.HREmployeeWorkScheduleStatus = KPIRegistrationStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }


        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            foreach (var obj in HREmployeeWorkScheduleList)
            {
                obj.FK_HREmployeeWorkScheduleID = ((HREmployeeWorkSchedulesInfo)MainObject).HREmployeeWorkScheduleID;
            }
            HREmployeeWorkScheduleList.SaveItemObjects();
        }

        #endregion
    }
}
