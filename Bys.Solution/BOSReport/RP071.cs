using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP071 : BaseReport
    {
        public RP071()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
