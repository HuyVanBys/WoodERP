using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AliasConfig.UI
{
    /// <summary>
    /// Summary description for DMALS100
    /// </summary>
    public partial class DMALS100 : BOSERPScreen
    {

        public DMALS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            ((Modules.AliasConfig.AliasConfigModule)this.Module).Search();
        }

        private void fld_btnFormatSearch_Click(object sender, EventArgs e)
        {
            string tableName = fld_txtTableFormatName.Text;
            string moduleName = fld_txtModuleName.Text;

            if (string.IsNullOrWhiteSpace(tableName) && string.IsNullOrWhiteSpace(moduleName))
            {
                MessageBox.Show("Điều kiên lọc không hợp lệ.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ((AliasConfigModule)this.Module).GetFormatTable(tableName, moduleName);
        }

        private void fld_btnSaveFieldFormat_Click(object sender, EventArgs e)
        {
            ((AliasConfigModule)this.Module).SaveSaveFieldFormat();
        }

        private void fld_btnSaveAliasConfigs_Click(object sender, EventArgs e)
        {
            ((AliasConfigModule)this.Module).SaveAliasConfig();
        }

        private void fld_btnSaveCurrency_Click(object sender, EventArgs e)
        {
            ((AliasConfigModule)this.Module).SaveCurrencyConfig();
        }

        private void fld_btnSaveICDepartmentFormats_Click(object sender, EventArgs e)
        {
            ((AliasConfigModule)this.Module).SaveDepartmentFormatConfig();
        }
    }
}
