using System;

namespace BOSERP.Modules.DataExchange.UI
{
    /// <summary>
    /// Summary description for DMDE100
    /// </summary>
    public partial class DMDE100 : BOSERPScreen
    {

        public DMDE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnUpdateHistory_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).RefreshPostingHistory();
        }

        private void fld_btnTransferPreferencesToBranch_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferCompanyPreferences();
        }

        private void fld_btnTransferInventoryToBranch_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferInventory();
        }

        private void fld_btnTransferCustomerToBranch_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferCustomers();
        }

        private void fld_btnTransferEmployeeToBranch_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferStaffs();
        }

        private void fld_btnTransferAccountingDataToBranch_Click(object sender, EventArgs e)
        {
            ((DataExchangeModule)Module).TransferTransactionData();
        }
    }
}
