using System;

namespace BOSERP.Modules.RevenueForecast.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMRF100 : BOSERPScreen
    {

        public DMRF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnLoadItem_Click(object sender, EventArgs e)
        {
            ((RevenueForecastModule)Module).LoadRevenueByCustomer();
        }

        private void fld_btnCalculatePredictRevenue_Click(object sender, EventArgs e)
        {
            ((RevenueForecastModule)Module).CalculatePredictRevenue();
        }

        private void fld_btnLoadRealRevenue_Click(object sender, EventArgs e)
        {
            ((RevenueForecastModule)Module).LoadRealityRevenue();
        }

        private void DMRF100_Load(object sender, EventArgs e)
        {
            //fld_dgcARRevenueForecastItems.MainView = ((RevenueForecastModule)Module).InitializeCustomerBandedGridView();
        }

        private void bosTextBox2_Validated(object sender, EventArgs e)
        {
            BOSComponent.BOSTextBox tb = (BOSComponent.BOSTextBox)sender;
            if (tb.OldEditValue != null && tb.OldEditValue != tb.EditValue)
            {
                ((RevenueForecastModule)Module).UpdateRevenueForecastRate();
            }         
        }

        private void fld_lkeRoundingNumber_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((RevenueForecastModule)Module).ChangingRoundingNumber(e.Value.ToString());
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((RevenueForecastModule)Module).ExportExcel();
        }
    }
}
