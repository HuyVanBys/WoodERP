using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.InventoryAdjustment
{
    public partial class ICAdjustmentItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICAdjustmentItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = InventoryAdjustmentLocalizedResources.ICAdjustmentItemProductDiffQty;
            column.FieldName = "ICAdjustmentItemProductDiffQty";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICAdjustmentItemProductQty"] != null)
                gridView.Columns["ICAdjustmentItemProductQty"].OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ICAdjustmentItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[InventoryAdjustmentEntities.strICAdjustmentItemsObjectName] = (ICAdjustmentItemsInfo)entity.ICAdjustmentItemsList[entity.ICAdjustmentItemsList.CurrentIndex].Clone();
                (entity.Module as InventoryAdjustmentModule).ChangeItemFromAdjustmentItemsList();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InventoryAdjustmentModule)Screen.Module).DeleteItemFromAdjustmentItemsList();
            }
        }
    }
}
