using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP070Details : BaseReport
    {
        public RP070Details()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
