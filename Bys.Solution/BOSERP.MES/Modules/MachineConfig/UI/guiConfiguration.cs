using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineConfig.UI
{
    public partial class guiConfiguration : BOSERPScreen
    {
        private String CurrentSection;

        public guiConfiguration()
        {
            InitializeComponent();
        }

        private void fld_trlSections_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            CurrentSection = e.Node.Tag.ToString();

            switch (e.Node.Tag.ToString())
            {
                case "MachineConfig":
                    DMMCC100 guiCompanyProfile = new DMMCC100();
                    guiCompanyProfile.ScreenNumber = "DMMCC100";
                    guiCompanyProfile.Module = Module;
                    LoadScreen(guiCompanyProfile);
                    ((MachineConfigEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((MachineConfigEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateModuleObjects(0);
                    break;
            }
        }

        private void LoadScreen(BOSERPScreen screen)
        {
            fld_pnlScreenContainer.Controls.Clear();
            screen.AddCustomControls(Module.Screens);
            screen.CustomizeControls(screen.Controls);
            screen.InitializeControls(screen.Controls);
            for (int i = 0; i < screen.Controls.Count; i++)
            {
                fld_pnlScreenContainer.Controls.Add(screen.Controls[i]);
                i--;
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;
            MachineConfigModule module = (MachineConfigModule)Module;
            MachineConfigEntities entity = ((MachineConfigEntities)((BaseModuleERP)Module).CurrentModuleEntity);
            switch (CurrentSection)
            {
                case "MachineConfig":
                    entity.SaveModuleObjects();
                    break;
            }
            if (isSuccess)
            {
                MessageBox.Show("Lưu thành công", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
