using System;

namespace BOSERP.Modules.EmloyeePayRollFormula.UI
{
    /// <summary>
    /// Summary description for DMEPRF100
    /// </summary>
    public partial class DMEPRF100 : BOSERPScreen
    {

        public DMEPRF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeHREmployeePayrollFormulaCalculation_Validated(object sender, EventArgs e)
        {
            if (fld_lkeHREmployeePayrollFormulaCalculation.EditValue != null)
            {
                ((EmloyeePayRollFormulaModule)Module).ChangeCalculationType(fld_lkeHREmployeePayrollFormulaCalculation.EditValue.ToString());
            }
        }

        private void btnCalculatorBreakTime_Click(object sender, EventArgs e)
        {
            ((EmloyeePayRollFormulaModule)Module).CalculatorBreakTime();
        }
    }
}
