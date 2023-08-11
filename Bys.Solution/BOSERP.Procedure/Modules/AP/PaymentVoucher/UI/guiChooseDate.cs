using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentVoucher

{
    public partial class guiChooseDate : BOSERPScreen
    {
        public DateTime FromMonth = DateTime.Now;
        public guiChooseDate()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FromMonth = DateTime.Now;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FromMonth = fld_dteICShipmentDate.DateTime;
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
            FromMonth = DateTime.Now;
            fld_dteICShipmentDate.DateTime = DateTime.Now;
        }
    }
}
