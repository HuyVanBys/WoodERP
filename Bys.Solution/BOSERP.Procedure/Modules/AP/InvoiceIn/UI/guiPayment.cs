using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public partial class guiPayment : BOSERPScreen
    {
        public BOSList<APClearingDetailsInfo> ListPaymentSave { get; set; }
        public guiPayment()
        {
            InitializeComponent();
            ListPaymentSave = new BOSList<APClearingDetailsInfo>();
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            InvoiceInEntities entity = (InvoiceInEntities)((InvoiceInModule)this.Module).CurrentModuleEntity;
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)entity.MainObject;
            decimal sumTotal = entity.PaymentDetailList.Sum(t => t.APClearingDetailAmount);
            decimal depositBalance = 0;
            if (sumTotal > invoice.APInvoiceInTotalCost - invoice.APInvoiceInWaitingPayment)
            {
                MessageBox.Show("Tổng tiền cấn trừ không được lớn hơn tổng tiền của hóa đơn."
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return;
            }
            foreach (APClearingDetailsInfo item in entity.PaymentDetailList)
            {
                if (item.APClearingDetailID >= 0)
                    ListPaymentSave.Add(item);
            }
            depositBalance = entity.PaymentDetailList.Sum(p => p.APClearingDetailAmount);
            invoice.APInvoiceInDepositBalance = depositBalance;

            ((InvoiceInModule)this.Module).UpdateTotalAmountForPayment();
            entity.UpdateMainObject();
            DialogResult = DialogResult.OK;
            ListPaymentSave.SaveItemObjects();
            STModulePostingsController controller = new STModulePostingsController();
            controller.PostedAPClearingDetails(this.Module.Name, invoice.APInvoiceInID, true);
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

            InvoiceInEntities entity = (InvoiceInEntities)((InvoiceInModule)this.Module).CurrentModuleEntity;
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)entity.MainObject;
            APClearingDetailsController objClearingDetailsController = new APClearingDetailsController();
            List<APClearingDetailsInfo> clearingList = objClearingDetailsController.GetClearingDetailFromAPInvoiceInID(invoice.APInvoiceInID);

            entity.PaymentDetailList.InitBOSList(entity,
                                                        TableName.APInvoiceInsTableName,
                                                        TableName.APClearingDetailsTableName,
                                                        BOSList<APClearingDetailsInfo>.cstRelationNone);
            entity.PaymentDetailList.Invalidate(clearingList);
            entity.PaymentDetailList.InitBOSListGridControl(fld_dgcAPClearingDetails);
            entity.PaymentDetailList.GridControl.RefreshDataSource();

            ListPaymentSave.InitBOSList(entity,
                            TableName.APInvoiceInsTableName,
                            TableName.APClearingDetailsTableName,
                            BOSList<APClearingDetailsInfo>.cstRelationNone);

            fld_txtTotalAmount.Text = invoice.APInvoiceInTotalCost.ToString("N2");
            fld_txtPaidAmount.Text = invoice.APInvoiceInDepositBalance.ToString("N2");
            fld_txtWaitingPayment.Text = invoice.APInvoiceInWaitingPayment.ToString("N2");
            fld_txtBalanceDue.Text = (invoice.APInvoiceInTotalCost - invoice.APInvoiceInDepositBalance - invoice.APInvoiceInWaitingPayment).ToString("N2");
        }

        private void fld_btnChooseReceiptVoucher_Click(object sender, EventArgs e)
        {
            InvoiceInEntities entity = (InvoiceInEntities)((InvoiceInModule)this.Module).CurrentModuleEntity;
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)entity.MainObject;

            if ((invoice.APInvoiceInTotalCost - invoice.APInvoiceInDepositBalance - invoice.APInvoiceInWaitingPayment) == 0)
            {
                MessageBox.Show("Hóa đơn đã thanh toán hết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                APClearingDetailsController detailController = new APClearingDetailsController();
                List<APClearingDetailsInfo> detailList = detailController.GetPaymentVoucherForInvoiceClearing(invoice.APInvoiceInID, fld_cedDeposit.Checked, invoice.FK_ACAssObjectID, invoice.APAssObjectType, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

                guiFind<APClearingDetailsInfo> guiChoose = new guiFind<APClearingDetailsInfo>(TableName.APClearingDetailsTableName
                                                                                               , detailList
                                                                                               , this.Module
                                                                                               , true);
            stampp:
                if (guiChoose.ShowDialog() == DialogResult.OK)
                {

                    APClearingDetailsInfo matchDetail;
                    foreach (APClearingDetailsInfo item in guiChoose.SelectedObjects)
                    {
                        if (item.APClearingDetailAmount > item.APClearingDetailCanClearingAmount)
                        {
                            MessageBox.Show(InvoiceInLocalizedResources.ErrorDetailAmount,
                                                  CommonLocalizedResources.MessageBoxDefaultCaption,
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
                            goto stampp;
                        }

                        matchDetail = entity.PaymentDetailList.FirstOrDefault(t => t.APClearingDetailSupplierPaymentNo == item.APClearingDetailSupplierPaymentNo);
                        if (matchDetail == null)
                        {
                            entity.PaymentDetailList.Add(item);
                        }
                    }
                    entity.PaymentDetailList.GridControl.RefreshDataSource();
                }
            }
        }
    }
}
