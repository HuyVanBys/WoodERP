using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelSaleForecast
{
    public class ARCancelSaleForecastItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CancelSaleForecastItemList;
            this.DataSource = bds;
        }



        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ARCancelSaleForecastItemProductQty"] != null)
                gridView.Columns["ARCancelSaleForecastItemProductQty"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARCancelSaleForecastItemProductUnitPrice"] != null)
                gridView.Columns["ARCancelSaleForecastItemProductUnitPrice"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARCancelSaleForecastItemProductDiscount"] != null)
                gridView.Columns["ARCancelSaleForecastItemProductDiscount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARCancelSaleForecastItemProductTaxPercent"] != null)
                gridView.Columns["ARCancelSaleForecastItemProductTaxPercent"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["ARCancelSaleForecastItemTaxAmount"] != null)
                gridView.Columns["ARCancelSaleForecastItemTaxAmount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARCancelSaleForecastItemDiscountAmount"] != null)
                gridView.Columns["ARCancelSaleForecastItemDiscountAmount"].OptionsColumn.AllowEdit = false;

            GridColumn column = gridView.Columns["ARCancelSaleForecastItemTaxAmount"];


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
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.CancelSaleForecastItemList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.ARCancelSaleForecastItemsTableName] = (ARCancelSaleForecastItemsInfo)entity.CancelSaleForecastItemList[entity.CancelSaleForecastItemList.CurrentIndex];
                (entity.Module as CancelSaleForecastModule).ChangeItemFromCancelVoucherItemList();
            }
        }
        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "ARCancelSaleForecastItemProductQty")
                {
                    if (!((CancelSaleForecastModule)Screen.Module).IsValidCanceledQty(Convert.ToDecimal(e.Value)))
                    {
                        e.ErrorText = CancelVoucherLocalizedResources.CanceledQtyCannotBeGreaterThanOrderedQty;
                        e.Valid = false;
                    }
                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CancelSaleForecastModule)Screen.Module).DeleteItemFromCancelSaleForecastItemList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }
        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.CancelSaleForecastItemList.CurrentIndex >= 0)
            {
                ((CancelSaleForecastModule)Screen.Module).InitProductPictureImage(entity.CancelSaleForecastItemList[entity.CancelSaleForecastItemList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}