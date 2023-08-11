using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public class MMCalculatorProductionNormCostItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CalculatorProductionNormCostItemList;
            this.DataSource = bds;
        }

        public void ChangeGridFormat(int currencyID)
        {
            GridView gridView = (GridView)MainView;
            foreach (GridColumn col in gridView.Columns)
            {

                //if (col.FieldName == "MMCalculatorProductionNormCostItemCostPrice")
                //{
                //    BOSApp.FormatColumnByCurrency(col, 0);
                //}
                //else if (col.FieldName == "MMCalculatorProductionNormCostItemCostPriceExchange")
                //{
                //    BOSApp.FormatColumnByCurrency(col, currencyID);
                //}
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["MMCalculatorProductionNormCostItemNumber"];
            if (column != null)
            {
                column.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            //foreach (GridColumn col in gridView.Columns)
            //{
            //    col.OptionsColumn.AllowEdit = true;
            //}
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((CalculatorProductionNormCostModule)Screen.Module).RemoveSelectedItemsList();
                }
            }
        }
    }
}
