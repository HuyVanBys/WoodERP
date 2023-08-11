using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using BOSLib;
using BOSCommon;

namespace BOSERP.Modules.Report
{
    public partial class RP242 : ReportForm
    {
        /// <summary>
        /// Gets or sets the employee list
        /// </summary>
        public List<HREmployeesInfo> EmployeeList { get; set; }
        public RP242()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RP242_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        /// <summary>
        /// Initialize data source for employee grid control
        /// </summary>
        public void InitializeDataSource()
        {
            //Set title report
            HREmployeesController objEmployeesController = new HREmployeesController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            string title = "DANH SÁCH NHÂN VIÊN ĐÃ NGHỈ";
            fld_dgcHRRP241Employees.LoadBandedGridViewByTitle(title, EmployeeControllerType.Resigned.ToString());
            EmployeeList = new List<HREmployeesInfo>();
            List<HREmployeesInfo> employees = objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, BOSApp.GetCurrentServerDate(), EmployeeControllerType.Resigned.ToString());
            EmployeeList.AddRange(employees);
           
            fld_dgcHRRP241Employees.DataSource = EmployeeList;
            GridView gridView = (GridView)fld_dgcHRRP241Employees.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeDataSource();
        }

        private void fld_lkeHRDepartmentID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            List<HRDepartmentsInfo> objDepartmentsInfo = null;
            objDepartmentsInfo = (List<HRDepartmentsInfo>)objDepartmentsController.GetListByFK_BRBranchID(branchID);
            fld_lkeHRDepartmentID.Properties.DataSource = objDepartmentsInfo;
            fld_lkeHRDepartmentID.EditValue = 0;
        }

        private void fld_lkeHRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
            objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
            fld_lkeHRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
            fld_lkeHRDepartmentRoomID.EditValue = 0;
        }

        private void fld_lkeHRDepartmentID_Validated(object sender, EventArgs e)
        {
            if (fld_lkeHRDepartmentID.EditValue != null)
            {
                int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
                if (departmentID != 0)
                    objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
                fld_lkeHRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
                fld_lkeHRDepartmentRoomID.EditValue = 0;
            }
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    fld_dgcHRRP241Employees.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}