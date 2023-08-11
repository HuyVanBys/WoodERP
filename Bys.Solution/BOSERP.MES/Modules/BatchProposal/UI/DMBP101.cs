using System;

namespace BOSERP.Modules.BatchProposal.UI
{
    /// <summary>
    /// Summary description for DMBP101
    /// </summary>
    public partial class DMBP101 : BOSERPScreen
    {

        public DMBP101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.BatchProposal.BatchProposalModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.BatchProposal.BatchProposalModule)this.Module).AddProposalTemplate();
        }

        private void fld_btnViewTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.BatchProposal.BatchProposalModule)this.Module).ViewFile();
        }

        private void fld_btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.BatchProposal.BatchProposalModule)this.Module).DeleteFile();
        }
    }
}
