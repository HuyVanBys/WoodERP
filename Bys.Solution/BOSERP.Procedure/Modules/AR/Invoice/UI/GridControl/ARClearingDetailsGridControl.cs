using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Invoice
{
    public class ARClearingDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            
            GridColumn column = gridView.Columns["ARClearingDetailAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
                column.SummaryItem.DisplayFormat = "{0:n3}";
                column.ColumnEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.ColumnEdit.DisplayFormat.FormatString = "{0:n3}";
            }
            InitColumnSummary("ARClearingDetailAmount", DevExpress.Data.SummaryItemType.Sum);
            column = gridView.Columns["FK_ARCustomerPaymentID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ARClearingDetailDesc"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ARCustomerPaymentTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ARCustomerPaymentClearingTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ARCustomerPaymentRemainAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Số tiền có thể cấn trừ";
            column.FieldName = "ARClearingDetailCanClearingAmount";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
