using System;
using BOSComponent;

namespace BOSERP.Modules.PaymentProposal.UI
{
    /// <summary>
    /// Summary description for DMPP100
    /// </summary>
    public partial class DMPP100 : BOSERPScreen
    {

        public DMPP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSelectPaymentTerm_Click(object sender, EventArgs e)
        {
            ((PaymentProposalModule)Module).GetPaymentTerm();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value == null)
            {
                if (!((PaymentProposalModule)Module).ChangeObject(string.Empty))
                {
                    e.Value = lke.OldEditValue.ToString();
                };
            }
            else if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (!((PaymentProposalModule)Module).ChangeObject(Convert.ToString(e.Value)))
                {
                    e.Value = lke.OldEditValue.ToString();
                };
            }
        }

        private void fld_btnAllocation_Click(object sender, EventArgs e)
        {
            decimal ProposalTotalAmount = 0;
            if (fld_txtAPPaymentProposalTotalAmount.EditValue != null)
                decimal.TryParse(fld_txtAPPaymentProposalTotalAmount.EditValue.ToString(), out ProposalTotalAmount);
            if (ProposalTotalAmount > 0)
                ((PaymentProposalModule)Module).AllocationProposalAmount(fld_cmbAllocationType.SelectedIndex, ProposalTotalAmount);
        }
		private void fld_linkViewApproval_Click(object sender, EventArgs e)
        {
            ((PaymentProposalModule)Module).ViewApprovalDetails();
        }

        private void fld_lkeFK_ACListAccountBankID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ((PaymentProposalModule)Module).GetListAccountBankForLookUpEditControl();
        }

        private void fld_lkeFK_ACListAccountBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PaymentProposalModule)Module).ChangeListAccountBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtAPPaymentProposalDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((PaymentProposalModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtAPPaymentProposalDiscountFix_Validated(object sender, EventArgs e)
        {
            ((PaymentProposalModule)Module).ChangeDiscountAmount();
        }

        private void fld_dteAPPaymentProposalPayDate_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            DateTime paymentProposalPayDate = DateTime.MaxValue;

            if (e.Value != null)
            {
                DateTime.TryParse(e.Value.ToString(), out paymentProposalPayDate);
            }

            if (paymentProposalPayDate.ToString() == DateTime.MaxValue.ToString())
            {
                e.DisplayText = null;
            }
        }
    }
}
