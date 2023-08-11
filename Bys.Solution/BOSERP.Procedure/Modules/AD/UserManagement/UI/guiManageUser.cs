using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class guiManageUser : BOSERPScreen
    {
        public guiManageUser()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void guiManageUser_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        /// <summary>
        /// Check the user whether it is proper or not
        /// </summary>
        /// <returns></returns>
        private bool IsValidInput()
        {
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            ADUsersInfo objUsersInfo = (ADUsersInfo)entity.ModuleObjects[TableName.ADUsersTableName];
            if (string.IsNullOrEmpty(objUsersInfo.ADUserName))
            {
                MessageBox.Show(UserManagementLocalizedResources.UserNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ADUsersController objUsersController = new ADUsersController();
            ADUsersInfo existingUser = (ADUsersInfo)objUsersController.GetObjectByName(objUsersInfo.ADUserName);
            if (existingUser != null && existingUser.ADUserID != objUsersInfo.ADUserID)
            {
                MessageBox.Show(UserManagementLocalizedResources.UserNameExistsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objUsersInfo.ADUserID == 0)
            {
                if (String.IsNullOrEmpty(objUsersInfo.ADPassword))
                {
                    MessageBox.Show(UserManagementLocalizedResources.PasswordRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(objUsersInfo.ADPassword) && objUsersInfo.ADPassword != fld_txtConfirmPassword.Text)
            {
                MessageBox.Show(UserManagementLocalizedResources.PasswordNotMatchMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}