using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRTimeSheetAudit
{
    public partial class guiSetTimeSheetAuditParam : BOSERPScreen
    {
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public guiSetTimeSheetAuditParam()
        {
            InitializeComponent();
        }

        private void guiSetTimeSheetAuditParam_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = Fromdate;
            fld_dteToDate.DateTime = Todate;
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnSet_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            int paramID = Convert.ToInt32(fld_lkeHRTimeSheetParamID.EditValue);
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ((HRTimeSheetAuditModule)Module).SetTimeSheetAuditParam(employeeID, paramID, fromDate, toDate, bosCheckEdit1.Checked);
        }
    }
}
