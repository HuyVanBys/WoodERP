using System;

namespace BOSERP.Modules.SaleOrderForWood.UI
{
    /// <summary>
    /// Summary description for DMSO102
    /// </summary>
    public partial class DMSOFW102 : BOSERPScreen
    {

        public DMSOFW102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            //((Modules.SaleOrder.SaleOrderModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            //((Modules.SaleOrder.SaleOrderModule)this.Module).SaveSaleOrderDocumentOnServer();
        }

        private void fld_btnViewTemplate_Click(object sender, EventArgs e)
        {
            //((Modules.SaleOrder.SaleOrderModule)this.Module).ViewFile();
        }

        private void fld_btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            //((Modules.SaleOrder.SaleOrderModule)this.Module).DeleteFile();
        }
    }
}
