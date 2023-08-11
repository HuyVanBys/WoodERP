using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP142BatchProductionNormItemGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = ReportLocalizedResources.MMBatchProductNo1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductSerial";
            column.Caption = ReportLocalizedResources.SerieNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductNo";
            column.Caption = ReportLocalizedResources.ICProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductName";
            column.Caption = ReportLocalizedResources.APPurchaseOrderItemProductName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MaCum";
            column.Caption = ReportLocalizedResources.Macum;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TenCum";
            column.Caption = ReportLocalizedResources.Tencum;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLcum";
            column.Caption = ReportLocalizedResources.SLcum;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLchitiet";
            column.Caption = ReportLocalizedResources.SLchitiet;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MaChiTiet";
            column.Caption = ReportLocalizedResources.Manguyenlieu;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TenChiTietSP";
            column.Caption = ReportLocalizedResources.Tennguyenlieu;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Dactinh";
            column.Caption = ReportLocalizedResources.Dactinh;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Manguyenlieu";
            column.Caption = ReportLocalizedResources.Machitiet;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Tennguyenlieu";
            column.Caption = ReportLocalizedResources.TenchitietSP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductQty";
            column.Caption = ReportLocalizedResources.MMBatchProductItemProductQty;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Dai";
            column.Caption = ReportLocalizedResources.Dai;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Rong";
            column.Caption = ReportLocalizedResources.Rong;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Dayy";
            column.Caption = ReportLocalizedResources.Day;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DVT";
            column.Caption = ReportLocalizedResources.ICMeasureUnitName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLRSS";
            column.Caption = ReportLocalizedResources.SLRSS;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "STDG";
            column.Caption = ReportLocalizedResources.STDG;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Mota";
            column.Caption = ReportLocalizedResources.APPurchaseOrderItemProductDesc;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "MMAllocationProposalDate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value.Date == DateTime.MinValue.Date)
                    {
                        e.DisplayText = "";
                    }
                    if (value.Date == DateTime.MaxValue.Date)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }
        public void LoadGridViewForBatchProductType(string productType)
        {
            GridView gridView = (GridView)MainView;

            GridColumn column = gridView.Columns["MMBatchProductNo"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 0;
            }
            column = gridView.Columns["MMBatchProductItemProductSerial"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 1;
            }
            column = gridView.Columns["MMBatchProductItemProductNo"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 2;
            }
            column = gridView.Columns["MMBatchProductItemProductName"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 3;
            }
            if (productType == BatchProductGroup.SemiProduct.ToString())
            {
                column = gridView.Columns["MaCum"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }
                column = gridView.Columns["TenCum"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                column = gridView.Columns["SLcum"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                column = gridView.Columns["SLchitiet"];
                if (column != null)
                {
                    column.Visible = true;
                    column.Caption = ReportLocalizedResources.SLchitiet;
                    column.VisibleIndex = 10;
                }
                column = gridView.Columns["Manguyenlieu"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                }
                column = gridView.Columns["Tennguyenlieu"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                column = gridView.Columns["Dactinh"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 12;
                }
                column = gridView.Columns["Dai"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 13;
                }
                column = gridView.Columns["Rong"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 14;
                }
                column = gridView.Columns["Dayy"];
                if (column != null)
                {
                    column.Visible = true;
                    column.VisibleIndex = 15;
                }
                column = gridView.Columns["SLRSS"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["STDG"];
                if (column != null)
                {
                    column.Visible = false;
                }

            }
            else
            {
                column = gridView.Columns["SLRSS"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["STDG"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["MaCum"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["TenCum"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["SLcum"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["Manguyenlieu"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["Tennguyenlieu"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["SLchitiet"];
                if (column != null)
                {
                    column.Visible = true;
                    column.Caption = ReportLocalizedResources.SLVatTu;
                    column.VisibleIndex = 10;
                }
                column = gridView.Columns["Dactinh"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["Dai"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["Rong"];
                if (column != null)
                {
                    column.Visible = false;
                }
                column = gridView.Columns["Dayy"];
                if (column != null)
                {
                    column.Visible = false;
                }
            }
            if (productType == BatchProductGroup.Hardware.ToString())
            {
                column = gridView.Columns["SLchitiet"];
                if (column != null)
                {
                    column.Visible = true;
                    column.Caption = ReportLocalizedResources.SLRTS;
                    column.VisibleIndex = 10;
                }
                column = gridView.Columns["SLRSS"];
                if (column != null)
                {
                    column.Visible = true;
                    column.Caption = ReportLocalizedResources.SLRSS;
                    column.VisibleIndex = 11;
                }
                column = gridView.Columns["STDG"];
                if (column != null)
                {
                    column.Visible = true;
                    column.Caption = ReportLocalizedResources.STDG;
                    column.VisibleIndex = 12;
                }
            }
            column = gridView.Columns["MaChiTiet"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 8;
            }
            column = gridView.Columns["TenChiTietSP"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 9;
            }
            column = gridView.Columns["MMBatchProductItemProductQty"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 16;
            }
            column = gridView.Columns["DVT"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 17;
            }
            column = gridView.Columns["Mota"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 18;
            }


            gridView.BestFitColumns();
        }



    }
}
