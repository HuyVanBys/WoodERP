using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class guiChooseDate : BOSERPScreen
    {
        public DateTime FromMonth = BOSApp.GetCurrentServerDate();
        public guiChooseDate()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FromMonth = BOSApp.GetCurrentServerDate();
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FromMonth = fld_dteClosingDate.DateTime;
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
            FromMonth = BOSApp.GetCurrentServerDate();
            fld_dteClosingDate.DateTime = BOSApp.GetCurrentServerDate();
        }
    }
}
