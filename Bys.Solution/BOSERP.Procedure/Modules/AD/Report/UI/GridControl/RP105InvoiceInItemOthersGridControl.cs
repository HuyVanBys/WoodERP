using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105InvoiceInItemOthersGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "APInvoiceInItemProductQty")
                {
                    column.Caption = "Số lượng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                    column.Visible = true;
                }
                if (column.FieldName == "APInvoiceInItemReceiptedQty")
                {
                    column.Caption = "Số lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                    column.Visible = true;
                }
                if (column.FieldName == "APInvoiceInItemWoodQty")
                {
                    column.Visible = false;
                }
                if (column.FieldName == "APInvoiceInItemQty1")
                {
                    column.Visible = false;
                }
            }
            return gridView;
        }
    }
}
