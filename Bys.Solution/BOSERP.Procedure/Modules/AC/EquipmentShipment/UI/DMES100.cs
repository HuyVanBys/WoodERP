using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentShipment.UI
{
    /// <summary>
    /// Summary description for DMES100
    /// </summary>
    public partial class DMES100 : BOSERPScreen
    {

        public DMES100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((EquipmentShipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((EquipmentShipmentModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }
    }
}
