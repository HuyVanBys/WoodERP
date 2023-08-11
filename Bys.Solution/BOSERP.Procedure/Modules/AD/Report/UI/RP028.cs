using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP028 : ReportForm
    {
        /// <summary>
        /// The selected product group id
        /// </summary>
        private int ProductGroupID = 0;
        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<APPurchaseOrderItemsInfo> ReportDataSource;

        public RP028()
        {
            InitializeComponent();
            fld_dteSearchFromAPPurchaseOrderItemDeliveryDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToAPPurchaseOrderItemDeliveryDate.DateTime = BOSUtil.GetMonthEndDate();
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

        private void RP028_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ShowReportData();
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
            int locationID = LocationID;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            DateTime dateFrom = fld_dteSearchFromAPPurchaseOrderItemDeliveryDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPPurchaseOrderItemDeliveryDate.DateTime;

            //Set title report
            if (branchID > 0)
            {
                locationID = 0;
                fld_lblSubTitle.Text = fld_lkeBRBranchID.Text;
            }
            else
            {
                fld_lblSubTitle.Text = fld_bedGELocationName.Text;
            }

            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDeliveryDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));

            List<APPurchaseOrderItemsInfo> purchaseOrderItems = GetPurchaseOrderItems();
            ReportDataSource = purchaseOrderItems;
            fld_dgcRP028APPurchaseOrderItems.DataSource = purchaseOrderItems;
            if (purchaseOrderItems.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        /// <summary>
        /// Get purchase order items for the report data source
        /// </summary>
        /// <returns>List of items</returns>
        private List<APPurchaseOrderItemsInfo> GetPurchaseOrderItems()
        {
            int locationID = LocationID;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            string purchaseOrderStatus = Convert.ToString(fld_lkeAPPurchaseOrderStatus.EditValue);
            DateTime dateFrom = fld_dteSearchFromAPPurchaseOrderItemDeliveryDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPPurchaseOrderItemDeliveryDate.DateTime;

            ADReportsController objReportsController = new ADReportsController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objReportsController.GetPurchaseOrderItemsBySomeCriteria(locationID,
            //                                                                        branchID,
            //                                                                        departmentID,
            //                                                                        ProductGroupID,
            //                                                                        supplierID,
            //                                                                        purchaseOrderStatus,
            //                                                                        dateFrom,
            //                                                                        dateTo);

            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);

            List<APPurchaseOrderItemsInfo> purchaseOrderItemList = new List<APPurchaseOrderItemsInfo>();
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<APPurchaseOrderItemsInfo> result = objReportsController.GetPurchaseOrderItemsBySomeCriteria(
                                                                                    null,
                                                                                    branch.BRBranchID,
                                                                                    departmentID,
                                                                                    ProductGroupID,
                                                                                    objectID,
                                                                                    objectType,
                                                                                    purchaseOrderStatus,
                                                                                    dateFrom,
                                                                                    dateTo);
                    purchaseOrderItemList.AddRange(result);
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            purchaseOrderItemList.ForEach(i => i.APPurchaseOrderItemUnitVolumn = i.APPurchaseOrderItemUnitVolumn * i.APPurchaseOrderItemProductQty);
            foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrderItemList)
            {
                if (objPurchaseOrderItemsInfo.APPurchaseOrderPackingDate.Year == DateTime.MaxValue.Year)
                {
                    objPurchaseOrderItemsInfo.APPurchaseOrderPackingDate = DateTime.MaxValue;
                }
            }

            if (fld_cmbViewOptions.SelectedIndex == 1)
            {
                purchaseOrderItemList = purchaseOrderItemList.Where(poi => poi.APPurchaseOrderItemPackagedQty < poi.APPurchaseOrderItemProductQty).ToList();
            }
            else if (fld_cmbViewOptions.SelectedIndex == 2)
            {
                purchaseOrderItemList = purchaseOrderItemList.Where(poi => poi.APPurchaseOrderItemReceiptedQty < poi.APPurchaseOrderItemPackagedQty).ToList();
            }

            List<int> purchaseOrderIDList = new List<int>();
            int rowNumber = 0;
            foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrderItemList)
            {
                bool isExistPurchaseOrderID = purchaseOrderIDList.Exists(e => e == objPurchaseOrderItemsInfo.FK_APPurchaseOrderID);
                if (!isExistPurchaseOrderID)
                {
                    rowNumber += 1;
                    if (!string.IsNullOrEmpty(objPurchaseOrderItemsInfo.APSupplierContactPhone2))
                    {
                        objPurchaseOrderItemsInfo.APSupplierContactPhone1 += string.Format("{0} {1}", ";", objPurchaseOrderItemsInfo.APSupplierContactPhone2);
                    }
                    if (!purchaseOrderItemList.Exists(i => i.FK_APPurchaseOrderID == objPurchaseOrderItemsInfo.FK_APPurchaseOrderID && i.APPurchaseOrderItemUnitVolumn > 0))
                    {
                        objPurchaseOrderItemsInfo.APPurchaseOrderItemUnitVolumn = objPurchaseOrderItemsInfo.APPurchaseOrderVolume;
                    }
                    objPurchaseOrderItemsInfo.APPurchaseOrderRowNumber = rowNumber.ToString("00");
                    purchaseOrderIDList.Add(objPurchaseOrderItemsInfo.FK_APPurchaseOrderID);
                }
                else
                {
                    objPurchaseOrderItemsInfo.APPurchaseOrderNo = string.Empty;
                    objPurchaseOrderItemsInfo.APPurchaseOrderComment = string.Empty;
                    objPurchaseOrderItemsInfo.APPurchaseOrderTypeDisplayText = string.Empty;
                    objPurchaseOrderItemsInfo.APPurchaseOrderStatusDisplayText = string.Empty;
                    objPurchaseOrderItemsInfo.APSupplierContactPhone1 = string.Empty;
                    objPurchaseOrderItemsInfo.APSupplierName = string.Empty;
                    objPurchaseOrderItemsInfo.ACObjectName = string.Empty;
                    objPurchaseOrderItemsInfo.APPurchaseOrderTotalCost = 0;
                    objPurchaseOrderItemsInfo.APPurchaseOrderDepositBalance = 0;
                    objPurchaseOrderItemsInfo.APPurchaseOrderBalanceDue = 0;
                    objPurchaseOrderItemsInfo.APPurchaseOrderDate = DateTime.MaxValue;
                    objPurchaseOrderItemsInfo.APPurchaseOrderDeliveryDate = DateTime.MaxValue;
                    objPurchaseOrderItemsInfo.APPurchaseOrderPackingDate = DateTime.MaxValue;
                    objPurchaseOrderItemsInfo.APSupplierContactPhone1 = string.Empty;
                }
            }
            return purchaseOrderItemList;
        }

        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 3));
            return lstHeaderParameter;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP028 rp = new BOSReport.RP028();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevPurchaseOrderItemReportPath);                     
            XRLabel title = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
            {
                title.Text = string.Format("{0} {1}", fld_lblTitle.Text, fld_lblSubTitle.Text);
            }
            XRLabel subTitle = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text = fld_lblSubTitleDate.Text;
            }

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

            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevPurchaseOrderItemReportPath, true);
            reviewer.Show();
        }

        private void fld_bteICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bteICProductGroupID.EditValue));
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, productGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupInfo != null)
                {
                    ProductGroupID = objProductGroupInfo.ICProductGroupID;
                    fld_bteICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_lkeICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    ProductGroupID = 0;
                    fld_bteICProductGroupID.Text = String.Empty;
                }
            }
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            guiChooseLocation locationForm = new guiChooseLocation(LocationID);
            locationForm.Module = Module;
            if (locationForm.ShowDialog() == DialogResult.OK)
            {
                GELocationsController objLocationsController = new GELocationsController();
                GELocationsInfo objLocationsInfo = (GELocationsInfo)locationForm.LocationTreeList.GetSelectedObject();
                if (objLocationsInfo != null && objLocationsInfo.Selected)
                {
                    LocationID = objLocationsInfo.GELocationID;
                    fld_bedGELocationName.EditValue = objLocationsController.GetFullLocationNameByID(objLocationsInfo.GELocationID);
                }
                else
                {
                    LocationID = 0;
                    fld_bedGELocationName.EditValue = string.Empty;
                }
            }
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcRP028APPurchaseOrderItems.MainView;
            ExportToXls(gridView);
        }
    }
}
