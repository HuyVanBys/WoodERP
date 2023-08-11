using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM104
    /// </summary>
    public partial class DMHM110 : BOSERPScreen
    {

        public DMHM110()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dtePurchaseOrdersFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dtePurchaseOrderToDate.DateTime = BOSApp.GetCurrentServerDate();
            fld_lkeAPPurchaseOrderStatus.Enabled = true;
            fld_lkeAPPurchaseOrderStatus.EditValue = "New";
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowPurchaseOrderFilterList();
        }
    }
}
