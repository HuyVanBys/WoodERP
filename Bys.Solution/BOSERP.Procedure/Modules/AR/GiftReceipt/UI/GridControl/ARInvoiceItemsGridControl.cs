using BOSCommon.Constants;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GiftReceipt
{
    public class ARInoviceItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            GiftReceiptEntities entity = (GiftReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = GiftReceiptLocalizedResources.InvoiceItemComponent;
            column.FieldName = "InvoiceItemComponent";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpChooseItemComponent = new RepositoryItemHyperLinkEdit();
            rpChooseItemComponent.NullText = InvoiceLocalizedResources.InvoiceItemComponentList;
            rpChooseItemComponent.Click += new EventHandler(RpChooseItemComponent_Click);
            column.ColumnEdit = rpChooseItemComponent;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            if (gridView.Columns["ARInvoiceItemProductQty"] != null)
                gridView.Columns["ARInvoiceItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARInvoiceItemProductUnitPrice"] != null)
                gridView.Columns["ARInvoiceItemProductUnitPrice"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ARInvoiceItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GiftReceiptEntities entity = (GiftReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.ARInvoiceItemsTableName] = (ARInvoiceItemsInfo)entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].Clone();
                (entity.Module as GiftReceiptModule).ChangeItemFromInvoiceItemList();

                if (e.Column.FieldName == "ARInvoiceItemProductQty")
                {
                    ((GiftReceiptModule)Screen.Module).ChangeComponentItemQty();
                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((GiftReceiptModule)Screen.Module).DeleteItemFromInvoiceItemList();
            }
        }

        private void RpChooseItemComponent_Click(object sender, EventArgs e)
        {
            ((GiftReceiptModule)Screen.Module).ShowItemComponent();
        }
    }
}
