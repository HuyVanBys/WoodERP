using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.EInvoiceConfig.UI
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
                case "EInvoiceConfig":
                    DMEIC100 guiCompanyProfile = new DMEIC100();
                    guiCompanyProfile.ScreenNumber = "DMEIC100";
                    guiCompanyProfile.Module = Module;
                    LoadScreen(guiCompanyProfile);
                    ((EInvoiceConfigEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((EInvoiceConfigEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateModuleObjects(0);
                    fld_btnSave.Visible = true;
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
            EInvoiceConfigModule module = (EInvoiceConfigModule)Module;
            EInvoiceConfigEntities entity = ((EInvoiceConfigEntities)((BaseModuleERP)Module).CurrentModuleEntity);
            switch (CurrentSection)
            {
                case "EInvoiceConfig":
                    entity.SaveModuleObjects();
                    break;
            }
            if (isSuccess)
            {
                MessageBox.Show(CompanyConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
