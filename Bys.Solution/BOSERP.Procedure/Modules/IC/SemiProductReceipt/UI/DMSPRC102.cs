using System;

namespace BOSERP.Modules.SemiProductReceipt.UI
{
    /// <summary>
    /// Summary description for DMSPRC102
    /// </summary>
    public partial class DMSPRC102 : BOSERPScreen
    {

        public DMSPRC102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).InvalidateReportList();
        }
    }
}
