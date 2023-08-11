using BOSComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EmployeeSchedule.UI
{
    public partial class guiSearchEmployee : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the employee list
        /// </summary>
        private List<HREmployeesInfo> EmployeeList;

        /// <summary>
        /// Gets or sets the selected employees
        /// </summary>
        public List<HREmployeesInfo> SelectedEmployeeList { get; set; }

        public int guiEmployeePayrollFormulaID;
        public guiSearchEmployee()
        {
            InitializeComponent();

            SelectedEmployeeList = new List<HREmployeesInfo>();
        }

        public guiSearchEmployee(List<HREmployeesInfo> selectedEmployees)
        {
            InitializeComponent();

            SelectedEmployeeList = selectedEmployees;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiSearchEmployee_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            //fld_lkeHREmployeeStatus.EditValue = EmployeeStatus.Working.ToString();
            // GetDataSouce();
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (HREmployeesInfo objEmployeesInfo in EmployeeList)
            {
                objEmployeesInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcHREmployees.RefreshDataSource();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            SelectedEmployeeList = EmployeeList.Where(emp => emp.Selected == true).ToList();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSouce();
        }

        /// <summary>
        /// Gets the data souce for employee grid control 
        /// </summary>
        public void GetDataSouce()
        {

            int departmentRoomID = 0;
            int deparmentID = 0;
            int branchID = 0;
            int employeePayrollFormulaID = 0;

            if (fld_lkeHRDepartmentRooms.EditValue != null && fld_lkeHRDepartmentRooms.EditValue != "")
                departmentRoomID = int.Parse(fld_lkeHRDepartmentRooms.EditValue.ToString());
            if (fld_lkeHRDepartment.EditValue != null && fld_lkeHRDepartment.EditValue != "")
                deparmentID = int.Parse(fld_lkeHRDepartment.EditValue.ToString());
            if (fld_lkeHRBranch.EditValue != null && fld_lkeHRBranch.EditValue != "")
                branchID = int.Parse(fld_lkeHRBranch.EditValue.ToString());
            if (fld_lkeHREmployeePayrollFormula.EditValue != null && fld_lkeHREmployeePayrollFormula.EditValue != "")
                employeePayrollFormulaID = int.Parse(fld_lkeHREmployeePayrollFormula.EditValue.ToString());

            addEmployeeToList(departmentRoomID, deparmentID, branchID, employeePayrollFormulaID);

            fld_dgcHREmployees.DataSource = EmployeeList;

        }

        private void fld_lkeHREmployeeID_KeyUp(object sender, KeyEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.KeyCode == Keys.Enter)
            {
                int employeeID = Convert.ToInt32(lke.EditValue);
                HREmployeesInfo objEmployeesInfo = EmployeeList.Where(emp => emp.HREmployeeID == employeeID).FirstOrDefault();
                if (objEmployeesInfo != null)
                {
                    objEmployeesInfo.Selected = true;
                }
                fld_dgcHREmployees.RefreshDataSource();
            }
        }

        public void addEmployeeToList(int departmentRoomID, int deparmentID, int branchID, int employeePayrollFormulaID)
        {

            guiEmployeePayrollFormulaID = employeePayrollFormulaID;
            HREmployeesController objEmployeeController = new HREmployeesController();

            EmployeeList = (List<HREmployeesInfo>)objEmployeeController.GetAllEmployees();

            if (branchID != 0)
            {
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (EmployeeList.ToArray()[i].FK_BRBranchID != branchID)
                    {
                        EmployeeList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (deparmentID != 0)
            {
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (EmployeeList.ToArray()[i].FK_HRDepartmentID != deparmentID)
                    {
                        EmployeeList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (departmentRoomID != 0)
            {
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (EmployeeList.ToArray()[i].FK_HRDepartmentRoomID != departmentRoomID)
                    {
                        EmployeeList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (employeePayrollFormulaID != 0)

                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (EmployeeList.ToArray()[i].FK_HREmployeePayrollFormulaID != employeePayrollFormulaID)
                    {
                        EmployeeList.RemoveAt(i);
                        i--;
                    }
                }


        }


    }
}
