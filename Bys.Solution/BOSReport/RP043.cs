using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP043 : BaseReport
    {
        public RP043()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
