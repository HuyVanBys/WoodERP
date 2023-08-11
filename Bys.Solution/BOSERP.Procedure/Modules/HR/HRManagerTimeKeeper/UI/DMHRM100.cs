using System;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
    /// <summary>
    /// Summary description for DMHRM100
    /// </summary>
    public partial class DMHRM100 : BOSERPScreen
    {

        public DMHRM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMHRM100_Load(object sender, EventArgs e)
        {

        }

        private void fld_btnLoadData_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).DownloadAndShowData();
        }

        private void fld_btnReadDat_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).ReadFileTxt();
        }

        private void fld_btnExport_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).Export();
        }

        private void fld_btnViewData_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).ViewHistory();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).ImportProductFromRawExcel();
        }

        private void fld_btnQuickImport_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).ActionQuickImportTimeSheet();
        }
    }
}
