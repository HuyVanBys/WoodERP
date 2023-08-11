using BOSComponent;
using System;

namespace BOSERP.Modules.FeePayment.UI
{
    /// <summary>
    /// Summary description for DMFP100
    /// </summary>
    public partial class DMFP100 : BOSERPScreen
    {

        public DMFP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnChooseReceipts_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChooseReceipts();
            ((FeePaymentModule)Module).PBAccount();
        }



        private void bosTextBox1_TextChanged(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).PBAccount();
        }

        private void fld_txtACDocumentExchangeRate_EditValueChanged(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChangeExchangeRate();
        }



        private void bosButton3_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChoosePurchaseOrders();
            ((FeePaymentModule)Module).PBAccount();
        }

        private void bosLookupEdit8_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((FeePaymentModule)Module).updateTotalAmountbyCurrecy();
        }

        private void bosButton4_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChooseDryLumberReceipts();
            ((FeePaymentModule)Module).PBAccount();
        }

        private void fld_btnChooseInvoiceIn_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).AddInvoiceIn();
        }

        private void fld_tcDetail_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ((FeePaymentModule)Module).FocusTabName = fld_tcDetail.SelectedTabPage.Name;
        }

        private void fld_lkeFK_ACObjectID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((FeePaymentModule)Module).ChangeObject();
        }

        private void fld_btnChooseTransfer_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChooseTransfer();
            ((FeePaymentModule)Module).PBTransferAccount();
        }

        private void bosButton4_Click_1(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChooseTransfer();
            ((FeePaymentModule)Module).PBTransferAccount();
        }

        private void bosButton5_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).ChooseInvoiceInternalReceipts();
            ((FeePaymentModule)Module).PBInvoiceInternalReceiptAccount();
        }

        private void bosButton6_Click(object sender, EventArgs e)
        {
            ((FeePaymentModule)Module).AddInvoice();
        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((FeePaymentModule)Module).ChangeProject(projectID);
                }
            }
        }

        private void fld_lkeACDocumentAllocationCriteria_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((FeePaymentModule)Module).ChangeDocumentAllocationCriteria(e.Value.ToString());
            }
        }

    }
}
