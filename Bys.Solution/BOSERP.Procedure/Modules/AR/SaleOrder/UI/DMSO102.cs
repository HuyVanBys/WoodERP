using System;

namespace BOSERP.Modules.SaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSO102
    /// </summary>
    public partial class DMSO102 : BOSERPScreen
    {

        public DMSO102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadSaleOrderTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).AddSaleOrderTemplate();
        }
    }
}
