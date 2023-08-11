using System;

namespace BOSERP.Modules.ConfigSalesTarget.UI
{
    /// <summary>
    /// Summary description for SMCSP100
    /// </summary>
    public partial class SMCST100 : BOSERPScreen
    {

        public SMCST100()
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
