using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public partial class RP146ICShipmentItemsGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Mã sản phẩm";
            column.FieldName = "ICProductNo";
            column.Visible = true;
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductName";
            column.Visible = true;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mô tả";
            column.FieldName = "ICProductDesc";
            column.Visible = true;
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lô hàng";
            column.FieldName = "ICProductSerieNo";
            column.Visible = true;
            column.VisibleIndex = 4;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Phòng ban";
            column.FieldName = "HRDepartmentRoomName";
            column.Visible = true;
            column.VisibleIndex = 5;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "EquipmentCardReceiptItemProductQty";
            column.Visible = true;
            column.VisibleIndex = 6;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn giá";
            column.FieldName = "EquipmentCardReceiptItemProductUnitPrice";
            column.Visible = true;
            column.VisibleIndex = 7;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành tiền";
            column.FieldName = "EquipmentCardReceiptAmount";
            column.Visible = true;
            column.VisibleIndex = 8;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị đã phân bổ";
            column.FieldName = "EquipmentCardReceiptDepreciatedAmount";
            column.Visible = true;
            column.VisibleIndex = 9;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị còn lại";
            column.FieldName = "EquipmentCardEndBalanceAmount";
            column.Visible = true;
            column.VisibleIndex = 10;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


        }

    }
}
