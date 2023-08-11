using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
namespace BOSERP.Modules.ConversionProposal.UI
{
    /// <summary>
    /// Summary description for DMTS100
    /// </summary>
    public partial class DMPCP100 : BOSERPScreen
    {
        public DMPCP100()
        {
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((ConversionProposalModule)Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ConversionProposalModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ConversionProposalModule)Module).AddItemToTransferItemsList();
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((ConversionProposalModule)Module).ShownInventoryStocks(true);
        }

        private void fld_lkeFK_ICProductID_QueryCloseUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;

            lke.Properties.DataSource = BOSApp.CurrentProductList;
        }
    }
}
