using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM100
    /// </summary>
    public partial class DMHM100 : BOSERPScreen
    {

        public DMHM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteSaleOrderFromDate.EditValue = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteSaleOrderToDate.EditValue = BOSApp.GetCurrentServerDate().AddDays(7);
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowPromptDeliverySaleOrder(fld_dteSaleOrderFromDate.EditValue as DateTime?, fld_dteSaleOrderToDate.EditValue as DateTime?);
        }
    }
}
