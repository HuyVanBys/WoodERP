using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Common
{
    public partial class guiChangePassword : BOSERPScreen
    {
        public guiChangePassword()
        {
            InitializeComponent();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (((CommonModule)Module).ChangePassword(fld_txtPassword.Text, fld_txtConfirmedPassword.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
