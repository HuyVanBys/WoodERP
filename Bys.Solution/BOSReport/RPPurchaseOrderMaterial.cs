using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPurchaseOrderMaterial : BaseReport
    {
        public RPPurchaseOrderMaterial()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
