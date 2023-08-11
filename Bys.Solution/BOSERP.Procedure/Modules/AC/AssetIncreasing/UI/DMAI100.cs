using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetIncreasing.UI
{
    /// <summary>
    /// Summary description for DMER100
    /// </summary>
    public partial class DMAI100 : BOSERPScreen
    {

        public DMAI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_APSupplierID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AssetIncreasingModule)Module).ChangeSupplier(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AssetIncreasingModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((AssetIncreasingModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtICReceiptDiscountFix_Validated(object sender, EventArgs e)
        {
            ((AssetIncreasingModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtICReceiptShippingFee_Validated(object sender, EventArgs e)
        {
            ((AssetIncreasingModule)Module).ChangeFee();
        }

        private void fld_txtICReceiptShippingExtraFee_Validated(object sender, EventArgs e)
        {
            ((AssetIncreasingModule)Module).ChangeFee();
        }

        private void fld_txtICReceiptTaxPercent_Validated(object sender, EventArgs e)
        {
            ((AssetIncreasingModule)Module).ChangeTaxPercent();
        }

        private void fld_txtICReceiptTaxAmount_Validated(object sender, EventArgs e)
        {
            ((AssetIncreasingModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssetIncreasingModule)Module).AddItemToReceiptItemList();
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

        private void fld_lblLabel12_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookupEdit = (LookUpEdit)sender;
            if (lookupEdit.OldEditValue != e.Value)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AssetIncreasingModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

    }
}
