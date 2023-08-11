using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_DeliveryNote : BaseReport
    {
        public RP_DeliveryNote()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

    }
}
