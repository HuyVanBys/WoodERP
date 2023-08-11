using System;

namespace BOSERP.Modules.Transfer.UI
{
    /// <summary>
    /// Summary description for SMTS100
    /// </summary>
    public partial class SMTS100 : BOSERPScreen
    {

        public SMTS100()
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
