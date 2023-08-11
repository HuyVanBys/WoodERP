using System;

namespace BOSERP.Modules.CanceledDeliveryPlan.UI
{
    /// <summary>
    /// Summary description for SMCDP100
    /// </summary>
    public partial class SMCDP100 : BOSERPScreen
    {

        public SMCDP100()
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
