using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM112
    /// </summary>
    public partial class DMHM112 : BOSERPScreen
    {

        public DMHM112()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteARRemindFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteARRemindToDate.DateTime = BOSApp.GetCurrentServerDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllRemindForHome();
        }
    }
}
