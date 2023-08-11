using BOSERP.Utilities;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP185 : ReportForm
    {
        private List<ARInvoicesInfo> InvoiceList;

        public RP185()
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

        private void RP052_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            ARInvoicesController objInvoicesController = new ARInvoicesController();
            InvoiceList = objInvoicesController.GetInvoiceListByDate(BOSUtil.GetMonthBeginDate(), BOSUtil.GetMonthEndDate());

            fld_lkeInvoiceVATNo.Properties.DataSource = InvoiceList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP185 report = new BOSReport.RP185();
            if (InitDataSourceReport(report) == false)
            {
                MessageBox.Show("Vui lòng chọn số hóa đơn!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraReportHelper.SetFormatField(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP184Path, true);
                reviewer.Show();
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        public bool InitDataSourceReport(XtraReport report)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            string invoiceVATNo = Convert.ToString(fld_lkeInvoiceVATNo.EditValue);

            //string invoiceVATNo = string.Empty;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            //ARInvoicesInfo objInvoiceInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(invoiceID);
            //if(objInvoiceInfo != null)
            //{
            //    invoiceVATNo = objInvoiceInfo.ARInvoiceVATInvoiceNo;
            //}

            if (String.IsNullOrEmpty(invoiceVATNo))
            {
                return false;
            }
            else
            {
                ARInvoicesInfo objInvoicesInfo = objInvoicesController.GetInvoiceDateByInvoiceVATNoAndFromdateTodate(invoiceVATNo, dateFrom, dateTo);

                XRLabel invoiceSupplierNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblIInvoiceSupplierNo"];
                if (invoiceSupplierNo != null)
                    invoiceSupplierNo.Text = invoiceVATNo;
                XRLabel date = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["lbl_Ngay"];
                if (date != null)
                    if (objInvoicesInfo != null)
                    {
                        date.Text = objInvoicesInfo.InvoiceDate;
                    }

                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                List<ARInvoiceItemsInfo> InvoiceItemList = objInvoiceItemsController.GetDataForReport185(dateFrom, dateTo, invoiceVATNo);

                report.DataSource = InvoiceItemList;

                return true;
            }
        }

        private void fld_dteSearchFromDate_TextChanged(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            InvoiceList = objInvoicesController.GetInvoiceListByDate(dateFrom, dateTo);

            fld_lkeInvoiceVATNo.Properties.DataSource = InvoiceList;

        }

        private void fld_dteSearchToDate_TextChanged(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            InvoiceList = objInvoicesController.GetInvoiceListByDate(dateFrom, dateTo);

            fld_lkeInvoiceVATNo.Properties.DataSource = InvoiceList;
        }

    }
}
