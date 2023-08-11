using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.BankTransaction.UI
{
    /// <summary>
    /// Summary description for DMBT100
    /// </summary>
    public partial class DMBT100 : BOSERPScreen
    {

        public DMBT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_CSCompanyBankID_Validating(object sender, CancelEventArgs e)
        {

        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BankTransactionModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((BankTransactionModule)Module).ChangeCurrency(currencyID);
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
                    ((BankTransactionModule)Module).ChangeSegment(segmentID);
                }
            }
        }

        private void fld_txtACBankTransactionExchangeRate_Validated(object sender, EventArgs e)
        {
            ((BankTransactionModule)Module).ChangeExchangeRate();
        }

        private void fld_medACBankTransactionDesc_Validated(object sender, EventArgs e)
        {
            ((BankTransactionModule)Module).UpdateItemDesc();
        }

        private void fld_lkeFK_ACLoanReceiptID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int loanReceiptID = 0;
                if (int.TryParse(e.Value.ToString(), out loanReceiptID))
                {
                    ((BankTransactionModule)Module).ChangeLoanReceipt(loanReceiptID);
                }
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BankTransactionModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }
    }
}
