using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPurchaseOrderMaterialsA4 : BaseReport
    {
        public RPPurchaseOrderMaterialsA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
