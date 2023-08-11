using BOSLib;
using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM114
    /// </summary>
    public partial class DMHM118 : BOSERPScreen
    {

        public DMHM118()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteAllocationPlansFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteAllocationPlansToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllocationPlansForHome();
        }
    }
}
