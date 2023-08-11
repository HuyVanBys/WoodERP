using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BOSCommon;
using BOSERP.Utilities;
using System.Windows.Forms;

namespace BOSERP.Modules.ElectronicInvoiceBKAV
{
    public partial class guiChooseReportPeriod : BOSERPScreen
    {
        private BackgroundWorker ExportWorker;

        private List<ACEInvoiceGeneralsInfo> EInvoiceUpdateList { get; set; }

        private int CountTotal { get; set; }

        private int CountSuccessful { get; set; }

        private DateTime FromDate { get; set; }

        private DateTime ToDate { get; set; }

        public string ResultMessage { get; set; }

        public guiChooseReportPeriod()
        {
            InitializeComponent();
        }

        public guiChooseReportPeriod(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            fld_dteFromDate.DateTime = fromDate;
            fld_dteToDate.DateTime = toDate;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            FromDate = fld_dteFromDate.DateTime;
            ToDate = fld_dteToDate.DateTime;
            
            ACEInvoiceGeneralsController controller = new ACEInvoiceGeneralsController();
            EInvoiceUpdateList = controller.GetEInvoiceGeneralForUpdateStatus(FromDate, ToDate);
            CountTotal = EInvoiceUpdateList.Count;
            CountSuccessful = 0;

            ExportWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            ExportWorker.DoWork += new DoWorkEventHandler(ExportWorker_DoWork);
            ExportWorker.ProgressChanged += new ProgressChangedEventHandler(ExportWorker_ProgressChanged);
            ExportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExportWorker_RunWorkerCompleted);
            ExportWorker.RunWorkerAsync();
            DialogResult = DialogResult.OK;
            Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in Controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void ExportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        private void ExportWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            fld_pgbProcessExport.EditValue = e.ProgressPercentage;
        }

        private void ExportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker background = sender as BackgroundWorker;            
            background.ReportProgress(10);

            int index = 2;
            int totalItem = EInvoiceUpdateList.Count() + 10;
            int process = 0;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo invoice = new ARInvoicesInfo();
            ACEInvoiceGeneralsController objEInvoiceGeneralsController = new ACEInvoiceGeneralsController();

            EInvoiceUpdateList.ForEach(o =>
            {
                ApiBkavEInvoiceHelper bkavEInvoiceHelper = new ApiBkavEInvoiceHelper(o.FK_ACTaxUnitID);
                if (bkavEInvoiceHelper.GetInfoEInvoiceBKAV(o))
                {                    
                    objEInvoiceGeneralsController.UpdateVATInvoiceNoEInvoiceGeneralID(o.ACEInvoiceGeneralID);
                    CountSuccessful++;
                }
                index++;
                process = 10 + 100 * index / totalItem;
                if (process > 100)
                    process = 100;
                background.ReportProgress(process);
            });
            ResultMessage = string.Format("Kết quả cập nhật trạng thái hóa đơn điện tử từ ngày {0} đến ngày {1}:" + Environment.NewLine
                                                + " -Thành công: {2} hóa đơn" + Environment.NewLine
                                                + " -Thất bại: {3} hóa đơn"
                                                , FromDate.ToString("dd/MM/yyyy")
                                                , ToDate.ToString("dd/MM/yyyy")
                                                , CountSuccessful.ToString()
                                                , (CountTotal - CountSuccessful).ToString());
            background.ReportProgress(100);
        }
    }
}
