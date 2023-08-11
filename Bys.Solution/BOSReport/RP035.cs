using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP035 : BaseReport
    {
        public RP035()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
