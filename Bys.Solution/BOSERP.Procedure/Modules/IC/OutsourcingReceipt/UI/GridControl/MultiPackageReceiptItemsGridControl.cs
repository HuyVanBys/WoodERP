using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt
{
    public class MultiPackageReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MultiPackageReceiptComponentItemsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICReceiptComponentItemPackageQty"] != null)
                gridView.Columns["ICReceiptComponentItemPackageQty"].OptionsColumn.AllowEdit = true;
            gridView.OptionsSelection.MultiSelect = true;
            MouseClick += new MouseEventHandler(ShowContextMenu);
            return gridView;
        }

        private void ShowContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(PurchaseReceiptLocalizedResources.MoveToMultiProduct, new System.EventHandler(MultiProduct_Click));
                contextMenu.MenuItems.Add(PurchaseReceiptLocalizedResources.MoveToMultiPackageMultiProduct, new System.EventHandler(MultiPackageMultiProduct_Click));
                contextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));
            }
        }

        private void MultiProduct_Click(Object sender, System.EventArgs e)
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((OutsourcingReceiptModule)Screen.Module).TranferReceiptItemFromListToList(ReceiptItemType.MultiProduct.ToString(), entity.MultiPackageReceiptComponentItemsList, entity.MultiProductReceiptComponentItemsList);
        }

        private void MultiPackageMultiProduct_Click(Object sender, System.EventArgs e)
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((OutsourcingReceiptModule)Screen.Module).TranferReceiptItemFromListToList(ReceiptItemType.MultiPackageProduct.ToString(), entity.MultiPackageReceiptComponentItemsList, entity.MultiReceiptComponentItemsList);
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
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
                OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ((OutsourcingReceiptModule)Screen.Module).IdentifyPackageSupplierNo(objReceiptComponentItemsInfo, entity.MultiPackageReceiptComponentItemsList);
            }
        }
    }
}
