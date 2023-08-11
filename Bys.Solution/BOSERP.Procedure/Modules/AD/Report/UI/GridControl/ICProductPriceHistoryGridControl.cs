using Localization;

namespace BOSERP.Modules.Report
{
    public partial class ICProductPriceHistoryGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ReportLocalizedResources.GEObjectHistoryDate;
            column.FieldName = "GEObjectHistoryDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ReportLocalizedResources.OldProductPrice;
            column.FieldName = "OldProductPrice";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ReportLocalizedResources.NewProductPrice;
            column.FieldName = "NewProductPrice";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ReportLocalizedResources.BRBranchName;
            column.FieldName = "BRBranchName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ReportLocalizedResources.GECurrencyName;
            column.FieldName = "GECurrencyName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

    }
}
