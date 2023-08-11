using BOSLib;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public enum AddUserMode { Add, Edit }

    public partial class guiAddUsers : BOSERPScreen
    {
        private TreeList TreeList = null;
        private AddUserMode Mode;

        public guiAddUsers()
        {
            InitializeComponent();
        }
        public guiAddUsers(TreeList treeList, AddUserMode mode)
        {
            InitializeComponent();
            TreeList = treeList;
            Mode = mode;
        }

        private void fld_btnCloseUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnAddUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtUser.Text))
            {
                MessageBox.Show(UserManagementLocalizedResources.UserGroupNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ADUserGroupsController objUserGroupsController = new ADUserGroupsController();
            if (Mode == AddUserMode.Add)
            {
                //ADUserGroupsInfo objADUserGroupsInfo = new ADUserGroupsInfo();
                //objADUserGroupsInfo.ADUserGroupName = fld_txtUser.Text;
                //objADUserGroupsInfo.ADLanguageIDCombo = 1;
                //objADUserGroupsInfo.ADUserGroupDesc = fld_txtUser.Text;
                //objUserGroupsController.CreateObject(objADUserGroupsInfo);
            }
            else if (Mode == AddUserMode.Edit)
            {
                //ADUserGroupsInfo objADUserGroupsInfo = (ADUserGroupsInfo)objUserGroupsController.GetObjectByID(Convert.ToInt32(TreeList.FocusedNode.Tag));
                //objADUserGroupsInfo.ADUserGroupName = fld_txtUser.Text;
                //objADUserGroupsInfo.ADUserGroupDesc = fld_txtUser.Text;
                //objUserGroupsController.UpdateObject(objADUserGroupsInfo);
            }
            ((UserManagementModule)this.Module).InitializeTreeList(TreeList);
            this.Close();
        }
    }
}