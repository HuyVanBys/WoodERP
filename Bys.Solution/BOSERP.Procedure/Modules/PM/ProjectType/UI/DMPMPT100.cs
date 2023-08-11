using System;

namespace BOSERP.Modules.ProjectType.UI
{
    /// <summary>
    /// Summary description for DMDE100
    /// </summary>
    public partial class DMPMPT100 : BOSERPScreen
    {

        public DMPMPT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddPhaseType_Click(object sender, EventArgs e)
        {
            ((ProjectTypeModule)this.Module).AddPhaseTypeToGridview();
        }

        private void fld_btnEditPhaseType_Click(object sender, EventArgs e)
        {
            ((ProjectTypeModule)this.Module).EditPhaseTypeInGridview();
        }

        private void fld_btnDeletePhaseType_Click(object sender, EventArgs e)
        {
            ((ProjectTypeModule)this.Module).DeletePhaseTypeFromGridview();
        }
    }
}
