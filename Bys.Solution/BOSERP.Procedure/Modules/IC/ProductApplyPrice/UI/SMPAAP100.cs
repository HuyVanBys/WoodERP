using System;

namespace BOSERP.Modules.ProductApplyPrice.UI
{
    /// <summary>
    /// Summary description for SMPAAP100
    /// </summary>
    public partial class SMPAAP100 : BOSERPScreen
    {

        public SMPAAP100()
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
