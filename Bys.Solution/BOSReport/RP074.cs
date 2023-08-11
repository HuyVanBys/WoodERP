using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP074 : BaseReport
    {
        public RP074()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
