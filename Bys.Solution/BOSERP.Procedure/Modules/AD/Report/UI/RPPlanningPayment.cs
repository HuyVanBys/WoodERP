using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RPPlanningPayment : ReportForm
    {
        public List<APPaymentProposalsInfo> PaymentProposalList;

        public RPPlanningPayment()
        {
            InitializeComponent();
        }

        private void RPPlanningPayment_Load(object sender, EventArgs e)
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            PaymentProposalList = objReportsController.GetPaymentProposalListForRP(searchFromDate, searchToDate);
            if (PaymentProposalList.Count() > 0)
            {
                PaymentProposalList.ForEach(o =>
                {
                    //o.HREmployeeWorkScheduleHourFrom = o.HREmployeeWorkScheduleDateFrom;
                    //o.HREmployeeWorkScheduleHourTo = o.HREmployeeWorkScheduleDateTo;
                });
            }
            fld_dgcRPPlanningPaymentProposalItems.DataSource = PaymentProposalList;
            GridView gridView = (GridView)fld_dgcRPPlanningPaymentProposalItems.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            string rptFile = System.IO.Path.Combine("Reports", "RPPlanningPayment" + ".repx");
            BaseReport report = new BaseReport();
            guiReportPreview reviewer;
            bool bExists = System.IO.File.Exists(rptFile);
            if (!bExists)
            {
                if (MessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bạn có muốn thiết kế ?"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    reviewer = new guiReportPreview(report, rptFile, true);
                    reviewer.Show();
                    return;
                }
            }
            report.LoadLayout(rptFile);
            report.DataSource = fld_dgcRPPlanningPaymentProposalItems.DataSource;
            reviewer = new guiReportPreview(report, rptFile, true);
            reviewer.Show();
        }
    }
}
