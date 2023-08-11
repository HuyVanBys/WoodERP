using System;

namespace BOSERP.Modules.LoanReceipt.UI
{
    /// <summary>
    /// Summary description for DMAS101
    /// </summary>
    public partial class DMLRC101 : BOSERPScreen
    {

        public DMLRC101()
        {
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.LoanReceipt.LoanReceiptModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.LoanReceipt.LoanReceiptModule)this.Module).AddLoanReceiptTemplate();
        }
    }
}
