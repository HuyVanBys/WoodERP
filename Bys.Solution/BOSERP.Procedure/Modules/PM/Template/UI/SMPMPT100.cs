using System;

namespace BOSERP.Modules.Template.UI
{
    /// <summary>
    /// Summary description for SMDE100
    /// </summary>
    public partial class SMPMTP100 : BOSERPScreen
    {

        public SMPMTP100()
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
