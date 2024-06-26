﻿using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP037 : ReportForm
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

        public RP037()
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
            string invoiceType = Convert.ToString(fld_lkeARInvoiceTypeCombo.EditValue);
            string invoiceStatus = Convert.ToString(fld_lkeARInvoiceStatus.EditValue);
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
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches == null)
                selectedBranches = new List<BRBranchsInfo>();
            List<ARInvoiceItemsInfo> result;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        result = objReportsController.GetInvoiceItemsList(null,
                                                                          branch.BRBranchID,
                                                                          objectID,
                                                                          objectType,
                                                                          productID,
                                                                          dateFrom,
                                                                          dateTo,
                                                                          invoiceType,
                                                                          objEmployeesInfo.HREmployeeID,
                                                                          invoiceStatus);
                        invoiceItemList = invoiceItemList.Concat(result).ToList();
                    }
                }
            }
            else
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    result = objReportsController.GetInvoiceItemsList(null,
                                                                      branch.BRBranchID,
                                                                      objectID,
                                                                      objectType,
                                                                      productID,
                                                                      dateFrom,
                                                                      dateTo,
                                                                      invoiceType,
                                                                      null,
                                                                      invoiceStatus);
                    invoiceItemList = invoiceItemList.Concat(result).ToList();
                }
            }
            fld_dgcARRP037ARInvoiceItems.DataSource = invoiceItemList;
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

        private void fld_btnExportExcelXls_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;
                    fld_dgcARRP037ARInvoiceItems.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
