using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt
{
    public partial class guiReceiptHistory : BOSERPScreen
    {
        public guiReceiptHistory()
        {
            InitializeComponent();
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

        private void guiReceiptHistory_Load(object sender, EventArgs e)
        {
            // Initialize controls
            InitializeControls(Controls);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
