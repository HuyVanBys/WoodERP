using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP141BatchProductItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = ReportLocalizedResources.MMBatchProductNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductSerial";
            column.Caption = "Mã lô";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderNo";
            column.Caption = ReportLocalizedResources.ARSaleOrderNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeValueTTMT";
            column.Caption = "Tình trạng môi trường";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductType";
            column.Caption = "Loại sản xuất";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerContactAddressLine3";
            column.Caption = ReportLocalizedResources.ARCustomerContactAddressLine3;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductDate";
            column.Caption = "Ngày phát hành";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = ReportLocalizedResources.ICProductNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductName";
            column.Caption = "Tên Sản Phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductQty";
            column.Caption = "Số lượng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeValueWoodType";
            column.Caption = "Loại gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeValueHTType";
            column.Caption = "Hoàn thiện";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductToDate";
            column.Caption = "Ngày hoàn thành";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "BatchProductItemResourceType";
            column.Caption = "Nguồn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
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
            if (e.CellValue != null && (e.Column.FieldName == "MMBatchProductToDate" || e.Column.FieldName == "MMBatchProductDate"))
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
