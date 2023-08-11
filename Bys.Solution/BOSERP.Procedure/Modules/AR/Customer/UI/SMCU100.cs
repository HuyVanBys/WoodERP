using System;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for SMCU100
    /// </summary>
    public partial class SMCU100 : BOSERPScreen
    {

        public SMCU100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnReset_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }
    }
}
