using System;

namespace BOSERP.Modules.ReturnShipping.UI
{
    /// <summary>
    /// Summary description for SMRSP100
    /// </summary>
    public partial class SMRSP100 : BOSERPScreen
    {

        public SMRSP100()
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
