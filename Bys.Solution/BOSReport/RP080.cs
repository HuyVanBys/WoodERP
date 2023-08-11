using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP080 : BaseReport
    {

        public RP080()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
