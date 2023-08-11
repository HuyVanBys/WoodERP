using BOSERP;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RPPurchaseOrderShipment : BaseReport
    {
        public RPPurchaseOrderShipment()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
