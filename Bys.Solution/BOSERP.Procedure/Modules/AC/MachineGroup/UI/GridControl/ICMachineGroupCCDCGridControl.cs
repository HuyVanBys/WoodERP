using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineGroup
{
    public class ICMachineGroupCCDCGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineGroupEntities entity = (MachineGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MachineGroupCCDCList;
            this.DataSource = bds;
        }


        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    MachineGroupEntities entity = (MachineGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    entity.MachineGroupCCDCList.RemoveSelectedRowObjectFromList();
                    entity.MachineGroupCCDCList.GridControl.RefreshDataSource();
                    //((MachineGroupModule)Screen.Module).RemoveSelectedItemsList();
                }
            }
        }
    }
}
