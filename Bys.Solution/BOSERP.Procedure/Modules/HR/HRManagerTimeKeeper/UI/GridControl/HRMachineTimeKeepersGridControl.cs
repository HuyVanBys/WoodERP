namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HRMachineTimeKeepersGridControl : BOSComponent.BOSGridControl
    {

        //public override void InitGridControlDataSource()
        //{
        //    ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    BindingSource bds = new BindingSource();
        //    bds.DataSource = entity.MachineTimeKeeperList;
        //    DataSource = bds;
        //}    
        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            ((ManagerTimeKeeperModule)Screen.Module).ChangeSelectedMachine(e.FocusedRowHandle);
        }

        public override object DataSource
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                base.DataSource = value;
                ((ManagerTimeKeeperModule)Screen.Module).ChangeSelectedMachine(0);
            }
        }
    }
}
