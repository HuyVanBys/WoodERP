using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_Shipment_CCDC : BaseReport
    {
        public RP_Shipment_CCDC()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
