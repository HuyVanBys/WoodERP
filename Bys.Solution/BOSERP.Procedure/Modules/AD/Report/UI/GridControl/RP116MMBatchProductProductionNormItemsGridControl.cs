using BOSComponent;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public partial class RP116MMBatchProductProductionNormItemsGridControl : BOSGridControl
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
            column.Caption = "MÃ CHI TIẾT";
            column.FieldName = "MaChiTiet";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "TÊN CHI TIẾT SP";
            column.FieldName = "TenChiTietSP";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "CÔNG ĐOẠN";
            column.FieldName = "CongDoan";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG CHI TIẾT KH";
            column.FieldName = "SoLuongChiTietKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 TINH KH";
            column.FieldName = "M3TinhKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG SX THỰC TẾ";
            column.FieldName = "SoLuongSXThucTe";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 THỰC TẾ";
            column.FieldName = "M3ThucTe";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SỐ LƯỢNG THIẾU";
            column.FieldName = "SoLuongThieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 THIẾU";
            column.FieldName = "M3Thieu";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "DÀY PHÁCH GỖ";
            column.FieldName = "DayPhachGo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 GỖ KẾ HOẠCH";
            column.FieldName = "M3GoKeHoach";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 THỰC TẾ NHẬN";
            column.FieldName = "M3ThucTeNhan";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 GỖ CÒN LẠI";
            column.FieldName = "M3GoConLai";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "M3 VƯỢT ĐM";
            column.FieldName = "M3VuotDM";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "TỈ LỆ TIÊU HAO";
            column.FieldName = "TiLeTieuHao";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Thành phẩm";
            column.FieldName = "ThanhPham";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);




        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["LenhSanXuat"];
            if (column != null)
            {

                column.Group();
            }
            column = gridView.Columns["ThanhPham"];
            if (column != null)
            {

                column.Group();
            }
            //column = gridView.Columns["MaSP"];
            //if (column != null)
            //{
            //    column.Caption = "MÃ SẢN PHẨM";
            //    column.VisibleIndex = 1;
            //}

            //column = gridView.Columns["TenSP"];
            //if (column != null)
            //{
            //    column.Caption = "TÊN SẢN PHẨM";
            //    column.VisibleIndex = 2;
            //}

            column = gridView.Columns["MaChiTiet"];
            if (column != null)
            {
                column.Caption = "MÃ CHI TIẾT";
                column.VisibleIndex = 3;

            }

            column = gridView.Columns["TenChiTietSP"];
            if (column != null)
            {
                column.Caption = "TÊN CHI TIẾT SP";
                column.VisibleIndex = 4;
            }

            column = gridView.Columns["CongDoan"];
            if (column != null)
            {
                column.Caption = "CÔNG ĐOẠN";
                column.VisibleIndex = 5;
            }

            column = gridView.Columns["SoLuongChiTietKeHoach"];
            if (column != null)
            {
                column.Caption = "SỐ LƯỢNG CHI TIẾT KH";
                column.VisibleIndex = 6;
            }

            column = gridView.Columns["M3TinhKeHoach"];
            if (column != null)
            {
                column.Caption = "M3 TINH KH";
                column.VisibleIndex = 7;
            }

            column = gridView.Columns["SoLuongSXThucTe"];
            if (column != null)
            {
                column.Caption = "SỐ LƯỢNG SX THỰC TẾ";
                column.VisibleIndex = 8;
            }

            column = gridView.Columns["M3ThucTe"];
            if (column != null)
            {
                column.Caption = "M3 THỰC TẾ";
                column.VisibleIndex = 9;
            }

            column = gridView.Columns["SoLuongThieu"];
            if (column != null)
            {
                column.Caption = "SỐ LƯỢNG THIẾU";
                column.VisibleIndex = 10;
            }

            column = gridView.Columns["M3Thieu"];
            if (column != null)
            {
                column.Caption = "M3 THIẾU";
                column.VisibleIndex = 11;
            }

            column = gridView.Columns["DayPhachGo"];
            if (column != null)
            {
                column.Caption = "DÀY PHÁCH GỖ";
                column.VisibleIndex = 12;
            }

            column = gridView.Columns["M3GoKeHoach"];
            if (column != null)
            {
                column.Caption = "M3 GỖ KẾ HOẠCH";
                column.VisibleIndex = 13;
            }

            column = gridView.Columns["M3ThucTeNhan"];
            if (column != null)
            {
                column.Caption = "M3 THỰC TẾ NHẬN";
                column.VisibleIndex = 14;
            }

            column = gridView.Columns["M3GoConLai"];
            if (column != null)
            {
                column.Caption = "M3 GỖ CÒN LẠI";
                column.VisibleIndex = 15;
            }

            column = gridView.Columns["M3VuotDM"];
            if (column != null)
            {
                column.Caption = "M3 VƯỢT ĐM";
                column.VisibleIndex = 16;
            }
            column = gridView.Columns["TiLeTieuHao"];
            if (column != null)
            {
                column.Caption = "TỈ LỆ TIÊU HAO";
                column.VisibleIndex = 17;
            }


            return gridView;
        }
    }
}
