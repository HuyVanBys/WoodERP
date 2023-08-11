using BOSCommon.Constants;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP153 : ReportForm
    {
        /// <summary>
        /// A variable indicates whether the report has gotten the previous cash flow
        /// </summary>
        private bool GetPrevCashFlow = false;

        public RP153()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP153 report = new BOSReport.RP153();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP056Path);
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP056Path, true);
            reviewer.Show();
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
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            //List<ACCashFlowsInfo> cashFlows = new List<ACCashFlowsInfo>();
            //GetPrevCashFlow = false;
            //ACCashFlowsInfo cashFlow = GetCashFlow(dateFrom, dateTo);
            //cashFlows.Add(cashFlow);
            //report.DataSource = cashFlows;

            DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(dateFrom.AddDays(-1));
            DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(dateFrom.AddDays(-1));
            //DateTime prevPeriodStartDate = dateFrom.AddYears(-1);
            //DateTime prevPeriodEndDate = BOSUtil.GetMonthEndDate(dateFrom.AddYears(-1));
            DateTime prevPeriod = BOSApp.GetPeriodEndDate(dateFrom.AddDays(-1));

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();

            GEAccountingFormulaItemsController objAccountingFormulaItemsController = new GEAccountingFormulaItemsController();
            List<GEAccountingFormulaItemsInfo> ListItem = objAccountingFormulaItemsController.GetObjectForReport("Báo cáo lưu chuyển tiền tệ");
            List<GEAccountingFormulaItemsInfo> ListParent = new List<GEAccountingFormulaItemsInfo>();
            List<GEAccountingFormulaItemsInfo> ListView = new List<GEAccountingFormulaItemsInfo>();
            List<GEAccountingFormulaItemsInfo> List = new List<GEAccountingFormulaItemsInfo>();
            decimal totalStart = 0;
            decimal totalEnd = 0;
            decimal exceptedDebitAmountStart = 0;
            decimal exceptedDebitAmountEnd = 0;
            decimal exceptedCreditAmountStart = 0;
            decimal exceptedCreditAmountEnd = 0;

            if (ListItem != null && ListItem.Count > 0)
            {
                foreach (GEAccountingFormulaItemsInfo objAccountingFormulaItemsInfo in ListItem)
                {
                    if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountNo)
                        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemFormula))
                    {
                        string[] debitAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);
                        string[] creditAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);
                        string[] exceptDebit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);
                        string[] exceptCredit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);

                        exceptedDebitAmountStart = 0;
                        exceptedDebitAmountEnd = 0;
                        exceptedCreditAmountStart = 0;
                        exceptedCreditAmountEnd = 0;

                        totalStart = GetAccountDebitAmount(
                                                            debitAccount,
                                                            creditAccount,
                                                            prevPeriodStartDate,
                                                            prevPeriodEndDate);
                        totalEnd = GetAccountDebitAmount(
                                                        debitAccount,
                                                        creditAccount,
                                                        dateFrom,
                                                        dateTo);

                        if (exceptDebit.Count() != 0)
                        {
                            exceptedDebitAmountStart = GetAccountDebitAmount(
                                                                        exceptDebit,
                                                                        creditAccount,
                                                                        prevPeriodStartDate,
                                                                        prevPeriodEndDate);
                            exceptedDebitAmountEnd = GetAccountDebitAmount(
                                                                    exceptDebit,
                                                                    creditAccount,
                                                                    dateFrom,
                                                                    dateTo);
                        }

                        if (exceptCredit.Count() != 0)
                        {
                            exceptedCreditAmountStart = GetAccountDebitAmount(
                                                                        debitAccount,
                                                                        exceptCredit,
                                                                        prevPeriodStartDate,
                                                                        prevPeriodEndDate);
                            exceptedCreditAmountEnd = GetAccountDebitAmount(
                                                                     debitAccount,
                                                                     exceptCredit,
                                                                     dateFrom,
                                                                     dateTo);
                        }

                        if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotCong.ToString())
                        {

                            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - exceptedDebitAmountStart - exceptedCreditAmountStart;
                            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - exceptedDebitAmountEnd - exceptedCreditAmountEnd;
                        }
                        else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
                        {

                            objAccountingFormulaItemsInfo.StartYearBalance = -(totalStart - exceptedDebitAmountStart - exceptedCreditAmountStart);
                            objAccountingFormulaItemsInfo.EndYearBalance = -(totalEnd - exceptedDebitAmountEnd - exceptedCreditAmountEnd);
                        }
                        if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountNo == "60A")
                        {
                            objAccountingFormulaItemsInfo.StartYearBalance = 0;
                            objAccountingFormulaItemsInfo.EndYearBalance = objDocumentEntrysController.GetAccountBalanceByBranchNoList("111", prevPeriod, null, null, null, null, null)
                                                                                + objDocumentEntrysController.GetAccountBalanceByBranchNoList("112", prevPeriod, null, null, null, null, null);
                            //objAccountingFormulaItemsInfo.EndYearBalance = objDocumentEntrysController.GetAccountBalanceByBranchNoList("111", prevPeriodEndDate, null, null, null, null, null)
                            //                                                    + objDocumentEntrysController.GetAccountBalanceByBranchNoList("112", prevPeriodEndDate, null, null, null, null, null); 

                            //ACAccountsController objAccountsController = new ACAccountsController();
                            //ACAccountsInfo account1 = (ACAccountsInfo)objAccountsController.GetObjectByNo("111");
                            //account1 = objAccountsController.GetAccountInitialBalanceBySomeCriteria(account1.ACAccountNo, null, null, null, null, null);
                            //ACAccountsInfo account2 = (ACAccountsInfo)objAccountsController.GetObjectByNo("112");
                            //account2 = objAccountsController.GetAccountInitialBalanceBySomeCriteria(account2.ACAccountNo, null, null, null, null, null);
                            //objAccountingFormulaItemsInfo.StartYearBalance = account1.ACAccountInitialBalance + account2.ACAccountInitialBalance;
                            //objAccountingFormulaItemsInfo.EndYearBalance = account1.ACAccountInitialBalance + account2.ACAccountInitialBalance;
                        }
                        //    if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit) &&
                        //        !string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit) &&
                        //        string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit)&& 
                        //        string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit))
                        //    {
                        //        string[] debitAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit.Split(',');
                        //        foreach (string account in debitAccount)
                        //        {
                        //            account.Trim();
                        //        }
                        //        string[] creditAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit.Split(',');
                        //        foreach (string account in creditAccount)
                        //        {
                        //            account.Trim();
                        //        }
                        //        if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotCong.ToString())
                        //        {

                        //            objAccountingFormulaItemsInfo.StartYearBalance = GetAccountDebitAmount(
                        //                                                                                debitAccount,
                        //                                                                                creditAccount,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = GetAccountDebitAmount(
                        //                                                                                debitAccount,
                        //                                                                                creditAccount,
                        //                                                                                dateFrom,
                        //                                                                                dateTo);
                        //        }
                        //        else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
                        //        {

                        //            objAccountingFormulaItemsInfo.StartYearBalance = -GetAccountDebitAmount(
                        //                                                                                debitAccount,
                        //                                                                                creditAccount,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = -GetAccountDebitAmount(
                        //                                                                                debitAccount,
                        //                                                                                creditAccount,
                        //                                                                                dateFrom,
                        //                                                                                dateTo);
                        //        }
                        //    }
                        //    else if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit)
                        //        && !string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit)
                        //        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit)
                        //        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit))
                        //    {
                        //        string[] exceptDebit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit.Split(',');
                        //        foreach (string account in exceptDebit)
                        //        {
                        //            account.Trim();
                        //        }
                        //        string[] creditAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit.Split(',');
                        //        foreach (string account in creditAccount)
                        //        {
                        //            account.Trim();
                        //        }

                        //        if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotCong.ToString())
                        //        {

                        //            totalStart = GetAccountDebitAmount(
                        //                                                new string [] {},
                        //                                                creditAccount,
                        //                                                prevPeriodStartDate,
                        //                                                prevPeriodEndDate);

                        //            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - (GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                creditAccount,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate));

                        //            totalEnd = GetAccountDebitAmount(
                        //                                            new string[] {},
                        //                                            creditAccount,
                        //                                            dateFrom,
                        //                                            dateTo);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - (GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                creditAccount,
                        //                                                                                dateFrom,
                        //                                                                                dateTo));
                        //        }
                        //        else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
                        //        {

                        //            totalStart = -GetAccountDebitAmount(
                        //                                                new string[] { },
                        //                                                creditAccount,
                        //                                                prevPeriodStartDate,
                        //                                                prevPeriodEndDate);

                        //            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - (-GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                creditAccount,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate));

                        //            totalEnd = -GetAccountDebitAmount(
                        //                                            new string[] { },
                        //                                            creditAccount,
                        //                                            dateFrom,
                        //                                            dateTo);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - (-GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                creditAccount,
                        //                                                                                dateFrom,
                        //                                                                                dateTo));
                        //        }
                        //    }

                        //    else if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit)
                        //        && !string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit)
                        //        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit)
                        //        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit))
                        //    {
                        //        string[] accountDebit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit.Split(',');
                        //        foreach (string account in accountDebit)
                        //        {
                        //            account.Trim();
                        //        }
                        //        string[] exceptCredit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit.Split(',');
                        //        foreach (string account in exceptCredit)
                        //        {
                        //            account.Trim();
                        //        }

                        //        if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotCong.ToString())
                        //        {

                        //            totalStart = GetAccountDebitAmount(
                        //                                                accountDebit,
                        //                                                new string[] { },
                        //                                                prevPeriodStartDate,
                        //                                                prevPeriodEndDate);

                        //            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - (GetAccountDebitAmount(
                        //                                                                                accountDebit,
                        //                                                                                exceptCredit,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate));

                        //            totalEnd = GetAccountDebitAmount(
                        //                                            accountDebit,
                        //                                            new string[] { },
                        //                                            dateFrom,
                        //                                            dateTo);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - (GetAccountDebitAmount(
                        //                                                                                accountDebit,
                        //                                                                                exceptCredit,
                        //                                                                                dateFrom,
                        //                                                                                dateTo));
                        //        }
                        //        else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
                        //        {

                        //            totalStart = -GetAccountDebitAmount(
                        //                                                accountDebit,
                        //                                                new string[] { },
                        //                                                prevPeriodStartDate,
                        //                                                prevPeriodEndDate);

                        //            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - (-GetAccountDebitAmount(
                        //                                                                                accountDebit,
                        //                                                                                exceptCredit,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate));

                        //            totalEnd = -GetAccountDebitAmount(
                        //                                            accountDebit,
                        //                                            new string[] { },
                        //                                            dateFrom,
                        //                                            dateTo);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - (-GetAccountDebitAmount(
                        //                                                                                accountDebit,
                        //                                                                                exceptCredit,
                        //                                                                                dateFrom,
                        //                                                                                dateTo));
                        //        }
                        //    }
                        //    else if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit)
                        //        && !string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit)
                        //        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit)
                        //        && string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit))
                        //    {
                        //        string[] exceptDebit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountDebit.Split(',');
                        //        foreach (string account in exceptDebit)
                        //        {
                        //            account.Trim();
                        //        }
                        //        string[] exceptCredit = objAccountingFormulaItemsInfo.GEAccountingFormulaItemExceptAccountCredit.Split(',');
                        //        foreach (string account in exceptCredit)
                        //        {
                        //            account.Trim();
                        //        }

                        //        if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotCong.ToString())
                        //        {

                        //            totalStart = GetAccountDebitAmount(
                        //                                                new string[] { },
                        //                                                new string[] { },
                        //                                                prevPeriodStartDate,
                        //                                                prevPeriodEndDate);

                        //            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - (GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                exceptCredit,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate));

                        //            totalEnd = GetAccountDebitAmount(
                        //                                            new string[] { },
                        //                                            new string[] { },
                        //                                            dateFrom,
                        //                                            dateTo);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - (GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                exceptCredit,
                        //                                                                                dateFrom,
                        //                                                                                dateTo));
                        //        }
                        //        else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
                        //        {

                        //            totalStart = -GetAccountDebitAmount(
                        //                                                new string[] { },
                        //                                                new string[] { },
                        //                                                prevPeriodStartDate,
                        //                                                prevPeriodEndDate);

                        //            objAccountingFormulaItemsInfo.StartYearBalance = totalStart - (-GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                exceptCredit,
                        //                                                                                prevPeriodStartDate,
                        //                                                                                prevPeriodEndDate));

                        //            totalEnd = -GetAccountDebitAmount(
                        //                                            new string[] { },
                        //                                            new string[] { },
                        //                                            dateFrom,
                        //                                            dateTo);
                        //            objAccountingFormulaItemsInfo.EndYearBalance = totalEnd - (-GetAccountDebitAmount(
                        //                                                                                exceptDebit,
                        //                                                                                exceptCredit,
                        //                                                                                dateFrom,
                        //                                                                                dateTo));
                        //        }
                        //    }
                    }
                }
                foreach (GEAccountingFormulaItemsInfo parent in ListItem)
                {
                    //if (!parent.GEAccountingFormulaItemAccountNo.Equals("110"))
                    //{
                    //    continue;
                    //}
                    if (!string.IsNullOrEmpty(parent.GEAccountingFormulaItemFormula) && parent.StartYearBalance == 0 && parent.EndYearBalance == 0)
                    {
                        List = getListByNo(parent.GEAccountingFormulaItemFormula, ListItem);
                        if (List.Count > 0)
                        {
                            parent.StartYearBalance = 0;
                            parent.EndYearBalance = 0;
                            CalculationBalance(parent, List, ListItem);
                        }
                    }
                }

                foreach (GEAccountingFormulaItemsInfo obj in ListItem)
                {
                    if (obj.GEAccountingFormulaItemShowPrint == true)
                    {
                        ListView.Add(obj);
                    }
                }

                ListView = ListView.OrderBy(item => item.GEAccountingFormulaItemNumber).ToList();
                report.DataSource = ListView;
            }

        }
        private GEAccountingFormulaItemsInfo CalculationBalance(GEAccountingFormulaItemsInfo obj, List<GEAccountingFormulaItemsInfo> childList, List<GEAccountingFormulaItemsInfo> ListItem)
        {
            List<GEAccountingFormulaItemsInfo> check = new List<GEAccountingFormulaItemsInfo>();
            foreach (GEAccountingFormulaItemsInfo item in childList)
            {
                if (item == null)
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(item.GEAccountingFormulaItemFormula)
                    //&& string.IsNullOrEmpty(item.GEAccountingFormulaItemAccountNo)
                    && item.StartYearBalance == 0 && item.EndYearBalance == 0)
                {
                    check = getListByNo(item.GEAccountingFormulaItemFormula, ListItem);
                    if (check.Count > 0)
                    {
                        CalculationBalance(item, check, ListItem);
                    }
                }
                obj.StartYearBalance += item.StartYearBalance;
                obj.EndYearBalance += item.EndYearBalance;
            }
            return obj;
        }

        private List<GEAccountingFormulaItemsInfo> getListByNo(String formula, List<GEAccountingFormulaItemsInfo> ListItem)
        {
            List<GEAccountingFormulaItemsInfo> check = new List<GEAccountingFormulaItemsInfo>();
            string[] AssetNos = formula.Split('+');
            foreach (string asset in AssetNos)
            {
                GEAccountingFormulaItemsInfo objItems = ListItem.Where(p => p.GEAccountingFormulaItemAccountNo.Equals(asset.Trim())).FirstOrDefault();
                check.Add(objItems);
            }
            return check;
        }

        private decimal GetAccountDebitAmount(string[] accountNumbers, string[] contraryAccountNumbers, DateTime fromDate, DateTime toDate)
        {
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            decimal debitAmount = 0;
            if (accountNumbers.Count() != 0 && contraryAccountNumbers.Count() != 0)
            {
                foreach (string accountNo in accountNumbers)
                {
                    foreach (string contraryAccountNo in contraryAccountNumbers)
                    {
                        debitAmount += objDocumentEntrysController.GetAccountDocumentEntryExchangeAmount(accountNo, contraryAccountNo, fromDate, toDate);
                    }
                }
            }
            else if (accountNumbers.Count() == 0)
            {
                foreach (string contraryAccountNo in contraryAccountNumbers)
                {
                    debitAmount += objDocumentEntrysController.GetAccountDocumentEntryExchangeAmount(string.Empty, contraryAccountNo, fromDate, toDate);
                }
            }
            else if (contraryAccountNumbers.Count() == 0)
            {
                foreach (string accountNo in accountNumbers)
                {
                    debitAmount += objDocumentEntrysController.GetAccountDocumentEntryExchangeAmount(accountNo, string.Empty, fromDate, toDate);
                }
            }

            return debitAmount;
        }


        private decimal GetAccountCreditAmount(string[] accountNumbers, string[] contraryAccountNumbers, DateTime fromDate, DateTime toDate)
        {
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            decimal creditAmount = 0;
            foreach (string accountNo in accountNumbers)
            {
                foreach (string contraryAccountNo in contraryAccountNumbers)
                {
                    creditAmount += objDocumentEntrysController.GetAccountCreditExchangeAmount(accountNo, contraryAccountNo, fromDate, toDate);
                }
            }
            return creditAmount;
        }

        private void RP056_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }
    }
}
