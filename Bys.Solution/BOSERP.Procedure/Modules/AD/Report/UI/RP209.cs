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
    public partial class RP209 : ReportForm
    {
        /// <summary>
        /// A variable to store the selected accounts
        /// </summary>
        private List<ACAccountsInfo> SelectedAccountList;

        #region Constructor
        public RP209()
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
        private void RP209_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_cmbType.SelectedIndex = 0;
            fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            SelectedAccountList = new BOSList<ACAccountsInfo>();
            InitAccounts();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string title = string.Empty;
            string modelNo = string.Empty;
            if (fld_cmbType.SelectedIndex == 0)
            {
                title = "SỔ NHẬT KÝ THU TIỀN";
                modelNo = "Mẫu số S03a1-DN";
            }
            else if (fld_cmbType.SelectedIndex == 1)
            {
                title = "SỔ NHẬT KÝ CHI TIỀN";
                modelNo = "Mẫu số S03a2-DN";
            }
            else if (fld_cmbType.SelectedIndex == 2)
            {
                title = "SỔ NHẬT KÝ BÁN HÀNG";
                modelNo = "Mẫu số S03a4-DN";
            }
            else
            {
                title = "SỔ NHẬT KÝ MUA HÀNG";
                modelNo = "Mẫu số S03a3-DN";
            }

            XtraReport report = null;
            if (currencyID == GECurrencyID.VND)
                report = new BOSReport.RP209();
            else
                report = new BOSReport.RP209Curency(currencyID);

            bool isComplete = InitReportDataSource(report);
            if (isComplete)
            {
                //xrTitle
                XRLabel xrTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTitle"];
                if (xrTitle != null)
                {
                    xrTitle.Text = title;
                }

                XRLabel xrModelNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrModelNo"];
                if (xrModelNo != null)
                {
                    xrModelNo.Text = modelNo;
                }
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
            else
            {
                if (SelectedAccountList.Exists(a => a.Selected == true))
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
        /// Init available accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            SelectedAccountList = objAccountsController.GetAllAccountList();
            if (SelectedAccountList != null)
            {
                if (fld_cmbType.SelectedIndex == 0 || fld_cmbType.SelectedIndex == 1)
                    SelectedAccountList = SelectedAccountList.Where(x => x.ACAccountNo.IndexOf("11") == 0).ToList();
                else if (fld_cmbType.SelectedIndex == 2)
                    SelectedAccountList = SelectedAccountList.Where(x => x.ACAccountNo.IndexOf("13") == 0).ToList();
                else
                    SelectedAccountList = SelectedAccountList.Where(x => x.ACAccountNo.IndexOf("33") == 0).ToList();
            }
            fld_dgcACRP209Accounts.DataSource = SelectedAccountList;
            fld_dgcACRP209Accounts.RefreshDataSource();
        }

        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>
        /// <returns>True if initialize successfully, otherwise false</returns>
        public bool InitReportDataSource(XtraReport report)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            bool isComplete = false;

            if (SelectedAccountList.Exists(a => a.Selected == true))
            {

                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
                List<ACAccountsInfo> selectedAccount = SelectedAccountList.Where(o => o.Selected == true).ToList();
                List<string> accountID = selectedAccount.Select(x => x.ACAccountID.ToString()).Distinct().ToList();
                if (accountID != null && accountID.Count > 0)
                {
                    if (fld_cmbType.SelectedIndex == 0 || fld_cmbType.SelectedIndex == 2)
                    {
                        documentEntrys = objDocumentEntrysController.GetDocumentEntrysNhatKy(dateFrom, dateTo, string.Join(",", accountID.ToArray()), null, currencyID, branchID);
                    }
                    else
                        documentEntrys = objDocumentEntrysController.GetDocumentEntrysNhatKy(dateFrom, dateTo, null, string.Join(",", accountID.ToArray()), currencyID, branchID);
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
        #endregion

        private void fld_cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitAccounts();
        }
    }
}
