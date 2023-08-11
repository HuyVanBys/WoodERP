using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP084 : BaseReport
    {
        public RP084()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
