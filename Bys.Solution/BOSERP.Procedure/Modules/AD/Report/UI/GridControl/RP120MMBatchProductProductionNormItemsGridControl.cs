using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP120MMBatchProductProductionNormItemsGridControl : BOSGridControl
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
            column.Caption = "Mã lô SX";
            column.FieldName = "MMBatchProductItemProductSerial";
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
            column.Caption = "SỐ LƯỢNG KẾ HOẠCH";
            column.FieldName = "SoLuongChiTietKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 KH";
            column.FieldName = "M3TinhKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG SP ĐÃ SƠN";
            column.FieldName = "SoLuongSXThucTe";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 SP ĐÃ SƠN";
            column.FieldName = "M3ThucTe";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG SP THIẾU";
            column.FieldName = "SoLuongThieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 THIẾU ";
            column.FieldName = "M3Thieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CỤM DỠ DANG ";
            column.FieldName = "M3GoKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 DỠ DANG";
            column.FieldName = "M3ThucTeNhan";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CỤM CHƯA QUA SƠN";
            column.FieldName = "SoLuongCumChuaQuaSon";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 CỤM CHƯA QUA SƠN";
            column.FieldName = "M3CumChuaQuaSon";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M2 ĐỊNH MỨC";
            column.FieldName = "M2Dinhmuc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M2 DỠ DANG";
            column.FieldName = "M2dodang";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M2 ĐÃ QUA SƠN";
            column.FieldName = "M2DaQuaSon";
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
            column = gridView.Columns["SoLuongChiTietKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["M3TinhKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["M2Dinhmuc"];
            if (column != null)
            {
                column.VisibleIndex = 6;
            }
            column = gridView.Columns["SoLuongSXThucTe"];
            if (column != null)
            {
                column.VisibleIndex = 7;
            }
            column = gridView.Columns["M3ThucTe"];
            if (column != null)
            {
                column.VisibleIndex = 8;
            }
            column = gridView.Columns["M2DaQuaSon"];
            if (column != null)
            {
                column.VisibleIndex = 9;
            }
            column = gridView.Columns["SoLuongThieu"];
            if (column != null)
            {
                column.VisibleIndex = 10;
            }
            column = gridView.Columns["M3Thieu"];
            if (column != null)
            {
                column.VisibleIndex = 11;
            }
            column = gridView.Columns["M3GoKeHoach"];
            if (column != null)
            {
                column.VisibleIndex = 12;
            }
            column = gridView.Columns["M3ThucTeNhan"];
            if (column != null)
            {
                column.VisibleIndex = 13;
            }
            column = gridView.Columns["M2dodang"];
            if (column != null)
            {
                column.VisibleIndex = 14;
            }
            column = gridView.Columns["SoLuongCumChuaQuaSon"];
            if (column != null)
            {
                column.VisibleIndex = 15;
            }
            column = gridView.Columns["M3CumChuaQuaSon"];
            if (column != null)
            {
                column.VisibleIndex = 16;
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
