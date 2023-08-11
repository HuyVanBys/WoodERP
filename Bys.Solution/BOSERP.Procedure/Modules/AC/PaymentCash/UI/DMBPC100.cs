using BOSCommon;
using BOSComponent;
using System;

namespace BOSERP.Modules.PaymentCash.UI
{
    /// <summary>
    /// Summary description for DMBPC100
    /// </summary>
    public partial class DMBPC100 : BOSERPScreen
    {

        public DMBPC100()
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
                ((PaymentCashModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentCashModule)Module).ChangeObject(e.Value.ToString());
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
                    ((PaymentCashModule)Module).ChangeCurrency(currencyID);
                }

            }
        }

        private void fld_lkeACBankTransactionFromType_EditValueChanged(object sender, EventArgs e)
        {
            ShowFrom();
        }

        private void fld_lkeACBankTransactionToType_EditValueChanged(object sender, EventArgs e)
        {
            ShowTo();
        }
        private void ShowFrom()
        {
            fld_lkeFK_CSCompanyBankID.Visible = false;
            fld_lkeFK_CSCashFundID.Visible = false;

            string fromType = ((PaymentCashModule)Module).GetFromType();
            if (fromType == BankTransactionFromType.Bank.ToString())
            {
                fld_lkeFK_CSCompanyBankID.Visible = true;
            }
            else if (fromType == BankTransactionFromType.CashFund.ToString())
            {
                fld_lkeFK_CSCashFundID.Visible = true;
            }
        }
        private void ShowTo()
        {
            fld_lkeFK_ToCSCompanyBankID.Visible = false;
            fld_lkeFK_ToCSCashFundID.Visible = false;

            string toType = ((PaymentCashModule)Module).GetToType();
            if (toType == BankTransactionToType.Bank.ToString())
            {
                fld_lkeFK_ToCSCompanyBankID.Visible = true;
            }
            else if (toType == BankTransactionToType.CashFund.ToString())
            {
                fld_lkeFK_ToCSCashFundID.Visible = true;
            }
        }

        private void fld_lkeACBankTransactionFromType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentCashModule)Module).ChangeFromType(e.Value.ToString());
                ShowFrom();
            }
        }

        private void fld_lkeACBankTransactionToType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentCashModule)Module).ChangeToType(e.Value.ToString());
                ShowTo();
            }
        }

        private void fld_lkeFK_CSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentCashModule)Module).ChangeCashFund(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void fld_lkeFK_ToCSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentCashModule)Module).ChangeToCashFund(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void fld_lkeFK_ToCSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentCashModule)Module).ChangeToBank(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void fld_txtACBankTransactionExchangeRate_Validated(object sender, EventArgs e)
        {
            ((PaymentCashModule)Module).ChangeExchangeRate();
        }
        private void fld_medACBankTransactionDesc_Validated(object sender, EventArgs e)
        {
            ((PaymentCashModule)Module).ValidatedItemDesc();
        }
    }
}
