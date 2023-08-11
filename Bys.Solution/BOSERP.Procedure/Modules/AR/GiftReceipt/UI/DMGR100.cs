using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GiftReceipt.UI
{
    /// <summary>
    /// Summary description for DMGR100
    /// </summary>
    public partial class DMGR100 : BOSERPScreen
    {

        public DMGR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lblViewCustomer_Click(object sender, EventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtARInvoiceDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_btnComplete_Click(object sender, EventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).ActionComplete();
        }

        private void fld_txtARInvoiceDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.GiftReceipt.GiftReceiptModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((GiftReceiptModule)Module).AddItemToInvoiceItemList();
            }
        }
    }
}
