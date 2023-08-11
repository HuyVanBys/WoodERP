using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPCancelPurchaseProposal : BaseReport
    {
        public RPCancelPurchaseProposal()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
