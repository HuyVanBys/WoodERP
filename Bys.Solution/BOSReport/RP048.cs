using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP048 : BaseReport
    {
        public RP048()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
