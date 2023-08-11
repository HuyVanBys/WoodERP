using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationEquipment.UI
{
    /// <summary>
    /// Summary description for DMAE100
    /// </summary>
    public partial class DMAE100 : BOSERPScreen
    {

        public DMAE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AllocationEquipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            fld_lkeFK_ICProductID.Properties.DataSource = objProductsController.GetEquipmentForAllocationEquipment();
        }
    }
}
