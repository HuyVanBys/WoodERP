using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_PurchaseReceiptForAccounting : BaseReport
    {
        public RP_PurchaseReceiptForAccounting()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
