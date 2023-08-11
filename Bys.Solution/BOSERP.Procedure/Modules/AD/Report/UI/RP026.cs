using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP026 : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ARDocumentPaymentsInfo> ReportDataSource;

        /// <summary>
        /// A variable to store the list of selected employees
        /// </summary>
        private List<HREmployeesInfo> SelectedEmployeeList = new List<HREmployeesInfo>();

        public RP026()
        {
            InitializeComponent();

            SelectedEmployeeList = new List<HREmployeesInfo>();
        }

        private void RP026_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now;
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
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            string saleOrderNo = fld_txtARSaleOrderNo.Text;
            DateTime fromDate = fld_dteSearchFromARInvoiceDate.DateTime;
            DateTime toDate = fld_dteSearchToARInvoiceDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<ARDocumentPaymentsInfo> documentPayments = new List<ARDocumentPaymentsInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (SelectedEmployeeList.Count > 0)
            //{
            //    foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
            //    {
            //        List<ARDocumentPaymentsInfo> result = objReportsController.GetDepositList(saleOrderNo, customerID, branchID, fromDate, toDate, objEmployeesInfo.HREmployeeID);
            //        documentPayments = documentPayments.Concat(result).ToList();
            //    }
            //}
            //else
            //{
            //    documentPayments = objReportsController.GetDepositList(saleOrderNo, customerID, branchID, fromDate, toDate, null);
            //}

            List<ARDocumentPaymentsInfo> result;

            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    if (branchID == 0)
                    {
                        foreach (BRBranchsInfo branch in BranchList)
                        {
                            result = objReportsController.GetDepositList(saleOrderNo, objectID, objectType, branch.BRBranchID, fromDate, toDate, objEmployeesInfo.HREmployeeID);
                            documentPayments = documentPayments.Concat(result).ToList();
                        }
                    }
                    else
                    {
                        result = objReportsController.GetDepositList(saleOrderNo, objectID, objectType, branchID, fromDate, toDate, objEmployeesInfo.HREmployeeID);
                        documentPayments = documentPayments.Concat(result).ToList();
                    }
                }
            }
            else
            {
                if (branchID == 0)
                {
                    foreach (BRBranchsInfo branch in BranchList)
                    {
                        result = objReportsController.GetDepositList(saleOrderNo, objectID, objectType, branch.BRBranchID, fromDate, toDate, null);
                        documentPayments = documentPayments.Concat(result).ToList();
                    }
                }
                else
                    documentPayments = objReportsController.GetDepositList(saleOrderNo, objectID, objectType, branchID, fromDate, toDate, null);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            List<ARCustomerPaymentDetailsInfo> paymentDetails = new List<ARCustomerPaymentDetailsInfo>();
            fld_dgcARRP026DocumentPayments.DataSource = documentPayments;
            ReportDataSource = documentPayments;
            if (documentPayments.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
            fld_lblBRBranchName.Text = string.Empty;
            fld_lblBRBranchName.Text = fld_lkeBRBranchID.Text;
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}",
                                                                ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);


            fld_lblPaymentDetailSummary.Text = GetPaymentDetailSummary(paymentDetails);
        }

        /// <summary>
        /// Get the summary of details of all payments
        /// </summary>
        /// <param name="paymentDetails">List of payment details</param>
        /// <returns>String includes the summary</returns>
        private string GetPaymentDetailSummary(List<ARCustomerPaymentDetailsInfo> paymentDetails)
        {
            string summary = string.Empty;
            var paymentMethodGroups = paymentDetails.GroupBy(p => p.ARPaymentMethodCombo);
            foreach (var paymentMethodGroup in paymentMethodGroups)
            {
                if (paymentMethodGroup.Count() > 0)
                {
                    var currencyGroups = paymentMethodGroup.GroupBy(p => p.GECurrencyName);
                    if (currencyGroups.Count() > 0)
                    {
                        foreach (var currencyGroup in currencyGroups)
                        {
                            decimal amount = currencyGroup.Sum(p => p.ARCustomerPaymentDetailAmount);
                            if (amount > 0)
                            {
                                summary += string.Format("{0} {1} {2}: {3}",
                                                        ReportLocalizedResources.Sum,
                                                        paymentMethodGroup.First().ARPaymentMethodDisplayText,
                                                        currencyGroup.First().GECurrencyName,
                                                        BOSUtil.GetNumberDisplayFormat(amount, FormatGroupAttribute.cstFormatGroupPriceByCurrency)) + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            return summary;
        }

        /// <summary>
        /// Get the detail description of a payment, including payment methods, currencies and corresponding amounts
        /// </summary>
        /// <param name="paymentDetails">Details of the payment</param>
        /// <returns>Detail description of the payment</returns>
        private string GetPaymentDetailDesc(List<ARCustomerPaymentDetailsInfo> paymentDetails)
        {
            string desc = string.Empty;
            foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in paymentDetails)
            {
                if (objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailAmount > 0)
                {
                    desc += string.Format(" {0} {1}: {2};",
                                        objCustomerPaymentDetailsInfo.ARPaymentMethodDisplayText,
                                        objCustomerPaymentDetailsInfo.GECurrencyName,
                                        BOSUtil.GetNumberDisplayFormat(objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailAmount, FormatGroupAttribute.cstFormatGroupPriceByCurrency));
                }
            }
            if (!string.IsNullOrEmpty(desc))
            {
                desc = desc.Substring(0, desc.Length - 1);
            }
            return desc;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBRBranchName.Text, 1, 3));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 3));
            return lstHeaderParameter;
        }

        #endregion

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP026 rp = new BOSReport.RP026();
            //rp.LoadLayout(BOSCommon.Constants.Report.DevDocumentPaymentReportPath);            
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
                                                                ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel paymentDetailSummary = (XRLabel)rp.Bands[BandKind.ReportFooter].Controls["xr_lblPaymentDetailSummary"];
            if (paymentDetailSummary != null)
                paymentDetailSummary.Text = fld_lblPaymentDetailSummary.Text;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevDocumentPaymentReportPath, true);
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
