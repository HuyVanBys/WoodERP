using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPGetInvoice : BaseReport
    {
        public RPGetInvoice()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
