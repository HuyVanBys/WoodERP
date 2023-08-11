using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAdvancePaymentVoucher : BaseReport
    {
        public RPAdvancePaymentVoucher()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
