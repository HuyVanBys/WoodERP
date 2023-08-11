using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP053 : ReportForm
    {
        /// <summary>
        /// A variable to store the list of all accounts
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP053()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP053 report = new BOSReport.RP053();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP053Path);
            InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP053Path, true);
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
            XRLabel date = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDate"];
            if (date != null)
                date.Text = fld_dteSearchToDate.DateTime.Day.ToString("00");
            XRLabel month = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblMonth"];
            if (month != null)
                month.Text = fld_dteSearchToDate.DateTime.Month.ToString("00");
            XRLabel year = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblYear"];
            if (year != null)
                year.Text = fld_dteSearchToDate.DateTime.Year.ToString();

            ACBalanceSheetsInfo objBalanceSheetsInfo = new ACBalanceSheetsInfo();
            List<ACBalanceSheetsInfo> balanceSheetList = new List<ACBalanceSheetsInfo>();
            SetBalanceSheetValue(objBalanceSheetsInfo);
            balanceSheetList.Add(objBalanceSheetsInfo);
            report.DataSource = balanceSheetList;

            //Init data source for sub report
            //List<GECurrenciesInfo> currencyList = objReportsController.GetBalanceSheetCurrencyByDate(dateTo);
            //if (currencyList.Count > 0)
            //    currencyList = currencyList.Where(c => c.GECurrencyNo != App.DefaultCurrency).ToList();
            //RP053Currency subReport = new RP053Currency();
            //subReport.DataSource = currencyList;
            //XRSubreport subReportCurrency = (XRSubreport)report.Bands[BandKind.ReportFooter].Controls["xr_SubCurrency"];
            //if (subReportCurrency != null)
            //    subReportCurrency.ReportSource = subReport;
        }

        /// <summary>
        /// Set balance sheet value
        /// </summary>
        /// <param name="objBalanceSheetsInfo">Given balace sheet</param>       
        public void SetBalanceSheetValue(ACBalanceSheetsInfo balanceSheet)
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(fromDate.AddDays(-1));
            DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(fromDate.AddDays(-1));

            ACAccountsController objAccountsController = new ACAccountsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            AccountList = objAccountsController.GetAllAccountList();

            #region Tai san

            #region Tai san ngan han

            #region Tien va cac khoan tuong duong tien
            balanceSheet.ACNo111StartYearBalance = GetAccountDebitBalance(
                                                                    new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                                    prevPeriodEndDate);

            balanceSheet.ACNo111EndYearBalance = GetAccountDebitBalance(
                                                                    new string[] { AccAccount.Acc111, AccAccount.Acc112, AccAccount.Acc113 },
                                                                    toDate);

            balanceSheet.ACNo112StartYearBalance = 0;
            balanceSheet.ACNo112EndYearBalance = 0;

            balanceSheet.ACNo110StartYearBalance = balanceSheet.ACNo111StartYearBalance + balanceSheet.ACNo112StartYearBalance;
            balanceSheet.ACNo110EndYearBalance = balanceSheet.ACNo111EndYearBalance + balanceSheet.ACNo112EndYearBalance;
            #endregion

            #region Cac khoan dau tu tai chinh ngan han
            balanceSheet.ACNo121StartYearBalance = 0;
            balanceSheet.ACNo121EndYearBalance = 0;

            balanceSheet.ACNo129StartYearBalance = 0;
            balanceSheet.ACNo129EndYearBalance = 0;

            balanceSheet.ACNo120StartYearBalance = balanceSheet.ACNo121StartYearBalance + balanceSheet.ACNo121StartYearBalance;
            balanceSheet.ACNo120EndYearBalance = balanceSheet.ACNo129EndYearBalance + balanceSheet.ACNo129EndYearBalance;
            #endregion

            #region Cac khoan phai thu ngan han                                                           
            balanceSheet.ACNo131StartYearBalance = GetObjectDebitBalance(AccAccount.Acc131, prevPeriodStartDate, prevPeriodEndDate);
            balanceSheet.ACNo131EndYearBalance = GetObjectDebitBalance(AccAccount.Acc131, fromDate, toDate);

            balanceSheet.ACNo132StartYearBalance = GetObjectDebitBalance(AccAccount.Acc331, prevPeriodStartDate, prevPeriodEndDate);
            balanceSheet.ACNo132EndYearBalance = GetObjectDebitBalance(AccAccount.Acc331, fromDate, toDate);

            balanceSheet.ACNo133StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc1368 }, prevPeriodEndDate);
            balanceSheet.ACNo133EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc1368 }, toDate);

            balanceSheet.ACNo134StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc337 }, prevPeriodEndDate);
            balanceSheet.ACNo134EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc337 }, toDate);

            balanceSheet.ACNo135StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc1385, AccAccount.Acc1388 }, prevPeriodEndDate);
            balanceSheet.ACNo135StartYearBalance += GetAccountDebitBalance(new string[] { AccAccount.Acc334, AccAccount.Acc338 }, prevPeriodEndDate);
            balanceSheet.ACNo135EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc1385, AccAccount.Acc1388 }, toDate);
            balanceSheet.ACNo135EndYearBalance += GetAccountDebitBalance(new string[] { AccAccount.Acc334, AccAccount.Acc338 }, toDate);

            balanceSheet.ACNo139StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc139 }, prevPeriodEndDate);
            balanceSheet.ACNo139EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc139 }, toDate);

            balanceSheet.ACNo130StartYearBalance = balanceSheet.ACNo131StartYearBalance +
                                                            balanceSheet.ACNo132StartYearBalance +
                                                            balanceSheet.ACNo133StartYearBalance +
                                                            balanceSheet.ACNo134StartYearBalance +
                                                            balanceSheet.ACNo135StartYearBalance +
                                                            balanceSheet.ACNo139StartYearBalance;
            balanceSheet.ACNo130EndYearBalance = balanceSheet.ACNo131EndYearBalance +
                                                            balanceSheet.ACNo132EndYearBalance +
                                                            balanceSheet.ACNo133EndYearBalance +
                                                            balanceSheet.ACNo134EndYearBalance +
                                                            balanceSheet.ACNo135EndYearBalance +
                                                            balanceSheet.ACNo139EndYearBalance;
            #endregion

            #region Hang ton kho
            balanceSheet.ACNo141StartYearBalance = GetAccountDebitBalance(
                                                                    new string[] {
                                                                        AccAccount.Acc151,
                                                                        AccAccount.Acc152,
                                                                        AccAccount.Acc153,
                                                                        AccAccount.Acc154,
                                                                        AccAccount.Acc155,
                                                                        AccAccount.Acc156,
                                                                        AccAccount.Acc157,
                                                                        AccAccount.Acc158},
                                                                    prevPeriodEndDate);

            balanceSheet.ACNo141EndYearBalance = GetAccountDebitBalance(
                                                                    new string[] {
                                                                        AccAccount.Acc151,
                                                                        AccAccount.Acc152,
                                                                        AccAccount.Acc153,
                                                                        AccAccount.Acc154,
                                                                        AccAccount.Acc155,
                                                                        AccAccount.Acc156,
                                                                        AccAccount.Acc157,
                                                                        AccAccount.Acc158},
                                                                    toDate);

            balanceSheet.ACNo149StartYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc159 }, prevPeriodEndDate);
            balanceSheet.ACNo149EndYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc159 }, toDate);

            balanceSheet.ACNo140StartYearBalance = balanceSheet.ACNo141StartYearBalance + balanceSheet.ACNo149StartYearBalance;
            balanceSheet.ACNo140EndYearBalance = balanceSheet.ACNo141EndYearBalance + balanceSheet.ACNo149EndYearBalance;
            #endregion

            #region Tai san ngan han khac
            balanceSheet.ACNo151StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc142 }, prevPeriodEndDate);
            balanceSheet.ACNo151EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc142 }, toDate);

            balanceSheet.ACNo152StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc133 }, prevPeriodEndDate);
            balanceSheet.ACNo152EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc133 }, toDate);

            balanceSheet.ACNo154StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc333 }, prevPeriodEndDate);
            balanceSheet.ACNo154EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc333 }, toDate);

            balanceSheet.ACNo158StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc138, }, prevPeriodEndDate);
            balanceSheet.ACNo158StartYearBalance += GetAccountDebitBalance(new string[] { AccAccount.Acc141 }, prevPeriodEndDate);
            balanceSheet.ACNo158StartYearBalance += GetAccountDebitBalance(new string[] { AccAccount.Acc144 }, prevPeriodEndDate);
            balanceSheet.ACNo158EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc138 }, toDate);
            balanceSheet.ACNo158EndYearBalance += GetAccountDebitBalance(new string[] { AccAccount.Acc141 }, toDate);
            balanceSheet.ACNo158EndYearBalance += GetAccountDebitBalance(new string[] { AccAccount.Acc144 }, toDate);

            balanceSheet.ACNo150StartYearBalance = balanceSheet.ACNo151StartYearBalance +
                                                            balanceSheet.ACNo152StartYearBalance +
                                                            balanceSheet.ACNo154StartYearBalance +
                                                            balanceSheet.ACNo158StartYearBalance;
            balanceSheet.ACNo150EndYearBalance = balanceSheet.ACNo151EndYearBalance +
                                                            balanceSheet.ACNo152EndYearBalance +
                                                            balanceSheet.ACNo154EndYearBalance +
                                                            balanceSheet.ACNo158EndYearBalance;
            #endregion

            balanceSheet.ACNo100StartYearBalance = balanceSheet.ACNo110StartYearBalance +
                                                            balanceSheet.ACNo120StartYearBalance +
                                                            balanceSheet.ACNo130StartYearBalance +
                                                            balanceSheet.ACNo140StartYearBalance +
                                                            balanceSheet.ACNo150StartYearBalance;
            balanceSheet.ACNo100EndYearBalance = balanceSheet.ACNo110EndYearBalance +
                                                            balanceSheet.ACNo120EndYearBalance +
                                                            balanceSheet.ACNo130EndYearBalance +
                                                            balanceSheet.ACNo140EndYearBalance +
                                                            balanceSheet.ACNo150EndYearBalance;
            #endregion

            #region Tai san dai han

            #region Cac khoan phai thu dai han
            balanceSheet.ACNo211StartYearBalance = 0;
            balanceSheet.ACNo211EndYearBalance = 0;

            balanceSheet.ACNo212StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc1361 }, prevPeriodEndDate);
            balanceSheet.ACNo212EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc1361 }, toDate);

            balanceSheet.ACNo213StartYearBalance = 0;
            balanceSheet.ACNo213EndYearBalance = 0;

            balanceSheet.ACNo218StartYearBalance = 0;
            balanceSheet.ACNo218EndYearBalance = 0;

            balanceSheet.ACNo219StartYearBalance = 0;
            balanceSheet.ACNo219EndYearBalance = 0;

            balanceSheet.ACNo210StartYearBalance = balanceSheet.ACNo211StartYearBalance +
                                                            balanceSheet.ACNo212StartYearBalance +
                                                            balanceSheet.ACNo213StartYearBalance +
                                                            balanceSheet.ACNo218StartYearBalance +
                                                            balanceSheet.ACNo219StartYearBalance;
            balanceSheet.ACNo210EndYearBalance = balanceSheet.ACNo211EndYearBalance +
                                                            balanceSheet.ACNo212EndYearBalance +
                                                            balanceSheet.ACNo213EndYearBalance +
                                                            balanceSheet.ACNo218EndYearBalance +
                                                            balanceSheet.ACNo219EndYearBalance;
            #endregion

            #region Tai san co dinh
            balanceSheet.ACNo222StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc211 }, prevPeriodEndDate);
            balanceSheet.ACNo222EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc211 }, toDate);

            balanceSheet.ACNo223StartYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2141 }, prevPeriodEndDate);
            balanceSheet.ACNo223EndYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2141 }, toDate);


            balanceSheet.ACNo221StartYearBalance = balanceSheet.ACNo222StartYearBalance + balanceSheet.ACNo223StartYearBalance;
            balanceSheet.ACNo221EndYearBalance = balanceSheet.ACNo222EndYearBalance + balanceSheet.ACNo223EndYearBalance;

            balanceSheet.ACNo225StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc212 }, prevPeriodEndDate);
            balanceSheet.ACNo225EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc212 }, toDate);


            balanceSheet.ACNo226StartYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2142 }, prevPeriodEndDate);
            balanceSheet.ACNo226EndYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2142 }, toDate);

            balanceSheet.ACNo224StartYearBalance = balanceSheet.ACNo225StartYearBalance + balanceSheet.ACNo226StartYearBalance;
            balanceSheet.ACNo224EndYearBalance = balanceSheet.ACNo226EndYearBalance + balanceSheet.ACNo226EndYearBalance;

            balanceSheet.ACNo228StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc213 }, prevPeriodEndDate);
            balanceSheet.ACNo228EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc213 }, toDate);

            balanceSheet.ACNo229StartYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2143 }, prevPeriodEndDate);
            balanceSheet.ACNo229EndYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2143 }, toDate);

            balanceSheet.ACNo227StartYearBalance = balanceSheet.ACNo228StartYearBalance + balanceSheet.ACNo229StartYearBalance;
            balanceSheet.ACNo227EndYearBalance = balanceSheet.ACNo228EndYearBalance + balanceSheet.ACNo229EndYearBalance;

            balanceSheet.ACNo230StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc241 }, prevPeriodEndDate);
            balanceSheet.ACNo230EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc241 }, toDate);

            balanceSheet.ACNo220StartYearBalance = balanceSheet.ACNo221StartYearBalance +
                                                                balanceSheet.ACNo224StartYearBalance +
                                                                balanceSheet.ACNo227StartYearBalance +
                                                                balanceSheet.ACNo230StartYearBalance;
            balanceSheet.ACNo220EndYearBalance = balanceSheet.ACNo221EndYearBalance +
                                                                balanceSheet.ACNo224EndYearBalance +
                                                                balanceSheet.ACNo227EndYearBalance +
                                                                balanceSheet.ACNo230EndYearBalance;
            #endregion

            #region Bat dong san dau tu
            balanceSheet.ACNo241StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc217 }, prevPeriodEndDate);
            balanceSheet.ACNo241EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc217 }, toDate);

            balanceSheet.ACNo242StartYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2147 }, prevPeriodEndDate);
            balanceSheet.ACNo242EndYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc2147 }, toDate);

            balanceSheet.ACNo240StartYearBalance = balanceSheet.ACNo241StartYearBalance + balanceSheet.ACNo242StartYearBalance;
            balanceSheet.ACNo240EndYearBalance = balanceSheet.ACNo241EndYearBalance + balanceSheet.ACNo242EndYearBalance;
            #endregion

            #region Cac khoan dau tu tai chinh dai han
            balanceSheet.ACNo251StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc221 }, prevPeriodEndDate);
            balanceSheet.ACNo251EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc221 }, toDate);

            balanceSheet.ACNo252StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc222, AccAccount.Acc223 }, prevPeriodEndDate);
            balanceSheet.ACNo252EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc222, AccAccount.Acc223 }, toDate);

            balanceSheet.ACNo258StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc228 }, prevPeriodEndDate);
            balanceSheet.ACNo258EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc228 }, toDate);

            balanceSheet.ACNo259StartYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc229 }, prevPeriodEndDate);
            balanceSheet.ACNo259EndYearBalance = -GetAccountCreditBalance(new string[] { AccAccount.Acc229 }, toDate);

            balanceSheet.ACNo250StartYearBalance = balanceSheet.ACNo251StartYearBalance +
                                                                balanceSheet.ACNo252StartYearBalance +
                                                                balanceSheet.ACNo258StartYearBalance +
                                                                balanceSheet.ACNo259StartYearBalance;
            balanceSheet.ACNo250EndYearBalance = balanceSheet.ACNo251EndYearBalance +
                                                                balanceSheet.ACNo252EndYearBalance +
                                                                balanceSheet.ACNo258EndYearBalance +
                                                                balanceSheet.ACNo259EndYearBalance;
            #endregion

            #region Tai san dai han khac
            balanceSheet.ACNo261StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc242 }, prevPeriodEndDate);
            balanceSheet.ACNo261EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc242 }, toDate);

            balanceSheet.ACNo262StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc243 }, prevPeriodEndDate);
            balanceSheet.ACNo262EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc243 }, toDate);

            balanceSheet.ACNo268StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc244 }, prevPeriodEndDate);
            balanceSheet.ACNo268EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc244 }, toDate);

            balanceSheet.ACNo260StartYearBalance = balanceSheet.ACNo261StartYearBalance +
                                                                balanceSheet.ACNo262StartYearBalance +
                                                                balanceSheet.ACNo268StartYearBalance;
            balanceSheet.ACNo260EndYearBalance = balanceSheet.ACNo261EndYearBalance +
                                                                balanceSheet.ACNo262EndYearBalance +
                                                                balanceSheet.ACNo268EndYearBalance;
            #endregion

            balanceSheet.ACNo200StartYearBalance = balanceSheet.ACNo210StartYearBalance +
                                                                balanceSheet.ACNo220StartYearBalance +
                                                                balanceSheet.ACNo240StartYearBalance +
                                                                balanceSheet.ACNo250StartYearBalance +
                                                                balanceSheet.ACNo260StartYearBalance;
            balanceSheet.ACNo200EndYearBalance = balanceSheet.ACNo210EndYearBalance +
                                                                balanceSheet.ACNo220EndYearBalance +
                                                                balanceSheet.ACNo240EndYearBalance +
                                                                balanceSheet.ACNo250EndYearBalance +
                                                                balanceSheet.ACNo260EndYearBalance;
            #endregion

            balanceSheet.ACNo270StartYearBalance = balanceSheet.ACNo100StartYearBalance + balanceSheet.ACNo200StartYearBalance;
            balanceSheet.ACNo270EndYearBalance = balanceSheet.ACNo100EndYearBalance + balanceSheet.ACNo200EndYearBalance;

            #endregion

            #region Nguon von

            #region No phai tra

            #region No ngan han
            balanceSheet.ACNo311StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc311, AccAccount.Acc315 }, prevPeriodEndDate);
            balanceSheet.ACNo311EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc311, AccAccount.Acc315 }, toDate);

            balanceSheet.ACNo312StartYearBalance = GetObjectCreditBalance(AccAccount.Acc331, prevPeriodStartDate, prevPeriodEndDate);
            balanceSheet.ACNo312EndYearBalance = GetObjectCreditBalance(AccAccount.Acc331, fromDate, toDate);

            balanceSheet.ACNo313StartYearBalance = GetObjectCreditBalance(AccAccount.Acc131, prevPeriodStartDate, prevPeriodEndDate);
            balanceSheet.ACNo313EndYearBalance = GetObjectCreditBalance(AccAccount.Acc131, fromDate, toDate);

            balanceSheet.ACNo314StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc333 }, prevPeriodEndDate);
            balanceSheet.ACNo314EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc333 }, toDate);

            balanceSheet.ACNo315StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc334 }, prevPeriodEndDate);
            balanceSheet.ACNo315EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc334 }, toDate);

            balanceSheet.ACNo316StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc335 }, prevPeriodEndDate);
            balanceSheet.ACNo316EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc335 }, toDate);

            balanceSheet.ACNo317StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc336 }, prevPeriodEndDate);
            balanceSheet.ACNo317EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc336 }, toDate);

            balanceSheet.ACNo318StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc337 }, prevPeriodEndDate);
            balanceSheet.ACNo318EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc337 }, toDate);

            balanceSheet.ACNo319StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc338 }, prevPeriodEndDate);
            balanceSheet.ACNo319StartYearBalance += GetAccountCreditBalance(new string[] { AccAccount.Acc138 }, prevPeriodEndDate);

            balanceSheet.ACNo319EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc338 }, toDate);
            balanceSheet.ACNo319EndYearBalance += GetAccountCreditBalance(new string[] { AccAccount.Acc138 }, toDate);

            balanceSheet.ACNo320StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc352 }, prevPeriodEndDate);
            balanceSheet.ACNo320EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc352 }, toDate);

            balanceSheet.ACNo310StartYearBalance = balanceSheet.ACNo311StartYearBalance +
                                                                balanceSheet.ACNo312StartYearBalance +
                                                                balanceSheet.ACNo313StartYearBalance +
                                                                balanceSheet.ACNo314StartYearBalance +
                                                                balanceSheet.ACNo315StartYearBalance +
                                                                balanceSheet.ACNo316StartYearBalance +
                                                                balanceSheet.ACNo317StartYearBalance +
                                                                balanceSheet.ACNo318StartYearBalance +
                                                                balanceSheet.ACNo319StartYearBalance +
                                                                balanceSheet.ACNo320StartYearBalance;

            balanceSheet.ACNo310EndYearBalance = balanceSheet.ACNo311EndYearBalance +
                                                                balanceSheet.ACNo312EndYearBalance +
                                                                balanceSheet.ACNo313EndYearBalance +
                                                                balanceSheet.ACNo314EndYearBalance +
                                                                balanceSheet.ACNo315EndYearBalance +
                                                                balanceSheet.ACNo316EndYearBalance +
                                                                balanceSheet.ACNo317EndYearBalance +
                                                                balanceSheet.ACNo318EndYearBalance +
                                                                balanceSheet.ACNo319EndYearBalance +
                                                                balanceSheet.ACNo320EndYearBalance;
            #endregion

            #region No dai han
            balanceSheet.ACNo331StartYearBalance = 0;
            balanceSheet.ACNo331EndYearBalance = 0;

            balanceSheet.ACNo332StartYearBalance = 0;
            balanceSheet.ACNo332EndYearBalance = 0;

            balanceSheet.ACNo333StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc344 }, prevPeriodEndDate);
            balanceSheet.ACNo333EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc344 }, toDate);

            balanceSheet.ACNo334StartYearBalance = GetAccountCreditBalance(new string[] {
                                                                    AccAccount.Acc341,
                                                                    AccAccount.Acc342,
                                                                    AccAccount.Acc3431,
                                                                    AccAccount.Acc3433}, prevPeriodEndDate);
            balanceSheet.ACNo334StartYearBalance -= GetAccountDebitBalance(new string[] { AccAccount.Acc3432 }, prevPeriodEndDate);

            balanceSheet.ACNo334EndYearBalance = GetAccountCreditBalance(new string[] {
                                                                    AccAccount.Acc341,
                                                                    AccAccount.Acc342,
                                                                    AccAccount.Acc3431,
                                                                    AccAccount.Acc3433}, toDate);
            balanceSheet.ACNo334EndYearBalance -= GetAccountDebitBalance(new string[] { AccAccount.Acc3432 }, toDate);

            balanceSheet.ACNo335StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc347 }, prevPeriodEndDate);
            balanceSheet.ACNo335EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc347 }, toDate);

            balanceSheet.ACNo336StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc351 }, prevPeriodEndDate);
            balanceSheet.ACNo336EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc351 }, toDate);

            balanceSheet.ACNo337StartYearBalance = 0;
            balanceSheet.ACNo337EndYearBalance = 0;

            balanceSheet.ACNo330StartYearBalance = balanceSheet.ACNo331StartYearBalance +
                                                            balanceSheet.ACNo332StartYearBalance +
                                                            balanceSheet.ACNo333StartYearBalance +
                                                            balanceSheet.ACNo334StartYearBalance +
                                                            balanceSheet.ACNo335StartYearBalance +
                                                            balanceSheet.ACNo336StartYearBalance +
                                                            balanceSheet.ACNo337StartYearBalance;

            balanceSheet.ACNo330EndYearBalance = balanceSheet.ACNo331EndYearBalance +
                                                            balanceSheet.ACNo332EndYearBalance +
                                                            balanceSheet.ACNo333EndYearBalance +
                                                            balanceSheet.ACNo334EndYearBalance +
                                                            balanceSheet.ACNo335EndYearBalance +
                                                            balanceSheet.ACNo336EndYearBalance +
                                                            balanceSheet.ACNo337EndYearBalance;
            #endregion

            balanceSheet.ACNo300StartYearBalance = balanceSheet.ACNo310StartYearBalance + balanceSheet.ACNo330StartYearBalance;
            balanceSheet.ACNo300EndYearBalance = balanceSheet.ACNo310EndYearBalance + balanceSheet.ACNo330EndYearBalance;
            #endregion

            #region Von chu so huu

            #region Von chu so huu
            balanceSheet.ACNo411StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc4111 }, prevPeriodEndDate);
            balanceSheet.ACNo411EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc4111 }, toDate);

            balanceSheet.ACNo412StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc4112 }, prevPeriodEndDate);
            if (balanceSheet.ACNo412StartYearBalance == 0)
            {
                balanceSheet.ACNo412StartYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc4112 }, prevPeriodEndDate);
            }

            balanceSheet.ACNo412EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc4112 }, toDate);
            if (balanceSheet.ACNo412EndYearBalance == 0)
            {
                balanceSheet.ACNo412EndYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc4112 }, toDate);
            }

            balanceSheet.ACNo413StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc4118 }, prevPeriodEndDate);
            balanceSheet.ACNo413EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc4118 }, toDate);

            balanceSheet.ACNo414StartYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc419 }, prevPeriodEndDate);
            balanceSheet.ACNo414EndYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc419 }, toDate);

            balanceSheet.ACNo415StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc412 }, prevPeriodEndDate);
            if (balanceSheet.ACNo415StartYearBalance == 0)
            {
                balanceSheet.ACNo415StartYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc412 }, prevPeriodEndDate);
            }
            balanceSheet.ACNo415EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc412 }, toDate);
            if (balanceSheet.ACNo415EndYearBalance == 0)
            {
                balanceSheet.ACNo415EndYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc412 }, toDate);
            }

            balanceSheet.ACNo416StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc413 }, prevPeriodEndDate);
            if (balanceSheet.ACNo416StartYearBalance == 0)
            {
                balanceSheet.ACNo416StartYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc413 }, prevPeriodEndDate);
            }
            balanceSheet.ACNo416EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc413 }, toDate);
            if (balanceSheet.ACNo416EndYearBalance == 0)
            {
                balanceSheet.ACNo416EndYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc413 }, toDate);
            }

            balanceSheet.ACNo417StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc414 }, prevPeriodEndDate);
            balanceSheet.ACNo417EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc414 }, toDate);

            balanceSheet.ACNo418StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc415 }, prevPeriodEndDate);
            balanceSheet.ACNo418EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc415 }, toDate);

            balanceSheet.ACNo419StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc418 }, prevPeriodEndDate);
            balanceSheet.ACNo419EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc418 }, toDate);

            balanceSheet.ACNo420StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc421 }, prevPeriodEndDate);
            if (balanceSheet.ACNo420StartYearBalance == 0)
            {
                balanceSheet.ACNo420StartYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc421 }, prevPeriodEndDate);
            }
            balanceSheet.ACNo420EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc421 }, toDate);
            if (balanceSheet.ACNo420EndYearBalance == 0)
            {
                balanceSheet.ACNo420EndYearBalance = -GetAccountDebitBalance(new string[] { AccAccount.Acc421 }, toDate);
            }

            balanceSheet.ACNo421StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc441 }, prevPeriodEndDate);
            balanceSheet.ACNo421EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc441 }, toDate);

            balanceSheet.ACNo410StartYearBalance = balanceSheet.ACNo411StartYearBalance +
                                                                balanceSheet.ACNo412StartYearBalance +
                                                                balanceSheet.ACNo413StartYearBalance +
                                                                balanceSheet.ACNo414StartYearBalance +
                                                                balanceSheet.ACNo415StartYearBalance +
                                                                balanceSheet.ACNo416StartYearBalance +
                                                                balanceSheet.ACNo417StartYearBalance +
                                                                balanceSheet.ACNo418StartYearBalance +
                                                                balanceSheet.ACNo419StartYearBalance +
                                                                balanceSheet.ACNo420StartYearBalance +
                                                                balanceSheet.ACNo421StartYearBalance;
            balanceSheet.ACNo410EndYearBalance = balanceSheet.ACNo411EndYearBalance +
                                                                balanceSheet.ACNo412EndYearBalance +
                                                                balanceSheet.ACNo413EndYearBalance +
                                                                balanceSheet.ACNo414EndYearBalance +
                                                                balanceSheet.ACNo415EndYearBalance +
                                                                balanceSheet.ACNo416EndYearBalance +
                                                                balanceSheet.ACNo417EndYearBalance +
                                                                balanceSheet.ACNo418EndYearBalance +
                                                                balanceSheet.ACNo419EndYearBalance +
                                                                balanceSheet.ACNo420EndYearBalance +
                                                                balanceSheet.ACNo421EndYearBalance;
            #endregion

            #region Nguon kinh phi va quy khac
            balanceSheet.ACNo431StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc353 }, prevPeriodEndDate);
            balanceSheet.ACNo431EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc353 }, toDate);

            decimal creditBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc461 }, prevPeriodEndDate);
            decimal debitBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc161 }, prevPeriodEndDate);
            decimal diffBalance = Convert.ToDecimal(creditBalance) - Convert.ToDecimal(debitBalance);
            if (diffBalance != 0)
            {
                balanceSheet.ACNo432StartYearBalance = diffBalance;
            }

            creditBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc461 }, toDate);
            debitBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc161 }, toDate);
            diffBalance = Convert.ToDecimal(creditBalance) - Convert.ToDecimal(debitBalance);
            if (diffBalance != 0)
            {
                balanceSheet.ACNo432EndYearBalance = diffBalance;
            }

            balanceSheet.ACNo433StartYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc466 }, prevPeriodEndDate);
            balanceSheet.ACNo433EndYearBalance = GetAccountCreditBalance(new string[] { AccAccount.Acc466 }, toDate);

            balanceSheet.ACNo430StartYearBalance = balanceSheet.ACNo431StartYearBalance +
                                                                balanceSheet.ACNo432StartYearBalance +
                                                                balanceSheet.ACNo433StartYearBalance;
            balanceSheet.ACNo430EndYearBalance = balanceSheet.ACNo431EndYearBalance +
                                                                balanceSheet.ACNo432EndYearBalance +
                                                                balanceSheet.ACNo433EndYearBalance;
            #endregion

            balanceSheet.ACNo400StartYearBalance = balanceSheet.ACNo410StartYearBalance + balanceSheet.ACNo430StartYearBalance;
            balanceSheet.ACNo400EndYearBalance = balanceSheet.ACNo410EndYearBalance + balanceSheet.ACNo430EndYearBalance;
            #endregion

            balanceSheet.ACNo440StartYearBalance = balanceSheet.ACNo300StartYearBalance + balanceSheet.ACNo400StartYearBalance;
            balanceSheet.ACNo440EndYearBalance = balanceSheet.ACNo300EndYearBalance + balanceSheet.ACNo400EndYearBalance;
            #endregion

            #region Tai khoan ngoai bang
            balanceSheet.ACNo001StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc001 }, prevPeriodEndDate);
            balanceSheet.ACNo001EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc001 }, toDate);

            balanceSheet.ACNo002StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc002 }, prevPeriodEndDate);
            balanceSheet.ACNo002EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc002 }, toDate);

            balanceSheet.ACNo003StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc003 }, prevPeriodEndDate);
            balanceSheet.ACNo003EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc003 }, toDate);

            balanceSheet.ACNo004StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc004 }, prevPeriodEndDate);
            balanceSheet.ACNo004EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc004 }, toDate);

            balanceSheet.ACNo007StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc007 }, prevPeriodEndDate);
            balanceSheet.ACNo007EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc007 }, toDate);

            balanceSheet.ACNo008StartYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc008 }, prevPeriodEndDate);
            balanceSheet.ACNo008EndYearBalance = GetAccountDebitBalance(new string[] { AccAccount.Acc008 }, toDate);
            #endregion
        }

        /// <summary>
        /// Get the total debit balance of accounts to a specific date
        /// </summary>
        /// <param name="accountNumbers">List of account numbers</param>
        /// <param name="date">Specific date</param>        
        /// <returns>Total balance</returns>
        private decimal GetAccountDebitBalance(string[] accountNumbers, DateTime date)
        {
            decimal balance = 0;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (string accountNo in accountNumbers)
            {
                balance += objDocumentEntrysController.GetAccountBalance(accountNo, date);
            }

            string postingRule = string.Empty;
            ACAccountsInfo account = AccountList.Where(a => a.ACAccountNo == accountNumbers[0]).FirstOrDefault();
            if (account != null)
            {
                postingRule = account.ACAccountPostingRule;
            }

            if (postingRule == AccountPostingRule.IncreasingByDebit.ToString())
            {
                if (balance <= 0)
                {
                    balance = 0;
                }
            }
            else if (postingRule == AccountPostingRule.IncreasingByCredit.ToString())
            {
                if (balance >= 0)
                {
                    balance = 0;
                }
                else
                {
                    balance = Math.Abs(balance);
                }
            }
            return balance;
        }

        /// <summary>
        /// Get the total credit balance of accounts to a specific date
        /// </summary>
        /// <param name="accountNumbers">List of account numbers</param>
        /// <param name="date">Specific date</param>        
        /// <returns>Total balance</returns>
        private decimal GetAccountCreditBalance(string[] accountNumbers, DateTime date)
        {
            decimal balance = 0;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (string accountNo in accountNumbers)
            {
                balance += objDocumentEntrysController.GetAccountBalance(accountNo, date);
            }

            string postingRule = string.Empty;
            ACAccountsInfo account = AccountList.Where(a => a.ACAccountNo == accountNumbers[0]).FirstOrDefault();
            if (account != null)
            {
                postingRule = account.ACAccountPostingRule;
            }

            if (postingRule == AccountPostingRule.IncreasingByDebit.ToString())
            {
                if (balance >= 0)
                {
                    balance = 0;
                }
                else
                {
                    balance = Math.Abs(balance);
                }
            }
            else if (postingRule == AccountPostingRule.IncreasingByCredit.ToString())
            {
                if (balance <= 0)
                {
                    balance = 0;
                }
            }
            return balance;
        }

        /// <summary>
        /// Get the debit balance of an account detailed to objects
        /// </summary>
        /// <param name="accountNo">Account no</param>        
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Debit balance</returns>
        public decimal GetObjectDebitBalance(string accountNo, DateTime fromDate, DateTime toDate)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo account = (ACAccountsInfo)objAccountsController.GetObjectByNo(accountNo);
            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();
            decimal balance = 0;
            if (account != null)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                List<ACObjectsInfo> owingObjects = objObjectsController.GetOwingObjectsBySomeCriteria(accountNo, fromDate, toDate, null, null, null, null, true);
                foreach (ACObjectsInfo obj in owingObjects)
                {
                    if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount > 0)
                        {
                            balance += obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount;
                        }
                    }
                    else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount < 0)
                        {
                            balance += Math.Abs(obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount);
                        }
                    }
                }
            }
            return balance;
        }

        /// <summary>
        /// Get the credit balance of an account detailed to objects
        /// </summary>
        /// <param name="accountNo">Account no</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Debit balance</returns>
        public decimal GetObjectCreditBalance(string accountNo, DateTime fromDate, DateTime toDate)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo account = (ACAccountsInfo)objAccountsController.GetObjectByNo(accountNo);
            decimal balance = 0;
            if (account != null)
            {
                ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();

                ACObjectsController objObjectsController = new ACObjectsController();
                List<ACObjectsInfo> owingObjects = objObjectsController.GetOwingObjectsBySomeCriteria(accountNo, fromDate, toDate, null, null, null, null, true);
                foreach (ACObjectsInfo obj in owingObjects)
                {
                    if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount < 0)
                        {
                            balance += Math.Abs(obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount);
                        }
                    }
                    else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount > 0)
                        {
                            balance += obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount;
                        }
                    }
                }
            }
            return balance;
        }

        private void RP053_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }
    }
}
