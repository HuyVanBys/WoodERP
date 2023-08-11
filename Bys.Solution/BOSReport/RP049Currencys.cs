using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP049Currencys : BaseReport
    {
        public RP049Currencys()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
