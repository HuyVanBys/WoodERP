using BOSERP;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RPPOSOutStock : BaseReport
    {
        public RPPOSOutStock()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
