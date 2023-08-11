using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.Vehicle
{
    public class VehicleEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<VMVehicleFuelLogsInfo> VehicleFuelLogList { get; set; }
        public BOSList<VMVehicleEmployeesInfo> VehicleEmployeeList { get; set; }
        #endregion

        #region Constructor
        public VehicleEntities()
            : base()
        {
            VehicleFuelLogList = new BOSList<VMVehicleFuelLogsInfo>();
            VehicleEmployeeList = new BOSList<VMVehicleEmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new VMVehiclesInfo();
            SearchObject = new VMVehiclesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.VMVehicleFuelLogsTableName, new VMVehicleFuelLogsInfo());
            ModuleObjects.Add(TableName.VMVehicleEmployeesTableName, new VMVehicleEmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            VehicleFuelLogList.InitBOSList(this,
                                               TableName.VMVehiclesTableName,
                                               TableName.VMVehicleFuelLogsTableName,
                                               BOSList<VMVehicleFuelLogsInfo>.cstRelationForeign);
            VehicleFuelLogList.ItemTableForeignKey = "FK_VMVehicleID";
            VehicleEmployeeList.InitBOSList(this,
                                               TableName.VMVehiclesTableName,
                                               TableName.VMVehicleEmployeesTableName,
                                               BOSList<VMVehicleEmployeesInfo>.cstRelationForeign);
            VehicleEmployeeList.ItemTableForeignKey = "FK_VMVehicleID";
        }

        public override void InitGridControlInBOSList()
        {
            VehicleFuelLogList.InitBOSListGridControl("fld_dgcVMVehicleFuelLogs");
            VehicleEmployeeList.InitBOSListGridControl(VehicleModule.VMVehicleEmployeesGridControlName);
        }


        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            VMVehiclesInfo mainobject = (VMVehiclesInfo)this.MainObject;
            mainobject.VMVehicleStatus = VehicleStatus.Using.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                VehicleFuelLogList.SetDefaultListAndRefreshGridControl();
                VehicleEmployeeList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            VehicleFuelLogList.Invalidate(iObjectID);
            VehicleEmployeeList.Invalidate(iObjectID);
        }
        #endregion

        public override void SaveModuleObjects()
        {
            VMVehiclesInfo objVehiclesInfo = (VMVehiclesInfo)MainObject;
            VehicleFuelLogList.ForEach(o => o.FK_VMVehicleID = objVehiclesInfo.VMVehicleID);
            VehicleFuelLogList.SaveItemObjects();
            VehicleEmployeeList.ForEach(o => o.FK_VMVehicleID = objVehiclesInfo.VMVehicleID);
            VehicleEmployeeList.SaveItemObjects();
        }
    }
}
