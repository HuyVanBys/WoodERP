using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP196 : BaseReport
    {
        public RP196()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
