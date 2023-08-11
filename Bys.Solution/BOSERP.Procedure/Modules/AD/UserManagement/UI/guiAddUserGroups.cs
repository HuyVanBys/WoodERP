using BOSLib;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public enum AddUserGroupMode { Add, Edit }

    public partial class guiAddUserGroups : BOSERPScreen
    {
        private TreeList TreeList = null;
        private AddUserGroupMode Mode;

        public guiAddUserGroups()
        {
            InitializeComponent();
        }
        public guiAddUserGroups(TreeList treeList, AddUserGroupMode mode)
        {
            InitializeComponent();
            TreeList = treeList;
            Mode = mode;
        }

        private void fld_btnCloseUserGroup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnAddUserGroup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtUserGroup.Text))
            {
                MessageBox.Show(UserManagementLocalizedResources.UserGroupNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ADUserGroupsController objUserGroupsController = new ADUserGroupsController();
            if (Mode == AddUserGroupMode.Add)
            {
                ADUserGroupsInfo objADUserGroupsInfo = new ADUserGroupsInfo();
                objADUserGroupsInfo.ADUserGroupName = fld_txtUserGroup.Text;
                objADUserGroupsInfo.ADLanguageIDCombo = 1;
                objADUserGroupsInfo.ADUserGroupDesc = fld_txtUserGroup.Text;
                objUserGroupsController.CreateObject(objADUserGroupsInfo);
            }
            else if (Mode == AddUserGroupMode.Edit)
            {
                ADUserGroupsInfo objADUserGroupsInfo = (ADUserGroupsInfo)objUserGroupsController.GetObjectByID(Convert.ToInt32(TreeList.FocusedNode.Tag));
                objADUserGroupsInfo.ADUserGroupName = fld_txtUserGroup.Text;
                objADUserGroupsInfo.ADUserGroupDesc = fld_txtUserGroup.Text;
                objUserGroupsController.UpdateObject(objADUserGroupsInfo);
            }
            ((UserManagementModule)this.Module).InitializeTreeList(TreeList);
            this.Close();
        }
    }
}