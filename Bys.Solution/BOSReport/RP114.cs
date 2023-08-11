using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP114 : BaseReport
    {
        public RP114()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
