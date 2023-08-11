using System;

namespace BOSERP.Modules.ProductConstant.UI
{
    /// <summary>
    /// Summary description for DMPC101
    /// </summary>
    public partial class DMPC112 : BOSERPScreen
    {

        public DMPC112()
        {
            InitializeComponent();
        }

        private void fld_btnSaveCalMaterialConfigs_Click(object sender, EventArgs e)
        {
            ((ProductConstantModule)Module).SaveCalMaterialConfigs();
        }
    }
}
