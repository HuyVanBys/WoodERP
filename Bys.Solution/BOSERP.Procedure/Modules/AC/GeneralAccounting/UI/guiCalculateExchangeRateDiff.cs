using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class guiCalculateExchangeRateDiff : BOSERPScreen
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

        #endregion

        public guiCalculateExchangeRateDiff()
        {
            InitializeComponent();
        }

        public guiCalculateExchangeRateDiff(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            FromDate = fromDate;
            ToDate = toDate;
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

            DialogResult = DialogResult.OK;
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

        private void guiCalculateExchangeRateDiff_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = FromDate;
            fld_dteToDate.DateTime = ToDate;
        }
    }
}
