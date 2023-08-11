using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSLib;
using System.Collections.Generic;
using BOSComponent;

namespace BOSERP.Modules.ElectronicInvoiceMInvoice.UI
{
	/// <summary>
	/// Summary description for DMBAA100
	/// </summary>
	public partial class DMEIMI100 : BOSERPScreen
	{

		public DMEIMI100()
		{
			InitializeComponent();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            this.fld_lkeFK_GECurrencyID.Properties.DataSource = objCurrenciesController.GetAllCurrencys();
        }

        private void fld_lkeACEInvoiceGeneralPaymentMethod_QueryPopUp(object sender, CancelEventArgs e)
        {
            List<string> resultData = ((ElectronicInvoiceMInvoiceModule)this.Module).GetPaymentDataSource();
            fld_lkeACEInvoicePaymentMethodName.Properties.DataSource = resultData;
        }

        private void fld_cmbTaxOfficeCode_Validated(object sender, EventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtExchangeRate_Validated(object sender, EventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void Fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ElectronicInvoiceMInvoiceModule)this.Module).ChangeObject(e.Value.ToString());
            }
        }

        private void Fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ElectronicInvoiceMInvoiceModule)this.Module).ChangeCurrencyID(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeACEInvoicePaymentMethodName_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ElectronicInvoiceMInvoiceModule)this.Module).ChangePaymentMethod(Convert.ToInt32(e.Value));
            }
        }

        private void fld_tbDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void fld_cmbTaxOfficeCode_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((ElectronicInvoiceMInvoiceModule)this.Module).UpdateTotalAmount();
        }

        private void fld_txtDiscountAmount_Validated_1(object sender, EventArgs e)
        {
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)((ElectronicInvoiceMInvoiceModule)this.Module).CurrentModuleEntity.MainObject;
            if(mainObject.SumOfTotalLineAmountWithoutVAT != 0)
                mainObject.DiscountPercent = mainObject.DiscountAmount / mainObject.SumOfTotalLineAmountWithoutVAT * 100;
            ((ElectronicInvoiceMInvoiceModule)this.Module).UpdateTotalAmount();
        }
    }
}
