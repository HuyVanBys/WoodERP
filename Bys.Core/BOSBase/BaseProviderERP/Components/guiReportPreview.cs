using BOSERP.Utilities;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiReportPreview : BOSERPScreen
    {
        #region Variables
        /// <summary>
        /// A variable is used to store the printer settings
        /// </summary>
        private PrinterSettings PrinterSettings;
        #endregion

        /// <summary>
        /// Gets or sets the report is previewed.
        /// </summary>
        public XtraReport Report { get; private set; }
        public bool CreateReport = true;

        /// <summary>
        /// Gets or sets file name of report
        /// </summary>
        public string ReportFileName { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public guiReportPreview()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="report">Report for viewing</param>
        public guiReportPreview(XtraReport report)
        {
            InitializeComponent();

            Report = report;

            SetAllowPrint(true);

            //Set format for the report's fields
            XtraReportHelper.SetFormatField(Report);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="report">Report for viewing</param>
        /// <param name="setFieldFormat">A value indicates whether the binding fields should be formatted automatically</param>
        public guiReportPreview(XtraReport report, bool setFieldFormat)
        {
            InitializeComponent();

            Report = report;

            SetAllowPrint(true);

            if (setFieldFormat)
            {
                XtraReportHelper.SetFormatField(Report);
            }
        }

        public guiReportPreview(XtraReport report, string fileName, bool allowPrint)
        {
            InitializeComponent();

            Report = report;
            ReportFileName = fileName;

            SetAllowPrint(allowPrint);

            //Set format for the report's fields
            XtraReportHelper.SetFormatField(Report);
        }

        public guiReportPreview(XtraReport report, string fileName, bool allowPrint, bool showReportToolbar)
        {
            InitializeComponent();

            Report = report;
            ReportFileName = fileName;

            SetAllowPrint(allowPrint);

            //Set format for the report's fields
            XtraReportHelper.SetFormatField(Report);

            ShowReportToolbar(showReportToolbar);
        }

        private void guiReportPreview_Load(object sender, EventArgs e)
        {
            printControl1.PrintingSystem = Report.PrintingSystem;
            // Generate the report's print document. 
            Report.CreateDocument();
        }

        private void fld_btnEditTemplate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Show the End-User Designer form, modally.
            guiReportDesigner designer = new guiReportDesigner(Report, ReportFileName);
            designer.Show();
            Close();
        }

        /// <summary>
        /// Set allow print or not
        /// </summary>
        /// <param name="allowPrint">True if allow print</param>
        private void SetAllowPrint(bool allowPrint)
        {
            if (allowPrint)
            {
                fld_btnPrint.Visibility = BarItemVisibility.Always;
            }
            else
            {
                fld_btnPrint.Visibility = BarItemVisibility.Never;
            }
        }

        private void ShowReportToolbar(bool showReportToolbar)
        {
            previewBar1.Visible = showReportToolbar;
        }

        private void fld_btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            ADReportsController objReportsController = new ADReportsController();
            short copies = 1;
            ADReportsInfo objReportsInfo = (ADReportsInfo)objReportsController.GetObjectByNo(Report.GetType().Name);
            if (objReportsInfo != null)
            {
                copies = objReportsInfo.ADReportCopies;
            }

            PrintDialog printDialog = new PrintDialog();
            printDialog.PrinterSettings.Copies = copies;
            printDialog.AllowSomePages = true;
            printDialog.AllowCurrentPage = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrinterSettings = printDialog.PrinterSettings;
                Report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                for (int i = 0; i < printDialog.PrinterSettings.Copies; i++)
                {
                    XtraReportHelper.PrintToPrinter(Report, printDialog.PrinterSettings.PrinterName);
                }
            }
        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            if (PrinterSettings.FromPage > 0 && PrinterSettings.ToPage > 0)
            {
                e.PrintDocument.PrinterSettings.FromPage = PrinterSettings.FromPage;
                e.PrintDocument.PrinterSettings.ToPage = PrinterSettings.ToPage;
            }
        }
    }
}
