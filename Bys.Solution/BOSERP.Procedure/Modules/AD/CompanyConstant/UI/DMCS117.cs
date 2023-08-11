using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS117
    /// </summary>
    public partial class DMCS117 : BOSERPScreen
    {

        public DMCS117()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSaveCompletePermissionConfigs_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Module).SaveObjectViewPermissionList();
        }

        private void fld_btnSaveDefaultDescConfigs_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Module).SaveDefaultDescConfigList();
        }
    }
}
