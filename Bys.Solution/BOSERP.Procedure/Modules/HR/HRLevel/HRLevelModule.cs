namespace BOSERP.Modules.HRLevel
{
    public class HRLevelModule : BaseModuleERP
    {
        public HRLevelModule()
        {
            Name = "HRLevel";
            CurrentModuleEntity = new HRLevelEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

    }
}
