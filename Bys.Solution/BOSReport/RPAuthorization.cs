using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAuthorization : BaseReport
    {
        public RPAuthorization()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
