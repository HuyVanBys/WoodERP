using BOSCommon;
using BOSComponent;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPurchaseReceipt.UI
{
    /// <summary>
    /// Summary description for DMWPR100
    /// </summary>
    public partial class DMWPR100 : BOSERPScreen
    {

        public DMWPR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtICReceiptShippingExtraFees_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)this.Module).ChangeFee();
        }

        private void fld_txtICReceiptDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtICReceiptDiscountFix_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtICReceiptShippingFees_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeFee();
        }

        private void fld_lkeFK_APSupplierID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((WoodPurchaseReceiptModule)Module).ChangeSupplier(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WoodPurchaseReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_txtICReceiptTaxPercent_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeTaxPercent();
        }

        private void fld_txtICReceiptTaxAmount_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeTaxAmount();
        }

        private void fld_rdgReceiptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChooseReceiptType();
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WoodPurchaseReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((WoodPurchaseReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangePackNo();
        }

        private void fld_lkeReceiptPurchaseTypeCombo_EditValueChanged(object sender, EventArgs e)
        {
            string productType = string.Empty;
            if (fld_lkeICReceiptReceiptType.EditValue != null)
            {
                productType = fld_lkeICReceiptReceiptType.EditValue.ToString();
                ((WoodPurchaseReceiptModule)Module).ChangedInputType(productType);
            }

        }
        private void fld_lkeFK_ADMatchCodeIDPaintType_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeWoodType();
        }

        private void fld_lkeICReceiptProductFSCCombo_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeProductTTMT();
        }

        private void fld_lkeICReceiptProductOriginCombo_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeProductOrigin();
        }

        private void fld_txtICReceiptContainerNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_txtICReceiptContainerNo_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ShownPopUpContainerNo(fld_txtICReceiptContainerNo.Text.ToString());
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((WoodPurchaseReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACAssObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((WoodPurchaseReceiptModule)Module).ChangeAssObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((WoodPurchaseReceiptModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeICProductIdentifyWoodType_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DataSource = ((WoodPurchaseReceiptModule)Module).GetProductAttributeDatasource(ProductAttributeGroup.WoodType.ToString());
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DisplayMember = "ICProductAttributeValue";
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ValueMember = "ICProductAttributeID";
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).ChangeExchangeRate();
        }
    }
}
