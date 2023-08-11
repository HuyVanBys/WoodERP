using BOSCommon;
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
    public partial class RP160 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list for selecting
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP160()
        {
            InitializeComponent();
        }

        private void RP041_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            ACAccountsController objAccountsController = new ACAccountsController();
            AccountList = objAccountsController.GetAllAccountList();
            fld_dgcRP041Accounts.DataSource = AccountList;
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

            BOSReport.RP160 report = new BOSReport.RP160();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP040Path);
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP041Path, true);
            reviewer.Show();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            //if (branchAddressLine3 != null)
            //    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            //XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            //if (branchPhone != null)
            //    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            //XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            //if (branchFax != null)
            //    branchFax.Text = objBranchsInfo.BRBranchContactFax;
            //XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            //if (dateTimeReport != null)
            //    dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
            //                                                                            ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            if (objBranchsInfo != null)
            {
                (report as BOSReport.RP160).FullAddress = objBranchsInfo.BRBranchContactAddressLine3;
                (report as BOSReport.RP160).PhoneNumber = objBranchsInfo.BRBranchContactPhone;
                (report as BOSReport.RP160).FaxNumber = objBranchsInfo.BRBranchContactFax;
            }
            (report as BOSReport.RP160).DateTimeReport = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            List<ACDocumentEntrysInfo> entries = GetDocumentEntriesBySelectedAccounts();
            report.DataSource = entries;
        }

        /// <summary>
        /// Get document entry list relating to selected accounts
        /// </summary>
        /// <returns>List of document entries</returns>
        public List<ACDocumentEntrysInfo> GetDocumentEntriesBySelectedAccounts()
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> result = new List<ACDocumentEntrysInfo>();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int currencyID = Convert.ToInt32(fld_lkeFK_GECurrencyID.EditValue);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(a => a.Selected == true).ToList();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            decimal startBalance;
            decimal startBalanceUSD;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            foreach (ACAccountsInfo account in selectedAccounts)
            {
                if (account.Selected)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    //List<ACDocumentEntrysInfo> entries = objDocumentEntrysController.GetEntriesByAccountID(account.ACAccountID, currencyID, locationID, branchID, fromDate, toDate);                    
                    entries.Clear();
                    startBalance = 0;
                    startBalanceUSD = 0;
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        //TNDLoc [ADD][08/08/2016][Receipt, Shipment lấy hoàn tất],START
                        //List<ACDocumentEntrysInfo> list = objDocumentEntrysController.GetEntriesByAccountID(account.ACAccountID, currencyID, 0, branch.BRBranchID, fromDate, toDate);
                        List<ACDocumentEntrysInfo> list = objDocumentEntrysController.GetEntriesByAccountIDByCompleteDocument(account.ACAccountID, currencyID, 0, branch.BRBranchID, fromDate, toDate);

                        entries.AddRange(list);

                        // startBalance += objDocumentEntrysController.GetAccountBalance(account.ACAccountNo, fromDate.AddDays(-1), currencyID, 0, branch.BRBranchID);
                        startBalance += objDocumentEntrysController.GetAccountBalanceByCompleteDocument(account.ACAccountNo, fromDate.AddDays(-1), currencyID, 0, branch.BRBranchID);

                        startBalanceUSD += objDocumentEntrysController.GetAccountBalanceByCompleteDocumentAndCurrency(account.ACAccountNo, fromDate.AddDays(-1), currencyID, 0, branch.BRBranchID);
                        //TNDLoc [ADD][08/08/2016][Receipt, Shipment lấy hoàn tất],END
                    }

                    entries = entries.OrderBy(item => item.ACDocumentDate).ToList();
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                    entries.ForEach(e =>
                    {
                        e.ACDocumentEntryAccountNoDisplayText = string.Format("{0} - {1}", account.ACAccountNo, account.ACAccountName);
                        e.GroupValue = account.ACAccountNo;
                    });
                    //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], START
                    //decimal startBalance = objDocumentEntrysController.GetAccountBalance(account.ACAccountNo, fromDate.AddDays(-1), currencyID, locationID, branchID);
                    //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], END
                    decimal endBalance = startBalance;
                    decimal endBalanceUSD = startBalanceUSD;
                    foreach (ACDocumentEntrysInfo entry in entries)
                    {
                        if (entry.ACDocumentDebitAccount != null && entry.ACDocumentDebitAccount.StartsWith(account.ACAccountNo))
                        {
                            entry.ACDocumentEntryContraAccountNo = entry.ACDocumentCreditAccount;
                            if (entry.ACDocumentExchangeRate > 1)
                            {
                                entry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryExchangeAmount;
                                entry.ACDocumentEntryDebitAmountUSD = entry.ACDocumentEntryAmount;
                            }
                            else
                            {
                                entry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryExchangeAmount;
                            }
                        }
                        if (entry.ACDocumentCreditAccount != null && entry.ACDocumentCreditAccount.StartsWith(account.ACAccountNo))
                        {
                            entry.ACDocumentEntryContraAccountNo = entry.ACDocumentDebitAccount;
                            if (entry.ACDocumentExchangeRate > 1)
                            {
                                entry.ACDocumentEntryCreditAmountUSD = entry.ACDocumentEntryAmount;
                                entry.ACDocumentEntryCreditAmount = entry.ACDocumentEntryExchangeAmount;

                            }
                            else
                            {

                                entry.ACDocumentEntryCreditAmount = entry.ACDocumentEntryExchangeAmount;
                            }
                        }
                        if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                        {
                            endBalance = endBalance + entry.ACDocumentEntryDebitAmount - entry.ACDocumentEntryCreditAmount;
                            endBalanceUSD = endBalanceUSD + entry.ACDocumentEntryDebitAmountUSD - entry.ACDocumentEntryCreditAmountUSD;
                        }
                        else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                        {
                            endBalance = endBalance + entry.ACDocumentEntryCreditAmount - entry.ACDocumentEntryDebitAmount;
                            endBalanceUSD = endBalanceUSD + entry.ACDocumentEntryCreditAmountUSD - entry.ACDocumentEntryDebitAmountUSD;
                        }

                        if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                        {
                            if (startBalance > 0 || startBalanceUSD > 0)
                            {
                                entry.StartPeriodDebitBalance = Math.Abs(startBalance);
                                entry.StartPeriodDebitBalanceUSD = Math.Abs(startBalanceUSD);
                            }
                            else if (startBalance < 0 || startBalanceUSD < 0)
                            {
                                entry.StartPeriodCreditBalance = Math.Abs(startBalance);
                                entry.StartPeriodCreditBalanceUSD = Math.Abs(startBalanceUSD);
                            }

                            if (endBalance > 0 || endBalanceUSD > 0)
                            {
                                entry.EndPeriodDebitBalance = Math.Abs(endBalance);
                                entry.EndPeriodDebitBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                            else if (endBalance < 0 || endBalanceUSD < 0)
                            {
                                entry.EndPeriodCreditBalance = Math.Abs(endBalance);
                                entry.EndPeriodCreditBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                        }
                        else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                        {
                            if (startBalance > 0 || startBalanceUSD > 0)
                            {
                                entry.StartPeriodCreditBalance = Math.Abs(startBalance);
                                entry.StartPeriodCreditBalanceUSD = Math.Abs(startBalanceUSD);
                            }
                            else if (startBalance < 0 || startBalanceUSD < 0)
                            {
                                entry.StartPeriodDebitBalance = Math.Abs(startBalance);
                                entry.StartPeriodDebitBalanceUSD = Math.Abs(startBalanceUSD);
                            }

                            if (endBalance > 0 || endBalanceUSD > 0)
                            {
                                entry.EndPeriodCreditBalance = Math.Abs(endBalance);
                                entry.EndPeriodCreditBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                            else if (endBalance < 0 || endBalanceUSD < 0)
                            {
                                entry.EndPeriodDebitBalance = Math.Abs(endBalance);
                                entry.EndPeriodDebitBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                        }
                        startBalance = endBalance;
                        startBalanceUSD = endBalanceUSD;
                    }

                    if (entries.Count == 0 && startBalance != 0)
                    {
                        ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                        if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                        {
                            if (startBalance > 0 || startBalanceUSD > 0)
                            {
                                entry.StartPeriodDebitBalance = Math.Abs(startBalance);
                                entry.StartPeriodDebitBalanceUSD = Math.Abs(startBalanceUSD);
                            }
                            else if (startBalance < 0 || startBalanceUSD < 0)
                            {
                                entry.StartPeriodCreditBalance = Math.Abs(startBalance);
                                entry.StartPeriodCreditBalanceUSD = Math.Abs(startBalanceUSD);
                            }

                            if (endBalance > 0 || endBalanceUSD > 0)
                            {
                                entry.EndPeriodDebitBalance = Math.Abs(endBalance);
                                entry.EndPeriodDebitBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                            else if (endBalance < 0 || endBalanceUSD < 0)
                            {
                                entry.EndPeriodCreditBalance = Math.Abs(endBalance);
                                entry.EndPeriodCreditBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                        }
                        else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                        {
                            if (startBalance > 0 || startBalanceUSD > 0)
                            {
                                entry.StartPeriodCreditBalance = Math.Abs(startBalance);
                                entry.StartPeriodCreditBalanceUSD = Math.Abs(startBalanceUSD);
                            }
                            else if (startBalance < 0 || startBalanceUSD < 0)
                            {
                                entry.StartPeriodDebitBalance = Math.Abs(startBalance);
                                entry.StartPeriodDebitBalanceUSD = Math.Abs(startBalanceUSD);
                            }

                            if (endBalance > 0 || endBalanceUSD > 0)
                            {
                                entry.EndPeriodCreditBalance = Math.Abs(endBalance);
                                entry.EndPeriodCreditBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                            else if (endBalance < 0 || endBalanceUSD < 0)
                            {
                                entry.EndPeriodDebitBalance = Math.Abs(endBalance);
                                entry.EndPeriodDebitBalanceUSD = Math.Abs(endBalanceUSD);
                            }
                        }

                        entry.ACDocumentEntryAccountNoDisplayText = string.Format("{0} - {1}", account.ACAccountNo, account.ACAccountName);
                        entries.Add(entry);
                    }

                    if (entries.Count > 0)
                    {
                        //ACDocumentEntrysInfo startEntry = entries[0];
                        ACDocumentEntrysInfo endEntry = entries[entries.Count - 1];
                        //if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                        //{
                        //    if (startBalance > 0)
                        //    {
                        //        startEntry.StartPeriodDebitBalance = Math.Abs(startBalance);
                        //    }
                        //    else if (startBalance < 0)
                        //    {
                        //        startEntry.StartPeriodCreditBalance = Math.Abs(startBalance);
                        //    }

                        //    if (endBalance > 0)
                        //    {
                        //        endEntry.EndPeriodDebitBalance = Math.Abs(endBalance);
                        //    }
                        //    else if (endBalance < 0)
                        //    {
                        //        endEntry.EndPeriodCreditBalance = Math.Abs(endBalance);
                        //    }
                        //}
                        //else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                        //{
                        //    if (startBalance > 0)
                        //    {
                        //        startEntry.StartPeriodCreditBalance = Math.Abs(startBalance);
                        //    }
                        //    else if (startBalance < 0)
                        //    {
                        //        startEntry.StartPeriodDebitBalance = Math.Abs(startBalance);
                        //    }

                        //    if (endBalance > 0)
                        //    {
                        //        endEntry.EndPeriodCreditBalance = Math.Abs(endBalance);
                        //    }
                        //    else if (endBalance < 0)
                        //    {
                        //        endEntry.EndPeriodDebitBalance = Math.Abs(endBalance);
                        //    }
                        //}

                        DateTime startYear = BOSUtil.GetYearBeginDate(fromDate);
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                        //endEntry.EndYearDebitAmount = objDocumentEntrysController.GetAccountDebitAmount(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);
                        //endEntry.EndYearCreditAmount = objDocumentEntrysController.GetAccountCreditAmount(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);
                        foreach (BRBranchsInfo branch in selectedBranches)
                        {
                            //TNDLoc [ADD][08/08/2016][Receipt, Shipment lấy hoàn tất],START
                            //  endEntry.EndYearDebitAmount += objDocumentEntrysController.GetAccountDebitAmount(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);
                            endEntry.EndYearDebitAmount += objDocumentEntrysController.GetAccountDebitAmountByCompleteDocument(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);

                            endEntry.EndYearDebitAmountUSD += objDocumentEntrysController.GetAccountDebitAmountByCompleteDocumentAndCurrency(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);

                            //endEntry.EndYearCreditAmount += objDocumentEntrysController.GetAccountCreditAmount(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);
                            endEntry.EndYearCreditAmount += objDocumentEntrysController.GetAccountCreditAmountByCompleteDocument(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);

                            endEntry.EndYearCreditAmountUSD += objDocumentEntrysController.GetAccountCreditAmountByCompleteDocumentAndCurrency(account.ACAccountNo, 0, branch.BRBranchID, startYear, toDate);
                            //TNDLoc [ADD][08/08/2016][Receipt, Shipment lấy hoàn tất],END
                        }
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                    }
                    result = result.Concat(entries).ToList();
                }
            }
            return result;
        }
    }
}
