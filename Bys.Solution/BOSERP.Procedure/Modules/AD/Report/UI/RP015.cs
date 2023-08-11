using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP015 : ReportForm
    {
        public RP015()
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

        private void RP015_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ShowReportData();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 4));
            return lstHeaderParameter;
        }
        #endregion

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        /// <summary>
        /// Show report's data based on some the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            //Set title report
            fld_lblSubTitleDate.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));
            string supplierType = string.Empty;
            int productID = Convert.ToInt32(fld_lkeFK_ICProductID.EditValue);
            if (fld_lkeAPSupplierTypeCombo.EditValue != null)
                supplierType = fld_lkeAPSupplierTypeCombo.EditValue.ToString();
            //TNDLoc [ADD] [10/16/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/16/2014] [DB centre] [Report Permission], END

            //TNDLoc [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            DataSet ds = objReportsController.GetSupplierListByBranchList(supplierType, productID, branchNos);
            //TNDLoc [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcAPRP015Suppliers.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP015 rp = new BOSReport.RP015();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevSupplierReportPath);
            ADReportsController objReportsController = new ADReportsController();
            string supplierType = string.Empty;
            int productID = Convert.ToInt32(fld_lkeFK_ICProductID.EditValue);
            if (fld_lkeAPSupplierTypeCombo.EditValue != null)
                supplierType = fld_lkeAPSupplierTypeCombo.EditValue.ToString();
            //TNDLoc [ADD] [10/16/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/16/2014] [DB centre] [Report Permission], END

            //TNDLoc [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            DataSet ds = objReportsController.GetSupplierListByBranchList(supplierType, productID, branchNos);
            //TNDLoc [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            rp.DataSource = ds;
            rp.DataMember = BOSCommon.Constants.Report.DevSupplierReportName;
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
            //Set title report
            XRLabel SubTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (SubTitle != null)
                SubTitle.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevSupplierReportPath, true);
            reviewer.Show();
        }
    }
}