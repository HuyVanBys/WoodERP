using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAssetDecreasing : BaseReport
    {
        public RPAssetDecreasing()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
