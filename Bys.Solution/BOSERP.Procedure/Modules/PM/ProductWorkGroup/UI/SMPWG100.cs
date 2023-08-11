using System;

namespace BOSERP.Modules.ProductWorkGroup.UI
{
    /// <summary>
    /// Summary description for SMPWG100
    /// </summary>
    public partial class SMPWG100 : BOSERPScreen
    {

        public SMPWG100()
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
