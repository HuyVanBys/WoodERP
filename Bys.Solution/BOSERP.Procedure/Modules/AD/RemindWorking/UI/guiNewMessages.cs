using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.RemindWorking
{
    public partial class guiNewMessages : BOSERPScreen
    {
        public guiNewMessages(List<ARSaleOrderItemsInfo> saleOrderItemList)
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

        private void guiNewMessages_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnSentMessages_Click(object sender, EventArgs e)
        {

        }
    }
}
