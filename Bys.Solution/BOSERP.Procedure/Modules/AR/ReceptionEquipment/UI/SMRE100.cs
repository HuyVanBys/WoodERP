using System;

namespace BOSERP.Modules.ReceptionEquipment.UI
{
    /// <summary>
    /// Summary description for SMRE100
    /// </summary>
    public partial class SMRE100 : BOSERPScreen
    {

        public SMRE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnButton_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)this.Module).ResetSearchObject();
        }
    }
}
