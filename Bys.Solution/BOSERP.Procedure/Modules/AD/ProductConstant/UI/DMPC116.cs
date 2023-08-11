using System;

namespace BOSERP.Modules.ProductConstant.UI
{
    /// <summary>
    /// Summary description for DMPC101
    /// </summary>
    public partial class DMPC116 : BOSERPScreen
    {

        public DMPC116()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSaveMMProductionCompletionTimeConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveProductionCompletionTimeConfig();
        }

        private void fld_btnMMExecuteTimeConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveExecuteTimes();
        }

        private void fld_btnMMDepartmentAndOperations_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveDepartmentAndOperationList();
        }

        private void fld_btnSaveMMDepartmentCapacityConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveDepartmentCapacityConfigList();
        }

        private void fld_btnMMProductGroupTypeSwitchingConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveProductGroupTypeSwitchingConfigList();
        }
    }
}
