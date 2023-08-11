using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPCancelVoucher : BaseReport
    {
        public RPCancelVoucher()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
