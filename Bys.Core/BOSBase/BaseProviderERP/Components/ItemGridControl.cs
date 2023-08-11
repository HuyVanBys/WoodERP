using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class ItemGridControl : BOSGridControl
    {
        /// <summary>
        /// A variable to store the serie column name
        /// </summary>
        private string SerieColumnName = string.Empty;
        private string LotColumnName = string.Empty;
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(GridView_FocusedColumnChanged);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "FK_ICStockID"
                    || e.Column.FieldName.Contains("IsSpecificCalculation"))
                {
                    BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                    ((BaseModuleERP)Screen.Module).InvalidateItemSerieNo(item, BOSDataSource, SerieColumnName);
                    ((BaseModuleERP)Screen.Module).InvalidateItemLotNo(item, BOSDataSource, LotColumnName);
                    gridView.RefreshData();
                }

                if (e.Column.FieldName.EndsWith("ProductSerialNo"))
                {
                    BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                    ((BaseModuleERP)Screen.Module).CheckValidateSerieNo(item, BOSDataSource, SerieColumnName);
                    this.RefreshDataSource();
                }
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (e.FocusedRowHandle < 0)
                return;
            BusinessObject item = (BusinessObject)gridView.GetRow(e.FocusedRowHandle);
            if (gridView.FocusedColumn != null && gridView.FocusedColumn.FieldName.Contains("ProductSerialNo"))
            {
                SerieColumnName = gridView.FocusedColumn.FieldName;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((BaseModuleERP)Screen.Module).InvalidateSerieColumn(gridView.FocusedColumn, item, BOSDataSource);
                }
                else
                {
                    GridColumn column = gridView.Columns[SerieColumnName];
                    if (column != null)
                    {
                        column.ColumnEdit = null;
                    }
                }
            }
            if (gridView.FocusedColumn != null && gridView.FocusedColumn.FieldName.EndsWith("LotNo"))
            {
                LotColumnName = gridView.FocusedColumn.FieldName;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((BaseModuleERP)Screen.Module).InvalidateLotColumn(gridView.FocusedColumn, item, BOSDataSource);
                }
                else
                {
                    GridColumn column = gridView.Columns[LotColumnName];
                    if (column != null)
                    {
                        column.ColumnEdit = null;
                    }
                }
            }
            ((BaseModuleERP)Screen.Module).InvalidateItemProductPicture(item);
        }

        protected virtual void GridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn != null && gridView.FocusedColumn.FieldName.Contains("ProductSerialNo"))
            {
                SerieColumnName = gridView.FocusedColumn.FieldName;
                if (gridView.FocusedRowHandle >= 0)
                {
                    BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                    ((BaseModuleERP)Screen.Module).InvalidateSerieColumn(gridView.FocusedColumn, item, BOSDataSource);
                }
            }
            else
            {
                GridColumn column = gridView.Columns[SerieColumnName];
                if (column != null)
                {
                    column.ColumnEdit = null;
                }
            }
            if (gridView.FocusedColumn != null && gridView.FocusedColumn.FieldName.EndsWith("LotNo"))
            {
                LotColumnName = gridView.FocusedColumn.FieldName;
                if (gridView.FocusedRowHandle >= 0)
                {
                    BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                    ((BaseModuleERP)Screen.Module).InvalidateLotColumn(gridView.FocusedColumn, item, BOSDataSource);
                }
            }
            else
            {
                GridColumn column = gridView.Columns[LotColumnName];
                if (column != null)
                {
                    column.ColumnEdit = null;
                }
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");

                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseModuleERP)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}
