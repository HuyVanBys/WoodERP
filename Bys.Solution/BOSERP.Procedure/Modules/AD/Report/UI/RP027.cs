using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP027 : ReportForm
    {
        public RP027()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void RP027_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromAPPurchaseOrderDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToAPPurchaseOrderDate.EditValue = BOSUtil.GetMonthEndDate();

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
            string purchaseOrderType = string.Empty;
            //Set title report
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromAPPurchaseOrderDate.DateTime.ToString("dd/MM/yyyy"),
                                                                   ReportLocalizedResources.ToDateTitle, fld_dteSearchToAPPurchaseOrderDate.DateTime.ToString("dd/MM/yyyy"));
            if (fld_lkeAPPurchaseOrderTypeCombo.EditValue != null)
                purchaseOrderType = fld_lkeAPPurchaseOrderTypeCombo.EditValue.ToString();


            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], END

            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            DataSet ds = objReportsController.GetPurchaseOrdersBySomeCriteriaAndBranchNos(Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue),
                                                                        purchaseOrderType,
                                                                        fld_dteSearchFromAPPurchaseOrderDate.DateTime,
                                                                        fld_dteSearchToAPPurchaseOrderDate.DateTime,
                                                                        branchNos);
            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], END
            fld_dgcAPRP027APPurchaseOrders.DataSource = ds.Tables[0];
            fld_dgcAPRP027APPurchaseOrders.RefreshDataSource();
            if (ds.Tables[0].Rows.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 3));
            return lstHeaderParameter;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP027 report = new BOSReport.RP027();
            //report.LoadLayout(BOSCommon.Constants.Report.DevPurchaseOrderReportPath);
            ADReportsController objReportsController = new ADReportsController();
            string purchaseOrderType = string.Empty;
            if (fld_lkeAPPurchaseOrderTypeCombo.EditValue != null)
                purchaseOrderType = fld_lkeAPPurchaseOrderTypeCombo.EditValue.ToString();
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], END

            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            DataSet ds = objReportsController.GetPurchaseOrdersBySomeCriteriaAndBranchNos(Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue),
                                                                        purchaseOrderType,
                                                                        fld_dteSearchFromAPPurchaseOrderDate.DateTime,
                                                                        fld_dteSearchToAPPurchaseOrderDate.DateTime,
                                                                        branchNos);
            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], END
            report.DataSource = ds;
            report.DataMember = BOSCommon.Constants.Report.DevPurchaseOrderReportName;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            //Set title report
            XRLabel subTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text = String.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromAPPurchaseOrderDate.DateTime.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToAPPurchaseOrderDate.DateTime.ToString("dd/MM/yyyy"));
            }
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPurchaseOrderReportPath, true);
            reviewer.Show();
        }
    }
}
