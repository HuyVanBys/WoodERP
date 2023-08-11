using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP018 : BaseReport
    {
        public RP018()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
