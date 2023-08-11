namespace BOSERP.Modules.Report
{
    public partial class RP104APInvoiceInsGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = ReportLocalizedResources.APInvoiceInPaymentAmount;
            //column.FieldName = "APInvoiceInPaymentAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }
    }
}
