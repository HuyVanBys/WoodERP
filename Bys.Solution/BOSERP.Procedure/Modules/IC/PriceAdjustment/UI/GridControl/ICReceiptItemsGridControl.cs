using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceAdjustment
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PriceAdjustmentEntities entity = (PriceAdjustmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PriceAdjustmentList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            PriceAdjustmentEntities entity = (PriceAdjustmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.PriceAdjustmentList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptCDItemsInfo item = (ICReceiptCDItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);

                //if (e.Column.FieldName == "ICReceiptCDItemProductPerimeter" || e.Column.FieldName == "ICReceiptCDItemProductLength" || e.Column.FieldName == "ICReceiptCDItemProductQty")
                //{
                //    ((PriceAdjustmentModule)Screen.Module).ChangeItemSize(item);
                //}
                //else
                //{
                //    ((PriceAdjustmentModule)Screen.Module).ChangeItemSize(item);
                //    //((PriceAdjustmentModule)Screen.Module).ChangeItemFromPriceAdjustmentList();
                //}



            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((PriceAdjustmentModule)Screen.Module).DeleteItemFromPriceAdjustmentList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            //if (gridView.Columns["ICReceiptDCItemProductQty"] != null)
            //{
            //    gridView.Columns["ICReceiptDCItemProductQty"].OptionsColumn.AllowEdit = true;
            //    gridView.Columns["ICReceiptDCItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //    gridView.Columns["ICReceiptDCItemProductQty"].DisplayFormat.FormatString = "{0:n3}";
            //}

            //if (gridView.Columns["ICReceiptDCItemProductUnitCost"] != null)
            //    gridView.Columns["ICReceiptDCItemProductUnitCost"].OptionsColumn.AllowEdit = true;            

            //if (gridView.Columns["FK_ICStockID"] != null)
            //    gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["ICReceiptItemDCProductDesc"] != null)
            //    gridView.Columns["ICReceiptItemDCProductDesc"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["FK_ACAccountID"] != null)
            //    gridView.Columns["FK_ACAccountID"].OptionsColumn.AllowEdit = true;

            //GridColumn column = gridView.Columns["ICReceiptItemProductSerialNo"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}

            //gridView.OptionsView.ShowFooter = true;
            //InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);

            return gridView;
        }


        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
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
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}
