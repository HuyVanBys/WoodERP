using BOSCommon;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
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
        bool isSelectDepartmentRoomGroupItem = false;
        bool isSelectDepartmentRoom = false;
        bool isSelectDepartment = false;
        bool isSelectBranch = false;

        public guiSearchEmployee()
        {
            InitializeComponent();

            SelectedEmployeeList = new List<HREmployeesInfo>();
        }

        public guiSearchEmployee(List<HREmployeesInfo> selectedEmployees)
        {
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            InitializeComponent();

            SelectedEmployeeList = selectedEmployees;
            fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = objDepartmentRoomGroupItemsController.GetAllDepartmentRoomGroupItemList();
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

            fld_lkeHREmployeeStatus.EditValue = EmployeeStatus.Working.ToString();
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
            EmployeeList = objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, status);
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
            if (fld_lkeFK_HRDepartmentID.EditValue == null || (fld_lkeFK_HRDepartmentID.EditValue.ToString() == "0" && isSelectBranch == false))
                return;
            if (isSelectDepartmentRoomGroupItem == true || isSelectDepartmentRoom == true)
                return;
            isSelectDepartment = true;
            BRBranchsController objBranchsController = new BRBranchsController();
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();

            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
            if (departmentID != 0)
            {
                objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
                fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
                fld_lkeFK_HRDepartmentRoomID.EditValue = 0;

                List<BRBranchsInfo> BRBranchsList = objBranchsController.GetAllBranches();
                fld_lkeBRBranchID.Properties.DataSource = BRBranchsList;
                HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue));
                fld_lkeBRBranchID.EditValue = objDepartmentsInfo.FK_BRBranchID;
            }
            else
            {
                List<HRDepartmentRoomsInfo> DepartmentRoomsList = objDepartmentRoomsController.GetRoomListByBranchID(Convert.ToInt32(fld_lkeBRBranchID.EditValue));
                fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = DepartmentRoomsList;
                fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
            }
            isSelectDepartment = false;
        }

        private void fld_lkeFK_HRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentRoomID.EditValue == null || (fld_lkeFK_HRDepartmentRoomID.EditValue.ToString() == "0" && isSelectDepartment == false))
                return;
            if (isSelectDepartmentRoomGroupItem == true)
                return;
            isSelectDepartmentRoom = true;
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            BRBranchsController objBranchsController = new BRBranchsController();

            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> objDepartmentRoomGroupItemsInfo = null;

            if (fld_lkeFK_HRDepartmentRoomID.EditValue.ToString() != "0")
            {
                List<HRDepartmentsInfo> DepartmentsList = objDepartmentsController.GetAllList();
                fld_lkeFK_HRDepartmentID.Properties.DataSource = DepartmentsList;
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(departmentRoomID);
                fld_lkeFK_HRDepartmentID.EditValue = objDepartmentRoomsInfo.FK_HRDepartmentID;

                List<BRBranchsInfo> BRBranchsList = objBranchsController.GetAllBranches();
                fld_lkeBRBranchID.Properties.DataSource = BRBranchsList;
                HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(objDepartmentRoomsInfo.FK_HRDepartmentID);
                fld_lkeBRBranchID.EditValue = objDepartmentsInfo.FK_BRBranchID;

                if (departmentRoomID != 0)
                    objDepartmentRoomGroupItemsInfo = objDepartmentRoomGroupItemsController.GetBySomeConditions(branchID, departmentID, departmentRoomID);
                fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = objDepartmentRoomGroupItemsInfo;
                fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
            }
            else
            {
                List<HRDepartmentRoomGroupItemsInfo> DepartmentRoomGroupItemsList = objDepartmentRoomGroupItemsController.GetBySomeConditions(branchID, departmentID, departmentRoomID);
                fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = DepartmentRoomGroupItemsList;
                fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
            }
            isSelectDepartmentRoom = false;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> DepartmentRoomGroupItemsList = null;
            DepartmentRoomGroupItemsList = objDepartmentRoomGroupItemsController.GetBySomeConditions(branchID, departmentID, departmentRoomID);
            fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = DepartmentRoomGroupItemsList;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue == null || (fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue.ToString() == "0" && isSelectDepartmentRoom == false))
                return;
            if (isSelectDepartmentRoomGroupItem == true)
                return;
            BRBranchsController objBranchsController = new BRBranchsController();
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomGroupsController objDepartmentRoomGroupsController = new HRDepartmentRoomGroupsController();
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            HRDepartmentRoomGroupsInfo objDepartmentRoomGroupsInfo = new HRDepartmentRoomGroupsInfo();
            isSelectDepartmentRoomGroupItem = true;
            if (fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue.ToString() == string.Empty)
                fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = 0;
            int departmentRoomGroupItemEditValue = (int)fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue;

            if (fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue.ToString() != "0")
            {
                HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)objDepartmentRoomGroupItemsController.GetObjectByID(Convert.ToInt32(fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue));
                objDepartmentRoomGroupsInfo = (HRDepartmentRoomGroupsInfo)objDepartmentRoomGroupsController.GetObjectByID(objDepartmentRoomGroupItemsInfo.FK_HRDepartmentRoomGroupID);
                List<BRBranchsInfo> BRBranchsList = objBranchsController.GetAllBranches();
                fld_lkeBRBranchID.Properties.DataSource = BRBranchsList;
                fld_lkeBRBranchID.EditValue = objDepartmentRoomGroupsInfo.FK_BRBranchID;

                List<HRDepartmentsInfo> DepartmentsList = objDepartmentsController.GetAllList();
                fld_lkeFK_HRDepartmentID.Properties.DataSource = DepartmentsList;
                fld_lkeFK_HRDepartmentID.EditValue = objDepartmentRoomGroupsInfo.FK_HRDepartmentID;

                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> DepartmentRoomsList = objDepartmentRoomsController.GetRoomList(objDepartmentRoomGroupsInfo.FK_HRDepartmentID);
                fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = DepartmentRoomsList;
                fld_lkeFK_HRDepartmentRoomID.EditValue = objDepartmentRoomGroupsInfo.FK_HRDepartmentRoomID;
                fld_lkeFK_HRDepartmentRoomGroupItemID.EditValue = departmentRoomGroupItemEditValue;
            }
            isSelectDepartmentRoomGroupItem = false;
        }

        private void fld_lkeBRBranchID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeBRBranchID.EditValue == null || fld_lkeBRBranchID.EditValue.ToString() == "0")
                return;
            if (isSelectDepartmentRoomGroupItem == true || isSelectDepartmentRoom == true || isSelectDepartment == true)
                return;
            isSelectBranch = true;
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            List<HRDepartmentsInfo> DepartmentsList = objDepartmentsController.GetListByFK_BRBranchID(Convert.ToInt32(fld_lkeBRBranchID.EditValue));
            fld_lkeFK_HRDepartmentID.Properties.DataSource = DepartmentsList;
            fld_lkeFK_HRDepartmentID.EditValue = 0;
            isSelectBranch = false;
        }
    }
}
