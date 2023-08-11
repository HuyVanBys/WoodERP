using BOSCommon;
using BOSComponent;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class ICRP013ProductsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.GroupFormat = "[#image]{1} {2}";
            GridColumn column = gridView.Columns["FK_ICDepartmentID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["FK_ICProductGroupID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected virtual void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.FocusedRowHandle < 0)
                return;
            DataRowView dataRowViewProductsInfo = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(dataRowViewProductsInfo.Row);
            ((RP013)Screen).InvalidateItemProductPicture(objProductsInfo);
        }

        /// <summary>
        /// Add extra inventory columns to grid view
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
            int stockSaleOrder = stocks.Where(o => o.ICStockType == StockType.SaleOrder.ToString()).Count();


            int stockCount = 0;
            stockCount = stocks.Count;
            for (int i = 0; i < stocks.Count; i++)
            {
                DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
                ICStocksInfo objStocksInfo = stocks[i];
                col.FieldName = objStocksInfo.ICStockID.ToString();
                col.Caption = objStocksInfo.ICStockName;
                col.OptionsColumn.AllowEdit = false;
                col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                col.DisplayFormat.FormatString = "{0:n4}";
                col.SummaryItem.FieldName = col.FieldName;
                col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                col.SummaryItem.DisplayFormat = "{0:n4}";
                col.Tag = "InventoryColumn";
                gridView.Columns.Add(col);
                gridView.Columns[objStocksInfo.ICStockID.ToString()].VisibleIndex = i + 20;
                gridView.Columns[objStocksInfo.ICStockID.ToString()].BestFit();
            }
            GridColumn column = new GridColumn();
            if (stockSaleOrder == 0)
            {
                column.Caption = ReportLocalizedResources.ICInventoryStockTotalQty;
                column.FieldName = "ICInventoryStockTotalQty";
                column.OptionsColumn.AllowEdit = false;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
                column.Tag = "InventoryColumn";
                gridView.Columns.Add(column);
                gridView.Columns["ICInventoryStockTotalQty"].VisibleIndex = 20 + stockCount;
                InitColumnSummary("ICInventoryStockTotalQty", SummaryItemType.Sum);
            }
            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ProductLockedPurchaseOrderStatus;
            column.FieldName = "ICProductLockedPurchaseOrderStatus";
            column.OptionsColumn.AllowEdit = false;
            column.Tag = "InventoryColumn";
            gridView.Columns.Add(column);
            gridView.Columns["ICProductLockedPurchaseOrderStatus"].VisibleIndex = 21 + stockCount;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICDepartmentName;
            column.FieldName = "ICDepartmentName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductGroupName;
            column.FieldName = "ICProductGroupName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void RepositoryItemHyperLinkEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                DataRowView dataRowViewProductsInfo = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
                ICProductsController objProductsController = new ICProductsController();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(dataRowViewProductsInfo.Row);
                objProductsInfo.ICStockID = Convert.ToInt32(gridView.FocusedColumn.FieldName);
                ((RP013)Screen).ShowProductSeries(objProductsInfo);
            }
        }
    }
}