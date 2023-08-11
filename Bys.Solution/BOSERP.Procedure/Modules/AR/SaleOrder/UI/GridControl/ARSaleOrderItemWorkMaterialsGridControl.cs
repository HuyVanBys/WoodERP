using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemWorkMaterialsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderItemWorkMaterialList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ARSaleOrderItemWorkProductQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductChargeCheck"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductChargeCheck"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductNo"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductNo"].Caption = "Mã vật tư";
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductName"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductName"].Caption = "Tên vật tư";
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemSaleOrderItemWorkMaterialtemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARSaleOrderItemWorkMaterialList.CurrentIndex >= 0)
            {
                ARSaleOrderItemWorksInfo item = entity.ARSaleOrderItemWorkMaterialList[entity.ARSaleOrderItemWorkMaterialList.CurrentIndex];
                if (e.Column.FieldName == "ARSaleOrderItemWorkProductQty")
                {
                    ((SaleOrderModule)Screen.Module).ChangeQty(item);
                }
                else if (e.Column.FieldName == "ARSaleOrderItemWorkProductChargeCheck")
                {
                    ((SaleOrderModule)Screen.Module).ChangeChargeCheck(item);
                }
                if (e.Column.FieldName == "ARSaleOrderItemWorkProductUnitPrice")
                {
                    ((SaleOrderModule)Screen.Module).ChangeQty(item);
                }
            }
        }
    }
}
