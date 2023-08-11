using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.ElectronicInvoice.UI
{
    /// <summary>
    /// Summary description for DMBAA100
    /// </summary>
    public partial class DMEI100 : BOSERPScreen
    {

        public DMEI100()
        {
            InitializeComponent();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            this.fld_lkeFK_GECurrencyID.Properties.DataSource = objCurrenciesController.GetAllCurrencys();
        }

        private void fld_lkeACEInvoiceGeneralPaymentMethod_QueryPopUp(object sender, CancelEventArgs e)
        {
            List<object> resultData = ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).GetPaymentDataSource();
            fld_lkeACEInvoicePaymentMethodName.Properties.DataSource = resultData;
            //fld_lkeACEInvoiceGeneralPaymentMethod.Properties.DisplayMember = "ACEInvoicePaymentMethodName";
            //fld_lkeACEInvoiceGeneralPaymentMethod.Properties.ValueMember = "ACEInvoicePaymentMethodName";
        }

        private void fld_cmbTaxOfficeCode_Validated(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtExchangeRate_Validated(object sender, EventArgs e)
        {
            ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void Fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).ChangeObject(e.Value.ToString());
            }
        }

        private void Fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((Modules.ElectronicInvoice.ElectronicInvoiceModule)this.Module).ChangeCurrencyID(Convert.ToInt32(e.Value));
            }
        }
    }
}
