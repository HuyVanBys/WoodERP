using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public class APInvoiceInPackageItemsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceInPackageItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column1 = new DevExpress.XtraGrid.Columns.GridColumn();
            column1.Caption = "Thêm chi tiết";
            column1.FieldName = "APProductPackageItemComponent";
            column1.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Thêm chi tiết";
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column1.ColumnEdit = rpItemComponent;

            gridView.Columns.Add(column1);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceInModule)Screen.Module).DeleteItemInvoiceInPackageItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                APInvoiceInPackageItemsInfo objInvoiceInPackageItemsInfo = (APInvoiceInPackageItemsInfo)gridView.GetRow(e.RowHandle);
                if (objInvoiceInPackageItemsInfo != null)
                {
                    if (e.Column.FieldName == "APInvoiceInPackageItemQty")
                    {
                        ((InvoiceInModule)Screen.Module).UpdateItemDetailShowListQty(entity.InvoiceInPackageItemList[entity.InvoiceInPackageItemList.CurrentIndex].APInvoiceInPackageItemQty);
                    }
                }
            }
            ((InvoiceInModule)Screen.Module).SetDefaultInvoiceInPackageItemList();
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((InvoiceInModule)Screen.Module).AddProductPackageItemDetails();
        }
    }
}
