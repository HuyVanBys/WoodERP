using System;

namespace BOSERP.Modules.ContainerLoader.UI
{
    /// <summary>
    /// Summary description for DMCL100
    /// </summary>
    public partial class DMCL100 : BOSERPScreen
    {

        public DMCL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnChooseFromPlan_Click(object sender, EventArgs e)
        {
            ((ContainerLoaderModule)Module).ShownProductionPlan();
        }
    }
}
