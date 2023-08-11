using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public partial class guiPrintPackageBarcode : BOSERPScreen
    {
        public guiPrintPackageBarcode()
        {
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiPrintPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            //Bind the grid control to the entity's list
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PackageList.InitBOSListGridControl(fld_dgcPrintedPackages);

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
            ((PurchaseReceiptModule)Module).SearchPackagesForPrinting(fld_txtICProductSupplierNumber.Text);
        }

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            ((PurchaseReceiptModule)Module).SelectAllPrintedPackages(selectAllCheckEdit.Checked);
        }
    }
}
