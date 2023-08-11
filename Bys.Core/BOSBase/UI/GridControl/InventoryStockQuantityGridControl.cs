using BOSComponent;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;

namespace BOSERP
{
    public partial class InventoryStockQuantityGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.BRBranchName;
            column.FieldName = "BRBranchName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "InventoryType";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieNo";
            column.Caption = CommonLocalizedResources.SerialNoText;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieLotNo";
            column.Caption = CommonLocalizedResources.LotNoText;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductLockedPurchaseOrderStatus";
            column.Caption = BaseLocalizedResources.ProductLockedPurchaseOrderStatus;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockPOAvailableQuantity";
            column.Caption = BaseLocalizedResources.InventoryStockPOAvailableQuantity;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n4";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                if (column.ColumnEdit != null)
                {
                    ICStocksController objStocksController = new ICStocksController();
                    DataSet ds = objStocksController.GetAllObjects();
                    if (ds.Tables.Count > 0)
                    {
                        (column.ColumnEdit as RepositoryItemLookUpEdit).DataSource = ds.Tables[0];
                    }
                }
            }

            gridView.GroupFormat = "[#image]{1}: {2}";
            column = gridView.Columns["InventoryType"];
            if (column != null)
            {
                column.Group();
                if (gridView.GroupSummary == null || gridView.GroupSummary.Count == 0)
                {
                    GridGroupSummaryItem summaryItem = (GridGroupSummaryItem)gridView.GroupSummary.Add(
                                                    SummaryItemType.Sum,
                                                    "ICInventoryStockQuantity");
                    summaryItem.DisplayFormat = "{0:n4}";
                }
            }
            return gridView;
        }
    }
}