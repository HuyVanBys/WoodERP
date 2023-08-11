using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class ARRP245ShipmentItemsGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "ICShipmentDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn hàng nội bộ";
            column.FieldName = "MMBatchProductItemSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lệnh sản xuất";
            column.FieldName = "MMBatchProductNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã sản phẩm";
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mô tả sản phẩm";
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số thanh/tấm xuất";
            column.FieldName = "ICShipmentItemWoodQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số thanh/tấm nhập";
            column.FieldName = "ICReceiptItemWoodQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = " SL Xuất";
            column.FieldName = "ICShipmentItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL Nhập";
            column.FieldName = "ICReceiptItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng xuất (X-N)";
            column.FieldName = "TotalQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "NCC";
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngàng hàng";
            column.FieldName = "ICDepartmentName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm hàng";
            column.FieldName = "ICProductGroupName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
        }
    }
}
