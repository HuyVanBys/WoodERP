using System;

namespace BOSERP.Modules.KPIForm.UI
{
    /// <summary>
    /// Summary description for DMKPIF100
    /// </summary>
    public partial class DMKPIF100 : BOSERPScreen
    {

        public DMKPIF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShowKPI_Click(object sender, EventArgs e)
        {
            ((KPIFormModule)Module).AddItemToKPIForms();
        }
    }
}
