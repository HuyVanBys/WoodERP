namespace BOSERP.Modules.Report
{
    public partial class ARRP010SaleOrdersGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsBehavior.Editable = false;

            InitColumnSummary("ARSaleOrderTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARSaleOrderDepositBalance", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARSaleOrderBalanceDue", DevExpress.Data.SummaryItemType.Sum);

            return gridView;
        }
    }
}
