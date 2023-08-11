using System;

namespace BOSERP.Modules.Supplier.UI
{
    /// <summary>
    /// Summary description for DMSP101
    /// </summary>
    public partial class DMSP101 : BOSERPScreen
    {

        public DMSP101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnHistoryFilter_Click(object sender, EventArgs e)
        {
            ((SupplierModule)Module).ShowSupplierHistory();
        }
    }
}
