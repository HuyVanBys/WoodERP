using BOSReport;
using DevExpress.XtraPrinting;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RPInputInvoice : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ACDocumentsInfo> documents;
        private List<ACDocumentsInfo> originalDocuments;

        public RPInputInvoice()
        {
            InitializeComponent();
            originalDocuments = new List<ACDocumentsInfo>();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RPInputInvoice_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            if (documents != null && documents.Any())
            {
                BOSReport.RPInputInvoice report = new BOSReport.RPInputInvoice();
                List<ACDocumentsInfo> selectedItems = documents.Where(item => item.Selected == true).ToList();
                report.DataSource = selectedItems;
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPInputInvoicePath, true);
                reviewer.Show();
            }

        }

        private void fld_btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    BOSReport.RPInputInvoice report = new BOSReport.RPInputInvoice();
                    //rp.LoadLayout(BOSCommon.Constants.Report.DevInvoiceReportPath);
                    List<ACDocumentsInfo> selectedItems = documents.Where(item => item.Selected == true).ToList();
                    report.DataSource = selectedItems;
                    ExportToXLSX(fileName, report, "PL 01-2_GTGT");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToXLSX(string reportPath, BaseReport report, string sheetName)
        {
            // Get its XLSX export options.
            XlsxExportOptions xlsxOptions = report.ExportOptions.Xlsx;

            // Set XLSX-specific export options.
            xlsxOptions.ShowGridLines = true;
            xlsxOptions.TextExportMode = TextExportMode.Value;
            xlsxOptions.ExportHyperlinks = true;
            xlsxOptions.SheetName = sheetName;

            // Export the report to XLSX.
            report.ExportToXlsx(reportPath);

            // Show the result.
            StartProcess(reportPath);
        }

        // Use this method if you want to automaically open
        // the created XLSX file in the default program.
        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteSearchFromARInvoiceDate.DateTime;
            DateTime toDate = fld_dteSearchToARInvoiceDate.DateTime;
            ACDocumentsController documentController = new ACDocumentsController();
            documents = documentController.GetDocumentsForInputVAT(fromDate, toDate);
            originalDocuments.Clear();
            if (documents != null)
            {
                foreach (ACDocumentsInfo document in documents)
                {
                    //if (document.ACDocumentTypeName == AccDocumentType.MuaHangCongNo.ToString())
                    //{
                    if (document.DocumentTotalPaymentAmount != 0)
                        document.DocumentTaxPercent = document.DocumentTaxAmount * 100 / document.DocumentTotalPaymentAmount;
                    //}

                    //    originalDocuments.Add(document.Clone() as ACDocumentsInfo);

                    //    if (document.ACDocumentTypeName == AccDocumentType.MuaHangCongNo.ToString())
                    //        document.Selected = true;                    
                }

                BOSReport.RPInputInvoice report = new BOSReport.RPInputInvoice();
                //List<ACDocumentsInfo> selectedItems = documents.Where(item => item.Selected == true).ToList();
                report.DataSource = documents;
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPInputInvoicePath, true);
                reviewer.Show();

                //fld_dgcRPInputInvoice.DataSource = documents;
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (documents != null)
            {
                List<ACDocumentsInfo> changedItems = documents.Where(document =>
                                                            originalDocuments.Any(item => item.ACDocumentID == document.ACDocumentID &&
                                                                                    (item.Selected != document.Selected) ||
                                                                                    item.ACDocumentVATFormNo != document.ACDocumentVATFormNo ||
                                                                                    item.ACDocumentVATSymbol != document.ACDocumentVATSymbol ||
                                                                                    item.ACDocumentVoucherNo != document.ACDocumentVoucherNo ||
                                                                                    item.ACVATInvoiceNoCombo != document.ACVATInvoiceNoCombo ||
                                                                                    item.ACVATDocumentType != document.ACVATDocumentType)).ToList();
                if (changedItems != null && changedItems.Any())
                {
                    ACDocumentsController documentController = new ACDocumentsController();
                    foreach (ACDocumentsInfo document in changedItems)
                    {
                        if (document.Selected == true)
                            document.ACDocumentVATType = "InputVAT";
                        else
                            document.ACDocumentVATType = string.Empty;
                        documentController.UpdateObject(document);
                    }

                    //refresh original document list
                    originalDocuments.Clear();
                    foreach (ACDocumentsInfo document in changedItems)
                    {
                        originalDocuments.Add(document.Clone() as ACDocumentsInfo);
                    }
                }
            }
        }


    }
}