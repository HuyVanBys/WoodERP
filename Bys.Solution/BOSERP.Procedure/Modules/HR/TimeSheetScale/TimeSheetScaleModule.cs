using BOSCommon.Constants;

namespace BOSERP.Modules.TimeSheetScale
{
    public class TimeSheetScaleModule : BaseModuleERP
    {
        #region Constants
        public const string TimeSheetLevelGridControlName = "fld_dgcTimeSheetLevels";
        #endregion

        public TimeSheetScaleModule()
        {
            Name = ModuleName.TimeSheetScale;
            CurrentModuleEntity = new TimeSheetScaleEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void RemoveItemFromRewardList()
        {
            TimeSheetScaleEntities entity = (TimeSheetScaleEntities)CurrentModuleEntity;
            entity.TimeSheetLevelList.RemoveSelectedRowObjectFromList();
        }
    }
}
