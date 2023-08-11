using BOSCommon;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP096 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP096()
        {
            InitializeComponent();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnExportExcel_Click(object sender, EventArgs e)
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

                    fld_dgcRP096ARSaleOrders.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            string acObjectAccessKey = string.Empty;
            if (fld_lkeACObjectAccessKey.EditValue != null)
                acObjectAccessKey = fld_lkeACObjectAccessKey.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acObjectAccessKey);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            List<ARSaleOrdersInfo> saleOrdersList = objReportsController.GetSaleOrderForSaleOrderListReport(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, searchFromDate, searchToDate, branchID);

            List<ARSaleOrdersInfo> extraList = new List<ARSaleOrdersInfo>();
            //TNDLoc [ADD][30/12/2015][Get Payment time => Payment Percent],START
            ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();

            //TNDLoc [ADD][30/12/2015][Get Payment time => Payment Percent],END
            //Get Customer Payment & Invoice 
            foreach (ARSaleOrdersInfo SOInfo in saleOrdersList.Where(p => p.ARSaleOrderDocumentType != "Invoice").ToList())
            {

                decimal paymentAmount = 0;
                decimal invoiceInAmount = 0;
                decimal depositAmount = 0;
                //Deposit
                ARSaleOrderPaymentTimesInfo objPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)objReportsController.GetSOPaymentTimeBySomeConditions(SOInfo.ARSaleOrderID, SaleOrderPaymentTimePaymentType.Deposit.ToString(), searchFromDate, searchToDate).FirstOrDefault();
                if (objPaymentTimesInfo != null)
                {
                    ARSaleOrdersInfo objDepositsInfo = new ARSaleOrdersInfo();
                    objDepositsInfo = ConvertToSaleOrder(SaleOrderPaymentTimePaymentType.Deposit.ToString(),
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeAmount,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeDepositBalance,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeDate,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeDueDate,
                                                             SOInfo.ARSaleOrderNo,
                                                             ReportLocalizedResources.Credit);
                    if (objPaymentTimesInfo.ARSaleOrderPaymentTimeStatus == SaleOrderPaymentTimeStatus.Canceled.ToString())
                    {
                        depositAmount = 0;
                    }
                    else
                    {
                        depositAmount = objPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue;
                    }
                    if (depositAmount == 0)
                    {
                        depositAmount = objPaymentTimesInfo.ARSaleOrderPaymentTimeAmount;
                    }
                    objDepositsInfo.ReportObjectType = ReportRP096ObjectType.SaleOrder.ToString();
                    extraList.Add(objDepositsInfo);
                }
                //Invoice
                List<ARSOPaymentTimeInvoiceDetailsInfo> InvoiceList = objReportsController.GetPaymentTimeInvoiceDetailBySomeConditions(SOInfo.ARSaleOrderID, searchFromDate, searchToDate);
                foreach (ARSOPaymentTimeInvoiceDetailsInfo item in InvoiceList)
                {
                    ARSaleOrdersInfo objInvoicesInfo = new ARSaleOrdersInfo();
                    objInvoicesInfo = ConvertToSaleOrder(item.ARInvoiceNo,
                                                             item.ARSOPaymentTimeInvoiceDetailAmount,
                                                             0,
                                                             0,
                                                             item.ARSOPaymentTimeInvoiceDetailDate,
                                                             item.ARSOPaymentTimeInvoiceDetailEndDate,
                                                             SOInfo.ARSaleOrderNo,
                                                             ReportLocalizedResources.Credit);
                    objInvoicesInfo.ReportObjectType = ReportRP096ObjectType.Invoice.ToString();
                    extraList.Add(objInvoicesInfo);
                    invoiceInAmount += item.ARSOPaymentTimeInvoiceDetailAmount;
                }
                //Customer Payment 
                List<APPurchaseOrdersInfo> customerPaymentList = objReportsController.GetPaymentInfoFromSaleOrderNo(SOInfo.ARSaleOrderNo, searchFromDate, searchToDate);
                foreach (APPurchaseOrdersInfo paymentItem in customerPaymentList)
                {
                    ARSaleOrdersInfo objPaymentsInfo = new ARSaleOrdersInfo();
                    objPaymentsInfo = ConvertToSaleOrder(paymentItem.APSupplierPaymentNo,
                                                             paymentItem.APDocumentPaymentAmount,
                                                             0,
                                                             0,
                                                             paymentItem.APPurchaseOrderDate,
                                                             DateTime.MinValue,
                                                             SOInfo.ARSaleOrderNo,
                                                             ReportLocalizedResources.Debit);
                    objPaymentsInfo.ReportObjectType = ReportRP096ObjectType.CustomerPayment.ToString();
                    objPaymentsInfo.ARSaleOrderID = paymentItem.APPurchaseOrderID;
                    extraList.Add(objPaymentsInfo);
                    paymentAmount += paymentItem.APDocumentPaymentAmount;
                }
                List<ARSaleOrderPaymentTimesInfo> objPaymentTimeList = objSaleOrderPaymentTimesController.GetItemsBySaleOrderID(SOInfo.ARSaleOrderID);
                decimal percentPayment = 0;
                if (objPaymentTimeList != null && objPaymentTimeList.Count > 0)
                {
                    ARSaleOrderPaymentTimesInfo objPaymentsInfo = objPaymentTimeList.FirstOrDefault(e => e.ARSaleOrderPaymentTimePaymentType == "Final Payment");
                    if (objPaymentsInfo != null)
                    {
                        if (SOInfo.ARSaleOrderTotalAmount > 0)
                            percentPayment = (objPaymentsInfo.ARSaleOrderPaymentTimeAmount / SOInfo.ARSaleOrderTotalAmount);
                    }
                }
                SOInfo.ReportPaidAmount = paymentAmount;
                SOInfo.ReportTotalAmount = SOInfo.ARSaleOrderTotalAmount;

                //SOInfo.ReportBalanceDueAmount = depositAmount + invoiceInAmount - paymentAmount;
                if (invoiceInAmount > 0)
                {

                    SOInfo.ReportBalanceDueAmount = (invoiceInAmount * percentPayment) - (paymentAmount - depositAmount);
                }
                else
                {
                    SOInfo.ReportBalanceDueAmount = -paymentAmount;
                }
                SOInfo.ReportReferencesNo = SOInfo.ARSaleOrderNo;
                SOInfo.ReportObjectType = ReportRP096ObjectType.SaleOrder.ToString();
                SOInfo.ReportDocumentType = " SO";
            }


            //References Purchase Order

            //        List<APPurchaseOrdersInfo> objPurchaseOrdersList = GetReferencePurchaseOrder(SOInfo.ARSaleOrderID);
            //        ARSaleOrdersInfo objsSaleOrderRef;
            //        foreach (APPurchaseOrdersInfo POInfo in objPurchaseOrdersList)
            //        {
            //            objsSaleOrderRef = new ARSaleOrdersInfo();
            //            if (POInfo.ReportDocumentType == " PO")
            //            {
            //                objsSaleOrderRef = ConvertPurchaseOrderToSaleOrder(POInfo.ReportReferencesNo,
            //                                                                   POInfo.ReportTotalAmount,
            //                                                                   POInfo.ReportPaidAmount,
            //                                                                   POInfo.ReportBalanceDueAmount,
            //                                                                   POInfo.ReportContractFromDate,
            //                                                                   POInfo.ReportContractToDate,
            //                                                                   SOInfo.ARSaleOrderNo,
            //                                                                   POInfo.APPurchaseOrderNo,
            //                                                                   " PO");
            //            }
            //            else if (POInfo.ReportDocumentType == ReportLocalizedResources.Debit)
            //            {
            //                objsSaleOrderRef = ConvertPurchaseOrderToSaleOrder(POInfo.ReportReferencesNo,
            //                                                                  POInfo.ReportTotalAmount,
            //                                                                  POInfo.ReportPaidAmount,
            //                                                                  POInfo.ReportBalanceDueAmount,
            //                                                                  POInfo.ReportContractFromDate,
            //                                                                  POInfo.ReportContractToDate,
            //                                                                  SOInfo.ARSaleOrderNo,
            //                                                                  POInfo.APPurchaseOrderNo,
            //                                                                  ReportLocalizedResources.Debit);
            //            }
            //            else if (POInfo.ReportDocumentType == ReportLocalizedResources.Credit)
            //            {
            //                objsSaleOrderRef = ConvertPurchaseOrderToSaleOrder(POInfo.ReportReferencesNo,
            //                                                                      POInfo.ReportTotalAmount,
            //                                                                      POInfo.ReportPaidAmount,
            //                                                                      POInfo.ReportBalanceDueAmount,
            //                                                                      POInfo.ReportContractFromDate,
            //                                                                      POInfo.ReportContractToDate,
            //                                                                      SOInfo.ARSaleOrderNo,
            //                                                                      POInfo.APPurchaseOrderNo,
            //                                                                      ReportLocalizedResources.Credit);
            //            }
            //            objsSaleOrderRef.ReportObjectType = POInfo.ReportObjectType;
            //            extraList.Add(objsSaleOrderRef);
            ////        }
            //    }
            saleOrdersList.AddRange(extraList);

            fld_dgcRP096ARSaleOrders.DataSource = saleOrdersList;

        }
        public ARSaleOrdersInfo ConvertPurchaseOrderToSaleOrder(string refNo, decimal totalAmount, decimal paidAmount, decimal dueAmount, DateTime fromDate, DateTime toDate, string saleOrderNo, string type, string subType)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            objSaleOrdersInfo.ReportReferencesNo = refNo;
            objSaleOrdersInfo.ReportTotalAmount = totalAmount;
            objSaleOrdersInfo.ReportPaidAmount = paidAmount;
            objSaleOrdersInfo.ReportBalanceDueAmount = dueAmount;
            objSaleOrdersInfo.ReportContractFromDate = fromDate;
            objSaleOrdersInfo.ReportContractToDate = toDate;
            objSaleOrdersInfo.ReportDocumentType = type;
            objSaleOrdersInfo.ARSaleOrderNo = saleOrderNo;
            objSaleOrdersInfo.ReportObjectSubType = subType;
            return objSaleOrdersInfo;


        }
        public ARSaleOrdersInfo ConvertToSaleOrder(string refNo, decimal totalAmount, decimal paidAmount, decimal dueAmount, DateTime fromDate, DateTime toDate, string saleOrderNo, string type)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            objSaleOrdersInfo.ReportReferencesNo = refNo;
            objSaleOrdersInfo.ReportTotalAmount = totalAmount;
            objSaleOrdersInfo.ReportPaidAmount = paidAmount;
            objSaleOrdersInfo.ReportBalanceDueAmount = dueAmount;
            objSaleOrdersInfo.ReportContractFromDate = fromDate;
            objSaleOrdersInfo.ReportContractToDate = toDate;
            objSaleOrdersInfo.ReportDocumentType = type;
            objSaleOrdersInfo.ARSaleOrderNo = saleOrderNo;
            return objSaleOrdersInfo;


        }
        public APPurchaseOrdersInfo ConvertToPurchaseOrder(string refNo, decimal totalAmount, decimal paidAmount, decimal dueAmount, DateTime fromDate, DateTime toDate, string purchaseOrderNo, string type)
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = new APPurchaseOrdersInfo();
            objPurchaseOrdersInfo.ReportReferencesNo = refNo;
            objPurchaseOrdersInfo.ReportTotalAmount = totalAmount;
            objPurchaseOrdersInfo.ReportPaidAmount = paidAmount;
            objPurchaseOrdersInfo.ReportBalanceDueAmount = dueAmount;
            objPurchaseOrdersInfo.ReportContractFromDate = fromDate;
            objPurchaseOrdersInfo.ReportContractToDate = toDate;
            objPurchaseOrdersInfo.ReportDocumentType = type;
            objPurchaseOrdersInfo.APPurchaseOrderNo = purchaseOrderNo;
            return objPurchaseOrdersInfo;
        }

        //public List<APPurchaseOrdersInfo> GetReferencePurchaseOrder(int saleOrderID)
        //{


        //    DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
        //    DateTime searchToDate = fld_dteSearchToDate.DateTime;
        //    int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
        //    ADReportsController objReportsController = new ADReportsController();
        //    List<APPurchaseOrdersInfo> purchaseOrdersList = objReportsController.GetPurchaseOrderBySaleOrderID(saleOrderID);

        //    List<APPurchaseOrdersInfo> extraList = new List<APPurchaseOrdersInfo>();
        //    //Get Supplier Payment & Invoice In
        //    foreach (APPurchaseOrdersInfo POInfo in purchaseOrdersList)
        //    {
        //        decimal paymentAmount = 0;
        //        decimal invoiceInAmount = 0;
        //        decimal depositAmount = 0;
        //        //Deposit
        //        APPurchaseOrderPaymentTimesInfo objPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)objReportsController.GetPaymentTimeBySomeConditions(POInfo.APPurchaseOrderID, PurchaseOrderPaymentTimePaymentType.Deposit.ToString(), searchFromDate, searchToDate).FirstOrDefault();
        //        if (objPaymentTimesInfo != null)
        //        {
        //            APPurchaseOrdersInfo objDepositsInfo = new APPurchaseOrdersInfo();
        //            objDepositsInfo = ConvertToPurchaseOrder(PurchaseOrderPaymentTimePaymentType.Deposit.ToString(),
        //                                                     objPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount,
        //                                                     objPaymentTimesInfo.ARSaleOrderPaymentTimeDepositBalance,
        //                                                     objPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue,
        //                                                     objPaymentTimesInfo.APPurchaseOrderPaymentTimeDate,
        //                                                     objPaymentTimesInfo.ARSaleOrderPaymentTimeDueDate,
        //                                                     POInfo.APPurchaseOrderNo,
        //                                                     CommonLocalizedResources.Credit);
        //            if (objPaymentTimesInfo.APPurchaseOrderPaymentTimeStatus == PurchaseOrderPaymentTimeStatus.Canceled.ToString())
        //            {
        //                depositAmount = 0;
        //            }
        //            else
        //            {
        //                depositAmount = objPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue;
        //            }
        //            objDepositsInfo.ReportObjectType = ReportRP098ObjectType.PurchaseOrder.ToString();
        //            extraList.Add(objDepositsInfo);
        //        }
        //        //Invoice In
        //        List<APPOPaymentTimeInvoiceInDetailsInfo> InvoiceInList = objReportsController.GetPaymentTimeInvoiceInDetailBySomeConditions(POInfo.APPurchaseOrderID, searchFromDate, searchToDate);
        //        foreach (APPOPaymentTimeInvoiceInDetailsInfo item in InvoiceInList)
        //        {
        //            APPurchaseOrdersInfo objInvoiceInsInfo = new APPurchaseOrdersInfo();
        //            objInvoiceInsInfo = ConvertToPurchaseOrder(item.APInvoiceInNo,
        //                                                     item.APPOPaymentTimeInvoiceInDetailAmount,
        //                                                     0,
        //                                                     0,
        //                                                     item.APPOPaymentTimeInvoiceInDetailDate,
        //                                                     item.APPOPaymentTimeInvoiceInDetailEndDate,
        //                                                     POInfo.APPurchaseOrderNo,
        //                                                     CommonLocalizedResources.Credit);
        //            objInvoiceInsInfo.ReportObjectType = ReportRP098ObjectType.InvoiceIn.ToString();
        //            extraList.Add(objInvoiceInsInfo);
        //            invoiceInAmount += item.APPOPaymentTimeInvoiceInDetailAmount;
        //        }
        //        //Supplier Payment 
        //        List<APPurchaseOrdersInfo> supplierPaymentList = objReportsController.GetPaymentInfoFromPurchaseOrderNo(POInfo.APPurchaseOrderNo, searchFromDate, searchToDate);
        //        foreach (APPurchaseOrdersInfo paymentItem in supplierPaymentList)
        //        {
        //            APPurchaseOrdersInfo objPaymentsInfo = new APPurchaseOrdersInfo();
        //            objPaymentsInfo = ConvertToPurchaseOrder(paymentItem.APSupplierPaymentNo,
        //                                                     paymentItem.APDocumentPaymentAmount,
        //                                                     0,
        //                                                     0,
        //                                                     paymentItem.APPurchaseOrderDate,
        //                                                     DateTime.MinValue,
        //                                                     POInfo.APPurchaseOrderNo,
        //                                                     CommonLocalizedResources.Debit);
        //            objPaymentsInfo.ReportObjectType = ReportRP098ObjectType.SupplierPayment.ToString();
        //            objPaymentsInfo.APPurchaseOrderID = paymentItem.APPurchaseOrderID;
        //            extraList.Add(objPaymentsInfo);
        //            paymentAmount += paymentItem.APDocumentPaymentAmount;
        //        }

        //        POInfo.ReportPaidAmount = paymentAmount;
        //        POInfo.ReportTotalAmount = POInfo.APPurchaseOrderTotalCost;
        //        POInfo.ReportBalanceDueAmount = depositAmount + invoiceInAmount - paymentAmount;
        //        POInfo.ReportReferencesNo = POInfo.APPurchaseOrderNo;
        //        POInfo.ReportObjectType = ReportRP098ObjectType.PurchaseOrder.ToString();
        //        POInfo.ReportDocumentType = " PO";
        //    }
        //    purchaseOrdersList.AddRange(extraList);
        //    return purchaseOrdersList;
        //}
    }
}
