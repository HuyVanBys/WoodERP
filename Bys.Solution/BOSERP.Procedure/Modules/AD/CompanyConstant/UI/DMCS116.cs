using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS116
    /// </summary>
    public partial class DMCS116 : BOSERPScreen
    {

        public DMCS116()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSaveCompletePermissionConfigs_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Module).SaveCompletePermissionConfig();
        }
    }
}
