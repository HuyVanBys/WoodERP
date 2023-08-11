using System.Windows.Forms;

namespace BOSERP.Modules.BugManagement
{
    public class HRBugManagementTemplatesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BugManagementEntities entity = (BugManagementEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BugManagementTemplatesList;
            this.DataSource = bds;
        }
    }
}
