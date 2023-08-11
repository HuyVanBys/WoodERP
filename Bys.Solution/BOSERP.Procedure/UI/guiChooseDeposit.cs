using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSCommon;
using BOSLib;
using Localization;

namespace BOSERP
{
    public partial class guiChooseDeposit : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the associated deposit list
        /// </summary>
        public BOSList<ARCustomerPaymentsInfo> DepositList { get; set; }

        public guiChooseDeposit()
        {
            InitializeComponent();
            DepositList = new BOSList<ARCustomerPaymentsInfo>(TableName.ARCustomerPaymentsTableName);
        }

        public guiChooseDeposit(int customerID)
        {
            InitializeComponent();

            DepositList = new BOSList<ARCustomerPaymentsInfo>(TableName.ARCustomerPaymentsTableName);
            fld_lkeARCustomerID.EditValue = customerID;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            if (!DepositList.Exists(cp => cp.Selected == true))
            {
                MessageBox.Show(CommonLocalizedResources.ChooseDepositMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            ShowDeposits();
        }

        /// <summary>
        /// Show deposits based on search criteria
        /// </summary>
        public void ShowDeposits()
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            List<ARCustomerPaymentsInfo> customerPayments = objCustomerPaymentsController.GetPaymentList(
                                                                                                    fld_txtARSaleOrderNo.Text,
                                                                                                    Convert.ToInt32(fld_lkeARCustomerID.EditValue),
                                                                                                    CustomerPaymentType.Deposit.ToString(),
                                                                                                    fld_dteCustomerPaymentDateFrom.DateTime,
                                                                                                    fld_dteCustomerPaymentDateTo.DateTime);
            DepositList.Invalidate(customerPayments);
            fld_dgcDeposits.DataSource = DepositList;
            fld_dgcDeposits.RefreshDataSource();                        
        }

        private void guiChooseDeposit_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteCustomerPaymentDateFrom.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteCustomerPaymentDateTo.DateTime = BOSUtil.GetMonthEndDate();

            ShowDeposits();
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
