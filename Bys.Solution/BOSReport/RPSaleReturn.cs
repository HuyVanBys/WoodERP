using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPSaleReturn : BaseReport
    {
        public RPSaleReturn()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
