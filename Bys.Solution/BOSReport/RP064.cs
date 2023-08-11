using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP064 : BaseReport
    {
        public RP064()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
