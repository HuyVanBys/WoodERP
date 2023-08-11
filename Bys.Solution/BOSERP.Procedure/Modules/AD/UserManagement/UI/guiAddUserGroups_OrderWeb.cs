using BOSLib;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public enum AddUserGroup_WebOrderMode { Add, Edit }

    public partial class guiAddUserGroups_OrderWeb : BOSERPScreen
    {
        private TreeList TreeList = null;
        private AddUserGroup_WebOrderMode Mode;

        public guiAddUserGroups_OrderWeb()
        {
            InitializeComponent();
        }
        public guiAddUserGroups_OrderWeb(TreeList treeList, AddUserGroup_WebOrderMode mode)
        {
            InitializeComponent();
            TreeList = treeList;
            Mode = mode;

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("GroupOrderWebRole");
            List<ADConfigValuesInfo> ListObjectFillter = new List<ADConfigValuesInfo>();
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ListObjectFillter.Add(objConfigValuesInfo);
                }
            }
            if (ListObjectFillter != null)
            {
                fld_lkeADGroupWebOrderRole.Properties.DataSource = ListObjectFillter;
            }
        }

        private void fld_btnCloseUserGroup_AppStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnAddUserGroup_AppStaff_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtUserGroup_WebOrder.Text))
            {
                MessageBox.Show(UserManagementLocalizedResources.UserGroupNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ADGroupOrderWebsController objGroupOrderWebsController = new ADGroupOrderWebsController();
            if (Mode == AddUserGroup_WebOrderMode.Add)
            {
                UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                ADGroupOrderWebsInfo objGroupOrderWebsInfo = new ADGroupOrderWebsInfo();
                objGroupOrderWebsInfo.ADGroupOrderWebName = fld_txtUserGroup_WebOrder.Text;
                objGroupOrderWebsInfo.ADGroupOrderWebDesc = fld_txtUserGroup_WebOrder.Text;
                objGroupOrderWebsInfo.ADGroupOrderWebRole = fld_lkeADGroupWebOrderRole.EditValue.ToString();
                objGroupOrderWebsController.CreateObject(objGroupOrderWebsInfo);
            }
            else if (Mode == AddUserGroup_WebOrderMode.Edit)
            {
                ADGroupOrderWebsInfo objGroupOrderWebsInfo = (ADGroupOrderWebsInfo)objGroupOrderWebsController.GetObjectByID(Convert.ToInt32(TreeList.FocusedNode.Tag));
                objGroupOrderWebsInfo.ADGroupOrderWebName = fld_txtUserGroup_WebOrder.Text;
                objGroupOrderWebsInfo.ADGroupOrderWebDesc = fld_txtUserGroup_WebOrder.Text;
                objGroupOrderWebsInfo.ADGroupOrderWebRole = fld_lkeADGroupWebOrderRole.EditValue.ToString();
                objGroupOrderWebsController.UpdateObject(objGroupOrderWebsInfo);
            }
            ((UserManagementModule)this.Module).InitializeTreeList_OrderWeb(TreeList);
            this.Close();

        }
    }
}