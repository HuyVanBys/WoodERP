using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP014 : BaseReport
    {
        public RP014()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
