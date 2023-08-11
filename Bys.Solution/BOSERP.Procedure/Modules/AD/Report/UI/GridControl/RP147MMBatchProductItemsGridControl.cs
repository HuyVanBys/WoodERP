using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP147MMBatchProductItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Lệnh sản xuất";
            column.FieldName = "LenhSanXuat";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã sản phẩm";
            column.FieldName = "MaSP";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên Sản Phẩm";
            column.FieldName = "TenSP";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng SP kế hoạch";
            column.FieldName = "SLSPKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng SP đã đóng gói";
            column.FieldName = "SLSPDaDongGoi";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng SP Thiếu";
            column.FieldName = "SLSPThieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 sản phẩm KH";
            column.FieldName = "M3TinhKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng thùng kế hoạch";
            column.FieldName = "SLThungKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng thùng đã đóng";
            column.FieldName = "SLThungDaDong";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng thùng thiếu";
            column.FieldName = "SLThungThieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lô";
            column.FieldName = "MMBatchProductItemProductSerial";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            GridColumn column = gridView.Columns["LenhSanXuat"];
            if (column != null)
            {

                column.Group();
            }
            column = gridView.Columns["MaSP"];
            if (column != null)
            {
                column.VisibleIndex = 2;
            }
            column = gridView.Columns["TenSP"];
            if (column != null)
            {
                column.VisibleIndex = 3;
            }
            column = gridView.Columns["SLSPKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["SLSPDaDongGoi"];
            if (column != null)
            {
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["SLSPThieu"];
            if (column != null)
            {
                column.VisibleIndex = 6;
            }
            column = gridView.Columns["M3TinhKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 7;
            }
            column = gridView.Columns["SLThungKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 8;
            }
            column = gridView.Columns["SLThungDaDong"];
            if (column != null)
            {
                column.VisibleIndex = 9;
            }
            column = gridView.Columns["SLThungThieu"];
            if (column != null)
            {
                column.VisibleIndex = 9;
            }
            column = gridView.Columns["MMBatchProductItemProductSerial"];
            if (column != null)
            {
                column.VisibleIndex = 10;
            }
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.BestFitColumns();
        }
    }
}
