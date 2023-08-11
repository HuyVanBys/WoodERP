using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP009 : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataSet ReportDataSource;

        public RP009()
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

        private void RP009_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteDateFrom.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteDateTo.DateTime = BOSUtil.GetMonthEndDate();

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            ShowReportData();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        /// <summary>
        /// Show report's data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            int customerLocationID = Convert.ToInt32(fld_lkeCustomerLocationID.EditValue);
            string customerType = Convert.ToString(fld_lkeARCustomerTypeCombo.EditValue);
            int priceLevelID = Convert.ToInt32(fld_lkeFK_ARPriceLevelID.EditValue);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            DateTime dateFrom = fld_dteDateFrom.DateTime;
            DateTime dateTo = fld_dteDateTo.DateTime;

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            string branchNoList = GetSelectedBranchNosByLocationIDAndBranchID(locationID, branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            ADReportsController objReportsController = new ADReportsController();

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetCustomerPurchaseSummary(
            //                                                    customerLocationID,
            //                                                    customerType,
            //                                                    priceLevelID,
            //                                                    locationID,
            //                                                    branchID,
            //                                                    dateFrom,
            //                                                    dateTo);
            DataSet ds = objReportsController.GetCustomerPurchaseSummaryByBranchList(
                                                                customerLocationID,
                                                                customerType,
                                                                priceLevelID,
                                                                null,
                                                                branchNoList,
                                                                dateFrom,
                                                                dateTo);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            ReportDataSource = ds;
            fld_dgcARRP009Customers.DataSource = ds.Tables[0];
            fld_dgcARRP009Customers.RefreshDataSource();
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}",
                                                        ReportLocalizedResources.FromDateTitle, fld_dteDateFrom.Text,
                                                        ReportLocalizedResources.ToDateTitle, fld_dteDateTo.Text);
            if (ds.Tables[0].Rows.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP009 report = new BOSReport.RP009();
            //report.LoadLayout(BOSCommon.Constants.Report.DevCustomerInvoiceSummaryReportPath);

            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = fld_lblFromdateTodate.Text;
            report.DataSource = ReportDataSource;
            report.DataMember = BOSCommon.Constants.Report.DevCustomerInvoiceSummaryReportName;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevCustomerInvoiceSummaryReportPath, true);
            reviewer.Show();
        }
    }
}