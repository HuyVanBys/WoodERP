using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP119MMBatchProductProductionNormItemsGridControl : BOSGridControl
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
            column.Caption = "MÃ SẢN PHẨM";
            column.FieldName = "MaSP";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "TÊN SẢN PHẨM";
            column.FieldName = "TenSP";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "TÊN CHI TIẾT";
            column.FieldName = "TenCum";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "MÃ CỤM";
            column.FieldName = "MaCum";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CHI TIẾT KH";
            column.FieldName = "SoLuongChiTietKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 CỤM KH";
            column.FieldName = "M3TinhKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CỤM ĐÃ RÁP";
            column.FieldName = "SoLuongSXThucTe";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 CỤM ĐÃ RÁP";
            column.FieldName = "M3ThucTe";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CỤM THIẾU SO VỚI KH";
            column.FieldName = "SoLuongThieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 CỤM THIẾU SO VỚI KẾ HOẠCH";
            column.FieldName = "M3Thieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CHI TIẾT DỠ DANG CHỜ RÁP";
            column.FieldName = "SLChiTietDoDangChoLR";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 DỠ DANG CHỜ RÁP";
            column.FieldName = "M3DoDangChoLapRap";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CỤM THAM KHẢO";
            column.FieldName = "SLCumThamKhao";
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
            column = gridView.Columns["TenCum"];
            if (column != null)
            {
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["MaCum"];
            if (column != null)
            {
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["SoLuongCumKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 6;
            }
            column = gridView.Columns["M3TinhKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 7;
            }
            column = gridView.Columns["SoLuongSXThucTe"];
            if (column != null)
            {
                column.VisibleIndex = 8;
            }
            column = gridView.Columns["M3ThucTe"];
            if (column != null)
            {
                column.VisibleIndex = 9;
            }
            column = gridView.Columns["SoLuongThieu"];
            if (column != null)
            {
                column.VisibleIndex = 9;
            }
            column = gridView.Columns["M3Thieu"];
            if (column != null)
            {
                column.VisibleIndex = 10;
            }
            column = gridView.Columns["SLChiTietDoDangChoLR"];
            if (column != null)
            {
                column.VisibleIndex = 11;
            }
            column = gridView.Columns["M3DoDangChoLapRap"];
            if (column != null)
            {
                column.VisibleIndex = 12;
            }
            column = gridView.Columns["SLCumThamKhao"];
            if (column != null)
            {
                column.VisibleIndex = 13;
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
