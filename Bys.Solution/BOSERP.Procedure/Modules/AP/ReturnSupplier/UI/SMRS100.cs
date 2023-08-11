using System;

namespace BOSERP.Modules.ReturnSupplier.UI
{
    /// <summary>
    /// Summary description for SMRS100
    /// </summary>
    public partial class SMRS100 : BOSERPScreen
    {

        public SMRS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnButton3_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }

        private void fld_btnButton4_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).Search();
        }
    }
}
