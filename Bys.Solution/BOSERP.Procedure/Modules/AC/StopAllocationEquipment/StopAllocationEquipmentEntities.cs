namespace BOSERP.Modules.StopAllocationEquipment
{
    public class StopAllocationEquipmentEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public StopAllocationEquipmentEntities()
            : base()
        {

        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACStopAllocationEquipmentsInfo();
            SearchObject = new ACStopAllocationEquipmentsInfo();
        }
        #endregion

        #region SetDefault
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACStopAllocationEquipmentsInfo objStopAllocationEquipmentsInfo = (ACStopAllocationEquipmentsInfo)MainObject;
            objStopAllocationEquipmentsInfo.ACStopAllocationEquipmentDate = BOSApp.GetCurrentServerDate();
            objStopAllocationEquipmentsInfo.ACStopAllocationEquipmentDateStop = BOSApp.GetCurrentServerDate();
            objStopAllocationEquipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        #endregion
    }
}