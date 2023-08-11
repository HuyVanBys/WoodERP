using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentProposalA5 : BaseReport
    {
        public RPPaymentProposalA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
