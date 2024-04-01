using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ProductionPlanningOrderBKV : BaseReport
    {
        public RP_ProductionPlanningOrderBKV()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
