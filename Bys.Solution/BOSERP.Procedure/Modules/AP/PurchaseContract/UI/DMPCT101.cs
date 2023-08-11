using System;

namespace BOSERP.Modules.PurchaseContract.UI
{
    /// <summary>
    /// Summary description for DMPCT101
    /// </summary>
    public partial class DMPCT101 : BOSERPScreen
    {

        public DMPCT101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.PurchaseContract.PurchaseContractModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadPurchaseContractTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.PurchaseContract.PurchaseContractModule)this.Module).AddPurchaseContractTemplate();
        }
    }
}
