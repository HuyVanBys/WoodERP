using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public class MultiReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MultiReceiptComponentItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["IsPackageGroup"] != null)
                gridView.Columns["IsPackageGroup"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICReceiptComponentItemPackageQty"] != null)
                gridView.Columns["ICReceiptComponentItemPackageQty"].OptionsColumn.AllowEdit = true;
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
                contextMenu.MenuItems.Add(PurchaseReceiptLocalizedResources.MoveToMultiProduct, new System.EventHandler(MultiProduct_Click));
                contextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));
            }
        }

        private void MultiPackage_Click(Object sender, System.EventArgs e)
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((PurchaseReceiptModule)Screen.Module).TranferReceiptItemFromListToList(ReceiptItemType.MultiPackage.ToString(), entity.MultiReceiptComponentItemsList, entity.MultiPackageReceiptComponentItemsList);
        }

        private void MultiProduct_Click(Object sender, System.EventArgs e)
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((PurchaseReceiptModule)Screen.Module).TranferReceiptItemFromListToList(ReceiptItemType.MultiProduct.ToString(), entity.MultiReceiptComponentItemsList, entity.MultiProductReceiptComponentItemsList);
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.ICPackageSupplierNo;
            column.FieldName = "ICPackageSupplierNo";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit reposIdentifyPackageSupplierNo = new RepositoryItemHyperLinkEdit();
            reposIdentifyPackageSupplierNo.NullText = PurchaseReceiptLocalizedResources.IdentifyPackageSupplierNo;
            reposIdentifyPackageSupplierNo.Click += new EventHandler(ReposIdentifyPackageSupplierNo_Click);
            column.ColumnEdit = reposIdentifyPackageSupplierNo;
            gridView.Columns.Add(column);
        }

        private void ReposIdentifyPackageSupplierNo_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICReceiptComponentItemsInfo objReceiptComponentItemsInfo = (ICReceiptComponentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ((PurchaseReceiptModule)Screen.Module).IdentifyPackageSupplierNo(objReceiptComponentItemsInfo, entity.MultiReceiptComponentItemsList);
            }
        }
    }
}
