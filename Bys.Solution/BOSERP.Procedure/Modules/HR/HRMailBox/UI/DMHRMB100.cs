using System.Windows.Forms;

namespace BOSERP.Modules.HRMailBox.UI
{
    /// <summary>
    /// Summary description for DMHRMB100
    /// </summary>
    public partial class DMHRMB100 : BOSERPScreen
    {

        public DMHRMB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_wbsContentMail100_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((HRMailBoxModule)Module).GetLink(fld_wbsContentMail100);
        }
    }
}
