using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS108
    /// </summary>
    public partial class DMCSProductionCostConfig : BOSERPScreen
    {

        public DMCSProductionCostConfig()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }



        private void fld_btnSaveCustomerAccountConfig_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostFactorGroup();
        }

        private void fld_btnProductionCostCollectType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostCollectType();
        }

        private void fld_btnProductionCostAllocationType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostAllocationType();
        }

        private void fld_btnInProgressCalType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostInProgressCalType();
        }

        private void fld_btnSaveFactor_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostFactor();
        }

        private void fld_btnSaveAllocationRate_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostFactorAllocationRate();
        }

        private void fld_btnInProgressClassifyType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostInProgressClassifyType();
        }

        private void fld_btnSaveProductionCostLinkConfigsList_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductionCostLinkConfigsList();
        }


    }
}