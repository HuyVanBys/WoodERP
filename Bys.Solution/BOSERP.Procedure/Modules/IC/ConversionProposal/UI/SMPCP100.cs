using System;

namespace BOSERP.Modules.ConversionProposal.UI
{
    /// <summary>
    /// Summary description for SMTS100
    /// </summary>
    public partial class SMPCP100 : BOSERPScreen
    {

        public SMPCP100()
        {
            InitializeComponent();
        }

        private void fld_btnButton_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }
    }
}
