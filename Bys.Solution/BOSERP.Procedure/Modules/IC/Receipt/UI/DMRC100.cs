using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Receipt.UI
{
    /// <summary>
    /// Summary description for DMRC100
    /// </summary>
    public partial class DMRC100 : BOSERPScreen
    {

        public DMRC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.Receipt.ReceiptModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }



        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((ReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((ReceiptModule)Module).ChangeExchangeRate();
        }

        private void Fld_lkeICReceiptReceiptType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ReceiptModule)Module).ChangeReceiptReceiptType(e.Value.ToString());
            }
        }

        private void fld_btnExportTemplate_Click(object sender, EventArgs e)
        {
            ((ReceiptModule)Module).ExportReceiptItemTemplate();
        }

        private void fld_btnImportTemplate_Click(object sender, EventArgs e)
        {
            ((ReceiptModule)Module).ImportReceiptItemExcel();
        }
    }
}
