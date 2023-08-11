namespace BOSERP.Modules.Report
{
    public partial class ARRP011InvoicesGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            base.InitializeGridView();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsBehavior.Editable = false;

            DevExpress.XtraGrid.Columns.GridColumn colTotalAmount = gridView.Columns["ARInvoiceTotalAmount"];
            colTotalAmount.SummaryItem.FieldName = "ARInvoiceTotalAmount";
            colTotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            colTotalAmount.SummaryItem.DisplayFormat = "{0:n2}";

            gridView.Columns["ARInvoiceID"].Caption = "Number";
            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["ARInvoiceDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }
    }
}
