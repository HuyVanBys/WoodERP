using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP068 : BaseReport
    {
        public RP068()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
