using System;
using System.Windows.Forms;


namespace BOSERP.Modules.HREvaluationStandard
{
    public partial class guiAddEvaluationStandard : BOSERPScreen
    {
        public guiAddEvaluationStandard()
        {
            InitializeComponent();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void guiAddEvaluationStandard_Load(object sender, EventArgs e)
        {
            fld_txtHREvaluationStandardName.Screen = this;
            fld_txtHREvaluationStandardName.InitializeControl();
        }
    }
}
