using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_BatchProductBKV : BaseReport
    {
        public RP_BatchProductBKV()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
