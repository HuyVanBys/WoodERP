using BOSLib;

namespace BOSERP.Modules.Introduction
{
    public class HomeModule : BaseModuleERP
    {
        public HomeModule()
        {
            Name = BaseModuleERP.cstHomeModule;
            Toolbar = new BaseToolbar();
            InitializeScreens();
        }
    }
}
