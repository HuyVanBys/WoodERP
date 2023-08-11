using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPReceipt : BaseReport
    {
        public RPReceipt()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
