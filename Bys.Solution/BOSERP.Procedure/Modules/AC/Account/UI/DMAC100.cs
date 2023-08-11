using System.Windows.Forms;

namespace BOSERP.Modules.Account.UI
{
    /// <summary>
    /// Summary description for DMAC100
    /// </summary>
    public partial class DMAC100 : BOSERPScreen
    {

        public DMAC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_trlACAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ((AccountModule)Module).ShowContextMenu(e);
        }
    }
}
