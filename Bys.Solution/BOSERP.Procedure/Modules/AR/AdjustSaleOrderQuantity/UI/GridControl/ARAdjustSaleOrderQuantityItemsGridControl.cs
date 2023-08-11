using BOSCommon.Constants;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.AdjustSaleOrderQuantity
{
    public class ARAdjustSaleOrderQuantityItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AdjustSaleOrderQuantityItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            //if (gridView.Columns["ARAdjustSaleOrderQuantityItemProductUnitPrice"] != null)
            //    gridView.Columns["ARAdjustSaleOrderQuantityItemProductUnitPrice"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARAdjustSaleOrderQuantityItemProductQty"] != null)
                gridView.Columns["ARAdjustSaleOrderQuantityItemProductQty"].OptionsColumn.AllowEdit = true;
            return gridView;
        }

        //private void GridView_DoubleClick(object sender, EventArgs e)
        //{
        //    ShowInventory();
        //}

        ///// <summary>
        ///// Show inventory details of the current item
        ///// </summary>
        //private void ShowInventory()
        //{
        //    GridView gridView = (GridView)MainView;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
        //        BOSDbUtil dbUtil = new BOSDbUtil();
        //        int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
        //        string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
        //        String columnName = String.Empty;
        //        columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
        //        string desc = dbUtil.GetPropertyStringValue(item, columnName);
        //        /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
        //        int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
        //        int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
        //        /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
        //        ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID); 
        //    }
        //}
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.AdjustSaleOrderQuantityItemList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                entity.ModuleObjects[TableName.ARAdjustSaleOrderQuantityItemsTableName] = (ARAdjustSaleOrderQuantityItemsInfo)entity.AdjustSaleOrderQuantityItemList[entity.AdjustSaleOrderQuantityItemList.CurrentIndex];
                ARAdjustSaleOrderQuantityItemsInfo item = (ARAdjustSaleOrderQuantityItemsInfo)entity.AdjustSaleOrderQuantityItemList[entity.AdjustSaleOrderQuantityItemList.CurrentIndex];
                if (e.Column.FieldName == "ARAdjustSaleOrderQuantityItemProductQty")
                {
                    if (!((AdjustSaleOrderQuantityModule)Screen.Module).IsValidAdjustQty(item, decimal.Parse(e.Value.ToString())))
                    {
                        MessageBox.Show(string.Format(AdjustSaleOrderQuantityLocalizedResources.AdjustQtyCannotBeGreaterThanCancelQty), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        entity.AdjustSaleOrderQuantityItemList[entity.AdjustSaleOrderQuantityItemList.CurrentIndex].ARAdjustSaleOrderQuantityItemProductQty = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
                (entity.Module as AdjustSaleOrderQuantityModule).ChangeItemFromAdjustSaleOrderQuantityItemList();
            }
        }
        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            //GridView gridView = (GridView)sender;
            //if (gridView.FocusedRowHandle >= 0)
            //{
            //    if (gridView.FocusedColumn.FieldName == "ARCancelSaleForecastItemProductQty")
            //    {
            //        if (!((CancelSaleOrderQuantityModule)Screen.Module).IsValidCanceledQty(Convert.ToDouble(e.Value)))
            //        {
            //            e.ErrorText = CancelVoucherLocalizedResources.CanceledQtyCannotBeGreaterThanOrderedQty;
            //            e.Valid = false;
            //        }
            //    }
            //}
        }
        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((CancelSaleOrderQuantityModule)Screen.Module).DeleteItemFromCancelSaleOrderQuantityItemList();
        //    }
        //    else if (e.KeyCode == Keys.F1)
        //    {
        //        ShowInventory();
        //    }
        //}

    }
}