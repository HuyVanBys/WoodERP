using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
    /// <summary>
    /// Summary description for guiQuickImportTimeSheet
    /// </summary>
    public partial class guiQuickImportTimeSheet : BOSERPScreen
    {
        private GridMulti GridMultiEmployee;
        private GridMulti GridMultiTimeKeeper;
        public List<HREmployeesInfo> SelectEmployeesList { get; set; }
        public List<HREmployeesInfo> EmployeesList { get; set; }
        public List<HRTimeKeepersInfo> SelectTimeKeepersList { get; set; }
        public List<HRTimeKeepersInfo> TimeKeepersList { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        bool check = false;

        public guiQuickImportTimeSheet()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void guiQuickImportTimeSheet_Load(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Đang tải ...");
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSApp.GetCurrentServerDate();
            fld_dteSearchToDate.DateTime = BOSApp.GetCurrentServerDate();

            GridView gridView = (GridView)fld_dgcHREmployees.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridMultiEmployee = new GridMulti(gridView);

            gridView = (GridView)fld_dgcHRTimeKeepers2.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridMultiTimeKeeper = new GridMulti(gridView);

            InitBindingDatasource();
            BOSProgressBar.Close();
        }

        private void InitBindingDatasource()
        {
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            DataSet departments = objDepartmentsController.GetAllObjects();
            fld_lkeFK_HRDepartmentID.Properties.DataSource = departments.Tables[0];

            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            DataSet departmentRooms = objDepartmentRoomsController.GetAllObjects();
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = departmentRooms.Tables[0];

            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet employees = objEmployeesController.GetAllObjects();
            fld_lkeHREmployeeID2.Properties.DataSource = employees.Tables[0];
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

        private void fld_lkeFK_HRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
            objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
            fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
        }

        private void fld_lkeHREmployeeID2_QueryPopUp(object sender, CancelEventArgs e)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeesList = null;
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            employeesList = objEmployeesController.GetEmployeeList(null, departmentID, departmentRoomID, null);
            if (employeesList != null)
            {
                employeesList = employeesList.Where(o => o.HREmployeeStatusCombo == EmployeeStatus.Working.ToString()).ToList();
            }
            fld_lkeHREmployeeID2.Properties.DataSource = employeesList;
            fld_lkeHREmployeeID2.EditValue = 0;
        }

        private void fld_btnViewQuickImport_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID2.EditValue);
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeesList = new List<HREmployeesInfo>();
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            DateTime date = DateTime.Parse(fld_dteSearchFromDate.EditValue.ToString());
            //if (departmentID == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn phòng ban!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            if (!check)
            {
                //employeesList = objEmployeesController.GetEmployeeList(null, departmentID, departmentRoomID, EmployeeStatus.Working.ToString());
                employeesList = objEmployeesController.GetEmployeeList(null, departmentID, departmentRoomID, null);
            }
            else
            {
                employeesList = objEmployeesController.GetEmployeeListForQuickImport(null, departmentID, departmentRoomID, employeeID, date);
            }
            if (employeeID > 0)
            {
                employeesList = employeesList.Where(o => o.HREmployeeID == employeeID).ToList();
            }
            if (employeesList.Count > 0)
            {
                EmployeesList = employeesList;
            }
            fld_dgcHREmployees.InvalidateDataSource(employeesList);
            GridView gridView = (GridView)fld_dgcHREmployees.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_dteSearchToDate_EditValueChanged(object sender, EventArgs e)
        {
            if (check)
            {
                fld_dteSearchToDate.DateTime = fld_dteSearchFromDate.DateTime;
            }
            else if (fld_dteSearchFromDate.DateTime.Date > fld_dteSearchToDate.DateTime.Date)
            {
                fld_dteSearchToDate.DateTime = fld_dteSearchFromDate.DateTime;
            }
            if (fld_dteSearchToDate.DateTime.Date < DateTime.MaxValue.Date)
            {
                FromDate = fld_dteSearchFromDate.DateTime;
                ToDate = fld_dteSearchToDate.DateTime;
                DateTime date = FromDate;

                List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
                HRTimeKeepersInfo objTimeKeepersInfo = new HRTimeKeepersInfo();

                while (date.Date <= ToDate.Date)
                {
                    objTimeKeepersInfo = new HRTimeKeepersInfo();
                    objTimeKeepersInfo.HRTimeKeeperQuickImportDate = date;
                    objTimeKeepersInfo.ThName = ((ManagerTimeKeeperModule)this.Module).GetThName(date);
                    list.Add(objTimeKeepersInfo);
                    date = date.AddDays(1);
                }

                if (list != null && list.Count > 0)
                {
                    TimeKeepersList = list;
                }

                fld_dgcHRTimeKeepers2.InvalidateDataSource(list);
                GridView gridView = (GridView)fld_dgcHRTimeKeepers2.MainView;
                gridView.ExpandAllGroups();
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            //SelectEmployeesList = EmployeesList.Where(o => o.Selected == true).ToList();
            //SelectTimeKeepersList = TimeKeepersList.Where(o => o.Selected == true).ToList();
            SelectEmployeesList = GridMultiEmployee.selection.OfType<HREmployeesInfo>().ToList();
            SelectTimeKeepersList = GridMultiTimeKeeper.selection.OfType<HRTimeKeepersInfo>().ToList();
            if (SelectEmployeesList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectTimeKeepersList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày nhập công!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (HREmployeesInfo item in SelectEmployeesList)
            {
                if (String.IsNullOrEmpty(item.HREmployeeCardNumber))
                {
                    MessageBox.Show("Vui tạo mã chấm công cho nhân viên: " + item.HREmployeeName, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            TimeIn = DateTime.Parse(fld_txtTimeFromDate.EditValue.ToString());
            TimeOut = DateTime.Parse(fld_txtTimeToDate.EditValue.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_lkeFK_HRDepartmentRoomID_QueryPopUp_1(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = new List<HRDepartmentRoomsInfo>();
            objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
            objDepartmentRoomsInfo.Insert(0, new HRDepartmentRoomsInfo());
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
        }

        private void fld_lkeHREmployeeID2_QueryPopUp_1(object sender, CancelEventArgs e)
        {
            int departmentRoomID = Convert.ToInt32(fld_lkeFK_HRDepartmentRoomID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> objHREmployeesInfo = new List<HREmployeesInfo>();
            objHREmployeesInfo = objEmployeesController.GetEmployeeList(null, departmentID, departmentRoomID);
            objHREmployeesInfo.Insert(0, new HREmployeesInfo());
            fld_lkeHREmployeeID2.Properties.DataSource = objHREmployeesInfo;
        }

        private void fld_ceHREmployeeHaveOutOfWorkIns_EditValueChanged(object sender, EventArgs e)
        {
            Boolean.TryParse(fld_ceHREmployeeHaveOutOfWorkIns.EditValue.ToString(), out check);
            if (check)
            {
                fld_dteSearchToDate.Enabled = false;
                fld_dteSearchToDate.DateTime = fld_dteSearchFromDate.DateTime;
            }
            else
            {
                fld_dteSearchToDate.Enabled = true;
            }
        }
    }
}
