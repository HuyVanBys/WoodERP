using System;

namespace BOSERP.Modules.WoodPurchaseReceipt.UI
{
    /// <summary>
    /// Summary description for SMWPR100
    /// </summary>
    public partial class SMWPR100 : BOSERPScreen
    {

        public SMWPR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnButton_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }
    }
}
