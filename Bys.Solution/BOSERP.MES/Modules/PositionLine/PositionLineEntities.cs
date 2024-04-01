using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.PositionLine
{
    public class PositionLineEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSTreeList LocationTreeList { get; set; }
        #endregion

        #region Constructor
        public PositionLineEntities()
            : base()
        {

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMPositionsInfo();
            SearchObject = new MMPositionsInfo();
            LocationTreeList = new BOSTreeList();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMPositionsTableName, new MMPositionsInfo());
        }

        public override void InitModuleObjectList()
        {
            LocationTreeList.InitBOSList(this,
                                    String.Empty,
                                    TableName.GELocationsTableName,
                                    BOSTreeList.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            LocationTreeList.InitBOSTreeListControl("fld_trlGELocations");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMPositionsInfo objPositionsInfo = (MMPositionsInfo)MainObject;
            objPositionsInfo.MMPositionType = PositionType.Line.ToString();
            objPositionsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                LocationTreeList.SetDefaultListAndRefreshTreeListControl();
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

            MMPositionsInfo objPositionsInfo = (MMPositionsInfo)MainObject;
            GELocationsController objLocationsController = new GELocationsController();
            objPositionsInfo.MMPositionGELocationName = objLocationsController.GetFullLocationNameByID(objPositionsInfo.FK_GELocationID);
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {

        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {

        }
        #endregion                
    }
}
