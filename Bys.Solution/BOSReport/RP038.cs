using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP038 : BaseReport
    {
        public RP038()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
