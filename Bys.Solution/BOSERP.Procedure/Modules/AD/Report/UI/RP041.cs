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
    public partial class RP041 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list for selecting
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP041()
        {
            InitializeComponent();
        }

        private void RP041_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            /*BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }*/

            ACAccountsController objAccountsController = new ACAccountsController();
            AccountList = objAccountsController.GetAllAccountList();
            fld_dgcRP041Accounts.DataSource = AccountList;
            //fld_dgcRP041Accounts.DataSource = AccountList.Where(x => x.ACAccountType != "DebitCreditBalance").ToList();
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

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            AccountList.ForEach(a => a.Selected = fld_chkSelectAll.Checked);
            fld_dgcRP041Accounts.RefreshDataSource();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            if (!AccountList.Exists(a => a.Selected == true))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int currencyID = Convert.ToInt32(fld_lkeFK_GECurrencyID.EditValue);
            XtraReport report = null;
            if (currencyID == GECurrencyID.VND)
            {
                report = new BOSReport.RP041Curencys();
            }
            else
                report = new BOSReport.RP041();

            bool isComplete = InitDataSourceReport(report);
            if (isComplete)
            {
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP041Path, true);
                reviewer.Show();
            }
            else
            {
                MessageBox.Show("Không tồn tại dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public bool InitDataSourceReport(XtraReport report)
        {
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            int currencyID = Convert.ToInt32(fld_lkeFK_GECurrencyID.EditValue);
            if (currencyID == GECurrencyID.VND)
            {
                (report as BOSReport.RP041Curencys).DateTimeReport = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                            ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            }
            else
                (report as BOSReport.RP041).DateTimeReport = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                            ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            bool isComplete = false;

            if (AccountList.Exists(a => a.Selected == true))
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
                List<ACAccountsInfo> selectedAccount = AccountList.Where(o => o.Selected == true).ToList();
                foreach (ACAccountsInfo objAccountsInfo in selectedAccount)
                {
                    List<ACDocumentEntrysInfo> documentByAccounts = objDocumentEntrysController.GetDocumentEntrysForReportRP061(dateFrom, dateTo, currencyID, branchID, objAccountsInfo.ACAccountID);

                    if (documentByAccounts.Count > 0)
                    {

                        List<string> curencyName = documentByAccounts.Select(x => x.GECurrencyName).Distinct().ToList();

                        int count = 0;
                        foreach (string curName in curencyName)
                        {
                            count++;
                            List<ACDocumentEntrysInfo> objStartPeriodBalance = documentByAccounts.Where(x => x.IsOpeningBalance
                                                                                                        && x.GECurrencyName == curName
                                                                                                        && x.ACDocumentEntryAccountNo == objAccountsInfo.ACAccountNo).ToList();
                            decimal startPeriodBalance = objStartPeriodBalance != null ? objStartPeriodBalance.Sum(x => x.StartPeriodBalance) : 0;

                            List<ACDocumentEntrysInfo> objStartPeriodExchangeBalance = documentByAccounts.Where(x => x.IsOpeningBalance
                                                                                                                && x.GECurrencyName == curName
                                                                                                                && x.ACDocumentEntryAccountNo == objAccountsInfo.ACAccountNo).ToList();
                            decimal startPeriodExchangeBalance = objStartPeriodExchangeBalance != null ? objStartPeriodExchangeBalance.Sum(x => x.StartPeriodExchangeBalance) : 0;

                            decimal account = objStartPeriodBalance != null ? objStartPeriodBalance.Sum(x => x.StartPeriodBalance) : 0;
                            decimal accountExchange = objStartPeriodExchangeBalance != null ? objStartPeriodExchangeBalance.Sum(x => x.StartPeriodExchangeBalance) : 0;

                            if (documentByAccounts != null)
                            {
                                if (curencyName != null)
                                    count = curencyName.Count;

                                #region Xử lý phát sinh đầu kỳ
                                ACDocumentEntrysInfo startBalance = new ACDocumentEntrysInfo();
                                startBalance.OrderNum = 0;
                                if (account > 0)
                                {
                                    startBalance.ACDocumentEntryDebitAmount = account;
                                    startBalance.ACDocumentEntryDebitExchangeAmount = accountExchange;
                                    startBalance.ACDocumentEntryCreditAmount = 0;
                                    startBalance.ACDocumentEntryCreditExchangeAmount = 0;
                                }
                                else
                                {
                                    startBalance.ACDocumentEntryDebitAmount = 0;
                                    startBalance.ACDocumentEntryDebitExchangeAmount = 0;
                                    startBalance.ACDocumentEntryCreditAmount = Math.Abs(account);
                                    startBalance.ACDocumentEntryCreditExchangeAmount = Math.Abs(accountExchange);
                                }
                                startBalance.ACDocumentDate = dateFrom;
                                startBalance.StartPeriodBalance = 0;
                                startBalance.StartPeriodExchangeBalance = 0;
                                startBalance.AccountBalance = 0;
                                startBalance.AccountExchangeBalance = 0;
                                startBalance.EndPeriodBalance = 0;
                                startBalance.EndPeriodExchangeBalance = 0;
                                startBalance.ACDocumentEntryDesc = "Số dư đầu kỳ";
                                startBalance.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
                                startBalance.ACDocumentEntryAccountNoDisplayText = objAccountsInfo.ACAccountNo + " - " + objAccountsInfo.ACAccountName;
                                startBalance.GECurrencyName = curName;
                                startBalance.IsEndBalance = false;
                                startBalance.IsOpeningBalance = true;
                                documentEntrys.Add(startBalance);
                                #endregion

                                // Xử lý phát sinh trong kỳ
                                documentByAccounts.ForEach(o =>
                                {
                                    if (o.GECurrencyName == curName && !o.IsOpeningBalance && o.ACDocumentEntryAccountNo == objAccountsInfo.ACAccountNo)
                                    {
                                        o.OrderNum = count;
                                        account = account + o.ACDocumentEntryDebitAmount - o.ACDocumentEntryCreditAmount;
                                        accountExchange = accountExchange + o.ACDocumentEntryDebitExchangeAmount - o.ACDocumentEntryCreditExchangeAmount;
                                        o.StartPeriodBalance = startPeriodBalance;
                                        o.StartPeriodExchangeBalance = startPeriodExchangeBalance;
                                        o.AccountBalance = account;
                                        o.AccountExchangeBalance = accountExchange;
                                        o.EndPeriodBalance = o.AccountBalance;
                                        o.EndPeriodExchangeBalance = o.AccountExchangeBalance;
                                    }
                                });

                                // Tổng phát sinh 
                                #region Xử lý phát sinh cuối kỳ
                                List<ACDocumentEntrysInfo> documentArising = documentByAccounts.Where(x => !x.IsOpeningBalance
                                                                                                        && !x.IsEndBalance
                                                                                                        && x.GECurrencyName == curName
                                                                                                        && x.ACDocumentEntryAccountNo == objAccountsInfo.ACAccountNo).ToList();
                                if (documentArising != null)
                                {
                                    ACDocumentEntrysInfo arisingBalance = new ACDocumentEntrysInfo();
                                    count++;
                                    arisingBalance.OrderNum = count;

                                    arisingBalance.ACDocumentEntryDebitAmount = documentArising.Sum(x => x.ACDocumentEntryDebitAmount);
                                    arisingBalance.ACDocumentEntryDebitExchangeAmount = documentArising.Sum(x => x.ACDocumentEntryDebitExchangeAmount);
                                    arisingBalance.ACDocumentEntryCreditAmount = documentArising.Sum(x => x.ACDocumentEntryCreditAmount);
                                    arisingBalance.ACDocumentEntryCreditExchangeAmount = documentArising.Sum(x => x.ACDocumentEntryCreditExchangeAmount);

                                    arisingBalance.ACDocumentDate = dateTo;
                                    arisingBalance.StartPeriodBalance = 0;
                                    arisingBalance.StartPeriodExchangeBalance = 0;
                                    arisingBalance.AccountBalance = 0;
                                    arisingBalance.AccountExchangeBalance = 0;
                                    arisingBalance.EndPeriodBalance = 0;
                                    arisingBalance.EndPeriodExchangeBalance = 0;
                                    arisingBalance.ACDocumentEntryDesc = "Tổng phát sinh";
                                    arisingBalance.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
                                    arisingBalance.ACDocumentEntryAccountNoDisplayText = objAccountsInfo.ACAccountNo + " - " + objAccountsInfo.ACAccountName;
                                    arisingBalance.GECurrencyName = curName;
                                    arisingBalance.IsEndBalance = true;
                                    documentEntrys.Add(arisingBalance);
                                }
                                #endregion

                                // Xử lý phát sinh cuối kỳ
                                #region Xử lý phát sinh cuối kỳ

                                ACDocumentEntrysInfo endBalance = new ACDocumentEntrysInfo();
                                count++;
                                endBalance.OrderNum = count;
                                if (account > 0)
                                {
                                    endBalance.ACDocumentEntryDebitAmount = account;
                                    endBalance.ACDocumentEntryDebitExchangeAmount = accountExchange;
                                    endBalance.ACDocumentEntryCreditAmount = 0;
                                    endBalance.ACDocumentEntryCreditExchangeAmount = 0;
                                }
                                else
                                {
                                    endBalance.ACDocumentEntryDebitAmount = 0;
                                    endBalance.ACDocumentEntryDebitExchangeAmount = 0;
                                    endBalance.ACDocumentEntryCreditAmount = Math.Abs(account);
                                    endBalance.ACDocumentEntryCreditExchangeAmount = Math.Abs(accountExchange);
                                }
                                endBalance.ACDocumentDate = dateTo;
                                endBalance.StartPeriodBalance = 0;
                                endBalance.StartPeriodExchangeBalance = 0;
                                endBalance.AccountBalance = 0;
                                endBalance.AccountExchangeBalance = 0;
                                endBalance.EndPeriodBalance = 0;
                                endBalance.EndPeriodExchangeBalance = 0;
                                endBalance.ACDocumentEntryDesc = "Số dư cuối kỳ";
                                endBalance.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
                                endBalance.ACDocumentEntryAccountNoDisplayText = objAccountsInfo.ACAccountNo + " - " + objAccountsInfo.ACAccountName;
                                endBalance.GECurrencyName = curName;
                                endBalance.IsEndBalance = true;
                                documentEntrys.Add(endBalance);
                                #endregion

                            }
                        }
                        documentByAccounts = documentByAccounts.Where(x => !x.IsOpeningBalance).ToList();
                        documentEntrys = documentEntrys.Concat(documentByAccounts).ToList();
                    }
                }

                if (documentEntrys != null && documentEntrys.Any())
                {
                    report.DataSource = (from m in documentEntrys
                                         orderby m.ACDocumentEntryAccountNo, m.GECurrencyName, m.OrderNum
                                         select m).ToList();
                    isComplete = true;
                }
                else
                    return isComplete;
            }
            else
            {
                MessageBox.Show(ReportLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isComplete;
        }
    }
}
