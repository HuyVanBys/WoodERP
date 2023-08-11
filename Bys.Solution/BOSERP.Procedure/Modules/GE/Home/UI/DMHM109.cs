using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM104
    /// </summary>
    public partial class DMHM109 : BOSERPScreen
    {

        public DMHM109()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteSaleOrderFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteSaleOrderToDate.DateTime = BOSApp.GetCurrentServerDate();
            fld_lkeARSaleOrderStatus.EditValue = "New";
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowSaleOrderFilterList();
        }
    }
}
