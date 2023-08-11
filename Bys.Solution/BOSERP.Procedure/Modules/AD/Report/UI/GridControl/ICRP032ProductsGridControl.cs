using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.Report
{
    public partial class ICRP032ProductsGridControl : ICProductsGridControl
    {
        List<ICStocksInfo> StockList { get; set; }
        public void AddInventoryColumns(List<ICStocksInfo> stockList)
        {
            StockList = stockList;
            GridView gridView = (GridView)MainView;
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].Tag == "InventoryColumn")
                {
                    gridView.Columns.RemoveAt(i);
                    i--;
                }
            }

            int stockCount = 0;
            if (StockList != null)
            {
                stockCount = StockList.Count;
                for (int i = 0; i < StockList.Count; i++)
                {
                    GridColumn col = new GridColumn();
                    ICStocksInfo objStocksInfo = StockList[i];
                    col.FieldName = objStocksInfo.ICStockID.ToString();
                    col.Caption = objStocksInfo.ICStockName;
                    col.Tag = "InventoryColumn";
                    FormatNumbericColumn(col, false, "n4");
                    gridView.Columns.Add(col);
                    gridView.Columns[objStocksInfo.ICStockID.ToString()].VisibleIndex = i + 20;
                    gridView.Columns[objStocksInfo.ICStockID.ToString()].BestFit();
                }
            }
        }

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)sender;
                ICProductsController objProductsController = new ICProductsController();
                DataRow row = gridView.GetDataRow(e.RowHandle);
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(row);
                if (StockList != null)
                {
                    foreach (ICStocksInfo objStocksInfo in StockList)
                    {
                        if (e.Column.FieldName == objStocksInfo.ICStockID.ToString())
                        {
                            if (!row[objStocksInfo.ICStockID.ToString()].Equals(string.Empty))
                            {
                                if (row[objStocksInfo.ICStockID.ToString()].Equals(DBNull.Value))
                                {
                                    row[objStocksInfo.ICStockID.ToString()] = 0;
                                }
                                decimal inventoryStockQty = Convert.ToDecimal(row[objStocksInfo.ICStockID.ToString()]);
                                int resultCompare = ((RP032)Screen).CompareInventoryStockQtyWithProductStockMinMax(objProductsInfo, inventoryStockQty);
                                if (resultCompare > 0)
                                    e.Appearance.BackColor = Color.Red;
                                if (resultCompare < 0)
                                    e.Appearance.BackColor = Color.LightGreen;
                            }
                        }
                    }
                }
            }
        }
    }
}
