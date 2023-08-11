using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP034 : BaseReport
    {
        public RP034()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
