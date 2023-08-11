using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationStandard.UI
{
    /// <summary>
    /// Summary description for DMHRES100
    /// </summary>
    public partial class DMHRES100 : BOSERPScreen
    {

        public DMHRES100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREvaluationQuestionID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int questionID = Convert.ToInt32(fld_lkeFK_HREvaluationQuestionID.EditValue);
                if (questionID == -1)
                {
                    ((HREvaluationStandardModule)Module).CreateNewEvaluationQuestion();
                }
                else
                {
                    ((HREvaluationStandardModule)Module).AddItemToStandardQuestionList();
                }
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((HREvaluationStandardModule)Module).SaveStandardQuestion();
        }
    }
}
