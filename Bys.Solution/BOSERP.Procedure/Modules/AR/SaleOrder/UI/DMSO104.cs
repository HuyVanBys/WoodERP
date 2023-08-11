using System;

namespace BOSERP.Modules.SaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSO104
    /// </summary>
    public partial class DMSO104 : BOSERPScreen
    {

        public DMSO104()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnViewProfile_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)this.Module).InvalidateProfileManagement();
        }
    }
}
