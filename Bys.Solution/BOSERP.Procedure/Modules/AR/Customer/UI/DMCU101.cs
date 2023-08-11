using System;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU101
    /// </summary>
    public partial class DMCU101 : BOSERPScreen
    {

        public DMCU101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnFilter_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).ShowCustomerHistory();
        }
    }
}
