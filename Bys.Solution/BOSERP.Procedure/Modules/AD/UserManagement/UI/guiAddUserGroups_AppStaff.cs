using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public enum AddUserGroup_AppStaffMode { Add, Edit }

    public partial class guiAddUserGroups_AppStaff : BOSERPScreen
    {
        private TreeList TreeList = null;
        private AddUserGroup_AppStaffMode Mode;

        public guiAddUserGroups_AppStaff()
        {
            InitializeComponent();
        }
        public guiAddUserGroups_AppStaff(TreeList treeList, AddUserGroup_AppStaffMode mode)
        {
            InitializeComponent();
            TreeList = treeList;
            Mode = mode;
            //BRBranchsController objBranchsController = new BRBranchsController();
            //List<BRBranchsInfo> branchs = objBranchsController.GetAllActiveBranches();
            //fld_lkeFK_BRBranchID.Properties.DataSource = branchs;

            //ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            //ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            //DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("GroupAppStaffRole");
            //List<ADConfigValuesInfo> ListObjectFillter = new List<ADConfigValuesInfo>();
            //if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
            //        ListObjectFillter.Add(objConfigValuesInfo);
            //    }
            //}
            //if (ListObjectFillter != null)
            //{
            //    fld_lkeADGroupAppStaffRole.Properties.DataSource = ListObjectFillter;
            //}
        }

        private void fld_btnCloseUserGroup_AppStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnAddUserGroup_AppStaff_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtUserGroup_AppStaff.Text))
            {
                MessageBox.Show(UserManagementLocalizedResources.UserGroupNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ADGroupAppStaffsController objGroupAppStaffsController = new ADGroupAppStaffsController();
            if (Mode == AddUserGroup_AppStaffMode.Add)
            {
                UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                //int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);
                ADGroupAppStaffsInfo objGroupAppStaffsInfo = new ADGroupAppStaffsInfo();
                objGroupAppStaffsInfo.ADGroupAppStaffName = fld_txtUserGroup_AppStaff.Text;
                objGroupAppStaffsInfo.ADGroupAppStaffDesc = fld_txtUserGroup_AppStaff.Text;
                objGroupAppStaffsInfo.FK_BRBranchID = branchID;
                //objGroupAppStaffsInfo.ADGroupAppStaffRole = fld_lkeADGroupAppStaffRole.EditValue.ToString();
                objGroupAppStaffsController.CreateObject(objGroupAppStaffsInfo);
            }
            else if (Mode == AddUserGroup_AppStaffMode.Edit)
            {
                int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                //int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);
                ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)objGroupAppStaffsController.GetObjectByID(Convert.ToInt32(TreeList.FocusedNode.Tag));
                objGroupAppStaffsInfo.ADGroupAppStaffName = fld_txtUserGroup_AppStaff.Text;
                objGroupAppStaffsInfo.ADGroupAppStaffDesc = fld_txtUserGroup_AppStaff.Text;
                objGroupAppStaffsInfo.FK_BRBranchID = branchID;
                //objGroupAppStaffsInfo.ADGroupAppStaffRole = fld_lkeADGroupAppStaffRole.EditValue.ToString();
                objGroupAppStaffsController.UpdateObject(objGroupAppStaffsInfo);
            }
            ((UserManagementModule)this.Module).InitializeTreeList_AppStaff(TreeList);
            this.Close();

        }
    }
}