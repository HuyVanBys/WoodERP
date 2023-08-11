using System;
using System.Windows.Forms;

namespace BOSERP.Modules.EmployeeLeaveCalculate.UI
{
    /// <summary>
    /// Summary description for DMELC100
    /// </summary>
    public partial class DMELC100 : BOSERPScreen
    {

        public DMELC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            ((EmployeeLeaveCalculateModule)Module).SearchEmployeeLReg();
        }

        public override void AddExtraControls(Control.ControlCollection controls)
        {

        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
        }

        private void fld_dteSearchFromDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void fld_dteSearchFromDate_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void fld_btnCalculate_Click(object sender, EventArgs e)
        {
            ((EmployeeLeaveCalculateModule)Module).CalculateEmployeeLeave_Click();
        }

        private void fld_btnRemove_Click(object sender, EventArgs e)
        {
            ((EmployeeLeaveCalculateModule)Module).RemoveEmployeeLRegs_Click();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((EmployeeLeaveCalculateModule)Module).SaveLeaveDays();
        }
    }
}
