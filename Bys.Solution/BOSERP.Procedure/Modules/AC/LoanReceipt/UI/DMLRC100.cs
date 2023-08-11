using System;
using BOSComponent;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace BOSERP.Modules.LoanReceipt.UI
{
    /// <summary>
    /// Summary description for DMLRC100
    /// </summary>
    public partial class DMLRC100 : BOSERPScreen
    {

        public DMLRC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtACLoanReceiptAmount_Validated(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Module).ChangeExchangeAmount();
        }

        private void fld_txtACLoanReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Module).ChangeExchangeAmount();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((LoanReceiptModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_lkeFK_ACLoanAgreementID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int acLoanAgreementID = 0;
                if (int.TryParse(e.Value.ToString(), out acLoanAgreementID))
                {
                    ((LoanReceiptModule)Module).ChangeLoanAgreementID(acLoanAgreementID);
                }
            }
        }

        private void fld_btnCreatePaymentPlans_Click(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Module).GenarateLoanReceiptPaymentPlans();
            ((LoanReceiptModule)Module).InvalidateNumberFormat();
        }

        private void fld_lkeACLoanReceiptProfitMethod_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((LoanReceiptModule)Module).InvalidatePaymentForMonth(e.Value.ToString());
        }

        private void fld_btnACDocument_Click(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Module).ShowDocuments();
        }

        private void fld_lkeFK_ACLoanAgreementID_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACLoanAgreementsController unController = new ACLoanAgreementsController();
            List<ACLoanAgreementsInfo> coList = unController.GetDataByDateAndRemainAmount();
            lookUpEdit.Properties.DataSource = coList;
        }

        private void fld_dteACLoanReceiptDate_Validated(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Module).UpdateLoanReceiptDeadline();
        }

        private void fld_txtACLoanReceiptLimit_Validated(object sender, EventArgs e)
        {
            ((LoanReceiptModule)Module).UpdateLoanReceiptDeadline();
        }

        private void fld_txtACLoanReceiptExchangeAmount_Validated(object sender, EventArgs e)
        {
            BOSTextBox edit = (BOSTextBox)sender;
            if (edit != null && edit.OldEditValue != null)
            {
                bool check = ((LoanReceiptModule)Module).ChangeLoanReceiptExchangeAmount();
                if (!check)
                {
                    edit.ErrorText = "Số tiền quy đổi lệch quá nhiều so với tính toán theo Tỷ giá";
                    edit.ErrorImageOptions.Alignment = ErrorIconAlignment.MiddleRight;
                }
            }
        }
    }
}