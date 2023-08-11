using System;

namespace BOSERP.Modules.TransferOutsourcing.UI
{
    /// <summary>
    /// Summary description for SMTO100
    /// </summary>
    public partial class SMTO100 : BOSERPScreen
    {

        public SMTO100()
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
