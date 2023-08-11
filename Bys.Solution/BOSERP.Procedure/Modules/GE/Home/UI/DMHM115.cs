using BOSLib;
using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM115
    /// </summary>
    public partial class DMHM115 : BOSERPScreen
    {
        public DMHM115()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteHREmployeeFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteHREmployeeToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllEmployeeForHome();
        }
    }
}
