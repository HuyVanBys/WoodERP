using System;

namespace BOSERP.Modules.PurchaseOrder.UI
{
    /// <summary>
    /// Summary description for DMPO102
    /// </summary>
    public partial class DMPO102 : BOSERPScreen
    {

        public DMPO102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).InvalidateReportList();
        }
    }
}
