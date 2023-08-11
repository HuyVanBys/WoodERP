using System;

namespace BOSERP.Modules.Shipment.UI
{
    /// <summary>
    /// Summary description for DMSH102
    /// </summary>
    public partial class DMSH102 : BOSERPScreen
    {

        public DMSH102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ((ShipmentModule)Module).InvalidateReportList();
        }
    }
}
