using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP044 : BaseReport
    {
        public RP044()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
