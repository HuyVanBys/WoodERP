using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP040 : BaseReport
    {
        public RP040()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
