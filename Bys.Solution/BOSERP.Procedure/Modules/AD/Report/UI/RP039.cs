using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP039 : ReportForm
    {
        private int productGroupID;

        #region Public Properties
        List<ADConfigValuesInfo> ReceiptTypesList;
        List<ADConfigValuesInfo> ShipmentTypesList;
        #endregion

        #region Constructor
        public RP039()
        {
            InitializeComponent();
            CenterToScreen();
            ReceiptTypesList = new List<ADConfigValuesInfo>();
            ShipmentTypesList = new List<ADConfigValuesInfo>();
        }
        #endregion

        #region Override methods
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
        #endregion

        #region Events
        private void RP039_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = DateTime.Now;
            fld_dteSearchToDate.EditValue = DateTime.Now;

            //ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            //DataSet dsReceiptType = (DataSet)objConfigValuesController.GetADConfigValuesByGroup("ReceiptType");

            //ReceiptTypesList = (List<ADConfigValuesInfo>)objConfigValuesController.GetListFromDataSet(dsReceiptType);

            //dsReceiptType = (DataSet)objConfigValuesController.GetADConfigValuesByGroup("ReceiptTypeExtension");
            //ReceiptTypesList.AddRange((List<ADConfigValuesInfo>)objConfigValuesController.GetListFromDataSet(dsReceiptType));

            //fld_cmbICReceiptType.Properties.DataSource = ReceiptTypesList;
            //fld_cmbICReceiptType.Properties.DisplayMember = "ADConfigText";
            //fld_cmbICReceiptType.Properties.ValueMember = "ADConfigKeyValue";


            //DataSet dsShipmentType = (DataSet)objConfigValuesController.GetADConfigValuesByGroup("ShipmentType");
            //ShipmentTypesList = (List<ADConfigValuesInfo>)objConfigValuesController.GetListFromDataSet(dsShipmentType);

            //dsShipmentType = (DataSet)objConfigValuesController.GetADConfigValuesByGroup("ShipmentTypeExtension");
            //ShipmentTypesList.AddRange((List<ADConfigValuesInfo>)objConfigValuesController.GetListFromDataSet(dsShipmentType));
            ////ShipmentTypesList.Add(new ADConfigValuesInfo() { ADConfigText = "Hóa đơn kiêm phiếu xuất", ADConfigKeyValue = "InvoiceAndShipment" }); 
            ////ShipmentTypesList.Add(new ADConfigValuesInfo() { ADConfigText = "Xuất chuyển kho", ADConfigKeyValue = "Transfer" });
            ////ShipmentTypesList.Add(new ADConfigValuesInfo() { ADConfigText = "Chuyển mã", ADConfigKeyValue = "ProductConversion" });

            //fld_cmbICShipmentType.Properties.DataSource = ShipmentTypesList;
            //fld_cmbICShipmentType.Properties.DisplayMember = "ADConfigText";
            //fld_cmbICShipmentType.Properties.ValueMember = "ADConfigKeyValue";


            //[TTLoi][Init Stock][09/12/2014] BEGIN
            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stocks = objStocksController.GetStocksByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            stocks.Insert(0, new ICStocksInfo());
            fld_cmbStocks.Properties.DataSource = stocks;
            //[TTLoi][Init Stock][09/12/2014] END

            InitDataSource();
            //dsReceiptType.Dispose();
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
            BOSReport.RP039 rp = new BOSReport.RP039();
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
            XRLabel employeeNameLabel = (XRLabel)rp.Bands[BandKind.ReportFooter].Controls["xr_lblEmployeeName"];
            HREmployeesController objEmployessController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployessController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                employeeNameLabel.Text = objEmployeesInfo.HREmployeeName;
            }

            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            //int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            string stockNos = GetStockNos();

            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            string productGroupName = fld_txtICProductGroupName.Text;

            ADReportsController objReportsController = new ADReportsController();

            // Get list Shipment Type
            //string[] shipmentTypes = fld_cmbICShipmentType.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //if(shipmentTypes is null || shipmentTypes.Count() == 0)
            //{
            //    shipmentTypes = ShipmentTypesList.Select(o => o.ADConfigKeyValue).ToArray();
            //}    
            //string shipmentType = string.Join(",", shipmentTypes);

            //// Get list Receipt Type
            //string[] receiptTypes = fld_cmbICReceiptType.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //if (receiptTypes is null || receiptTypes.Count() == 0)
            //{
            //    receiptTypes = ReceiptTypesList.Select(o => o.ADConfigKeyValue).ToArray();
            //}
            //string receiptType = string.Join(",", receiptTypes);

            List<ICReceiptItemsInfo> receiptItemList = objReportsController.GetDataForReport039(
                                                                                             dateFrom,
                                                                                             dateTo,
                                                                                             branchID,
                                                                                             stockNos,
                                                                                             productID,
                                                                                             departmentID,
                                                                                             productGroupName,
                                                                                             //shipmentType,
                                                                                             //receiptType,
                                                                                             bosCheckEdit2.Checked,
                                                                                             bosCheckEdit1.Checked,
                                                                                             productGroupID);

            rp.DataSource = receiptItemList;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP039Path, true);
            reviewer.Show();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Init data source for report
        /// </summary>
        public void InitDataSource()
        {
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                          ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            ADReportsController objReportsController = new ADReportsController();
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string stockNos = GetStockNos();
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            string productGroupName = fld_txtICProductGroupName.Text;

            //// Get list Shipment Type
            //string[] shipmentTypes = fld_cmbICShipmentType.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //if (shipmentTypes is null || shipmentTypes.Count() == 0)
            //{
            //    shipmentTypes = ShipmentTypesList.Select(o => o.ADConfigKeyValue).ToArray();
            //}
            //string shipmentType = string.Join(",", shipmentTypes);

            //// Get list Receipt Type
            //string[] receiptTypes = fld_cmbICReceiptType.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //if (receiptTypes is null || receiptTypes.Count() == 0)
            //{
            //    receiptTypes = ReceiptTypesList.Select(o => o.ADConfigKeyValue).ToArray();
            //}
            //string receiptType = string.Join(",", receiptTypes);


            List<ICReceiptItemsInfo> receiptItemList = objReportsController.GetDataForReport039(
                                                                                             dateFrom,
                                                                                             dateTo,
                                                                                             branchID,
                                                                                             stockNos,
                                                                                             productID,
                                                                                             departmentID,
                                                                                             productGroupName,
                                                                                             //shipmentType,
                                                                                             //receiptType,
                                                                                             bosCheckEdit2.Checked,
                                                                                             bosCheckEdit1.Checked,
                                                                                             productGroupID);


            fld_dgcICRP039RecieptShipmentTransferItems.DataSource = receiptItemList;
            if (receiptItemList.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        /// <summary>
        /// Get stock list
        /// </summary>        
        /// <returns>List of stocks</returns>
        public string GetStockNos()
        {
            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stockList = new List<ICStocksInfo>();
            string[] stockIDs = fld_cmbStocks.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (stockIDs.Length > 0)
            {
                for (int i = 0; i < stockIDs.Length; i++)
                {
                    int stockID = Convert.ToInt32(stockIDs[i]);
                    ICStocksInfo stock = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
                    if (stock != null)
                    {
                        stockList.Add(stock);
                    }
                }
            }

            if (stockList.Count == 0)
            {
                ADReportsController objReportsController = new ADReportsController();
                DataSet ds = new DataSet();
                int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                if (branchID > 0)
                {
                    ds = objStocksController.GetAllDataByForeignColumn("FK_BRBranchID", branchID);
                }
                else
                {
                    ds = objStocksController.GetAllObjects();
                }
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
                        stockList.Add(objStocksInfo);
                    }
                }
            }

            ICInventoryPermissionsController objInventoryPermissionsController = new ICInventoryPermissionsController();
            List<ICInventoryPermissionsInfo> invPermissions = objInventoryPermissionsController.GetInventoryPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            for (int i = 0; i < stockList.Count; i++)
            {
                ICInventoryPermissionsInfo objInventoryPermissionsInfo = invPermissions.Where(ip => ip.FK_ICStockID == stockList[i].ICStockID).FirstOrDefault();
                if (objInventoryPermissionsInfo != null && objInventoryPermissionsInfo.ICInventoryPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                {
                    stockList.RemoveAt(i);
                    i--;
                }
            }

            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
            foreach (ICStocksInfo stock in stockList)
            {
                BRBranchsInfo branch = (BRBranchsInfo)branches.Where(b => b.BRBranchID == stock.FK_BRBranchID).FirstOrDefault();
                if (branch != null)
                {
                    stock.BRBranchParentID = branch.BRBranchParentID;
                }
            }

            string stockNos = string.Join(",", stockList.Select(o => o.ICStockNo).ToArray());

            return stockNos;
        }

        #endregion

        private void bosCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            fld_cmbICReceiptType.Enabled = bosCheckEdit1.Checked;
            //bosLookupEdit1.Enabled = bosCheckEdit1.Checked;
        }

        private void bosCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            fld_cmbICShipmentType.Enabled = bosCheckEdit2.Checked;
            //bosLookupEdit2.Enabled = bosCheckEdit2.Checked;
        }
        //TNDLoc [ADD][10/06/2015][Issue filter ProductGroup],START
        private void fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowCategoryTree();
        }
        public void ShowCategoryTree()
        {
            int departmentID = 0;
            departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedICProductGroupID.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.AllowMultipleSelect = false;
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = departmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    fld_bedICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    productGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    fld_bedICProductGroupID.Text = String.Empty;
                    productGroupID = 0;
                }
            }
        }
        //TNDLoc [ADD][10/06/2015][Issue filter ProductGroup],END

        ////TNDLoc [ADD][05/10/2015][Issue filter by Locations],START
        //private List<GELocationsInfo> SelectedLocations = new List<GELocationsInfo>();

        //private void fld_bedGELocationName_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{

        //    guiChooseLocation locationForm;

        //    if (SelectedLocations != null && SelectedLocations.Count > 0)
        //    {
        //        locationForm = new guiChooseLocation(SelectedLocations, true);
        //    }
        //    else
        //    {
        //        locationForm = new guiChooseLocation(true);
        //    }
        //    locationForm.Module = this.Module;
        //    if (locationForm.ShowDialog() == DialogResult.OK)
        //    {
        //        SelectedLocations.Clear();
        //        fld_bedGELocationName.Text = string.Empty;
        //        GELocationsController objLocationsController = new GELocationsController();
        //        List<BOSTreeListObject> treeList = new List<BOSTreeListObject>();
        //        locationForm.LocationTreeList.GetSelectedObjects(treeList);
        //        if (treeList != null && treeList.Count > 0)
        //        {
        //            foreach (BOSTreeListObject obj in treeList)
        //            {
        //                GELocationsInfo location = (GELocationsInfo)obj;
        //                if (location != null)
        //                {
        //                    SelectedLocations.Add((GELocationsInfo)obj);
        //                    if (!string.IsNullOrEmpty(fld_bedGELocationName.Text))
        //                        fld_bedGELocationName.Text += "; ";
        //                    fld_bedGELocationName.Text += location.GELocationName;
        //                }
        //            }
        //        }

        //    }
        //}
        ////TNDLoc [ADD][05/10/2015][Issue filter by Locations],END
    }
}
