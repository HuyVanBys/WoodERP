using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.LoanAgreement.UI
{
    /// <summary>
    /// Summary description for DMLAGM100
    /// </summary>
    public partial class DMLAGM100 : BOSERPScreen
    {

        public DMLAGM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((LoanAgreementModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_txtACLoanAgreementAmount_Validated(object sender, EventArgs e)
        {
            ((LoanAgreementModule)Module).UpdateLoanAgreementAmount();
        }

        private void fld_txtACLoanAgreementLCLimit_Validated(object sender, EventArgs e)
        {
            ((LoanAgreementModule)Module).UpdateLoanAgreementAmount();
        }
    }
}
