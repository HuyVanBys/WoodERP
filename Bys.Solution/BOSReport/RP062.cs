using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP062 : BaseReport
    {
        public RP062()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
