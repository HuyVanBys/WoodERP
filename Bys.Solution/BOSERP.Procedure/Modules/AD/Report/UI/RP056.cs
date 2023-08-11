using BOSCommon.Constants;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Report
{
    public partial class RP056 : ReportForm
    {
        /// <summary>
        /// A variable indicates whether the report has gotten the previous cash flow
        /// </summary>
        private bool GetPrevCashFlow = false;

        public RP056()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP056 report = new BOSReport.RP056();
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

            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            List<ACCashFlowsInfo> cashFlows = new List<ACCashFlowsInfo>();
            GetPrevCashFlow = false;
            ACCashFlowsInfo cashFlow = GetCashFlow(dateFrom, dateTo);
            cashFlows.Add(cashFlow);
            report.DataSource = cashFlows;
        }

        /// <summary>
        /// Gets the cash flow.
        /// </summary>
        /// <param name="fromDate">Start date of the report period</param>
        /// <param name="toDate">End date of the report period</param>
        /// <returns>The cash flow object</returns>
        private ACCashFlowsInfo GetCashFlow(DateTime fromDate, DateTime toDate)
        {
            DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(fromDate.AddDays(-1));
            DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(fromDate.AddDays(-1));

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACCashFlowsInfo cashFlow = new ACCashFlowsInfo();

            #region Luu chuyen tien tu hoat dong kinh doanh
            cashFlow.AC01StartPeriodAmount = GetAccountDebitAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112 },
                                                        new string[] { AccAccount.Acc511, AccAccount.Acc515, AccAccount.Acc131, AccAccount.Acc331 },
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC01EndPeriodAmount = GetAccountDebitAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112 },
                                                        new string[] { AccAccount.Acc511, AccAccount.Acc515, AccAccount.Acc131, AccAccount.Acc331 },
                                                        fromDate,
                                                        toDate);

            cashFlow.AC02StartPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc331, AccAccount.Acc152, AccAccount.Acc153, AccAccount.Acc156 },
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC02EndPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc331, AccAccount.Acc152, AccAccount.Acc153, AccAccount.Acc156 },
                                                        fromDate,
                                                        toDate);

            cashFlow.AC03StartPeriodAmount = -GetAccountCreditAmount(
                                                        //new string[] { AccAccount.Acc111, AccAccount.Acc112},
                                                        new string[] { AccAccount.Acc111 },
                                                        new string[] { AccAccount.Acc334 },
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC03EndPeriodAmount = -GetAccountCreditAmount(
                                                        //new string[] { AccAccount.Acc111, AccAccount.Acc112 },
                                                        new string[] { AccAccount.Acc111 },
                                                        new string[] { AccAccount.Acc334 },
                                                        fromDate,
                                                        toDate);

            cashFlow.AC04StartPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc635 },
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC04EndPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc635 },
                                                        fromDate,
                                                        toDate);

            cashFlow.AC05StartPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc3334 },
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC05EndPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc3334 },
                                                        fromDate,
                                                        toDate);

            cashFlow.AC06StartPeriodAmount = GetAccountDebitAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc711, AccAccount.Acc133, AccAccount.Acc3386, AccAccount.Acc344,
                                                                       AccAccount.Acc144, AccAccount.Acc244, AccAccount.Acc461, AccAccount.Acc414,
                                                                       AccAccount.Acc415, AccAccount.Acc136, AccAccount.Acc138,
                                                                       AccAccount.Acc112, AccAccount.Acc111},
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);

            cashFlow.AC06EndPeriodAmount = GetAccountDebitAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc711, AccAccount.Acc133, AccAccount.Acc3386, AccAccount.Acc344,
                                                                       AccAccount.Acc144, AccAccount.Acc244, AccAccount.Acc461, AccAccount.Acc414,
                                                                       AccAccount.Acc415, AccAccount.Acc136, AccAccount.Acc138,
                                                                       AccAccount.Acc112, AccAccount.Acc111},
                                                        fromDate,
                                                        toDate);

            cashFlow.AC07StartPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc811, AccAccount.Acc333, AccAccount.Acc144, AccAccount.Acc244,
                                                                       AccAccount.Acc3386, AccAccount.Acc334, AccAccount.Acc351, AccAccount.Acc352,
                                                                       //AccAccount.Acc353, AccAccount.Acc414, AccAccount.Acc415, AccAccount.Acc335, AccAccount.Acc336},
                                                                       AccAccount.Acc431, AccAccount.Acc414, AccAccount.Acc415, AccAccount.Acc335, AccAccount.Acc336},
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate) +
                                              GetAccountCreditAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc3334 },
                                                            prevPeriodStartDate,
                                                            prevPeriodEndDate);
            cashFlow.AC07EndPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc811, AccAccount.Acc333, AccAccount.Acc144, AccAccount.Acc244,
                                                                       AccAccount.Acc3386, AccAccount.Acc334, AccAccount.Acc351, AccAccount.Acc352,
                                                                       //AccAccount.Acc353, AccAccount.Acc414, AccAccount.Acc415, AccAccount.Acc335, AccAccount.Acc336},
                                                                       AccAccount.Acc431, AccAccount.Acc414, AccAccount.Acc415, AccAccount.Acc335, AccAccount.Acc336},
                                                        fromDate,
                                                        toDate) +
                                              GetAccountCreditAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc3334 },
                                                            fromDate,
                                                            toDate);

            cashFlow.AC20StartPeriodAmount = cashFlow.AC01StartPeriodAmount +
                                            cashFlow.AC02StartPeriodAmount +
                                            cashFlow.AC03StartPeriodAmount +
                                            cashFlow.AC04StartPeriodAmount +
                                            cashFlow.AC05StartPeriodAmount +
                                            cashFlow.AC06StartPeriodAmount +
                                            cashFlow.AC07StartPeriodAmount;
            cashFlow.AC20EndPeriodAmount = cashFlow.AC01EndPeriodAmount +
                                            cashFlow.AC02EndPeriodAmount +
                                            cashFlow.AC03EndPeriodAmount +
                                            cashFlow.AC04EndPeriodAmount +
                                            cashFlow.AC05EndPeriodAmount +
                                            cashFlow.AC06EndPeriodAmount +
                                            cashFlow.AC07EndPeriodAmount;
            #endregion

            #region Luu chuyen tien tu hoat dong dau tu
            cashFlow.AC21StartPeriodAmount = -GetAccountCreditAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] {AccAccount.Acc211, AccAccount.Acc213, AccAccount.Acc217, AccAccount.Acc241, 
                                                                    //AccAccount.Acc228, AccAccount.Acc341},
                                                                    AccAccount.Acc228, AccAccount.Acc331, AccAccount.Acc341},
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC21EndPeriodAmount = -GetAccountCreditAmount(
                                                       new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                       new string[] {AccAccount.Acc211, AccAccount.Acc213, AccAccount.Acc217, AccAccount.Acc241, 
                                                                    //AccAccount.Acc228, AccAccount.Acc341},
                                                                    AccAccount.Acc228, AccAccount.Acc331, AccAccount.Acc341},
                                                       fromDate,
                                                       toDate);

            cashFlow.AC22StartPeriodAmount = 0;
            cashFlow.AC22EndPeriodAmount = 0;

            cashFlow.AC23StartPeriodAmount = -GetAccountCreditAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc128, AccAccount.Acc228 },
                                                            prevPeriodStartDate,
                                                            prevPeriodEndDate);
            cashFlow.AC23EndPeriodAmount = -GetAccountCreditAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc128, AccAccount.Acc228 },
                                                            fromDate,
                                                            toDate);

            cashFlow.AC24StartPeriodAmount = GetAccountDebitAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            //new string[] { AccAccount.Acc121, AccAccount.Acc128, AccAccount.Acc228},
                                                            new string[] { AccAccount.Acc121, AccAccount.Acc128, AccAccount.Acc228, AccAccount.Acc515 },
                                                            prevPeriodStartDate,
                                                            prevPeriodEndDate);
            cashFlow.AC24EndPeriodAmount = GetAccountDebitAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            //new string[] { AccAccount.Acc121, AccAccount.Acc128, AccAccount.Acc228},
                                                            new string[] { AccAccount.Acc121, AccAccount.Acc128, AccAccount.Acc228, AccAccount.Acc515 },
                                                            fromDate,
                                                            toDate);

            cashFlow.AC25StartPeriodAmount = -GetAccountCreditAmount(
                                                           new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                           new string[] { AccAccount.Acc121, AccAccount.Acc221, AccAccount.Acc222, AccAccount.Acc223, 
                                                                          //AccAccount.Acc128, AccAccount.Acc228},
                                                                          AccAccount.Acc128, AccAccount.Acc228, AccAccount.Acc635},
                                                           prevPeriodStartDate,
                                                           prevPeriodEndDate);
            cashFlow.AC25EndPeriodAmount = -GetAccountCreditAmount(
                                                           new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                           new string[] { AccAccount.Acc121, AccAccount.Acc221, AccAccount.Acc222, AccAccount.Acc223, 
                                                                          //AccAccount.Acc128, AccAccount.Acc228},
                                                                          AccAccount.Acc128, AccAccount.Acc228, AccAccount.Acc635},
                                                           fromDate,
                                                           toDate);

            cashFlow.AC26StartPeriodAmount = GetAccountDebitAmount(
                                                           new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                           new string[] { AccAccount.Acc121, AccAccount.Acc221, AccAccount.Acc222, AccAccount.Acc223,
                                                                          AccAccount.Acc128, AccAccount.Acc228},
                                                           prevPeriodStartDate,
                                                           prevPeriodEndDate);
            cashFlow.AC26EndPeriodAmount = GetAccountDebitAmount(
                                                           new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                           new string[] { AccAccount.Acc121, AccAccount.Acc221, AccAccount.Acc222, AccAccount.Acc223,
                                                                          AccAccount.Acc128, AccAccount.Acc228},
                                                           fromDate,
                                                           toDate);

            //cashFlow.AC27StartPeriodAmount = 0;
            //cashFlow.AC27EndPeriodAmount = 0;
            cashFlow.AC27StartPeriodAmount = GetAccountDebitAmount(
                                                           new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                           new string[] { AccAccount.Acc515 },
                                                           prevPeriodStartDate,
                                                           prevPeriodEndDate);
            cashFlow.AC27StartPeriodAmount = GetAccountDebitAmount(
                                                           new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                           new string[] { AccAccount.Acc515 },
                                                           fromDate,
                                                           toDate);

            cashFlow.AC30StartPeriodAmount = cashFlow.AC21StartPeriodAmount +
                                            cashFlow.AC22StartPeriodAmount +
                                            cashFlow.AC23StartPeriodAmount +
                                            cashFlow.AC24StartPeriodAmount +
                                            cashFlow.AC25StartPeriodAmount +
                                            cashFlow.AC26StartPeriodAmount +
                                            cashFlow.AC27StartPeriodAmount;
            cashFlow.AC30EndPeriodAmount = cashFlow.AC21EndPeriodAmount +
                                            cashFlow.AC22EndPeriodAmount +
                                            cashFlow.AC23EndPeriodAmount +
                                            cashFlow.AC24EndPeriodAmount +
                                            cashFlow.AC25EndPeriodAmount +
                                            cashFlow.AC26EndPeriodAmount +
                                            cashFlow.AC27EndPeriodAmount;
            #endregion

            #region Luu chuyen tien tu hoat dong tai chinh
            cashFlow.AC31StartPeriodAmount = GetAccountDebitAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc411 },
                                                            prevPeriodStartDate,
                                                            prevPeriodEndDate);
            cashFlow.AC31EndPeriodAmount = GetAccountDebitAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc411 },
                                                            fromDate,
                                                            toDate);

            cashFlow.AC32StartPeriodAmount = -GetAccountCreditAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc411, AccAccount.Acc419 },
                                                            prevPeriodStartDate,
                                                            prevPeriodEndDate);
            cashFlow.AC32StartPeriodAmount = -GetAccountCreditAmount(
                                                            new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                            new string[] { AccAccount.Acc411, AccAccount.Acc419 },
                                                            fromDate,
                                                            toDate);

            cashFlow.AC33StartPeriodAmount = GetAccountDebitAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc311, AccAccount.Acc341, AccAccount.Acc342, AccAccount.Acc343 },
                                                        prevPeriodStartDate,
                                                        prevPeriodEndDate);
            cashFlow.AC33EndPeriodAmount = GetAccountDebitAmount(
                                                        new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                        new string[] { AccAccount.Acc311, AccAccount.Acc341, AccAccount.Acc342, AccAccount.Acc343 },
                                                        fromDate,
                                                        toDate);

            cashFlow.AC34StartPeriodAmount = -GetAccountCreditAmount(
                                                          new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                          //new string[] { AccAccount.Acc311, AccAccount.Acc341, AccAccount.Acc343 },
                                                          new string[] { AccAccount.Acc311, AccAccount.Acc315, AccAccount.Acc341,
                                                                        AccAccount.Acc342, AccAccount.Acc343 },
                                                          prevPeriodStartDate,
                                                          prevPeriodEndDate);
            cashFlow.AC34EndPeriodAmount = -GetAccountCreditAmount(
                                                          new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                          //new string[] { AccAccount.Acc311, AccAccount.Acc341, AccAccount.Acc343 },
                                                          new string[] { AccAccount.Acc311, AccAccount.Acc315, AccAccount.Acc341,
                                                                        AccAccount.Acc342, AccAccount.Acc343 },
                                                          fromDate,
                                                          toDate);

            cashFlow.AC35StartPeriodAmount = -GetAccountCreditAmount(
                                                          new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                          new string[] { AccAccount.Acc315, AccAccount.Acc342 },
                                                          prevPeriodStartDate,
                                                          prevPeriodEndDate);
            cashFlow.AC35EndPeriodAmount = -GetAccountCreditAmount(
                                                          new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                          new string[] { AccAccount.Acc315, AccAccount.Acc342 },
                                                          fromDate,
                                                          toDate);

            cashFlow.AC36StartPeriodAmount = -GetAccountCreditAmount(
                                                          new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                          new string[] { AccAccount.Acc421 },
                                                          prevPeriodStartDate,
                                                          prevPeriodEndDate);
            cashFlow.AC36EndPeriodAmount = -GetAccountCreditAmount(
                                                          new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                          new string[] { AccAccount.Acc421 },
                                                          fromDate,
                                                          toDate);

            cashFlow.AC40StartPeriodAmount = cashFlow.AC31StartPeriodAmount +
                                            cashFlow.AC32StartPeriodAmount +
                                            cashFlow.AC33StartPeriodAmount +
                                            cashFlow.AC34StartPeriodAmount +
                                            cashFlow.AC35StartPeriodAmount +
                                            cashFlow.AC36StartPeriodAmount;
            cashFlow.AC40EndPeriodAmount = cashFlow.AC31EndPeriodAmount +
                                            cashFlow.AC32EndPeriodAmount +
                                            cashFlow.AC33EndPeriodAmount +
                                            cashFlow.AC34EndPeriodAmount +
                                            cashFlow.AC35EndPeriodAmount +
                                            cashFlow.AC36EndPeriodAmount;
            #endregion

            //Luu chuyen tien trong ki
            cashFlow.AC50StartPeriodAmount = cashFlow.AC20StartPeriodAmount +
                                            cashFlow.AC30StartPeriodAmount +
                                            cashFlow.AC40StartPeriodAmount;
            cashFlow.AC50EndPeriodAmount = cashFlow.AC20EndPeriodAmount +
                                            cashFlow.AC30EndPeriodAmount +
                                            cashFlow.AC40EndPeriodAmount;

            //Tien va tuong duong tien dau ky
            if (!GetPrevCashFlow)
            {
                GetPrevCashFlow = true;
                ACCashFlowsInfo prevCashFlow = GetCashFlow(prevPeriodStartDate, prevPeriodEndDate);
                cashFlow.AC60StartPeriodAmount = prevCashFlow.AC70StartPeriodAmount;
                cashFlow.AC60EndPeriodAmount = prevCashFlow.AC70EndPeriodAmount;
            }
            else
            {
                cashFlow.AC60StartPeriodAmount = 0;
                cashFlow.AC60EndPeriodAmount = 0;
            }

            //Chenh lech ty gia hoi doai
            cashFlow.AC61StartPeriodAmount = 0;
            cashFlow.AC61EndPeriodAmount = 0;

            //Tien va tuong duong tien cuoi ky
            cashFlow.AC70StartPeriodAmount = cashFlow.AC50StartPeriodAmount + cashFlow.AC60StartPeriodAmount + cashFlow.AC61StartPeriodAmount;
            cashFlow.AC70EndPeriodAmount = cashFlow.AC50EndPeriodAmount + cashFlow.AC60EndPeriodAmount + cashFlow.AC61EndPeriodAmount;
            return cashFlow;
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

        private void RP056_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }
    }
}
