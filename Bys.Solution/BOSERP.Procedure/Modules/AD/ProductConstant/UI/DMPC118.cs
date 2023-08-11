using System;

namespace BOSERP.Modules.ProductConstant.UI
{
    /// <summary>
    /// Summary description for DMPC118
    /// </summary>
    public partial class DMPC118 : BOSERPScreen
    {

        public DMPC118()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSaveMMProductionCompletionTimeConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveAllocationOperationConfig();
        }

        private void fld_btnSaveBomChangeRate_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveBomChangeRate();
        }

        private void fld_btnSaveConfigProductionComplexity_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveConfigProductionComplexity();
        }

        private void fld_btnSaveMMConfigMaterialShipmentUtilitys_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveConfigMaterialShipmentUtility();
        }

        private void fld_btnSaveMMDefaultAllocationOperationConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveDefaultAllocationOperationConfig();
        }
    }
}
