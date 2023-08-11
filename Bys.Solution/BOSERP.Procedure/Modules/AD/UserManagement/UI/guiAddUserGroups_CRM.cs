using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public enum AddUserGroup_CRMMode { Add, Edit }

    public partial class guiAddUserGroups_CRM : BOSERPScreen
    {
        private TreeList TreeList = null;
        private AddUserGroup_CRMMode Mode;

        public guiAddUserGroups_CRM()
        {
            InitializeComponent();
        }
        public guiAddUserGroups_CRM(TreeList treeList, AddUserGroup_CRMMode mode)
        {
            InitializeComponent();
            TreeList = treeList;
            Mode = mode;
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branchs = objBranchsController.GetAllActiveBranches();
            fld_lkeFK_BRBranchID.Properties.DataSource = branchs;
        }

        private void fld_btnCloseUserGroup_CRM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnAddUserGroup_CRM_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtUserGroup_CRM.Text))
            {
                MessageBox.Show(UserManagementLocalizedResources.UserGroupNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HRGroupsController objHRGroupsController = new HRGroupsController();
            if (Mode == AddUserGroup_CRMMode.Add)
            {
                int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);
                HRGroupsInfo objHRGroupsInfo = new HRGroupsInfo();
                objHRGroupsInfo.HRGroupName = fld_txtUserGroup_CRM.Text;
                objHRGroupsInfo.HRGroupDesc = fld_txtUserGroup_CRM.Text;
                objHRGroupsInfo.FK_BRBranchID = branchID;
                objHRGroupsController.CreateObject(objHRGroupsInfo);
            }
            else if (Mode == AddUserGroup_CRMMode.Edit)
            {
                int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);
                HRGroupsInfo objHRGroupsInfo = (HRGroupsInfo)objHRGroupsController.GetObjectByID(Convert.ToInt32(TreeList.FocusedNode.Tag));
                objHRGroupsInfo.HRGroupName = fld_txtUserGroup_CRM.Text;
                objHRGroupsInfo.HRGroupDesc = fld_txtUserGroup_CRM.Text;
                objHRGroupsInfo.FK_BRBranchID = branchID;
                objHRGroupsController.UpdateObject(objHRGroupsInfo);
            }
            ((UserManagementModule)this.Module).InitializeTreeList_CRM(TreeList);
            this.Close();

        }
    }
}