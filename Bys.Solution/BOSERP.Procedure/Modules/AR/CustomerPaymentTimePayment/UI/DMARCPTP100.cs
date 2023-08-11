using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.CustomerPaymentTimePayment.UI
{
    /// <summary>
    /// Summary description for DMARCP100
    /// </summary>
    public partial class DMARCPTP100 : BOSERPScreen
    {

        public DMARCPTP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnInvoice_Click(object sender, EventArgs e)
        {
            //((CustomerPaymentTimePaymentModule)Module).ShowOwingInvoices(Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue));
            ((CustomerPaymentTimePaymentModule)Module).GetSaleOrderForPayment();
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentTimePaymentModule)Module).ChangeCustomer(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentTimePaymentModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentTimePaymentModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtARCustomerPaymentExchangeRate_EditValueChanged(object sender, EventArgs e)
        {
            ((CustomerPaymentTimePaymentModule)Module).ChangeExchangeRate();
        }

        private void fld_txtARCustomerPaymentTotalAmount_Validated(object sender, EventArgs e)
        {
            ((CustomerPaymentTimePaymentModule)Module).ChangeCustomerPaymentTotalAmount();
        }

        private void fld_lkeFK_CSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentTimePaymentModule)Module).ChangeCashFund(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value == null)
            {
                ((CustomerPaymentTimePaymentModule)Module).ChangeObject(string.Empty);
            }
            else if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentTimePaymentModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_lkeFK_PMProjectID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((CustomerPaymentTimePaymentModule)Module).InvalidatePMProjectIDDatasorce();
        }

        private void fld_txtARCustomerPaymentExchangeRate_Validated(object sender, EventArgs e)
        {
            BOSTextBox txt = (BOSTextBox)sender;
            if (txt.EditValue != string.Empty
                && txt.EditValue != txt.OldEditValue)
            {
                ((CustomerPaymentTimePaymentModule)Module).ChangeExchangeRate();
            }
        }
    }
}
