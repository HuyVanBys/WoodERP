using BOSLib;
using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM114
    /// </summary>
    public partial class DMHM114 : BOSERPScreen
    {

        public DMHM114()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteBatchProposalFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteBatchProposalToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllBatchProposalForHome();
        }
    }
}
