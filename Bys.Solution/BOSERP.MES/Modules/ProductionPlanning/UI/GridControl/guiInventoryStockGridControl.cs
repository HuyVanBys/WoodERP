using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;

namespace BOSERP.Modules.ProductionPlanning
{
    public class guiInventoryStockGridControl : BOSGridControl
    {
        public List<ICStocksInfo> StockList { get; set; }
        public void AddInventoryColumns()
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
            GridColumn collumn = new GridColumn();
            collumn.FieldName = "SLCoTheSuDung";
            collumn.Caption = "Số lượng có thể sử dụng";
            collumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            collumn.DisplayFormat.FormatString = "n2";
            collumn.Tag = "InventoryColumn";
            collumn.OptionsColumn.AllowEdit = false;
            collumn.Visible = true;
            gridView.Columns.Add(collumn);

            collumn = new GridColumn();
            collumn.FieldName = "TonKhoThucTe";
            collumn.Caption = "Tồn kho thực tế";
            collumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            collumn.DisplayFormat.FormatString = "n2";
            collumn.Tag = "InventoryColumn";
            collumn.OptionsColumn.AllowEdit = false;
            collumn.Visible = true;
            gridView.Columns.Add(collumn);

            collumn = new GridColumn();
            collumn.FieldName = "SoLuongDaDatMua";
            collumn.Caption = "Số lượng đã đặt mua";
            collumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            collumn.DisplayFormat.FormatString = "n2";
            collumn.Tag = "InventoryColumn";
            collumn.OptionsColumn.AllowEdit = false;
            collumn.Visible = true;
            gridView.Columns.Add(collumn);

            collumn = new GridColumn();
            collumn.FieldName = "SoLuongKeHoach";
            collumn.Caption = "Số lượng kế hoạch";
            collumn.Tag = "InventoryColumn";
            collumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            collumn.DisplayFormat.FormatString = "n2";
            collumn.OptionsColumn.AllowEdit = false;
            collumn.Visible = true;
            gridView.Columns.Add(collumn);

            gridView.Columns["SLCoTheSuDung"].VisibleIndex = 8;
            gridView.Columns["TonKhoThucTe"].VisibleIndex = 9;
            gridView.Columns["SoLuongDaDatMua"].VisibleIndex = 10;
            gridView.Columns["SoLuongKeHoach"].VisibleIndex = 11;

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
                    col.OptionsColumn.AllowEdit = false;
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "n2";
                    gridView.Columns.Add(col);
                    gridView.Columns[objStocksInfo.ICStockID.ToString()].VisibleIndex = i + 12;
                    gridView.Columns[objStocksInfo.ICStockID.ToString()].BestFit();
                }
            }
            gridView.BestFitColumns();
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn column in gridView.Columns)
                column.Visible = false;

            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 1;

            }
            if (gridView.Columns["ICProductName"] != null)
            {
                gridView.Columns["ICProductName"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductName"].Visible = true;
                gridView.Columns["ICProductName"].VisibleIndex = 2;

            }
            if (gridView.Columns["ICProductDesc"] != null)
            {
                gridView.Columns["ICProductDesc"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductDesc"].Visible = true;
                gridView.Columns["ICProductDesc"].VisibleIndex = 3;

            }
            if (gridView.Columns["FK_ICDepartmentID"] != null)
            {
                gridView.Columns["FK_ICDepartmentID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_ICDepartmentID"].Visible = true;
                gridView.Columns["FK_ICDepartmentID"].VisibleIndex = 4;
            }
            if (gridView.Columns["FK_ICProductGroupID"] != null)
            {
                gridView.Columns["FK_ICProductGroupID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_ICProductGroupID"].Visible = true;
                gridView.Columns["FK_ICProductGroupID"].VisibleIndex = 5;
            }
            if (gridView.Columns["ICProductStockMax"] != null)
            {
                gridView.Columns["ICProductStockMax"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductStockMax"].Visible = true;
                gridView.Columns["ICProductStockMax"].VisibleIndex = 6;
            }
            if (gridView.Columns["ICProductStockMin"] != null)
            {
                gridView.Columns["ICProductStockMin"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductStockMin"].Visible = true;
                gridView.Columns["ICProductStockMin"].VisibleIndex = 7;
            }
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

        }

    }
}
