using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.DataExchange
{
    public partial class BRPostingHistorysGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DataExchangeEntities entity = (DataExchangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            this.DataSource = entity.BRPostingHistoryList;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["BRPostingHistoryDate"];
            if (column != null)
            {
                RepositoryItemDateEdit rep = new RepositoryItemDateEdit();
                rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                rep.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
                rep.Mask.UseMaskAsDisplayFormat = true;
                column.ColumnEdit = rep;
            }

            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["BRPostingHistoryDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }
    }
}
