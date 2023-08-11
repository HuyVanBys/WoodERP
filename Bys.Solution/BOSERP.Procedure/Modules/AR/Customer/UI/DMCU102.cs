using System;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU102
    /// </summary>
    public partial class DMCU102 : BOSERPScreen
    {

        public DMCU102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnFilter_Click(object sender, EventArgs e)
        {
            ((Modules.Customer.CustomerModule)this.Module).ShowOwingDetails();
        }
    }
}
