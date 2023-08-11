using BOSCommon;
using BOSComponent;
using Localization;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.RetailVAT.UI
{
    /// <summary>
    /// Summary description for DMIV100
    /// </summary>
    public partial class DMRVAT100 : BOSERPScreen
    {

        public DMRVAT100()
        {
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((RetailVATModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtARInvoiceDiscountFix_Validated(object sender, EventArgs e)
        {
            ((RetailVATModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_txtARInvoiceDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((RetailVATModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_txtARInvoiceTaxPercent_Validated(object sender, EventArgs e)
        {
            ((RetailVATModule)this.Module).ChangeTaxPercent();
        }

        private void fld_txtARInvoiceTaxAmount_Validated(object sender, EventArgs e)
        {
            ((RetailVATModule)this.Module).ChangeTaxAmount();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                //((RetailVATModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((RetailVATModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_lkeFK_ACEInvoiceTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((RetailVATModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }
        }

        private void fld_lkeFK_ACObjectID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null && e.OldValue != null && e.NewValue.ToString() != e.OldValue.ToString())
            {
                ((RetailVATModule)Module).ChangeObject(e.NewValue.ToString());
            }
        }
    }
}
