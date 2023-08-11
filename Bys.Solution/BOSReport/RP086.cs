using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP086 : BaseReport
    {
        public RP086()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
