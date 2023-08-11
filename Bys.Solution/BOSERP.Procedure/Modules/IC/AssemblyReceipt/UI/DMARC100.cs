using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AssemblyReceipt.UI
{
    /// <summary>
    /// Summary description for DMARC100
    /// </summary>
    public partial class DMARC100 : BOSERPScreen
    {

        public DMARC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((AssemblyReceiptModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssemblyReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((AssemblyReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }



        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((AssemblyReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((AssemblyReceiptModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((AssemblyReceiptModule)Module).ChangePackNo();
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((AssemblyReceiptModule)Module).ChangeExchangeRate();
        }
    }
}
