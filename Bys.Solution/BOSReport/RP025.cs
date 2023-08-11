using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP025 : BaseReport
    {
        public RP025()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
