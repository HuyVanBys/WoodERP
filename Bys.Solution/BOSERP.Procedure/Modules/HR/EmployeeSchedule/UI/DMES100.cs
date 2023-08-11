using System;

namespace BOSERP.Modules.EmployeeSchedule.UI
{
    /// <summary>
    /// Summary description for DMES100
    /// </summary>
    public partial class DMES100 : BOSERPScreen
    {

        public DMES100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }



        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            ((EmployeeScheduleModule)Module).ExportToExcel();
        }

        private void fld_lkeHREmployeePayrollFormulaID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_txtChooseFile_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_btnImportFromExcel_Click(object sender, EventArgs e)
        {
            ((EmployeeScheduleModule)Module).ImportCommissionFromExcel();
        }

        private void fld_txtChooseFile_Click(object sender, EventArgs e)
        {
            fld_txtChooseFile.Text = ((EmployeeScheduleModule)Module).ChooseFile();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((EmployeeScheduleModule)Module).AddEmployee();
        }

        private void fld_btnChooseFile_Click(object sender, EventArgs e)
        {
            fld_txtChooseFile.Text = ((EmployeeScheduleModule)Module).ChooseFile();
        }

        private void fld_btnEditinExcel_Click(object sender, EventArgs e)
        {
            ((EmployeeScheduleModule)Module).ExportToExcel();
        }
    }
}
