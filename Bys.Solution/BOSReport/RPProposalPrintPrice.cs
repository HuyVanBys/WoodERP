using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProposalPrintPrice : BaseReport
    {
        public RPProposalPrintPrice()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
