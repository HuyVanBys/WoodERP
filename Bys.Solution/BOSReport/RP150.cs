using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP150 : BaseReport
    {
        public RP150()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
