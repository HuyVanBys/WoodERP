using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAccountingBill : BaseReport
    {
        public RPAccountingBill()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
