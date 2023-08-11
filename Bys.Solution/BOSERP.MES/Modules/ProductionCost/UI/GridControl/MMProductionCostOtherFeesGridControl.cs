using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCost
{
    public class MMProductionCostOtherFeesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostEntities entity = (ProductionCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostOtherFeesList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            GridColumn column = new GridColumn();
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["MMProductionCostOtherFeeTotalAmount"];
            if (column != null)
            {

                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["MMProductionCostOtherFeeDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["MMProductionCostOtherFeeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

    }
}
