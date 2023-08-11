using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.PaymentOrder.UI
{
    /// <summary>
    /// Summary description for DMBPO100
    /// </summary>
    public partial class DMBPO100 : BOSERPScreen
    {

        public DMBPO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentOrderModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentOrderModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeACVATDocumentType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bosLabel14_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((PaymentOrderModule)Module).ChangeCurrency(currencyID);
                }
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
                    ((PaymentOrderModule)Module).ChangeSegment(segmentID);
                }
            }
        }

        private void fld_lkeFK_ACListAccountBankID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((PaymentOrderModule)Module).GetDSForListAccountBankLookUpEditControl();
        }

        private void fld_lkeFK_ACListAccountBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentOrderModule)Module).ChangeListAccountBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_medACBankTransactionDesc_Validated(object sender, EventArgs e)
        {
            ((PaymentOrderModule)Module).UpdateItemDesc();
        }

        private void fld_txtACBankTransactionExchangeRate_Validated(object sender, EventArgs e)
        {
            ((PaymentOrderModule)Module).ChangeExchangeRate();
        }

        private void fld_lkeFK_ACLoanReceiptID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentOrderModule)Module).ChangeLoanReceipt(Convert.ToInt32(e.Value));
            }
        }
    }
}
