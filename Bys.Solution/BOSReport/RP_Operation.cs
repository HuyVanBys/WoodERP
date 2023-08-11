using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_Operation : BaseReport
    {
        public RP_Operation()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
