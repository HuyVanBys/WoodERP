using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.PurchaseContract.UI
{
    /// <summary>
    /// Summary description for DMPCT100
    /// </summary>
    public partial class DMPCT100 : BOSERPScreen
    {

        public DMPCT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseContractModule)Module).ChangeCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtARPurchaseOrderSubTotalCost_Validated(object sender, EventArgs e)
        {
            ((PurchaseContractModule)Module).UpdateTotalAmount();
        }

        private void fld_txtAPPurchaseContractTaxPercent_Validated(object sender, EventArgs e)
        {
            ((PurchaseContractModule)Module).ChangeTaxPercent();
        }

        private void fld_txtAPPurchaseContractTaxAmount_Validated(object sender, EventArgs e)
        {
            ((PurchaseContractModule)Module).ChangeTaxAmount();
        }

        private void fld_lkeAPPurchaseContractType_Validated(object sender, EventArgs e)
        {
            ((PurchaseContractModule)Module).ChangePurchaseContractType();
        }

        private void fld_lkeAPPurchaseContractType_QueryCloseUp(object sender, CancelEventArgs e)
        {
            ((PurchaseContractModule)Module).ChangePurchaseContractType();
        }
    }
}
