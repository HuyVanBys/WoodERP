using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiPaymentDetails : BOSERPScreen
    {
        #region Variables
        /// <summary>
        /// A variable to store the payment id
        /// </summary>
        private int CustomerPaymentID;

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
        public BOSList<ARCustomerPaymentDetailsInfo> PaymentDetailList { get; set; }

        /// <summary>
        /// Gets or sets a value indicates whether the deposit should be printed out
        /// </summary>
        public bool IsPrinted { get; set; }
        #endregion

        public guiPaymentDetails()
        {
            InitializeComponent();
        }

        public guiPaymentDetails(BaseModule module, int customerPaymentID, int customerID, decimal paymentAmount)
        {
            InitializeComponent();

            CustomerPaymentID = customerPaymentID;
            CustomerID = customerID;
            PaymentAmount = paymentAmount;
            Module = module;

            fld_lblPaymentAmount.Text = BOSUtil.GetNumberDisplayFormat(paymentAmount);
            fld_txtReceivingAmount.Text = paymentAmount.ToString();

            //Init payment method grid
            PaymentDetailList = new BOSList<ARCustomerPaymentDetailsInfo>();
            InitPaymentMethods();
            fld_dgcPayment.Screen = this;
            fld_dgcPayment.InitializeControl();
            fld_dgcPayment.PaymentAmount = paymentAmount;
            fld_dgcPayment.ProposeRemainingAmount();
            if (customerPaymentID > 0)
            {
                ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
                PaymentDetailList.BackupList = objCustomerPaymentDetailsController.GetDetailsByPaymentID(CustomerPaymentID);
            }
            IsPrinted = false;
        }

        public guiPaymentDetails(BaseModule module, int customerID, decimal paymentAmount)
            : this(module, 0, customerID, paymentAmount)
        {

        }

        /// <summary>
        /// Init payment methods
        /// </summary>
        public void InitPaymentMethods()
        {

            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            List<ARCustomerPaymentDetailsInfo> paymentDetailList = new List<ARCustomerPaymentDetailsInfo>();
            if (CustomerPaymentID > 0)
            {
                paymentDetailList = objCustomerPaymentDetailsController.GetDetailsByPaymentID(CustomerPaymentID);
            }
            else
            {
                paymentDetailList = objCustomerPaymentDetailsController.GetDefaultPaymentDetails();
                paymentDetailList = paymentDetailList.Where(p =>
                                      p.ARPaymentMethodCombo == PaymentMethod.Cash.ToString() ||
                                      p.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString() ||
                                      p.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString() ||
                                      p.ARPaymentMethodCombo == PaymentMethod.CreditNote.ToString() ||
                                      p.ARPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString() ||
                                      p.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString() ||
                                      p.ARPaymentMethodCombo == PaymentMethod.DepositTransfer.ToString()).ToList();
            }
            PaymentDetailList.Invalidate(paymentDetailList);
            fld_dgcPayment.CustomerPaymentDetailList = PaymentDetailList;
            fld_dgcPayment.InitGridControlDataSource();
        }

        public ARCustomerPaymentDetailsInfo GetCurrentRowData()
        {
            GridView gridView = (GridView)fld_dgcPayment.MainView;
            int index = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
            if (index >= 0)
                return PaymentDetailList[index];
            return null;
        }

        private void fld_btnAcceptPayment_Click(object sender, EventArgs e)
        {
            if (fld_btnAcceptPayment.Tag.ToString() == "Accept")
            {
                if (Modules.CustomerPayment.CustomerPaymentModule.AcceptPayment(PaymentDetailList, CustomerID, PaymentAmount))
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
                changeAmount = receivingAmount - PaymentAmount;
            }
            fld_txtChangeAmount.Text = changeAmount.ToString();
        }
    }
}