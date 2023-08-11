using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP040 : ReportForm
    {
        /// <summary>
        /// A variable to store the selected product group id
        /// </summary>
        private int ProductGroupID = 0;

        public RP040()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RP040_Load(object sender, EventArgs e)
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
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }

            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string invoiceStatus = Convert.ToString(fld_lkeAPInvoiceInStatus.EditValue);
            DateTime dateFrom = fld_dteSearchFromAPInvoiceInDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPInvoiceInDate.DateTime;
            //Set title report
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<APInvoiceInItemsInfo> invoiceInItemList;
            if (branchID == 0)
            {
                invoiceInItemList = new List<APInvoiceInItemsInfo>();
                foreach (BRBranchsInfo branch in BranchList)
                {
                    List<APInvoiceInItemsInfo> result = objReportsController.GetInvoiceInItemsBySomeCriteria(
                                                                                                        departmentID,
                                                                                                        ProductGroupID,
                                                                                                        objectID,
                                                                                                        objectType,
                                                                                                        productID,
                                                                                                        branch.BRBranchID,
                                                                                                        invoiceStatus,
                                                                                                        dateFrom,
                                                                                                        dateTo);
                    invoiceInItemList.AddRange(result);
                }
            }
            else
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                invoiceInItemList = objReportsController.GetInvoiceInItemsBySomeCriteria(
                                                                                                        departmentID,
                                                                                                        ProductGroupID,
                                                                                                        objectID,
                                                                                                        objectType,
                                                                                                        productID,
                                                                                                        branchID,
                                                                                                        invoiceStatus,
                                                                                                        dateFrom,
                                                                                                        dateTo);
            fld_dgcAPRP040APInvoiceInItems.DataSource = invoiceInItemList;
            if (invoiceInItemList.Count <= 0)
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
            BOSReport.RP040 rp = new BOSReport.RP040();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevRP040Path);
            ADReportsController objReportsController = new ADReportsController();
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }

            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string invoiceStatus = Convert.ToString(fld_lkeAPInvoiceInStatus.EditValue);
            DateTime dateFrom = fld_dteSearchFromAPInvoiceInDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPInvoiceInDate.DateTime;
            List<APInvoiceInItemsInfo> invoiceInItemList = objReportsController.GetInvoiceInItemsBySomeCriteria(
                                                                                                        departmentID,
                                                                                                        ProductGroupID,
                                                                                                        objectID,
                                                                                                        objectType,
                                                                                                        productID,
                                                                                                        branchID,
                                                                                                        invoiceStatus,
                                                                                                        dateFrom,
                                                                                                        dateTo);
            rp.DataSource = invoiceInItemList;

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
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP040Path, true);
            reviewer.Show();
        }

        private void fld_bedProductGroup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowCategoryTree();
        }

        /// <summary>
        /// Show treelist category
        /// </summary>
        public void ShowCategoryTree()
        {
            int iDepartmentID = 0;
            iDepartmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedProductGroup.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = iDepartmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {

                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    fld_bedProductGroup.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    fld_bedProductGroup.Text = String.Empty;
                    ProductGroupID = 0;
                }
            }
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcAPRP040APInvoiceInItems.MainView;
            ExportToXls(gridView);
        }
    }
}
