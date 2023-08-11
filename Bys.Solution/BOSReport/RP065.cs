using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP065 : BaseReport
    {
        public RP065()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
