using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP025 : ReportForm
    {
        /// <summary>
        /// A variable to store the list of selected employees
        /// </summary>
        private List<HREmployeesInfo> SelectedEmployeeList = new List<HREmployeesInfo>();

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ARSaleOrdersInfo> ReportDataSource;

        public RP025()
        {
            InitializeComponent();

            SelectedEmployeeList = new List<HREmployeesInfo>();
        }

        private void RP025_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARSaleOrderDate.EditValue = DateTime.Now;
            fld_dteSearchToARSaleOrderDate.EditValue = DateTime.Now;
            fld_lblBRBranchName.Text = string.Empty;
            //ShowReportData();
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
        /// Show report's data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            int sellerID = Convert.ToInt32(fld_lkeFK_ARSellerID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime fromDate = fld_dteSearchFromARSaleOrderDate.DateTime;
            DateTime toDate = fld_dteSearchToARSaleOrderDate.DateTime;
            List<ARSaleOrdersInfo> saleOrderList = new List<ARSaleOrdersInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (SelectedEmployeeList.Count > 0)
            //{
            //    foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
            //    {
            //        List<ARSaleOrdersInfo> result = objReportsController.GetSaleOrderBySomeCriteria(sellerID, branchID, customerID, fromDate, toDate, objEmployeesInfo.HREmployeeID);
            //        saleOrderList = saleOrderList.Concat(result).ToList();
            //    }
            //}
            //else
            //{
            //    saleOrderList = objReportsController.GetSaleOrderBySomeCriteria(sellerID, branchID, customerID, fromDate, toDate, null);
            //}

            List<ARSaleOrdersInfo> result;

            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    if (branchID == 0)
                    {
                        foreach (BRBranchsInfo branch in BranchList)
                        {
                            result = objReportsController.GetSaleOrderBySomeCriteria(sellerID, branch.BRBranchID, objectID, objectType, fromDate, toDate, objEmployeesInfo.HREmployeeID);
                            saleOrderList = saleOrderList.Concat(result).ToList();
                        }
                    }
                    else
                    {
                        result = objReportsController.GetSaleOrderBySomeCriteria(sellerID, branchID, objectID, objectType, fromDate, toDate, objEmployeesInfo.HREmployeeID);
                        saleOrderList = saleOrderList.Concat(result).ToList();
                    }
                }
            }
            else
            {
                if (branchID == 0)
                {
                    foreach (BRBranchsInfo branch in BranchList)
                    {
                        result = objReportsController.GetSaleOrderBySomeCriteria(sellerID, branch.BRBranchID, objectID, objectType, fromDate, toDate, null);
                        saleOrderList = saleOrderList.Concat(result).ToList();
                    }
                }
                else
                    saleOrderList = objReportsController.GetSaleOrderBySomeCriteria(sellerID, branchID, objectID, objectType, fromDate, toDate, null);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcARRP025ARSaleOrders.DataSource = saleOrderList;
            ReportDataSource = saleOrderList;
            if (saleOrderList.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
            fld_lblBRBranchName.Text = fld_lkeBRBranchID.Text;
            lbl_FromdateTodate.Text = string.Format("{0} {1} {2} {3}",
                                                                ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARSaleOrderDate.Text,
                                                                ReportLocalizedResources.ToDateTitle, fld_dteSearchToARSaleOrderDate.Text);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 3));
            return lstHeaderParameter;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP025 rp = new BOSReport.RP025();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevSaleOrderReportPath);            
            rp.DataSource = ReportDataSource;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchName = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchName"];
            if (branchName != null)
                branchName.Text += string.Format(" {0}", fld_lkeBRBranchID.Text);
            XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            XRLabel dateTime = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}",
                                                                ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARSaleOrderDate.Text,
                                                                ReportLocalizedResources.ToDateTitle, fld_dteSearchToARSaleOrderDate.Text);
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevSaleOrderReportPath, true);
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
