using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS108
    /// </summary>
    public partial class DMCS108 : BOSERPScreen
    {

        public DMCS108()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnButton_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveCustomerConfig();
        }

        private void fld_btnSaveCustomerAccountConfig_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveCustomerAccountConfig();
        }

        private void fld_btnSaveSupplierAccountConfig_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveSupplierAccountConfig();
        }

        private void fld_btnSaveProductAccountConfig_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveProductAccountConfig();
        }

        private void fld_btnACAssetTypeAccountConfigs_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveAssetAccountConfig();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveAssetDepreciationConfig();
        }

        private void fld_btnACEquipmentTypeAccountConfigs_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveEquipmentDepreciationConfig();
        }

        private void fld_btnSaveACLoanReceiptTypes_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveLoanReceiptType();
        }

        private void fld_btnACEquipmentStates_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveEquipmentState();
        }
    }
}
