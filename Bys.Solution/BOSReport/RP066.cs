using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP066 : BaseReport
    {
        public RP066()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
