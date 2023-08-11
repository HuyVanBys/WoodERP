using System;
using System.Data;

namespace BOSERP.Modules.UserManagement
{
    public partial class guiListUsers : BOSERPScreen
    {
        public guiListUsers()
        {
            InitializeComponent();
        }

        public override void InitializeScreen()
        {
            fld_dgcADUsers.Screen = this;
            fld_dgcADUsers.InitializeControl();
            //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
            fld_dgcADDataViewPermissions.Screen = this;
            fld_dgcADDataViewPermissions.InitializeControl();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            fld_dgcADReportViewPermissions.Screen = this;
            fld_dgcADReportViewPermissions.InitializeControl();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], END

            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ADUserList.InitBOSListGridControl(fld_dgcADUsers);
        }

        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).AddUser();
        }

        /// <summary>
        /// Edit a user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fld_btnEdit_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).EditUser();
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).DeleteUser();
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
        public void RefreshDataViewPermissionGridControlDataSource(DataTable dt)
        {
            fld_dgcADDataViewPermissions.RefreshDataSource(dt);
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        public void RefreshReportViewPermissionGridControlDataSource(DataTable dt)
        {
            fld_dgcADReportViewPermissions.RefreshDataSource(dt);
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).SaveDataViewPermissions();
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
    }
}