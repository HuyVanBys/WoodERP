using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP087 : ReportForm
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
        /// A variable to store the report data soruce
        /// </summary>
        private List<ICProductsInfo> ReportDataSource = new List<ICProductsInfo>();

        private int ICProductGroupID = 0;

        public RP087()
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

        private void RP037_Load(object sender, EventArgs e)
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
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            //int productGroupID = Convert.ToInt32(fld_bedFK_ICProductGroupID.EditValue == null ? "0" : fld_bedFK_ICProductGroupID.EditValue);
            int productGroupID = ICProductGroupID;
            int productDepartmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            string invoiceType = Convert.ToString(fld_lkeARInvoiceTypeCombo.EditValue);
            if (branchID > 0)
            {
                locationID = 0;
                fld_lblSubTitle.Text = fld_lkeBRBranchID.Text;
            }
            else
                fld_lblSubTitle.Text = fld_bedGELocationName.Text;
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            ADReportsController objReportsController = new ADReportsController();
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            string branchNoList = GetSelectedBranchNosByLocationIDAndBranchID(locationID, branchID);

            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    List<ICProductsInfo> result = objReportsController.GetProductUnitCostListByBranchList(
                                                                                        null,
                                                                                        branchNoList,
                                                                                        customerID,
                                                                                        productID,
                                                                                        dateFrom,
                                                                                        dateTo,
                                                                                        invoiceType,
                                                                                        objEmployeesInfo.HREmployeeID,
                                                                                        productGroupID,
                                                                                        productDepartmentID,
                                                                                        supplierID);
                    productList = productList.Concat(result).ToList();
                }
            }
            else
            {
                productList = objReportsController.GetProductUnitCostListByBranchList(
                                                                    null,
                                                                    branchNoList,
                                                                    customerID,
                                                                    productID,
                                                                    dateFrom,
                                                                    dateTo,
                                                                    invoiceType,
                                                                    null,
                                                                    productGroupID,
                                                                    productDepartmentID,
                                                                    supplierID);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcARRP087ARInvoiceItems.DataSource = productList;
            ReportDataSource = productList;
            if (productList.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP087I rp = new BOSReport.RP087I();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevRP037Path);
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

            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            XRLabel title = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
            {
                if (branchID > 0)
                    title.Text += string.Format(" {0}", fld_lkeBRBranchID.Text);
                else
                    title.Text += string.Format(" {0}", fld_bedGELocationName.Text);
            }
            XRLabel dateTime = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                             ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> lstMeasureUnits = objMeasureUnitsController.GetAllAliveMeasureUnit();
            ReportDataSource.ForEach(o =>
            {
                if (lstMeasureUnits.Exists(x => x.ICMeasureUnitID == o.FK_ICProductBasicUnitID))
                    o.ICMeasureUnitName = lstMeasureUnits.Where(x => x.ICMeasureUnitID == o.FK_ICProductBasicUnitID).FirstOrDefault().ICMeasureUnitName;
            });

            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP037Path, true);
            reviewer.Show();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
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
                    ICProductGroupID = objProductGroupInfo.ICProductGroupID;
                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    ICProductGroupID = 0;
                    fld_bedFK_ICProductGroupID.Text = String.Empty;
                }
            }
        }
    }
}
