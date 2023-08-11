using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_PurchaseReceipt : BaseReport
    {
        public RP_PurchaseReceipt()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
