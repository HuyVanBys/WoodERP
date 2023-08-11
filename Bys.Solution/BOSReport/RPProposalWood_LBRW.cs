using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProposalWoodLBRW : BaseReport
    {
        public RPProposalWoodLBRW()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
