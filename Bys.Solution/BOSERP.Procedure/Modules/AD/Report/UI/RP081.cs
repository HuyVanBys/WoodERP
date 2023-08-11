using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP081 : ReportForm
    {
        public RP081()
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
            BOSReport.RP081 report = new BOSReport.RP081();
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
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            List<ACDocumentsInfo> result = new List<ACDocumentsInfo>();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            #region init label
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
            #endregion

            int supplierID = Convert.ToInt32(fld_lkeAPSupplierID.EditValue);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            foreach (BRBranchsInfo branch in selectedBranches)
            {
                List<ACDocumentsInfo> documentByAccounts = objDocumentsController.GetDocumentsForReportRP081(supplierID, fromDate, toDate, currencyID, null, branch.BRBranchID);
                if (documentByAccounts.Count > 0)
                {
                    decimal account = documentByAccounts.First().StartPeriodBalance;
                    documentByAccounts.ForEach(o =>
                    {
                        account = account - o.DocumentPaymentAmount;
                        o.AccountBalance = account;
                        o.EndPeriodBalance = o.AccountBalance;
                    });
                    result = result.Concat(documentByAccounts).ToList();
                }
            }
            report.DataSource = result;
            decimal totalPaymentAmount = 0;
            decimal totalReceiptAmount = 0;
            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierID);
            foreach (ACDocumentsInfo document in result)
            {
                if (supplier != null)
                {
                    document.ACObjectNo = supplier.APSupplierNo;
                    document.ACObjectName = supplier.APSupplierName;
                    document.ACObjectContactAddress = supplier.APSupplierContactAddressLine3;
                    document.ACObjectContactPhone = supplier.APSupplierContactPhone;
                    document.ACObjectTaxNumber = supplier.APSupplierTaxNumber;
                }
                document.GECurrencyName = currencyName;
                totalPaymentAmount += document.DocumentPaymentAmount;
                totalReceiptAmount += document.DocumentReceiptAmount;
                document.TotalPaymentAmount = totalPaymentAmount;
                document.TotalReceiptAmount = totalReceiptAmount;
            }
            report.DataSource = result;
        }
        #region HoanVo_Delete
        /*public void InitDataSourceReport(XtraReport report)
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

            int supplierID = Convert.ToInt32(fld_lkeAPSupplierID.EditValue);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);            
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();            
            decimal startBalance = 0;
            decimal endBalance = 0;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            List<ACDocumentsInfo> result = new List<ACDocumentsInfo>();
            foreach (BRBranchsInfo branch in selectedBranches)
            {
                 List<ACDocumentsInfo> list = objReportsController.GetSuplierOwingHistory(supplierID, fromDate, toDate, currencyID, null, branch.BRBranchID);
                 result.AddRange(list);

                if (currencyID > 0)
                {
                    startBalance += objDocumentEntrysController.GetAccountBalanceByCurrency(
                                                                            AccAccount.Acc331,
                                                                            fromDate.AddDays(-1),
                                                                            supplierID,
                                                                            ObjectType.Supplier.ToString(),
                                                                            currencyID,
                                                                            null,
                                                                            null,
                                                                            branch.BRBranchID);
                    endBalance += objDocumentEntrysController.GetAccountBalanceByCurrency(
                                                                            AccAccount.Acc331,
                                                                            toDate,
                                                                            supplierID,
                                                                            ObjectType.Supplier.ToString(),
                                                                            currencyID,
                                                                            null,
                                                                            null,
                                                                            branch.BRBranchID);
                }
                else
                {
                    startBalance += objDocumentEntrysController.GetAccountBalance(
                                                                          AccAccount.Acc331,
                                                                          fromDate.AddDays(-1),
                                                                          supplierID,
                                                                          ObjectType.Supplier.ToString(),
                                                                          currencyID,
                                                                          null,
                                                                          null,
                                                                          branch.BRBranchID);
                    endBalance += objDocumentEntrysController.GetAccountBalance(
                                                                            AccAccount.Acc331,
                                                                            toDate,
                                                                            supplierID,
                                                                            ObjectType.Supplier.ToString(),
                                                                            currencyID,
                                                                            null,
                                                                            null,
                                                                            branch.BRBranchID);
                }
            }

            result = result.OrderBy(item => item.ACDocumentDate).ToList();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
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
            //List<ACDocumentsInfo> result = objReportsController.GetSuplierOwingHistory(supplierID, fromDate, toDate, currencyID, locationID, branchID);
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], END
            int recordNumber = 1;
            foreach (ACDocumentsInfo document in result)
            {                
                List<ACDocumentEntrysInfo> entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);                                
                decimal amount = 0;
                decimal depositExchangeAmount = 0;                
                string purchaseOrderNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.ACDocumentDebitAccount.StartsWith(AccAccount.Acc331))
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
                    else if (entry.ACDocumentCreditAccount.StartsWith(AccAccount.Acc331))
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
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = null;
                if (document.ACDocumentTypeName == AccDocumentType.MuaHangCongNoNhapKhau.ToString()
                    ||document.ACDocumentTypeName == AccDocumentType.ThanhToanPhi.ToString())
                {
                    APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                    APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
                    APInvoiceInsInfo invoice = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByNo(document.ACDocumentNo);                    
                    if (invoice != null)
                    {
                        document.ItemDiscountPercent = invoice.APInvoiceInDiscountPerCent;
                        document.ItemTaxPercent = invoice.APInvoiceInTaxPercent;
                        List<APInvoiceInItemsInfo> items = objInvoiceInItemsController.GetItemsByInvoiceID(invoice.APInvoiceInID);
                        //TNDLoc [ADD][07/12/2015][Distinct items ],START
                        List<int> itemIDs = new List<int>();
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (itemIDs.Contains(items[i].APInvoiceInItemID))
                            {
                                items.RemoveAt(i--);
                            }
                            else
                            {
                                itemIDs.Add(items[i].APInvoiceInItemID);
                            }
                        }
                        //TNDLoc [ADD][07/12/2015][Distinct items ],END
                        foreach (APInvoiceInItemsInfo item in items)
                        {
                            ACDocumentsInfo document1 = new ACDocumentsInfo();
                            document1.ACDocumentDesc = item.APInvoiceInItemProductDesc;
                            if (!string.IsNullOrEmpty(item.APInvoiceInItemProductSupplierNo))
                            {
                                document1.ACDocumentDesc = string.Format("{0} / {1}", item.APInvoiceInItemProductDesc, item.APInvoiceInItemProductSupplierNo);                            
                            }                            
                            document1.ItemQty = item.APInvoiceInItemProductQty;
                            document1.ItemUnitPrice = item.APInvoiceInItemProductUnitCost;
                            document1.ItemDiscountPercent = item.APInvoiceInItemProductDiscount;
                            document1.ItemTaxPercent = item.APInvoiceInItemProductTaxPercent;
                            document1.ACDocumentExchangeRate = invoice.APInvoiceInExchangeRate;
                            document1.DocumentReceiptAmount = item.APInvoiceInItemTotalCost;
                            //document1.DocumentPaymentAmount = item.APInvoiceInPaymentAmount;
                            document1.ProductSerieNo = string.IsNullOrEmpty(item.APInvoiceInItemProductSerialNo) ? item.ICProductSerieNo : item.APInvoiceInItemProductSerialNo;
                            documents.Add(document1);
                        }
                        purchaseOrderNo = invoice.APInvoiceInReference;                        
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
                            objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
                            if (objProductSeriesInfo != null)
                                document1.ProductSerieNo = objProductSeriesInfo.ICProductSerieNo;
                            documents.Add(document1);
                        }
                    }
                }
                else if (document.ACDocumentTypeName == AccDocumentType.NhapKho.ToString() ||
                        document.ACDocumentTypeName == AccDocumentType.NhapKhoMuaHang.ToString())
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
                            document1.ItemUnitPrice = item.ICReceiptItemProductUnitCost;
                            document1.ItemDiscountPercent = item.ICReceiptItemProductDiscount;
                            document1.ItemTaxPercent = item.ICReceiptItemProductTaxPercent;
                            document1.ACDocumentExchangeRate = receipt.ICReceiptExchangeRate;
                            document1.DocumentReceiptAmount = item.ICReceiptItemTotalCost;
                            objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
                            if (objProductSeriesInfo != null)
                                document1.ProductSerieNo = objProductSeriesInfo.ICProductSerieNo;
                            documents.Add(document1);
                        }
                    }
                }

                if (depositExchangeAmount > 0)
                {
                    ACDocumentsInfo document1 = new ACDocumentsInfo();
                    document1.ACDocumentNo = document.ACDocumentNo;
                    document1.ACDocumentDate = document.ACDocumentDate;                    
                    document1.ACDocumentDesc = string.Format("{0} {1}", ReportLocalizedResources.DepositExchange, purchaseOrderNo);
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

            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierID);
            foreach (ACDocumentsInfo document in documents)
            {
                if (supplier != null)
                {
                    document.ACObjectNo = supplier.APSupplierNo;
                    document.ACObjectName = supplier.APSupplierName;
                    document.ACObjectContactAddress = supplier.APSupplierContactAddressLine3;
                    document.ACObjectContactPhone = supplier.APSupplierContactPhone;
                    document.ACObjectTaxNumber = supplier.APSupplierTaxNumber;
                }
                document.GECurrencyName = currencyName;
                document.StartPeriodBalance = startBalance;
                document.EndPeriodBalance = endBalance;
                document.TotalPaymentAmount = totalPaymentAmount;
                document.TotalReceiptAmount = totalReceiptAmount;
            }           
            report.DataSource = documents;
        }*/
        #endregion

        private void RP081_Load(object sender, EventArgs e)
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
