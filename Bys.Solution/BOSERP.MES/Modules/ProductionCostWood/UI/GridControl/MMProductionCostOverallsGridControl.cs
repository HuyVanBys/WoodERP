using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.ProductionCostWood
{
    public class MMProductionCostOverallsGridControl : BOSGridControl
    {

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.OptionsView.ShowFooter = true;
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã xuất kho";
            column.FieldName = "MMOverallProductionCostShipmentNo";
            column.Group();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Ghi chú xuất kho";
            column.FieldName = "MMOverallProductionCostShipmentDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Ngày xuất kho";
            column.FieldName = "MMOverallProductionCostShipmentDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã lô hàng";
            column.FieldName = "MMOverallProductionCostProductSerialNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mô tả";
            column.FieldName = "MMOverallProductionCostProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Đơn giá";
            column.FieldName = "MMOverallProductionCostProductUnitPrice";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Ghi chú";
            column.FieldName = "MMOverallProductionCostShipmentItemComment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "MMOverallProductionCostProductQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Thành tiền";
            column.FieldName = "MMOverallProductionCostShipmentItemTotalAmount";
            column.OptionsColumn.AllowEdit = false;

            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:N2}";

            gridView.Columns.Add(column);
            GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
            summaryItem.FieldName = "MMOverallProductionCostShipmentItemTotalAmount";
            summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            summaryItem.DisplayFormat = "{0:N2}";
            summaryItem.ShowInGroupColumnFooter = column;
            gridView.GroupSummary.Add(summaryItem);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã NCC";
            column.FieldName = "MMOverallProductionCostProductSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Kho";
            column.FieldName = "FK_ICStockID";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "ĐVT";
            column.FieldName = "FK_ICMeasureUnitID";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMOverallProductionCostBatchComponent")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
                    ADMatchCodesInfo objMatchCodesInfo = (ADMatchCodesInfo)objMatchCodesController.GetObjectByID(matchCodeID);
                    if (objMatchCodesInfo != null)
                        e.DisplayText = objMatchCodesInfo.ADMatchCodeValue;
                }
                else
                {
                    e.DisplayText = "";
                }
            }
            if (e.Column.FieldName == "FK_ICStockID")
            {
                if (e.Value != null)
                {
                    int StocksID = int.Parse(e.Value.ToString());
                    ICStocksController objStocksController = new ICStocksController();
                    ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(StocksID);
                    if (objStocksInfo != null)
                        e.DisplayText = objStocksInfo.ICStockName;
                }
                else
                {
                    e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    int MeasureUnitsID = int.Parse(e.Value.ToString());
                    ICMeasureUnitsController objMeasureUnitssController = new ICMeasureUnitsController();
                    ICMeasureUnitsInfo objMeasureUnitssInfo = (ICMeasureUnitsInfo)objMeasureUnitssController.GetObjectByID(MeasureUnitsID);
                    if (objMeasureUnitssInfo != null)
                        e.DisplayText = objMeasureUnitssInfo.ICMeasureUnitName;
                }
                else
                {
                    e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int ProductID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(ProductID);
                    if (objProductsInfo != null)
                        e.DisplayText = objProductsInfo.ICStockName;
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}
