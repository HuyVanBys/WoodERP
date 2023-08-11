using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.DepartmentRoomGroupTeam
{
    class DepartmentRoomGroupTeamEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        public BOSList<HRDepartmentRoomGroupTeamItemsInfo> DepartmentRoomGroupTeamItemList { get; set; }

        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public DepartmentRoomGroupTeamEntities()
            : base()
        {
            DepartmentRoomGroupTeamItemList = new BOSList<HRDepartmentRoomGroupTeamItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRDepartmentRoomGroupTeamsInfo();
            SearchObject = new HRDepartmentRoomGroupTeamsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRDepartmentRoomGroupTeamItemsTableName, new HRDepartmentRoomGroupTeamItemsInfo());
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRDepartmentRoomGroupTeamsInfo objMainObject = (HRDepartmentRoomGroupTeamsInfo)MainObject;
            objMainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        public override void InitModuleObjectList()
        {

            DepartmentRoomGroupTeamItemList.InitBOSList(
                                       this,
                                       TableName.HRDepartmentRoomGroupTeamsTableName,
                                       TableName.HRDepartmentRoomGroupTeamItemsTableName,
                                       BOSList<HRDepartmentRoomGroupTeamItemsInfo>.cstRelationForeign);
            DepartmentRoomGroupTeamItemList.ItemTableForeignKey = "FK_HRDepartmentRoomGroupTeamID";

        }
        public override void InitGridControlInBOSList()
        {
            DepartmentRoomGroupTeamItemList.InitBOSListGridControl();

        }
        public override void SaveModuleObjects()
        {
            DepartmentRoomGroupTeamItemList.SaveItemObjects();
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DepartmentRoomGroupTeamItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }


        #endregion

        public override void InvalidateModuleObjects(int iObjectID)
        {

            DepartmentRoomGroupTeamItemList.Invalidate(iObjectID);

        }
        public override void Invalidate(int iObjectID)
        {

            base.Invalidate(iObjectID);

        }
        #region Save Module Objects functions



        #endregion

    }
}
