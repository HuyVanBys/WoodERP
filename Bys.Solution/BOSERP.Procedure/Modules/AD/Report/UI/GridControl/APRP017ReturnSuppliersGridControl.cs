namespace BOSERP.Modules.Report
{
    public partial class APRP017ReturnSuppliersGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            base.InitializeGridView();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;

            InitColumnSummary("APReturnSupplierTotalCost", DevExpress.Data.SummaryItemType.Sum);

            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["APReturnSupplierDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }
    }
}
