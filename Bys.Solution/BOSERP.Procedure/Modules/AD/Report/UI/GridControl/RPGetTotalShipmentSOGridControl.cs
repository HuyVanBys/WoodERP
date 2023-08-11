using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RPGetTotalShipmentSOGridControl : ReportGridControl
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
            column.Caption = "Xưởng";
            column.FieldName = "MMWorkShopName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã LSX";
            column.FieldName = "MMBatchProductNo";
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
            column.Caption = "Ngày DKXH";
            column.FieldName = "ARSaleOrderDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tinh";
            column.FieldName = "MMBatchProductProductionNormItemBlocks";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thô";
            column.FieldName = "MMBatchProductProductionNormItemMeterialDepreciationQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Xuất gỗ nguyên";
            column.FieldName = "ICShipmentItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhập gỗ nguyên";
            column.FieldName = "ICReceiptItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tỉ lệ sử dụng gỗ nguyên";
            column.FieldName = "TiLeSuDungGoNguyen";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Xuất gỗ loại";
            column.FieldName = "ICShipmentItemProductQty1";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhập gỗ loại";
            column.FieldName = "ICReceiptItemProductQty1";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "% Gỗ loại nhập lại";
            column.FieldName = "GoLoaiNhapLai";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "0%";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng xuất";
            column.FieldName = "ICShipmentItemProductTotalQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tỉ lệ sử dụng";
            column.FieldName = "TiLeSuDung";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = " T. Nhiên hoặc màu";
            column.FieldName = "ICProductAttributePaintType";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ghi trú & giải trình";
            column.FieldName = "MMBatchProductRemark";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại đơn hàng";
            column.FieldName = "ARSaleOrderType";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đơn hàng";
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày giao hàng";
            column.FieldName = "ARSaleOrderDeliveryDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên khách hàng";
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 18;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày lập";
            column.FieldName = "AACreatedDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 19;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Diễn giải";
            column.FieldName = "MMBatchProductDesc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 20;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "T.Hiện từ";
            column.FieldName = "MMBatchProductFromDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 21;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đến ngày";
            column.FieldName = "MMBatchProductToDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 22;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày tạo lệnh";
            column.FieldName = "MMBatchProductCreateDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 23;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tình trạng LSX";
            column.FieldName = "MMBatchProductStatus";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 24;
            gridView.Columns.Add(column);
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
        }
    }
}
