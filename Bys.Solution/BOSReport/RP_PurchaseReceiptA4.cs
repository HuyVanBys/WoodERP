using BOSERP;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RP_PurchaseReceiptA4 : BaseReport
    {
        public RP_PurchaseReceiptA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
