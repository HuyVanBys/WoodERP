using System;

namespace BOSERP.Modules.TransferPlan.UI
{
    public partial class DMTFP100 : BOSERPScreen
    {

        public DMTFP100()
        {
            InitializeComponent();
        }

        private void fld_btnDistributionTruck_Click(object sender, EventArgs e)
        {
            ((TransferPlanModule)Module).AddDeliveryPlanTrucksList();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((TransferPlanModule)Module).AddProduct();
        }

        private void fld_btnAttributionItemTruck_Click(object sender, EventArgs e)
        {
            ((TransferPlanModule)Module).AttributionItemTruck();
        }

        private void fld_btnAttributionSaleOrderTruck_Click(object sender, EventArgs e)
        {
            ((TransferPlanModule)Module).AttributionForTruck();
        }

        private void fld_dteARDeliveryPlanBeginDate_Validated(object sender, EventArgs e)
        {
            ((TransferPlanModule)Module).ChangeDeliveryPlanBeginDate();
        }
    }
}
