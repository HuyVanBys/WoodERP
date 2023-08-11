using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.Operation
{
    class OperationEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strMMOperationsObjectName = "MMOperations";

        //public readonly static String strICStockSlotsObjectName = "ICStockSlots";
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties

        public BOSList<MMLineOperationsInfo> LineOperationsList { get; set; }
        public BOSList<MMOperationMachineGroupsInfo> OperationMachineGroupsList { get; set; }
        public BOSList<MMProductionComplexityByOperationsInfo> ProductionComplexityByOperationsList { get; set; }
        /// <summary>
        /// Gets or sets stock parent id
        /// </summary>
        public int OperationParentID { get; set; }
        #endregion

        #region Constructor
        public OperationEntities()
            : base()
        {
            LineOperationsList = new BOSList<MMLineOperationsInfo>();
            OperationMachineGroupsList = new BOSList<MMOperationMachineGroupsInfo>();
            ProductionComplexityByOperationsList = new BOSList<MMProductionComplexityByOperationsInfo>();
        }


        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMOperationsInfo();
            SearchObject = new MMOperationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMLineOperationTableName, new MMLineOperationsInfo());
            ModuleObjects.Add(TableName.MMOperationMachineGroupsTableName, new MMOperationMachineGroupsInfo());
            ModuleObjects.Add(TableName.MMProductionComplexityByOperationsTableName, new MMProductionComplexityByOperationsInfo());
        }

        public override void InitModuleObjectList()
        {
            LineOperationsList.InitBOSList(this,
                                             TableName.MMOperationsTableName,
                                             TableName.MMLineOperationTableName,
                                             BOSList<MMLineOperationsInfo>.cstRelationForeign);
            LineOperationsList.ItemTableForeignKey = "FK_MMOperationID";

            OperationMachineGroupsList.InitBOSList(this,
                                             TableName.MMOperationsTableName,
                                             TableName.MMOperationMachineGroupsTableName,
                                             BOSList<MMOperationMachineGroupsInfo>.cstRelationForeign);
            OperationMachineGroupsList.ItemTableForeignKey = "FK_MMOperationID";

            ProductionComplexityByOperationsList.InitBOSList(this,
                                             TableName.MMOperationsTableName,
                                             TableName.MMProductionComplexityByOperationsTableName,
                                             BOSList<MMProductionComplexityByOperationsInfo>.cstRelationForeign);
            ProductionComplexityByOperationsList.ItemTableForeignKey = "FK_MMOperationID";
        }

        public override void InitGridControlInBOSList()
        {
            LineOperationsList.InitBOSListGridControl(OperationModule.LineOperationGridControl);
            OperationMachineGroupsList.InitBOSListGridControl("fld_dgcMMOperationMachineGroups");
            ProductionComplexityByOperationsList.InitBOSListGridControl("fld_dgcMMProductionComplexityByOperations");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)MainObject;
            objOperationsInfo.MMOperationNeedQC = false;
            objOperationsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                LineOperationsList.SetDefaultListAndRefreshGridControl();
                OperationMachineGroupsList.SetDefaultListAndRefreshGridControl();
                ProductionComplexityByOperationsList.SetDefaultListAndRefreshGridControl();
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

            OperationParentID = iObjectID;
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            LineOperationsList.Invalidate(iObjectID);
            OperationMachineGroupsList.Invalidate(iObjectID);
            ProductionComplexityByOperationsList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)MainObject;
            if (objOperationsInfo.MMOperationID == 0)
            {
                objOperationsInfo.MMOperationParentID = OperationParentID;
            }
            //objOperationsInfo.ICStockContactAddressLine3 = BOSUtil.GenerateFullAddress(MainObject, AddressType.Contact.ToString());

            int operationID = base.SaveMainObject();
            return operationID;
        }
        public override void SaveModuleObjects()
        {
            LineOperationsList.SaveItemObjects();
            OperationMachineGroupsList.SaveItemObjects();
            ProductionComplexityByOperationsList.SaveItemObjects();
        }

        #endregion

        public override void Delete(int iObjectID)
        {
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)MainObject;
            iObjectID = objOperationsInfo.MMOperationID;
            base.Delete(iObjectID);
        }

    }
}
