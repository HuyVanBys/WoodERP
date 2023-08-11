using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP145ICReceiptCDItemDetailGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Dày ván tươi";
            column.FieldName = "ICReceiptCDItemHeightLumber";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.Quality;
            column.FieldName = "Quality";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDetailBlocks;
            column.FieldName = "ICReceiptCDItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tỷ lệ cấp chất lượng(%)";
            column.FieldName = "ProductQuality";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);
        }

    }
}
