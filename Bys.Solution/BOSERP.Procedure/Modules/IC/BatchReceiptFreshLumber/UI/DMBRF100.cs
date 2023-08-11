using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptFreshLumber.UI
{
    /// <summary>
    /// Summary description for DMBRF100
    /// </summary>
    public partial class DMBRF100 : BOSERPScreen
    {

        public DMBRF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchReceiptFreshLumberModule)Module).AdditemtoItemRecceipt();
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((BatchReceiptFreshLumberModule)Module).ChangePackNo();
        }

        private void fld_btnShowItem_Click(object sender, EventArgs e)
        {
            ((BatchReceiptFreshLumberModule)Module).ShowItem();
        }

        private void fld_lkeFK_ICProductAttributeTTMTID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchReceiptFreshLumberModule)Module).UpdateTTMT(int.Parse(fld_lkeFK_ICProductAttributeTTMTID.EditValue.ToString()));
        }

        private void fld_lkeFK_MMOperationID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchReceiptFreshLumberModule)Module).UpdateOperation(int.Parse(fld_lkeFK_MMOperationID.EditValue.ToString()));
        }

        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchReceiptFreshLumberModule)Module).UpdateBatchProductID(int.Parse(fld_lkeFK_MMBatchProductID.EditValue.ToString()));
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((BatchReceiptFreshLumberModule)Module).ChangeGECurrency(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                int stock = 0;
                int.TryParse(e.Value.ToString(), out stock);
                ((BatchReceiptFreshLumberModule)Module).ChangeStock(stock);
            }
        }
    }
}
