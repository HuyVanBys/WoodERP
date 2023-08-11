using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class guiManageUser_OrderWeb : BOSERPScreen
    {
        public enum AddUserGroup_WebOrder_Mode { Add, Edit }
        private TreeList TreeList = null;
        private AddUserGroup_WebOrderMode Mode;

        public guiManageUser_OrderWeb()
        {
            InitializeComponent();
        }

        public guiManageUser_OrderWeb(TreeList treeList, AddUserGroup_WebOrderMode mode)
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
            if (Mode == AddUserGroup_WebOrderMode.Edit)
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
                ADGroupOrderWebsInfo objGroupOrderWebsInfo = (ADGroupOrderWebsInfo)new ADGroupOrderWebsController().GetObjectByID(Convert.ToInt32(node.Tag));
                if (objGroupOrderWebsInfo != null)
                {
                    HREmployeeGroupOrderWebsController objHREmployeeGroupOrderWebsController = new HREmployeeGroupOrderWebsController();
                    if (Mode == AddUserGroup_WebOrderMode.Add)
                    {
                        HREmployeeGroupOrderWebsInfo objHREmployeeGroupOrderWebsInfo = new HREmployeeGroupOrderWebsInfo();
                        HREmployeeGroupOrderWebsInfo objEmployeeExist = (HREmployeeGroupOrderWebsInfo)objHREmployeeGroupOrderWebsController.GetEmployeeByADGroupOrderAndHREmployeeID(Convert.ToInt32(TreeList.FocusedNode.Tag), Convert.ToInt32(fld_lkeStaff.EditValue));
                        if (objEmployeeExist != null)
                        {
                            MessageBox.Show("Nhân viên đã tồn tại trong nhóm !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        objHREmployeeGroupOrderWebsInfo.FK_HREmployeeID = Convert.ToInt32(fld_lkeStaff.EditValue);
                        objHREmployeeGroupOrderWebsInfo.FK_ADGroupOrderWebID = objGroupOrderWebsInfo.ADGroupOrderWebID;
                        objHREmployeeGroupOrderWebsController.CreateObject(objHREmployeeGroupOrderWebsInfo);
                    }
                    //else if (Mode == AddUserGroup_WebOrderMode.Edit)
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

            ((UserManagementModule)this.Module).InitializeTreeList_OrderWeb(TreeList);
            this.Close();

        }
    }
}