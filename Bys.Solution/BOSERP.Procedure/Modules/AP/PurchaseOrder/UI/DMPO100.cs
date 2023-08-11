using BOSComponent;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder.UI
{
    /// <summary>
    /// Summary description for DMPO100
    /// </summary>
    public partial class DMPO100 : BOSERPScreen
    {

        public DMPO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_bedAPPurchaseOrderPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ShowPaymentInfo();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtAPPurchaseOrderDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ChangeDiscountPercent();
            ((PurchaseOrderModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtAPPurchaseOrderDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ChangeDiscountAmount();
            ((PurchaseOrderModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtAPPurchaseOrderShippingExtraFees_Validated(object sender, EventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ChangeShippingFee();
            ((PurchaseOrderModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtAPPurchaseOrderShippingFees_Validated(object sender, EventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ChangeShippingFee();
            ((PurchaseOrderModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_btnShippingInfo_Click(object sender, EventArgs e)
        {
            ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).ShowShippingInfo();
        }

        //private void fld_lkeFK_APSupplierID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        //{
        //    ((PurchaseOrderModule)Module).ChangeSupplier(sender, e);
        //}

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if(objProductsInfo != null)
                {
                    if (!objProductsInfo.ICProductActiveCheck)
                    {
                        MessageBox.Show(PurchaseOrderLocalizedResources.ProductNonActiveCheck, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                ((PurchaseOrderModule)Module).AddItemToPurchaseOrderItemsList();
                }
            }
        }

        private void fld_txtAPPurchaseOrderTaxPercent_Validated(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ChangeTaxPercent();
            ((PurchaseOrderModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtAPPurchaseOrderTaxAmount_Validated(object sender, EventArgs e)
        {
            //((PurchaseOrderModule)Module).ChangeTaxAmount();
        }

        private void fld_txtAPPurchaseOrderDepositBalance_Validated(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ChangeDepositBalance();
        }

        private void fld_lkeAPPurchaseOrderTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseOrderModule)Module).ChangePurchaseOrderType(e.Value.ToString());
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

        private void fld_btnShowProposalItems_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ShowGuiChooseProposalItems();
        }

        private void fld_lkeFK_GECurrencyID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((PurchaseOrderModule)Module).updateTotalAmountbyCurrecy();
        }

        private void fld_dteAPPurchaseOrdeDate_Validated(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ChangePaymentTimeDate();
        }

        private void fld_dteAPPurchaseOrderDeliveryDate_Validated(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ChangePaymentTimeDate();
        }

        private void bosDateEdit2_Validated(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ChangePaymentTimeDate();
        }

        private void fld_lkeFK_GEPaymentTermID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int paymentTimeID = 0;
                if (int.TryParse(e.Value.ToString(), out paymentTimeID))
                {
                    ((PurchaseOrderModule)Module).CheckPaymentTerm(paymentTimeID);
                    //((PurchaseOrderModule)Module).GeneratePaymentTime(paymentTimeID);
                }
            }

        }

        private void fld_lkeFK_APSupplierID1_Validated(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).InvalidateProductItemsListAfterChoosingSupplier();
        }

        private void accObjectLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value == null)
            {
                ((PurchaseOrderModule)Module).ChangeAssObject(string.Empty);
            }
            else if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseOrderModule)Module).ChangeAssObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value == null)
            {
                ((PurchaseOrderModule)Module).ChangeObject(string.Empty);
            }
            else if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseOrderModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void bosLookupEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((PurchaseOrderModule)Module).ChangePurchaseOrderChannel();
        }

        private void BosLookupEdit2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int batchProductID = 0;
                if (int.TryParse(e.Value.ToString(), out batchProductID))
                {
                    ((PurchaseOrderModule)Module).ChangeBatchProduct(batchProductID);
                }
            }
        }

        private void fld_btnAddSemiProduct_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).AddSemiProductForBatch();
        }

        private void fld_btnAddMaterial_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).AddMaterialForBatch();
        }

        private void fld_lkeAPPurchaseOrderReceiptTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseOrderModule)Module).ChangePurchaseOrderReceiptType(e.Value.ToString());
            }
        }

        private void fld_btnAddMoreMaterial_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).AddMoreMaterial();
        }

        private void fld_btnSaveDelivery_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).UpdatePurchaseOrderItemDelivery();
        }

        private void Fld_btnApplyOldPrice_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ApplyOldPrice();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseOrderModule)Module).ChangeCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_dteFK_ICProductAttributeTTMTID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((PurchaseOrderModule)Module).ChangeProductAttributeTTMT(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_APPurchasingStaffID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((PurchaseOrderModule)Module).ChangePurchasingStaff(Convert.ToInt32(e.Value));
            }
        }

        private void bosLookupEdit6_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((PurchaseOrderModule)Module).ChangeProductOrigin(Convert.ToInt32(e.Value));
            }
        }

        private void fld_dteAPPurchaseOrderDeliveryDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((PurchaseOrderModule)Module).ChangePurchaseOrderItemDeliveryDate(dt);
                }
            }
        }
		private void fld_linkViewApproval_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).ViewApprovalDetails();
        }

        private void fld_btnUpdateInventoryStock_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Module).GetInventoryQty();
        }
    }
}
