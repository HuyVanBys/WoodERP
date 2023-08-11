using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP049 : BaseReport
    {
        public RP049()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
