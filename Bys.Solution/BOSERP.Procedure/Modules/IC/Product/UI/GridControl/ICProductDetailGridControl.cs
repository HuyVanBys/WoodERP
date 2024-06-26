using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ICProductDetailGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductDetailsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductDetailProductNo"] != null)
            {
                gridView.Columns["ICProductDetailProductNo"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductDetailProductName"] != null)
            {
                gridView.Columns["ICProductDetailProductName"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductDetailProductDesc"] != null)
            {
                gridView.Columns["ICProductDetailProductDesc"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductDetailProductQty"] != null)
            {
                gridView.Columns["ICProductDetailProductQty"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).DeleteItemFromICProductDetailsList();
            }
        }
    }
}
