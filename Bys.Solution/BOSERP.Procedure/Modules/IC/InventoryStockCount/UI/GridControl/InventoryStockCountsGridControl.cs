using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.IC.InventoryStockCount.Localization;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStockCount
{
    public partial class InventoryStockCountsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            InventoryStockCountEntities entity = (InventoryStockCountEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InventoryStockCountItemsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            GridColumn column = gridView.Columns["ICInventoryStockCountItemQuantity"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["ICInventoryStockCountItemActualQuantity"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomDrawCell += new RowCellCustomDrawEventHandler(GridView_CustomDrawCell);

            column = gridView.Columns["ICInventoryStockActualUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICInventoryStockCountItemQuantityVariance"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICInventoryStockUnitCostAVG"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICInventoryStockCountItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            return gridView;
        }

        private void GridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            if (e.Column.FieldName == "ICInventoryStockCountItemQuantityVariance")
            {
                if (e.CellValue != null)
                {
                    if (e.CellValue.ToString() == "0")
                    {
                        e.DisplayText = "-";
                    }
                }
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((InventoryStockCountModule)Screen.Module).ShowInventoryLeadgerModule();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InventoryStockCountModule)Screen.Module).RemoveSelectedItemFromInventoryStockCountItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            InventoryStockCountEntities entity = (InventoryStockCountEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.InventoryStockCountItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.ICInventoryStockCountItemsTableName] = (ICInventoryStockCountItemsInfo)entity.InventoryStockCountItemsList[entity.InventoryStockCountItemsList.CurrentIndex].Clone();
                ((InventoryStockCountModule)Screen.Module).ChangeItemFromInventoryStockCountItemsList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ICProductNoOfOldSys";
            column.Caption = "Mã HT cũ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
