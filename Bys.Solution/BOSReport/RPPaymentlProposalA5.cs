using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentlProposalA5 : BaseReport
    {
        public RPPaymentlProposalA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
