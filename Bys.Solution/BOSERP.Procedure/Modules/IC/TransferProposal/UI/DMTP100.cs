using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferProposal.UI
{
    /// <summary>
    /// Summary description for DMTP100
    /// </summary>
    public partial class DMTP100 : BOSERPScreen
    {

        public DMTP100()
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
                ((TransferProposalModule)Module).AddItemToTransferProposalItemsList();
            }
        }

        private void fld_lkeFK_ICFromStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = 0;
                Int32.TryParse(e.Value.ToString(), out stockID);
                ((TransferProposalModule)Module).ChangeSourceStock(stockID);
            }
        }

        private void fld_lkeFK_ICToStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = 0;
                Int32.TryParse(e.Value.ToString(), out stockID);
                ((TransferProposalModule)Module).ChangeTargetStock(stockID);
            }
        }

        private void fld_dteValidDate_Validated(object sender, EventArgs e)
        {
            ((TransferProposalModule)Module).ChangeTransferProposalValiDate();
        }
    }
}
