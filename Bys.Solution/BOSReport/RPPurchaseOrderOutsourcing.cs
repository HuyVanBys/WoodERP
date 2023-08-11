using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPurchaseOrderOutsourcing : BaseReport
    {
        public RPPurchaseOrderOutsourcing()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
