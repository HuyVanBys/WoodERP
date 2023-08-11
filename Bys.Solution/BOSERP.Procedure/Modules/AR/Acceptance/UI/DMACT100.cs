using System;

namespace BOSERP.Modules.Acceptance.UI
{
    /// <summary>
    /// Summary description for DMRSP100
    /// </summary>
    public partial class DMACT100 : BOSERPScreen
    {

        public DMACT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShowMaterialShipment_Click(object sender, EventArgs e)
        {
            ((AcceptanceModule)this.Module).ShowMaterialShipment();
        }

        private void fld_txtARAcceptanceDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((AcceptanceModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_txtARAcceptanceDiscountFix_Validated(object sender, EventArgs e)
        {
            ((AcceptanceModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_txtARAcceptanceTaxPercent_Validated(object sender, EventArgs e)
        {
            ((AcceptanceModule)this.Module).ChangeTaxPercent();
        }

        private void fld_txtARAcceptanceTaxAmount_Validated(object sender, EventArgs e)
        {
            ((AcceptanceModule)this.Module).ChangeTaxAmount();
        }

        private void fld_btnChooseShipmentItems_Click(object sender, EventArgs e)
        {
            ((AcceptanceModule)this.Module).ChooseShipmentItems();
        }
    }
}
