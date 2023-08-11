using BOSERP.Procedure.Modules.IC.SemiProductReceipt.ImportInfo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public partial class guiImportReceiptItem : BOSERPScreen
    {
        List<IPReceiptItemsInfo> ReceiptItemList { get; set; }

        public guiImportReceiptItem(List<IPReceiptItemsInfo> receiptItemList)
        {
            InitializeComponent();
            ReceiptItemList = receiptItemList;
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
            this.Close();
        }

        private void guiPrintInventoryPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnApprove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
