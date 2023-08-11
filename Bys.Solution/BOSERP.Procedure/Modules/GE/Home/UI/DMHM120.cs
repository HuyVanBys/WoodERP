using BOSLib;
using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM119
    /// </summary>
    public partial class DMHM120 : BOSERPScreen
    {
        public DMHM120()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dtePaymentProposalFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dtePaymentProposalToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllPaymentProposalForHome();
        }
    }
}
