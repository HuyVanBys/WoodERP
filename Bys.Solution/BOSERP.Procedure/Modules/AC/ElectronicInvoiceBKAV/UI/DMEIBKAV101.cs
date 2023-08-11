using System;

namespace BOSERP.Modules.ElectronicInvoiceBKAV.UI
{
    /// <summary>
    /// Summary description for DMAS101
    /// </summary>
    public partial class DMEIBKAV101 : BOSERPScreen
    {

        public DMEIBKAV101()
        {
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).AddLoanReceiptTemplate();
        }
    }
}
