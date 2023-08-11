using System.Windows.Forms;

namespace BOSERP.Modules.AssetShipment.UI
{
    /// <summary>
    /// Summary description for DMAS100
    /// </summary>
    public partial class DMAS100 : BOSERPScreen
    {

        public DMAS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACAssetID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssetShipmentModule)Module).AddItemToList();
            }
        }
    }
}
