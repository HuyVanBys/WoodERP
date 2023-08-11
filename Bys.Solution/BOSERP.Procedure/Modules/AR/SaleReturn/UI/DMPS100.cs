using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleReturn.UI
{
    /// <summary>
    /// Summary description for DMPS100
    /// </summary>
    public partial class DMPS100 : BOSERPScreen
    {

        public DMPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleReturn.SaleReturnModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtARSaleReturnDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleReturn.SaleReturnModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_txtARSaleReturnTaxAmount_Validated(object sender, EventArgs e)
        {
            ((SaleReturnModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleReturnModule)Module).AddItemToSaleReturnItemsList();
                fld_lkeFK_ICProductID.EditValue = 0;
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleReturnModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleReturnModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACEInvoiceTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((SaleReturnModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }
        }

        private void fld_lkeARInvoiceProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleReturnModule)Module).ChangeSaleReturnProductType(e.Value.ToString());
            }
        }

        private void fld_txtARSaleReturnDiscountPerCent_Validated_1(object sender, EventArgs e)
        {
            ((SaleReturnModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtARSaleReturnTaxPercent_Validated_1(object sender, EventArgs e)
        {
            ((SaleReturnModule)Module).ChangeTaxPercent();
        }

        private void fld_dteARSaleReturnGetPriceDate_Validated(object sender, EventArgs e)
        {
            ((SaleReturnModule)Module).CalculaterProductUnitPrice();
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SaleReturnModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((SaleReturnModule)Module).LoadProductList();
        }
    }
}
