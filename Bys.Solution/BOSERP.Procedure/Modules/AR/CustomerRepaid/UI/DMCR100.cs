using BOSComponent;
using System;

namespace BOSERP.Modules.CustomerRepaid.UI
{
    /// <summary>
    /// Summary description for DMCR100
    /// </summary>
    public partial class DMCR100 : BOSERPScreen
    {

        public DMCR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnChooseOwingInvoices_Click(object sender, EventArgs e)
        {
            ((CustomerRepaidModule)Module).ChooseOwingInvoices();
        }

        private void fld_txtARCustomerPaymentTotalAmount_Validated(object sender, EventArgs e)
        {
            ((CustomerRepaidModule)Module).ChangeTotalAmount();
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerRepaidModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerRepaidModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_CSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerRepaidModule)Module).ChangeCashFund(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ARCustomerID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerRepaidModule)Module).ChangeCustomer(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CustomerRepaidModule)Module).ChangeObject(e.Value.ToString());
            }
        }
    }
}
