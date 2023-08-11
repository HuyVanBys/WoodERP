using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ReturnSupplier.UI
{
    /// <summary>
    /// Summary description for DMRS100
    /// </summary>
    public partial class DMRS100 : BOSERPScreen
    {

        public DMRS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.ReturnSupplier.ReturnSupplierModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtAPReturnSupplierShippingFees_Validated(object sender, EventArgs e)
        {
            ((Modules.ReturnSupplier.ReturnSupplierModule)this.Module).ChangeFee();
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ReturnSupplierModule)Module).AddItemToReturnSupplierItemsList();
            }
        }

        private void fld_lkeFK_ACEInvoiceTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSComponent.BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((ReturnSupplierModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ReturnSupplierModule)Module).ChangeCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeAPReturnSupplierReceiptType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ReturnSupplierModule)Module).ChangeSaleReturnProductType(e.Value.ToString());
            }
        }
    }
}
