using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP028 : BaseReport
    {
        public RP028()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
