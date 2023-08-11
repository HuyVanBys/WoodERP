using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStockCount
{
    public partial class guiPrintQRCode : BOSERPScreen
    {
        public string PrintQCodeType { get; set; }
        public guiPrintQRCode()
        {
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            ((InventoryStockCountModule)Module).PrintQRcode(PrintQCodeType);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiPrintInventoryPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InventoryStockCountEntities entity = (InventoryStockCountEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            fld_dgcPrintQRCodeGridControl.DataSource = entity.PrintQCodeItemsList;
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
            InventoryStockCountEntities entity = (InventoryStockCountEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PrintQCodeItemsList.ForEach(o => o.Selected = selectAllCheckEdit.Checked);
            fld_dgcPrintQRCodeGridControl.DataSource = entity.PrintQCodeItemsList;
            fld_dgcPrintQRCodeGridControl.RefreshDataSource();
        }
    }
}
