using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPReceiptVoucherA4 : BaseReport
    {
        public RPReceiptVoucherA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
