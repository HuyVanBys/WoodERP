using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP027 : BaseReport
    {
        public RP027()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
