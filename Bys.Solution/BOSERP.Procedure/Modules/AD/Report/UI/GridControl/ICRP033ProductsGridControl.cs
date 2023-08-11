using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;

namespace BOSERP.Modules.Report
{
    public partial class ICRP033ProductsGridControl : ICProductsGridControl
    {
        /// <summary>
        /// Add inventory columns to grid view
        /// </summary>
        /// <param name="stocks">Stock list</param>
        public void AddInventoryColumns(List<ICStocksInfo> stocks)
        {
            GridView gridView = (GridView)MainView;
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].Tag == "InventoryColumn")
                {
                    gridView.Columns.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < stocks.Count; i++)
            {
                ICStocksInfo objStocksInfo = stocks[i];
                GridColumn col = new GridColumn();
                col.FieldName = objStocksInfo.ICStockID.ToString();
                col.Caption = objStocksInfo.ICStockName;
                col.Tag = "InventoryColumn";
                col.OptionsColumn.AllowEdit = false;
                gridView.Columns.Add(col);
                gridView.Columns[objStocksInfo.ICStockID.ToString()].VisibleIndex = i + 20;
                gridView.Columns[objStocksInfo.ICStockID.ToString()].BestFit();
            }
        }
    }
}
