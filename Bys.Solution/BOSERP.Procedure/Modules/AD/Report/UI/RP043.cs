using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP043 : ReportForm
    {
        /// <summary>
        /// Gets or sets account list
        /// </summary>
        public List<ACAccountsInfo> SelectedAccountList { get; set; }

        #region Constructor
        public RP043()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
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
        #endregion

        #region Events
        private void RP043_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            SelectedAccountList = new BOSList<ACAccountsInfo>();
            InitDataSourceGridControl();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP043 report = new BOSReport.RP043();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP042Path);
            bool isComplete = InitDataSourceReport(report);
            if (isComplete)
            {
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP043Path, true);
                reviewer.Show();
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (fld_chkSellectAllAccount.Checked)
            {
                foreach (ACAccountsInfo objAccountsInfo in SelectedAccountList)
                {
                    objAccountsInfo.Selected = true;
                }
            }
            else
            {
                foreach (ACAccountsInfo objAccountsInfo in SelectedAccountList)
                {
                    objAccountsInfo.Selected = false;
                }
            }
            fld_dgcACRP043Accounts.RefreshDataSource();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Init data source for account and object grid control
        /// </summary>
        public void InitDataSourceGridControl()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            SelectedAccountList = objAccountsController.GetSubAccountsByAccountNo(AccAccount.Acc111);
            fld_dgcACRP043Accounts.DataSource = SelectedAccountList;
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        /// <returns>True if initialize successfully, otherwise false</returns>
        public bool InitDataSourceReport(XtraReport report)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            bool isComplete = false;
            if (SelectedAccountList.Exists(a => a.Selected == true))
            {
                List<ACDocumentEntrysInfo> documentEntryList = GetDocumentEntrysBySelectedAccounts();
                report.DataSource = documentEntryList;
                isComplete = true;
            }
            else
            {
                MessageBox.Show(ReportLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isComplete;
        }

        /// <summary>
        /// Get document entry by selected accounts
        /// </summary>
        /// <returns>List of receipt voucher</returns>
        private List<ACDocumentEntrysInfo> GetDocumentEntrysBySelectedAccounts()
        {
            ADReportsController objReportsController = new ADReportsController();
            List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
            decimal documentEntryAmount = 0;
            List<ACDocumentEntrysInfo> documentEntryList = new List<ACDocumentEntrysInfo>();
            foreach (ACAccountsInfo objAccountsInfo in SelectedAccountList)
            {
                if (objAccountsInfo.Selected)
                {
                    string accountName = objAccountsInfo.ACAccountName;
                    foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in documentEntryList)
                    {
                        if (objDocumentEntrysInfo.FK_ACDebitAccountID.Equals(objAccountsInfo.ACAccountID))
                        {
                            documentEntryAmount += objDocumentEntrysInfo.ACDocumentEntryAmount;
                            objDocumentEntrysInfo.ACDocumentEntryAccountNo = objDocumentEntrysInfo.ACDocumentDebitAccount + " - " + accountName;
                            documentEntrys.Add(objDocumentEntrysInfo);
                        }
                    }
                }

            }
            return documentEntrys;
        }
        #endregion
    }
}
