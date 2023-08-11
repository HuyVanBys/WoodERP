using BOSComponent;
using System;

namespace BOSERP.Modules.SupplierPriceSheet.UI
{
    /// <summary>
    /// Summary description for DMSPS100
    /// </summary>
    public partial class DMSPS100 : BOSERPScreen
    {

        public DMSPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((SupplierPriceSheetModule)Module).AddProductToPriceSheetItemList();
        }

        private void fld_btnImportFromExcel_Click(object sender, EventArgs e)
        {
            ((SupplierPriceSheetModule)Module).ImportSupplierPriceSheet();
        }

        private void Fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int currencyID = 0;
                Int32.TryParse(e.Value.ToString(), out currencyID);
                ((SupplierPriceSheetModule)Module).ChangeCurrency(currencyID);
            }
        }

        private void Fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SupplierPriceSheetModule)Module).ChangeObject(e.Value.ToString());
            }
        }
    }
}
