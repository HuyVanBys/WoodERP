using System;

namespace BOSERP.Modules.Product.UI
{
    /// <summary>
    /// Summary description for DMPD102
    /// </summary>
    public partial class DMPD102 : BOSERPScreen
    {

        public DMPD102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.Product.ProductModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.Product.ProductModule)this.Module).SaveProductDocumentOnServer();
        }

        private void fld_btnViewTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.Product.ProductModule)this.Module).ViewFile();
        }

        private void fld_btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.Product.ProductModule)this.Module).DeleteFile();
        }
    }
}
