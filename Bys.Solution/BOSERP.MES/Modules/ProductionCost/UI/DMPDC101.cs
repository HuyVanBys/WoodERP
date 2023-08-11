using System;

namespace BOSERP.Modules.ProductionCost.UI
{
    /// <summary>
    /// Summary description for DMPDC101
    /// </summary>
    public partial class DMPDC101 : BOSERPScreen
    {

        public DMPDC101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnApplyPrice_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecCostOprationPhoi(true);
        }

        private void fld_btnApplyPriceSC_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecCostOprationSC(true);
        }

        private void fld_btnApplyPriceTC_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecCostOprationTC(true);
        }

        private void fld_btnApplyPriceSon_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecCostOprationSon(true);
        }

        private void fld_btnApplyPriceLR_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecCostOprationLR(true);
        }

        private void fld_btnApplyPriceDG_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecCostOprationDG(true);
        }
        private void fld_btnUpdatePricePhoi_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecUpdateCostOprationPhoi();
        }

        private void fld_btnUpdatePriceSC_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecUpdateCostOprationSC();
        }

        private void fld_btnUpdatePriceTC_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecUpdateCostOprationTC();
        }

        private void fld_btnUpdatePriceLR_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecUpdateCostOprationLR();
        }

        private void fld_btnUpdatePriceSon_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecUpdateCostOprationSon();
        }

        private void bosButton6_Click(object sender, EventArgs e)
        {
            ((ProductionCostModule)Module).ExecUpdateCostOprationDG();
        }
    }
}
