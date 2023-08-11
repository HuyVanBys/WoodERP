using System;

namespace BOSERP.Modules.SaleForecast.UI
{
    /// <summary>
    /// Summary description for DMSF102
    /// </summary>
    public partial class DMSF102 : BOSERPScreen
    {

        public DMSF102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).BrowseFile();
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).SaveSaleForecastDocumentOnServer();
        }

        private void fld_btnViewTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).ViewFile();
        }

        private void fld_btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            ((Modules.SaleForecast.SaleForecastModule)this.Module).DeleteFile();
        }
    }
}
