using System.Windows.Forms;

namespace BOSERP.Modules.AssetTransfer.UI
{
    /// <summary>
    /// Summary description for DMAT100
    /// </summary>
    public partial class DMAT100 : BOSERPScreen
    {

        public DMAT100()
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
                ((AssetTransferModule)Module).AddItemToList();
            }
        }
    }
}
