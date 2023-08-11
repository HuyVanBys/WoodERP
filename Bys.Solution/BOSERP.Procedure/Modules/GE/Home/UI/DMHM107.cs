using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM107
    /// </summary>
    public partial class DMHM107 : BOSERPScreen
    {

        public DMHM107()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            int productID = 0;
            int batchProductID = 0;
            int customerID = 0;
            string productSys = string.Empty;
            if (fld_lkeFK_ICProductID.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            }
            if (fld_lkeFK_MMBatchProductID.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_MMBatchProductID.EditValue.ToString(), out batchProductID);
            }
            if (fld_lkeFK_ARCustomerID.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out customerID);
            }
            if (fld_txbProductSysNo.EditValue != null)
            {
                productSys = fld_txbProductSysNo.EditValue.ToString();
            }
            ((HomeModule)Module).ShowProductInProduction(productID, batchProductID, customerID, productSys);
        }
    }
}
