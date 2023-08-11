using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public partial class guiPrintInventoryPackageBarcode : BOSERPScreen
    {
        public guiPrintInventoryPackageBarcode()
        {
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).PrintInventoryItemBarcode();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiPrintInventoryPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.InventoryItemPackageList.InitBOSListGridControl(fld_dgcICInventoryItemPackages);
            SearchPackages();
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SearchPackages();
        }

        private void SearchPackages()
        {
            int stockID = fld_lkeFK_ICStockID2.EditValue != null
                    ? Convert.ToInt32(fld_lkeFK_ICStockID2.EditValue)
                    : 0;
            int serieID = fld_lkeFK_ICProductSerieID.EditValue != null
                    ? Convert.ToInt32(fld_lkeFK_ICProductSerieID.EditValue)
                    : 0;
            int productID = fld_lkeFK_ICProductID2.EditValue != null
                    ? Convert.ToInt32(fld_lkeFK_ICProductID2.EditValue)
                    : 0;
            ((PurchaseReceiptModule)Module).SearchInventoryItemPackagesForPrinting(stockID, serieID, productID);
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            ((PurchaseReceiptModule)Module).SelectAllPrintedPackages(selectAllCheckEdit.Checked);
        }
    }
}
