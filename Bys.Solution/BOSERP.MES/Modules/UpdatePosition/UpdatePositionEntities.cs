using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.UpdatePosition
{
    public class UpdatePositionEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMUpdatePositionItemsInfo> UpdatePositionItemList { get; set; }
        #endregion

        #region Constructor
        public UpdatePositionEntities()
            : base()
        {
            UpdatePositionItemList = new BOSList<MMUpdatePositionItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMUpdatePositionsInfo();
            SearchObject = new MMUpdatePositionsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMUpdatePositionsTableName, new MMPositionsInfo());
            ModuleObjects.Add(TableName.MMUpdatePositionItemsTableName, new MMPositionsInfo());
        }

        public override void InitModuleObjectList()
        {
            UpdatePositionItemList.InitBOSList(this,
                                                TableName.MMUpdatePositionsTableName,
                                                TableName.MMUpdatePositionItemsTableName,
                                                BOSList<MMUpdatePositionItemsInfo>.cstRelationForeign);
            UpdatePositionItemList.ItemTableForeignKey = "FK_MMUpdatePositionID";
        }

        public override void InitGridControlInBOSList()
        {
            UpdatePositionItemList.InitBOSListGridControl("fld_dgcMMUpdatePostitionItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMUpdatePositionsInfo objPositionsInfo = (MMUpdatePositionsInfo)MainObject;
            objPositionsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objPositionsInfo.MMUpdatePositionStatus = UpdatePositionStatus.New.ToString();
            objPositionsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objPositionsInfo.MMUpdatePositionDate = DateTime.Now;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                UpdatePositionItemList.SetDefaultListAndRefreshGridControl();
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
            UpdatePositionItemList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            UpdatePositionItemList.SaveItemObjects();
        }
        public override bool CompleteTransaction()
        {
            MMUpdatePositionsInfo mainObject = (MMUpdatePositionsInfo)MainObject;
            //Update the this's status
            mainObject.MMUpdatePositionStatus = UpdatePositionStatus.Approved.ToString();
            UpdateMainObject();
            return true;
        }
            #endregion
        }
}
