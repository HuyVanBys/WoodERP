using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Seller
{
    public partial class ARSellerContactsGridControl : BOSComponent.BOSGridControl
    {
        public ARSellerContactsGridControl()
        {
            InitializeComponent();
        }

        public ARSellerContactsGridControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            SellerEntities entity = (SellerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSellerContactsList;
            this.DataSource = bds;
        }
    }
}
