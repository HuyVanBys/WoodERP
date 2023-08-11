using BOSComponent;
using System;

namespace BOSERP.Modules.CustomerPayment.UI
{
    /// <summary>
    /// Summary description for DMARCP100
    /// </summary>
    public partial class DMARCP100 : BOSERPScreen
    {

        public DMARCP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnInvoice_Click(object sender, EventArgs e)
        {
            ((CustomerPaymentModule)Module).ShowOwingInvoices(Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue));
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentModule)Module).ChangeCustomer(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerPaymentModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }
    }
}
