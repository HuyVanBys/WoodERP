using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;
namespace BOSERP.Modules.Barcode.UI
{
    /// <summary>
    /// Summary description for DMBC100
    /// </summary>
    public partial class DMBC100 : BOSERPScreen
    {

        public DMBC100()
        {
            InitializeComponent();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((BarcodeModule)Module).ShowCategoryTree();
        }

        private void fld_chkICProductActiveCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void fld_btnPrintBarcode_Click(object sender, EventArgs e)
        {
            ((Modules.Barcode.BarcodeModule)this.Module).PrintBarcode();
        }

        private void fld_btnPrintBarcodeList_Click(object sender, EventArgs e)
        {
            ((Modules.Barcode.BarcodeModule)this.Module).PrintBarcode();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((BarcodeModule)Module).ShowGuiAddProduct();
        }

        private void fld_btnUpdateItemBarcodeQty_Click(object sender, EventArgs e)
        {
            ((BarcodeModule)Module).UpdateItemBarcodeQty();
        }

        private void fld_btnPrintQRcode_Click(object sender, EventArgs e)
        {
            ((Modules.Barcode.BarcodeModule)this.Module).PrintQRcode();
        }
    }
}
