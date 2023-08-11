using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPurchaseOrderSter : BaseReport
    {
        public RPPurchaseOrderSter()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
