using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class ARRP009CustomersGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsBehavior.Editable = false;

            InitColumnSummary("TotalPurchaseAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("TotalPurchaseQty", DevExpress.Data.SummaryItemType.Sum);

            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "TotalPurchaseAmount";
            column.Caption = ReportLocalizedResources.TotalPurchaseAmount;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TotalPurchaseQty";
            column.Caption = ReportLocalizedResources.TotalPurchaseQty;
            gridView.Columns.Add(column);
        }
    }
}
