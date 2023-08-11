using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBatchProduct : BaseReport
    {
        public RPBatchProduct()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
