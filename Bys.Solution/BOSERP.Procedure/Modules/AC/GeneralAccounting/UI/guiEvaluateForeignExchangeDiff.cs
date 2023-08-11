using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class guiEvaluateForeignExchangeDiff : BOSERPScreen
    {
        #region Properties
        /// <summary>
        /// Gets or sets the start date of a fiscal year
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of a fiscal year
        /// </summary>
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Gets or sets the currency id for revaluation
        /// </summary>
        public int CurrencyID { get; set; }

        /// <summary>
        /// Gets or sets the exchange rate for revaluation
        /// </summary>
        public decimal ExchangeRate { get; set; }
        /// <summary>
        /// A variable to store the selected accounts
        /// </summary>
        public bool ByObject { get; set; }
        /// <summary>
        /// A variable to store the selected accounts
        /// </summary>
        public bool ByInvoice { get; set; }
        public int EvaluateType { get; set; }

        public List<ACAccountsInfo> SelectedAccountList { get; set; }
        #endregion

        public guiEvaluateForeignExchangeDiff()
        {
            InitializeComponent();
        }

        public guiEvaluateForeignExchangeDiff(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            InitAccounts();
            FromDate = fromDate;
            ToDate = toDate;
            ByObject = false;
            ByInvoice = false;
            EvaluateType = 0;
            fld_cmEvaluateType.SelectedIndex = 0;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            if (currencyID == 0)
            {
                MessageBox.Show(
                             GeneralAccountingLocalizedResources.CurrencyIsRequiredMessage,
                             CommonLocalizedResources.MessageBoxDefaultCaption,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return;
            }

            FromDate = fld_dteFromDate.DateTime;
            ToDate = fld_dteToDate.DateTime;
            CurrencyID = currencyID;
            ExchangeRate = Convert.ToDecimal(fld_txtExchangeRate.Text);
            ByObject = fld_chkObject.Checked;
            ByInvoice = fld_chkInvoice.Checked;
            EvaluateType = fld_cmEvaluateType.SelectedIndex;
            SelectedAccountList = SelectedAccountList.Where(a => a.Selected).ToList();
            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// Init available accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            SelectedAccountList = objAccountsController.GetAccountsForEvaluatingExchangeRateDiff();
            fld_dgcACRP060Accounts.DataSource = SelectedAccountList;
        }
        /// <summary>
        /// Init available accounts for the report
        /// </summary>
        public void InitPurchaseAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            SelectedAccountList = objAccountsController.GetSubAccountsByAccountNo("1112");
            SelectedAccountList.AddRange(objAccountsController.GetSubAccountsByAccountNo("1122"));
            SelectedAccountList.AddRange(objAccountsController.GetSubAccountsByAccountNo("3312"));
            fld_dgcACRP060Accounts.DataSource = SelectedAccountList;
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

        private void guiEvaluateForeignExchangeDiff_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = FromDate;
            fld_dteToDate.DateTime = ToDate;
        }

        private void fld_cmbInventoryType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fld_chkSellectAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSellectAllAccount.Checked);
            fld_dgcACRP060Accounts.RefreshDataSource();
        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcACRP060Accounts.MainView;
            List<ACAccountsInfo> listView = new List<ACAccountsInfo>();

            List<ACAccountsInfo> objects = new List<ACAccountsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                ACAccountsInfo obj = (ACAccountsInfo)gridView.GetRow(j);
                if (obj != null)
                {
                    objects.Add(obj);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    ACAccountsInfo obj = (ACAccountsInfo)gridView.GetRow(j);
                    if (obj != null)
                    {
                        listView.Add(obj);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
        }
    }
}
