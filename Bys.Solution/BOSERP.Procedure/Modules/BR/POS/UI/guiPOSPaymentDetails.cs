using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.POS
{
    public partial class guiPOSPaymentDetails : BOSERPScreen
    {
        #region Variables
        /// <summary>
        /// A variable to store the payment id
        /// </summary>
        private int InvoiceID;

        /// <summary>
        /// A variable to store the customer id of the payment
        /// </summary>
        private int CustomerID;

        /// <summary>
        /// A variable to store the payment amount
        /// </summary>
        private decimal PaymentAmount;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the detail list of the payment
        /// </summary>
        public BOSList<ARPOSPaymentDetailsInfo> PaymentDetailList { get; set; }

        /// <summary>
        /// Gets or sets a value indicates whether the deposit should be printed out
        /// </summary>
        public bool IsPrinted { get; set; }
        public decimal ReceivingAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        #endregion

        public guiPOSPaymentDetails()
        {
            InitializeComponent();
        }

        public guiPOSPaymentDetails(BaseModule module, int invoiceID, int customerID, decimal paymentAmount, decimal receivingAmount)
        {
            InitializeComponent();
            POSEntities entity = (POSEntities)((BaseModuleERP)module).CurrentModuleEntity;
            InvoiceID = invoiceID;
            CustomerID = customerID;
            PaymentAmount = paymentAmount;
            Module = module;

            fld_lblPaymentAmount.Text = BOSUtil.GetNumberDisplayFormat(paymentAmount);
            fld_txtReceivingAmount.Text = receivingAmount.ToString();
            decimal changeAmount = 0;
            if (!String.IsNullOrEmpty(fld_txtReceivingAmount.Text))
            {
                changeAmount = receivingAmount - PaymentAmount;
            }
            fld_txtChangeAmount.Text = changeAmount.ToString();

            ReceivingAmount = receivingAmount;
            ChangeAmount = ReceivingAmount - PaymentAmount;

            //Init payment method grid
            PaymentDetailList = new BOSList<ARPOSPaymentDetailsInfo>();
            PaymentDetailList.InitBOSList(entity,
                                          TableName.ARInvoicesTableName,
                                          TableName.ARPOSPaymentDetailsTableName,
                                          BOSList<ARPOSPaymentDetailsInfo>.cstRelationForeign);
            InitPaymentMethods();
            fld_dgcPayment.Screen = this;
            fld_dgcPayment.InitializeControl();
            fld_dgcPayment.PaymentAmount = paymentAmount;
            fld_dgcPayment.ProposeRemainingAmount();
            if (invoiceID > 0)
            {
                ARPOSPaymentDetailsController objPOSPaymentDetailsController = new ARPOSPaymentDetailsController();
                PaymentDetailList.BackupList = objPOSPaymentDetailsController.GetDetailsByPaymentID(InvoiceID);
            }
            IsPrinted = false;
        }

        public guiPOSPaymentDetails(BaseModule module, int customerID, decimal paymentAmount)
            : this(module, 0, customerID, paymentAmount, paymentAmount)
        {

        }

        /// <summary>
        /// Init payment methods
        /// </summary>
        public void InitPaymentMethods()
        {
            ARPOSPaymentDetailsController objPOSPaymentDetailsController = new ARPOSPaymentDetailsController();
            List<ARPOSPaymentDetailsInfo> paymentDetailList = new List<ARPOSPaymentDetailsInfo>();
            if (InvoiceID > 0)
            {
                paymentDetailList = objPOSPaymentDetailsController.GetDetailsByPaymentID(InvoiceID);
                List<ARPOSPaymentDetailsInfo> defaultPaymentDetailList = objPOSPaymentDetailsController.GetDefaultPaymentDetails();
                defaultPaymentDetailList = defaultPaymentDetailList.Where(p =>
                                                                  p.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString() ||
                                                                  p.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString() ||
                                                                  p.ARPOSPaymentMethodCombo == PaymentMethod.CreditCard.ToString() ||
                                                                  p.ARPOSPaymentMethodCombo == PaymentMethod.CreditNote.ToString() ||
                                                                  p.ARPOSPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString() ||
                                                                  p.ARPOSPaymentMethodCombo == PaymentMethod.OwingExchange.ToString()).ToList();
                foreach (ARPOSPaymentDetailsInfo item in defaultPaymentDetailList)
                {
                    for (int i = 0; i < paymentDetailList.Count; i++)
                    {
                        if (paymentDetailList[i].ARPOSPaymentMethodCombo == item.ARPOSPaymentMethodCombo)
                        {
                            paymentDetailList[i].ARPaymentMethodDisplayText = item.ARPaymentMethodDisplayText;
                        }
                    }
                }
            }
            else
            {
                paymentDetailList = objPOSPaymentDetailsController.GetDefaultPaymentDetails();
                paymentDetailList = paymentDetailList.Where(p =>
                                      p.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString() ||
                                      p.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString() ||
                                      p.ARPOSPaymentMethodCombo == PaymentMethod.CreditCard.ToString() ||
                                      p.ARPOSPaymentMethodCombo == PaymentMethod.CreditNote.ToString() ||
                                      p.ARPOSPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString() ||
                                      p.ARPOSPaymentMethodCombo == PaymentMethod.OwingExchange.ToString()).ToList();
            }
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            List<ACDocTypeEntrysInfo> entries = objDocTypeEntrysController.GetEntriesByDocumentType(DocumentTypeName.NghiepVuKhac);
            ACDocTypeEntrysInfo voucherTang = entries.Where(p => p.ACEntryTypeName == AccEntryType.ThuPhieuGhiCo.ToString()).FirstOrDefault();
            ACDocTypeEntrysInfo voucherBan = entries.Where(p => p.ACEntryTypeName == AccEntryType.ThuCocBangPhieuGhiCo.ToString()).FirstOrDefault();
            foreach (ARPOSPaymentDetailsInfo item in paymentDetailList)
            {
                if (item.ARPOSPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString())
                {
                    if (voucherTang != null)
                        item.FK_ACAccountID = voucherTang.ACDocTypeEntryAccountDefaultDebit;
                }
                else if (item.ARPOSPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                {
                    if (voucherBan != null)
                        item.FK_ACAccountID = voucherBan.ACDocTypeEntryAccountDefaultDebit;
                }
            }
            PaymentDetailList.Invalidate(paymentDetailList);
            fld_dgcPayment.POSPaymentDetailList = PaymentDetailList;
            fld_dgcPayment.InitGridControlDataSource();
        }

        public ARPOSPaymentDetailsInfo GetCurrentRowData()
        {
            GridView gridView = (GridView)fld_dgcPayment.MainView;
            int index = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
            if (index >= 0)
                return PaymentDetailList[index];
            return null;
        }

        private void fld_btnAcceptPayment_Click(object sender, EventArgs e)
        {
            if (fld_dgcPayment.POSPaymentDetailList.Where(o => o.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString()
                                                            && o.ARPOSPaymentDetailAmount > 0
                                                            && o.FK_CSCashFundID == 0).Count() > 0)
            {
                MessageBox.Show("Thu tiền bằng tiền mặt bắt buộc chọn Quỹ tiền mặt!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (fld_dgcPayment.POSPaymentDetailList.Where(o => o.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()
                                                            && o.ARPOSPaymentDetailAmount > 0
                                                            && o.FK_CSCompanyBankID == 0).Count() > 0)
            {
                MessageBox.Show("Thu tiền bằng chuyển khoản bắt buộc chọn tài khoản ngân hàng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (fld_btnAcceptPayment.Tag.ToString() == "Accept")
            {
                if (POSModule.AcceptPayment(PaymentDetailList, CustomerID, PaymentAmount))
                {
                    //Invalidate controls
                    fld_btnAcceptPayment.Text = CommonLocalizedResources.DiscardPayment;
                    fld_btnAcceptPayment.Tag = "Discard";
                    fld_btnSave.Enabled = true;
                    fld_btnSavePrint.Enabled = true;
                    fld_dgcPayment.Enabled = false;
                }
            }
            else if (fld_btnAcceptPayment.Tag.ToString() == "Discard")
            {
                fld_btnAcceptPayment.Text = CommonLocalizedResources.AcceptPayment;
                fld_btnAcceptPayment.Tag = "Accept";
                fld_btnSave.Enabled = false;
                fld_btnSavePrint.Enabled = false;
                fld_dgcPayment.Enabled = true;
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            IsPrinted = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnSavePrint_Click(object sender, EventArgs e)
        {
            IsPrinted = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_txtReceivingAmount_TextChanged(object sender, EventArgs e)
        {
            decimal changeAmount = 0;
            if (!String.IsNullOrEmpty(fld_txtReceivingAmount.Text))
            {
                decimal receivingAmount = Convert.ToDecimal(fld_txtReceivingAmount.Text);
                ReceivingAmount = receivingAmount;
                changeAmount = receivingAmount - PaymentAmount;
            }
            fld_txtChangeAmount.Text = changeAmount.ToString();
            ChangeAmount = changeAmount;
        }
    }
}