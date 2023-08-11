using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP082 : BaseReport
    {
        public RP082()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
