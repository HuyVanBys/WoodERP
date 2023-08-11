using System;

namespace BOSERP.Modules.TransferConstruction.UI
{
    /// <summary>
    /// Summary description for SMTC100
    /// </summary>
    public partial class SMTC100 : BOSERPScreen
    {

        public SMTC100()
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
