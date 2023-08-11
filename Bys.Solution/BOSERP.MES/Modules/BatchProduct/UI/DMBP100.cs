using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct.UI
{
    /// <summary>
    /// Summary description for DMBP100
    /// </summary>
    public partial class DMBP100 : BOSERPScreen
    {

        public DMBP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchProductModule)Module).AddItemToBatchProductItemsList(0, 0, DateTime.Now, new MMProposalItemsInfo());
            }
        }

        private void fld_dteMMBatchProductDeliveryDate_EditValueChanged(object sender, EventArgs e)
        {
            //((BatchProductModule)Module).CheckDeliveryDate();
        }

        private void fld_lkeMMBatchProductResourceType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchProductModule)Module).ChangeResourceType(e.Value.ToString());
            }
        }

        private void Fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchProductModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICProductAttributeTTMTID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int ttmtID = 0;
                Int32.TryParse(e.Value.ToString(), out ttmtID);
                ((BatchProductModule)Module).ChangeAttributeTTMT(ttmtID);
            }
        }

    }
}
