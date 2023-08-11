using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.POS
{
    public enum IssueGiftVoucherMode { Create, View }

    public partial class guiIssueGiftVoucher : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the mode of the screen, indicates whether
        /// the user is creating or viewing gift vouchers
        /// </summary>
        private IssueGiftVoucherMode Mode;

        public guiIssueGiftVoucher()
        {
            InitializeComponent();
        }

        public guiIssueGiftVoucher(IssueGiftVoucherMode mode)
        {
            InitializeComponent();

            Mode = mode;
            if (mode == IssueGiftVoucherMode.Create)
            {
                fld_btnOK.Text = POSLocalizedResources.OK;
            }
            else if (mode == IssueGiftVoucherMode.View)
            {
                fld_btnOK.Text = POSLocalizedResources.Save;
            }
        }

        private void guiIssueGiftVoucher_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (Mode == IssueGiftVoucherMode.View)
            {
                ((POSModule)Module).UpdateGiftVoucher();
            }
            else if (Mode == IssueGiftVoucherMode.Create)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}