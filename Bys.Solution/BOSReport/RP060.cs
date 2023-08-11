using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP060 : BaseReport
    {
        public RP060()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
