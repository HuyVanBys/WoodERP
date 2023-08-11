using System;

namespace BOSERP.Modules.DataExchange.UI
{
    /// <summary>
    /// Summary description for DMDE101
    /// </summary>
    public partial class DMDE101 : BOSERPScreen
    {

        public DMDE101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnTransferCustomerToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferCustomersFromBranchToCentre(sender);
        }

        private void fld_btnTransferInventoryToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferInventoryFromBranchToCentre(sender);
        }

        private void fld_btnTransferSaleDataToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferSaleDataFromBranchToCentre(sender);
        }

        private void fld_btnTransferPurchaseDataToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferPurchaseDataFromBranchToCentre(sender);
        }

        private void fld_btnTransferAccountingDataToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferAccountingDataFromBranchToCentre(sender);
        }

        private void fld_btnTransferStaffToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferHumanResourceDataToCentre(sender);
        }

        private void fld_btnTransferAccountInitDataToCentre_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferAccountInitDataToCentre(sender);
        }

        private void fld_btnUpdateRegionalPostingHistory_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).RefreshRegionalPostingHistory();
        }
    }
}
