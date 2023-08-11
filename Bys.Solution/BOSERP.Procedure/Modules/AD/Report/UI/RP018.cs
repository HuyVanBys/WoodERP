using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP018 : ReportForm
    {
        /// <summary>
        /// Gets or sets the employee list
        /// </summary>
        public List<HREmployeesInfo> EmployeeList { get; set; }
        public RP018()
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

        private void RP018_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitializeDataSource();
        }

        /// <summary>
        /// Initialize data source for employee grid control
        /// </summary>
        public void InitializeDataSource()
        {
            //Set title report
            fld_lblSubTitleDate.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));
            HREmployeesController objEmployeesController = new HREmployeesController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            int levelID = Convert.ToInt32(fld_lkeHRLevelID.EditValue);
            string status = Convert.ToString(fld_lkeHREmployeeStatus.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            if (branchID == 0)
            {
                EmployeeList = new List<HREmployeesInfo>();
                foreach (BRBranchsInfo branch in BranchList)
                {
                    List<HREmployeesInfo> employees = objEmployeesController.GetEmployeeList(branch.BRBranchID, departmentID, departmentRoomID, levelID, status);
                    EmployeeList.AddRange(employees);
                }
            }
            else
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                EmployeeList = objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, levelID, status);
            fld_dgcHRRP018Employees.DataSource = EmployeeList;
            GridView gridView = (GridView)fld_dgcHRRP018Employees.MainView;
            gridView.ExpandAllGroups();
            if (EmployeeList.Count > 0)
                fld_btnPrint.Enabled = true;
            else
                fld_btnPrint.Enabled = false;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeDataSource();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP018 rp = new BOSReport.RP018();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevRP018Path);
            rp.DataSource = EmployeeList;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            //Set title report
            XRLabel SubTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (SubTitle != null)
                SubTitle.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP018Path, true);
            reviewer.Show();
        }
    }
}