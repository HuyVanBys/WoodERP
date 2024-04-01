using System;

namespace BOSERP.Modules.UpdatePosition.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMUP100 : BOSERPScreen
    {

        public DMUP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnInventoryStatement_Click(object sender, EventArgs e)
        {
            if (fld_lkeFK_ICStockID.EditValue == null || fld_lkeFK_ICStockID.EditValue.ToString() == "0")
            {
                BOSApp.ShowMessage("Vui lòng chọn kho");
                return;
            }
            decimal height = 0;
            decimal width = 0;
            decimal lenght = 0;
            int productID = 0;
            string serialNo = fld_btnICProductSerieNo.Text;
            if (fld_lkeICProductID.EditValue != null)
            {
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID);
            }
            if (fld_txtProductHeight.EditValue != null)
            {
                decimal.TryParse(fld_txtProductHeight.EditValue.ToString(), out height);
            }
            if (fld_txtProductWidth.EditValue != null)
            {
                decimal.TryParse(fld_txtProductWidth.EditValue.ToString(), out width);
            }
            if (fld_txtProductLength.EditValue != null)
            {
                decimal.TryParse(fld_txtProductLength.EditValue.ToString(), out lenght);
            }
            ((UpdatePositionModule)Module).LoadInventoryStatement(productID, height, width, lenght, serialNo);
        }

        private void fld_btn_DeleteSerialNo_Click(object sender, EventArgs e)
        {
            
           ((UpdatePositionModule)Module).DeleteErrorFromList();
            
        }
    }
}
