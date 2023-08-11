using System;

namespace BOSERP.Modules.InvoiceIn.UI
{
    /// <summary>
    /// Summary description for DMII102
    /// </summary>
    public partial class DMII102 : BOSERPScreen
    {

        public DMII102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).InvalidateReportList();
        }
    }
}
