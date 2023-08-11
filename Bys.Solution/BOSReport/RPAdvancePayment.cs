using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAdvancePayment : BaseReport
    {
        public RPAdvancePayment()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
