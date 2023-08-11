using System;

namespace BOSERP.Modules.ProductApplyPrice.UI
{
    /// <summary>
    /// Summary description for DMPAAP100
    /// </summary>
    public partial class DMPAAP100 : BOSERPScreen
    {

        public DMPAAP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((ProductApplyPriceModule)Module).AddProductToProductApplyPriceItemList();
        }

        private void fld_btnImportFromExcel_Click(object sender, EventArgs e)
        {
            ((ProductApplyPriceModule)Module).ImportProductApplyPrice();
        }

    }
}
