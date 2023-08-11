using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBankTransaction : BaseReport
    {
        public RPBankTransaction()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
