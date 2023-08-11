using BOSCommon.Constants;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Report
{
    public partial class RP055 : ReportForm
    {
        public RP055()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP055 report = new BOSReport.RP055();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP055Path);
            InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP055Path, true);
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
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
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
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            ACIncomeStatementsInfo objIncomeStatementsInfo = GetIncomeStatement();
            List<ACIncomeStatementsInfo> incomeStatementList = new List<ACIncomeStatementsInfo>();
            incomeStatementList.Add(objIncomeStatementsInfo);
            report.DataSource = incomeStatementList;
        }

        /// <summary>
        /// Get the income statement
        /// </summary>
        /// <returns>Income statement object</returns>
        private ACIncomeStatementsInfo GetIncomeStatement()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(fromDate.AddDays(-1));
            DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(fromDate.AddDays(-1));

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACIncomeStatementsInfo incomeStatement = new ACIncomeStatementsInfo();
            incomeStatement.ACNo01StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc511, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo01StartPeriodAmount += objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc512, prevPeriodStartDate, prevPeriodEndDate);

            incomeStatement.ACNo01EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc511, fromDate, toDate);
            incomeStatement.ACNo01EndPeriodAmount += objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc512, fromDate, toDate);

            incomeStatement.ACNo02StartPeriodAmount = GetAccountDebitAmount(
                                                                        new string[] { AccAccount.Acc511, AccAccount.Acc512 },
                                                                        new string[] { AccAccount.Acc521, AccAccount.Acc531, AccAccount.Acc532 },
                                                                        prevPeriodStartDate,
                                                                        prevPeriodEndDate);
            incomeStatement.ACNo02EndPeriodAmount = GetAccountDebitAmount(
                                                                        new string[] { AccAccount.Acc511, AccAccount.Acc512 },
                                                                        new string[] { AccAccount.Acc521, AccAccount.Acc531, AccAccount.Acc532 },
                                                                        fromDate,
                                                                        toDate);

            incomeStatement.ACNo10StartPeriodAmount = incomeStatement.ACNo01StartPeriodAmount - incomeStatement.ACNo02StartPeriodAmount;
            incomeStatement.ACNo10EndPeriodAmount = incomeStatement.ACNo01EndPeriodAmount - incomeStatement.ACNo02EndPeriodAmount;

            incomeStatement.ACNo11StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc632, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo11EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc632, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo20StartPeriodAmount = incomeStatement.ACNo10StartPeriodAmount - incomeStatement.ACNo11StartPeriodAmount;
            incomeStatement.ACNo20EndPeriodAmount = incomeStatement.ACNo10EndPeriodAmount - incomeStatement.ACNo11EndPeriodAmount;

            incomeStatement.ACNo21StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc515, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo21EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc515, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo22StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc635, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo22EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc635, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo23StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount("6351", AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate)
                + objDocumentEntrysController.GetAccountCreditAmount("6352", AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate)
                + objDocumentEntrysController.GetAccountCreditAmount("6353", AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo23EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount("6351", AccAccount.Acc911, fromDate, toDate)
                + objDocumentEntrysController.GetAccountCreditAmount("6352", AccAccount.Acc911, fromDate, toDate)
                + objDocumentEntrysController.GetAccountCreditAmount("6353", AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo24StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc641, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo24EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc641, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo25StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc642, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo25EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc642, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo30StartPeriodAmount = incomeStatement.ACNo20StartPeriodAmount + (incomeStatement.ACNo21StartPeriodAmount - incomeStatement.ACNo22StartPeriodAmount) -
                                                    incomeStatement.ACNo24StartPeriodAmount - incomeStatement.ACNo25StartPeriodAmount;
            incomeStatement.ACNo30EndPeriodAmount = incomeStatement.ACNo20EndPeriodAmount + (incomeStatement.ACNo21EndPeriodAmount - incomeStatement.ACNo22EndPeriodAmount) -
                                                    incomeStatement.ACNo24EndPeriodAmount - incomeStatement.ACNo25EndPeriodAmount;

            incomeStatement.ACNo31StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc711, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo31EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc711, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo32StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc811, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo32EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc811, AccAccount.Acc911, fromDate, toDate);

            incomeStatement.ACNo40StartPeriodAmount = incomeStatement.ACNo31StartPeriodAmount - incomeStatement.ACNo32StartPeriodAmount;
            incomeStatement.ACNo40EndPeriodAmount = incomeStatement.ACNo31EndPeriodAmount - incomeStatement.ACNo32EndPeriodAmount;

            incomeStatement.ACNo50StartPeriodAmount = incomeStatement.ACNo30StartPeriodAmount + incomeStatement.ACNo40StartPeriodAmount;
            incomeStatement.ACNo50EndPeriodAmount = incomeStatement.ACNo30EndPeriodAmount + incomeStatement.ACNo40EndPeriodAmount;

            incomeStatement.ACNo51StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc8211, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc8211, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo51EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc8211, AccAccount.Acc911, fromDate, toDate) -
                                                    objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc8211, AccAccount.Acc911, fromDate, toDate);
            incomeStatement.ACNo52StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc8212, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc8212, AccAccount.Acc911, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.ACNo52EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmount(AccAccount.Acc8212, fromDate, toDate) -
                                                    objDocumentEntrysController.GetAccountDebitAmount(AccAccount.Acc8212, fromDate, toDate);
            incomeStatement.ACNo60StartPeriodAmount = incomeStatement.ACNo50StartPeriodAmount - (incomeStatement.ACNo51StartPeriodAmount + incomeStatement.ACNo52StartPeriodAmount);
            incomeStatement.ACNo60EndPeriodAmount = incomeStatement.ACNo50EndPeriodAmount - (incomeStatement.ACNo51EndPeriodAmount + incomeStatement.ACNo52EndPeriodAmount);

            return incomeStatement;
        }

        private decimal GetAccountDebitAmount(string[] accountNumbers, string[] contraryAccountNumbers, DateTime fromDate, DateTime toDate)
        {
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            decimal debitAmount = 0;
            foreach (string accountNo in accountNumbers)
            {
                foreach (string contraryAccountNo in contraryAccountNumbers)
                {
                    debitAmount += objDocumentEntrysController.GetAccountDebitAmount(accountNo, contraryAccountNo, fromDate, toDate);
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
                    creditAmount += objDocumentEntrysController.GetAccountCreditAmount(accountNo, contraryAccountNo, fromDate, toDate);
                }
            }
            return creditAmount;
        }

        private void RP055_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }
    }
}
