using BOSComponent;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt.UI
{
    /// <summary>
    /// Summary description for DMRC100
    /// </summary>
    public partial class DMRC100 : BOSERPScreen
    {

        public DMRC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtICReceiptShippingExtraFees_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)this.Module).ChangeFee();
        }

        private void fld_txtICReceiptDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtICReceiptDiscountFix_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtICReceiptShippingFees_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangeFee();
        }

        private void fld_lkeFK_APSupplierID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeSupplier(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((PurchaseReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_txtICReceiptTaxPercent_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangeTaxPercent();
        }

        private void fld_txtICReceiptTaxAmount_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangeTaxAmount();
        }

        private void fld_rdgReceiptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChooseReceiptType();
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((PurchaseReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangePackNo();
        }

        private void fld_btnShowPurchaseOrderItems_Click(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ShowGuiChoosePurchaseOrderItems();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((PurchaseReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }

        }

        private void fld_lkeFK_ACAssObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeAssObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangeExchangeRate();
        }

        private void Fld_lkeICReceiptReceiptType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeReceiptReceiptType(e.Value.ToString());
            }
        }

        private void Fld_lkeFK_GETerminalID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeTerminal(Convert.ToInt32(e.Value));
            }
        }

        private void BosLookupEdit7_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeCountry(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeFK_ICProductAttributeTTMTID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeProductAttributeTTMT(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeFK_ICProductAttributeWoodTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseReceiptModule)Module).ChangeProductAttributeWoodType(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnZoomProduct_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_panelProduct);
        }
        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom();
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            var anchor = ctl.Anchor;
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }

        private void btnGenPackage_Click(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ChangePackage();
        }

        private void fld_btnGroupPackage_Click(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).GroupPackage();
        }

        private void fld_btnClearPackage_Click(object sender, EventArgs e)
        {
            ((PurchaseReceiptModule)Module).ClearPackage();
        }
    }
}
