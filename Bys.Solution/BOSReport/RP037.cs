using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP037 : BaseReport
    {
        public RP037()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
