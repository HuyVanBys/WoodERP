using BOSCommon.Constants;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using BOSCommon;
using Localization;
using BOSERP.Utilities;

namespace BOSERP.Modules.Report
{
    public partial class RP161 : ReportForm
    {
        #region Variables
        public BOSList<ACBankTransactionItemsInfo> PaymentOrderList;

        public IList<ACBankTransactionItemsInfo> SelectedObjects;

        public BOSLookupEdit PrintTemplateMethod;

        public GridControlHelper GridControlHelper { get; private set; }
        #endregion
        public RP161()
        {
            InitializeComponent();
            PaymentOrderList = new BOSList<ACBankTransactionItemsInfo>(TableName.ACBankTransactionItemsTableName);
            PrintTemplateMethod = (BOSLookupEdit)Controls["fld_lkePrintTemplates"];
            PrintTemplateMethod.QueryPopUp += new System.ComponentModel.CancelEventHandler(PrintTemplateMethod_QueryPopUp);
        }

        private void PrintTemplateMethod_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("RPDetailBankTransactionMethod");
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            fld_lkePrintTemplates.Properties.Columns.Clear();
            fld_lkePrintTemplates.Properties.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));

            if (ConfigValuesList != null)
            {
                fld_lkePrintTemplates.BOSDataSource = "";
                fld_lkePrintTemplates.BOSDataMember = "";
                fld_lkePrintTemplates.Properties.DataSource = ConfigValuesList;
                fld_lkePrintTemplates.Properties.DisplayMember = "ADConfigText";
                fld_lkePrintTemplates.Properties.ValueMember = "ADConfigKeyValue";
            }
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
            SelectedObjects = GridControlHelper.Selection.OfType<ACBankTransactionItemsInfo>().ToList();
            if (SelectedObjects == null || SelectedObjects.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn chứng từ cần in", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            XtraReport report = new XtraReport();
            switch ((String)fld_lkePrintTemplates.EditValue)
            {
                case "VCB":
                    report = new BOSReport.RP161VCB();
                    break;
                case "NN":
                    report = new BOSReport.RP161NN();
                    break;
                case "VCBN":
                    report = new BOSReport.RP161VCBn();
                    break;
                case "Agribank":
                    report = new BOSReport.RP161NNN();
                    break;
                case "Vietin":
                    report = new BOSReport.RP161VT();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn mẫu in", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            InitDataSourceReport(report);
            report.DataSource = SelectedObjects;
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
            XRLabel branchAddress = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddress"];
            if (branchAddress != null)
                branchAddress.Text = objBranchsInfo.BRBranchContactAddressLine1;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            int bankID = Convert.ToInt32(fld_lkeCSCompanyBankID.EditValue);

            //CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            //if (bankID > 0)
            //{
            //    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
            //    XRLabel xrLabel22 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xrLabel22"];
            //    if (xrLabel22 != null)
            //        xrLabel22.Text = objCompanyBanksInfo.CSCompanyBankName.ToUpper();
            //}
            //XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            //dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
            //                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            //List<ACBankTransactionItemsInfo> result = new List<ACBankTransactionItemsInfo>();
            //ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            //result = objBankTransactionItemsController.GetBankTransactionsForRP161(dateFrom, dateTo, bankID);
            //report.DataSource = result;
            decimal totalAmountVND = PaymentOrderList.Where(o => o.GECurrencyNo == CurrencyNo.VND.ToString()).Sum(o1 => o1.APPaymentProposalPaymentAmount);
            decimal totalAmountUSD = PaymentOrderList.Where(o => o.GECurrencyNo != CurrencyNo.VND.ToString()).Sum(o1 => o1.APPaymentProposalPaymentEAmount);
            XRLabel amountVND = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrAmountVND"];
            if (amountVND != null)
                amountVND.Text = ConvertAmountToWord.ReadAmount(totalAmountVND.ToString(), GECurrencyID.VND);
            XRLabel amountUSD = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrAmountUSD"];
            if (amountUSD != null)
                amountUSD.Text = ConvertAmountToWord.ReadAmount(totalAmountUSD.ToString(), GECurrencyID.USD);
            XRLabel amountUSD1 = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrAmountUSD1"];
            if (amountUSD1 != null)
                amountUSD1.Text = ConvertAmountToWord.ReadAmount(totalAmountUSD.ToString(), GECurrencyID.USD);
        }


        private void RP054_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-1);
            fld_dteSearchToDate.DateTime = BOSApp.GetCurrentServerDate();
            InitializeControls(Controls);
            GridView gridView = (GridView)fld_dgcPrintMultiPaymentOrdersGridControl.MainView;
            GridControlHelper = new GridControlHelper(gridView);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
        public void GetDataSearch()
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int bankID = Convert.ToInt32(fld_lkeCSCompanyBankID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            List<ACBankTransactionItemsInfo> listItem = objBankTransactionItemsController.GetDetailBankTransactions(dateFrom, dateTo, bankID, branchID);
            PaymentOrderList.Invalidate(listItem);
            fld_dgcPrintMultiPaymentOrdersGridControl.DataSource = PaymentOrderList;
            fld_dgcPrintMultiPaymentOrdersGridControl.RefreshDataSource();
        }
    }
}
