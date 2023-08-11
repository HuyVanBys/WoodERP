using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentProposal : BaseReport
    {
        public RPPaymentProposal()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
