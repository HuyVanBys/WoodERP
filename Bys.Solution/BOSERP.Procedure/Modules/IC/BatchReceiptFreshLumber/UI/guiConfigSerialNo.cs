using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptFreshLumber
{
    public partial class guiConfigSerialNo : BOSERPScreen
    {
        public guiConfigSerialNo()
        {
            InitializeComponent();
        }
        private void guiCommission_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}