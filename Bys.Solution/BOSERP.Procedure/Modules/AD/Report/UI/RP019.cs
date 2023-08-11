using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP019 : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<HREmployeesInfo> EmployeeList;

        /// <summary>
        /// A variable to indicate the level at which the report is viewed
        /// </summary>
        private int ViewLevel = 1;

        public RP019()
        {
            InitializeComponent();
            //Set default Invoice from date to date
            fld_dteFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.EditValue = BOSUtil.GetMonthEndDate();
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

        private void RP019_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            ViewSaleSummary();
        }


        /// <summary>
        /// View sale summary of employees
        /// </summary>
        private void ViewSaleSummary()
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime fromDate = Convert.ToDateTime(fld_dteFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteToDate.EditValue);
            //Set title report
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fromDate.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy"));

            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //EmployeeList = objReportsController.GetEmployeeSaleSummaryList(locationID, branchID, employeeID, fromDate, toDate);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (EmployeeList == null)
                EmployeeList = new List<HREmployeesInfo>();
            EmployeeList.Clear();
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<HREmployeesInfo> result = objReportsController.GetEmployeeSaleSummaryList(0, branch.BRBranchID, employeeID, fromDate, toDate);
                    EmployeeList.AddRange(result);
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            EmployeeList = EmployeeList.Where(e => e.TotalSaleAmount != 0).ToList();
            fld_dgcHRRP019Employees.DataSource = EmployeeList;
            GridView gridView = (GridView)fld_dgcHRRP019Employees.MainView;
            gridView.ExpandAllGroups();
            if (EmployeeList.Count > 0)
                fld_btnPrint.Enabled = true;
            else
                fld_btnPrint.Enabled = false;
        }

        /// <summary>
        /// View the sale details of the selected employee
        /// </summary>
        private void ViewEmployeeSaleDetails()
        {
            GridView gridView = (GridView)fld_dgcHRRP019Employees.MainView;
            HREmployeesInfo employee = (HREmployeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (employee != null)
            {
                ViewEmployeeSaleDetails(employee.HREmployeeID);
            }
        }

        /// <summary>
        /// View the sale details of an employee
        /// </summary>
        /// <param name="employeeID">Employee id</param>
        private void ViewEmployeeSaleDetails(int employeeID)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<EmployeeSaleDetailInfo> saleDetails = objReportsController.GetEmployeeSaleDetails(employeeID, fromDate, toDate);
            foreach (EmployeeSaleDetailInfo saleDetail in saleDetails)
            {
                if (saleDetail.DocumentType == "SaleOrder")
                {
                    saleDetail.DocumentType = ReportLocalizedResources.SaleOrderIncome;
                }
                else if (saleDetail.DocumentType == "Invoice")
                {
                    saleDetail.DocumentType = ReportLocalizedResources.InvoiceIncome;
                }
                else if (saleDetail.DocumentType == "CancelVoucher")
                {
                    saleDetail.DocumentType = ReportLocalizedResources.CancelVoucherAmount;
                }
                else if (saleDetail.DocumentType == "SaleReturn")
                {
                    saleDetail.DocumentType = ReportLocalizedResources.SaleReturnAmount;
                }
            }
            fld_dgcSaleDetails.DataSource = saleDetails;
            (fld_dgcSaleDetails.MainView as GridView).ExpandAllGroups();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            if (ViewLevel == 1)
            {
                ViewSaleSummary();
            }
            else if (ViewLevel == 2)
            {
                int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
                ViewEmployeeSaleDetails(employeeID);
            }
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP019 rp = new BOSReport.RP019();
            DateTime fromDate = Convert.ToDateTime(fld_dteFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteToDate.EditValue);
            //rp.LoadLayout(BOSCommon.Constants.Report.DevRP019Path);
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
            string.Format("{0} {1} {2} {3}",
                ReportLocalizedResources.FromDateTitle, fld_dteFromDate.Text,
                ReportLocalizedResources.ToDateTitle, fld_dteToDate.Text);
            XRLabel SubTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (SubTitle != null)
                SubTitle.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fromDate.ToString("dd/MM/yyyy"), ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy"));
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP018Path, true);
            reviewer.Show();
        }

        private void fld_btnViewDetails_Click(object sender, EventArgs e)
        {
            SwitchView();
        }

        /// <summary>
        /// Switch the report from the summary view to the detail one or vice versa
        /// </summary>
        public void SwitchView()
        {
            if (ViewLevel == 1)
            {
                ViewEmployeeSaleDetails();
                fld_dgcSaleDetails.Visible = true;
                fld_btnViewDetails.Text = ReportLocalizedResources.Captionprev;
                ViewLevel = 2;
            }
            else if (ViewLevel == 2)
            {
                ViewSaleSummary();
                fld_dgcSaleDetails.Visible = false;
                fld_btnViewDetails.Text = ReportLocalizedResources.CaptionNext;
                ViewLevel = 1;
            }
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            if (ViewLevel == 1)
            {
                ExportToXls((GridView)fld_dgcHRRP019Employees.MainView);
            }
            else if (ViewLevel == 2)
            {
                ExportToXls((GridView)fld_dgcSaleDetails.MainView);
            }
        }
    }
}