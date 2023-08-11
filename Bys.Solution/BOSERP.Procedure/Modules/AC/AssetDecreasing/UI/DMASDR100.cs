using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetDecreasing.UI
{
    /// <summary>
    /// Summary description for DMNTS100
    /// </summary>
    public partial class DMASDR100 : BOSERPScreen
    {

        public DMASDR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtACAssetReceiptDiscountPercent_Validated(object sender, EventArgs e)
        {
            //((AssetDecreasingModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtACAssetReceiptDiscountAmount_Validated(object sender, EventArgs e)
        {
            //((AssetDecreasingModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtACAssetReceiptShippingFee_Validated(object sender, EventArgs e)
        {
            // ((AssetDecreasingModule)Module).ChangeFee();
        }

        private void fld_txtACAssetReceiptExtraFee_Validated(object sender, EventArgs e)
        {
            // ((AssetDecreasingModule)Module).ChangeFee();
        }

        private void fld_txtACAssetReceiptTaxPercent_Validated(object sender, EventArgs e)
        {
            // ((AssetDecreasingModule)Module).ChangeTaxPercent();
        }

        private void fld_txtACAssetReceiptTaxAmount_Validated(object sender, EventArgs e)
        {
            // ((AssetDecreasingModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_APSupplierID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

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

        private void fld_lkeFK_ICProductID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssetDecreasingModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookupEdit = (LookUpEdit)sender;
            if (lookupEdit.OldEditValue != e.Value)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AssetDecreasingModule)Module).ChangeCurrency(currencyID);
                }
            }
        }
    }
}
