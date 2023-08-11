using System;

namespace BOSERP.Modules.PaymentProposal.UI
{
    /// <summary>
    /// Summary description for DMAS101
    /// </summary>
    public partial class DMPP101 : BOSERPScreen
    {

        public DMPP101()
        {
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((PaymentProposalModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((PaymentProposalModule)this.Module).AddFileTemplate();
        }
    }
}
