using System;

namespace BOSERP.Modules.ProductionCostWood.UI
{
    /// <summary>
    /// Summary description for DMPCW102
    /// </summary>
    public partial class DMPCW102 : BOSERPScreen
    {

        public DMPCW102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnApplyPrice_Click(object sender, EventArgs e)
        {
            ((ProductionCostWoodModule)Module).ApplyProductPriceNew();
        }

        private void fld_btnUpdateProductUnitCost_Click(object sender, EventArgs e)
        {
            ((ProductionCostWoodModule)Module).AdjustCostOfGoodsSold();
        }
    }
}
