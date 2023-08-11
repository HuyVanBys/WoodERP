using BOSCommon;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP001 : ReportForm
    {
        /// <summary>
        /// A variable to store the list of selected employees 
        /// </summary>
        private List<HREmployeesInfo> SelectedEmployeeList = new List<HREmployeesInfo>();

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ARInvoicesInfo> ReportDataSource;

        public RP001()
        {
            InitializeComponent();

            SelectedEmployeeList = new List<HREmployeesInfo>();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }

            DateTime fromDate = fld_dteSearchFromARInvoiceDate.DateTime;
            DateTime toDate = fld_dteSearchToARInvoiceDate.DateTime;
            string invoiceType = Convert.ToString(fld_lkeARInvoiceTypeCombo.EditValue);
            List<ARInvoicesInfo> invoices = new List<ARInvoicesInfo>();
            if (SelectedEmployeeList.Count > 0)
            {
                foreach (HREmployeesInfo objEmployeesInfo in SelectedEmployeeList)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        List<ARInvoicesInfo> result = objReportsController.GetInvoicesBySomeCriteria(branch.BRBranchID, objectID, objectType, invoiceType, fromDate, toDate, objEmployeesInfo.HREmployeeID);
                        invoices = invoices.Concat(result).ToList();
                    }
                    //List<ARInvoicesInfo> result = objReportsController.GetInvoicesBySomeCriteriaAndBranchNosList(branchNos, customerID, invoiceType, fromDate, toDate, objEmployeesInfo.HREmployeeID);
                    //invoices = invoices.Concat(result).ToList();
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                }
            }
            else
            {
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<ARInvoicesInfo> result = objReportsController.GetInvoicesBySomeCriteria(branch.BRBranchID, objectID, objectType, invoiceType, fromDate, toDate, null);
                    invoices = invoices.Concat(result).ToList();
                }
                //invoices = objReportsController.GetInvoicesBySomeCriteriaAndBranchNosList(branchNos, customerID, invoiceType, fromDate, toDate, null);
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }

            ReportDataSource = invoices;
            fld_dgcARRP001Invoices.Visible = false;
            fld_dgcRP001SaleReceipts.Visible = false;
            if (invoiceType != InvoiceType.SaleReceipt.ToString())
            {
                fld_dgcARRP001Invoices.DataSource = invoices;
                fld_dgcARRP001Invoices.Visible = true;
                fld_lblPaymentDetailSummary.Text = string.Empty;
            }
            else
            {
                fld_dgcRP001SaleReceipts.Visible = true;

                ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                List<ARCustomerPaymentDetailsInfo> paymentDetails = new List<ARCustomerPaymentDetailsInfo>();
                foreach (ARInvoicesInfo objInvoicesInfo in invoices)
                {
                    List<ARCustomerPaymentsInfo> customerPayments = objCustomerPaymentsController.GetCustomerPaymentsByInvoiceID(objInvoicesInfo.ARInvoiceID);
                    if (customerPayments.Count > 0)
                    {
                        ARCustomerPaymentsInfo objCustomerPaymentsInfo = customerPayments[0];
                        List<ARCustomerPaymentDetailsInfo> result = objCustomerPaymentsController.GetPaymentDetails(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objInvoicesInfo.ARCustomerPaymentDetailDesc = GetPaymentDetailDesc(result);
                        paymentDetails = paymentDetails.Concat(result).ToList();
                    }
                }

                fld_dgcRP001SaleReceipts.DataSource = invoices;
                fld_lblPaymentDetailSummary.Text = GetPaymentDetailSummary(paymentDetails);
            }

            if (invoices.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
            fld_lblBRBranchName.Text = string.Empty;
            if (Convert.ToInt32(fld_lkeBRBranchID.EditValue) > 0)
            {
                fld_lblBRBranchName.Text = fld_lkeBRBranchID.Text;
            }
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}",
                ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
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
            this.Close();
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

        private void RP001_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now;
            fld_lblBRBranchName.Text = string.Empty;
            //ShowReportData();
        }

        /// <summary>
        /// Set default current branch and title displaying for report
        /// </summary>
        /// <param name="report">Report</param>
        /// <param name="branchID">Branch id</param>
        private void SetDefaultCurrentBranchAndTitle(XtraReport report, int branchID)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchName"];
            branchName.Text += string.Format(" {0}", objBranchsController.GetObjectNameByID(branchID));
            XRLabel datetTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            datetTime.Text = string.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                           ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];

            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string invoiceType = Convert.ToString(fld_lkeARInvoiceTypeCombo.EditValue);
            if (invoiceType != InvoiceType.SaleReceipt.ToString())
            {
                BOSReport.RP001 report = new BOSReport.RP001();
                //rp.LoadLayout(BOSCommon.Constants.Report.DevInvoiceReportPath);
                report.DataSource = ReportDataSource;
                SetDefaultCurrentBranchAndTitle(report, branchID);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceReportPath, true);
                reviewer.Show();
            }
            else
            {
                BOSReport.RP001SaleReceipt report = new BOSReport.RP001SaleReceipt();
                //rp.LoadLayout(BOSCommon.Constants.Report.DevSaleReceiptPath);
                report.DataSource = ReportDataSource;
                SetDefaultCurrentBranchAndTitle(report, branchID);
                XRLabel paymentDetailSummary = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblPaymentDetailSummary"];
                if (paymentDetailSummary != null)
                    paymentDetailSummary.Text = fld_lblPaymentDetailSummary.Text;
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevSaleReceiptPath, true);
                reviewer.Show();
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