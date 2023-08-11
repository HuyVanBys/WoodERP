using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP052I : BaseReport
    {
        public RP052I()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
