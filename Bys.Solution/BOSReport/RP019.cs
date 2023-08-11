using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP019 : BaseReport
    {
        public RP019()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
