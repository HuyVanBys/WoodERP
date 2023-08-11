using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrderForWood.UI
{
    /// <summary>
    /// Summary description for DMSO100
    /// </summary>
    public partial class DMSOFW100 : BOSERPScreen
    {

        public DMSOFW100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ARCustomerID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtARSaleOrderDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ChangeDiscountAmount();
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).CheckPaymentTimeAmount();
        }

        private void fld_txtARSaleOrderDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ChangeDiscountPercent();
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).CheckPaymentTimeAmount();

        }

        private void fld_bedARSaleOrderPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ShowPaymentInfo();
        }

        private void fld_btnEditShippingInfo_Click(object sender, EventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ShowShippingInfo();
        }

        private void fld_lkeFK_ARCustomerID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.SaleOrderForWood.SaleOrderForWoodModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleOrderForWoodModule)Module).AddItemToSaleOrderItemsList();
            }
        }

        private void fld_txtARSaleOrderTaxPercent_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeTaxPercent();
            ((SaleOrderForWoodModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtARSaleOrderTaxAmount_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeTaxAmount();
            ((SaleOrderForWoodModule)Module).CheckPaymentTimeAmount();
        }

        private void fld_txtARSaleOrderDepositBalance_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeDeposit();
        }

        private void fld_txtARSaleOrderShippingFee_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeShippingFee();
        }

        private void fld_lnkViewDiffPrice_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ViewDiffPrice();
        }

        private void fld_txtARSaleOrderCustomerCommissionPercent_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeCommissionPercent();
        }

        private void fld_txtARSaleOrderSOCommissionAmount_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeCommissionAmount();
        }

        private void fld_lkeFK_ARAssociatedSellerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderForWoodModule)Module).ChangeAssociatedSeller(Convert.ToInt32(e.Value));
            }
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).GetCustomerContactInfo("Invoice");
        }

        private void fld_btnEditShippingInfo_Click_1(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).GetCustomerContactInfo("Delivery");
        }

        private void fld_lkeARSaleOrderType_EditValueChanged(object sender, EventArgs e)
        {
            //((SaleOrderForWoodModule)Module).ChangeGridControl(fld_lkeARSaleOrderType.EditValue.ToString());
        }

        private void itemLookupEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleOrderForWoodModule)Module).AddItemToLumberWoodList(int.Parse(itemLookupEdit1.EditValue.ToString()));
            }

        }


        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleOrderForWoodModule)Module).AddItemToRoundWoodList(int.Parse(fld_lkeFK_ICProductID.EditValue.ToString()));
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ShownInventoryStocks();
        }

        private void fld_lkeARSaleOrderProductType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeARSaleOrderProductType.EditValue != null)
            {
                ((SaleOrderForWoodModule)Module).ChangeGridControl(fld_lkeARSaleOrderProductType.EditValue.ToString());
            }
        }

        private void fld_txtARSaleOrderExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeItemFromSaleOrderExchangeRate();
        }

        private void fld_txtARSaleOrderExchangeRate2_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangeItemFromSaleOrderExchangeRate();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderForWoodModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderForWoodModule)Module).UpdateTotalAmountByCurrency2(Convert.ToInt32(e.Value));
            }
        }

        private void fld_dteARSaleOrderDeliveryDate_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((SaleOrderForWoodModule)Module).UpdateSaleOrderItemDeliveryDate();
        }

        private void fld_dteARSaleOrderDate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangePaymentTimeDate();
        }

        private void fld_dteARSaleOrderDeliveryDate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).ChangePaymentTimeDate();
        }

        private void fld_lkeFK_GEPaymentTermID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int paymentTimeID = 0;
                if (int.TryParse(e.Value.ToString(), out paymentTimeID))
                {
                    ((SaleOrderForWoodModule)Module).GeneratePaymentTime(paymentTimeID);
                }
            }
        }


    }
}
