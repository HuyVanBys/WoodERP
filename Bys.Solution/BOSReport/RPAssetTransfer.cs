using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAssetTransfer : BaseReport
    {
        public RPAssetTransfer()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
