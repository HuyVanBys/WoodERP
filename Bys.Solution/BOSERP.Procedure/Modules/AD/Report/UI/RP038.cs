using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP038 : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ARCancelVoucherItemsInfo> ReportDataSource;

        public RP038()
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

        private void RP038_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
            //InitDataSource();
        }

        /// <summary>
        /// Init data source for report
        /// </summary>
        public void InitDataSource()
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string saleOrderNo = fld_txtARSaleOrderNo.Text;
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            if (branchID > 0)
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                fld_lblSubTitle.Text = objBranchsController.GetObjectNameByID(branchID);
            }
            else
            {
                fld_lblSubTitle.Text = string.Empty;
            }
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text); ;
            ADReportsController objReportsController = new ADReportsController();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<ARCancelVoucherItemsInfo> cancelVoucherItems;
            if (branchID == 0)
            {
                cancelVoucherItems = new List<ARCancelVoucherItemsInfo>();
                foreach (BRBranchsInfo branch in BranchList)
                {
                    List<ARCancelVoucherItemsInfo> result = objReportsController.GetCancelVoucherItemList(
                                                                                        branch.BRBranchID,
                                                                                        saleOrderNo,
                                                                                        objectID,
                                                                                        objectType,
                                                                                        dateFrom,
                                                                                        dateTo);
                    cancelVoucherItems.AddRange(result);
                }
            }
            else
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                cancelVoucherItems = objReportsController.GetCancelVoucherItemList(
                                                                                        branchID,
                                                                                        saleOrderNo,
                                                                                        objectID,
                                                                                        objectType,
                                                                                        dateFrom,
                                                                                        dateTo);
            fld_dgcARRP038ARCancelVoucherItems.DataSource = cancelVoucherItems;
            ReportDataSource = cancelVoucherItems;
            if (cancelVoucherItems.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP038 rp = new BOSReport.RP038();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevRP038Path);
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            XRLabel dateTime = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text); ;
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            if (branchID > 0)
            {
                XRLabel titleLabel = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
                if (titleLabel != null)
                {
                    titleLabel.Text += string.Format(" {0}", objBranchsController.GetObjectNameByID(branchID));
                }
            }
            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP038Path, true);
            reviewer.Show();
        }
    }
}
