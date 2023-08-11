using System;

namespace BOSERP.Modules.Estimate.UI
{
    /// <summary>
    /// Summary description for DMEM100
    /// </summary>
    public partial class DMEM100 : BOSERPScreen
    {

        public DMEM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtAREstimateDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((EstimateModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtAREstimateDiscountFix_Validated(object sender, EventArgs e)
        {
            ((EstimateModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtAREstimateTaxPercent_Validated(object sender, EventArgs e)
        {
            ((EstimateModule)Module).ChangeTaxPercent();
        }

        private void fld_txtAREstimateTaxAmount_Validated(object sender, EventArgs e)
        {
            ((EstimateModule)Module).ChangeTaxAmount();
        }
    }
}
