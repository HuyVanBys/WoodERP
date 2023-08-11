using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP149 : ReportForm
    {
        public RP149()
        {
            InitializeComponent();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP149 report = new BOSReport.RP149();
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, false);
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
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            int bankID = Convert.ToInt32(fld_lkeCSCompanyBankID.EditValue);

            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            if (bankID > 0)
            {
                CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
                XRLabel xrLabel22 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xrLabel22"];
                if (xrLabel22 != null)
                    xrLabel22.Text = objCompanyBanksInfo.CSCompanyBankName.ToUpper();
            }
            //XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            //dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
            //                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            List<ACBankTransactionsInfo> result = new List<ACBankTransactionsInfo>();
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            result = objBankTransactionsController.GetBankTransactionsForRP149(dateFrom, dateTo, bankID, BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID);
            //foreach (ACBankTransactionsInfo item in result)
            //{
            //    item.AmountInWords = ConvertAmountToWord.ReadAmount(item.ACBankTransactionExchangeAmount.ToString(), item.FK_GECurrencyID);
            //}
            report.DataSource = result;
        }


        private void RP054_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }

    }
}
