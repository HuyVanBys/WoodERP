using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_BatchProduct : BaseReport
    {
        public RP_BatchProduct()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
