using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public partial class guiPayment : BOSERPScreen
    {
        public BOSList<ARClearingDetailsInfo> ListPaymentSave { get; set; }
        public guiPayment()
        {
            InitializeComponent();
            ListPaymentSave = new BOSList<ARClearingDetailsInfo>();
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            InvoiceEntities entity = (InvoiceEntities)((InvoiceModule)this.Module).CurrentModuleEntity;
            ARInvoicesInfo invoice = (ARInvoicesInfo)entity.MainObject;
            decimal sumTotal = entity.PaymentDetailList.Sum(t => t.ARClearingDetailAmount);
            decimal depositBalance = 0;
            if (sumTotal > (invoice.ARInvoiceTotalAmount - invoice.ARInvoiceReceivingAmount))
            {
                MessageBox.Show("Tổng tiền cấn trừ không được lớn hơn tiền còn lại của hóa đơn."
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return;
            }
            foreach (ARClearingDetailsInfo item in entity.PaymentDetailList)
            {
                if (item.ARClearingDetailID >= 0)
                    ListPaymentSave.Add(item);
            }
            depositBalance = entity.PaymentDetailList.Sum(p => p.ARClearingDetailAmount);
            invoice.ARInvoiceDepositBalance = depositBalance;

            ((InvoiceModule)this.Module).UpdateTotalAmountForPayment();
            entity.UpdateMainObject();
            DialogResult = DialogResult.OK;
            ListPaymentSave.SaveItemObjects();
            STModulePostingsController controller = new STModulePostingsController();
            controller.PostedARClearingDetails(this.Module.Name, invoice.ARInvoiceID, true);
            Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                InitializeFieldFormat(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiPayment_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            InvoiceEntities entity = (InvoiceEntities)((InvoiceModule)this.Module).CurrentModuleEntity;
            ARInvoicesInfo invoice = (ARInvoicesInfo)entity.MainObject;
            ARClearingDetailsController detailController = new ARClearingDetailsController();
            List<ARClearingDetailsInfo> detailList = detailController.GetClearingDetailFromARInvoiceID(invoice.ARInvoiceID);

            entity.PaymentDetailList.InitBOSList(entity,
                                                        TableName.ARInvoicesTableName,
                                                        TableName.ARClearingDetailsTableName,
                                                        BOSList<ARClearingDetailsInfo>.cstRelationNone);
            entity.PaymentDetailList.InitBOSListGridControl(fld_dgcARClearingDetails);
            entity.PaymentDetailList.Invalidate(detailList);
            entity.PaymentDetailList.GridControl.RefreshDataSource();

            ListPaymentSave.InitBOSList(entity,
                            TableName.ARInvoicesTableName,
                            TableName.ARClearingDetailsTableName,
                            BOSList<ARClearingDetailsInfo>.cstRelationNone);

            fld_txtTotalAmount.Text = invoice.ARInvoiceTotalAmount.ToString("N3");
            fld_txtPaidAmount.Text = invoice.ARInvoiceDepositBalance.ToString("N3");
            fld_txtWaitingPayment.Text = invoice.ARInvoiceReceivingAmount.ToString("N3");
            fld_txtBalanceDue.Text = (invoice.ARInvoiceTotalAmount - invoice.ARInvoiceDepositBalance - invoice.ARInvoiceReceivingAmount).ToString("N3");
        }

        private void fld_btnChooseReceiptVoucher_Click(object sender, EventArgs e)
        {
            InvoiceEntities entity = (InvoiceEntities)((InvoiceModule)this.Module).CurrentModuleEntity;
            ARInvoicesInfo invoice = (ARInvoicesInfo)entity.MainObject;

            if ((invoice.ARInvoiceTotalAmount - invoice.ARInvoiceDepositBalance - invoice.ARInvoiceReceivingAmount) == 0)
            {
                MessageBox.Show("Hóa đơn đã thanh toán hết."
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);

            }
            else
            {
                ARClearingDetailsController detailController = new ARClearingDetailsController();
                List<ARClearingDetailsInfo> detailList = detailController.GetReceiptVoucherForInvoiceClearing(invoice.ARInvoiceID, fld_cedDeposit.Checked, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                guiFind<ARClearingDetailsInfo> guiChoose = new guiFind<ARClearingDetailsInfo>(TableName.ARClearingDetailsTableName
                                                                                                                       , detailList
                                                                                                                       , this.Module
                                                                                                                       , true);
            stampp:
                if (guiChoose.ShowDialog() == DialogResult.OK)
                {
                    ARClearingDetailsInfo detail;
                    ARClearingDetailsInfo matchDetail;
                    foreach (ARClearingDetailsInfo item in guiChoose.SelectedObjects)
                    {
                        if (item.ARClearingDetailAmount > item.ARClearingDetailCanClearingAmount)
                        {
                            MessageBox.Show(InvoiceInLocalizedResources.ErrorDetailAmount,
                                                  CommonLocalizedResources.MessageBoxDefaultCaption,
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
                            goto stampp;
                        }
                        detail = new ARClearingDetailsInfo();
                        BOSUtil.CopyObject(item, detail);

                        matchDetail = entity.PaymentDetailList.FirstOrDefault(t => t.ARClearingDetailCustomerPaymentNo == detail.ARClearingDetailCustomerPaymentNo
                                                                                && t.FK_ARSaleOrderID == detail.FK_ARSaleOrderID
                                                                                && t.FK_ARSaleOrderPaymentTimeID == detail.FK_ARSaleOrderPaymentTimeID);
                        if (matchDetail == null)
                        {
                            entity.PaymentDetailList.Add(detail);
                        }
                    }
                    entity.PaymentDetailList.GridControl.RefreshDataSource();
                }
            }
        }
    }
}
