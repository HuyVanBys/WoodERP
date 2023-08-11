using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTransferData : BaseReport
    {
        public RPTransferData()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
