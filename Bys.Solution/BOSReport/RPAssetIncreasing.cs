using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAssetIncreasing : BaseReport
    {
        public RPAssetIncreasing()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
