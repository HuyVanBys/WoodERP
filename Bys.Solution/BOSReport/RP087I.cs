using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP087I : BaseReport
    {
        public RP087I()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
