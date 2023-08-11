using System;

namespace BOSERP.Modules.AllocationEquipment.UI
{
    /// <summary>
    /// Summary description for SMAE100
    /// </summary>
    public partial class SMAE100 : BOSERPScreen
    {

        public SMAE100()
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
