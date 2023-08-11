using Localization;
using System;
using System.Windows.Forms;


namespace BOSERP.Modules.Candidate
{
    public partial class guiAddReligion : BOSERPScreen
    {
        public guiAddReligion()
        {
            InitializeComponent();
        }

        public guiAddReligion(String txtname, String txtcode)
        {
            InitializeComponent();
            fld_lblName.Text = txtname;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtAttributeName.Text))
            {
                MessageBox.Show(CandidateLocalizedResources.ReligionRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void guiAttributeInput_Load(object sender, EventArgs e)
        {
            fld_txtAttributeName.Focus();
        }
    }
}