using BOSComponent;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.SupplierPayment.UI
{
    /// <summary>
    /// Summary description for DMAPSP100
    /// </summary>
    public partial class DMAPSP100 : BOSERPScreen
    {

        public DMAPSP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnInvoiceIn_Click(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).ShowOwingInvoiceIns(Convert.ToInt32(fld_lkeFK_ACObjectID.EditValue));
        }

        private void fld_txtAPPaymentVoucherTotalAmount_Validated(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).ChangeTotalAmount();
        }

        private void fld_txtAPSupplierPaymentAssExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).ChangeAssociatedExchangeInfo();
        }

        private void fld_lkeAPSupplierPaymentAssExchangeWay_Validated(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).ChangeAssociatedExchangeInfo();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPaymentModule)Module).ChangeCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GEAssCurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPaymentModule)Module).ChangeAssociatedCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_APAssociatedSupplierID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                //((SupplierPaymentModule)Module).ChangeDefaultDesc(Convert.ToInt32(e.Value));
            }
        }

        //private void fld_lkeFK_APSupplierID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        //{
        //    BOSLookupEdit lke = (BOSLookupEdit)sender;
        //    if (e.Value != null && e.Value != lke.OldEditValue)
        //    {
        //        ((SupplierPaymentModule)Module).ChangeSupplier(Convert.ToInt32(e.Value));
        //    }
        //}

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(Width, Height);
            }
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPaymentModule)Module).ChangeBank(Convert.ToInt32(e.Value));
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).NewFromPaymentProposal();
        }

        private void fld_lkeFK_GECurrencyID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((SupplierPaymentModule)Module).updateTotalAmountbyCurrecy();
        }

        private void fld_lkeFK_ACAssObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value == null)
            {
                ((SupplierPaymentModule)Module).ChangeAssObject(string.Empty);
            }
            else if (e.Value != lke.OldEditValue)
            {

                ((SupplierPaymentModule)Module).ChangeAssObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_CSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPaymentModule)Module).ChangeCashFund(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                string value = string.Empty;
                if (e.Value != null)
                {
                    value = e.Value.ToString();
                }
                if (!((SupplierPaymentModule)Module).ChangeObject(value))
                {
                    e.Value = lke.OldEditValue.ToString();
                };
            }
        }

        private void fld_lkeFK_ACAssObjectID_EditValueChanged(object sender, EventArgs e)
        {
            /*if (((SupplierPaymentModule)Module).CreatePaymentByIntermediatePaye)
            MessageBox.Show("thai đổi đối tuongj 2");*/
        }

        private void fld_txtAPSupplierPaymentExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).ChangeExchangeRate();
        }

        private void fld_lkeFK_ACListAccountBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPaymentModule)Module).ChangeListAccountBank(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACListAccountBankID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((SupplierPaymentModule)Module).GetDSForListAccountBankLookUpEditControl();
        }

        private void fld_lkeFK_ACLoanReceiptID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPaymentModule)Module).ChangeLoanReceipt(Convert.ToInt32(e.Value));
            }
        }
    }
}
