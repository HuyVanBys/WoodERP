using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineConfig.UI
{
    /// <summary>
    /// Summary description for DMCS100
    /// </summary>
    public partial class DMMCC100 : BOSERPScreen
    {

        public DMMCC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSemiSave_Click(object sender, EventArgs e)
        {
            MachineConfigModule module = (MachineConfigModule)Module;
            if (module.SaveProductSemis())
            {
                MessageBox.Show("Lưu thành công", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            MachineConfigModule module = (MachineConfigModule)Module;
            module.InvalidateMachine(fld_txtUnitNo.Text.Trim(), fld_txtUnitName.Text.Trim());
        }
    }
}
