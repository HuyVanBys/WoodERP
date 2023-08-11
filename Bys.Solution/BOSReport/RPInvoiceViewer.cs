using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInvoiceViewer : BaseReport
    {
        public RPInvoiceViewer()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
