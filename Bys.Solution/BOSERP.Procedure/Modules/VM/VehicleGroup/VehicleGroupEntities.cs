using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.VehicleGroup
{
    public class VehicleGroupEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<VMVehiclesInfo> VMVehiclesList { get; set; }
        #endregion

        #region Constructor
        public VehicleGroupEntities()
            : base()
        {
            VMVehiclesList = new BOSList<VMVehiclesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new VMVehicleGroupsInfo();
            SearchObject = new VMVehicleGroupsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.VMVehiclesTableName, new VMVehiclesInfo());
        }

        public override void InitModuleObjectList()
        {
            VMVehiclesList.InitBOSList(this,
                                               TableName.VMVehicleGroupsTableName,
                                               TableName.VMVehiclesTableName,
                                               BOSList<VMVehiclesInfo>.cstRelationForeign);
            VMVehiclesList.ItemTableForeignKey = "FK_VMVehicleGroupID";
        }

        public override void InitGridControlInBOSList()
        {
            VMVehiclesList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                VMVehiclesList.SetDefaultListAndRefreshGridControl();
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
            VMVehiclesList.Invalidate(iObjectID);
        }
        #endregion

        public override void Save()
        {
            base.Save();
        }
    }
}
