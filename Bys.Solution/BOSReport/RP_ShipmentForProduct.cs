using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ShipmentForProduct : BaseReport
    {
        public RP_ShipmentForProduct()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
