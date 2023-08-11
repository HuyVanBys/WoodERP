using System;

namespace BOSERP.Modules.TransferAdditional.UI
{
    /// <summary>
    /// Summary description for SMTA100
    /// </summary>
    public partial class SMTA100 : BOSERPScreen
    {

        public SMTA100()
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
