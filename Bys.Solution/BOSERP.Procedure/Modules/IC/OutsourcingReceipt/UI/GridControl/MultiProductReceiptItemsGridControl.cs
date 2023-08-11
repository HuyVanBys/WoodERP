using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt
{
    public class MultiProductReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MultiProductReceiptComponentItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICReceiptComponentItemPackageQty"] != null)
                gridView.Columns["ICReceiptComponentItemPackageQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["IsPackageGroup"] != null)
                gridView.Columns["IsPackageGroup"].OptionsColumn.AllowEdit = true;
            gridView.OptionsSelection.MultiSelect = true;
            MouseClick += new MouseEventHandler(ShowContextMenu);
            return gridView;
        }

        /// <summary>
        /// Show context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(PurchaseReceiptLocalizedResources.MoveToMultiPackage, new System.EventHandler(MultiPackage_Click));
                contextMenu.MenuItems.Add(PurchaseReceiptLocalizedResources.MoveToMultiPackageMultiProduct, new System.EventHandler(MultiPackageMultiProduct_Click));
                contextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));
            }
        }

        private void MultiPackage_Click(Object sender, System.EventArgs e)
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((OutsourcingReceiptModule)Screen.Module).TranferReceiptItemFromListToList(ReceiptItemType.MultiPackage.ToString(), entity.MultiProductReceiptComponentItemsList, entity.MultiPackageReceiptComponentItemsList);
        }

        private void MultiPackageMultiProduct_Click(Object sender, System.EventArgs e)
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((OutsourcingReceiptModule)Screen.Module).TranferReceiptItemFromListToList(ReceiptItemType.MultiPackageProduct.ToString(), entity.MultiProductReceiptComponentItemsList, entity.MultiReceiptComponentItemsList);
        }
    }
}
