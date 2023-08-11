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
    public partial class RP210 : ReportForm
    {


        #region Constructor
        public RP210()
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
        private void RP210_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> SelectedAccountList = objAccountsController.GetAllAccountList();
            if (SelectedAccountList != null)
            {
                fld_lkeACAccountID.Properties.DataSource = SelectedAccountList;
            }
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);

            XtraReport report = null;
            if (currencyID == GECurrencyID.VND)
                report = new BOSReport.RP210();
            else
                report = new BOSReport.RP210Curency();

            bool isComplete = InitReportDataSource(report);
            if (isComplete)
            {

                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
            else
            {
                if (fld_lkeACAccountID.EditValue != null)
                    MessageBox.Show("Không tồn tại dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region Methods


        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>
        /// <returns>True if initialize successfully, otherwise false</returns>
        public bool InitReportDataSource(XtraReport report)
        {
            if (fld_lkeACAccountID.EditValue == null)
            {
                MessageBox.Show(ReportLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            ACAccountsController objAccountsController = new ACAccountsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTime != null)
                dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(int.Parse(fld_lkeACAccountID.EditValue.ToString()));
            if (objAccountsInfo != null)
            {
                //xrlblAccountNo
                XRLabel xrlblAccountNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrlblAccountNo"];
                if (xrlblAccountNo != null) xrlblAccountNo.Text = "Số hiệu: " + objAccountsInfo.ACAccountNo;
                //xrlblAccountNo
                XRLabel xrlblAccountName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrlblAccountName"];
                if (xrlblAccountName != null) xrlblAccountName.Text = "Tên tài khoản: " + objAccountsInfo.ACAccountName;
            }
            else return false;
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);


            bool isComplete = false;

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();

            documentEntrys = objDocumentEntrysController.GetDocumentEntrySoChuT(dateFrom, dateTo, int.Parse(fld_lkeACAccountID.EditValue.ToString()), currencyID, branchID);
            if (documentEntrys != null && documentEntrys.Any())
            {
                report.DataSource = (from m in documentEntrys
                                     orderby m.ACDocumentEntryAccountNo, m.GECurrencyName, m.OrderNum
                                     select m).ToList();
                isComplete = true;
            }
            else
                return isComplete;
            return isComplete;
        }
        #endregion
    }
}
