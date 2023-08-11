using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP055 : BaseReport
    {
        public RP055()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
