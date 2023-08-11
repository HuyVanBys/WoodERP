using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class ADUsersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ADUserList;
            DataSource = bds;
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.DoubleClick += new EventHandler(gridView_DoubleClick);
            return gridView;
        }

        void gridView_DoubleClick(object sender, EventArgs e)
        {
            UserManagementModule module = (UserManagementModule)Screen.Module;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //module.InitProductLocationBranchPricesDataSource();
            module.InitDataViewPermissionScreen();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], END
    }
}
