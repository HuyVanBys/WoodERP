using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP034 : ReportForm
    {
        public RP034()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void RP034_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromICTransferDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToICTransferDate.EditValue = BOSUtil.GetMonthEndDate();

            ShowReportData();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        /// <summary>
        /// Show report's data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            int fromStockID = Convert.ToInt32(fld_lkeFK_ICFromStockID.EditValue);
            int toStockID = Convert.ToInt32(fld_lkeFK_ICToStockID.EditValue);
            string serieNo = fld_txtICTransferItemProductSerieNo.Text;
            DateTime fromDate = fld_dteSearchFromICTransferDate.DateTime;
            DateTime toDate = fld_dteSearchToICTransferDate.DateTime;
            string transferStatus = Convert.ToString(fld_lkeICTransferStatus.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            //Set title report
            fld_lblSubTitleDate.Text = String.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fromDate.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy"));
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICTransferItemsInfo> transferItemList = objReportsController.GetTransferProductList(fromStockID, toStockID, fromDate, toDate, serieNo, transferStatus);
            List<ICTransferItemsInfo> transferItemList = objReportsController.GetTransferProductListByBranchNoList(fromStockID, toStockID, fromDate, toDate, serieNo, transferStatus, branchNos);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcRP034ICTransferItems.DataSource = transferItemList;
            if (transferItemList.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP034 rp = new BOSReport.RP034();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevTransferProductReportPath);

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            int fromStockID = Convert.ToInt32(fld_lkeFK_ICFromStockID.EditValue);
            int toStockID = Convert.ToInt32(fld_lkeFK_ICToStockID.EditValue);
            string serieNo = fld_txtICTransferItemProductSerieNo.Text;
            DateTime fromDate = fld_dteSearchFromICTransferDate.DateTime;
            DateTime toDate = fld_dteSearchToICTransferDate.DateTime;
            string transferStatus = Convert.ToString(fld_lkeICTransferStatus.EditValue);
            //Set title report
            XRLabel subTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text += String.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fromDate.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy"));
            }
            List<ICTransferItemsInfo> transferItemList = objReportsController.GetTransferProductList(fromStockID, toStockID, fromDate, toDate, serieNo, transferStatus);
            rp.DataSource = transferItemList;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevTransferProductReportPath, true);
            reviewer.Show();
        }
    }
}
