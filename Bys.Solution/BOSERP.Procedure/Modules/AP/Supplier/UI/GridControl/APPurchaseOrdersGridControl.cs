using BOSComponent;

namespace BOSERP.Modules.Supplier
{
    public partial class APPurchaseOrdersGridControl : BOSGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["APPurchaseOrderDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }
    }
}
