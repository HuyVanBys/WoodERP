using System;

namespace BOSERP.Modules.ProductConstant.UI
{
    /// <summary>
    /// Summary description for DMPC101
    /// </summary>
    public partial class DMPC117 : BOSERPScreen
    {

        public DMPC117()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"ftp://192.168.1.3");
        }

    }
}