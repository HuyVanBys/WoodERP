using System;

namespace BOSERP.Modules.ProductionCostWood.UI
{
    /// <summary>
    /// Summary description for DMPCW100
    /// </summary>
    public partial class DMPCW100 : BOSERPScreen
    {

        public DMPCW100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnRefresh_Click(object sender, EventArgs e)
        {
            ((ProductionCostWoodModule)Module).ValidateProductionCostByDate(true);
        }
    }
}
