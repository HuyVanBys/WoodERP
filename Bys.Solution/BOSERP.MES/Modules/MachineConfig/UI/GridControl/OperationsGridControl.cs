using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.MachineConfig
{
    public partial class OperationsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineConfigEntities entity = (MachineConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMMachineUnitOperationsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = false;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
            return gridView;
        }
        void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                MMMachineUnitOperationsInfo item = (MMMachineUnitOperationsInfo)gridView.GetRow(e.FocusedRowHandle);
                ((MachineConfigModule)Screen.Module).MMMachineUnitOperationID = item != null ? item.MMMachineUnitOperationID : 0;
                ((MachineConfigModule)Screen.Module).InvalidateSemiProductList(item != null ? item.MMMachineUnitOperationID : 0);
            }
        }
    }
}
