using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPDeposit : BaseReport
    {
        public RPDeposit()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
