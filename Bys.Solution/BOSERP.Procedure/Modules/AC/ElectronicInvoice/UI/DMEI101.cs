using System;

namespace BOSERP.Modules.ElectronicInvoice.UI
{
    /// <summary>
    /// Summary description for DMAS101
    /// </summary>
    public partial class DMEI101 : BOSERPScreen
    {

        public DMEI101()
        {
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).AddLoanReceiptTemplate();
        }
    }
}
