using BOSComponent;
using System;

namespace BOSERP.Modules.ReceiptVoucher.UI
{
    /// <summary>
    /// Summary description for DMRCVC100
    /// </summary>
    public partial class DMRCVC100 : BOSERPScreen
    {

        public DMRCVC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ReceiptVoucherModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ReceiptVoucherModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_CSCashFundID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ReceiptVoucherModule)Module).ChangeCashFund(Convert.ToInt32(e.Value));
            }
        }

        private void fld_medARReceiptVoucherDesc_Validated(object sender, EventArgs e)
        {
            ((ReceiptVoucherModule)Module).UpdateItemDesc();
        }

        private void fld_txtARReceiptVoucherExchangeRate_Validated(object sender, EventArgs e)
        {
            ((ReceiptVoucherModule)Module).ChangeExchangeRate();
        }
    }
}
