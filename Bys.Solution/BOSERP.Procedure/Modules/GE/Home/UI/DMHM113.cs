using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM112
    /// </summary>
    public partial class DMHM113 : BOSERPScreen
    {

        public DMHM113()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteBatchProductFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteBatchProductToDate.DateTime = BOSApp.GetCurrentServerDate();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowAllBatchProductForHome();
        }
    }
}
