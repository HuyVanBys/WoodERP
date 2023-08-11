using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS118
    /// </summary>
    public partial class DMCS118 : BOSERPScreen
    {
        public DMCS118()
        {
            InitializeComponent();
        }

        private void fld_btnSaveSalaryDocumentType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveSalaryDocumentType();
        }

        private void fld_btnSaveSalaryEntryType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveSalaryEntryType();
        }
    }
}
