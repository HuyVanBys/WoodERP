using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ReceiptCD

{
    public partial class guiChooseDate : BOSERPScreen
    {
        public DateTime FromDate = DateTime.Now;
        public DateTime ToDate = DateTime.Now;
        public guiChooseDate()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FromDate = DateTime.Now.AddMonths(-1);
            ToDate = DateTime.Now;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FromDate = fld_dteICShipmentDate.DateTime;
            ToDate = fld_dteICShipmentDateTo.DateTime;
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
            FromDate = DateTime.Now.AddMonths(-1);
            ToDate = DateTime.Now;
            fld_dteICShipmentDate.DateTime = FromDate;
            fld_dteICShipmentDateTo.DateTime = ToDate;
        }
    }
}
