using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP009 : BaseReport
    {
        public RP009()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
