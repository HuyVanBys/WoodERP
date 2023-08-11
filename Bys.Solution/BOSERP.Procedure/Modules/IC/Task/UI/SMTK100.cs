using System;

namespace BOSERP.Modules.Task.UI
{
    /// <summary>
    /// Summary description for SMTK100
    /// </summary>
    public partial class SMTK100 : BOSERPScreen
    {

        public SMTK100()
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
