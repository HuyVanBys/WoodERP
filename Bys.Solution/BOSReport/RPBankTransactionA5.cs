using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBankTransactionA5 : BaseReport
    {
        public RPBankTransactionA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
