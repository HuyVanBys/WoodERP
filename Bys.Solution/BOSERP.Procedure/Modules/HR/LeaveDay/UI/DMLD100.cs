using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.LeaveDay.UI
{
    /// <summary>
    /// Summary description for DMLD100
    /// </summary>
    public partial class DMLD100 : BOSERPScreen
    {

        public DMLD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int employeePayrollFormulaID = Convert.ToInt32(fld_lkeFK_HREmployeePayrollFormulaID.EditValue);
            string status = Convert.ToString(fld_lkeHREmployeeStatus.EditValue);
            //((LeaveDayModule)Module).InitializeLeaveDayGridControl();
            //((LeaveDayModule)Module).UpdateGridDateAlias();
            ((LeaveDayModule)Module).ViewLeaveDays(branchID, departmentID, departmentRoomID, employeeID, dateFrom, dateTo, status, employeePayrollFormulaID);
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((LeaveDayModule)Module).SaveLeaveDays();
        }

        public override void AddExtraControls(Control.ControlCollection controls)
        {

        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(0, 0);
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((LeaveDayModule)Module).ExportExcel();
        }

        //private void fld_dteSearchFromDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        //{
        //    DateTime dateFrom = fld_dteSearchFromDate.DateTime.Date;
        //    if (dateFrom.Date != DateTime.MaxValue.Date)
        //    {
        //        int numOfDay = DateTime.DaysInMonth(dateFrom.Year, dateFrom.Month);
        //        fld_dteSearchToDate.DateTime = dateFrom.AddDays(numOfDay - 1);
        //        ((LeaveDayModule)Module).InitializeLeaveDayGridControl();
        //    }
        //}

        //private void fld_dteSearchFromDate_EditValueChanged(object sender, EventArgs e)
        //{
        //    DateTime dateFrom = fld_dteSearchFromDate.DateTime.Date;
        //    if (dateFrom.Date != DateTime.MaxValue.Date)
        //    {
        //        int numOfDay = DateTime.DaysInMonth(dateFrom.Year, dateFrom.Month);
        //        fld_dteSearchToDate.DateTime = dateFrom.AddDays(numOfDay - 1);
        //        ((LeaveDayModule)Module).InitializeLeaveDayGridControl();
        //    }
        //}

        private void fld_dteLeaveDayFrom_Validated(object sender, EventArgs e)
        {
            ((LeaveDayModule)Module).InitializeLeaveDayFromGridControl();
        }

        private void fld_dteLeaveDayTo_Validated(object sender, EventArgs e)
        {
            ((LeaveDayModule)Module).InitializeLeaveDayToGridControl();
        }

        private void fld_lkeHRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> list = null;
            if (departmentID != 0)
                list = objDepartmentRoomsController.GetRoomList(departmentID);
            if (list != null)
            {
                list.Insert(0, new HRDepartmentRoomsInfo());
            }
            fld_lkeHRDepartmentRoomID.Properties.DataSource = list;
            fld_lkeHREmployeeID.EditValue = 0;
        }

        private void fld_lkeHREmployeeID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            int employeePayrollFormulaID = Convert.ToInt32(fld_lkeFK_HREmployeePayrollFormulaID.EditValue);
            string status = Convert.ToString(fld_lkeHREmployeeStatus.EditValue);
            List<HREmployeesInfo> list = (List<HREmployeesInfo>)objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, null, null, status);
            if (list != null)
            {
                list.Insert(0, new HREmployeesInfo());
            }
            fld_lkeHREmployeeID.Properties.DataSource = list;
        }

        private void fld_lkeHRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            fld_lkeHRDepartmentRoomID.EditValue = 0;
            fld_lkeHREmployeeID.EditValue = 0;
        }

        private void fld_lkeHRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            int employeePayrollFormulaID = Convert.ToInt32(fld_lkeFK_HREmployeePayrollFormulaID.EditValue);
            string status = Convert.ToString(fld_lkeHREmployeeStatus.EditValue);
            List<HREmployeesInfo> list = (List<HREmployeesInfo>)objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, null, null, status);
            if (list != null)
            {
                list.Insert(0, new HREmployeesInfo());
            }
            fld_lkeHREmployeeID.Properties.DataSource = list;
        }
    }
}
