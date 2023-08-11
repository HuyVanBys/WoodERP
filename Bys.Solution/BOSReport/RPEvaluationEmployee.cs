using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPEvaluationEmployee : BaseReport
    {
        public RPEvaluationEmployee()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
