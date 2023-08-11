using BOSComponent;
using System;

namespace BOSERP.Modules.AdjustSaleOrderQuantity.UI
{
    /// <summary>
    /// Summary description for DMARCS100
    /// </summary>
    public partial class DMASOQ100 : BOSERPScreen
    {

        public DMASOQ100()
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
                ((AdjustSaleOrderQuantityModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }
    }
}
