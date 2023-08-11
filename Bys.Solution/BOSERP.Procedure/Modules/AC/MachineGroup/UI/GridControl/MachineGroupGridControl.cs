using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineGroup
{
    public partial class MachineGroupGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineGroupEntities entity = (MachineGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MachineGroupList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            MachineGroupEntities entity = (MachineGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.FocusedRowHandle >= 0 && entity.MachineGroupList[e.FocusedRowHandle] != null)
            {

                ICMachinesInfo item = entity.MachineGroupList[e.FocusedRowHandle];
                ((MachineGroupModule)Screen.Module).CurrentID++;
                item.CurrentID = ((MachineGroupModule)Screen.Module).CurrentID;
                ((MachineGroupModule)Screen.Module).InvalidateTSCDAndCCDC(item);
            }
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                MachineGroupEntities entity = (MachineGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                entity.MachineGroupList.RemoveSelectedRowObjectFromList();
            }
        }
    }
}
