using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class guiManageUser_AppStaff : BOSERPScreen
    {
        public enum AddUserGroup_AppStaff_Mode { Add, Edit }
        private TreeList TreeList = null;
        private AddUserGroup_AppStaffMode Mode;

        public guiManageUser_AppStaff()
        {
            InitializeComponent();
        }

        public guiManageUser_AppStaff(TreeList treeList, AddUserGroup_AppStaffMode mode)
        {
            InitializeComponent();
            TreeList = treeList;
            Mode = mode;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void guiManageUser_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            if (Mode == AddUserGroup_AppStaffMode.Edit)
            {
                //TreeListNode node = TreeList.FocusedNode;
                //HREmployeeGroupsInfo objHREmployeeGroupsInfo = (HREmployeeGroupsInfo)new HREmployeeGroupsController().GetObjectByID(Convert.ToInt32(node.Tag));
                //HREmployeesInfo objHREmployeesInfo = (HREmployeesInfo)new HREmployeesController().GetObjectByID(objHREmployeeGroupsInfo.FK_HREmployeeID);
                //fld_lkeStaff.CurrentDisplayText = objHREmployeesInfo.HREmployeeName;
                //fld_lkeStaff.ItemIndex = objHREmployeesInfo.HREmployeeID;
            }
            else
                fld_lkeStaff.Text = "";
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_lkeStaff.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TreeListNode node = TreeList.FocusedNode;
            if (node != null)
            {
                ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)new ADGroupAppStaffsController().GetObjectByID(Convert.ToInt32(node.Tag));
                if (objGroupAppStaffsInfo != null)
                {
                    HREmployeeGroupAppStaffsController objEmployeeGroupAppStaffsController = new HREmployeeGroupAppStaffsController();
                    if (Mode == AddUserGroup_AppStaffMode.Add)
                    {
                        HREmployeeGroupAppStaffsInfo objEmployeeGroupAppStaffsInfo = new HREmployeeGroupAppStaffsInfo();
                        HREmployeeGroupAppStaffsInfo objEmployeeExist = (HREmployeeGroupAppStaffsInfo)objEmployeeGroupAppStaffsController.GetEmployeeByADGroupAppStaffAndHREmployeeID(Convert.ToInt32(TreeList.FocusedNode.Tag), Convert.ToInt32(fld_lkeStaff.EditValue));
                        if (objEmployeeExist != null)
                        {
                            MessageBox.Show("Nhân viên đã tồn tại trong nhóm !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        objEmployeeGroupAppStaffsInfo.FK_HREmployeeID = Convert.ToInt32(fld_lkeStaff.EditValue);
                        objEmployeeGroupAppStaffsInfo.FK_ADGroupAppStaffID = objGroupAppStaffsInfo.ADGroupAppStaffID;
                        objEmployeeGroupAppStaffsInfo.FK_BRBranchID = objGroupAppStaffsInfo.FK_BRBranchID;
                        objEmployeeGroupAppStaffsController.CreateObject(objEmployeeGroupAppStaffsInfo);
                    }
                    //else if (Mode == AddUserGroup_AppStaffMode.Edit)
                    //{
                    //    HREmployeeGroupsInfo objHREmployeeGroupsInfo = (HREmployeeGroupsInfo)objHREmployeeGroupsController.GetObjectByID(Convert.ToInt32(TreeList.FocusedNode.Tag));

                    //    HREmployeeGroupsInfo objEmployeeExist = (HREmployeeGroupsInfo)objHREmployeeGroupsController.GetEmployeeByHRGroupAndHREmployeeID(objHREmployeeGroupsInfo.FK_HRGroupID, Convert.ToInt32(fld_lkeStaff.ItemIndex));
                    //    if (objEmployeeExist != null)
                    //    {
                    //        MessageBox.Show("nhân viên đã tồn tại trong nhóm !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                    //    objHREmployeeGroupsInfo.FK_HREmployeeID = Convert.ToInt32(fld_lkeStaff.ItemIndex);
                    //    objHREmployeeGroupsController.UpdateObject(objHREmployeeGroupsInfo);
                    //}
                }
            }

            ((UserManagementModule)this.Module).InitializeTreeList_AppStaff(TreeList);
            this.Close();

        }
    }
}