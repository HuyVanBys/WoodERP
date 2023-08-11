using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public class RP140GridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceNo";
            column.Caption = "Mã phiếu giao";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceDate";
            column.Caption = "Ngày giao hàng";
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
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceItemProductName";
            column.Caption = "Tên sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductGroupName";
            column.Caption = "Nhóm hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICDepartmentName";
            column.Caption = "Ngành hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "WoodType";
            column.Caption = "Loại gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICMeasureUnitName";
            column.Caption = "Đơn vị tính";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductQty";
            column.Caption = "Số lượng lệnh sản xuất";
            SetFormat("MMBatchProductItemProductQty", "n2", gridView);
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceItemProductQty";
            column.Caption = "Số lượng thực xuất";
            //SetFormat("ARInvoiceItemProductQty", "n2", gridView);
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemBlockPerOne";
            // SetFormat("MMBatchProductProductionNormItemBlockPerOne", "n4", gridView);
            column.Caption = "Khối tinh";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionNormTotalPaint";
            // SetFormat("MMBatchProductProductionNormItemBlockPerOne", "n4", gridView);
            column.Caption = "M2 sơn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICReceiptItemWoodFee";
            column.Caption = "Tiền gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemPaintFee";
            column.Caption = "Tiền sơn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemHardwareFee";
            column.Caption = "Tiền hardware";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemMaintainFee";
            column.Caption = "Tiền bao bì";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 18;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemDirectSalaryFee";
            column.Caption = "Tiền lương";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 19;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemElecFee";
            column.Caption = "Tiền điện";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 20;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemDepreciationFee";
            column.Caption = "Tiền khấu hao";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 21;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICReceiptItemOtherFee";
            column.Caption = "CPSXC khác";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 22;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "CPGiaCong";
            column.Caption = "Tiền gia công";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 23;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "CongGiaVon";
            column.Caption = "Cộng giá vốn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 24;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceItemProductUnitPrice";
            column.Caption = "Gía bán";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 25;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockUnitCost";
            column.Caption = "Gía mua ngoài";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 26;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "LNGop";
            column.Caption = "Lãi gộp";
            //SetFormat("LNGop", "n3", gridView);
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 27;
            gridView.Columns.Add(column);
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            // gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);


            if (gridView.Columns["ARInvoiceItemProductQty"] != null)
            {

                SetFormat("ARInvoiceItemProductQty", "n3", gridView);
            }

            return gridView;
        }


    }
}
