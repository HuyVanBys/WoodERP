using BOSCommon;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP077 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP077()
        {
            InitializeComponent();
            CenterToScreen();
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

                    fld_dgcRP077APPurchaseOrders.ExportToXlsx(fileName);
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
        public void GetDataSearch()
        {
            //int supplierID = 0;
            //int.TryParse(fld_lkeFK_APSupplierID.EditValue.ToString(), out supplierID);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }

            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            List<APPurchaseOrdersInfo> purchaseOrdersList = objReportsController.GetPurchaseOrderForPurchaseOrderListReport(objectID, objectType, searchFromDate, searchToDate, branchID);

            List<APPurchaseOrdersInfo> extraList = new List<APPurchaseOrdersInfo>();
            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();

            //Get Supplier Payment & Invoice In
            foreach (APPurchaseOrdersInfo POInfo in purchaseOrdersList)
            {
                decimal paymentAmount = 0;
                decimal invoiceInAmount = 0;
                decimal depositAmount = 0;
                //Deposit
                APPurchaseOrderPaymentTimesInfo objPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)objReportsController.GetPaymentTimeBySomeConditions(POInfo.APPurchaseOrderID, PurchaseOrderPaymentTimePaymentType.Deposit.ToString(), searchFromDate, searchToDate).FirstOrDefault();
                if (objPaymentTimesInfo != null)
                {
                    APPurchaseOrdersInfo objDepositsInfo = new APPurchaseOrdersInfo();
                    objDepositsInfo = ConvertToPurchaseOrder(PurchaseOrderPaymentTimePaymentType.Deposit.ToString(),
                                                             objPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeDepositBalance,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue,
                                                             objPaymentTimesInfo.APPurchaseOrderPaymentTimeDate,
                                                             objPaymentTimesInfo.ARSaleOrderPaymentTimeDueDate,
                                                             POInfo.APPurchaseOrderNo,
                                                             ReportLocalizedResources.Credit);
                    //Left amount : còn lại; balanceDueAmount : đợt thanh toán kế tiếp
                    objDepositsInfo.ReportLeftAmount = objDepositsInfo.ReportBalanceDueAmount;
                    objDepositsInfo.ReportBalanceDueAmount = 0;
                    if (objPaymentTimesInfo.APPurchaseOrderPaymentTimeStatus == PurchaseOrderPaymentTimeStatus.Canceled.ToString())
                    {
                        depositAmount = 0;
                    }
                    else
                    {
                        depositAmount = objPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue;
                    }

                    if (depositAmount == 0)
                    {
                        depositAmount = objPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount;
                    }
                    objDepositsInfo.ReportObjectType = ReportRP077ObjectType.PurchaseOrder.ToString();
                    extraList.Add(objDepositsInfo);
                }
                //Invoice In
                List<APPOPaymentTimeInvoiceInDetailsInfo> InvoiceInList = objReportsController.GetPaymentTimeInvoiceInDetailBySomeConditions(POInfo.APPurchaseOrderID, searchFromDate, searchToDate);
                foreach (APPOPaymentTimeInvoiceInDetailsInfo item in InvoiceInList)
                {
                    APPurchaseOrdersInfo objInvoiceInsInfo = new APPurchaseOrdersInfo();
                    objInvoiceInsInfo = ConvertToPurchaseOrder(item.APInvoiceInNo,
                                                             item.APPOPaymentTimeInvoiceInDetailAmount,
                                                             0,
                                                             0,
                                                             item.APPOPaymentTimeInvoiceInDetailDate,
                                                             item.APPOPaymentTimeInvoiceInDetailEndDate,
                                                             POInfo.APPurchaseOrderNo,
                                                             ReportLocalizedResources.Credit);
                    objInvoiceInsInfo.ReportObjectType = ReportRP077ObjectType.InvoiceIn.ToString();
                    extraList.Add(objInvoiceInsInfo);
                    invoiceInAmount += item.APPOPaymentTimeInvoiceInDetailAmount;
                }
                //Supplier Payment 
                List<APPurchaseOrdersInfo> supplierPaymentList = objReportsController.GetPaymentInfoFromPurchaseOrderNo(POInfo.APPurchaseOrderNo, searchFromDate, searchToDate);
                foreach (APPurchaseOrdersInfo paymentItem in supplierPaymentList)
                {
                    APPurchaseOrdersInfo objPaymentsInfo = new APPurchaseOrdersInfo();
                    objPaymentsInfo = ConvertToPurchaseOrder(paymentItem.APSupplierPaymentNo,
                                                             paymentItem.APDocumentPaymentAmount,
                                                             0,
                                                             0,
                                                             paymentItem.APPurchaseOrderDate,
                                                             DateTime.MinValue,
                                                             POInfo.APPurchaseOrderNo,
                                                             ReportLocalizedResources.Debit);
                    objPaymentsInfo.ReportObjectType = ReportRP077ObjectType.SupplierPayment.ToString();
                    objPaymentsInfo.APPurchaseOrderID = paymentItem.APPurchaseOrderID;
                    extraList.Add(objPaymentsInfo);
                    paymentAmount += paymentItem.APDocumentPaymentAmount;
                }

                POInfo.ReportPaidAmount = paymentAmount;
                POInfo.ReportTotalAmount = POInfo.APPurchaseOrderTotalCost;
                //POInfo.ReportBalanceDueAmount = depositAmount + invoiceInAmount - paymentAmount;
                List<APPurchaseOrderPaymentTimesInfo> purchaseOrderPaymentTimesList
                    = objPurchaseOrderPaymentTimesController.GetByPurchaeOrderIDAndPaymentType(POInfo.APPurchaseOrderID, PurchaseOrderPaymentTimePaymentType.Payment.ToString());
                decimal percentPayment = 0;
                if (purchaseOrderPaymentTimesList != null && purchaseOrderPaymentTimesList.Count > 0)
                {
                    APPurchaseOrderPaymentTimesInfo objPaymentsInfo = purchaseOrderPaymentTimesList.FirstOrDefault();
                    if (objPaymentsInfo != null && POInfo.APPurchaseOrderTotalCost != 0)
                    {
                        percentPayment = objPaymentsInfo.APPurchaseOrderPaymentTimeAmount / POInfo.APPurchaseOrderTotalCost;
                    }
                }
                if (invoiceInAmount > 0)
                {
                    POInfo.ReportBalanceDueAmount = (invoiceInAmount * percentPayment) - (paymentAmount - depositAmount);
                }
                else
                {
                    POInfo.ReportBalanceDueAmount = -paymentAmount;
                }
                POInfo.ReportReferencesNo = POInfo.APPurchaseOrderNo;
                POInfo.ReportObjectType = ReportRP077ObjectType.PurchaseOrder.ToString();
                POInfo.ReportDocumentType = " PO";
                POInfo.ReportLeftAmount = POInfo.ReportTotalAmount - POInfo.ReportPaidAmount;
            }
            purchaseOrdersList.AddRange(extraList);
            fld_dgcRP077APPurchaseOrders.DataSource = purchaseOrdersList;
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

    }
}
