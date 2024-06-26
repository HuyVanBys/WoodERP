using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralCostAllocation
{
    public class MMProductionCostGeneralCostAllocationDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            GeneralCostAllocationEntities entity = (GeneralCostAllocationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionCostGeneralCostAllocationDetailsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMProductionCostGeneralCostAllocationDetailAmount")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

        }




        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((GeneralCostAllocationModule)Screen.Module).DeleteItemFromGeneralCostAllocationDetailsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            ((GeneralCostAllocationModule)Screen.Module).ChangeToEdit();
            MMProductionCostGeneralCostAllocationDetailsInfo item = (MMProductionCostGeneralCostAllocationDetailsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "MMProductionCostGeneralCostAllocationDetailRateValue")
                {
                    ((GeneralCostAllocationModule)Screen.Module).ChangeItemRateValue();
                }
            }
        }

    }
}
