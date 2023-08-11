using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProposal : BaseReport
    {
        public RPProposal()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
