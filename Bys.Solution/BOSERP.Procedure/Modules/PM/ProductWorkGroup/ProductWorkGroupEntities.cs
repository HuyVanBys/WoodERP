namespace BOSERP.Modules.ProductWorkGroup
{
    public class ProductWorkGroupEntities : ERPModuleEntities
    {
        #region Constructor
        public ProductWorkGroupEntities()
            : base()
        {
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductWorkGroupsInfo();
            SearchObject = new ICProductWorkGroupsInfo();
        }
        #endregion
    }
}