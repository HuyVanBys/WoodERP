using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP180 : ReportForm
    {
        public RP180()
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
            BOSReport.RP180 report = new BOSReport.RP180();
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
            ICProductsController objProductsController = new ICProductsController();

            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;


            (report as BOSReport.RP180).DateTimeReport = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                     ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            List<ICProductsInfo> productList = objProductsController.GetProductForReport180();
            List<ICProductsInfo> list = new List<ICProductsInfo>();
            List<ICProductsInfo> sublist = new List<ICProductsInfo>();

            double percent = 0;
            double percentplus = 0;
            double percentPrint = 0;

            percentplus = 100 / double.Parse(productList.Count.ToString());

            BOSProgressBar.Start("Đang load dữ liệu");
            foreach (ICProductsInfo product in productList)
            {
                percent += percentplus;
                if (percent > 100)
                {
                    percent = 100;
                }
                percentPrint = Math.Round(percent, 0);
                BOSProgressBar.Start("Đang load dữ liệu " + percentPrint + "%");
                sublist = (List<ICProductsInfo>)objProductsController.GetItemForReport180(dateFrom, dateTo, product.ICProductID);
                list.AddRange(sublist);
            }
            BOSProgressBar.Close();
            report.DataSource = list;
        }

    }
}
