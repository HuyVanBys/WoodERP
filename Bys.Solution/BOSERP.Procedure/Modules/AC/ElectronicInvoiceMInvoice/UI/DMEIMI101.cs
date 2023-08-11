using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ElectronicInvoiceMInvoice.UI
{
	/// <summary>
    /// Summary description for DMAS101
	/// </summary>
	public partial class DMEIMI101 : BOSERPScreen
	{

        public DMEIMI101()
		{
			InitializeComponent();
		}

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).AddLoanReceiptTemplate();
        }
	}
}
