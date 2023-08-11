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
    public partial class RP072 : ReportForm
    {
        public RP072()
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
            BOSReport.RP072 report = new BOSReport.RP072();
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
            XRLabel startPeriodDescLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblStartPeriodDesc"];
            if (startPeriodDescLabel != null)
            {
                startPeriodDescLabel.Text += string.Format(" {0}:", fromDate.ToString("dd/MM/yyyy"));
            }
            XRLabel detailDesc = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDetailDesc"];
            if (detailDesc != null)
            {
                detailDesc.Text += string.Format(" {0} {1} {2}:",
                                                fromDate.ToString("dd/MM/yyyy"),
                                                ReportLocalizedResources.ToDateTitle,
                                                toDate.ToString("dd/MM/yyyy"));
            }
            XRLabel endPeriodDescLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblEndPeriodDesc"];
            if (endPeriodDescLabel != null)
            {
                endPeriodDescLabel.Text += string.Format(" {0}:", toDate.ToString("dd/MM/yyyy"));
            }

            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            decimal startBalance = 0;
            decimal endBalance = 0;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<ACDocumentsInfo> result = new List<ACDocumentsInfo>();
            foreach (BRBranchsInfo branch in selectedBranches)
            {
                if (currencyID > 0)
                {
                    startBalance += objDocumentEntrysController.GetAccountBalanceByCurrency(
                                                                            AccAccount.Acc131,
                                                                            fromDate.AddDays(-1),
                                                                            customerID,
                                                                            ObjectType.Customer.ToString(),
                                                                            currencyID,
                                                                            null,
                                                                            null,
                                                                            branch.BRBranchID);
                    endBalance += objDocumentEntrysController.GetAccountBalanceByCurrency(
                                                                            AccAccount.Acc131,
                                                                            toDate,
                                                                            customerID,
                                                                            ObjectType.Customer.ToString(),
                                                                            currencyID,
                                                                            null,
                                                                            null,
                                                                            branch.BRBranchID);
                }
                else
                {
                    startBalance += objDocumentEntrysController.GetAccountBalance(
                                                                          AccAccount.Acc131,
                                                                          fromDate.AddDays(-1),
                                                                          customerID,
                                                                          ObjectType.Customer.ToString(),
                                                                          currencyID,
                                                                          null,
                                                                          null,
                                                                          branch.BRBranchID);
                    endBalance += objDocumentEntrysController.GetAccountBalance(
                                                                            AccAccount.Acc131,
                                                                            toDate,
                                                                            customerID,
                                                                            ObjectType.Customer.ToString(),
                                                                            currencyID,
                                                                            null,
                                                                            null,
                                                                            branch.BRBranchID);
                }

                List<ACDocumentsInfo> list = objReportsController.GetCustomerOwingHistory(customerID, fromDate, toDate, currencyID, null, branch.BRBranchID);
                result.AddRange(list);
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }

            XRLabel endBalanceInWordLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblEndBalanceInWord"];
            if (endBalanceInWordLabel != null)
            {
                if (currencyID == 0)
                {
                    endBalanceInWordLabel.Text = ConvertAmountToWord.ReadAmount(endBalance.ToString(), BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID);
                }
                else
                {
                    endBalanceInWordLabel.Text = ConvertAmountToWord.ReadAmount(endBalance.ToString(), currencyID);
                }
            }

            List<ACDocumentsInfo> documents = new List<ACDocumentsInfo>();
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], START          
            //List<ACDocumentsInfo> result = objReportsController.GetCustomerOwingHistory(customerID, fromDate, toDate, currencyID, locationID, branchID);
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], END
            result = result.OrderBy(item => item.ACDocumentDate).ToList();
            int recordNumber = 1;
            foreach (ACDocumentsInfo document in result)
            {
                List<ACDocumentEntrysInfo> entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);
                decimal amount = 0;
                decimal depositExchangeAmount = 0;
                string saleOrderNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.ACDocumentDebitAccount.StartsWith(AccAccount.Acc131))
                    {
                        if (currencyID > 0)
                        {
                            amount += entry.ACDocumentEntryAmount;
                        }
                        else
                        {
                            amount += entry.ACDocumentEntryExchangeAmount;
                        }
                    }
                    else if (entry.ACDocumentCreditAccount.StartsWith(AccAccount.Acc131))
                    {
                        if (!entry.ACDocumentDebitAccount.StartsWith(AccAccount.Acc3386))
                        {
                            if (currencyID > 0)
                            {
                                amount -= entry.ACDocumentEntryAmount;
                            }
                            else
                            {
                                amount -= entry.ACDocumentEntryExchangeAmount;
                            }
                        }
                        else
                        {
                            if (currencyID > 0)
                            {
                                depositExchangeAmount += entry.ACDocumentEntryAmount;
                            }
                            else
                            {
                                depositExchangeAmount += entry.ACDocumentEntryExchangeAmount;
                            }
                        }
                    }
                }
                if (amount > 0)
                {
                    document.DocumentPaymentAmount = Math.Abs(amount);
                }
                else
                {
                    document.DocumentReceiptAmount = Math.Abs(amount);
                }
                document.RecordNumber = recordNumber;
                documents.Add(document);
                recordNumber++;

                if (document.ACDocumentTypeName == AccDocumentType.BanHangCongNo.ToString() ||
                    document.ACDocumentTypeName == AccDocumentType.BanLe.ToString() ||
                    document.ACDocumentTypeName == AccDocumentType.BanDichVu.ToString())
                {
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                    ARInvoicesInfo invoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(document.ACDocumentNo);
                    if (invoice != null)
                    {
                        document.ItemDiscountPercent = invoice.ARInvoiceDiscountPerCent;
                        document.ItemTaxPercent = invoice.ARInvoiceTaxPercent;
                        List<ARInvoiceItemsInfo> items = objInvoiceItemsController.GetItemsByInvoiceID(invoice.ARInvoiceID);
                        foreach (ARInvoiceItemsInfo item in items)
                        {
                            ACDocumentsInfo document1 = new ACDocumentsInfo();
                            document1.ACDocumentDesc = item.ARInvoiceItemProductDesc;
                            if (!string.IsNullOrEmpty(item.ARInvoiceItemProductSupplierNo))
                            {
                                document1.ACDocumentDesc = string.Format("{0} / {1}", item.ARInvoiceItemProductDesc, item.ARInvoiceItemProductSupplierNo);
                            }
                            document1.ItemQty = item.ARInvoiceItemProductQty;
                            document1.ItemUnitPrice = item.ARInvoiceItemProductUnitPrice;
                            document1.ItemDiscountPercent = item.ARInvoiceItemProductDiscount;
                            document1.ItemTaxPercent = item.ARInvoiceItemProductTaxPercent;
                            document1.ACDocumentExchangeRate = invoice.ARInvoiceExchangeRate;
                            document1.DocumentPaymentAmount = item.ARInvoiceItemTotalAmount;
                            documents.Add(document1);
                        }
                        saleOrderNo = invoice.ARInvoiceReference;
                    }
                }
                else if (document.ACDocumentTypeName == AccDocumentType.HangBanTraLai.ToString())
                {
                    ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
                    ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
                    ARSaleReturnsInfo saleReturn = (ARSaleReturnsInfo)objSaleReturnsController.GetObjectByNo(document.ACDocumentNo);
                    if (saleReturn != null)
                    {
                        document.ItemDiscountPercent = saleReturn.ARSaleReturnDiscountPerCent;
                        document.ItemTaxPercent = saleReturn.ARSaleReturnTaxPercent;
                        List<ARSaleReturnItemsInfo> items = objSaleReturnItemsController.GetItemsBySaleReturnID(saleReturn.ARSaleReturnID);
                        foreach (ARSaleReturnItemsInfo item in items)
                        {
                            ACDocumentsInfo document1 = new ACDocumentsInfo();
                            document1.ACDocumentDesc = item.ARSaleReturnItemProductDesc;
                            if (!string.IsNullOrEmpty(item.ARSaleReturnItemProductSupplierNo))
                            {
                                document1.ACDocumentDesc = string.Format("{0} / {1}", item.ARSaleReturnItemProductDesc, item.ARSaleReturnItemProductSupplierNo);
                            }
                            document1.ItemQty = item.ARSaleReturnItemProductQty;
                            document1.ItemUnitPrice = item.ARSaleReturnItemProductUnitPrice;
                            document1.ItemDiscountPercent = item.ARSaleReturnItemProductDiscount;
                            document1.ItemTaxPercent = item.ARSaleReturnItemProductTaxPercent;
                            document1.ACDocumentExchangeRate = saleReturn.ARSaleReturnExchangeRate;
                            document1.DocumentReceiptAmount = item.ARSaleReturnItemTotalAmount;
                            documents.Add(document1);
                        }
                    }
                }
                else if (document.ACDocumentTypeName == AccDocumentType.XuatKho.ToString())
                {
                    ICShipmentsController objShipmentsController = new ICShipmentsController();
                    ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                    ICShipmentsInfo shipment = (ICShipmentsInfo)objShipmentsController.GetObjectByNo(document.ACDocumentNo);
                    if (shipment != null)
                    {
                        document.ItemDiscountPercent = shipment.ICShipmentDiscountPerCent;
                        document.ItemTaxPercent = shipment.ICShipmentTaxPercent;
                        List<ICShipmentItemsInfo> items = objShipmentItemsController.GetItemsByShipmentID(shipment.ICShipmentID);
                        foreach (ICShipmentItemsInfo item in items)
                        {
                            ACDocumentsInfo document1 = new ACDocumentsInfo();
                            document1.ACDocumentDesc = item.ICShipmentItemProductDesc;
                            if (!string.IsNullOrEmpty(item.ICShipmentItemProductSupplierNo))
                            {
                                document1.ACDocumentDesc = string.Format("{0} / {1}", item.ICShipmentItemProductDesc, item.ICShipmentItemProductSupplierNo);
                            }
                            document1.ItemQty = item.ICShipmentItemProductQty;
                            document1.ItemUnitPrice = item.ICShipmentItemProductUnitPrice;
                            document1.ItemDiscountPercent = item.ICShipmentItemProductDiscount;
                            document1.ItemTaxPercent = item.ICShipmentItemProductTaxPercent;
                            document1.ACDocumentExchangeRate = shipment.ICShipmentExchangeRate;
                            document1.DocumentPaymentAmount = item.ICShipmentItemTotalAmount;
                            documents.Add(document1);
                        }
                    }
                }
                else if (document.ACDocumentTypeName == AccDocumentType.NhapKho.ToString())
                {
                    ICReceiptsController objReceiptsController = new ICReceiptsController();
                    ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                    ICReceiptsInfo receipt = (ICReceiptsInfo)objReceiptsController.GetObjectByNo(document.ACDocumentNo);
                    if (receipt != null)
                    {
                        document.ItemDiscountPercent = receipt.ICReceiptDiscountPerCent;
                        document.ItemTaxPercent = receipt.ICReceiptTaxPercent;
                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receipt.ICReceiptID);
                        foreach (ICReceiptItemsInfo item in items)
                        {
                            ACDocumentsInfo document1 = new ACDocumentsInfo();
                            document1.ACDocumentDesc = item.ICReceiptItemProductDesc;
                            if (!string.IsNullOrEmpty(item.ICReceiptItemProductSupplierNo))
                            {
                                document1.ACDocumentDesc = string.Format("{0} / {1}", item.ICReceiptItemProductDesc, item.ICReceiptItemProductSupplierNo);
                            }
                            document1.ItemQty = item.ICReceiptItemProductQty;
                            document1.ItemUnitPrice = item.ICReceiptItemProductUnitPrice;
                            document1.ItemDiscountPercent = item.ICReceiptItemProductDiscount;
                            document1.ItemTaxPercent = item.ICReceiptItemProductTaxPercent;
                            document1.ACDocumentExchangeRate = receipt.ICReceiptExchangeRate;
                            document1.DocumentReceiptAmount = item.ICReceiptItemTotalCost;
                            documents.Add(document1);
                        }
                    }
                }

                if (depositExchangeAmount > 0)
                {
                    ACDocumentsInfo document1 = new ACDocumentsInfo();
                    document1.ACDocumentNo = document.ACDocumentNo;
                    document1.ACDocumentDate = document.ACDocumentDate;
                    document1.ACDocumentDesc = string.Format("{0} {1}", ReportLocalizedResources.DepositExchange, saleOrderNo);
                    document1.DocumentReceiptAmount = depositExchangeAmount;
                    document1.RecordNumber = recordNumber;
                    documents.Add(document1);
                    recordNumber++;
                }
            }

            if (documents.Count == 0 && endBalance != 0)
            {
                ACDocumentsInfo document = new ACDocumentsInfo();
                documents.Add(document);
            }
            if (currencyID == 0)
            {
                foreach (ACDocumentsInfo document in documents)
                {
                    if (document.RecordNumber == 0)
                    {
                        document.ItemUnitPrice = document.ItemUnitPrice * document.ACDocumentExchangeRate;
                        document.DocumentPaymentAmount = document.DocumentPaymentAmount * document.ACDocumentExchangeRate;
                        document.DocumentReceiptAmount = document.DocumentReceiptAmount * document.ACDocumentExchangeRate;
                    }
                }
            }

            decimal totalPaymentAmount = documents.Where(d => d.RecordNumber > 0).Sum(d => d.DocumentPaymentAmount);
            decimal totalReceiptAmount = documents.Where(d => d.RecordNumber > 0).Sum(d => d.DocumentReceiptAmount);

            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
            foreach (ACDocumentsInfo document in documents)
            {
                if (customer != null)
                {
                    document.ACObjectNo = customer.ARCustomerNo;
                    document.ACObjectName = customer.ARCustomerName;
                    document.ACObjectContactAddress = customer.ARCustomerContactAddressLine3;
                    document.ACObjectContactPhone = customer.ARCustomerContactPhone;
                    document.ACObjectTaxNumber = customer.ARCustomerTaxNumber;
                }
                document.GECurrencyName = currencyName;
                document.StartPeriodBalance = startBalance;
                document.EndPeriodBalance = endBalance;
                document.TotalPaymentAmount = totalPaymentAmount;
                document.TotalReceiptAmount = totalReceiptAmount;
            }
            report.DataSource = documents;
        }

        private void RP072_Load(object sender, EventArgs e)
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
    }
}
