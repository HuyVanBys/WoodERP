using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt.UI
{
    /// <summary>
    /// Summary description for DMOR100
    /// </summary>
    public partial class DMOR100 : BOSERPScreen
    {

        public DMOR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtICReceiptShippingExtraFees_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)this.Module).ChangeFee();
        }

        private void fld_txtICReceiptDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtICReceiptDiscountFix_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtICReceiptShippingFees_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangeFee();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((OutsourcingReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_txtICReceiptTaxPercent_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangeTaxPercent();
        }

        private void fld_txtICReceiptTaxAmount_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((OutsourcingReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OutsourcingReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangePackNo();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((OutsourcingReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }

        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((OutsourcingReceiptModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((OutsourcingReceiptModule)Module).ChangeExchangeRate();
        }
    }
}
