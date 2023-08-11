using System;
namespace BOSERP.Modules.UserManagement
{
    public partial class guiGroupTimeSheetPermission : BOSERPScreen
    {
        public guiGroupTimeSheetPermission()
        {
            InitializeComponent();
        }

        public override void InitializeControls()
        {
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.GroupTimeSheetPermissionList.InitBOSListGridControl(fld_dgcADGroupTimeSheetPermissions);
            fld_dgcADGroupTimeSheetPermissions.Screen = this;
            fld_dgcADGroupTimeSheetPermissions.InitializeControl();
            ((UserManagementModule)Module).InvalidateGroupTimeSheetPermissionList();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).SaveGroupTimeSheetPermission();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).ChooseAllGroupTimeSheets(fld_chkChooseAll.Checked);
        }
    }
}
