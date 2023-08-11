using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{
    public partial class guiAddStreet : BOSERPScreen
    {
        public guiAddStreet()
        {
            InitializeComponent();
        }

        public guiAddStreet(String lblname, String lblcode, String txtname, String txtcode)
        {
            InitializeComponent();
            fld_txtAttributeName.Text = lblcode;
            fld_txtAttributeCode.Text = lblname;
            fld_lblCode.Text = txtcode;
            fld_lblName.Text = txtname;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtAttributeCode.Text))
            {
                MessageBox.Show(SupplierLocalizedResources.CountryNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            fld_txtAttributeCode.Focus();
        }
    }
}