using System;

namespace BOSERP.Modules.Receipt.UI
{
    /// <summary>
    /// Summary description for DMRC102
    /// </summary>
    public partial class DMRC102 : BOSERPScreen
    {

        public DMRC102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ((ReceiptModule)Module).InvalidateReportList();
        }
    }
}
