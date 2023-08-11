using System;

namespace BOSERP.Modules.OutsourcingReceipt.UI
{
    /// <summary>
    /// Summary description for SMOR100
    /// </summary>
    public partial class SMOR100 : BOSERPScreen
    {

        public SMOR100()
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

        private void SMOR100_Load(object sender, EventArgs e)
        {

        }
    }
}
