using System;

namespace BOSERP.Modules.AccountInitialBalance.UI
{
    /// <summary>
    /// Summary description for DMAIB100
    /// </summary>
    public partial class DMAIB100 : BOSERPScreen
    {

        public DMAIB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((AccountInitialBalanceModule)Module).SaveInitialBalanceAccount();
        }
    }
}
