using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ExpressDesigner
{
    public partial class guiCreateModule : BOSERPScreen
    {
        public String ModuleDescription { get; set; }

        public guiCreateModule()
        {
            InitializeComponent();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtDescription.Text))
            {
                MessageBox.Show(ExpressDesignerLocalizedResources.ModuleDescRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModuleDescription = fld_txtDescription.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
