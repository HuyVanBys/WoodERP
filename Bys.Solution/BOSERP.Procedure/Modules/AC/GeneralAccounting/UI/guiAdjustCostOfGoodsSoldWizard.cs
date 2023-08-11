using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class guiAdjustCostOfGoodsSoldWizard : BOSERPScreen
    {
        private int CurrentStep = 0;

        /// <summary>
        /// Gets or sets the start date at which documents are processed by this calculation
        /// </summary>
        public DateTime FromDate { get; private set; }

        /// <summary>
        /// Gets or sets the end date at which documents are processed by this calculation
        /// </summary>
        public DateTime ToDate { get; private set; }

        /// <summary>
        /// Gets or sets the adjustment ratio which is a maximum value in percentage that
        /// any differences between the original inventory cost and the adjusted ones must be less than
        /// </summary>
        public decimal AdjustmentRatio { get; private set; }

        public guiAdjustCostOfGoodsSoldWizard()
        {
            InitializeComponent();
        }

        public guiAdjustCostOfGoodsSoldWizard(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            FromDate = fromDate;
            ToDate = toDate;
        }

        private void guiCalculateCostOfGoodSold_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = FromDate;
            fld_dteToDate.DateTime = ToDate;

            (((BaseModuleERP)Module).CurrentModuleEntity as GeneralAccountingEntities).BranchList.InitBOSListGridControl(fld_dgcBranches);
            (((BaseModuleERP)Module).CurrentModuleEntity as GeneralAccountingEntities).ProductSerieList.InitBOSListGridControl(fld_dgcSeries);
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

        /// <summary>
        /// Make the wizard go to the next step from the current one
        /// </summary>
        public void GoToNextStep()
        {
            CurrentStep++;
            GoToStep(CurrentStep);
        }

        /// <summary>
        /// Make the wizard go to the previous step from the current one
        /// </summary>
        public void GoToPreviousStep()
        {
            CurrentStep--;
            GoToStep(CurrentStep);
        }

        /// <summary>
        /// Make the wizard go to a specific step by hiding or displaying appropriate components        
        /// </summary>
        /// <param name="step">Given step to go to</param>
        public void GoToStep(int step)
        {
            fld_pnlWelcome.Visible = false;
            fld_pnlStep1.Visible = false;
            fld_pnlStep2.Visible = false;
            fld_pnlStep3.Visible = false;
            fld_pnlStep4.Visible = false;

            fld_btnBack.Visible = true;
            fld_btnNext.Visible = true;
            fld_btnCancel.Visible = true;

            fld_btnNext.Enabled = true;
            fld_chkViewWrongSeries.Checked = false;

            fld_btnNext.Text = GeneralAccountingLocalizedResources.Next;

            switch (step)
            {
                case 1:
                    fld_pnlStep1.Visible = true;
                    fld_lblWizardTitle.Text = GeneralAccountingLocalizedResources.SpecifyFiscalPeriod;
                    break;
                case 2:
                    fld_pnlStep2.Visible = true;
                    fld_lblWizardTitle.Text = GeneralAccountingLocalizedResources.SpecifyAdjustmentRatio;
                    break;
                case 3:
                    fld_pnlStep3.Visible = true;
                    fld_lblWizardTitle.Text = GeneralAccountingLocalizedResources.SpecifyAdjustedCost;
                    break;
                case 4:
                    fld_pnlStep4.Visible = true;
                    fld_lblWizardTitle.Text = GeneralAccountingLocalizedResources.ChooseBranch;
                    fld_btnNext.Text = GeneralAccountingLocalizedResources.Finish;
                    break;
                default:
                    fld_pnlWelcome.Visible = true;
                    fld_lblWizardTitle.Text = GeneralAccountingLocalizedResources.AdjustCostAtTheEndOfFiscalPeriod;
                    fld_btnBack.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Disable the next step from the current one
        /// </summary>
        public void DisableNextStep()
        {
            fld_btnNext.Enabled = false;
        }

        /// <summary>
        /// Enable the next step from the current one
        /// </summary>
        public void EnableNextStep()
        {
            fld_btnNext.Enabled = true;
        }

        /// <summary>
        /// Finish the wizard
        /// </summary>
        public void Finish()
        {
            fld_btnNext.Enabled = false;
            fld_btnBack.Enabled = false;
            fld_btnCancel.Text = GeneralAccountingLocalizedResources.Close;
        }

        private void fld_btnNext_Click(object sender, EventArgs e)
        {
            FromDate = fld_dteFromDate.DateTime;
            ToDate = fld_dteToDate.DateTime;
            if (string.IsNullOrEmpty(fld_txtAdjustmentRatio.Text))
            {
                AdjustmentRatio = -1;
            }
            else
            {
                AdjustmentRatio = Convert.ToDecimal(fld_txtAdjustmentRatio.Text);
            }

            ((GeneralAccountingModule)Module).ProcessStep(CurrentStep + 1);
        }

        private void fld_btnBack_Click(object sender, EventArgs e)
        {
            GoToPreviousStep();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_chkViewWrongSeries_CheckedChanged(object sender, EventArgs e)
        {
            ((GeneralAccountingModule)Module).ViewWrongSeries(fld_chkViewWrongSeries.Checked, Convert.ToDecimal(fld_txtAdjustmentRatio.Text));
        }
    }
}
