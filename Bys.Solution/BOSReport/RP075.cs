using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP075 : BaseReport
    {
        public RP075()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
