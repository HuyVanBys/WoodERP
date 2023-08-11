using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostFormula
{
    public class MMProductionCostFormulaOperationsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostFormulaEntities entity = (ProductionCostFormulaEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionCostFormulaOperationsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ((ProductionCostFormulaModule)Screen.Module).ChangeToEdit();

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionCostFormulaModule)Screen.Module).DeleteItemFromProductionCostFormulaOperationsList();
            }
        }

    }
}
