using BOSComponent;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP083 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        /// <summary>
        /// A variable to store the segment List
        /// </summary>
        private List<ACSegmentsInfo> SegmentList;

        public RP083()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP083 report = new BOSReport.RP083();
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP083Path, true);
            reviewer.Show();
        }


        /// <summary>
        /// Init accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountList = objAccountsController.GetAllAccountList();
            fld_dgcACRP083Accounts.DataSource = AccountList;
        }

        /// <summary>
        /// Init segments for the report
        /// </summary>
        public void GetSegmentsBySomeCriteria()
        {
            ACSegmentsController objSegmentsController = new ACSegmentsController();
            DateTime? fromDate = null;
            if (fld_dteSearchFromDate.EditValue != null)
                fromDate = DateTime.Parse(fld_dteSearchFromDate.EditValue.ToString());
            DateTime? toDate = null;
            if (fld_dteSearchToDate.EditValue != null)
                toDate = DateTime.Parse(fld_dteSearchToDate.EditValue.ToString());
            int currencyID = 0;
            if (fld_lkeGECurrencyID.EditValue != null)
                currencyID = int.Parse(fld_lkeGECurrencyID.EditValue.ToString());

            SegmentList = objSegmentsController.GetSegmentsAndTotalAmountBySomeCriteria(fromDate, toDate, currencyID);
            fld_dgcACRP083Segments.DataSource = SegmentList;
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            ADReportsController objReportsController = new ADReportsController();
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACSegmentsController objSegmentsController = new ACSegmentsController();

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
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(fld_dteSearchFromDate.Text)),
                                                                                        ReportLocalizedResources.ToDateTitle, String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(fld_dteSearchToDate.Text)));

            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            List<ACSegmentsInfo> selectedSegments = SegmentList.Where(sg => sg.Selected == true).ToList();
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();

            foreach (ACSegmentsInfo objSegmentsInfo in selectedSegments)
            {
                foreach (ACAccountsInfo objAccountsInfo in selectedAccounts)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        List<ACDocumentEntrysInfo> documentEntrysList = objDocumentEntrysController.GetDocumentEntryForGeneralSegmentReport(
                                                                            objSegmentsInfo.ACSegmentID,
                                                                            objAccountsInfo.ACAccountNo,
                                                                            null,
                                                                            currencyID,
                                                                            branch.BRBranchID,
                                                                            dateFrom,
                                                                            dateTo);

                        entries.AddRange(documentEntrysList);
                    }
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                }
            }
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            entries = entries.OrderBy(item => item.ACDocumentDate).ToList();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            report.DataSource = entries;
        }

        private void fld_chkSellectAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (ACAccountsInfo objAccountsInfo in AccountList)
            {
                objAccountsInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcACRP083Accounts.RefreshDataSource();
        }

        private void fld_chkSellectAllSegment_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (ACSegmentsInfo objSegmentsInfo in SegmentList)
            {
                objSegmentsInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcACRP083Segments.RefreshDataSource();
        }

        private void RP083_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            InitAccounts();
            GetSegmentsBySomeCriteria();
        }

        private void fld_dteSearchFromDate_EditValueChanged(object sender, EventArgs e)
        {
            GetSegmentsBySomeCriteria();
        }

        private void fld_dteSearchToDate_EditValueChanged(object sender, EventArgs e)
        {
            GetSegmentsBySomeCriteria();
        }

        private void fld_lkeGECurrencyID_EditValueChanged(object sender, EventArgs e)
        {
            GetSegmentsBySomeCriteria();
        }
    }
}
