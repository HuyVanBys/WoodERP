using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Department
{
    public partial class guiAttributeInput : Form
    {
        public guiAttributeInput()
        {
            InitializeComponent();
        }

        public guiAttributeInput(String name, String desc)
        {
            InitializeComponent();
            fld_txtAttributeName.Text = name;
            fld_txtAttributeDesc.Text = desc;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtAttributeName.Text))
            {
                MessageBox.Show(ICDepartmentLocalizedResources.AttributeNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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