using System;

namespace BOSERP.Modules.AdvanceRefund.UI
{
    /// <summary>
    /// Summary description for DMBP101
    /// </summary>
    public partial class DMARF101 : BOSERPScreen
    {

        public DMARF101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.AdvanceRefund.AdvanceRefundModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.AdvanceRefund.AdvanceRefundModule)this.Module).AddAdvanceRefundTemplate();
        }

        private void fld_btnViewTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.AdvanceRefund.AdvanceRefundModule)this.Module).ViewFile();
        }

        private void fld_btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.AdvanceRefund.AdvanceRefundModule)this.Module).DeleteFile();
        }
    }
}
