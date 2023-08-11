using System.Windows.Forms;

namespace BOSERP.Modules.Vehicle.UI
{
    /// <summary>
    /// Summary description for DMVM100
    /// </summary>
    public partial class DMVM100 : BOSERPScreen
    {

        public DMVM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((VehicleModule)Module).ChangeObject(fld_lkeFK_ACObjectID.EditValue.ToString());
            }
        }
    }
}
