using BOSLib;
using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM119
    /// </summary>
    public partial class DMHM119 : BOSERPScreen
    {
        public DMHM119()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteLeaveApplicationFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteLeaveApplicationToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllLeaveApplicationForHome();
        }
    }
}
