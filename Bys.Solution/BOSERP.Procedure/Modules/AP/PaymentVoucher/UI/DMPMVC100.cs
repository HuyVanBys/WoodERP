using BOSComponent;
using System;

namespace BOSERP.Modules.PaymentVoucher.UI
{
    /// <summary>
    /// Summary description for DMPMVC100
    /// </summary>
    public partial class DMPMVC100 : BOSERPScreen
    {

        public DMPMVC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentVoucherModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentVoucherModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_CSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentVoucherModule)Module).ChangeCashFund(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACSegmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int segmentID = 0;
                if (int.TryParse(e.Value.ToString(), out segmentID))
                {
                    ((PaymentVoucherModule)Module).ChangeSegment(segmentID);
                }
            }
        }

        private void fld_medAPPaymentVoucherDesc_Validated(object sender, EventArgs e)
        {
            ((PaymentVoucherModule)Module).UpdateItemDesc();
        }

        private void fld_txtAPPaymentVoucherExchangeRate_Validated(object sender, EventArgs e)
        {
            ((PaymentVoucherModule)Module).ChangeExchangeRate();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((PaymentVoucherModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_lkeFK_ACLoanReceiptID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentVoucherModule)Module).ChangeLoanReceipt(Convert.ToInt32(e.Value));
            }
        }
    }
}
