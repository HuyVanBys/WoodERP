using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.TimeSheetScale
{
    public class TimeSheetScaleEntities : ERPModuleEntities
    {
        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the level list of the time sheet scale
        /// </summary>
        public BOSList<HRTimeSheetLevelsInfo> TimeSheetLevelList { get; set; }
        #endregion

        #region Constructor
        public TimeSheetScaleEntities()
            : base()
        {
            TimeSheetLevelList = new BOSList<HRTimeSheetLevelsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRTimeSheetScalesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRTimeSheetLevelsTableName, new HRTimeSheetLevelsInfo());
        }

        public override void InitModuleObjectList()
        {
            TimeSheetLevelList.InitBOSList(
                                        this,
                                        TableName.HRTimeSheetScalesTableName,
                                        TableName.HRTimeSheetLevelsTableName,
                                        BOSList<HRTimeSheetLevelsInfo>.cstRelationForeign);
            TimeSheetLevelList.ItemTableForeignKey = "FK_HRTimeSheetScaleID";
        }

        public override void InitGridControlInBOSList()
        {
            TimeSheetLevelList.InitBOSListGridControl(TimeSheetScaleModule.TimeSheetLevelGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                TimeSheetLevelList.SetDefaultListAndRefreshGridControl();
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
            TimeSheetLevelList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            TimeSheetLevelList.SaveItemObjects();
        }
        #endregion        
    }
}
