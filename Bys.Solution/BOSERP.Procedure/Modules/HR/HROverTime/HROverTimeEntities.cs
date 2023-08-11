using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.HROverTime
{
    public class HROverTimeEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeeOTsInfo> HREmployeeOTList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        #endregion

        #region Constructor
        public HROverTimeEntities()
            : base()
        {
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HROverTimesInfo();
            HREmployeeOTList = new BOSList<HREmployeeOTsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeOTsTableName, new HREmployeeOTsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeOTList.InitBOSList(
                                            this,
                                            TableName.HROverTimesTableName,
                                            TableName.HREmployeeOTsTableName,
                                            BOSList<HREmployeeOTsInfo>.cstRelationForeign);
            HREmployeeOTList.ItemTableForeignKey = "FK_HROverTimeID";

            HREmployeeList.InitBOSList(
                                       this,
                                       String.Empty,
                                       TableName.HREmployeesTableName,
                                       BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeOTList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)MainObject;
            objOverTimesInfo.HROverTimeDate = DateTime.Now.Date;
            objOverTimesInfo.HROverTimeFromDate = DateTime.Now.Date;
            objOverTimesInfo.HROverTimeToDate = DateTime.Now.Date;
            objOverTimesInfo.HROverTimeDateEnd = DateTime.Now.Date;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeOTList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeOTsController objEmployeeOTsController = new HREmployeeOTsController();
            DataSet ds = objEmployeeOTsController.GetAllDataByOverTimeID(iObjectID);
            HREmployeeOTList.Invalidate(ds);
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var item in HREmployeeOTList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    item.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }
            //if (HREmployeeOTList.Count > 0)
            //{
            //    HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)MainObject;
            //    objOverTimesInfo.HROverTimeFactor = HREmployeeOTList[0].HREmployeeOTFactor;
            //    UpdateMainObjectBindingSource();
            //}
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)MainObject;
            objOverTimesInfo.HROverTimeDate = objOverTimesInfo.HROverTimeDate.Date;
            try
            {

                //int time1 = objOverTimesInfo.HROverTimeFromDate.Hour * 60 + objOverTimesInfo.HROverTimeFromDate.Minute;
                //int time2 = objOverTimesInfo.HROverTimeToDate.Hour * 60 + objOverTimesInfo.HROverTimeToDate.Minute;
                //objOverTimesInfo.HROverTimeFromDate = objOverTimesInfo.HROverTimeDate.AddMinutes(time1);
                //objOverTimesInfo.HROverTimeToDate = objOverTimesInfo.HROverTimeDate.AddMinutes(time2);
            }
            catch (Exception) { }
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeeOTList.EndCurrentEdit();
            HREmployeeOTList.SaveItemObjects();
        }
        #endregion
    }
}
