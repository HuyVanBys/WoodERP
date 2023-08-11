using System;

namespace BOSERP.Modules.EquipmentDecreasing.UI
{
    /// <summary>
    /// Summary description for DMED100
    /// </summary>
    public partial class DMED100 : BOSERPScreen
    {

        public DMED100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lblLabel5_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_ACAssObjectID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((EquipmentDecreasingModule)Module).ChangeObject();
        }
    }
}
