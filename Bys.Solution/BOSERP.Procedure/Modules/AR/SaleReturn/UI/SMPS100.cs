using System;

namespace BOSERP.Modules.SaleReturn.UI
{
    /// <summary>
    /// Summary description for SMPS100
    /// </summary>
    public partial class SMPS100 : BOSERPScreen
    {

        public SMPS100()
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
