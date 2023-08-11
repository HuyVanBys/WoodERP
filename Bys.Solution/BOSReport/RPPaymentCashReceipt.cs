using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentCashReceipt : BaseReport
    {
        public RPPaymentCashReceipt()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
