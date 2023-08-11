using BOSLib;
using Localization;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Common
{
    public class CommonModule : BaseModuleERP
    {
        public CommonModule()
        {
            Name = "Common";
            CurrentModuleEntity = new CommonEntities();
            CurrentModuleEntity.Module = this;
            CurrentModuleEntity.InitModuleEntity();
        }

        /// <summary>
        /// Logout from the current user
        /// </summary>
        public void Logout()
        {
            BOSApp.LogOff();
        }

        /// <summary>
        /// Called when the user changes their password
        /// </summary>
        public void ChangePassword()
        {
            guiChangePassword guiChangePassword = new guiChangePassword();
            guiChangePassword.Module = this;
            guiChangePassword.ShowDialog();
        }

        /// <summary>
        /// Change the user's password
        /// </summary>
        /// <param name="password">New password</param>
        /// <param name="confirmedPassword">Confirmed password</param>
        /// <returns>True if change successfully, otherwise false</returns>
        public bool ChangePassword(string password, string confirmedPassword)
        {
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(CommonLocalizedResources.PasswordIsRequiredMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            if (password != confirmedPassword)
            {
                MessageBox.Show(CommonLocalizedResources.ConfirmedPasswordNotMatchMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            ADUsersController objUsersController = new ADUsersController();
            byte[] passwordBytes = SHA1Managed.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            BOSApp.CurrentUsersInfo.ADPassword = Convert.ToBase64String(passwordBytes);
            objUsersController.UpdateObject(BOSApp.CurrentUsersInfo);
            MessageBox.Show(CommonLocalizedResources.ChangePasswordSuccessfullyMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            return true;
        }
    }
}
