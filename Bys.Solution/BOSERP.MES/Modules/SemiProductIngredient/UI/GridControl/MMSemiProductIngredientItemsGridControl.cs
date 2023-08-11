using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductIngredient
{
    public class MMSemiProductIngredientItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SemiProductIngredientEntities entity = (SemiProductIngredientEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiProductIngredientItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            gridView.GroupFormat = "[#image]{1} {2}";

            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 0;
            }

            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((SemiProductIngredientModule)Screen.Module).RemoveProductionCostItemList();
            }
        }
    }
}
