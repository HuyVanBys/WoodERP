using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP045 : BaseReport
    {
        public RP045()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
