using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentIncreasing.UI
{
    /// <summary>
    /// Summary description for DMEI100
    /// </summary>
    public partial class DMEI100 : BOSERPScreen
    {

        public DMEI100()
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
                ((EquipmentIncreasingModule)Module).AddItemToShipmentItemsList();
            }
        }
    }
}
