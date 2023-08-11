using BOSCommon.Constants;
using System.Windows.Forms;

namespace BOSERP.Modules.LayBy
{
    public partial class ARLayByItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LayByEntities entity = (LayByEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ARSaleOrderItemProductQty"] != null)
                gridView.Columns["ARSaleOrderItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleOrderItemProductUnitPrice"] != null)
                gridView.Columns["ARSaleOrderItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            LayByEntities entity = (LayByEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARSaleOrderItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.ARSaleOrderItemsTableName] = (ARSaleOrderItemsInfo)entity.ARSaleOrderItemsList[entity.ARSaleOrderItemsList.CurrentIndex].Clone();
                (entity.Module as LayByModule).ChangeItemFromSaleOrderItemsList();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((LayByModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            }
        }
    }
}
