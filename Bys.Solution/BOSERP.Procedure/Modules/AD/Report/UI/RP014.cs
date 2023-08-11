using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP014 : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataSet ReportDataSource;

        public RP014()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void RP014_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromICTransferDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToICTransferDate.DateTime = BOSUtil.GetMonthEndDate();

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
            int fromStockID = Convert.ToInt32(fld_lkeFK_ICFromStockID.EditValue);
            int toStockID = Convert.ToInt32(fld_lkeFK_ICToStockID.EditValue);
            DateTime dateFrom = fld_dteSearchFromICTransferDate.DateTime;
            DateTime dateTo = fld_dteSearchToICTransferDate.DateTime;
            string status = Convert.ToString(fld_lkeICTransferStatus.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            //Set title report
            fld_lblSubTitleDate.Text = String.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));

            ADReportsController objReportsController = new ADReportsController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetTransferList(fromStockID, toStockID, dateFrom, dateTo, status);
            DataSet ds = objReportsController.GetTransferListByBranchNoList(branchNos, fromStockID, toStockID, dateFrom, dateTo, status);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            ReportDataSource = ds;
            fld_dgcICRP014Transfers.DataSource = ds.Tables[0];
            fld_dgcICRP014Transfers.RefreshDataSource();
            if (ds.Tables[0].Rows.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP014 report = new BOSReport.RP014();
            //report.LoadLayout(BOSCommon.Constants.Report.DevTransferReportPath);
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
            //Set title report
            XRLabel subTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text = fld_lblSubTitleDate.Text;
            }
            report.DataSource = ReportDataSource;
            report.DataMember = BOSCommon.Constants.Report.DevTransferReportName;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevTransferReportPath, true);
            reviewer.Show();
        }
    }
}