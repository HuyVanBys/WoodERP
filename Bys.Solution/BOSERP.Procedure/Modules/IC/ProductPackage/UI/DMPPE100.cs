using System;

namespace BOSERP.Modules.ProductPackage.UI
{
    /// <summary>
    /// Summary description for DMPPE100
    /// </summary>
    public partial class DMPPE100 : BOSERPScreen
    {

        public DMPPE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMPPE100_Load(object sender, EventArgs e)
        {

        }

        private void Fld_btnFind_Click(object sender, EventArgs e)
        {
            string packNo = !string.IsNullOrEmpty(fld_txtPackageNo.Text) ? fld_txtPackageNo.Text.TrimEnd() : string.Empty;

            int productID = 0;
            if (fld_lkeICProductID.EditValue != null)
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID);

            int supplierID = 0; //fld_lkeAPSupplierID
            if (fld_lkeAPSupplierID.EditValue != null)
                int.TryParse(fld_lkeAPSupplierID.EditValue.ToString(), out supplierID);

            string packName = !string.IsNullOrEmpty(fld_txtPackageName.Text) ? fld_txtPackageName.Text.TrimEnd() : string.Empty;
            string lotNo = !string.IsNullOrEmpty(fld_txtSerial.Text) ? fld_txtSerial.Text.TrimEnd() : string.Empty;
            string supplierLotNo = !string.IsNullOrEmpty(fld_txtICPackageSupplierNo.Text) ? fld_txtICPackageSupplierNo.Text.TrimEnd() : string.Empty;

            int attributeID = 0; //fld_lkeICProductAttributeID
            if (fld_lkeICProductAttributeID.EditValue != null)
                int.TryParse(fld_lkeICProductAttributeID.EditValue.ToString(), out attributeID);

            int batchID = 0; //fld_lkeICProductAttributeID
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchID);
            string barcodeNo = !string.IsNullOrEmpty(fld_txtBarcodeNo.Text) ? fld_txtBarcodeNo.Text.TrimEnd() : string.Empty;

            bool isGetBatchInfo = fld_ckeGetInfoFromBatch.Checked;//fld_ckeGetInfoFromBatch

            ((ProductPackageModule)Module).GetPackageData(packNo, productID, supplierID, packName, lotNo, supplierLotNo, attributeID, batchID, barcodeNo, isGetBatchInfo);
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            ((ProductPackageModule)Module).CheckedAllByFilterItem(fld_chkSelectAll.Checked);
        }

        private void fld_btnPrintQR_Click(object sender, EventArgs e)
        {
            ((ProductPackageModule)Module).PrintMultiBarcode(null);
        }
    }
}
