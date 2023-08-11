using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{
    public partial class ARRemindGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CustomerEntities entity = (CustomerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARRemindsList;
            DataSource = bds;
        }
    }
}
