using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineGroup
{
    public class ICMachineGroupTSCDGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineGroupEntities entity = (MachineGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MachineGroupTSCDList;
            this.DataSource = bds;
        }


        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            //gridView.Columns["FK_ICProductID"].OptionsColumn.AllowEdit = false;
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
                    entity.MachineGroupTSCDList.RemoveSelectedRowObjectFromList();
                    entity.MachineGroupTSCDList.GridControl.RefreshDataSource();
                    //((MachineGroupModule)Screen.Module).RemoveSelectedItemPlansList();
                }
            }
        }



    }
}
