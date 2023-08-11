using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP001SaleReceipt : BaseReport
    {
        public RP001SaleReceipt()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
