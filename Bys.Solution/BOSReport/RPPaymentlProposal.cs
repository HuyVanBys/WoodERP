using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentlProposal : BaseReport
    {
        public RPPaymentlProposal()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
