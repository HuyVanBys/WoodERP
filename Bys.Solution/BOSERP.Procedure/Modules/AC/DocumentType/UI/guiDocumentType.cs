using Localization;
using System;
using System.Windows.Forms;


namespace BOSERP.Modules.ACDocumentType
{
    public partial class guiDocumentType : BOSERPScreen
    {
        public guiDocumentType()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fld_txtACDocumentTypeDesc.Text))
            {
                MessageBox.Show(DocumentTypeLocalizedResources.DocumentTypeDescRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void guiDocumentType_Load(object sender, EventArgs e)
        {
            ((ACDocumentTypeModule)Module).GetDocumentTypeDescForTextBox(fld_txtACDocumentTypeDesc);
        }
    }
}
