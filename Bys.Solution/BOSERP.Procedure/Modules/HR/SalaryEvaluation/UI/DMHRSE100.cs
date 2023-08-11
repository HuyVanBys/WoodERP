using System;

namespace BOSERP.Modules.SalaryEvaluation.UI
{
    /// <summary>
    /// Summary description for DMHRSE100
    /// </summary>
    public partial class DMHRSE100 : BOSERPScreen
    {

        public DMHRSE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((SalaryEvaluationModule)Module).AddEmployeeToSalaryEvaluation();
        }
    }
}
