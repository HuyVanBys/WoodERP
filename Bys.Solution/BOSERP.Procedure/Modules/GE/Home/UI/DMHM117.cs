using BOSLib;
using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM114
    /// </summary>
    public partial class DMHM117 : BOSERPScreen
    {

        public DMHM117()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteTransferProposalFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteTransferProposalToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllTransferProposalForHome();
        }
    }
}
