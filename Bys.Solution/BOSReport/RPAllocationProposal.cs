using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAllocationProposal : BaseReport
    {
        public RPAllocationProposal()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
