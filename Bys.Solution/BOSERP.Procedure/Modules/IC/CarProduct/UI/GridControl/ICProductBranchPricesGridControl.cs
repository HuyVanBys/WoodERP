using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.CarProduct
{
    public partial class ICProductBranchPricesGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.Columns.Clear();
            UseEmbeddedNavigator = false;
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                int index = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
                ((CarProductModule)Screen.Module).ChangeProductBranchPrice(this, index, e.Column.FieldName);
            }
        }
    }
}
