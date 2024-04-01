using BOSCommon;
using BOSLib;
using CredentialManagement;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiLogin : Form
    {
        public int BRBranchID { get; set; }
        public guiLogin()
        {
            InitializeComponent();
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> BranchsList = objBranchsController.GetAllBranches();
            if (BranchsList != null && BranchsList.Count > 0)
            {
                fld_lkeBRBranchID.Properties.DataSource = BranchsList;
                fld_lkeBRBranchID.EditValue = 0;
            }
            fld_lkeBRBranchID.Properties.PopupWidth = 350;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void fld_btnLogin_Click(object sender, EventArgs e)
        {
            if (fld_lkeBRBranchID.EditValue != null)
            {
                string message = string.Empty;

                if (BOSApp.IsAuthenticated(fld_txtUserName.Text, fld_txtPassword.Text, out message))
                {
                    if (!BOSApp.IsBranchPermission(fld_txtUserName.Text, Convert.ToInt32(fld_lkeBRBranchID.EditValue)))
                    {
                        MessageBox.Show(BaseLocalizedResources.InvalidBranchPermissioMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //string messageError = string.Empty;
                        //int result = Utilities.ApiLicenseHelper.CheckLicense(fld_txtUserName.Text, ref messageError);
                        //if ((int)LicenseStatus.NoConnecttion == result)
                        //{
                        //    MessageBox.Show(BaseLocalizedResources.NoConnecttionLicense, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                        //else
                        //{
                        //    if ((int)LicenseStatus.Inactive == result)
                        //    {
                        //        MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //    }
                        //    else
                        //    {
                                
                        //    }
                        //}
                        BRBranchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                        BOSApp.SetCurrentUserLogin(fld_txtUserName.Text);
                        if (fld_ckeSavePassword.Checked)
                            SavePassword(fld_txtUserName.Text, fld_txtPassword.Text);
                        else
                            DeleteCredential(fld_txtUserName.Text);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(BaseLocalizedResources.InvalidBranchMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fld_txtUserName_Validated(object sender, EventArgs e)
        {
            string userName = fld_txtUserName.Text;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetEmployeeByUserName(userName);
            if (objEmployeesInfo == null)
                return;

            fld_lkeBRBranchID.EditValue = objEmployeesInfo.FK_BRBranchID;
            fld_txtPassword.Text = GetPassword(userName);
            if (!string.IsNullOrWhiteSpace(fld_txtPassword.Text))
            {
                fld_ckeSavePassword.EditValue = true;
            }
        }

        private void DeleteCredential(string userName)
        {
            using (var cred = new Credential())
            {
                cred.Target = string.Format("{0}//User={1}", BysGateway.CredentialPrefixKey, userName);
                cred.Delete();
            }
        }


        private string GetPassword(string userName)
        {
            using (var cred = new Credential())
            {
                cred.Target = string.Format("{0}//User={1}", BysGateway.CredentialPrefixKey, userName);
                cred.Load();
                return cred.Password;
            }
        }

        public void SavePassword(string userName, string password)
        {
            using (var cred = new Credential())
            {
                cred.Username = userName;
                cred.Password = password;
                cred.Target = string.Format("{0}//User={1}", BysGateway.CredentialPrefixKey, userName);
                cred.Type = CredentialType.Generic;
                cred.PersistanceType = PersistanceType.LocalComputer;
                cred.Save();
            }
        }

        private void fld_txtPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fld_txtPassword.Properties.PasswordChar = '*';
        }

        private void fld_txtPassword_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fld_txtPassword.Properties.PasswordChar = '\0';
        }

        private void guiLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}