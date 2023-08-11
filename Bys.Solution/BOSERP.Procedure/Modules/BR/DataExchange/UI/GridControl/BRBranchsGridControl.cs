using Localization;

namespace BOSERP.Modules.DataExchange
{
    public partial class BRBranchsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DataExchangeEntities entity = (DataExchangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            this.DataSource = entity.BRBranchsList;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.FieldName = "Selected";
            column.Caption = DataExchangeLocalizedResources.AASelected;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.FieldName = "BRBranchTransferMessage";
            column.Caption = DataExchangeLocalizedResources.BRBranchTransferMessage;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
