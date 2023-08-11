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
    public partial class RP066 : ReportForm
    {
        public RP066()
        {
            InitializeComponent();
        }

        private void RP066_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
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
            BOSReport.RP066 report = new BOSReport.RP066();
            InitReportDataSource(report);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>        
        public void InitReportDataSource(XtraReport report)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
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
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteFromDate.Text, ReportLocalizedResources.ToDateTitle, fld_dteToDate.Text);

            List<ACDocumentEntrysInfo> entries = GetReportData();
            report.DataSource = entries;
        }

        /// <summary>
        /// Get data for the report
        /// </summary>
        /// <returns>List of entries represents the report data</returns>
        private List<ACDocumentEntrysInfo> GetReportData()
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            int documentTypeID = Convert.ToInt32(fld_lkeACDocumentTypeID.EditValue);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            foreach (BRBranchsInfo branch in selectedBranches)
            {
                List<ACDocumentEntrysInfo> list = objDocumentEntrysController.GetEntryList(documentTypeID, currencyID, null, branch.BRBranchID, fromDate, toDate);
                entries.AddRange(list);
            }
            entries = entries.OrderBy(item => item.ACDocumentDate).ToList();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            List<ACDocumentEntrysInfo> result = new List<ACDocumentEntrysInfo>();
            foreach (ACDocumentEntrysInfo entry in entries)
            {
                if (entry.ACDocumentEntryExchangeAmount > 0)
                {
                    // entry.ACDocumentEntryContraAccountNo = entry.ACDocumentDebitAccount;
                    // entry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryExchangeAmount;                    
                    //result.Add(entry);

                    ACDocumentEntrysInfo contraryEntry = new ACDocumentEntrysInfo();
                    contraryEntry.ACDocumentNo = entry.ACDocumentNo;
                    contraryEntry.ACDocumentDate = entry.ACDocumentDate;
                    contraryEntry.ACDocumentEntryDesc = entry.ACDocumentEntryDesc;
                    contraryEntry.ACDocumentEntryContraAccountNo = entry.ACDocumentCreditAccount;
                    contraryEntry.ACDocumentEntryCreditAmount = entry.ACDocumentEntryExchangeAmount;
                    contraryEntry.ACDocumentEntryAccountNo = entry.ACDocumentDebitAccount;
                    contraryEntry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryExchangeAmount;
                    result.Add(contraryEntry);
                }
            }
            return result;
        }

        private void fld_btnExportToExcel_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            //Workbook exWorkBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            //Worksheet exSheet = (Worksheet)exWorkBook.Worksheets[1];
            //exSheet.Activate();

            //List<ACDocumentEntrysInfo> entries = GetReportData();

            //int i = 1;
            //int j = 1;
            //foreach (ACDocumentEntrysInfo item in entries)
            //{
            //    exSheet.Cells[i, j] = "aa";
            //    i++;
            //    j++;
            //}
            //exWorkBook.SaveAs("csharp-Excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
            //    misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
            //    misValue, misValue, misValue, misValue, misValue);
            //exWorkBook.Close(true, misValue, misValue);
            //exApp.Quit();

            //releaseObject(exSheet);
            //releaseObject(exWorkBook);
            //releaseObject(exApp);

            //MessageBox.Show("Excel file created , you can find the file c:\\csharp-Excel.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
