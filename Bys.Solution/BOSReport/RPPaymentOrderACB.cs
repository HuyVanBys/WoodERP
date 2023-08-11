using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentOrderACB : BaseReport
    {
        public RPPaymentOrderACB()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
