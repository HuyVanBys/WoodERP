using BOSComponent;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleForecast.UI
{
    /// <summary>
    /// Summary description for DMSF100
    /// </summary>
    public partial class DMSF100 : BOSERPScreen
    {

        public DMSF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ARCustomerID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtARSaleForecastDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_txtARSaleForecastDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ChangeDiscountPercentForItem();
        }

        private void fld_bedARSaleForecastPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ShowPaymentInfo();
        }

        private void fld_btnEditShippingInfo_Click(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ShowShippingInfo();
        }

        private void fld_lkeFK_ARCustomerID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
                ((SaleForecastModule)Module).AddItemToSaleForecastItemsList(productID);
                ((SaleForecastModule)Module).UpdateContQty();
            }
        }

        private void fld_txtARSaleForecastTaxPercent_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeTaxPercent();
        }

        private void fld_txtARSaleForecastTaxAmount_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeTaxAmount();
        }

        private void fld_txtARSaleForecastDepositBalance_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeDeposit();
        }

        private void fld_txtARSaleForecastShippingFee_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeShippingFee();
        }

        private void fld_lnkViewDiffPrice_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ViewDiffPrice();
        }

        private void fld_txtARSaleForecastCustomerCommissionPercent_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeCommissionPercent();
        }

        private void fld_txtARSaleForecastSOCommissionAmount_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeCommissionAmount();
        }

        private void fld_lkeFK_ARAssociatedSellerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).GetCustomerContactInfo("Invoice");
        }

        private void fld_btnEditShippingInfo_Click_1(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).GetCustomerContactInfo("Delivery");
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fld_lkeARSaleForecastType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_txtARSaleForecastExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).UpdatePriceForcurrencyOrExchange(true);
        }

        private void fld_txtARSaleForecastExchangeRate2_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).UpdatePriceForcurrencyOrExchange(false);
        }

        private void fld_txtARSaleForecastPONo_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangePONoItem();
        }

        private void bosLookupEdit2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleForecastModule)Module).ChangeSaleType(e.Value.ToString());
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ARConfigOriginalUnitPricesController objcoupController = new ARConfigOriginalUnitPricesController();
                ARConfigOriginalUnitPricesInfo objconfigPrice = objcoupController.GetOriginalIsAlive();
                if (objconfigPrice != null)
                {
                    if (objconfigPrice.ARConfigOriginalUnitPriceVoucher)
                    {
                        if (MessageBox.Show("Thay đổi loại tiền tệ sẽ thay đổi đơn giá gốc, bạn có chắc muốn thay đổi không? "
                            , CommonLocalizedResources.MessageBoxDefaultCaption
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ((SaleForecastModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
                        }
                        else
                        {
                            e.Value = lke.OldEditValue;
                        }
                    }
                    else
                    {
                        ((SaleForecastModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
                    }
                }
            }
        }

        private void fld_lkeFK_GECurrencyID2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleForecastModule)Module).UpdateTotalAmountByCurrency2(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnViewHistorySF_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ViewHistorySF();
        }

        private void fld_btnUpdateQty_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).UpdateQty();
        }

        private void fld_btnFromProposal_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ActionNewFromProposal();
        }

        private void fld_btnImport_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ImportItem();
        }

        private void fld_btnExportTemplate_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).GetDetailHardwareExcelTemplate();
        }

        private void Fld_txtARSaleForecastDiscountPerCent_Validated_1(object sender, EventArgs e)
        {
            ((SaleForecastModule)this.Module).ChangeDiscountPercent();
        }

        private void Fld_dteARSaleForecastDate_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)this.Module).ChangeSaleForecastDate();
        }

        private void Fld_lkeARSaleOrderProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ((SaleForecastModule)Module).ChangeInputType(e.Value.ToString());
            }
        }

        private void fld_dteARSaleForecastDeliveryDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((SaleForecastModule)Module).ChangeItemDeliveryDate(dt);
                }
            }
        }
    }
}
