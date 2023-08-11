using System;

namespace BOSERP.Modules.PriceSheet.UI
{
    /// <summary>
    /// Summary description for SMPRS100
    /// </summary>
    public partial class SMPRS100 : BOSERPScreen
    {

        public SMPRS100()
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
