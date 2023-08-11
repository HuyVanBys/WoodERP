using System;

namespace BOSERP.Modules.BugManagement.UI
{
    /// <summary>
    /// Summary description for DMBM101
    /// </summary>
    public partial class DMBM101 : BOSERPScreen
    {

        public DMBM101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.BugManagement.BugManagementModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.BugManagement.BugManagementModule)this.Module).SaveBugManagementDocumentOnServer();
        }

        private void fld_btnViewTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.BugManagement.BugManagementModule)this.Module).ViewFile();
        }

        private void fld_btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.BugManagement.BugManagementModule)this.Module).DeleteFile();
        }
    }
}
