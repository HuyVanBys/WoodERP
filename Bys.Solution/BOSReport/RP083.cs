using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP083 : BaseReport
    {
        public RP083()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
