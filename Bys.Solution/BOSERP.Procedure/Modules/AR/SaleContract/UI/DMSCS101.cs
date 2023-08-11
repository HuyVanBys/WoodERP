using System;

namespace BOSERP.Modules.SaleContract.UI
{
    /// <summary>
    /// Summary description for DMSO102
    /// </summary>
    public partial class DMSCS101 : BOSERPScreen
    {

        public DMSCS101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.SaleContract.SaleContractModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.SaleContract.SaleContractModule)this.Module).AddSaleContractTemplate();
        }
    }
}
