using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrderForOther.UI
{
    /// <summary>
    /// Summary description for DMSO100
    /// </summary>
    public partial class DMSOFO100 : BOSERPScreen
    {

        public DMSOFO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ARCustomerID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtARSaleOrderDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ChangeDiscountAmount();
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).CheckPaymentTimeAmount();
        }

        private void fld_txtARSaleOrderDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ChangeDiscountPercent();
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).CheckPaymentTimeAmount();
        }

        private void fld_bedARSaleOrderPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ShowPaymentInfo();
        }

        private void fld_btnEditShippingInfo_Click(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ShowShippingInfo();
        }

        private void fld_lkeFK_ARCustomerID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.SaleOrderForOther.SaleOrderForOtherModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleOrderForOtherModule)Module).AddItemToSaleOrderItemsList();
            }
        }

        private void fld_txtARSaleOrderTaxPercent_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeTaxPercent();
            ((SaleOrderForOtherModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtARSaleOrderTaxAmount_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeTaxAmount();
            ((SaleOrderForOtherModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtARSaleOrderDepositBalance_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeDeposit();
        }

        private void fld_txtARSaleOrderShippingFee_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeShippingFee();
        }

        private void fld_lnkViewDiffPrice_Click(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ViewDiffPrice();
        }

        private void fld_txtARSaleOrderCustomerCommissionPercent_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeCommissionPercent();
        }

        private void fld_txtARSaleOrderSOCommissionAmount_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeCommissionAmount();
        }

        private void fld_lkeFK_ARAssociatedSellerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderForOtherModule)Module).ChangeAssociatedSeller(Convert.ToInt32(e.Value));
            }
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).GetCustomerContactInfo("Invoice");
        }

        private void fld_btnEditShippingInfo_Click_1(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).GetCustomerContactInfo("Delivery");
        }

        private void fld_lkeARSaleOrderType_EditValueChanged(object sender, EventArgs e)
        {
            //((SaleOrderForOtherModule)Module).ChangeGridControl(fld_lkeARSaleOrderType.EditValue.ToString());
        }

        private void itemLookupEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleOrderForOtherModule)Module).AddItemToLumberWoodList(int.Parse(itemLookupEdit1.EditValue.ToString()));
            }

        }


        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            ((SaleOrderForOtherModule)Module).AddItemToRoundWoodList(int.Parse(fld_lkeFK_ICProductID.EditValue.ToString()));
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ShownInventoryStocks();
        }

        private void fld_lkeARSaleOrderProductType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeARSaleOrderProductType.EditValue != null)
                ((SaleOrderForOtherModule)Module).ChangeGridControl(fld_lkeARSaleOrderProductType.EditValue.ToString());
        }

        private void fld_txtARSaleOrderExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeItemFromSaleOrderExchangeRate();
        }

        private void fld_txtARSaleOrderExchangeRate2_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangeItemFromSaleOrderExchangeRate();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderForOtherModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderForOtherModule)Module).UpdateTotalAmountByCurrency2(Convert.ToInt32(e.Value));
            }
        }

        private void fld_dteARSaleOrderDeliveryDate_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((SaleOrderForOtherModule)Module).UpdateSaleOrderItemDeliveryDate();
        }

        private void fld_dteARSaleOrderDate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangePaymentTimeDate();
        }

        private void fld_dteARSaleOrderDeliveryDate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForOtherModule)Module).ChangePaymentTimeDate();
        }

        private void fld_lkeFK_GEPaymentTermID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int paymentTimeID = 0;
                if (int.TryParse(e.Value.ToString(), out paymentTimeID))
                {
                    ((SaleOrderForOtherModule)Module).GeneratePaymentTime(paymentTimeID);
                }
            }
        }

    }
}
