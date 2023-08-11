using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP026 : BaseReport
    {
        public RP026()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
