using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationStandard
{
    public partial class guiCreateEvaluationQuestion : BOSERPScreen
    {
        /// <summary>
        /// Get or set valuation question description
        /// </summary>
        public string HREvaluationQuestionDesc { get; set; }

        public guiCreateEvaluationQuestion()
        {
            InitializeComponent();
        }

        public guiCreateEvaluationQuestion(int evaluationQuestionID, string evaluationQuestionDesc)
        {
            InitializeComponent();
            fld_txtHREvaluationQuestionDesc.Text = evaluationQuestionDesc;
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            HREvaluationQuestionDesc = fld_txtHREvaluationQuestionDesc.Text.Trim();
            if (string.IsNullOrEmpty(HREvaluationQuestionDesc))
            {
                MessageBox.Show(EvaluationStandardLocalizedResources.SaveErrorDescriptionNullOrEmptyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
