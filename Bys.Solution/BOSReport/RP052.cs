using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP052 : BaseReport
    {
        public RP052()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
