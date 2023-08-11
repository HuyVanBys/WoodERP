using System;

namespace BOSERP.Modules.ProjectType.UI
{
    /// <summary>
    /// Summary description for SMDE100
    /// </summary>
    public partial class SMPMPT100 : BOSERPScreen
    {

        public SMPMPT100()
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
