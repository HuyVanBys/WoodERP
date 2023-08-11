using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP006 : ReportForm
    {
        public RP006()
        {
            InitializeComponent();
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

        private void RP006_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            //Set default from date to date
            fld_dteSearchFromARInvoiceDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteSearchToARInvoiceDate.DateTime = BOSUtil.GetYearEndDate();

            //Set default branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            fld_lkeFK_BRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            fld_lblBranchName.Text = objBranchsInfo.BRBranchName;
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);

            //InvalidateInvoiceChartControl();
            //fld_cctrlARRP006Invoices.ShowOverTimeChart();
        }

        /// <summary>
        /// Invalidate invoice chart control by branch id and from date to date
        /// </summary>
        private void InvalidateInvoiceChartControl()
        {
            int branchID = Convert.ToInt32(fld_lkeFK_BRBranchID.EditValue);
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<OverTimeChartPointInfo> points = objReportsController.GetBranchSaleOverTime(branchID, fromDate, toDate);            
            List<OverTimeChartPointInfo> points;
            if (branchID == 0)
            {
                points = new List<OverTimeChartPointInfo>();
                foreach (BRBranchsInfo branch in BranchList)
                {
                    List<OverTimeChartPointInfo> list = objReportsController.GetBranchSaleOverTime(branch.BRBranchID, fromDate, toDate);
                    if (list != null)
                        points.AddRange(list);
                }
            }
            else
                points = objReportsController.GetBranchSaleOverTime(branchID, fromDate, toDate);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            fld_cctrlARRP006Invoices.Points = points;
        }

        private void fld_ctxItemDayOfWeek_Click(object sender, EventArgs e)
        {
            fld_cctrlARRP006Invoices.Titles[1].Text = fld_ctxItemDayOfWeek.Text;
            fld_cctrlARRP006Invoices.FilterType = OverTimeChart.FilterTypeEnum.DayOfWeek;
            fld_cctrlARRP006Invoices.ShowOverTimeChart();
        }

        private void fld_ctxItemDayOfMonth_Click(object sender, EventArgs e)
        {
            fld_cctrlARRP006Invoices.Titles[1].Text = fld_ctxItemDayOfMonth.Text;
            fld_cctrlARRP006Invoices.FilterType = OverTimeChart.FilterTypeEnum.DayOfMonth;
            fld_cctrlARRP006Invoices.ShowOverTimeChart();
        }

        private void fld_ctxItemMonth_Click(object sender, EventArgs e)
        {
            fld_cctrlARRP006Invoices.Titles[1].Text = fld_ctxItemMonth.Text;
            fld_cctrlARRP006Invoices.FilterType = OverTimeChart.FilterTypeEnum.Month;
            fld_cctrlARRP006Invoices.ShowOverTimeChart();
        }

        private void fld_ctxItemYear_Click(object sender, EventArgs e)
        {
            fld_cctrlARRP006Invoices.Titles[1].Text = fld_ctxItemYear.Text;
            fld_cctrlARRP006Invoices.FilterType = OverTimeChart.FilterTypeEnum.Year;
            fld_cctrlARRP006Invoices.ShowOverTimeChart();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeFK_BRBranchID.EditValue);
            if (branchID > 0)
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                if (objBranchsInfo != null)
                {
                    fld_lblBranchName.Text = objBranchsInfo.BRBranchName;
                }
            }
            else
            {
                fld_lblBranchName.Text = string.Empty;
            }
            InvalidateInvoiceChartControl();
            fld_cctrlARRP006Invoices.ShowOverTimeChart();
        }

        private void fld_dteSearchFromARInvoiceDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            e.ErrorText = ReportLocalizedResources.FromDateLargerToDateErrorMessage;
        }

        private void fld_dteSearchFromARInvoiceDate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (fld_dteSearchFromARInvoiceDate.DateTime > fld_dteSearchToARInvoiceDate.DateTime);
        }

        private void fld_dteSearchToARInvoiceDate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (fld_dteSearchFromARInvoiceDate.DateTime > fld_dteSearchToARInvoiceDate.DateTime);
        }

        private void fld_dteSearchToARInvoiceDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            e.ErrorText = ReportLocalizedResources.ToDateLessFromDateErrorMessage;
        }
    }
}