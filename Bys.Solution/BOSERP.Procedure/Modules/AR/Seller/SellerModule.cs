namespace BOSERP.Modules.Seller
{
    class SellerModule : BaseModuleERP
    {
        public SellerModule()
        {
            Name = "Seller";
            CurrentModuleEntity = new SellerEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
    }
}
