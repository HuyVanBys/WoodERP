using System;

namespace BOSERP.Modules.HREvaluationEmployee.UI
{
    /// <summary>
    /// Summary description for DMHREE101
    /// </summary>
    public partial class DMHREE101 : BOSERPScreen
    {

        public DMHREE101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID2_Validated(object sender, EventArgs e)
        {
            ((HREvaluationEmployeeModule)Module).InvalidateEvaluationDetails();
        }

    }
}
