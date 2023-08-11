using System;

namespace BOSERP.Modules.SemiProductIngredient.UI
{
    /// <summary>
    /// Summary description for DMSPI100
    /// </summary>
    public partial class DMSPI100 : BOSERPScreen
    {

        public DMSPI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShowReceiptList_Click(object sender, EventArgs e)
        {
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue.ToString());
            int operationID = Convert.ToInt32(fld_lkeFK_MMOperationID.EditValue.ToString());

            ((SemiProductIngredientModule)Module).ShowIngredientCostDD(batchProductID, operationID, fld_dteMMSemiProductIngredientDate.DateTime);
        }
    }
}
