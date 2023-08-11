using Localization;
using System;
using System.Windows.Forms;


namespace BOSERP.Modules.ACDocumentType
{
    public partial class guiCreateEntryType : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the entry type object
        /// </summary>
        public ACEntryTypesInfo EntryTypeObject { get; set; }

        public guiCreateEntryType()
        {
            InitializeComponent();
            EntryTypeObject = new ACEntryTypesInfo();
        }

        private void fld_btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fld_txtACEntryTypeDesc.Text))
            {
                MessageBox.Show(DocumentTypeLocalizedResources.EntryTypeNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EntryTypeObject.ACEntryTypeDesc = fld_txtACEntryTypeDesc.Text;
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
