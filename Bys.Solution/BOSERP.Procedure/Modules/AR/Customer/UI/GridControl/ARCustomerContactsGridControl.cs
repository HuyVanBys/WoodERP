using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{
    public partial class ARCustomerContactsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CustomerEntities entity = (CustomerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CustomerContactsList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CustomerModule)Screen.Module).RemoveSelectedItemFromCustomerContactList();
            }
        }
    }
}
