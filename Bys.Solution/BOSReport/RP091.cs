using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP091 : BaseReport
    {
        public RP091()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
