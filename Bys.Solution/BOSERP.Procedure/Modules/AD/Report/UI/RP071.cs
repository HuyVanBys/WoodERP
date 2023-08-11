using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
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
    public partial class RP071 : ReportForm
    {
        public RP071()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP071 report = new BOSReport.RP071();
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            ADReportsController objReportsController = new ADReportsController();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            List<ACObjectsInfo> objects = GetObjectList();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ARInvoicesInfo> invoices = new List<ARInvoicesInfo>();

            Parallel.ForEach<ACObjectsInfo>(objects, (obj) =>
            {
                decimal totalOwing = 0;
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    if (currencyID > 0)
                    {
                        totalOwing += objDocumentEntrysController.GetAccountBalanceByCurrency(
                                                                                AccAccount.Acc131,
                                                                                toDate,
                                                                                obj.ACObjectID,
                                                                                obj.ACObjectType,
                                                                                currencyID,
                                                                                null,
                                                                                null,
                                                                                branch.BRBranchID);
                    }
                    else
                    {
                        totalOwing += objDocumentEntrysController.GetAccountBalance(
                                                                                AccAccount.Acc131,
                                                                                toDate,
                                                                                obj.ACObjectID,
                                                                                obj.ACObjectType,
                                                                                currencyID,
                                                                                null,
                                                                                null,
                                                                                branch.BRBranchID);
                    }
                }
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                totalOwing = Math.Round(totalOwing, 3);
                if (totalOwing != 0)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    List<ARInvoicesInfo> result = new List<ARInvoicesInfo>();
                    foreach (BRBranchsInfo branch in selectedBranches)
                    {
                        List<ARInvoicesInfo> lst = objInvoicesController.GetOwingInvoices(obj.ACObjectID, null, currencyID, null, branch.BRBranchID, fromDate, toDate);
                        result.AddRange(lst);
                    }
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                    if (result.Count == 0)
                    {
                        ARInvoicesInfo invoice = new ARInvoicesInfo();
                        invoice.ARCustomerNo = obj.ACObjectNo;
                        invoice.ARCustomerName = obj.ACObjectName;
                        result.Add(invoice);
                    }

                    if (result.Count > 0)
                    {
                        result[0].TotalOwing = totalOwing;
                    }
                    if (currencyID == 0)
                    {
                        foreach (ARInvoicesInfo invoice in result)
                        {
                            invoice.ARInvoiceTotalAmount = invoice.ARInvoiceTotalAmount * invoice.ARInvoiceExchangeRate;
                            invoice.ARInvoiceDepositBalance = invoice.ARInvoiceDepositBalance * invoice.ARInvoiceExchangeRate;
                            invoice.ARInvoicePaymentAmount = invoice.ARInvoicePaymentAmount * invoice.ARInvoiceExchangeRate;
                            invoice.ARInvoiceReturnAmount = invoice.ARInvoiceReturnAmount * invoice.ARInvoiceExchangeRate;
                            invoice.ARInvoiceBalanceDue = invoice.ARInvoiceBalanceDue * invoice.ARInvoiceExchangeRate;
                        }
                    }
                    result.ForEach(i => i.GECurrencyName = currencyName);
                    invoices = invoices.Concat(result).ToList();
                }
            });
            //foreach (var iAsyncResult in resultList) iAsyncResult.AsyncWaitHandle.WaitOne();
            //foreach (ACObjectsInfo obj in objects)
            //{
            //    decimal totalOwing = 0;
            //    if (currencyID > 0)
            //    {
            //        totalOwing = objDocumentEntrysController.GetAccountBalanceByCurrency(
            //                                                                AccAccount.Acc131,
            //                                                                toDate,
            //                                                                obj.ACObjectID,
            //                                                                obj.ACObjectType,
            //                                                                currencyID,
            //                                                                null,
            //                                                                locationID,
            //                                                                branchID);
            //    }
            //    else
            //    {
            //        totalOwing = objDocumentEntrysController.GetAccountBalance(
            //                                                                AccAccount.Acc131,
            //                                                                toDate,
            //                                                                obj.ACObjectID,
            //                                                                obj.ACObjectType,
            //                                                                currencyID,
            //                                                                null,
            //                                                                locationID,
            //                                                                branchID);
            //    }
            //    totalOwing = Math.Round(totalOwing, 3);
            //    if (totalOwing != 0)
            //    {
            //        List<ARInvoicesInfo> result = objInvoicesController.GetOwingInvoices(obj.ACObjectID, null, currencyID, locationID, branchID, fromDate, toDate);
            //        if (result.Count == 0)
            //        {
            //            ARInvoicesInfo invoice = new ARInvoicesInfo();
            //            invoice.ARCustomerNo = obj.ACObjectNo;
            //            invoice.ARCustomerName = obj.ACObjectName;
            //            result.Add(invoice);
            //        }

            //        if (result.Count > 0)
            //        {
            //            result[0].TotalOwing = totalOwing;
            //        }
            //        if (currencyID == 0)
            //        {
            //            foreach (ARInvoicesInfo invoice in result)
            //            {
            //                invoice.ARInvoiceTotalAmount = invoice.ARInvoiceTotalAmount * invoice.ARInvoiceExchangeRate;
            //                invoice.ARInvoiceDepositBalance = invoice.ARInvoiceDepositBalance * invoice.ARInvoiceExchangeRate;
            //                invoice.ARInvoicePaymentAmount = invoice.ARInvoicePaymentAmount * invoice.ARInvoiceExchangeRate;
            //                invoice.ARInvoiceReturnAmount = invoice.ARInvoiceReturnAmount * invoice.ARInvoiceExchangeRate;
            //                invoice.ARInvoiceBalanceDue = invoice.ARInvoiceBalanceDue * invoice.ARInvoiceExchangeRate;
            //            }
            //        }
            //        result.ForEach(i => i.GECurrencyName = currencyName);
            //        invoices = invoices.Concat(result).ToList();
            //    }
            //}

            invoices = invoices.OrderBy(i => i.ARCustomerName).ToList();
            string groupValue = string.Empty;
            int recordNumber = 1;
            Parallel.ForEach<ARInvoicesInfo>(invoices, (invoice) =>
            {
                string temp = string.Format("{0}{1}", invoice.ARCustomerName, invoice.ARCustomerNo);
                if (temp != groupValue)
                {
                    invoice.RecordNumber = recordNumber;
                    recordNumber++;
                    groupValue = temp;
                }
            });
            //foreach (ARInvoicesInfo invoice in invoices)
            //{
            //    string temp = string.Format("{0}{1}", invoice.ARCustomerName, invoice.ARCustomerNo);
            //    if (temp != groupValue)
            //    {
            //        invoice.RecordNumber = recordNumber;
            //        recordNumber++;
            //        groupValue = temp;
            //    }
            //}
            report.DataSource = invoices;
            BOSProgressBar.Close();
        }

        private void RP071_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }
        }

        /// <summary>
        /// Get object list for the report
        /// </summary>
        private List<ACObjectsInfo> GetObjectList()
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            if (customerID > 0)
            {
                ACObjectsInfo obj = objObjectsController.GetObjectByIDAndType(customerID, ObjectType.Customer.ToString());
                objects.Add(obj);
            }
            else
            {
                int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
                int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                List<ACObjectsInfo> result = objObjectsController.GetOwingObjects(AccAccount.Acc131, fromDate, toDate, ObjectType.Customer.ToString(), locationID, branchID, true);
                objects = objects.Concat(result).ToList();

                //Make the object list unique
                for (int i = 0; i < objects.Count; i++)
                {
                    for (int j = i + 1; j < objects.Count; j++)
                    {
                        if (objects[i].ACObjectID == objects[j].ACObjectID && objects[i].ACObjectType == objects[j].ACObjectType)
                        {
                            objects.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
            return objects;
        }
    }
}
