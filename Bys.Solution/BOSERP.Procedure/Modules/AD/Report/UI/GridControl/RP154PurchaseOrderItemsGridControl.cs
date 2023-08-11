using BOSComponent;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public class RP154PurchaseOrderItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "APPurchaseOrderNo";
            column.Caption = "Đơn mua hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderContractNo";
            column.Caption = "Số hợp đồng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = "Nhà cung cấp";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = "Khách hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeValue";
            column.Caption = "Loại gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemProductHeight";
            column.Caption = "Chiều dày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemProductQty";
            column.Caption = "Khối lượng đặt mua";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemReceiptedQty";
            column.Caption = "Khối lượng đã giao(nhập kho)";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemProductCanceledQty";
            column.Caption = "Khối lượng hủy";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemNotReceiptYet";
            column.Caption = "Khối lượng chưa giao";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);
        }

        //protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        //{

        //    DateTime value = DateTime.Now;
        //    if (e.CellValue != null && (e.Column.FieldName == "MMBatchProductToDate" || e.Column.FieldName == "MMBatchProductDate"))
        //    {
        //        if (DateTime.TryParse(e.CellValue.ToString(), out value))
        //        {
        //            if (value.Date == DateTime.MinValue.Date)
        //            {
        //                e.DisplayText = "";
        //            }
        //            if (value.Date == DateTime.MaxValue.Date)
        //            {
        //                e.DisplayText = "";
        //            }
        //        }
        //    }

        //}


    }
}
