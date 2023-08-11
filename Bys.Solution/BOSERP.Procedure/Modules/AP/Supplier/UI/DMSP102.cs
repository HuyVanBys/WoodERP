using System;

namespace BOSERP.Modules.Supplier.UI
{
    /// <summary>
    /// Summary description for DMSP102
    /// </summary>
    public partial class DMSP102 : BOSERPScreen
    {

        public DMSP102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnOwingFilter_Click(object sender, EventArgs e)
        {
            ((SupplierModule)Module).ShowSupplierOwing();
        }

        private void fld_btnTakePayment_Click(object sender, EventArgs e)
        {
            ((SupplierModule)Module).TakePayment();
        }
    }
}
