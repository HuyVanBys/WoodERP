using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_BatchProductPaint : BaseReport
    {
        public RP_BatchProductPaint()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
