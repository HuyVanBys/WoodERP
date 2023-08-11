using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProposalWood : BaseReport
    {
        public RPProposalWood()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
