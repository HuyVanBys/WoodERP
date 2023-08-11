using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;

namespace BOSERP.Modules.Report
{
    public partial class RP013ICProductSeriesGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductSerieNo;
            column.FieldName = "ICProductSerieNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ICStockID"];
            if (column != null && column.ColumnEdit != null)
            {
                ICStocksController objStocksController = new ICStocksController();
                DataSet ds = objStocksController.GetAllObjects();
                if (ds.Tables.Count > 0)
                {
                    (column.ColumnEdit as RepositoryItemLookUpEdit).DataSource = ds.Tables[0];
                }
            }
            return gridView;
        }


    }
}
