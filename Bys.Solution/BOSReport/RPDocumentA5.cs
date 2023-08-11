using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPDocumentA5 : BaseReport
    {
        public RPDocumentA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
