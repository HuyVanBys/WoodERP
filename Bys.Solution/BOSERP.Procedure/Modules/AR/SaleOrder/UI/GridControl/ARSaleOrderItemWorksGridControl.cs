using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemWorksGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderItemWorkList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = SaleOrderLocalizedResources.ARSaleOrderItemWorkComponentCaption;
            //column.FieldName = "ARSaleOrderItemWorkComponent";
            //column.OptionsColumn.AllowEdit = true;
            //column.MinWidth = 100;
            //RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            //rpItemComponent.NullText = SaleOrderLocalizedResources.ARSaleOrderItemWorkComponentCaption;
            //rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            //column.ColumnEdit = rpItemComponent;
            //gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ARSaleOrderItemWorkProductQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARSaleOrderItemWorkProductChargeCheck"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductChargeCheck"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARSaleOrderItemWorkComment"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkComment"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"].OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARSaleOrderItemWorkList.CurrentIndex >= 0)
            {
                ARSaleOrderItemWorksInfo item = entity.ARSaleOrderItemWorkList[entity.ARSaleOrderItemWorkList.CurrentIndex];
                if (e.Column.FieldName == "ARSaleOrderItemWorkProductQty")
                {
                    ((SaleOrderModule)Screen.Module).ChangeQty(item);
                }
                else if (e.Column.FieldName == "ARSaleOrderItemWorkProductChargeCheck")
                {
                    ((SaleOrderModule)Screen.Module).ChangeChargeCheck(item);
                }
                else if (e.Column.FieldName == "ARSaleOrderItemWorkProductUnitPrice")
                {
                    ((SaleOrderModule)Screen.Module).ChangeQty(item);
                }
            }
        }

        //private void RpItemComponent_Click(object sender, EventArgs e)
        //{
        //((SaleOrderModule)Screen.Module).ShowWorkItemComponent();
        //}

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemWorksList();
            }
        }
    }
}
