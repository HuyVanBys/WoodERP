using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInvoiceIn : BaseReport
    {
        public RPInvoiceIn()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
