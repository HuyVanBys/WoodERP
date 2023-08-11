namespace BOSERP.Modules.Package
{
    public class PackageModule : BaseModuleERP
    {
        public PackageModule()
        {
            Name = "Package";
            CurrentModuleEntity = new PackageEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
    }
}
