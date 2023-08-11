﻿using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.ConversionProposal
{
    public partial class ICProductSeriesGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã HT cũ";
            column.FieldName = "ICProductNoOfOldSys";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn vị tính";
            column.FieldName = "FK_ICMeasureUnitID";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICStockName";
            column.Caption = "Kho";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lô";
            column.FieldName = "ICProductSerieLotNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieNo";
            column.Caption = "Mã kiện";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductHeight";
            column.Caption = "Dày(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductWidth";
            column.Caption = "Rộng(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLength";
            column.Caption = "Dài(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockQuantity";
            column.Caption = "Số lượng/ Khối lượng";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);
            column = new GridColumn();
            column.FieldName = "ICInventoryStockCumulative";
            column.Caption = "Tồn lũy kế";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockWoodQuantity";
            column.Caption = "Số thanh tấm";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductDesc";
            column.Caption = "Mô tả";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieContainerNo";
            column.Caption = "Mã Container";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = "Nhà cung cấp";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lệnh sản xuất";
            column.FieldName = "FK_MMBatchProductID";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICModelDetailID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", int.Parse(e.Value.ToString()), "ICMeasureUnitName");
                }
            }
            else if (e.Column.FieldName == "FK_MMBatchProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMBatchProducts", "MMBatchProductID", int.Parse(e.Value.ToString()), "MMBatchProductNo");
                }
            }
        }
    }
}