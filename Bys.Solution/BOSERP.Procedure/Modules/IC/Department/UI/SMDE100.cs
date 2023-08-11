using System;

namespace BOSERP.Modules.Department.UI
{
    /// <summary>
    /// Summary description for SMDE100
    /// </summary>
    public partial class SMDE100 : BOSERPScreen
    {

        public SMDE100()
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
