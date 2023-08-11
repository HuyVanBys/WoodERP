using System.ComponentModel;

namespace BOSERP.Modules.StopAllocationEquipment.UI
{
    /// <summary>
    /// Summary description for DMNPB100
    /// </summary>
    public partial class DMNPB100 : BOSERPScreen
    {

        public DMNPB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductIdentifiedEquipmentID_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.DataSource = ((StopAllocationEquipmentModule)Module).ChangeProductIdentifiedEquipment();
            fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((StopAllocationEquipmentModule)Module).GetDataSourceEquipment();
        }
    }
}
