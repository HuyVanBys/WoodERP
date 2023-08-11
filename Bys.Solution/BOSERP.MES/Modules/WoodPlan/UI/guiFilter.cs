using System;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan

{
    public partial class guiFilter : BOSERPScreen
    {
        public decimal Height = 0;
        public guiFilter()
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
            DialogResult = DialogResult.OK;
            decimal.TryParse(fld_txtHeight.Text.ToString(), out Height);
            //decimal.TryParse(fld_txtICReceiptCDWidth.Text.ToString(), out Width);
            // decimal.TryParse(fld_txtICReceiptCDQty.Text.ToString(), out Qty);
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
