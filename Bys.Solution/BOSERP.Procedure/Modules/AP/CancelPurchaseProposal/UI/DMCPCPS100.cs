using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseProposal.UI
{
    /// <summary>
    /// Summary description for DMCPCPS100
    /// </summary>
    public partial class DMCPCPS100 : BOSERPScreen
    {

        public DMCPCPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((CancelPurchaseProposalModule)Module).AddItemToCancelPurchaseProposalItemsList();
            }
        }

        private void fld_lkeFK_BRBranchID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((CancelPurchaseProposalModule)Module).ChangeBranch(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeAPCancelPurchaseProposalType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((CancelPurchaseProposalModule)Module).ChangeProposalType(e.Value.ToString());
            }
        }

        private void fld_lkeAPCancelPurchaseProposalAPTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            string inputType = e.Value == null ? string.Empty : e.Value.ToString();
            ((CancelPurchaseProposalModule)Module).ChangedInputType(inputType);
        }
    }
}
