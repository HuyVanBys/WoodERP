using BOSComponent;
using System;

namespace BOSERP.Modules.ElectronicInvoiceBKAV.UI
{
    /// <summary>
    /// Summary description for DMBAA100
    /// </summary>
    public partial class DMEIBKAV100 : BOSERPScreen
    {

        public DMEIBKAV100()
        {
            InitializeComponent();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            this.fld_lkeFK_GECurrencyID.Properties.DataSource = objCurrenciesController.GetAllCurrencys();
        }

        private void fld_cmbTaxOfficeCode_Validated(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtExchangeRate_Validated(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).UpdateTotalAmount();
        }

        private void Fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).ChangeObject(e.Value.ToString());
            }
        }

        private void Fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule)this.Module).ChangeCurrencyID(Convert.ToInt32(e.Value));
            }
        }
    }
}
