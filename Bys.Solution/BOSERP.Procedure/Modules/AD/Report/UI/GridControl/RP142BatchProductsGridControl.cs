using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP142BatchProductsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductActiveCheck";
            column.Caption = ReportLocalizedResources.Selected;
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
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
