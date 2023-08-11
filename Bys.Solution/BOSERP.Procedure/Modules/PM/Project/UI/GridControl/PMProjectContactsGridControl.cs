using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public partial class PMProjectContactsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProjectEntities entity = (ProjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProjectContactsList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProjectModule)Screen.Module).RemoveSelectedItemFromProjectContactList();
            }
        }
    }
}
