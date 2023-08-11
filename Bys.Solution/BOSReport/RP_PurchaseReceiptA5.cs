using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_PurchaseReceiptA5 : BaseReport
    {
        public RP_PurchaseReceiptA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
