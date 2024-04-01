using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptDryLumber.UI
{
    /// <summary>
    /// Summary description for DMBRDL100
    /// </summary>
    public partial class DMBRDL100 : BOSERPScreen
    {

        public DMBRDL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_tabPageReceiptItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchReceiptDryLumberModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((BatchReceiptDryLumberModule)Module).ChangePackNo();
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((BatchReceiptDryLumberModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((BatchReceiptDryLumberModule)Module).ChangBatchProduct(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((BatchReceiptDryLumberModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
        }

        private void fld_lnkChooseProspectCustomer_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {

        }

        private void fld_lkeMMUpdatePositionItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

        }
    }
}
