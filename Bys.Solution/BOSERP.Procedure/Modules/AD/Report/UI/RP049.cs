using BOSCommon.Constants;
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
    public partial class RP049 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        private List<ACAccountsInfo> AccountList;
        bool IsgroupByCurency = false;
        public RP049()
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
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            List<string> accountNo = AccountList.Where(acc => acc.Selected == true).Select(x => x.ACAccountNo.ToString()).Distinct().ToList();
            XtraReport report = null;
            IsgroupByCurency = true;
            string stringReportTitle = "TỔNG HỢP CÔNG NỢ PHẢI THU";
            if (!fld_chkGroupByAcount.Checked)
            {
                if (currencyID > 0)
                {

                    if (currencyID == GECurrencyID.VND)
                    {
                        report = new BOSReport.RP046VND();
                    }
                    else
                        report = new BOSReport.RP046Currencys();
                }
                else
                {
                    report = new BOSReport.RP046Currencys();

                }
            }
            else
            {
                if (currencyID > 0)
                {
                    if (currencyID == GECurrencyID.VND)
                    {
                        report = new BOSReport.RP046VNDACCount();
                    }
                    else
                        report = new BOSReport.RP046CurrencysACCount();
                }
                else
                {
                    report = new BOSReport.RP046CurrencysACCount();
                }
            }
            InitDataSourceReport(report);
            //xrReportTitle
            XRLabel xrReportTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrReportTitle"];
            if (xrReportTitle != null)
                xrReportTitle.Text = stringReportTitle;
            guiReportPreview reviewer = new guiReportPreview(report, false);
            reviewer.Show();
        }
        /// <summary>
        /// Init accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountList = objAccountsController.GetReceivableAccounts();
            fld_dgcACRP049Accounts.DataSource = AccountList;
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);

            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
            List<ACAccountsInfo> ItemSelectList = new List<ACAccountsInfo>();
            if (selectedAccounts != null && selectedAccounts.Count > 0)
            {
                foreach (ACAccountsInfo item in selectedAccounts)
                {
                    List<ACAccountsInfo> CheckSelectList = new List<ACAccountsInfo>();
                    CheckSelectList = AccountList.Where(acc => acc.ACAccountParentID == item.ACAccountID).ToList();
                    if (CheckSelectList != null && CheckSelectList.Count > 0)
                    {
                        ItemSelectList.AddRange(CheckSelectList);
                    }
                }
                if (ItemSelectList != null && ItemSelectList.Any())
                    selectedAccounts.AddRange(ItemSelectList);
            }
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            List<string> accountID = selectedAccounts.Select(x => x.ACAccountID.ToString()).Distinct().ToList();
            List<string> accountNo = selectedAccounts.Select(x => x.ACAccountNo.ToString()).Distinct().ToList();
            List<string> accountName = selectedAccounts.Select(x => x.ACAccountName.ToString()).Distinct().ToList();
            //xrReportTitle
            XRLabel AcountDesc = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAcountDesc"];
            XRLabel xrlblAccount = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrlblAccount"];
            if (AcountDesc != null && !fld_chkGroupByAcount.Checked)
            {
                ACAccountsInfo selectedDefualt = AccountList.Where(acc => acc.Selected == true).FirstOrDefault();
                if (selectedDefualt != null)
                    AcountDesc.Text = string.Join(",", accountNo.ToArray()) + " - " + string.Join(",", accountName.ToArray());
            }
            else
            {
                if (AcountDesc != null)
                    AcountDesc.Visible = false;
                if (xrlblAccount != null)
                    xrlblAccount.Visible = false;
            }
            report.DataSource = GetData(accountID, accountNo, dateFrom, dateTo, currencyID, branchID);
        }

        private void RP049_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_chkGroupByAcount.Checked = false;
            IsgroupByCurency = false;
            InitAccounts();
        }

        private void fld_chkSellectAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (ACAccountsInfo objAccountsInfo in AccountList)
            {
                objAccountsInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcACRP049Accounts.RefreshDataSource();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            IsgroupByCurency = true;
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            BOSList<ACDocumentEntrysInfo> entries = InitDataViewRP049();
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
            if (currencyID > 0)
            {
                if (currencyID == GECurrencyID.VND)
                {
                    guiRP049Show gui = new guiRP049Show(entries, dateFrom, dateTo, selectedAccounts, currencyID, branchID, "RP049");
                    gui.Module = Module;
                    gui.ShowDialog();
                }
                else
                {
                    guiRP049CurrencyShow gui = new guiRP049CurrencyShow(entries, dateFrom, dateTo, selectedAccounts, currencyID, branchID, "RP049");
                    gui.Module = Module;
                    gui.ShowDialog();
                }
            }
            else
            {
                guiRP049CurrencyShow gui = new guiRP049CurrencyShow(entries, dateFrom, dateTo, selectedAccounts, currencyID, branchID, "RP049");
                gui.Module = Module;
                gui.ShowDialog();
            }
        }

        public BOSList<ACDocumentEntrysInfo> InitDataViewRP049()
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
            List<ACAccountsInfo> ItemSelectList = new List<ACAccountsInfo>();
            if (selectedAccounts != null && selectedAccounts.Count > 0)
            {
                foreach (ACAccountsInfo item in selectedAccounts)
                {
                    List<ACAccountsInfo> CheckSelectList = new List<ACAccountsInfo>();
                    CheckSelectList = AccountList.Where(acc => acc.ACAccountParentID == item.ACAccountID).ToList();
                    if (CheckSelectList != null && CheckSelectList.Count > 0)
                    {
                        ItemSelectList.AddRange(CheckSelectList);
                    }
                }
                if (ItemSelectList != null && ItemSelectList.Any())
                    selectedAccounts.AddRange(ItemSelectList);
            }
            List<string> accountID = selectedAccounts.Select(x => x.ACAccountID.ToString()).Distinct().ToList();
            List<string> accountNo = selectedAccounts.Select(x => x.ACAccountNo.ToString()).Distinct().ToList();
            List<ACDocumentEntrysInfo> entries = GetData(accountID, accountNo, dateFrom, dateTo, currencyID, branchID);
            BOSList<ACDocumentEntrysInfo> data = new BOSList<ACDocumentEntrysInfo>();
            data.Invalidate(entries);
            return data;
        }

        public List<ACDocumentEntrysInfo> GetData(List<string> accountID, List<string> accountNo, DateTime dateFrom, DateTime dateTo, int currencyID, int branchID)
        {
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> entries = new BOSList<ACDocumentEntrysInfo>();
            //Get data 
            if (accountID != null && accountID.Count > 0)
            {
                if (fld_chkGroupByAcount.Checked)
                {
                    entries = objDocumentEntrysController.GetDocumentEntryGroupByAcountSoTHCN(dateFrom, dateTo, currencyID, string.Join(",", accountID.ToArray()), branchID);
                }
                else
                    entries = objDocumentEntrysController.GetDocumentEntrySoTHCN(dateFrom, dateTo, currencyID, string.Join(",", accountID.ToArray()), branchID);

                //Tách tài khoản
                if (fld_chkGroupByAcount.Checked)
                {
                    foreach (string itemNo in accountNo)
                    {
                        // Add group
                        if (IsgroupByCurency && entries != null && entries.Any())
                        {
                            List<string> CurencyNo = entries.Where(o => o.ACAccountNo == itemNo).Select(x => x.GECurrencyName).Distinct().ToList();
                            if (CurencyNo != null)
                            {
                                foreach (string curName in CurencyNo)
                                {
                                    List<ACDocumentEntrysInfo> entrieCurs = new List<ACDocumentEntrysInfo>();
                                    entrieCurs = entries.Where(x => x.GECurrencyName == curName && x.ACAccountNo == itemNo).ToList();
                                    if (entrieCurs != null && entrieCurs.Any())
                                    {
                                        ACDocumentEntrysInfo endBalance = new ACDocumentEntrysInfo();
                                        endBalance.OrderNum = 1;
                                        endBalance.StartPeriodDebitBalance = entrieCurs.Sum(o => o.StartPeriodDebitBalance);
                                        endBalance.StartPeriodDebitExchangeBalance = entrieCurs.Sum(o => o.StartPeriodDebitExchangeBalance);
                                        endBalance.StartPeriodCreditBalance = entrieCurs.Sum(o => o.StartPeriodCreditBalance);
                                        endBalance.StartPeriodCreditExchangeBalance = entrieCurs.Sum(o => o.StartPeriodCreditExchangeBalance);
                                        endBalance.ACDocumentEntryDebitAmount = entrieCurs.Sum(o => o.ACDocumentEntryDebitAmount);
                                        endBalance.ACDocumentEntryDebitExchangeAmount = entrieCurs.Sum(o => o.ACDocumentEntryDebitExchangeAmount);
                                        endBalance.ACDocumentEntryCreditAmount = entrieCurs.Sum(o => o.ACDocumentEntryCreditAmount);
                                        endBalance.ACDocumentEntryCreditExchangeAmount = entrieCurs.Sum(o => o.ACDocumentEntryCreditExchangeAmount);
                                        endBalance.EndPeriodDebitBalance = entrieCurs.Sum(o => o.EndPeriodDebitBalance);
                                        endBalance.EndPeriodDebitExchangeBalance = entrieCurs.Sum(o => o.EndPeriodDebitExchangeBalance);
                                        endBalance.EndPeriodCreditBalance = entrieCurs.Sum(o => o.EndPeriodCreditBalance);
                                        endBalance.EndPeriodCreditExchangeBalance = entrieCurs.Sum(o => o.EndPeriodCreditExchangeBalance);
                                        endBalance.ACDocumentDate = dateTo;
                                        endBalance.StartPeriodBalance = 0;
                                        endBalance.StartPeriodExchangeBalance = 0;
                                        endBalance.AccountBalance = 0;
                                        endBalance.AccountExchangeBalance = 0;
                                        endBalance.EndPeriodBalance = 0;
                                        endBalance.EndPeriodExchangeBalance = 0;
                                        endBalance.ACObjectName = "Tổng: " + curName;
                                        endBalance.ACDocumentEntryAccountNo = entrieCurs[0].ACAccountNo;
                                        endBalance.ACAccountNo = entrieCurs[0].ACAccountNo;
                                        endBalance.ACDocumentEntryAccountNoDisplayText = entrieCurs[0].ACDocumentEntryAccountNoDisplayText;
                                        endBalance.GECurrencyName = curName;
                                        endBalance.IsEndBalance = true;
                                        entries.Add(endBalance);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Add group
                    if (IsgroupByCurency && entries != null && entries.Any())
                    {
                        List<string> CurencyNo = entries.Select(x => x.GECurrencyName).Distinct().ToList();
                        if (CurencyNo != null)
                        {
                            foreach (string curName in CurencyNo)
                            {
                                List<ACDocumentEntrysInfo> entrieCurs = new List<ACDocumentEntrysInfo>();
                                entrieCurs = entries.Where(x => x.GECurrencyName == curName).ToList();
                                if (entrieCurs != null)
                                {
                                    ACDocumentEntrysInfo endBalance = new ACDocumentEntrysInfo();
                                    endBalance.OrderNum = 1;
                                    endBalance.StartPeriodDebitBalance = entrieCurs.Sum(o => o.StartPeriodDebitBalance);
                                    endBalance.StartPeriodDebitExchangeBalance = entrieCurs.Sum(o => o.StartPeriodDebitExchangeBalance);
                                    endBalance.StartPeriodCreditBalance = entrieCurs.Sum(o => o.StartPeriodCreditBalance);
                                    endBalance.StartPeriodCreditExchangeBalance = entrieCurs.Sum(o => o.StartPeriodCreditExchangeBalance);
                                    endBalance.ACDocumentEntryDebitAmount = entrieCurs.Sum(o => o.ACDocumentEntryDebitAmount);
                                    endBalance.ACDocumentEntryDebitExchangeAmount = entrieCurs.Sum(o => o.ACDocumentEntryDebitExchangeAmount);
                                    endBalance.ACDocumentEntryCreditAmount = entrieCurs.Sum(o => o.ACDocumentEntryCreditAmount);
                                    endBalance.ACDocumentEntryCreditExchangeAmount = entrieCurs.Sum(o => o.ACDocumentEntryCreditExchangeAmount);
                                    endBalance.EndPeriodDebitBalance = entrieCurs.Sum(o => o.EndPeriodDebitBalance);
                                    endBalance.EndPeriodDebitExchangeBalance = entrieCurs.Sum(o => o.EndPeriodDebitExchangeBalance);
                                    endBalance.EndPeriodCreditBalance = entrieCurs.Sum(o => o.EndPeriodCreditBalance);
                                    endBalance.EndPeriodCreditExchangeBalance = entrieCurs.Sum(o => o.EndPeriodCreditExchangeBalance);
                                    endBalance.ACDocumentDate = dateTo;
                                    endBalance.StartPeriodBalance = 0;
                                    endBalance.StartPeriodExchangeBalance = 0;
                                    endBalance.AccountBalance = 0;
                                    endBalance.AccountExchangeBalance = 0;
                                    endBalance.EndPeriodBalance = 0;
                                    endBalance.EndPeriodExchangeBalance = 0;
                                    // endBalance.ACDocumentEntryAccountNo = string.Join(",", accountNo.ToArray()) + " - " + string.Join(",", accountName.ToArray());
                                    endBalance.ACObjectName = "Tổng: " + curName;
                                    endBalance.GECurrencyName = curName;
                                    endBalance.IsEndBalance = true;
                                    entries.Add(endBalance);
                                }
                            }
                        }
                    }
                }

            }
            return (from m in entries
                    orderby m.ACAccountNo, m.GECurrencyName, m.OrderNum
                    select m).ToList();
        }
    }
}
