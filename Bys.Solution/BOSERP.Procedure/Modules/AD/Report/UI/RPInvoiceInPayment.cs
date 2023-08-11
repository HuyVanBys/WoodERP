using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSERP.Modules.Report;
using BOSERP.Utilities;
using Localization;
using DevExpress.XtraReports.UI;
using BOSReport;
using BOSLib;
using BOSComponent;
using BOSCommon;

namespace BOSERP.Modules.Report
{
    public partial class RPInvoiceInPayment : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        private List<ACAccountsInfo> AccountList;
        bool IsgroupByCurency = false;
        public RPInvoiceInPayment()
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
            BOSReport.RPInvoiceInPayment report = new BOSReport.RPInvoiceInPayment();
            int currencyID = 0;
            if (fld_lkeGECurrencyID.EditValue != null)
            {
                int.TryParse(fld_lkeGECurrencyID.EditValue.ToString(), out currencyID);
            }

            if (currencyID == 0)
            {
                MessageBox.Show("Vui lòng chọn loại tiền tệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                bool isDataExist = InitDataSourceReport(report);
                if (isDataExist)
                {
                    GECurrenciesController cController = new GECurrenciesController();
                    GECurrenciesInfo c = (GECurrenciesInfo)cController.GetObjectByID(currencyID);
                    //xrReportTitle
                    XRLabel xrReportTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["CurrencyLabel"];
                    if (xrReportTitle != null)
                        xrReportTitle.Text = c.GECurrencyName;
                    report.CurrencyName = c.GECurrencyName;
                    guiReportPreview reviewer = new guiReportPreview(report, false);
                    ADReportsController objReportsController = new ADReportsController();
                    string name = fld_lkeBRBranchID.Screen.Name;
                    DataSet ds = objReportsController.GetReportByReportNo(name);
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                        reviewer.Text = ds.Tables[0].Rows[0]["ADReportName"].ToString();
                    ds.Dispose();
                    reviewer.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
      
        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public bool InitDataSourceReport(BOSReport.RPInvoiceInPayment report)
        {

            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            DateTime fromdate = fld_dteSearchFromDate.DateTime;
            DateTime todate = fld_dteSearchToDate.DateTime;
            int branchID = 0;
            if (fld_lkeBRBranchID.EditValue != null)
            {
                int.TryParse(fld_lkeBRBranchID.EditValue.ToString(), out branchID);
            }

            int currencyID = 0;
            if (fld_lkeGECurrencyID.EditValue != null)
            {
                int.TryParse(fld_lkeGECurrencyID.EditValue.ToString(), out currencyID);
            }

            int objectID = 0;
            string objectType = string.Empty;

            if (fld_lkeACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeACObjectID.EditValue.ToString().Split(';');
                if (objectKey != null && objectKey.Length == 2)
                {
                    int.TryParse(objectKey[0], out objectID);
                    objectType = objectKey[1];
                }
             }

            APInvoiceInsController iiController = new APInvoiceInsController();
            List<APInvoiceInsInfo> dataList = iiController.GetDataForInvoiceInPaymentReport(fromdate, todate, branchID, currencyID, objectID, objectType);

            if (dataList != null && dataList.Count > 0)
            {
                report.DataSource = dataList;
                return true;
            }
            else
            {
                return false;
            }
        }
            
        private void RPInvoiceInPayment_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
          
        }

        private void fld_lkeBRBranchID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            fld_lkeBRBranchID.Properties.DataSource = objBranchsController.GetAllActiveBranches();
        }

     
    }
}
