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
    public partial class RP074 : ReportForm
    {
        /// <summary>
        /// A variable to store the selected accounts
        /// </summary>
        private List<ACAccountsInfo> SelectedAccountList;

        #region Constructor
        public RP074()
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
        private void RP074_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            SelectedAccountList = new BOSList<ACAccountsInfo>();

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            InitAccounts();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP074 report = new BOSReport.RP074();
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
            fld_dgcACRP074Accounts.RefreshDataSource();
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
            fld_dgcACRP074Accounts.DataSource = SelectedAccountList;
        }

        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>
        /// <returns>True if initialize successfully, otherwise false</returns>
        public bool InitReportDataSource(XtraReport report)
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

            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            bool isComplete = false;
            if (SelectedAccountList.Exists(a => a.Selected == true))
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                List<ACDocumentEntrysInfo> documents = new List<ACDocumentEntrysInfo>();
                List<ACAccountsInfo> accountList = SelectedAccountList.Where(o => o.Selected == true).ToList();
                foreach (ACAccountsInfo objAccountsInfo in accountList)
                {
                    List<ACDocumentEntrysInfo> documentByAccounts = objDocumentEntrysController.GetDocumentsForReportRP074(dateFrom, dateTo, currencyID, branchID, objAccountsInfo.ACAccountID);
                    if (documentByAccounts.Count > 0)
                    {
                        decimal account = documentByAccounts.First().StartPeriodBalance;
                        decimal accountExchange = documentByAccounts.First().StartPeriodExchangeBalance;
                        documentByAccounts.ForEach(o =>
                            {
                                if (o.GECurrencyName == "VND")
                                {
                                    accountExchange = accountExchange + o.DocumentReceiptAmount - o.DocumentPaymentAmount;
                                    o.AccountExchangeBalance = accountExchange * o.ACDocumentExchangeRate;
                                    o.EndPeriodExchangeBalance = accountExchange * o.ACDocumentExchangeRate;
                                    o.ACDocumentEntryAccountNoDisplayText = o.ACAccountNo + " - " + o.ACAccountName;
                                }
                                else
                                {
                                    account = account + o.DocumentReceiptAmount - o.DocumentPaymentAmount;
                                    o.AccountBalance = account;
                                    o.EndPeriodBalance = o.AccountBalance;
                                    o.AccountExchangeBalance = o.AccountBalance * o.ACDocumentExchangeRate;
                                    o.EndPeriodExchangeBalance = o.EndPeriodBalance * o.ACDocumentExchangeRate;
                                    o.ACDocumentEntryAccountNoDisplayText = o.ACAccountNo + " - " + o.ACAccountName;
                                }
                            });
                        //if (currencyID == 100000)
                        //{
                        //    documentByAccounts.ForEach(o =>
                        //    {
                        //        account = account + o.DocumentReceiptAmount - o.DocumentPaymentAmount;
                        //        o.AccountExchangeBalance = account * o.ACDocumentExchangeRate;
                        //        o.EndPeriodExchangeBalance = account * o.ACDocumentExchangeRate;
                        //        o.ACDocumentEntryAccountNoDisplayText = o.ACAccountNo + " - " + o.ACAccountName;
                        //    });
                        //}
                        //else
                        //{
                        //    documentByAccounts.ForEach(o =>
                        //    {
                        //        account = account + o.DocumentReceiptAmount - o.DocumentPaymentAmount;
                        //        o.AccountBalance = account;
                        //        o.EndPeriodBalance = o.AccountBalance;
                        //        o.AccountExchangeBalance = o.AccountBalance * o.ACDocumentExchangeRate;
                        //        o.EndPeriodExchangeBalance = o.EndPeriodBalance * o.ACDocumentExchangeRate;
                        //        o.ACDocumentEntryAccountNoDisplayText = o.ACAccountNo + " - " + o.ACAccountName;
                        //    });
                        //}
                        documents = documents.Concat(documentByAccounts).ToList();
                    }
                }

                report.DataSource = documents;
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
        /// Get entries relating to selected accounts
        /// </summary>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>List of entries</returns>
        private List<ACDocumentEntrysInfo> GetDocumentEntriesBySelectedAccounts(DateTime fromDate, DateTime toDate)
        {
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> result = new List<ACDocumentEntrysInfo>();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            foreach (ACAccountsInfo objAccountsInfo in SelectedAccountList)
            {
                if (objAccountsInfo.Selected)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    decimal startBalance = 0;
                    decimal startExchangeBalance = 0;
                    entries.Clear();
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        List<ACDocumentEntrysInfo> list = objDocumentEntrysController.GetEntriesByAccountID(
                                                                                                    objAccountsInfo.ACAccountID,
                                                                                                    currencyID,
                                                                                                    0,
                                                                                                    branch.BRBranchID,
                                                                                                    fromDate,
                                                                                                    toDate);
                        entries.AddRange(list);

                        if (currencyID > 0)
                        {
                            startBalance += objDocumentEntrysController.GetAccountBalanceByCurrency(objAccountsInfo.ACAccountNo, fromDate.AddDays(-1), currencyID, 0, branch.BRBranchID);
                            startExchangeBalance += objDocumentEntrysController.GetAccountBalance(objAccountsInfo.ACAccountNo, fromDate.AddDays(-1), currencyID, 0, branch.BRBranchID);
                        }
                        else
                        {
                            startExchangeBalance += objDocumentEntrysController.GetAccountBalance(objAccountsInfo.ACAccountNo, fromDate.AddDays(-1), currencyID, 0, branch.BRBranchID);
                        }

                    }

                    entries = entries.OrderBy(item => item.ACDocumentDate).ToList();
                    entries.ForEach(e => e.ACDocumentEntryAccountNoDisplayText = string.Format("{0} - {1}", objAccountsInfo.ACAccountNo, objAccountsInfo.ACAccountName));
                    entries.ForEach(e => e.GECurrencyName = currencyName);
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                    decimal endBalance = startBalance;
                    decimal endExchangeBalance = startExchangeBalance;
                    foreach (ACDocumentEntrysInfo entry in entries)
                    {
                        if (entry.ACDocumentDebitAccount.StartsWith(AccAccount.Acc111))
                        {
                            entry.ReceiptDocumentNo = entry.ACDocumentNo;
                            if (currencyID > 0)
                            {
                                entry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryAmount;
                                entry.DebitExchangeAmount = entry.ACDocumentEntryExchangeAmount;
                                entry.ACDocumentExchangeRate = entry.ACDocumentEntryExchangeAmount / entry.ACDocumentEntryAmount;
                            }
                            else
                            {
                                entry.DebitExchangeAmount = entry.ACDocumentEntryExchangeAmount;
                            }
                        }
                        else if (entry.ACDocumentCreditAccount.StartsWith(AccAccount.Acc111))
                        {
                            entry.PaymentDocumentNo = entry.ACDocumentNo;
                            if (currencyID > 0)
                            {
                                entry.ACDocumentEntryCreditAmount = entry.ACDocumentEntryAmount;
                                entry.CreditExchangeAmount = entry.ACDocumentEntryExchangeAmount;
                                entry.ACDocumentExchangeRate = entry.ACDocumentEntryExchangeAmount / entry.ACDocumentEntryAmount;
                            }
                            else
                            {
                                entry.CreditExchangeAmount = entry.ACDocumentEntryExchangeAmount;
                            }
                        }
                        endBalance = endBalance + entry.ACDocumentEntryDebitAmount - entry.ACDocumentEntryCreditAmount;
                        endExchangeBalance = endExchangeBalance + entry.DebitExchangeAmount - entry.CreditExchangeAmount;
                        entry.AccountBalance = endBalance;
                        entry.AccountExchangeBalance = endExchangeBalance;
                    }

                    if (entries.Count == 0 && startBalance != 0)
                    {
                        ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                        entry.ACDocumentEntryAccountNoDisplayText = string.Format("{0} - {1}", objAccountsInfo.ACAccountNo, objAccountsInfo.ACAccountName);
                        entry.GECurrencyName = currencyName;
                        entry.StartPeriodBalance = startBalance;
                        entry.StartPeriodExchangeBalance = startExchangeBalance;
                        entry.EndPeriodBalance = endBalance;
                        entry.EndPeriodExchangeBalance = endExchangeBalance;
                        entries.Add(entry);
                    }

                    if (entries.Count > 0)
                    {
                        entries[0].StartPeriodBalance = startBalance;
                        entries[0].StartPeriodExchangeBalance = startExchangeBalance;
                        entries[entries.Count - 1].EndPeriodBalance = endBalance;
                        entries[entries.Count - 1].EndPeriodExchangeBalance = endExchangeBalance;
                    }
                    result = result.Concat(entries).ToList();
                }
            }
            return result;
        }
        #endregion
    }
}
