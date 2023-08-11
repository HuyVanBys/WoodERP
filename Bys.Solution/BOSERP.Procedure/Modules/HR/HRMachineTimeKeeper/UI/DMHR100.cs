using System;

namespace BOSERP.Modules.MachineTimeKeeper.UI
{
    /// <summary>
    /// Summary description for DMHR100
    /// </summary>
    public partial class DMHR100 : BOSERPScreen
    {

        public DMHR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            //((MachineTimeKeeperModule)this.Module).DisConnectAll();
        }

        private void fld_btnConnect_Click(object sender, EventArgs e)
        {
            ((MachineTimeKeeperModule)this.Module).TestConnect();
        }

        private void fld_btnDisconnect_Click(object sender, EventArgs e)
        {
            //((MachineTimeKeeperModule)this.Module).DisConnect();
        }

        private void fld_btnLoadData_Click(object sender, EventArgs e)
        {
            //((MachineTimeKeeperModule)this.Module).DownloadAndShowData();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            //((MachineTimeKeeperModule)this.Module).SaveData();
        }

        private void fld_btnReadTxt_Click(object sender, EventArgs e)
        {
            //((MachineTimeKeeperModule)this.Module).ReadFileTxt();
        }

        private void fld_btnConnectAll_Click(object sender, EventArgs e)
        {
            //((MachineTimeKeeperModule)this.Module).ConnectAll();
        }
    }
}
