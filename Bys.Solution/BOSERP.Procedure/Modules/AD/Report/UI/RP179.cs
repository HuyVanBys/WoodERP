using BOSLib;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP179 : ReportForm
    {
        public RP179()
        {
            InitializeComponent();
        }


        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RP070_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
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
            BOSReport.RP179 report = new BOSReport.RP179();
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP178Path, true);
            reviewer.Show();
        }
        public void InitDataSourceReport(XtraReport report)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();

            List<ARInvoiceItemsInfo> list = (List<ARInvoiceItemsInfo>)objInvoiceItemsController.GetItemForReport179(dateFrom, dateTo);
            report.DataSource = list;
        }

    }
}
