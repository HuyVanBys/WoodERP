using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS102
    /// </summary>
    public partial class DMCS102 : BOSERPScreen
    {

        public DMCS102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProductTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).AddObjectFromProductTemplates();
        }

        private void fld_btnDeleteProductTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).ProductTemplateConfigsTreeList();
        }

        private void fld_tclProductTabContrl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (fld_tclProductTabControl.SelectedTabPage.Name != "fld_tabProductTemplates")
                return;

            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).InvalidateProductTemplate();
        }

        private void fld_btn_SavePackageNumering_Click(object sender, EventArgs e)
        {
            bool isSuccess = ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveGeneratePackageConfig();
            if (isSuccess)
            {
                MessageBox.Show(CompanyConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fld_btnSaveProductNoConfigs_Click(object sender, EventArgs e)
        {
            bool isSuccess = ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveGenerateProductNoConfig();
            if (isSuccess)
            {
                MessageBox.Show(CompanyConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
