using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ProductionPlanningBKV : BaseReport
    {
        public RP_ProductionPlanningBKV()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
