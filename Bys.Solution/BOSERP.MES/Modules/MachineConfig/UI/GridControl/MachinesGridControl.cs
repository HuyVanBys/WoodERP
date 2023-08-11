using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.MachineConfig
{
    public partial class MachinesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineConfigEntities entity = (MachineConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMMachineUnitsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = false;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
            return gridView;
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                MMMachineUnitsInfo item = (MMMachineUnitsInfo)gridView.GetRow(e.FocusedRowHandle);
                ((MachineConfigModule)Screen.Module).MachineUnitID = item != null ? item.MMMachineUnitID : 0;
                ((MachineConfigModule)Screen.Module).InvalidateMachineOperation(item != null ? item.MMMachineUnitID : 0);
            }
        }
    }
}
