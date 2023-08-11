using System;

namespace BOSERP.Modules.AssemblyReceipt.UI
{
    /// <summary>
    /// Summary description for SMARC100
    /// </summary>
    public partial class SMARC100 : BOSERPScreen
    {

        public SMARC100()
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
