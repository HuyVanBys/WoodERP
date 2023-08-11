using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP
{
    public partial class ShowInventoryStockGridControl : BOSGridControl
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
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICStockName";
            column.Caption = "Kho";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lô";
            column.FieldName = "ICProductSerieLotNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieNo";
            column.Caption = "Mã kiện";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICProductSerieProductHeight";
            column.Caption = "Dày(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductWidth";
            column.Caption = "Rộng(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductWidthMax";
            column.Caption = "Rộng Max(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLength";
            column.Caption = "Dài(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLengthMax";
            column.Caption = "Dài Max(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductPerimeter";
            column.Caption = "Hoành(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockWoodQuantity";
            column.Caption = "Số lượng thanh(Tấm)";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 12;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);



            column = new GridColumn();
            column.FieldName = "ICInventoryStockQuantity";
            column.Caption = "Khối lượng tồn kho";
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



        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            //GridColumn column = gridView.Columns["FK_ICStockID"];
            //if (column != null)
            //{
            //    if (column.ColumnEdit != null)
            //    {
            //        ICStocksController objStocksController = new ICStocksController();
            //        DataSet ds = objStocksController.GetAllObjects();
            //        if (ds.Tables.Count > 0)
            //        {
            //            (column.ColumnEdit as RepositoryItemLookUpEdit).DataSource = ds.Tables[0];
            //        }
            //    }
            //}

            //gridView.GroupFormat = "[#image]{1}: {2}";
            //column = gridView.Columns["InventoryType"];
            //if (column != null)
            //{
            //    column.Group();
            //    GridGroupSummaryItem summaryItem = (GridGroupSummaryItem)gridView.GroupSummary.Add(
            //                                                        SummaryItemType.Sum, 
            //                                                        "ICInventoryStockQuantity");
            //    summaryItem.DisplayFormat = "{0:n0}";
            //}            

            return gridView;
        }
    }
}
