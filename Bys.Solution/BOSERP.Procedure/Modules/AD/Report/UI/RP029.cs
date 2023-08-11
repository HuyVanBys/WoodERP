using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP029 : ReportForm
    {
        public RP029()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RP029_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromAPInvoiceInDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToAPInvoiceInDate.EditValue = BOSUtil.GetMonthEndDate();

            ShowReportData();
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        /// <summary>
        /// Show report's data based on the report's parameter
        /// </summary>
        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime dateFrom = fld_dteSearchFromAPInvoiceInDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPInvoiceInDate.DateTime;
            //Set title report
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], END

            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            DataSet ds = objReportsController.GetInvoiceInsBySomeCriteriaAndBranchNos(objectID, objectType, dateFrom, dateTo, branchNos);
            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], END       
            fld_dgcAPRP029APInvoiceIns.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count <= 0)
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
            BOSReport.RP029 rp = new BOSReport.RP029();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevInvoiceInReportPath);
            ADReportsController objReportsController = new ADReportsController();
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime dateFrom = fld_dteSearchFromAPInvoiceInDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPInvoiceInDate.DateTime;
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], END

            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            DataSet ds = objReportsController.GetInvoiceInsBySomeCriteriaAndBranchNos(objectID, objectType, dateFrom, dateTo, branchNos);
            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], END
            rp.DataSource = ds;
            rp.DataMember = BOSCommon.Constants.Report.DevInvoiceInReportName;

            //Set current branch
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
            XRLabel subTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text = String.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));
            }
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceInReportPath, true);
            reviewer.Show();
        }
    }
}
