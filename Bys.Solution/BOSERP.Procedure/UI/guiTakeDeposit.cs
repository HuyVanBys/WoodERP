using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiTakeDeposit : BOSERPScreen
    {
        /// <summary>
        /// Variable is used to store the passed-in sale order associating with the deposit
        /// </summary>
        private ARSaleOrdersInfo SaleOrder;

        /// <summary>
        /// Gets or sets the deposit object
        /// </summary>
        public ARCustomerPaymentsInfo CustomerPayment { get; set; }

        public guiTakeDeposit()
        {
            InitializeComponent();
        }

        public guiTakeDeposit(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            InitializeComponent();

            SaleOrder = objSaleOrdersInfo;
            CustomerPayment = new ARCustomerPaymentsInfo();
        }

        public guiTakeDeposit(ARSaleOrdersInfo objSaleOrdersInfo, ARCustomerPaymentsInfo customerPayment)
        {
            InitializeComponent();

            objSaleOrdersInfo.ARSaleOrderDepositBalance -= customerPayment.ARCustomerPaymentTotalAmount;
            objSaleOrdersInfo.ARSaleOrderBalanceDue += customerPayment.ARCustomerPaymentTotalAmount;
            SaleOrder = objSaleOrdersInfo;
            CustomerPayment = customerPayment;
        }

        /// <summary>
        /// Init screen for displaying
        /// </summary>
        private void InitScreen()
        {
            fld_lblTotalAmount.Text = BOSUtil.GetNumberDisplayFormat(SaleOrder.ARSaleOrderTotalAmount);
            fld_lblBalanceDue.Text = BOSUtil.GetNumberDisplayFormat(SaleOrder.ARSaleOrderBalanceDue);
            fld_lblDepositBalance.Text = BOSUtil.GetNumberDisplayFormat(SaleOrder.ARSaleOrderTotalAmount - SaleOrder.ARSaleOrderBalanceDue);
            if (SaleOrder.ARSaleOrderDepositBalance > 0)
            {
                fld_lblMinimumDepositTitle.Visible = false;
                fld_lblMinimumDeposit.Visible = false;
            }
            else
            {
                //Get initial deposit from ADConfigValues
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SaleOrderInitialDeposit.ToString());
                decimal initialPercent = Convert.ToDecimal(objConfigValuesInfo.ADConfigKeyValue);
                fld_lblMinimumDeposit.Text = BOSUtil.GetNumberDisplayFormat(SaleOrder.ARSaleOrderBalanceDue * initialPercent / 100);
                fld_txtPaymentAmount.Text = fld_lblMinimumDeposit.Text;
            }

            fld_dtePaymentDate.DateTime = DateTime.Now;
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(SaleOrder.FK_ARCustomerID);
            if (customer != null)
            {
                fld_medPaymentDesc.Text = string.Format(CommonLocalizedResources.TakeDepositDefaultDesc,
                                                        customer.ARCustomerName,
                                                        SaleOrder.ARSaleOrderNo);
            }

            fld_txtPaymentAmount.Focus();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fld_txtPaymentAmount.Text))
            {
                decimal paymentAmount = Convert.ToDecimal(fld_txtPaymentAmount.Text);
                if (fld_lblMinimumDeposit.Visible)
                {
                    decimal minimumDeposit = Convert.ToDecimal(fld_lblMinimumDeposit.Text);
                    if (paymentAmount < minimumDeposit)
                    {
                        MessageBox.Show(CommonLocalizedResources.PaymentAmountMustBeGreaterThanMinimumDepositMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (paymentAmount > SaleOrder.ARSaleOrderBalanceDue)
                {
                    paymentAmount = SaleOrder.ARSaleOrderBalanceDue;
                }
                CustomerPayment.ARCustomerPaymentTotalAmount = paymentAmount;
                CustomerPayment.ARCustomerPaymentDate = fld_dtePaymentDate.DateTime;
                CustomerPayment.ARCustomerPaymentDesc = fld_medPaymentDesc.Text;
                CustomerPayment.FK_CSCompanyBankID = Convert.ToInt32(fld_lkeBankID.EditValue);
                CustomerPayment.ARCustomerPaymentBankAccount = fld_txtBankAccount.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(CommonLocalizedResources.PaymentAmountIsRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int bankID = Convert.ToInt32(e.Value);
                CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                CSCompanyBanksInfo bank = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
                if (bank != null)
                {
                    fld_txtBankAccount.Text = bank.CSCompanyBankAccount;
                }
            }
        }

        private void guiTakeDeposit_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            InitScreen();

            if (CustomerPayment.ARCustomerPaymentID > 0)
            {
                fld_txtPaymentAmount.Text = CustomerPayment.ARCustomerPaymentTotalAmount.ToString();
                fld_dtePaymentDate.DateTime = CustomerPayment.ARCustomerPaymentDate;
                fld_medPaymentDesc.Text = CustomerPayment.ARCustomerPaymentDesc;
                fld_lkeBankID.EditValue = CustomerPayment.FK_CSCompanyBankID;
                fld_txtBankAccount.Text = CustomerPayment.ARCustomerPaymentBankAccount;
            }
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
    }
}