using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public partial class guiPrintQRCode : BOSERPScreen
    {
        private List<ICReceiptItemsInfo> ReceiptItemList { get; set; }

        public List<ICReceiptItemsInfo> SelectedObjects { get; set; }

        public guiPrintQRCode(List<ICReceiptItemsInfo> receiptItemList)
        {
            InitializeComponent();
            ReceiptItemList = receiptItemList.Select(o => o.Clone() as ICReceiptItemsInfo).ToList();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            SelectedObjects = ReceiptItemList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiPrintInventoryPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcPrintQRCodeGridControl.DataSource = ReceiptItemList;
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

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            bool isCheckAll = fld_chkSellectAll.EditValue == null ? false : (bool)fld_chkSellectAll.EditValue;
            ReceiptItemList.ForEach(o => o.Selected = isCheckAll);
            fld_dgcPrintQRCodeGridControl.RefreshDataSource();
        }
    }
}
