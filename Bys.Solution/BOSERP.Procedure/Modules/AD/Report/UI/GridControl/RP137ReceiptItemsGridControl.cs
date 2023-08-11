using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP137ReceiptItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICReceiptItemLotNo";
            column.Caption = ReportLocalizedResources.ICReceiptPackNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeValueRoundWood";
            column.Caption = ReportLocalizedResources.ProductAttributeWoodType;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLDauky";
            column.Caption = ReportLocalizedResources.SLDauky;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "KLDauky";
            column.Caption = ReportLocalizedResources.KLDauky;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Tongdaitondau";
            column.Caption = ReportLocalizedResources.Tongdaitondau;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemWoodQty";
            column.Caption = ReportLocalizedResources.ICReceiptItemWoodQty;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemProductQty";
            column.Caption = ReportLocalizedResources.ICReceiptItemProductQty2;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Tongdainhap";
            column.Caption = ReportLocalizedResources.Tongdainhap;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemWoodQty";
            column.Caption = ReportLocalizedResources.ICShipmentItemWoodQty;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemProductQty";
            column.Caption = ReportLocalizedResources.ICShipmentItemProductQty;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "Tongdaixuat";
            column.Caption = ReportLocalizedResources.Tongdaixuat;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLTonkho";
            column.Caption = ReportLocalizedResources.SLTonkho;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "KLTonkho";
            column.Caption = ReportLocalizedResources.KLTonkho;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Tongdaiton";
            column.Caption = ReportLocalizedResources.Tongdaiton;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemWoodQtyLumber";
            column.Caption = ReportLocalizedResources.ICReceiptItemWoodQtyLumber;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemProductQtyLumber";
            column.Caption = ReportLocalizedResources.ICReceiptItemProductQtyLumber;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Tilethuhoi";
            column.Caption = "Tỉ lệ thu hồi %";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

        }
        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //    GridColumn column = gridView.Columns["FK_ICMeasureUnitID"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = false;
        //        column.Visible = true;
        //        column.VisibleIndex = 5;
        //    }
        //    column = gridView.Columns["FK_ICProductID"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = false;
        //        column.Visible = true;
        //        column.VisibleIndex = 3;
        //    }
        //    column = gridView.Columns["MMAllocationProposalItemProductName"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = false;
        //        column.Visible = true;
        //        column.VisibleIndex = 4;
        //    }
        //    column = gridView.Columns["MMAllocationProposalItemQty"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = false;
        //        column.Visible = true;
        //        column.VisibleIndex = 6;
        //    }
        //    column = gridView.Columns["MMAllocationProposalItemComment"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = false;
        //        column.Visible = true;
        //        column.VisibleIndex = 12;
        //    }
        //    return gridView;
        //}
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


    }
}
