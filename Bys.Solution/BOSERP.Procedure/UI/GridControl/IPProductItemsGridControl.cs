using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class IPProductItemsGridControl : BOSGridControl
    {
        private List<ICMeasureUnitsInfo> ListMeasureUnitsInfo { get; set; }
        private List<ICStocksInfo> ListStocksInfo { get; set; }
        private List<ICProductSeriesInfo> ListProductSeriesInfo { get; set; }
        private bool IsShipment { get; set; }

        public void InvalidateDataSource(List<IPProductsInfo> dataSource, bool isShipment)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            IsShipment = isShipment;
            RefreshDataSource();

            ListMeasureUnitsInfo = new List<ICMeasureUnitsInfo>();
            if (BOSApp.LookupTables.Contains("ICMeasureUnits"))
            {
                ListMeasureUnitsInfo = (List<ICMeasureUnitsInfo>)(new ICMeasureUnitsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICMeasureUnits"]);
            }
            else
            {
                ListMeasureUnitsInfo = (new ICMeasureUnitsController()).GetAllAliveMeasureUnit();
            }

            ListStocksInfo = new List<ICStocksInfo>();
            if (BOSApp.LookupTables.Contains("ICStocks"))
            {
                ListStocksInfo = (List<ICStocksInfo>)(new ICStocksController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICStocks"]);
            }
            else
            {
                ListStocksInfo = (new ICStocksController()).GetListRealStock();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            foreach(GridColumn col in gridview.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                //if(col.Name == "IPMeasureUnitName")
                //{
                //    col.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemTextEdit.ToString());
                //}    
            }    
            return gridview;
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPProductsInfo itemImport = (IPProductsInfo)gridView.GetRow(e.RowHandle);
            if (itemImport == null)
                return;
            DateTime shipmentDate = BOSApp.GetCurrentServerDate();
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductNo.Trim() == itemImport.IPProductNo.Trim()).FirstOrDefault();
            itemImport.FK_ICProductID = objProductsInfo != null ? objProductsInfo.ICProductID : 0;
            if (objProductsInfo == null)
            {
                e.Appearance.BackColor = Color.PeachPuff;
            }
            else if (objProductsInfo.ICProductName.Trim() != itemImport.IPProductName.Trim() && !string.IsNullOrWhiteSpace(itemImport.IPProductName))
            {
                e.Appearance.BackColor = Color.LightYellow;
            }
            else if (objProductsInfo.ICProductNoOfOldSys.Trim() != itemImport.IPProductNoOfOldSys.Trim() && !string.IsNullOrWhiteSpace(itemImport.IPProductNoOfOldSys))
            {
                e.Appearance.BackColor = Color.Gainsboro;
            }

            if (!string.IsNullOrWhiteSpace(itemImport.IPMeasureUnitName))
            {
                ICMeasureUnitsInfo objMeasureUnitsInfo = ListMeasureUnitsInfo.Where(f => f.ICMeasureUnitName.Trim() == itemImport.IPMeasureUnitName.Trim()).FirstOrDefault();
                if (objMeasureUnitsInfo == null && !string.IsNullOrWhiteSpace(itemImport.IPMeasureUnitName))
                {
                    e.Appearance.BackColor = Color.PaleTurquoise;
                }
                List<ICMeasureUnitsInfo> listProductMeasureUnit = (List<ICMeasureUnitsInfo>)(new ICMeasureUnitsController()).GetListFromDataSet((new ICMeasureUnitsController()).GetMeasureUnitByProductID(itemImport.FK_ICProductID));
                ICMeasureUnitsInfo objProductMeasureUnitsInfo = listProductMeasureUnit.Where(f => f.ICMeasureUnitName.Trim() == itemImport.IPMeasureUnitName.Trim()).FirstOrDefault();
                if (objProductMeasureUnitsInfo == null)
                {
                    e.Appearance.BackColor = Color.PaleTurquoise;
                }
            }

            if (!string.IsNullOrWhiteSpace(itemImport.IPStockNo))
            {
                ICStocksInfo objStocksInfo = ListStocksInfo.Where(f => f.ICStockNo.Trim() == itemImport.IPStockNo.Trim()).FirstOrDefault();
                if (objStocksInfo == null)
                {
                    objStocksInfo = ListStocksInfo.Where(f => f.ICStockName.Trim() == itemImport.IPStockNo.Trim()).FirstOrDefault();
                }
                if (objStocksInfo == null)
                {
                    e.Appearance.BackColor = Color.Tomato;
                }
                itemImport.FK_ICStockID = objStocksInfo != null ? objStocksInfo.ICStockID : 0;
            }

            if(IsShipment && !string.IsNullOrWhiteSpace(itemImport.IPProductSerieNo))
            {
                ListProductSeriesInfo = (new ICProductSeriesController()).GetSeriesByProductIDAndStockID(itemImport.FK_ICProductID, itemImport.FK_ICStockID, null, shipmentDate);
                ICProductSeriesInfo objProductSeriesInfo = ListProductSeriesInfo.Where(f => f.ICProductSerieNo.Trim().ToUpper() == itemImport.IPProductSerieNo.Trim().ToUpper()).FirstOrDefault();
                if (objProductSeriesInfo == null)
                {
                    e.Appearance.BackColor = Color.DarkKhaki;
                }
            }
        }
    }
}
