using BOSCommon;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP035 : ReportForm
    {
        /// <summary>
        /// ID of product group
        /// </summary>
        private int ProductGroupID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ICReceiptItemsInfo> ReportDataSource;

        public RP035()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ProductGroupID;
            //int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            string receiptStatus = Convert.ToString(fld_lkeICReceiptStatus.EditValue);
            string packNo = fld_txtICReceiptPackNo.Text;
            DateTime receiptDateFrom = fld_dteSearchFromICReceiptDate.DateTime;
            DateTime receiptDateTo = fld_dteSearchToICReceiptDate.DateTime;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            //Set title report
            fld_lblSubTitleDate.Text = String.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, receiptDateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, receiptDateTo.ToString("dd/MM/yyyy"));
            ADReportsController objReportsController = new ADReportsController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICReceiptItemsInfo> receiptList = objReportsController.GetReceiptItemListBySomeCriteria(
            //                                                                    departmentID, 
            //                                                                    productGroupID, 
            //                                                                    supplierID, 
            //                                                                    stockID,
            //                                                                    ReceiptType.PurchaseReceipt.ToString(), 
            //                                                                    receiptStatus,
            //                                                                    packNo, 
            //                                                                    receiptDateFrom, 
            //                                                                    receiptDateTo);

            List<ICReceiptItemsInfo> receiptList = objReportsController.GetReceiptItemListByBranchNoListAndSomeCriteria(
                                                                                departmentID,
                                                                                productGroupID,
                                                                                objectID,
                                                                                objectType,
                                                                                stockID,
                                                                                ReceiptType.PurchaseReceipt.ToString(),
                                                                                receiptStatus,
                                                                                packNo,
                                                                                receiptDateFrom,
                                                                                receiptDateTo, branchNos);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            ReportDataSource = receiptList;
            fld_dgcRP035ICReceiptItems.DataSource = receiptList;
            if (receiptList.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP035 rp = new BOSReport.RP035();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemsReportPath);
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
            XRLabel subTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text = fld_lblSubTitleDate.Text;
            }
            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevReceiptItemsReportPath, true);
            reviewer.Show();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedFK_ICProductGroupID.EditValue));
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, productGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupInfo != null)
                {
                    ProductGroupID = objProductGroupInfo.ICProductGroupID;
                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    ProductGroupID = 0;
                    fld_bedFK_ICProductGroupID.Text = String.Empty;
                }
            }
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

        private void RP035_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromICReceiptDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToICReceiptDate.EditValue = BOSUtil.GetMonthEndDate();

            ShowReportData();
        }
    }
}
