using BOSLib;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class guiCopyPermission : BOSERPScreen
    {
        private TreeList TreeList = null;

        private int ToUserGroupId { get; set; }

        public guiCopyPermission(TreeList _treeList, int userGroupId)
        {
            InitializeComponent();
            ToUserGroupId = userGroupId;
            TreeList = _treeList;
        }

        private void fld_btnCloseUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnAddUser_Click(object sender, EventArgs e)
        {
            int usergroupId = fld_lkeUserGroup.EditValue == null ? 0 : (int)fld_lkeUserGroup.EditValue;
            if (usergroupId == 0)
                return;

            (new STModuleToUserGroupSectionsController()).CopyPermissionToUserGroup(usergroupId, ToUserGroupId);
            ((UserManagementModule)this.Module).InitializeTreeList(TreeList);
            this.Close();
        }

        private void guiCopyPermission_Load(object sender, EventArgs e)
        {
            DataSet ds =  (new ADUserGroupsController()).GetAllObjects();
            fld_lkeUserGroup.Properties.DataSource = ds.Tables[0];
        }
    }
}