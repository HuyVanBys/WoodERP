using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP008 : BaseReport
    {
        public RP008()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
