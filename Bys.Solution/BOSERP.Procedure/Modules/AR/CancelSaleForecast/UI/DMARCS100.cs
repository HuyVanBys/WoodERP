using BOSComponent;
using System;

namespace BOSERP.Modules.CancelSaleForecast.UI
{
    /// <summary>
    /// Summary description for DMARCS100
    /// </summary>
    public partial class DMARCS100 : BOSERPScreen
    {

        public DMARCS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp_1(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CancelSaleForecastModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }
    }
}
