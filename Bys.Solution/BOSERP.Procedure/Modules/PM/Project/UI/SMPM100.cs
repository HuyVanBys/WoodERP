using System;

namespace BOSERP.Modules.Project.UI
{
    /// <summary>
    /// Summary description for SMPM100
    /// </summary>
    public partial class SMPM100 : BOSERPScreen
    {

        public SMPM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnReset_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }
    }
}
