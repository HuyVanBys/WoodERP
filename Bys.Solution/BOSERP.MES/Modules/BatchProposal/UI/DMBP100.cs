using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProposal.UI
{
    /// <summary>
    /// Summary description for DMBM100
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
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
                if (productID > 0)
                    ((BatchProposalModule)Module).AddItemToProposalItemsList(productID);
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchProposalModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_dteMMProposalSaleOrderDeliveryDate_Validated(object sender, EventArgs e)
        {
            ((BatchProposalModule)Module).UpdateProposalSaleOrderDeliveryDate();
        }
    }
}
