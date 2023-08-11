using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP070 : BaseReport
    {
        public RP070()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
