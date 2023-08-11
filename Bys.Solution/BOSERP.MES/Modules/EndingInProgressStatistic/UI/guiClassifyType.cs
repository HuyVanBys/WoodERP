using System;
using System.Windows.Forms;

namespace BOSERP.Modules.EndingInProgressStatistic
{
    public partial class guiClassifyType : BOSERPScreen
    {
        public string ProgressClassifyType = string.Empty;
        public guiClassifyType()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            string value = fld_lkeProductionCostInProgressClassifyType.EditValue != null ? fld_lkeProductionCostInProgressClassifyType.EditValue.ToString() : "";
            if (string.IsNullOrEmpty(value))
            {
                BOSApp.ShowMessage("Vui lòng chọn loại dở dang!");
                return;
            }
            ProgressClassifyType = value;
            DialogResult = DialogResult.OK;
            Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                InitializeFieldFormat(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChooseDate_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }
    }
}
