using BOSCommon;
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
    public partial class RP047 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP047()
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
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            if (string.IsNullOrEmpty(objectAccessKey))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            XtraReport report = null;
            if (currencyID == GECurrencyID.VND)
            {
                report = new BOSReport.RP047Currencys();
            }
            else
                report = new BOSReport.RP047();

            bool isComplete = InitDataSourceReport(report);
            if (isComplete)
            {
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
            else
            {
                if (fld_lkeACObjectID.EditValue != null)
                    MessageBox.Show("Không tồn tại dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Init accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountList = objAccountsController.GetPayableAccounts();
            fld_dgcACRP047Accounts.DataSource = AccountList;
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>

        public bool InitDataSourceReport(XtraReport report)
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            XRLabel xrTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTitle"];
            if (xrTitle != null)
                xrTitle.Text = "SỔ CHI TIẾT CÔNG NỢ PHẢI TRẢ";
            bool isComplete = false;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> result = new List<ACDocumentEntrysInfo>();
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ACObjectsController objObjectsController = new ACObjectsController();
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            ACObjectsInfo selectedObject = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            selectedObject = objObjectsController.GetObjectByIDAndType(selectedObject.ACObjectID, selectedObject.ACObjectType);
            if (selectedObject != null)
            {
                XRLabel xrLblObjectNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLblObjectNo"];
                if (xrLblObjectNo != null)
                    xrLblObjectNo.Text = selectedObject.ACObjectNo;
                XRLabel xrLblObjectName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLblObjectName"];
                if (xrLblObjectName != null)
                    xrLblObjectName.Text = selectedObject.ACObjectName;

                ACAccountsController objAccountsController = new ACAccountsController();
                List<ACAccountsInfo> selectedAccounts = AccountList.Where(a => a.Selected == true).ToList();
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
                List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();

                List<string> accountID = selectedAccounts.Select(x => x.ACAccountID.ToString()).Distinct().ToList();
                List<string> accountNo = selectedAccounts.Select(x => x.ACAccountNo.ToString()).Distinct().ToList();
                List<string> accountName = selectedAccounts.Select(x => x.ACAccountName.ToString()).Distinct().ToList();

                entries = objDocumentEntrysController.GetDocumentEntryGroupByAcountSoChitietCN(fromDate, toDate, string.Join(",", accountID.ToArray())
                    , currencyID, selectedObject.ACObjectID, selectedObject.ACObjectType, branchID);


                if (entries != null && entries.Any())
                {
                    report.DataSource = entries;
                    isComplete = true;
                }
                else
                    return isComplete;


            }
            else
                MessageBox.Show(ReportLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            return isComplete;
        }

        private void RP047_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_lkeObjectType.EditValue = ObjectType.Supplier.ToString();
            fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            InitAccounts();
        }

        private void fld_chkSellectAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (ACAccountsInfo objAccountsInfo in AccountList)
            {
                objAccountsInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcACRP047Accounts.RefreshDataSource();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            if (string.IsNullOrEmpty(objectAccessKey))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            ACObjectsInfo selectedObject = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            selectedObject = objObjectsController.GetObjectByIDAndType(selectedObject.ACObjectID, selectedObject.ACObjectType);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(a => a.Selected == true).ToList();

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            List<string> accountID = selectedAccounts.Select(x => x.ACAccountID.ToString()).Distinct().ToList();

            entries = objDocumentEntrysController.GetDocumentEntryGroupByAcountSoChitietCN(dateFrom, dateTo, string.Join(",", accountID.ToArray())
                , currencyID, selectedObject.ACObjectID, selectedObject.ACObjectType, branchID);
            if (entries != null && entries.Any())
            {
                if (currencyID == GECurrencyID.VND)
                {
                    guiRP049ShowDetail gui = new guiRP049ShowDetail(entries, dateFrom, dateTo, currencyName, selectedObject.ACObjectName, "RP047");
                    gui.Module = Module;
                    gui.ShowDialog();
                }
                else
                {
                    guiRP049CurrencyShowDetail gui = new guiRP049CurrencyShowDetail(entries, dateFrom, dateTo, currencyName, selectedObject.ACObjectName, "RP047");
                    gui.Module = Module;
                    gui.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
