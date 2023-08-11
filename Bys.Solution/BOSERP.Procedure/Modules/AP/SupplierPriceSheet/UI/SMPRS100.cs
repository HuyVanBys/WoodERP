using System;

namespace BOSERP.Modules.SupplierPriceSheet.UI
{
    /// <summary>
    /// Summary description for SMSPS100
    /// </summary>
    public partial class SMSPS100 : BOSERPScreen
    {

        public SMSPS100()
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
