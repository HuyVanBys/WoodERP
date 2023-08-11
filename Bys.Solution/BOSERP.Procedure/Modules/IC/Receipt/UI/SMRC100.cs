using System;

namespace BOSERP.Modules.Receipt.UI
{
    /// <summary>
    /// Summary description for SMRC100
    /// </summary>
    public partial class SMRC100 : BOSERPScreen
    {

        public SMRC100()
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
