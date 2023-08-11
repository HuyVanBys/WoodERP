using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Vehicle.UI
{
    /// <summary>
    /// Summary description for DMVM101
    /// </summary>
    public partial class DMVM101 : BOSERPScreen
    {

        public DMVM101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((VehicleModule)Module).AddItemToVehicleFuelLogList();
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((VehicleModule)Module).ChangeSelectedItemFromVehicleFuelLogList();
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            ((VehicleModule)Module).RemoveSelectedItemFromVehicleFuelLogList();
        }

        private void fld_txtVMVehicleFuelLogQty_KeyUp(object sender, KeyEventArgs e)
        {
            ((VehicleModule)Module).SetVehicleFuelLogTotalCost();
        }

        private void fld_txtVMVehicleFuelLogStartOdometer_KeyUp(object sender, KeyEventArgs e)
        {
            ((VehicleModule)Module).SetOdometer();
        }

        private void fld_txtVMVehicleFuelLogDistanceCovered_KeyUp(object sender, KeyEventArgs e)
        {
            ((VehicleModule)Module).SetDistanceCovered();
        }
    }
}
