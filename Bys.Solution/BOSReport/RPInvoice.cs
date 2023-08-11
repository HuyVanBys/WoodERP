using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInvoice : BaseReport
    {
        public RPInvoice()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
