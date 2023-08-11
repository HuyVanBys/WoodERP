using System;

namespace BOSERP.Modules.Barcode.UI
{
    /// <summary>
    /// Summary description for SMBC100
    /// </summary>
    public partial class SMBC100 : BOSERPScreen
    {

        public SMBC100()
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
