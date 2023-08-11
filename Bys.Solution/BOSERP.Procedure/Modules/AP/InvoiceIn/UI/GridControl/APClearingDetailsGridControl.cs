using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.InvoiceIn
{
    public class APClearingDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("APClearingDetailAmount", DevExpress.Data.SummaryItemType.Sum);

            GridColumn column = gridView.Columns["APClearingDetailAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Số tiền có thể cấn trừ";
            column.FieldName = "APClearingDetailCanClearingAmount";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n0}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
