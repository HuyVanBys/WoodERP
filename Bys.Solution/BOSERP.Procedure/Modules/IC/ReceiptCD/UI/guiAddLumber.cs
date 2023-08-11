using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ReceiptCD

{
    public partial class guiAddLumber : BOSERPScreen
    {
        public decimal Qty = 0;
        //public string SerialPrefix = string.Empty;
        public guiAddLumber()
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
            //decimal.TryParse(fld_txtICReceiptCDHeight.Text.ToString(), out Length);
            //decimal.TryParse(fld_txtICReceiptCDWidth.Text.ToString(), out Width);
            decimal.TryParse(fld_txtICReceiptCDQty.Text.ToString(), out Qty);
            //decimal.TryParse(fld_txtSerialNoStart.Text.ToString(), out SerialNoStart );
            //SerialPrefix = fld_txtSerialPrefix.Text.ToString();
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
