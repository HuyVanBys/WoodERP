using System;

namespace BOSERP.Modules.Acceptance.UI
{
    /// <summary>
    /// Summary description for SMRSP100
    /// </summary>
    public partial class SMACT100 : BOSERPScreen
    {

        public SMACT100()
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
