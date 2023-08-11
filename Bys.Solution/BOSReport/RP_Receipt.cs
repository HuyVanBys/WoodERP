using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_Receipt : BaseReport
    {
        public RP_Receipt()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
