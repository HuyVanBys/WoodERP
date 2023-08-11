using BOSComponent;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStockCount
{
    public partial class guiExportTemplate : BOSERPScreen
    {

        public int StockId { get; set; }

        public string StockName { get; set; }

        public DateTime InventoryDate { get; set; }

        public guiExportTemplate()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiPrintInventoryPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteICInventoryStockCountDate.EditValue = DateTime.Now;
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

        private void fld_btnExportTeamplate_Click(object sender, EventArgs e)
        {
            int stockId = fld_FK_ICStockID.EditValue == null ? 0 : (int)fld_FK_ICStockID.EditValue;
            if (stockId == 0)
            {
                MessageBox.Show("Vui lòng chọn kho để tiếp tục thao tác!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            StockId = stockId;
            InventoryDate = fld_dteICInventoryStockCountDate.DateTime;
            StockName = fld_FK_ICStockID.Properties.GetDisplayText(fld_FK_ICStockID.EditValue);
            Close();
        }
    }
}
