using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Data;

namespace BOSERP.Modules.Report
{
    public partial class ICRP192ProductsGridControl : ICProductsGridControl
    {
        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            ICStocksController objStocksController = new ICStocksController();
            DataSet ds = objStocksController.GetAllDataByForeignColumn("FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            int stockCount = 0;
            if (ds.Tables.Count > 0)
            {
                stockCount = ds.Tables[0].Rows.Count;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
                    DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
                    col.FieldName = objStocksInfo.ICStockID.ToString();
                    col.Caption = objStocksInfo.ICStockName;
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "{0:n0}";
                    col.SummaryItem.FieldName = col.FieldName;
                    col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    col.SummaryItem.DisplayFormat = "{0:n0}";
                    gridView.Columns.Add(col);
                }
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                gridView.Columns[objStocksInfo.ICStockID.ToString()].VisibleIndex = i + 20;
                gridView.Columns[objStocksInfo.ICStockID.ToString()].BestFit();
            }

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICInventoryStockTotalQty;
            column.FieldName = "ICInventoryStockTotalQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
            gridView.Columns["ICInventoryStockTotalQty"].VisibleIndex = 20 + stockCount;
            InitColumnSummary("ICInventoryStockTotalQty", SummaryItemType.Sum);
        }
    }
}
