using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetReceipt.UI
{
    /// <summary>
    /// Summary description for DMNTS100
    /// </summary>
    public partial class DMAR100 : BOSERPScreen
    {

        public DMAR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_txtACAssetReceiptDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((AssetReceiptModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtACAssetReceiptDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((AssetReceiptModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtACAssetReceiptShippingFee_Validated(object sender, EventArgs e)
        {
            ((AssetReceiptModule)Module).ChangeFee();
        }

        private void fld_txtACAssetReceiptExtraFee_Validated(object sender, EventArgs e)
        {
            ((AssetReceiptModule)Module).ChangeFee();
        }

        private void fld_txtACAssetReceiptTaxPercent_Validated(object sender, EventArgs e)
        {
            ((AssetReceiptModule)Module).ChangeTaxPercent();
        }

        private void fld_txtACAssetReceiptTaxAmount_Validated(object sender, EventArgs e)
        {
            ((AssetReceiptModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_APSupplierID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AssetReceiptModule)Module).ChangeSupplier(Convert.ToInt32(e.Value));
            }
        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(Width, Height);
            }
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AssetReceiptModule)Module).ChangeCurrency(currencyID);
                }
            }
        }
        private void fld_lkeFK_ACAssetID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssetReceiptModule)Module).AddItemToList();
            }
        }
        private void fld_lkeFK_ICProductID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssetReceiptModule)Module).AddItemProductToList();
            }
        }

        private void fld_bkeACAssetReceiptType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((AssetReceiptModule)Module).AssetTypeChange();
        }

        private void fld_txtFK_ACEInvoiceTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((AssetReceiptModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }
        }
    }
}
