using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP019SaleDetailGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.DocumentNo;
            column.FieldName = "DocumentNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.DocumentDate;
            column.FieldName = "DocumentDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DocumentType";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.DocumentComment;
            column.FieldName = "DocumentComment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.SaleOrderNo;
            column.FieldName = "SaleOrderNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.SaleOrderDate;
            column.FieldName = "ARSaleOrderDateString";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.SellerName;
            column.FieldName = "SellerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.TotalAmount;
            column.FieldName = "TotalAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.GroupFormat = "[#image]{1}: {2}";
            GridColumn column = gridView.Columns["DocumentType"];
            if (column != null)
            {
                column.Group();
                GridGroupSummaryItem summaryItem = (GridGroupSummaryItem)gridView.GroupSummary.Add(SummaryItemType.Sum, "TotalAmount");
                summaryItem.DisplayFormat = "{0:n0}";
            }
            return gridView;
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            if (e.Column.FieldName == "SaleOrderDate")
            {
                if (Convert.ToDateTime(e.CellValue).Date == DateTime.MinValue.Date)
                {
                    e.DisplayText = string.Empty;
                }
            }
        }
    }
}
