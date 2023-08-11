using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP088 : ReportForm
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
        private List<ARInvoiceItemsInfo> ReportDataSource = new List<ARInvoiceItemsInfo>();

        public RP088()
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
            List<ARInvoiceItemsInfo> invoiceItemList = new List<ARInvoiceItemsInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches == null)
                selectedBranches = new List<BRBranchsInfo>();
            List<ARInvoiceItemsInfo> result;
            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    //result = objReportsController.GetInvoiceItemsList1(
                    //                                                                        locationID,
                    //                                                                        branchID,
                    //                                                                        customerID,
                    //                                                                        productID,
                    //                                                                        dateFrom,
                    //                                                                        dateTo,
                    //                                                                        invoiceType,
                    //                                                                        objEmployeesInfo.HREmployeeID);
                    //invoiceItemList = invoiceItemList.Concat(result).ToList();
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        result = objReportsController.GetInvoiceItemsList1(
                                                                            null,
                                                                            branch.BRBranchID,
                                                                            customerID,
                                                                            productID,
                                                                            "Customer",
                                                                            dateFrom,
                                                                            dateTo,
                                                                            invoiceType,
                                                                            objEmployeesInfo.HREmployeeID);
                        invoiceItemList = invoiceItemList.Concat(result).ToList();
                    }
                }
            }
            else
            {
                //invoiceItemList = objReportsController.GetInvoiceItemsList1(
                //                                                        locationID,
                //                                                        branchID,
                //                                                        customerID,
                //                                                        productID,
                //                                                        dateFrom,
                //                                                        dateTo,
                //                                                        invoiceType,
                //                                                        null);
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    result = objReportsController.GetInvoiceItemsList1(
                                                                        null,
                                                                        branch.BRBranchID,
                                                                        customerID,
                                                                        productID,
                                                                        "Customer",
                                                                        dateFrom,
                                                                        dateTo,
                                                                        invoiceType,
                                                                        null);
                    invoiceItemList = invoiceItemList.Concat(result).ToList();
                }

            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            fld_dgcARRP088ARInvoiceItems.DataSource = invoiceItemList;
            ReportDataSource = invoiceItemList;
            if (invoiceItemList.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP037 rp = new BOSReport.RP037();
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
    }
}
