using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP015 : BaseReport
    {
        public RP015()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
