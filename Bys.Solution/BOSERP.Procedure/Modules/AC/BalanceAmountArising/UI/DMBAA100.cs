using System;

namespace BOSERP.Modules.BalanceAmountArising.UI
{
    /// <summary>
    /// Summary description for DMBAA100
    /// </summary>
    public partial class DMBAA100 : BOSERPScreen
    {

        public DMBAA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((BalanceAmountArisingModule)Module).GetData(fld_dteACBalanceAmountArisingFromDate.DateTime, fld_dteACBalanceAmountArisingToDate.DateTime);
        }
    }
}
