using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP036 : BaseReport
    {
        public RP036()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
