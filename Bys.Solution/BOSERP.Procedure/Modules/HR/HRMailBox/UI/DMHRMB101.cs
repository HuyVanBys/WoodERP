using System.Windows.Forms;

namespace BOSERP.Modules.HRMailBox.UI
{
    /// <summary>
    /// Summary description for DMHRMB101
    /// </summary>
    public partial class DMHRMB101 : BOSERPScreen
    {

        public DMHRMB101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_wbsMailContent_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((HRMailBoxModule)Module).GetLink(fld_wbsMailContent);
        }
    }
}
