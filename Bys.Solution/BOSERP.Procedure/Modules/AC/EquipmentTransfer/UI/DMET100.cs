using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentTransfer.UI
{
    /// <summary>
    /// Summary description for DMET100
    /// </summary>
    public partial class DMET100 : BOSERPScreen
    {

        public DMET100()
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
                ((EquipmentTransferModule)Module).AddItemToList();
            }
        }
    }
}
