using System;

namespace BOSERP.Modules.Candidate.UI
{
    /// <summary>
    /// Summary description for DMCM101
    /// </summary>
    public partial class DMCM101 : BOSERPScreen
    {

        public DMCM101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.Candidate.CandidateModule)this.Module).BrowseFile();
        }

        private void Fld_btnAddTemplates_Click(object sender, EventArgs e)
        {
            ((Modules.Candidate.CandidateModule)this.Module).AddTemplate();
        }
    }
}
