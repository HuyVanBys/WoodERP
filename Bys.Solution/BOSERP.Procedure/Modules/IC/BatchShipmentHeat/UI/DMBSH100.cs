using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentHeat.UI
{
    /// <summary>
    /// Summary description for DMBSH100
    /// </summary>
    public partial class DMBSH100 : BOSERPScreen
    {

        public DMBSH100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }



        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = 0;
                if (int.TryParse(e.Value.ToString(), out stockID))
                {
                    ((BatchShipmentHeatModule)Module).SetShipmentItemStock(stockID);
                }
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentHeatModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchShipmentHeatModule)Module).AddItemToShipmentItemsList();
            }
        }
    }
}
