using System;

namespace BOSERP.Modules.InitializedInventoryStock.UI
{
    /// <summary>
    /// Summary description for DMIS100
    /// </summary>
    public partial class DMIS100 : BOSERPScreen
    {

        public DMIS100()
        {
            InitializeComponent();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((InitializedInventoryStockModule)Module).InitInventoryStocks();
        }

    }
}
