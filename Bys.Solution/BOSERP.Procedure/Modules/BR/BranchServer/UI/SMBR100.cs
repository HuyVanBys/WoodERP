using System;

namespace BOSERP.Modules.Branch.UI
{
    /// <summary>
    /// Summary description for SMBR100
    /// </summary>
    public partial class SMBR100 : BOSERPScreen
    {

        public SMBR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnButton1_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }

    }
}
