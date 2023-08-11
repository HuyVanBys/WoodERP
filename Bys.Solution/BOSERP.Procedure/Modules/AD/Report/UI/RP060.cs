using BOSCommon.Constants;
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
    public partial class RP060 : ReportForm
    {
        /// <summary>
        /// A variable to store the selected accounts
        /// </summary>
        private List<ACAccountsInfo> SelectedAccountList;

        #region Constructor
        public RP060()
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
        private void RP060_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            SelectedAccountList = new BOSList<ACAccountsInfo>();
            InitAccounts();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP060 report = new BOSReport.RP060();
            bool isComplete = InitReportDataSource(report);
            if (isComplete)
            {
                guiReportPreview reviewer = new guiReportPreview(report);
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
            fld_dgcACRP060Accounts.RefreshDataSource();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Init available accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            SelectedAccountList = objAccountsController.GetSubAccountsByAccountNo(AccAccount.Acc111);
            SelectedAccountList.AddRange(objAccountsController.GetSubAccountsByAccountNo(AccAccount.Acc113));
            fld_dgcACRP060Accounts.DataSource = SelectedAccountList;
        }

        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>
        /// <returns>True if initialize successfully, otherwise false</returns>
        public bool InitReportDataSource(XtraReport report)
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
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

            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            bool isComplete = false;
            if (SelectedAccountList.Exists(a => a.Selected == true))
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
                List<ACAccountsInfo> selectedAccount = SelectedAccountList.Where(o => o.Selected == true).ToList();
                foreach (ACAccountsInfo objAccountsInfo in selectedAccount)
                {
                    List<ACDocumentEntrysInfo> documentEntrysByAccounts = objDocumentEntrysController.GetDocumentEntrysForReportRP060(fromDate, toDate, currencyID, branchID, objAccountsInfo.ACAccountID);
                    if (documentEntrysByAccounts.Count > 0)
                    {
                        decimal account = documentEntrysByAccounts.First().StartPeriodBalance;
                        for (int i = 1; i < documentEntrysByAccounts.Count; i++)
                        {
                            account = account + documentEntrysByAccounts[i].ACDocumentEntryDebitAmount - documentEntrysByAccounts[i].ACDocumentEntryCreditAmount;
                            documentEntrysByAccounts[i].AccountBalance = account;
                            documentEntrysByAccounts[i].EndPeriodBalance = documentEntrysByAccounts[i].AccountBalance;
                        }
                        documentEntrys = documentEntrys.Concat(documentEntrysByAccounts).ToList();
                    }
                }
                report.DataSource = documentEntrys;
                isComplete = true;
            }
            else
            {
                MessageBox.Show(ReportLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isComplete;
        }
        #endregion
    }
}
