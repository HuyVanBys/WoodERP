using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS108
    /// </summary>
    public partial class DMCS122 : BOSERPScreen
    {

        public DMCS122()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnCommodityType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveCommodityType();
        }

        private void fld_btnCommodityGridControlTypeMapping_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveCommodityGridControlTypeMapping();
        }

        private void fld_btnCommodityProductTypeMapping_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveCommodityProductTypeMapping();
        }

        private void fld_btnProductTypeMapping_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveSaleOrderProductTypeMapping();
        }
    }
}
