using DevExpress.XtraEditors.Repository;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ICProductWorkItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductWorkItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductWorkItemProductNo;
            column.FieldName = "ICProductWorkItemProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductWorkItemProductName;
            column.FieldName = "ICProductWorkItemProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductWorkItemProductDesc;
            column.FieldName = "ICProductWorkItemProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductWorkItemComponent;
            column.FieldName = "ICProductWorkItemComponent";
            column.OptionsColumn.AllowEdit = true;
            column.MinWidth = 100;
            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = ProductLocalizedResources.ICProductWorkItemComponent;
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductWorkItemQty"] != null)
            {
                gridView.Columns["ICProductWorkItemQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductWorkItemDesc"] != null)
            {
                gridView.Columns["ICProductWorkItemDesc"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductWorkItemProductChargeCheck"] != null)
            {
                gridView.Columns["ICProductWorkItemProductChargeCheck"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).DeleteItemFromProductWorkItemList();
            }
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((ProductModule)Screen.Module).ShowWorkItemComponent();
        }
    }
}
