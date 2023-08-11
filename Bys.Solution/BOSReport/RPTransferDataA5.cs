using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTransferDataA5 : BaseReport
    {
        public RPTransferDataA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
