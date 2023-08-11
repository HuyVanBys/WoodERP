using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_PurchaseReceiptForAccountingA4 : BaseReport
    {
        public RP_PurchaseReceiptForAccountingA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
