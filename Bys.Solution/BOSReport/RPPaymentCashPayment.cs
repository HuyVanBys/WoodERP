using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentCashPayment : BaseReport
    {
        public RPPaymentCashPayment()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
