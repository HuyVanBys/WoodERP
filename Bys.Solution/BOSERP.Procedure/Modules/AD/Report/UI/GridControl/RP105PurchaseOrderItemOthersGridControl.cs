using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105PurchaseOrderItemOthersGridControl : BOSGridControl
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
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "APPurchaseOrderItemProductQty")
                {
                    column.Caption = "Số lượng";
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
                if (column.FieldName == "APPurchaseOrderItemReceiptedQty")
                {
                    column.Caption = "Số lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
                if (column.FieldName == "APPurchaseOrderItemPackagedQty")
                {
                    column.Caption = "Số lượng đóng hàng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            return gridView;
        }
    }
}
