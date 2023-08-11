using BOSComponent;
using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace BOSERP.Modules.MachineGroup.UI
{
    /// <summary>
    /// Summary description for SMNTS100
    /// </summary>
    public partial class DMMG100 : BOSERPScreen
    {

        public DMMG100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosLookupEdit3_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void bosLookupEdit3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ((DeviceConfigModule)Module).AddItemToDeviceItemPlansList();
            }
        }

        private void fld_btnLuu_Click(object sender, EventArgs e)
        {
            ((MachineGroupModule)Module).ActionSave();
        }

        private void fld_lkeICProductIdentifiedEquipmentID_KeyUp(object sender, KeyEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.KeyCode == Keys.Enter)
            {
                ((MachineGroupModule)Module).AddItemICMachineGroupCCDCList(Convert.ToInt32(lke.EditValue));
            }
        }

        private void fld_lkeACAssetID_KeyUp(object sender, KeyEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.KeyCode == Keys.Enter)
            {
                ((MachineGroupModule)Module).AddItemICMachineGroupTSCDList(Convert.ToInt32(lke.EditValue));
            }
        }

    }
}
