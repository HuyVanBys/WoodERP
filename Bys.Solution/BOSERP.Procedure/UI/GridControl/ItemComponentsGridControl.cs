using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using BOSCommon.Constants;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Localization;

namespace BOSERP
{
    public partial class ItemComponentsGridControl : ItemGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<ICProductComponentsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICProductComponentQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    int index = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
                    List<ICProductComponentsInfo> productComponents = (List<ICProductComponentsInfo>)((BindingSource)DataSource).DataSource;
                    productComponents.RemoveAt(index);
                    RefreshDataSource();
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ICProductDesc;
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ICProductSupplierNo;
            column.FieldName = "ICProductSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ICStockName;
            column.FieldName = "FK_ICStockID";

            RepositoryItemLookUpEdit repositoryStock = new RepositoryItemLookUpEdit();
            repositoryStock.DisplayMember = "ICStockName";
            repositoryStock.ValueMember = "ICStockID";
            repositoryStock.TextEditStyle = TextEditStyles.Standard;
            repositoryStock.SearchMode = SearchMode.AutoFilter;
            DataSet ds = BOSApp.LookupTables[TableName.ICStocksTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ICStocksTableName);
                BOSApp.LookupTables[TableName.ICStocksTableName] = ds;
            }
            repositoryStock.DataSource = ds.Tables[0];
            repositoryStock.NullText = string.Empty;
            repositoryStock.Columns.Add(new LookUpColumnInfo("ICStockNo", "Mã kho"));
            repositoryStock.Columns.Add(new LookUpColumnInfo("ICStockName", "Tên kho"));
            repositoryStock.QueryPopUp += new CancelEventHandler(repositoryStock_QueryPopUp);

            column.ColumnEdit = repositoryStock;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ICProductSerialNo;
            column.FieldName = "FK_ICProductSerieID";
            RepositoryItemLookUpEdit repositorySerieNo = new RepositoryItemLookUpEdit();
            repositorySerieNo.DisplayMember = "ICProductSerieNo";
            repositorySerieNo.ValueMember = "ICProductSerieID";
            repositorySerieNo.TextEditStyle = TextEditStyles.Standard;
            repositorySerieNo.SearchMode = SearchMode.AutoFilter;
            ds = BOSApp.LookupTables[TableName.ICProductSeriesTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ICProductSeriesTableName);
                BOSApp.LookupTables[TableName.ICProductSeriesTableName] = ds;
            }
            repositorySerieNo.DataSource = ds.Tables[0];
            repositorySerieNo.NullText = string.Empty;
            repositorySerieNo.Columns.Add(new LookUpColumnInfo("ICProductSerieNo", "Mã lô"));
            repositorySerieNo.QueryPopUp += new CancelEventHandler(repositorySerieNo_QueryPopUp);
            repositorySerieNo.CloseUp += new CloseUpEventHandler(repositorySerieNo_CloseUp);
            column.ColumnEdit = repositorySerieNo;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        private void repositorySerieNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = (GridView)this.MainView;
            ICProductComponentsInfo item = (ICProductComponentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            List<ICProductSeriesInfo> list = (new ICProductSeriesController()).GetSeriesByProductIDAndStockID(item.FK_ICProductID, item.FK_ICStockID, string.Empty, BOSApp.GetCurrentServerDate());
            lookUpEdit.Properties.DataSource = list;
        }

        private void repositorySerieNo_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            ICProductComponentsInfo item = (ICProductComponentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            item.ICProductSerialNo = objProductSeriesController.GetObjectNoByID(int.Parse(e.Value.ToString()));
        }

        private void repositoryStock_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables[TableName.ICStocksTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ICStocksTableName);
                BOSApp.LookupTables[TableName.ICStocksTableName] = ds;
            }
            lookUpEdit.Properties.DataSource = ds.Tables[0];
        }
    }
}
