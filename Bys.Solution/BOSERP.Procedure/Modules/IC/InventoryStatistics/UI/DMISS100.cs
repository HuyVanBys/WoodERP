using System;

namespace BOSERP.Modules.InventoryStatistics.UI
{
    /// <summary>
    /// Summary description for DMISS100
    /// </summary>
    public partial class DMISS100 : BOSERPScreen
    {
        public DMISS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnInventoryStattistics_Click(object sender, EventArgs e)
        {
            ((Modules.InventoryStatistics.InventoryStatisticsModule)this.Module).InventoryStatistics();
        }

        private void Fld_btnPrint_Click(object sender, EventArgs e)
        {
            ((Modules.InventoryStatistics.InventoryStatisticsModule)this.Module).PrintClick();
        }
    }
}
