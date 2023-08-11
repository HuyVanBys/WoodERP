using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStockCount
{
    public class ImportInventoryStockCountsGridControl : BOSGridControl
    {
        private List<ICStocksInfo> StockList { get; set; }

        public void InvalidateDataSource(List<IPInventoryStockCountsInfo> dataSource, List<ICStocksInfo> stockList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            StockList = stockList;
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPInventoryStockCountsInfo item = (IPInventoryStockCountsInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();
            BRBranchsInfo branchsInfo = new BRBranchsInfo();
            ICStocksInfo stocksInfo = new ICStocksInfo();
            objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == item.ProductNo).FirstOrDefault();
            if (objProductsInfo == null)
            {
                e.Appearance.BackColor = Color.Salmon;
            }
            else if (objProductsInfo.ICProductName != item.ProductName)
            {
                e.Appearance.BackColor = Color.Moccasin;
            }
            stocksInfo = StockList.Where(s => s.ICStockNo == item.StockNo).FirstOrDefault();
            if (stocksInfo == null)
            {
                e.Appearance.BackColor = Color.Yellow;
            }
            else if (stocksInfo.ICStockName != item.StockName)
            {
                e.Appearance.BackColor = Color.Yellow;
            }
        }
    }
}
