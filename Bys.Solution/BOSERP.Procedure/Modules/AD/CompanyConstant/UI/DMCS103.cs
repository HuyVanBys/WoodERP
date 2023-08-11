using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS103
    /// </summary>
    public partial class DMCS103 : BOSERPScreen
    {

        public DMCS103()
        {
            //
            // Required designer variable
            //
            InitializeComponent();

            //Load sale order config            
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            fld_txtInitialDeposit.Text = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.SaleOrderInitialDeposit).ToString();
            fld_txtPaymentDueDays.Text = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.SaleOrderPaymentDueDays).ToString();
            fld_txtDeliveryDueDays.Text = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.SaleOrderDeliveryDueDays).ToString();
            fld_txtMainSellerCommissionPercent.Text = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.MainSellerCommissionPercent).ToString();
            fld_txtAssSellerCommissionPercent.Text = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.AssSellerCommissionPercent).ToString();

            //Load credit note config
            fld_txtValidDays.Text = objConfigValuesController.GetValueByConfigKey(ConfigValueKey.CreditNoteValidDays).ToString();
            fld_lkeCSSourceSellingPriceMethod.Properties.DataSource = objConfigValuesController.GetADConfigValuesByKeyGroup("SourceSellingPriceMethod");
            fld_lkeCSSourceSellingPriceMethod.Text = objConfigValuesController.GetValueByConfigKey("SourceSellingPriceMethod" + BOSApp.CurrentCompanyInfo.CSSourceSellingPriceMethod).ToString();

        }

        private void fld_btnPaymentType_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveSaleConfig();
        }
    }
}
