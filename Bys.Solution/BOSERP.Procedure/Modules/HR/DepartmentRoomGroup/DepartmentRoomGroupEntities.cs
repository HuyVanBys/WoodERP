using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.DepartmentRoomGroup
{
    class DepartmentRoomGroupEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        public BOSList<HRDepartmentRoomGroupItemsInfo> DepartmentRoomGroupItemList { get; set; }
        public BOSList<HRDepartmentGroupOperationsInfo> DepGroupOperationList { get; set; }

        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public DepartmentRoomGroupEntities()
            : base()
        {
            DepartmentRoomGroupItemList = new BOSList<HRDepartmentRoomGroupItemsInfo>();
            DepGroupOperationList = new BOSList<HRDepartmentGroupOperationsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRDepartmentRoomGroupsInfo();
            SearchObject = new HRDepartmentRoomGroupsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRDepartmentRoomGroupItemsTableName, new HRDepartmentRoomGroupItemsInfo());

        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRDepartmentRoomGroupsInfo objMainObject = (HRDepartmentRoomGroupsInfo)MainObject;
            objMainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        public override void InitModuleObjectList()
        {
            DepartmentRoomGroupItemList.InitBOSList(
                                      this,
                                      TableName.HRDepartmentRoomGroupsTableName,
                                      TableName.HRDepartmentRoomGroupItemsTableName,
                                      BOSList<HRDepartmentRoomGroupItemsInfo>.cstRelationForeign);
            DepartmentRoomGroupItemList.ItemTableForeignKey = "FK_HRDepartmentRoomGroupID";

            DepGroupOperationList.InitBOSList(
                                       this,
                                       TableName.HRDepartmentRoomGroupItemsTableName,
                                       "HRDepartmentGroupOperations",
                                       BOSList<HRDepartmentGroupOperationsInfo>.cstRelationForeign);
            DepGroupOperationList.ItemTableForeignKey = "FK_HRDepartmentRoomGroupItemID";
        }
        public override void InitGridControlInBOSList()
        {
            DepartmentRoomGroupItemList.InitBOSListGridControl();

        }
        public override void SaveModuleObjects()
        {
            DepartmentRoomGroupItemList.SaveItemObjects();
            DepGroupOperationList.SaveItemObjects();
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DepartmentRoomGroupItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }


        #endregion

        public override void InvalidateModuleObjects(int iObjectID)
        {
            DepartmentRoomGroupItemList.Invalidate(iObjectID);
            HRDepartmentGroupOperationsController control = new HRDepartmentGroupOperationsController();
            List<HRDepartmentGroupOperationsInfo> listFound = control.GetOperationByParent(iObjectID);
            DepGroupOperationList.Invalidate(listFound);
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }
        #region Save Module Objects functions



        #endregion

    }
}
