using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentTerm
{
    public partial class GEPaymentTermItemGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            PaymentTermEntities entity = (PaymentTermEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.GEPaymentTermItemList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PaymentTermModule)Screen.Module).RemoveSelectedItemFromGEPaymentTermItemList();
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }
    }
}
