using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS100
    /// </summary>
    public partial class DMCS100 : BOSERPScreen
    {

        public DMCS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSaveCompanyProfile_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveCompanyProfile();
        }
    }
}
