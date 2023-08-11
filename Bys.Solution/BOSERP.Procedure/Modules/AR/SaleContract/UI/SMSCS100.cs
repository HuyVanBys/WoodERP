using System;

namespace BOSERP.Modules.SaleContract.UI
{
    /// <summary>
    /// Summary description for SMCN100
    /// </summary>
    public partial class SMSCS100 : BOSERPScreen
    {

        public SMSCS100()
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
