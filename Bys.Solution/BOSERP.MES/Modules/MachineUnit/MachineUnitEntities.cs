using System;

namespace BOSERP.Modules.MachineUnit
{
    class MachineUnitEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strMMMachineUnitsObjectName = "MMMachineUnits";
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties

        public BOSList<MMMachineUnitOperationsInfo> MachineUnitOperationList { get; set; }
        public BOSList<MMMachineUnitItemsInfo> MachineUnitItemList { get; set; }
        /// <summary>
        /// Gets or sets stock parent id
        /// </summary>
        public int MachineUnitParentID { get; set; }
        #endregion

        #region Constructor
        public MachineUnitEntities()
            : base()
        {
            MachineUnitOperationList = new BOSList<MMMachineUnitOperationsInfo>();
            MachineUnitItemList = new BOSList<MMMachineUnitItemsInfo>();
        }


        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMMachineUnitsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("MMMachineUnitOperations", new MMMachineUnitOperationsInfo());
            ModuleObjects.Add("MMMachineUnitItems", new MMMachineUnitItemsInfo());

        }

        public override void InitModuleObjectList()
        {
            MachineUnitOperationList.InitBOSList(this,
                                            "MMMachineUnits",
                                            "MMMachineUnitOperations",
                                            BOSList<MMMachineUnitOperationsInfo>.cstRelationForeign);
            MachineUnitOperationList.ItemTableForeignKey = "FK_MMMachineUnitID";

            MachineUnitItemList.InitBOSList(this,
                                             "MMMachineUnits",
                                             "MMMachineUnitItems",
                                             BOSList<MMMachineUnitItemsInfo>.cstRelationForeign);
            MachineUnitItemList.ItemTableForeignKey = "FK_MMMachineUnitID";
        }

        public override void InitGridControlInBOSList()
        {
            MachineUnitOperationList.InitBOSListGridControl(MachineUnitModule.MUOperationGridControl);
            MachineUnitItemList.InitBOSListGridControl("fld_dgcMMMachineUnitItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMMachineUnitsInfo objMainObject = (MMMachineUnitsInfo)MainObject;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MachineUnitOperationList.SetDefaultListAndRefreshGridControl();
                MachineUnitItemList.SetDefaultListAndRefreshGridControl();
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

            MachineUnitParentID = iObjectID;
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MachineUnitOperationList.Invalidate(iObjectID);
            MachineUnitItemList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            MMMachineUnitsInfo objMainObject = (MMMachineUnitsInfo)MainObject;
            if (objMainObject.MMMachineUnitID == 0)
            {
                objMainObject.MMMachineUnitParentID = MachineUnitParentID;
            }

            int operationID = base.SaveMainObject();
            return operationID;
        }
        public override void SaveModuleObjects()
        {
            MachineUnitOperationList.SaveItemObjects();
            MachineUnitItemList.SaveItemObjects();
        }

        #endregion

        public override void Delete(int iObjectID)
        {
            MMMachineUnitsInfo objOperationsInfo = (MMMachineUnitsInfo)MainObject;
            iObjectID = objOperationsInfo.MMMachineUnitID;
            base.Delete(iObjectID);
        }

    }
}
