using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP087 : BaseReport
    {
        public RP087()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
