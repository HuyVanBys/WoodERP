using BOSERP;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RPRetrunSupplier : BaseReport
    {
        public RPRetrunSupplier()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
