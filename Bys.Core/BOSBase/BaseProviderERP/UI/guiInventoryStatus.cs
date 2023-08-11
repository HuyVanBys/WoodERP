using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiInventoryStatus : BOSERPScreen
    {
        public LabelControl LabelStatus;

        public BOSGridControl InventoryStatusGridControl
        {
            get { return fld_dgcInventoryStatus; }
        }

        public guiInventoryStatus()
        {
            InitializeComponent();
            LabelStatus = this.fld_lblStatus;
        }

        private void fld_btnContinue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guiInventoryStatus_Load(object sender, EventArgs e)
        {
            fld_dgcInventoryStatus.Screen = this;
            fld_dgcInventoryStatus.InitializeControl();
        }
    }
}