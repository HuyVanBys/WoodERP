using System;

namespace BOSERP.Modules.ProductionCost.UI
{
    /// <summary>
    /// Summary description for DMPDC100
    /// </summary>
    public partial class DMPDC100 : BOSERPScreen
    {

        public DMPDC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnRefresh_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ValidateProductionCostByDate(true);
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ApplyProductPriceAllOperation();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).AdjustCostOfGoodsSold();
        }
    }
}
