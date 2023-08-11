using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP053 : BaseReport
    {
        public RP053()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
