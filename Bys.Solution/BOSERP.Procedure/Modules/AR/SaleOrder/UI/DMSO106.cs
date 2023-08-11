using System;

namespace BOSERP.Modules.SaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSO105
    /// </summary>
    public partial class DMSO106 : BOSERPScreen
    {

        public DMSO106()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnViewFollow_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)this.Module).ViewFollow();
        }

        private void fld_btnEditOtherFees_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)this.Module).UpdateOtherFeeAfterComplete();
        }
    }
}
