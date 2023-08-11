using BOSComponent;
using Localization;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceSheet.UI
{
    /// <summary>
    /// Summary description for DMPRS100
    /// </summary>
    public partial class DMPRS100 : BOSERPScreen
    {

        public DMPRS100()
        {
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((PriceSheetModule)Module).AddProductToPriceSheetItemList();
        }

        private void fld_btnImportFromExcel_Click(object sender, EventArgs e)
        {
            ((PriceSheetModule)Module).UpdatePriceSheetEndDate();
        }

        private void Fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
                string errorMessage = ((PriceSheetModule)Module).CheckValidProduct(productID);
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ((PriceSheetModule)Module).AddItemToPriceSheetItemsList();
                }
            }
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PriceSheetModule)Module).ChangeCustomer(Convert.ToInt32(e.Value.ToString()));
            }
        }
    }
}
