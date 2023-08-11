using BOSComponent;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;

namespace BOSERP.Modules.ProductConversion
{
    public partial class ICProductSerialGridControl : BOSGridControl
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
            column.Caption = "Sản phẩm";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductDesc";
            column.Caption = "Mô tả";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Kho";
            column.FieldName = "ICStockName";
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
            return gridView;
        }
    }
}