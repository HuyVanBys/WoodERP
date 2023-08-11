using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTransferDataA4 : BaseReport
    {
        public RPTransferDataA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
