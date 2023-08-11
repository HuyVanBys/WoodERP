using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.CancelVoucher.UI
{
    /// <summary>
    /// Summary description for DMARCV100
    /// </summary>
    public partial class DMARCV100 : BOSERPScreen
    {

        public DMARCV100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMARCV100_Load(object sender, EventArgs e)
        {

        }

        private void fld_txtARCancelVoucherDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((CancelVoucherModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtARCancelVoucherDiscountFix_Validated(object sender, EventArgs e)
        {
            ((CancelVoucherModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtARCancelVoucherTaxPerCent_Validated(object sender, EventArgs e)
        {
            ((CancelVoucherModule)Module).ChangeTaxPercent();
        }

        private void fld_txtARCancelVoucherTaxAmount_Validated(object sender, EventArgs e)
        {
            ((CancelVoucherModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CancelVoucherModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CancelVoucherModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_btnAddCost_Click(object sender, EventArgs e)
        {
            ((CancelVoucherModule)Module).ShowChooseItemWork();
        }

        private void fld_lkeFK_PMProjectID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((CancelVoucherModule)Module).GetProjectByObjectID();
        }

        private void fld_lkeFK_ARSaleContractID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((CancelVoucherModule)Module).GetSaleContractByObjectIDAnProjectID(); ;
        }
    }
}
