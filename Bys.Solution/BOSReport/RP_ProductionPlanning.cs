using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ProductionPlanning : BaseReport
    {
        public RP_ProductionPlanning()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
