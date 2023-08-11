using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP036 : ReportForm
    {
        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the list of selected employees
        /// </summary>
        private List<HREmployeesInfo> SelectedEmployeeList = new List<HREmployeesInfo>();

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ARSaleOrderItemsInfo> ReportDataSource;

        public RP036()
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

        private void RP036_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
            //InitDataSource();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source for report
        /// </summary>
        public void InitDataSource()
        {
            int locationID = LocationID;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            if (branchID > 0)
            {
                locationID = 0;
                fld_lblSubTitle.Text = fld_lkeBRBranchID.Text;
            }
            else
                fld_lblSubTitle.Text = fld_bedGELocationName.Text;


            DateTime formDate = DateTime.Now;
            DateTime.TryParse(fld_dteSearchFromDate.EditValue.ToString(), out formDate);

            DateTime toDate = DateTime.Now;
            DateTime.TryParse(fld_dteSearchToDate.EditValue.ToString(), out toDate);
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, formDate.ToString("dd/MM/yyyy"),
                                                                                    ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy")); ;
            ADReportsController objReportsController = new ADReportsController();
            List<ARSaleOrderItemsInfo> saleOrderItemList = new List<ARSaleOrderItemsInfo>();

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches == null)
                selectedBranches = new List<BRBranchsInfo>();

            List<ARSaleOrderItemsInfo> result;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    //List<ARSaleOrderItemsInfo> result = objReportsController.GetSaleOrderItemList(
                    //                                                                    locationID,
                    //                                                                    branchID,
                    //                                                                    customerID,
                    //                                                                    productID,
                    //                                                                    dateFrom,
                    //                                                                    dateTo,
                    //                                                                    objEmployeesInfo.HREmployeeID);
                    //saleOrderItemList = saleOrderItemList.Concat(result).ToList();

                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        result = objReportsController.GetSaleOrderItemList(
                                                                                null,
                                                                                branch.BRBranchID,
                                                                                objectID,
                                                                                objectType,
                                                                                productID,
                                                                                dateFrom,
                                                                                dateTo,
                                                                                objEmployeesInfo.HREmployeeID);
                        saleOrderItemList = saleOrderItemList.Concat(result).ToList();
                    }
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                }
            }
            else
            {
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                //saleOrderItemList = objReportsController.GetSaleOrderItemList(
                //                                                            locationID,
                //                                                            branchID,
                //                                                            customerID,
                //                                                            productID,
                //                                                            dateFrom,
                //                                                            dateTo,
                //                                                            null);

                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    result = objReportsController.GetSaleOrderItemList(
                                                                            null,
                                                                            branch.BRBranchID,
                                                                            objectID,
                                                                            objectType,
                                                                            productID,
                                                                            dateFrom,
                                                                            dateTo,
                                                                            null);
                    saleOrderItemList = saleOrderItemList.Concat(result).ToList();
                }
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }
            if (fld_cmbViewType.SelectedIndex == 1)
            {
                saleOrderItemList = saleOrderItemList.Where(i => i.ARSaleOrderItemProductQty > i.ARSaleOrderItemShippedQty + i.ARSaleOrderItemCanceledQty).ToList();
            }

            List<int> saleOrderIDList = new List<int>();
            int rowNumber = 0;
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in saleOrderItemList)
            {
                bool isExistSaleOrderID = saleOrderIDList.Exists(e => e == objSaleOrderItemsInfo.FK_ARSaleOrderID);
                if (!isExistSaleOrderID)
                {
                    rowNumber += 1;
                    objSaleOrderItemsInfo.ARSaleOrderRowNumber = rowNumber.ToString("00");
                    saleOrderIDList.Add(objSaleOrderItemsInfo.FK_ARSaleOrderID);
                }
                else
                {
                    objSaleOrderItemsInfo.ARSaleOrderNo = string.Empty;
                    objSaleOrderItemsInfo.ARSellerName = string.Empty;
                    objSaleOrderItemsInfo.ARCustomerName = string.Empty;
                    objSaleOrderItemsInfo.FK_ACObjectID = 0;
                    objSaleOrderItemsInfo.ARObjectType = string.Empty;
                    objSaleOrderItemsInfo.ARSaleOrderTotalAmount = 0;
                    objSaleOrderItemsInfo.ARSaleOrderDepositBalance = 0;
                    objSaleOrderItemsInfo.ARSaleOrderBalanceDue = 0;
                    objSaleOrderItemsInfo.ARSaleOrderDeliveryDate = DateTime.MaxValue;
                }
            }

            fld_dgcARRP036ARSaleOrderItems.DataSource = saleOrderItemList;
            ReportDataSource = saleOrderItemList;
            if (saleOrderItemList.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP036 rp = new BOSReport.RP036();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevRP036Path);
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
            XRLabel title = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
            {
                if (branchID > 0)
                    title.Text += string.Format(" {0}", fld_lkeBRBranchID.Text);
                else
                    title.Text += string.Format(" {0}", fld_bedGELocationName.Text);
            }
            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP036Path, true);
            reviewer.Show();
        }

        private void fld_bedEmployees_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            guiSearchEmployee guiSearchEmployee = new guiSearchEmployee(SelectedEmployeeList);
            guiSearchEmployee.Module = Module;
            if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
            {
                fld_bedEmployees.Text = string.Empty;
                foreach (HREmployeesInfo objEmployeesInfo in guiSearchEmployee.SelectedEmployeeList)
                {
                    fld_bedEmployees.Text += string.Format(" {0};", objEmployeesInfo.HREmployeeName);
                }
                SelectedEmployeeList = guiSearchEmployee.SelectedEmployeeList;
            }
        }
    }
}
