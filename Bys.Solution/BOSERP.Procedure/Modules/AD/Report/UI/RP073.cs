using BOSCommon.Constants;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP073 : ReportForm
    {
        public RP073()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP073 report = new BOSReport.RP073();
            InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
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
            XRLabel title = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
            {
                int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                BRBranchsInfo selectedBranch = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                if (selectedBranch != null)
                {
                    title.Text += string.Format(" {0}", selectedBranch.BRBranchName);
                }
            }
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            PXIncomeStatementInfo incomeStatement = GetIncomeStatement();
            List<PXIncomeStatementInfo> incomeStatementList = new List<PXIncomeStatementInfo>();
            incomeStatementList.Add(incomeStatement);
            report.DataSource = incomeStatementList;
        }

        /// <summary>
        /// Get the income statement
        /// </summary>
        /// <returns>Income statement object</returns>
        private PXIncomeStatementInfo GetIncomeStatement()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(fromDate.AddDays(-1));
            DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(fromDate.AddDays(-1));
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            PXIncomeStatementInfo incomeStatement = new PXIncomeStatementInfo();
            incomeStatement.No01StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc511, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No01StartPeriodAmount += objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc512, branchID, prevPeriodStartDate, prevPeriodEndDate);

            incomeStatement.No01EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc511, branchID, fromDate, toDate);
            incomeStatement.No01EndPeriodAmount += objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc512, branchID, fromDate, toDate);
            incomeStatement.No01Ratio = CalculateRatio(incomeStatement.No01EndPeriodAmount, incomeStatement.No01StartPeriodAmount);

            incomeStatement.No0201StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc521, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc521, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0202StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc531, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc531, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0203StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc532, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc532, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No02StartPeriodAmount = incomeStatement.No0201StartPeriodAmount + incomeStatement.No0202StartPeriodAmount + incomeStatement.No0203StartPeriodAmount;

            incomeStatement.No0201EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc521, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc521, branchID, fromDate, toDate);
            incomeStatement.No0202EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc531, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc531, branchID, fromDate, toDate);
            incomeStatement.No0203EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc532, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc532, branchID, fromDate, toDate);
            incomeStatement.No02EndPeriodAmount = incomeStatement.No0201EndPeriodAmount + incomeStatement.No0202EndPeriodAmount + incomeStatement.No0203EndPeriodAmount;

            incomeStatement.No0201Ratio = CalculateRatio(incomeStatement.No0201EndPeriodAmount, incomeStatement.No0201StartPeriodAmount);
            incomeStatement.No0202Ratio = CalculateRatio(incomeStatement.No0202EndPeriodAmount, incomeStatement.No0202StartPeriodAmount);
            incomeStatement.No0203Ratio = CalculateRatio(incomeStatement.No0203EndPeriodAmount, incomeStatement.No0203StartPeriodAmount);
            incomeStatement.No02Ratio = CalculateRatio(incomeStatement.No02EndPeriodAmount, incomeStatement.No02StartPeriodAmount);

            incomeStatement.No03StartPeriodAmount = incomeStatement.No01StartPeriodAmount - incomeStatement.No02StartPeriodAmount;
            incomeStatement.No03EndPeriodAmount = incomeStatement.No01EndPeriodAmount - incomeStatement.No02EndPeriodAmount;
            incomeStatement.No03Ratio = CalculateRatio(incomeStatement.No03EndPeriodAmount, incomeStatement.No03StartPeriodAmount);

            incomeStatement.No04StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc632, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                    objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc632, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No04EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc632, branchID, fromDate, toDate) -
                                                    objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc632, branchID, fromDate, toDate);
            incomeStatement.No04Ratio = CalculateRatio(incomeStatement.No04EndPeriodAmount, incomeStatement.No04StartPeriodAmount);

            incomeStatement.No05StartPeriodAmount = incomeStatement.No03StartPeriodAmount - incomeStatement.No04StartPeriodAmount;
            incomeStatement.No05EndPeriodAmount = incomeStatement.No03EndPeriodAmount - incomeStatement.No04EndPeriodAmount;
            incomeStatement.No05Ratio = CalculateRatio(incomeStatement.No05EndPeriodAmount, incomeStatement.No05StartPeriodAmount);

            incomeStatement.No06StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc515, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                    objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc515, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No06EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc515, branchID, fromDate, toDate) -
                                                    objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc515, branchID, fromDate, toDate);
            incomeStatement.No06Ratio = CalculateRatio(incomeStatement.No06EndPeriodAmount, incomeStatement.No06StartPeriodAmount);

            incomeStatement.No07StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc635, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                    objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc635, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No07EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc635, branchID, fromDate, toDate) -
                                                    objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc635, branchID, fromDate, toDate);
            incomeStatement.No07Ratio = CalculateRatio(incomeStatement.No07EndPeriodAmount, incomeStatement.No07StartPeriodAmount);

            incomeStatement.No0801StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6411, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6411, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0801EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6411, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6411, branchID, fromDate, toDate);
            incomeStatement.No0801Ratio = CalculateRatio(incomeStatement.No0801EndPeriodAmount, incomeStatement.No0801StartPeriodAmount);

            incomeStatement.No0802StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6412, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6412, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0802EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6412, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6412, branchID, fromDate, toDate);
            incomeStatement.No0802Ratio = CalculateRatio(incomeStatement.No0802EndPeriodAmount, incomeStatement.No0802StartPeriodAmount);

            incomeStatement.No0803StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6413, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6413, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0803EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6413, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6413, branchID, fromDate, toDate);
            incomeStatement.No0803Ratio = CalculateRatio(incomeStatement.No0803EndPeriodAmount, incomeStatement.No0803StartPeriodAmount);

            incomeStatement.No0804StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6414, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6414, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0804EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6414, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6414, branchID, fromDate, toDate);
            incomeStatement.No0804Ratio = CalculateRatio(incomeStatement.No0804EndPeriodAmount, incomeStatement.No0804StartPeriodAmount);

            incomeStatement.No0805StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6415, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6415, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0805EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6415, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6415, branchID, fromDate, toDate);
            incomeStatement.No0805Ratio = CalculateRatio(incomeStatement.No0805EndPeriodAmount, incomeStatement.No0805StartPeriodAmount);

            incomeStatement.No0806StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64171, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64171, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0806EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64171, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64171, branchID, fromDate, toDate);
            incomeStatement.No0806Ratio = CalculateRatio(incomeStatement.No0806EndPeriodAmount, incomeStatement.No0806StartPeriodAmount);

            incomeStatement.No0807StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64172, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64172, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0807EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64172, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64172, branchID, fromDate, toDate);
            incomeStatement.No0807Ratio = CalculateRatio(incomeStatement.No0807EndPeriodAmount, incomeStatement.No0807StartPeriodAmount);

            incomeStatement.No0808StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64173, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64173, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0808EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64173, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64173, branchID, fromDate, toDate);
            incomeStatement.No0808Ratio = CalculateRatio(incomeStatement.No0808EndPeriodAmount, incomeStatement.No0808StartPeriodAmount);

            incomeStatement.No0809StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64174, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64174, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0809EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64174, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64174, branchID, fromDate, toDate);
            incomeStatement.No0809Ratio = CalculateRatio(incomeStatement.No0809EndPeriodAmount, incomeStatement.No0809StartPeriodAmount);

            incomeStatement.No0810StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64175, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64175, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0810EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64175, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64175, branchID, fromDate, toDate);
            incomeStatement.No0810Ratio = CalculateRatio(incomeStatement.No0810EndPeriodAmount, incomeStatement.No0810StartPeriodAmount);

            incomeStatement.No0811StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64176, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64176, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0811EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64176, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64176, branchID, fromDate, toDate);
            incomeStatement.No0811Ratio = CalculateRatio(incomeStatement.No0811EndPeriodAmount, incomeStatement.No0811StartPeriodAmount);

            incomeStatement.No0812StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64181, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64181, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0812EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64181, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64181, branchID, fromDate, toDate);
            incomeStatement.No0812Ratio = CalculateRatio(incomeStatement.No0812EndPeriodAmount, incomeStatement.No0812StartPeriodAmount);

            incomeStatement.No0813StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64182, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64182, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0813EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64182, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64182, branchID, fromDate, toDate);
            incomeStatement.No0813Ratio = CalculateRatio(incomeStatement.No0813EndPeriodAmount, incomeStatement.No0813StartPeriodAmount);

            incomeStatement.No08StartPeriodAmount = incomeStatement.No0801StartPeriodAmount +
                                                    incomeStatement.No0802StartPeriodAmount +
                                                    incomeStatement.No0803StartPeriodAmount +
                                                    incomeStatement.No0804StartPeriodAmount +
                                                    incomeStatement.No0805StartPeriodAmount +
                                                    incomeStatement.No0806StartPeriodAmount +
                                                    incomeStatement.No0807StartPeriodAmount +
                                                    incomeStatement.No0808StartPeriodAmount +
                                                    incomeStatement.No0809StartPeriodAmount +
                                                    incomeStatement.No0810StartPeriodAmount +
                                                    incomeStatement.No0811StartPeriodAmount +
                                                    incomeStatement.No0812StartPeriodAmount +
                                                    incomeStatement.No0813StartPeriodAmount;
            incomeStatement.No08EndPeriodAmount = incomeStatement.No0801EndPeriodAmount +
                                                    incomeStatement.No0802EndPeriodAmount +
                                                    incomeStatement.No0803EndPeriodAmount +
                                                    incomeStatement.No0804EndPeriodAmount +
                                                    incomeStatement.No0805EndPeriodAmount +
                                                    incomeStatement.No0806EndPeriodAmount +
                                                    incomeStatement.No0807EndPeriodAmount +
                                                    incomeStatement.No0808EndPeriodAmount +
                                                    incomeStatement.No0809EndPeriodAmount +
                                                    incomeStatement.No0810EndPeriodAmount +
                                                    incomeStatement.No0811EndPeriodAmount +
                                                    incomeStatement.No0812EndPeriodAmount +
                                                    incomeStatement.No0813EndPeriodAmount;
            incomeStatement.No08Ratio = CalculateRatio(incomeStatement.No08EndPeriodAmount, incomeStatement.No08StartPeriodAmount);

            incomeStatement.No0901StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6421, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6421, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0901EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6421, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6421, branchID, fromDate, toDate);
            incomeStatement.No0901Ratio = CalculateRatio(incomeStatement.No0901EndPeriodAmount, incomeStatement.No0901StartPeriodAmount);

            incomeStatement.No0902StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6423, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6423, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0902EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6423, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6423, branchID, fromDate, toDate);
            incomeStatement.No0902Ratio = CalculateRatio(incomeStatement.No0902EndPeriodAmount, incomeStatement.No0902StartPeriodAmount);

            incomeStatement.No0903StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6424, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6424, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0903EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6424, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6424, branchID, fromDate, toDate);
            incomeStatement.No0903Ratio = CalculateRatio(incomeStatement.No0903EndPeriodAmount, incomeStatement.No0903StartPeriodAmount);

            incomeStatement.No0904StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6425, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6425, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0904EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6425, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6425, branchID, fromDate, toDate);
            incomeStatement.No0904Ratio = CalculateRatio(incomeStatement.No0904EndPeriodAmount, incomeStatement.No0904StartPeriodAmount);

            incomeStatement.No0905StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6427, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6427, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0905EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc6427, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc6427, branchID, fromDate, toDate);
            incomeStatement.No0905Ratio = CalculateRatio(incomeStatement.No0905EndPeriodAmount, incomeStatement.No0905StartPeriodAmount);

            incomeStatement.No0906StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64281, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64281, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0906EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64281, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64281, branchID, fromDate, toDate);
            incomeStatement.No0906Ratio = CalculateRatio(incomeStatement.No0906EndPeriodAmount, incomeStatement.No0906StartPeriodAmount);

            incomeStatement.No0907StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64282, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64282, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0907EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64282, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64282, branchID, fromDate, toDate);
            incomeStatement.No0907Ratio = CalculateRatio(incomeStatement.No0907EndPeriodAmount, incomeStatement.No0907StartPeriodAmount);

            incomeStatement.No0908StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64283, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64283, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No0908EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc64283, branchID, fromDate, toDate) -
                                                      objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc64283, branchID, fromDate, toDate);
            incomeStatement.No0908Ratio = CalculateRatio(incomeStatement.No0908EndPeriodAmount, incomeStatement.No0908StartPeriodAmount);

            incomeStatement.No09StartPeriodAmount = incomeStatement.No0901StartPeriodAmount +
                                                  incomeStatement.No0902StartPeriodAmount +
                                                  incomeStatement.No0903StartPeriodAmount +
                                                  incomeStatement.No0904StartPeriodAmount +
                                                  incomeStatement.No0905StartPeriodAmount +
                                                  incomeStatement.No0906StartPeriodAmount +
                                                  incomeStatement.No0907StartPeriodAmount +
                                                  incomeStatement.No0908StartPeriodAmount;
            incomeStatement.No09EndPeriodAmount = incomeStatement.No0901EndPeriodAmount +
                                                    incomeStatement.No0902EndPeriodAmount +
                                                    incomeStatement.No0903EndPeriodAmount +
                                                    incomeStatement.No0904EndPeriodAmount +
                                                    incomeStatement.No0905EndPeriodAmount +
                                                    incomeStatement.No0906EndPeriodAmount +
                                                    incomeStatement.No0907EndPeriodAmount +
                                                    incomeStatement.No0908EndPeriodAmount;
            incomeStatement.No09Ratio = CalculateRatio(incomeStatement.No09EndPeriodAmount, incomeStatement.No09StartPeriodAmount);

            incomeStatement.No10StartPeriodAmount = incomeStatement.No05StartPeriodAmount +
                                                    incomeStatement.No06StartPeriodAmount -
                                                    incomeStatement.No07StartPeriodAmount -
                                                    incomeStatement.No08StartPeriodAmount -
                                                    incomeStatement.No09StartPeriodAmount;
            incomeStatement.No10EndPeriodAmount = incomeStatement.No05EndPeriodAmount +
                                                    incomeStatement.No06EndPeriodAmount -
                                                    incomeStatement.No07EndPeriodAmount -
                                                    incomeStatement.No08EndPeriodAmount -
                                                    incomeStatement.No09EndPeriodAmount;
            incomeStatement.No10Ratio = CalculateRatio(incomeStatement.No10EndPeriodAmount, incomeStatement.No10StartPeriodAmount);

            incomeStatement.No11StartPeriodAmount = objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc711, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                    objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc711, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No11EndPeriodAmount = objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc711, branchID, fromDate, toDate) -
                                                objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc711, branchID, fromDate, toDate);
            incomeStatement.No11Ratio = CalculateRatio(incomeStatement.No11EndPeriodAmount, incomeStatement.No11StartPeriodAmount);

            incomeStatement.No12StartPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc811, branchID, prevPeriodStartDate, prevPeriodEndDate) -
                                                    objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc811, branchID, prevPeriodStartDate, prevPeriodEndDate);
            incomeStatement.No12EndPeriodAmount = objDocumentEntrysController.GetAccountDebitAmountByBranch(AccAccount.Acc811, branchID, fromDate, toDate) -
                                                  objDocumentEntrysController.GetAccountCreditAmountByBranch(AccAccount.Acc811, branchID, fromDate, toDate);
            incomeStatement.No12Ratio = CalculateRatio(incomeStatement.No12EndPeriodAmount, incomeStatement.No12StartPeriodAmount);

            incomeStatement.No13StartPeriodAmount = incomeStatement.No11StartPeriodAmount - incomeStatement.No12StartPeriodAmount;
            incomeStatement.No13EndPeriodAmount = incomeStatement.No11EndPeriodAmount - incomeStatement.No12EndPeriodAmount;
            incomeStatement.No13Ratio = CalculateRatio(incomeStatement.No13EndPeriodAmount, incomeStatement.No13StartPeriodAmount);

            incomeStatement.No14StartPeriodAmount = incomeStatement.No10StartPeriodAmount + incomeStatement.No13StartPeriodAmount;
            incomeStatement.No14EndPeriodAmount = incomeStatement.No10EndPeriodAmount + incomeStatement.No13EndPeriodAmount;
            incomeStatement.No14Ratio = CalculateRatio(incomeStatement.No14EndPeriodAmount, incomeStatement.No14StartPeriodAmount);

            return incomeStatement;
        }

        private decimal CalculateRatio(decimal currentAmount, decimal prevAmount)
        {
            decimal ratio = 0;
            if (prevAmount != 0)
            {
                ratio = (currentAmount / prevAmount) * 100 - 100;
                ratio = Math.Round(ratio, 2);
            }
            return ratio;
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

        private void RP073_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
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
    }
}
