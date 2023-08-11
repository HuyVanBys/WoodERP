using System;

namespace BOSERP.Modules.CreditNote.UI
{
    /// <summary>
    /// Summary description for SMCN100
    /// </summary>
    public partial class SMCN100 : BOSERPScreen
    {

        public SMCN100()
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
