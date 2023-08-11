using BOSCommon;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.HRReward.UI
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
        public DateTime EmployeeOTDate { get; set; }
        public DateTime EmployeeOTDateEnd { get; set; }
        public DateTime EmployeeOTFromDate { get; set; }
        public DateTime EmployeeOTToDate { get; set; }

        public string reWardType { get; set; }
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
            if (reWardType == RewardType.PNTL.ToString())
            {
                fld_lkeHREmployeeStatus.EditValue = EmployeeStatus.Resigned.ToString();
            }
            else
            {
                fld_lkeHREmployeeStatus.EditValue = EmployeeStatus.Working.ToString();
            }
            fld_lkeFK_HREmployeePayrollFormulaID.EditValue = 0;
            GetDataSouce();
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
            HREmployeesController objEmployeesController = new HREmployeesController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int DepartmentRoomGroupItemID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue);
            int EmployeePayrollFormulaID = Convert.ToInt32(fld_lkeFK_HREmployeePayrollFormulaID.EditValue);
            string status = Convert.ToString(fld_lkeHREmployeeStatus.EditValue);
            EmployeeList = objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, DepartmentRoomGroupItemID, status);
            if (EmployeeList != null)
            {
                if (DepartmentRoomGroupItemID > 0)
                {
                    EmployeeList = EmployeeList.Where(x => x.FK_HRDepartmentRoomGroupItemID == DepartmentRoomGroupItemID).ToList();
                }

                if (EmployeeList != null & EmployeePayrollFormulaID > 0)
                {
                    EmployeeList = EmployeeList.Where(x => x.FK_HREmployeePayrollFormulaID == EmployeePayrollFormulaID).ToList();
                }
            }
            if (EmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in EmployeeList)
                {
                    HREmployeesInfo objSelectedEmployeesInfo = SelectedEmployeeList.Where(emp => emp.HREmployeeID == objEmployeesInfo.HREmployeeID).FirstOrDefault();
                    if (objSelectedEmployeesInfo != null)
                    {
                        objEmployeesInfo.Selected = true;
                    }

                    objEmployeesInfo.HREmployeeOTDate = EmployeeOTDate;
                    objEmployeesInfo.HREmployeeOTDateEnd = EmployeeOTDateEnd;
                    objEmployeesInfo.HREmployeeOTFromDate = EmployeeOTFromDate;
                    objEmployeesInfo.HREmployeeOTToDate = EmployeeOTToDate;
                }
            }
            fld_dgcHREmployees.DataSource = EmployeeList;
            fld_lkeHREmployeeID.Properties.DataSource = EmployeeList;
            fld_lkeHREmployeeID.Focus();
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

        private void fld_lkeFK_HRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
            if (departmentID != 0)
                objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
            fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
        }

        private void fld_lkeFK_HRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> objDepartmentRoomGroupItemsInfo = null;
            if (departmentRoomID != 0)
                objDepartmentRoomGroupItemsInfo = objDepartmentRoomGroupItemsController.GetBySomeConditions(branchID, departmentID, departmentRoomID);
            fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = objDepartmentRoomGroupItemsInfo;
            fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
        }
    }
}
